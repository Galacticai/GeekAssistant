Imports Managed

Module FlashFiles

    Private ErrorInfo As (lvl As Integer, msg As String)
    Public Sub Run(zip As String)
        If Working Then
            DoMsg(1, "We need to wait the other process to finish first...", 2)
            Exit Sub
        End If
        If zip Is Nothing Then ' check zip string 
            DoMsg(10, "File name is not set!", 1)
            Exit Sub
        End If
        Working = True
        ErrorCodeTrack("FF-00")
        LogEvent("Flash ZIP", 2)
        GA_PleaseWait.Run(True)


        Try

            '' check if fb compatible 
            If Not CheckFastbootCompatible.Run("FF") Then Throw New Exception

            Dim dev As Adb.Device = madb_GetListOfDevice(0)


            '' detected but not in fastboot
            If My.Settings.DeviceState = "Connected (ADB)" Then
                If GA_infoAsk.Run("Rebooting your device!",
                                     $"Now we need to reboot your device into fastboot mode to proceed with the installation.{vbCrLf}{vbCrLf}" &
                                       $"Please save your work then confirm the reboot.",
                                      "Reboot into fastboot", "Cancel") Then
                    dev.Reboot("bootloader")
                    GA_SetProgressText.Run(-1, "Waiting for your device to enter fastboot...")
                    fbDo("wait-for-device") '''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    GoTo DeviceInFastboot
                Else
                    ErrorCodeTrack("FF-uX")
                    ErrorInfo = (0, "You have cancelled the process.")
                    LogEvent("Flash ZIP Cancelled", 1)
                    Throw New Exception
                End If

            ElseIf Not My.Settings.DeviceState = "Fastboot mode" Then

                If My.Settings.DeviceState = "Disconnected" Then 'failsafe
                    ErrorCodeTrack("FF-xX")
                    ErrorInfo = (1, $"We lost contact with your device!{vbCrLf}" & My.Resources.TroubleshootConnection)
                Else 'not adb and not fastboot and not disconnected
                    ErrorCodeTrack("FF-rX")
                    ErrorInfo = (0, $"We cannot reboot into fastboot while your device is in {My.Settings.DeviceState}.{vbCrLf}" & My.Resources.TroubleshootConnection)
                End If
                Throw New Exception
            End If



            ' check bootloader state

DeviceInFastboot:
            If Not My.Settings.DeviceBootloaderUnlockSupported Then
                '' cancel if not unlockable
                ErrorCodeTrack("FF-BLX")
                ErrorInfo = (1, "Oh no... Bootloader unlock is not supported.") 'you can enable with checkbox
                Throw New Exception
            End If


            'If Not My.Settings.DeviceBootloaderUnlocked Then

            '    ErrorInfo = (1, "Sorry we can't proceed with a locked bootloader")
            '    'Throw New Exception
            'End If

            '' if unlockable  make sure it is unlocked ("fastboot oem device-info" -> "Device unlocked: true")
            fbDo("oem device-info")
            If Not fbOutput.Contains("Device unlocked: true") Then
                ErrorCodeTrack("FF-BLuX")
                ErrorInfo = (1, $"Your device bootloader is locked.{vbCrLf}You have to unlock the bootloader first or you will brick your device.")
                Throw New Exception
            End If
            'If Not GA_infoAsk.Run("Confirming bootloader state",
            '                      $"We have detected that your device bootloader supports unlocking; " &
            '                      $"But we can't check if it is unlocked unless you reboot into fastboot mode.{vbCrLf}{vbCrLf}" &
            '                        $"Did you make sure you have unlocked it?{vbCrLf}{vbCrLf}{vbCrLf}" &
            '                          $"⚠ Warning: Locked bootloader can brick your device upon modification.",
            '                      "Yes Let's Go", "Cancel") Then

            '    ErrorInfo = (0, " ")
            '    Throw New Exception
            'End If


            '' push zip to /sdcard/0/GeekAssistant tmp dir
            ErrorCodeTrack("FF-F")
            fbDo($"flash ""{zip}""")
            If fbOutput.Contains("error") Then
                ErrorCodeTrack("FF-BLuX")
                ErrorInfo = (1, $"Your device bootloader is locked.{vbCrLf}You have to unlock the bootloader first.")
                Throw New Exception
            End If
            LogAppendText(-1, fbOutput)
            'Push(zip)
            'Dim zipInAndroid = $"/sdcard/0/GeekAssistant/{IO.Path.GetFileName(zip)}"
            ErrorCodeTrack("FF-rX")


            'Dim twrpInstall_CommandResultReceiver As New Adb.CommandResultReceiver
            'dev.ExecuteShellCommand($"twrp install ""{zipInAndroid}""", twrpInstall_CommandResultReceiver)
            'LogAppendText(twrpInstall_CommandResultReceiver.Result, 1)

            'remove lockscreen lock: "adb shell su -c rm /data/system/*.key && adb shell su -c rm /data/system/locksettings*"
            'Hot reboot: "adb shell su -c busybox killall system_server"
            'Clear dulvik cache: "adb shell su -c rm -R /data/dalvik-cache"
            'factory reset: "adb shell su -c recovery --wipe_data"
        Catch ex As Exception
            GA_PleaseWait.Run(False) 'Close before error dialog 
            DoMsg(ErrorInfo.lvl, ErrorInfo.msg, 2, ex.ToString)
        End Try

        GA_PleaseWait.Run(False) 'Close if Try was successful
        Working = False
    End Sub
End Module

'old code
'Private StopOnError As Boolean = False
'Public Sub Run()
'    Dim er As String
'    Main.ProgressBar.Value = 0

'    LogEvent("Flash Zip file", 2)

'    GA_SetProgressText.Run("Launching adb And fastboot servers... Please be patient.", -1)
'    adbDo("devices")
'    fbDo("devices")

'    Main.ProgressBar.Value = 5
'    If Main.FlashZip_OpenFileDialog.FileName = "" Then
'        GA_SetProgressText.Run("No file selected. Please Select a .zip file To proceed.", 0)
'        LogAppendText("No file selected. Please Select a .zip file To proceed.", 1)
'        Exit Sub
'    End If

'    Main.ProgressBar.Value = 10
'    If My.Settings.DeviceCount = 0 Then
'        GA_SetProgressText.Run("Making sure adb status Is good To go...", -1)
'        'adbDetect(True, {"count"})
'        If StopOnError Then
'            DoMsg(1, "Error While flashing zip", 1)
'            Exit Sub
'        End If
'    End If
'    LogAppendText("Copying Zip To internal storage...", 1)

'    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'    MessageBox.Show("Stopping before entering the broken phase.")
'    Exit Sub
'    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'    ErrorCodeTrack("Fz-C0")
'    adbDo("push '" & Main.FlashZip_OpenFileDialog.FileName & "/sdcard/0/")
'    If Not Text.RegularExpressions.Regex.Split(adbOutput, "files pushed.").Length - 2 = 1 Then
'        Dim err As String = "Error while copying zip to internal storage." 'Start without empty new line (avoid exception out-of-range in DoError)
'        If adbOutput = "" Then err &= vbCrLf & adbOutput 'Add output to new line if not ""
'        DoMsg(1, err, 2)
'        Exit Sub
'    End If


'    ErrorCodeTrack("Fz-C1")
'    'adbDo("shell ""reboot sideload""")
'    If Text.RegularExpressions.Regex.Split(adbOutput, "error").Length - 2 = 1 Then
'        er = "Error while issuing commands. Do you want to continue by using ROOT commands?" & vbCrLf & vbCrLf & "More information:" & vbCrLf & adbOutput

'        Dim FlashZip_NeedRoot = MessageBox.Show(er, "Error while issuing commands", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
'        If FlashZip_NeedRoot = DialogResult.OK Then
'            adbDo("shell ""su -c touch /cache/recovery/command""")
'            MessageBox.Show("You will be prompted to grant root access for ""Shell"".")
'            adbDo("shell 'su -c ""'""echo ""boot-recovery"" > /cache/recovery/command""'""'")
'        Else
'            DoMsg(1, er, 2)
'        End If
'    End If
'    ''''''''''''''''''''''''''''''''

'    ErrorCodeTrack("Fz-C2")
'    Try
'        adbDo("shell 'su -c ""'""echo ""--update_package=/sdcard/" & Main.FlashZip_OpenFileDialog.FileName & """ > /cache/recovery/command""'""'")
'    Catch e As Exception
'        DoMsg(1, e.ToString, 2)
'    End Try

'    If Main.FlashZip_RebootWhenComplete_Checkbox.Checked Then
'        adbDo("shell echo 'reboot' > /cache/recovery/command")
'    End If

'    ErrorCodeTrack("Fz-C4")
'    Try
'        adbDo("reboot recovery")
'    Catch e As Exception
'        DoMsg(1, e.ToString, 2)
'    End Try

'End Sub

