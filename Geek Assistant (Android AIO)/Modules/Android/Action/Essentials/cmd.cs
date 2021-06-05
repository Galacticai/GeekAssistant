using Managed.Adb;
using System.Text.RegularExpressions;

internal static partial class cmd {
    public static string madbShell(Device dev, string cmd, bool sudo = false) {
        if (ConnectionIsCompatible.adbIsReady()) {
            inf.Run(inf.detail, ("Close", null));
        }

        madb.madbBridge(); // failsafe
        CommandResultReceiver crr = new();
        if (sudo) {
            dev.ExecuteRootShellCommand(cmd, crr);
        } else {
            dev.ExecuteShellCommand(cmd, crr);
        }

        return crr.Result;
    }
    public static void Run(string command) {
        //return;
        if (command.IndexOf(" ") != -1) { invalidCMD(command); return; } // If command has no arguments: cancel (invalidCMD)


        var cmdStart = command.Substring(0, command.IndexOf(" ")); // Get the first word of the command 
        if (cmdStart == "adb") // command starting with "adb"
        {
            // filter invalid commands using regex for adb
            var adbRegex = new Regex("adb (devices|shell|push|pull|logcat|install|install-multiple|uninstall|sync|emu|forward|reverse|jdwp|bugreport|backup|backup|restore|disable-verity|enable-verity|keygen|help|version|wait-for-device|start-server|kill-server|get-state|get-serialno|get-devpath|remount|reboot|reboot-bootloader|root|unroot|usb|tcpip|ppp)"); // Matching example: "adb devices"
            if (adbRegex.Match(command).Success) // If command matching adbRegex
            {
                adbDo_WithTrack(command.Substring(command.IndexOf(" ") + 1)); // run command without "adb "
                if (adbCMD.adbOutput == "") {
                    GA_Log.LogAppendText($"⮜⮜ \"{command}\"\n  Process finished with no response.", 2);
                } else {
                    GA_Log.LogAppendText($"⮜⮜ \"{command}\"\n⮞⮞\n{adbCMD.adbOutput}", 2);
                }
            } else {
                invalidCMD(command); return;
            }
        } else if (cmdStart == "fastboot") // command starting with "fastboot"
          {
            // filter invalid commands using regex for fastboot
            var fbRegex = new Regex("fastboot (devices|update|flashall|flash|flashing lock|flashing unlock|flashing lock_critical|flashing get_unlock_ability|erase|format|getvar|boot)"); // Matching example: "fastboot"
            if (fbRegex.Match(command).Success) // If command matching fbRegex
            {
                fbDo_WithTrack(command.Substring(command.IndexOf(" ") + 1)); // run command without "fastboot "
                if (fbCMD.fbOutput == "") {
                    GA_Log.LogAppendText($"⮜⮜ \"{command}\"\n  Process finished with no response.", 2);
                } else {
                    GA_Log.LogAppendText($"⮜⮜ \"{command}\"\n⮞⮞\n{fbCMD.fbOutput}", 2);
                }
            } else {
                invalidCMD(command); return;
            }
        } else {
            invalidCMD(command); return;

        }
    }
    private static void invalidCMD(string command) {
        System.Media.SystemSounds.Beep.Play();
        string invalid_text = $"⮜⮜ {command}\n⮞⮞ ⚠  Invalid Command.\nPlease use a valid adb or fastboot command";
        if (command.Contains("adb") && command.Contains("fastboot")) {
            invalid_text = $"⮜⮜ {command}\n⮞⮞ ⚠  Invalid adb Or fastboot command.\n";
            goto Skip_commandContains;
        }

        if (command.Contains("adb")) {
            invalid_text = $"⮜⮜ {command}\n⮞⮞ ⚠  Invalid adb command.\n" + $"Allowed adb arguments:\n" + "devices | shell | push | pull | logcat | install | install-multiple | uninstall | sync | emu | forward | reverse | jdwp | bugreport | backup | backup | restore | disable-verity | enable-verity | keygen | help | version | wait-for-device | start-server | kill-server | get-state | get-serialno | get-devpath | remount | reboot | reboot-bootloader | root | unroot | usb | tcpip | ppp";
        } else if (command.Contains("fastboot")) {
            invalid_text = $"⮜⮜ {command}\n⮞⮞ ⚠  Invalid fastboot command.\n" + $"Allowed fastboot arguments:\n" + "update | flashall | flash | flashing lock | flashing unlock | flashing lock_critical | flashing get_unlock_ability | erase | format | getvar | boot";
        }

        Skip_commandContains:;

        GA_Log.LogAppendText(invalid_text, 2);
    }
    private static string adbDo_WithTrack(string command) {
        inf.detail.workCode = $"{txt.GA_current_workCode}-adb-cmd";
        return adbCMD.adbDo(command);
    }

