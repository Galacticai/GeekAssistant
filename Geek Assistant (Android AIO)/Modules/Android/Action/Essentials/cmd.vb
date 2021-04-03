
Imports System.Text.RegularExpressions

Module cmd

    Public Sub Run(command)
        Exit Sub

        If command.IndexOf(" ") = -1 Then GoTo invalidCMD 'If command has no arguments: cancel (invalidCMD)

        Dim cmdStart = command.Substring(0, command.IndexOf(" ")) 'Get the first word of the command 

        If cmdStart = "adb" Then 'command starting with "adb"
            'filter invalid commands using regex for adb
            Dim adbRegex As New Regex("adb (devices|shell|push|pull|logcat|install|install-multiple|uninstall|sync|emu|forward|reverse|jdwp|bugreport|backup|backup|restore|disable-verity|enable-verity|keygen|help|version|wait-for-device|start-server|kill-server|get-state|get-serialno|get-devpath|remount|reboot|reboot-bootloader|root|unroot|usb|tcpip|ppp)") 'Matching example: "adb devices"
            If adbRegex.Match(command).Success Then 'If command matching adbRegex
                adbCMD(command.Substring(command.indexof(" ") + 1)) 'run command without "adb "
                If adbOutput = "" Then
                    LogAppendText($"⮜⮜ ""{command}""{vbCrLf}  Process finished with no response.", 2)
                Else
                    LogAppendText($"⮜⮜ ""{command}""{vbCrLf}⮞⮞{vbCrLf}{adbOutput}", 2)
                End If
            Else
                GoTo invalidCMD
            End If
        ElseIf cmdStart = "fastboot" Then 'command starting with "fastboot"
            'filter invalid commands using regex for fastboot
            Dim fbRegex As New Regex("fastboot (devices|update|flashall|flash|flashing lock|flashing unlock|flashing lock_critical|flashing get_unlock_ability|erase|format|getvar|boot)") 'Matching example: "fastboot"
            If fbRegex.Match(command).Success Then 'If command matching fbRegex
                fbCMD(command.Substring(command.indexof(" ") + 1)) 'run command without "fastboot "
                If fbOutput = "" Then
                    LogAppendText($"⮜⮜ ""{command}""{vbCrLf}  Process finished with no response.", 2)
                Else
                    LogAppendText($"⮜⮜ ""{command}""{vbCrLf}⮞⮞{vbCrLf}{fbOutput}", 2)
                End If
            Else
                GoTo invalidCMD
            End If
        Else
invalidCMD:
            Media.SystemSounds.Beep.Play()
            Dim invalid_text =
                $"⮜⮜ {command}{vbCrLf}⮞⮞ ⚠  Invalid Command.{vbCrLf}Please use a valid adb or fastboot command"
            If command.contains("adb") And command.contains("fastboot") Then
                invalid_text = $"⮜⮜ {command}{vbCrLf}⮞⮞ ⚠  Invalid adb Or fastboot command.{vbCrLf}"
                GoTo Skip_commandContains
            End If
            If command.contains("adb") Then
                invalid_text = $"⮜⮜ {command}{vbCrLf}⮞⮞ ⚠  Invalid adb command.{vbCrLf}" &
                               $"Allowed adb arguments:{vbCrLf}" &
                                "devices | shell | push | pull | logcat | install | install-multiple | uninstall | sync | emu | forward | reverse | jdwp | bugreport | backup | backup | restore | disable-verity | enable-verity | keygen | help | version | wait-for-device | start-server | kill-server | get-state | get-serialno | get-devpath | remount | reboot | reboot-bootloader | root | unroot | usb | tcpip | ppp"
            ElseIf command.contains("fastboot") Then
                invalid_text = $"⮜⮜ {command}{vbCrLf}⮞⮞ ⚠  Invalid fastboot command.{vbCrLf}" &
                               $"Allowed fastboot arguments:{vbCrLf}" &
                                "update | flashall | flash | flashing lock | flashing unlock | flashing lock_critical | flashing get_unlock_ability | erase | format | getvar | boot"
            End If
