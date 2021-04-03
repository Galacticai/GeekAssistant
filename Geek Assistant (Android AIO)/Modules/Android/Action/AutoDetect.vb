Imports Managed

Module AutoDetect

    Private ErrorInfo As (lvl As Integer, msg As String)
    Public Sub Run(Optional Silent As Boolean = False)

        ' (ROOT) 
        ' Remove screen lock: "adb shell su -c rm /data/system/*.key" && "adb shell su -c rm /data/system/locksettings*"
        ' Hot reboot: "adb shell su -c busybox killall system_server"
        ' Clear dulvik cache: "adb shell su -c rm -R /data/dalvik-cache"
        ' Factory Reset: "adb shell su -c recovery --wipe_data"

        Working = True
        ErrorCodeTrack("AD-00") ' adb Auto - Begin
        If Not Silent Then LogEvent("Auto Detect", 2)
        Main.ProgressBar.Value = 0
        Try

            If Not Silent Then GA_SetProgressText.Run("Clearing previous device information.", -1)
            ErrorInfo = (10, "We had trouble while clearing previous device information.")
            ResetDeviceInfo()
            Main.ProgressBar.Value = 2

            If Not Silent Then GA_SetProgressText.Run("Preparing the environment... Please be patient.", -1)
            ErrorInfo = (10, "Things didn't go as planned while preparing the environment.")
            madbStart()
            Main.ProgressBar.Value = 5

            If Not Silent Then GA_SetProgressText.Run("Counting the connected devices...", -1)
            ErrorInfo = (10, "Math...oh no we couldn't count the devices.")
            If madb_GetDeviceCount() = 0 Then
                Main.DeviceState_Label.Text = "Disconnected"
                ErrorInfo = (0, $"We haven't found any device.{vbCrLf}{My.Resources.TroubleshootConnection}")
                ErrorCodeTrack("AD-D0") ' adb Auto - Device 0 (0 devices connected)
                Throw New Exception
            ElseIf madb_GetDeviceCount() > 1 Then
                Main.DeviceState_Label.Text = "Multiple"
                ErrorInfo = (0, $"Oh there are several devices.{vbCrLf}Would you mind keeping 1 and disconnecting the rest please?")
                ErrorCodeTrack("AD-DX") ' adb Auto - Device X-number (More than 1 connected)
                Throw New Exception
            End If
            'DeviceInfoSave(Nothing, "Connected", Nothing, -1, 0, 0, 0)

            Main.ProgressBar.Value = 7
            If Not Silent Then GA_SetProgressText.Run("Communicating with your device...", -1)
            ErrorInfo = (1, "We have trouble reading your device.")

            Dim DeviceState_String As String = "Device is "

            Select Case madb_GetDeviceState()
                Case 5 'unknown
                    Main.DeviceState_Label.Text = "Unknown"
                    DeviceState_String &= $"in an unknown state...{vbCrLf}{My.Resources.TroubleshootConnection}"
                    ErrorInfo = (-1, DeviceState_String)
                    ErrorCodeTrack("AD-DU") ' adb Auto - Device 0 (No devices connected)
                    Throw New Exception

                Case 2 'offline
                    Main.DeviceState_Label.Text = "Offline"
                    DeviceState_String &= $"offline. {vbCrLf}{My.Resources.TroubleshootConnection}"
                    ErrorInfo = (0, DeviceState_String)
                    ErrorCodeTrack("AD-DO") ' adb Auto - Device Offline (PC not allowed to debug device)
                    Throw New Exception
                Case 0 'recovery
                    Main.DeviceState_Label.Text = "Recovery mode"
                    DeviceState_String &= $"in recovery mode.{vbCrLf}Please enter adb mode and try again." 'Please enter adb mode or reboot to system and try again."
                    ErrorInfo = (0, DeviceState_String)
                    ErrorCodeTrack("AD-DR") ' adb Auto - Device Recovery
                    Throw New Exception
                Case 4 'download
                    Main.DeviceState_Label.Text = "Download mode"
                    DeviceState_String &= $"in download mode.{vbCrLf}Please enter adb mode and try again."
                    ErrorInfo = (0, DeviceState_String)
                    ErrorCodeTrack("AD-DD") ' adb Auto - Device Download
                    Throw New Exception

            ' ^^   All the above will jump to > Catch e As Exception   ^^
            ' vv            All the below will continue code           vv

                Case 1 'bootloader 
                    DeviceState_String &= $"in fastboot mode."
                    Main.DeviceState_Label.Text = "Fastboot mode"
                    ErrorCodeTrack("AD-DF") ' adb Auto - Device Fastboot
                    Main.ProgressBar.Value = 10
                    If Not Silent Then
                        Dim DeviceInFastboot_ContinueAsk = GA_infoAsk.Run($"{DeviceState_String}",
                                                                      $"We cannot read much in this mode.{vbCrLf}Do you want to continue detection in fastboot mode?",
                                                                       "Continue", "Cancel")
                        If DeviceInFastboot_ContinueAsk Then


                            ErrorInfo.lvl = 1
                            DoMsg(1, $"Oh no this is currently unavailable.{vbCrLf}{My.Resources.FeatureUnavailable }", 2)
                            'later maybe will be implemented 
                            '''''''''''''''''''''''''''''''''

                        Else
                            GA_SetProgressText.Run("Detection cancelled by user.", 0)
                        End If
                    End If

                Case 3 'online
                    ErrorCodeTrack("AD-D1") ' adb Auto - Device 1 (1 Device connected in adb mode)
                    Main.ProgressBar.Value = 10
                    ErrorInfo.lvl = 10

                    Dim dev As Adb.Device = madb_GetListOfDevice(0) 'Set dev as first device

                    DeviceState_String &= $"in adb mode."
                    Main.DeviceState_Label.Text = "Connected (ADB)"
                    Main.ProgressBar.Value = 11


                    If Not Silent Then GA_SetProgressText.Run("Retrieving device manufacturer, model, and codename...", -1)
                    Dim Manufacturer_CommandResultReceiver As New Adb.CommandResultReceiver
                    Main.ProgressBar.Value = 13
                    dev.ExecuteShellCommand($"getprop ro.product.manufacturer", Manufacturer_CommandResultReceiver)
                    Main.ProgressBar.Value = 15
                    My.Settings.DeviceManufacturer = FixManufacturerString(Manufacturer_CommandResultReceiver.Result)
                    My.Settings.Save()
                    Main.Manufacturer_ComboBox.Text = My.Settings.DeviceManufacturer
                    If Not Silent Then LogAppendText($" > {My.Settings.DeviceManufacturer} {dev.Model} ({dev.Product})", 1)
                    Main.ProgressBar.Value = 17

                    If Not Silent Then GA_SetProgressText.Run("Retrieving device serial#...", -1)
                    My.Settings.DeviceSerial = dev.SerialNumber
                    My.Settings.Save()
                    If Not Silent Then LogAppendText($" | Serial: {My.Settings.DeviceSerial}", 1)
                    Main.ProgressBar.Value = 20

                    If Not Silent Then GA_SetProgressText.Run("Retrieving root state...", -1)
                    My.Settings.DeviceRooted = dev.CanSU
                    My.Settings.Save()
                    Main.Rooted_Checkbox.Checked = My.Settings.DeviceRooted
                    If Not Silent Then LogAppendText($" | Rooted: {txt_ConvertBooleanYesNo(My.Settings.DeviceRooted)}", 1)
                    Main.ProgressBar.Value = 25

                    If Not Silent Then GA_SetProgressText.Run("Retrieving bootloader unlock support state...", -1)
                    Dim BLunlockable_CommandResultReceiver As New Adb.CommandResultReceiver
                    Main.ProgressBar.Value = 26
                    dev.ExecuteShellCommand($"getprop ro.oem_unlock_supported", BLunlockable_CommandResultReceiver)
                    My.Settings.DeviceBootloaderUnlockSupported = BLunlockable_CommandResultReceiver.Result
                    My.Settings.Save()
                    Main.BootloaderUnlockable_CheckBox.Checked = My.Settings.DeviceBootloaderUnlockSupported
                    Main.ProgressBar.Value = 27
                    If Not Silent Then LogAppendText($" | Bootloader Unlock allowed: {txt_ConvertBooleanYesNo(My.Settings.DeviceBootloaderUnlockSupported)}", 1)
                    Main.ProgressBar.Value = 30

                    If Not Silent Then GA_SetProgressText.Run("Retrieving Android API level...", -1)
                    Dim API_CommandResultReceiver As New Adb.CommandResultReceiver
                    Main.ProgressBar.Value = 31
                    dev.ExecuteShellCommand($"getprop {Adb.Device.PROP_BUILD_API_LEVEL}", API_CommandResultReceiver)
                    Main.ProgressBar.Value = 32
                    My.Settings.DeviceAPILevel = Convert.ToInt32(API_CommandResultReceiver.Result)
                    My.Settings.Save()
                    Main.AndroidVersion_ComboBox.Text = ConvertAPILevelToAVer(My.Settings.DeviceAPILevel)(1)
                    If Not Silent Then GA_SetProgressText.Run("Converting API level to Android name...", -1)
                    Main.ProgressBar.Value = 33
                    If Not Silent Then LogAppendText($" | Android Version: {ConvertAPILevelToAVer(My.Settings.DeviceAPILevel)(0)} (API: {My.Settings.DeviceAPILevel})", 1)
                    Main.ProgressBar.Value = 35

                    If Not Silent Then GA_SetProgressText.Run("Retrieving battery level...", -1)
                    Main.ProgressBar.Value = 36
                    Dim batteryString As String
                    If dev.GetBatteryInfo.Present Then
                        My.Settings.DeviceBatteryLevel = dev.GetBatteryInfo.Level
                        batteryString = $"{My.Settings.DeviceBatteryLevel}%"
                    Else
                        My.Settings.DeviceBatteryLevel = -1 'no level. Not present
                        If Not Silent Then GA_SetProgressText.Run("Battery not present!", -1)
                        batteryString = "❌"
                    End If
                    My.Settings.Save()
                    Main.ProgressBar.Value = 38
                    If Not Silent Then LogAppendText($" | Battery: {batteryString}", 1)
                    Main.ProgressBar.Value = 40

                    If Not Silent Then GA_SetProgressText.Run(DeviceState_String, -1) 'This is after retrieving info to stay written in Progress Text



            End Select

            Main.ProgressBar.Value = 100
        Catch ex As Exception
            GA_PleaseWait.Run(False) 'Close before error dialog
            If Not Silent Then
                DoMsg(ErrorInfo.lvl, ErrorInfo.msg, 2, ex.ToString)
            Else
                Main.DoNeutral()
            End If
        End Try
        My.Settings.DeviceState = Main.DeviceState_Label.Text
        GA_PleaseWait.Run(False) 'Close if Try was successful
        Working = False
    End Sub

End Module