    private static string fbDo_WithTrack(string command) {
        inf.detail.workCode = $"{txt.GA_current_workCode}-fb-cmd";
        return fbCMD.fbDo(command);
    }
}
// |========================== OLD CODE ==========================|'
// Try
// from " " to " "+1 
// Dim Testvar_adbCMDSigniture As String = command.Substring(command.IndexOf(" "), command.IndexOf(" ") + 1)
// Catch ex As Exception
// Dim adbAllowedCommandsList As String() = {"devices", "shell", "push", "pull", "logcat",
// "install", "install-multiple", "uninstall", "sync", "emu",
// "forward", "reverse", "jdwp", "bugreport", "backup", "backup",
// "restore", "disable-verity", "enable-verity", "keygen", "help",
// "version", "wait-for-device", "start-server", "kill-server", "get-state",
// "get-serialno", "get-devpath", "remount", "reboot", "reboot-bootloader",
// "root", "unroot", "usb", "tcpip", "ppp", ""}
// If Not adbAllowedCommandsList.Contains(LCase(command)) Then
// LogAppendText("⮜⮜ ""adb " & command & """" & vbCrLf & "⮞⮞ (X) Invalid argument." & vbCrLf & "Please refer to adb documentation to see the possible commands" & vbCrLf & "Example: ""shell su""", 2)
// Exit Sub
// End If
// End Try
// 'Select Case adbManualCMD_TextBox.Text.Substring(0, adbManualCMD_TextBox.Text.IndexOf(" "))
// '    Case <> "shell", "push", "pull", "logcat", "install"
// '        LogAppendText("<< "" adb " & adbManualCMD_TextBox.Text & """" & vbCrLf & ">> Application Response:" & vbCrLf & "Invalid argument." & vbCrLf & "Allowed commands: shell, push, pull, logcat, install" & vbCrLf & "Example: ""shell su""", 1)
// '        Exit Sub
// 'End Select

// Sub Run(cmd As String)
// GA_Error.ErrorCodeTrack("adb-cmd")
// If Main.adbManualCMD_TextBox.Text <> "" Then

// Select Case Main.adbManualCMD_TextBox.Text.Substring(0, Main.adbManualCMD_TextBox.Text.IndexOf(" "))
// Case <> "shell", "push", "pull", "logcat", "install"
// LogAppendText("<< ""adb " & Main.adbManualCMD_TextBox.Text & """" & vbCrLf & ">> Application Response:" & vbCrLf & "Invalid argument." & vbCrLf & "Allowed commands: shell, push, pull, logcat, install" & vbCrLf & "Example: ""shell su""", 1)
// Exit Sub
// End Select

// Main.adbCommand_Previous = Main.adbManualCMD_TextBox.Text
// SetProgressText.Run("Running adb command...", 0)
// adbDoThread(Main.adbManualCMD_TextBox.Text)
// 'LogEvent("Manual ADB Command", 2)
// If adb_output = "" Then
// LogAppendText("<< ""adb " & Main.adbManualCMD_TextBox.Text & """" & vbCrLf & ">> (i) No output.", 1)
// 'DoError("(i) No ADB Response!" & vbCrLf & "Please check your command and try again.", 1, False)
// Else
// LogAppendText("<< ""adb " & Main.adbManualCMD_TextBox.Text & """" & vbCrLf & ">> ADB Response:" & vbCrLf & adb_output, 1)
// End If
// Main.adbManualCMD_TextBox.Text = ""
// Main.ShowLog_InfoBlink_Timer.Start()
// End If
// End Sub
