using System; 
using GeekAssistant.Forms;

internal static partial class UnlockBL {

    // Private ErrorInfo As (lvl As Integer, msg As String) 
    // ' https://source.android.com/devices/bootloader/locking_unlocking
     
    public static void Run() {
        bool Cancelled = false;
        if (common.Working) {
            GA_Msg.DoMsg(1, "We need to wait the current process to finish first...", 2);
            return;
        }

        Home.ProgressBar.Value = 0;
        common.Working = true;
        common.ErrorInfo.code = "UB-00"; // Unlock Bootloader - Start
        GA_Log.LogEvent("Unlock Bootloader", 2);
        GA_PleaseWait.Run(true);
        try {


            // ' check if fb compatible 
            Home.ProgressBar.Value = 10;
            if (!CheckConnectionIsCompatible. fbIsCompatible("UB")) {
                Cancelled = true;
                if (common.ErrorInfo.code == "UB-DS")
                    common.ErrorInfo.msg = $"{txt.GetFirstLine(common.ErrorInfo.msg)}\n" + 
                        $"You can unlock Samsung devices using this method:\n" + 
                        $" - Unhide \"Developer options\":\n" + 
                        $"Settings : About : Software information : (Tap \"Build number\" 7 times) : (Confirm security unlock if asked)\n" + 
                        $" - OEM Unlock:\n" + $"Settings : Developer options : (Find and Enable \"OEM Unlock\")\n\n" + 
                        $" ⚠ Warning: Some devices will factory reset when unlocking for security reasons.\n" + 
                        $" ⚠ Notice: If you don't see \"OEM Unlock\" then your device is either unlocked by default, " + 
                        "or your manufacturer has hidden the option to unlock (Certain tricks needed to make it visible)";
                throw new Exception();
            }

            Home.ProgressBar.Value = 15;
            GA_SetProgressText.Run("Checking bootloader unlock support status...", -1);
            if (!common.S.DeviceBootloaderUnlockSupported) {
                Cancelled = true;
                // ' cancel if not unlockable
                common.ErrorInfo.code = "UB-BLX"); // Unlock Bootloader - Bootloader X (BLU is not supported)
                // ErrorInfo = (1, "Oh no... Bootloader unlock is not supported on your device.") 'you can enable with checkbox
                throw new Exception();
            }

            Home.ProgressBar.Value = 17;
            Managed.Adb.Device dev = madb.GetListOfDevice()[0];
            Home.ProgressBar.Value = 25;
            // ' detected but not in fastboot
            GA_SetProgressText.Run("Checking connection status...", -1);
            if (common.S.DeviceState == "Connected (ADB)") // '''''SUCCESS
            {
                Home.ProgressBar.Value = 30;
                GA_SetProgressText.Run("Device is connected (ADB).", -1);
                if (GA_infoAsk.Run("Rebooting your device!", $"We need to reboot your device to access fastboot mode and proceed with unlocking.\n\n" + $"Please save your work then confirm the reboot.", "Ready! Let's reboot", "Cancel")) // '''''SUCCESS
                {
                    Home.ProgressBar.Value = 35;
                    dev.Reboot("bootloader");
                    Home.ProgressBar.Value = 40;
                    GA_SetProgressText.Run("Waiting for your device to enter fastboot...", -1);
                    fbCMD.fbDo("wait-for-device"); // ''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    Home.ProgressBar.Value = 45;
                    goto DeviceInFastboot; // '''''SUCCESS
                } else {
                    Home.ProgressBar.Value = 35;
                    Cancelled = true;
                    common.ErrorInfo.code = "UB-uX"; // Unlock Bootloader - Unlock X (BLU cancelled)
                    // ErrorInfo = (0, "You have cancelled the process.")
                    GA_Log.LogEvent("Unlock Bootloader Cancelled", 1);
                    throw new Exception();
                }
            } else if (!(common.S.DeviceState == "Fastboot mode")) {
                Home.ProgressBar.Value = 30;
                Cancelled = true;
                if (common.S.DeviceState == "Disconnected") // failsafe  
                {
                    GA_SetProgressText.Run("Device is disconnected.", 0);
                    common.ErrorInfo.code = "UB-xX"; // Unlock Bootloader - x error X (device disconnected)
                }
                // ErrorInfo = (1, $"We lost contact with your device!\n" & My.R.TroubleshootConnection)
                else // not adb and not fastboot and not disconnected 
                {
                    GA_SetProgressText.Run("Device is not in adb or fastboot mode.", 0);
                    common.ErrorInfo.code = "UB-rX";
                    // ErrorInfo = (0, $"We cannot reboot into fastboot while your device is in {S.DeviceState}.\n" & My.R.TroubleshootConnection)
                } // Unlock Bootloader - reboot X (Device is not in adb or fastboot (cant reboot to fastboot))

                Home.ProgressBar.Value = 32;
                throw new Exception();
            }



            // check bootloader state

            DeviceInFastboot:
            ;
            Home.ProgressBar.Value = 45;
            Cancelled = false; // failsafe

            // If Not S.DeviceBootloaderUnlocked Then

            // 'ErrorInfo = (1, "Sorry we can't proceed with a locked bootloader")
            // 'Throw New Exception
            // End If

            Home.ProgressBar.Value = 46;
            // ' if unlockable  make sure it is unlocked ("fastboot oem device-info" -> "Device unlocked: true")
            GA_SetProgressText.Run("Checking current bootloader state.", -1);
            if (fbCMD.fbDo("oem device-info").Contains("Device unlocked: true")) {
                Home.ProgressBar.Value = 100;
                Cancelled = true;
                common.ErrorInfo.code = "UB-U1"; // Unlock Bootloader - Unlock 1 (BL Unlocked already)
                // ErrorInfo = (0, $"Hooray! The Bootloader is unlocked already.\nNo need to unlock it once more.")
                throw new Exception();
            }

            Home.ProgressBar.Value = 50;
            common.ErrorInfo.code = "UB-UXn"; // Unlock Bootloader - Unlock X new (Attempt BLU (new method))
            GA_SetProgressText.Run("Attempting to unlock bootloader...", -1);
            fbCMD.fbDo($"flashing unlock");
            if (fbCMD.fbOutput.ToLower().Contains("err") |  fbCMD.fbOutput.ToLower().Contains("fail")) {
                Home.ProgressBar.Value = 52;
                common.ErrorInfo.code = "UB-UXo"); // Unlock Bootloader - Unlock X old (Attempt BLU (old method)) 
                GA_SetProgressText.Run("New unlock method failed... Attempting old method...", -1);
                Home.ProgressBar.Value = 55;
                fbCMD.fbDo($"oem unlock");
                if (fbCMD.fbOutput.ToLower().Contains("err") | fbCMD.fbOutput.ToLower().Contains("fail")) {
                    Home.ProgressBar.Value = 57;
                    // ErrorInfo = (10, $"Failed to unlock your device bootloader.")
                    throw new Exception(fbCMD.fbOutput);
                }
            }

            Home.ProgressBar.Value = 80;
            GA_Log.LogAppendText(fbCMD.fbOutput ,- 1);
            GA_SetProgressText.Run("Process finished. Rebooting...", -1);
            Home.ProgressBar.Value = 100;
            fbCMD.fbDo("reboot");
        } catch (Exception ex) {
            GA_PleaseWait.Run(false); // Close before error dialog 
            GA_Msg.DoMsg(common.ErrorInfo.lvl, common.ErrorInfo.msg, 2, ex.ToString());
            if (!Cancelled) {
                if (common.S.DeviceState == "Connected (ADB)" | S.DeviceState == "Fastboot mode") {
                    if (GA_infoAsk.Run("We are sorry... Seems like we failed.", 
                        "Do you want to reboot your device?", 
                        "Reboot", "Do Nothing"
                        ))
                        fbCMD.fbDo("reboot");
                }
            }
        }

        GA_PleaseWait.Run(false); // Close if Try was successful
        common.Working = false;
    }
}