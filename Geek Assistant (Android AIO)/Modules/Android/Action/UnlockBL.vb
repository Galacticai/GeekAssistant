Imports Managed

Module UnlockBL

    'Private ErrorInfo As (lvl As Integer, msg As String)


    '' https://source.android.com/devices/bootloader/locking_unlocking


    Public Sub Run()

        Dim Cancelled As Boolean = False

        If Working Then
            DoMsg(1, "We need to wait the current process to finish first...", 2)
            Exit Sub
        End If
        Main.ProgressBar.Value = 0
        Working = True
        ErrorCodeTrack("UB-00") ' Unlock Bootloader - Start
        LogEvent("Unlock Bootloader", 2)
        GA_PleaseWait.Run(True)


        Try


            '' check if fb compatible 
            Main.ProgressBar.Value = 10
            If Not CheckFastbootCompatible.Run("UB") Then
                Cancelled = True
                Throw New Exception
            End If

            Main.ProgressBar.Value = 15
            GA_SetProgressText.Run("Checking bootloader unlock support status...", -1)
            If Not My.Settings.DeviceBootloaderUnlockSupported Then
                Cancelled = True
                '' cancel if not unlockable
                ErrorCodeTrack("UB-BLX") ' Unlock Bootloader - Bootloader X (BLU is not supported)
                ErrorInfo = (1, "Oh no... Bootloader unlock is not supported on your device.") 'you can enable with checkbox
                Throw New Exception
            End If

            Main.ProgressBar.Value = 17
            Dim dev As Adb.Device = madb_GetListOfDevice(0)


            Main.ProgressBar.Value = 25
            '' detected but not in fastboot
            GA_SetProgressText.Run("Checking connection status...", -1)
            If My.Settings.DeviceState = "Connected (ADB)" Then ''''''SUCCESS
                Main.ProgressBar.Value = 30
                GA_SetProgressText.Run("Device is connected (ADB).", -1)
                If GA_infoAsk.Run("Rebooting your device!",
                                     $"We need to reboot your device to access fastboot mode and proceed with unlocking.{vbCrLf}{vbCrLf}" &
                                       $"Please save your work then confirm the reboot.",
                                      "Ready! Let's reboot", "Cancel") Then ''''''SUCCESS
                    Main.ProgressBar.Value = 35
                    dev.Reboot("bootloader")
                    Main.ProgressBar.Value = 40
                    GA_SetProgressText.Run("Waiting for your device to enter fastboot...", -1)
                    fbDo("wait-for-device") '''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    Main.ProgressBar.Value = 45
                    GoTo DeviceInFastboot ''''''SUCCESS
                Else
                    Main.ProgressBar.Value = 35
                    Cancelled = True
                    ErrorCodeTrack("UB-uX") ' Unlock Bootloader - Unlock X (BLU cancelled)
                    ErrorInfo = (0, "You have cancelled the process.")
                    LogEvent("Unlock Bootloader Cancelled", 1)
                    Throw New Exception
                End If

            ElseIf Not My.Settings.DeviceState = "Fastboot mode" Then
                Main.ProgressBar.Value = 30
                Cancelled = True

                If My.Settings.DeviceState = "Disconnected" Then 'failsafe  
                    GA_SetProgressText.Run("Device is disconnected.", 0)
                    ErrorCodeTrack("UB-xX") ' Unlock Bootloader - x error X (device disconnected)
                    ErrorInfo = (1, $"We lost contact with your device!{vbCrLf}" & My.Resources.TroubleshootConnection)
                Else 'not adb and not fastboot and not disconnected 
                    GA_SetProgressText.Run("Device is not in adb or fastboot mode.", 0)
                    ErrorCodeTrack("UB-rX") ' Unlock Bootloader - reboot X (Device is not in adb or fastboot (cant reboot to fastboot))
                    ErrorInfo = (0, $"We cannot reboot into fastboot while your device is in {My.Settings.DeviceState}.{vbCrLf}" & My.Resources.TroubleshootConnection)
                End If
                Main.ProgressBar.Value = 32
                Throw New Exception
            End If



            ' check bootloader state

DeviceInFastboot:

            Main.ProgressBar.Value = 45
            Cancelled = False 'failsafe

            'If Not My.Settings.DeviceBootloaderUnlocked Then

            '    ErrorInfo = (1, "Sorry we can't proceed with a locked bootloader")
            '    'Throw New Exception
            'End If

            Main.ProgressBar.Value = 46
            '' if unlockable  make sure it is unlocked ("fastboot oem device-info" -> "Device unlocked: true")
            GA_SetProgressText.Run("Checking current bootloader state.", -1)

            If fbDo("oem device-info").Contains("Device unlocked: true") Then
                Main.ProgressBar.Value = 100
                Cancelled = True
                ErrorCodeTrack("UB-U1") ' Unlock Bootloader - Unlock 1 (BL Unlocked already)
                ErrorInfo = (0, $"Hooray! The Bootloader is unlocked already.{vbCrLf}No need to unlock it once more.")
                Throw New Exception
            End If


            Main.ProgressBar.Value = 50
            ErrorCodeTrack("UB-UXn") ' Unlock Bootloader - Unlock X new (Attempt BLU (new method))
            GA_SetProgressText.Run("Attempting to unlock bootloader...", -1)
            fbDo($"flashing unlock")
            If LCase(fbOutput).Contains("err") Or LCase(fbOutput).Contains("fail") Then
                Main.ProgressBar.Value = 52

                ErrorCodeTrack("UB-UXo") ' Unlock Bootloader - Unlock X old (Attempt BLU (old method)) 
                GA_SetProgressText.Run("New unlock method failed... Attempting old method...", -1)

                Main.ProgressBar.Value = 55
                fbDo($"oem unlock")

                If LCase(fbOutput).Contains("err") Or LCase(fbOutput).Contains("fail") Then
                    Main.ProgressBar.Value = 57
                    ErrorInfo = (10, $"Failed to unlock your device bootloader.")
                    Throw New Exception(fbOutput)
                End If

            End If
            Main.ProgressBar.Value = 80
            LogAppendText(-1, fbOutput)
            GA_SetProgressText.Run("Process finished. Rebooting...", -1)
            Main.ProgressBar.Value = 100
            fbDo("reboot")

        Catch ex As Exception
            GA_PleaseWait.Run(False) 'Close before error dialog 
            DoMsg(ErrorInfo.lvl, ErrorInfo.msg, 2, ex.ToString)


            If Not Cancelled Then _
                If My.Settings.DeviceState = "Connected (ADB)" Or My.Settings.DeviceState = "Fastboot mode" Then _
                    If GA_infoAsk.Run("We are sorry... Seems like we failed.",
                                  "Do you want to reboot your device?",
                                  "Reboot", "Do Nothing") Then _
                        fbDo("reboot")
        End Try

        GA_PleaseWait.Run(False) 'Close if Try was successful
        Working = False
    End Sub
End Module
