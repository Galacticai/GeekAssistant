using System;
using System.Linq;
using GeekAssistant.Forms;
using Managed;

internal static partial class FastbootFlash {
    // 0 boot 
    // 1 bootloader 
    // 2 radio 
    // 3 recovery
    // 4 system 
    // 5 vendor   
    public static void Run(string img, int type) {
        if (c.Working) {
            GA_Msg.DoMsg(1, "We need to wait the other process to finish first...", 2);
            return;
        }

        c.Working = true;
        c.ErrorInfo.code = "FF-00";
        GA_Log.LogEvent("Fastboot Flash", 2);
        GA_PleaseWait.Run(true);
        try {
            c.ErrorInfo.code = "FF-F0";
            if (string.IsNullOrEmpty(img)) // check zip string 
            {
                // ErrorInfo = (10, "File name is not set!")
                throw new Exception();
            }

            c.ErrorInfo.code = "FF-T0";
            if (type < 0 | type > 5) {
                // ErrorInfo = (10, "File type is out of range!")
                throw new Exception();
            }

            // ' check if fb compatible 
            if (!CheckConnectionIsCompatible.fbIsCompatible("FF"))
                throw new Exception();
            Managed.Adb.Device dev = madb.GetListOfDevice()[0];


            // ' detected but not in fastboot
            if (c.S.DeviceState == "Connected (ADB)") {
                if (GA_infoAsk.Run("Rebooting your device!", $"Now we need to reboot your device into fastboot mode to proceed with the installation.\n\n" + $"Please save your work then confirm the reboot.", "Reboot into fastboot", "Cancel")) {
                    dev.Reboot("bootloader");
                    GA_SetProgressText.Run("Waiting for your device to enter fastboot...", -1);
                    fbCMD.fbDo("wait-for-device"); // ''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    goto DeviceInFastboot;
                } else {
                    c.ErrorInfo.code = "FF-uX";
                    // ErrorInfo = (0, "You have cancelled the process.")
                    GA_Log.LogEvent("Fastboot Flash Cancelled", 1);
                    throw new Exception();
                }
            } else if (!(c.S.DeviceState == "Fastboot mode")) {
                if (c.S.DeviceState == "Disconnected") // failsafe
                {
                    c.ErrorInfo.code = "FF-xX";
                }
                // ErrorInfo = (1, $"We lost contact with your device!\n" & My.R.TroubleshootConnection)
                else // not adb and not fastboot and not disconnected
                {
                    c.ErrorInfo.code = "FF-rX";
                    // ErrorInfo = (0, $"We cannot reboot into fastboot while your device is in {S.DeviceState}.\n" & My.R.TroubleshootConnection)
                }

                throw new Exception();
            }



            // check bootloader state

            DeviceInFastboot:
            ;
            if (!c.S.DeviceBootloaderUnlockSupported) {
                // ' cancel if not unlockable
                c.ErrorInfo.code = "FF-BLX";
                // ErrorInfo = (1, "Bootloader unlock is not supported.") 'you can enable with checkbox
                throw new Exception();
            }


            // If Not S.DeviceBootloaderUnlocked Then

            // 'ErrorInfo = (1, "Sorry we can't proceed with a locked bootloader")
            // 'Throw New Exception
            // End If

            // ' if unlockable  make sure it is unlocked ("fastboot oem device-info" -> "Device unlocked: true")
            fbCMD.fbDo("oem device-info");
            if (!fbCMD.fbOutput.Contains("Device unlocked: true")) {
                c.ErrorInfo.code = "FF-BLuX";
                // ErrorInfo = (1, $"Your device bootloader is locked.\nYou have to unlock the bootloader first or you will brick your device.")
                throw new Exception();
            }

            // ' push zip to /sdcard/0/GeekAssistant tmp dir
            c.ErrorInfo.code = "FF-F";
            fbCMD.fbDo($"flash {TypeToString(type)} \"{img}\"");
            if (fbCMD.fbOutput.Contains("error")) {
                c.ErrorInfo.code = "FF-BLuX";
                // ErrorInfo = (1, $"Your device bootloader is locked.\nYou have to unlock the bootloader first.")
                throw new Exception();
            }

            GA_Log.LogAppendText(fbCMD.fbOutput, -1);
            // Push(zip)
            // Dim zipInAndroid = $"/sdcard/0/GeekAssistant/{IO.Path.GetFileName(zip)}"
            c.ErrorInfo.code = "FF-rX";
        } catch (Exception ex) {
            GA_PleaseWait.Run(false); // Close before error dialog 
            GA_Msg.DoMsg(c.ErrorInfo.lvl, c.ErrorInfo.msg, 2, ex.ToString());
        }

        GA_PleaseWait.Run(false); // Close if Try was successful
        c.Working = false;
    }