Skip_commandContains:
            LogAppendText(invalid_text, 2)
        End If
    End Sub

    Private Function adbCMD(command As String)
        ErrorCodeTrack("adb-cmd")
        Return adbDo(command)
    End Function
    Private Function fbCMD(command As String)
        ErrorCodeTrack("fb-cmd")
        Return fbDo(command)
    End Function
End Module
'|========================== OLD CODE ==========================|'
'Try
'    from " " to " "+1 
'    Dim Testvar_adbCMDSigniture As String = command.Substring(command.IndexOf(" "), command.IndexOf(" ") + 1)
'Catch ex As Exception
'    Dim adbAllowedCommandsList As String() = {"devices", "shell", "push", "pull", "logcat",
'                                              "install", "install-multiple", "uninstall", "sync", "emu",
'                                              "forward", "reverse", "jdwp", "bugreport", "backup", "backup",
'                                              "restore", "disable-verity", "enable-verity", "keygen", "help",
'                                              "version", "wait-for-device", "start-server", "kill-server", "get-state",
'                                              "get-serialno", "get-devpath", "remount", "reboot", "reboot-bootloader",
'                                              "root", "unroot", "usb", "tcpip", "ppp", ""}
'    If Not adbAllowedCommandsList.Contains(LCase(command)) Then
'        LogAppendText("⮜⮜ ""adb " & command & """" & vbCrLf & "⮞⮞ (X) Invalid argument." & vbCrLf & "Please refer to adb documentation to see the possible commands" & vbCrLf & "Example: ""shell su""", 2)
'        Exit Sub
'    End If
'End Try
''Select Case adbManualCMD_TextBox.Text.Substring(0, adbManualCMD_TextBox.Text.IndexOf(" "))
''    Case <> "shell", "push", "pull", "logcat", "install"
''        LogAppendText("<< "" adb " & adbManualCMD_TextBox.Text & """" & vbCrLf & ">> Application Response:" & vbCrLf & "Invalid argument." & vbCrLf & "Allowed commands: shell, push, pull, logcat, install" & vbCrLf & "Example: ""shell su""", 1)
''        Exit Sub
''End Select

'Sub Run(cmd As String)
'    GA_Error.ErrorCodeTrack("adb-cmd")
'    If Main.adbManualCMD_TextBox.Text <> "" Then

'        Select Case Main.adbManualCMD_TextBox.Text.Substring(0, Main.adbManualCMD_TextBox.Text.IndexOf(" "))
'            Case <> "shell", "push", "pull", "logcat", "install"
'                LogAppendText("<< ""adb " & Main.adbManualCMD_TextBox.Text & """" & vbCrLf & ">> Application Response:" & vbCrLf & "Invalid argument." & vbCrLf & "Allowed commands: shell, push, pull, logcat, install" & vbCrLf & "Example: ""shell su""", 1)
'                Exit Sub
'        End Select

'        Main.adbCommand_Previous = Main.adbManualCMD_TextBox.Text
'        SetProgressText.Run("Running adb command...", 0)
'        adbDoThread(Main.adbManualCMD_TextBox.Text)
'        'LogEvent("Manual ADB Command", 2)
'        If adb_output = "" Then
'            LogAppendText("<< ""adb " & Main.adbManualCMD_TextBox.Text & """" & vbCrLf & ">> (i) No output.", 1)
'            'DoError("(i) No ADB Response!" & vbCrLf & "Please check your command and try again.", 1, False)
'        Else
'            LogAppendText("<< ""adb " & Main.adbManualCMD_TextBox.Text & """" & vbCrLf & ">> ADB Response:" & vbCrLf & adb_output, 1)
'        End If
'        Main.adbManualCMD_TextBox.Text = ""
'        Main.ShowLog_InfoBlink_Timer.Start()
'    End If
'End Sub