    // 0 boot 
    // 1 bootloader 
    // 2 radio 
    // 3 recovery
    // 4 system 
    // 5 vendor  
    private static string TypeToString(int type) {
        if (type < 0 | type > 5) {
            c.ErrorInfo.code=$"{txt.GA_GetErrorInitials()}-FtX" ;
            // ErrorInfo = (10, $"File type not set.")
            throw new Exception();
        }

        string result = "";
        switch (type) {
        case 0: {
            result = "boot";
            break;
        }

        case 1: {
            result = "bootloader";
            break;
        }

        case 2: {
            result = "radio";
            break;
        }

        case 3: {
            result = "recovery";
            break;
        }

        case 4: {
            result = "system";
            break;
        }

        case 5: {
            result = "vendor";
            break;
        }
        }

        return result;
    }
}

// old code
// Private StopOnError As Boolean = False
// Public Sub Run()
// Dim er As String
// Main.ProgressBar.Value = 0

// LogEvent("Flash Zip file", 2)

// GA_SetProgressText.Run("Launching adb And fastboot servers... Please be patient.", -1)
// adbDo("devices")
// fbDo("devices")

// Main.ProgressBar.Value = 5
// If Main.FlashZip_OpenFileDialog.FileName = "" Then
// GA_SetProgressText.Run("No file selected. Please Select a .zip file To proceed.", 0)
// LogAppendText("No file selected. Please Select a .zip file To proceed.", 1)
// Exit Sub
// End If

// Main.ProgressBar.Value = 10
// If S.DeviceCount = 0 Then
// GA_SetProgressText.Run("Making sure adb status Is good To go...", -1)
// 'adbDetect(True, {"count"})
// If StopOnError Then
// DoMsg(1, "Error While flashing zip", 1)
// Exit Sub
// End If
// End If
// LogAppendText("Copying Zip To internal storage...", 1)

// ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
// MessageBox.Show("Stopping before entering the broken phase.")
// Exit Sub
// ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
// ErrorCodeTrack("Fz-C0")
// adbDo("push '" & Main.FlashZip_OpenFileDialog.FileName & "/sdcard/0/")
// If Not Text.RegularExpressions.Regex.Split(adbOutput, "files pushed.").Length - 2 = 1 Then
// Dim err As String = "Error while copying zip to internal storage." 'Start without empty new line (avoid exception out-of-range in DoError)
// If adbOutput = "" Then err &= vbCrLf & adbOutput 'Add output to new line if not ""
// DoMsg(1, err, 2)
// Exit Sub
// End If


// ErrorCodeTrack("Fz-C1")
// 'adbDo("shell ""reboot sideload""")
// If Text.RegularExpressions.Regex.Split(adbOutput, "error").Length - 2 = 1 Then
// er = "Error while issuing commands. Do you want to continue by using ROOT commands?" & vbCrLf & vbCrLf & "More information:" & vbCrLf & adbOutput

// Dim FlashZip_NeedRoot = MessageBox.Show(er, "Error while issuing commands", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
// If FlashZip_NeedRoot = DialogResult.OK Then
// adbDo("shell ""su -c touch /cache/recovery/command""")
// MessageBox.Show("You will be prompted to grant root access for ""Shell"".")
// adbDo("shell 'su -c ""'""echo ""boot-recovery"" > /cache/recovery/command""'""'")
// Else
// DoMsg(1, er, 2)
// End If
// End If
// ''''''''''''''''''''''''''''''''

// ErrorCodeTrack("Fz-C2")
// Try
// adbDo("shell 'su -c ""'""echo ""--update_package=/sdcard/" & Main.FlashZip_OpenFileDialog.FileName & """ > /cache/recovery/command""'""'")
// Catch e As Exception
// DoMsg(1, e.ToString, 2)
// End Try

// If Main.FlashZip_RebootWhenComplete_Checkbox.Checked Then
// adbDo("shell echo 'reboot' > /cache/recovery/command")
// End If

// ErrorCodeTrack("Fz-C4")
// Try
// adbDo("reboot recovery")
// Catch e As Exception
// DoMsg(1, e.ToString, 2)
// End Try

// End Sub

