using System;
using GeekAssistant.Forms;

internal static partial class UnlockBL {

    // Private ErrorInfo As (lvl As Integer, msg As String) 
    // ' https://source.android.com/devices/bootloader/locking_unlocking

    public static void Run() {
        bool Cancelled = false;
        if (c.Working) {
            inf.Run(inf.lvls.Error, "Unlock Bootloader", "We need to wait the current process to finish first...", null);
            return;
        }

        Home Home = new Home();
        Home.bar.Value = 0;
        inf.currentTitle = "Unlock Bootloader";
        c.Working = true;
        inf.detail.code = "UB-00"; // Unlock Bootloader - Start
        GA_Log.LogEvent(inf.currentTitle, 2);
        GA_Wait.Run(true);
        try {


            // ' check if fb compatible 
            Home.bar.Value = 10;
            if (!ConnectionIsCompatible.fbIsCompatible("UB")) {
                Cancelled = true;
                if (inf.detail.code == "UB-DS")
                    inf.detail.msg = $"{txt.GetFirstLine(inf.detail.msg)}\n" +
                        $"You can unlock Samsung devices using this method:\n" +
                          $" - Unhide \"Developer options\":\n" +
                            $"Settings() : About : Software information : (Tap \"Build number\" 7 times) : (Confirm security unlock if asked)\n" +
                          $" - OEM Unlock:\n" + $"Settings() : Developer options : (Find and Enable \"OEM Unlock\")\n\n" +
                            $" ⚠ Warning: Some devices will factory reset when unlocking for security reasons.\n" +
                            $" ⚠ Notice: If you don't see \"OEM Unlock\" then your device is either unlocked by default, " +
                               "or your manufacturer has hidden the option to unlock (Certain tricks needed to make it visible)";
                throw new Exception();
            }

            Home.bar.Value = 15;
            GA_SetProgressText.Run("Checking bootloader unlock support status...", -1);
            if (!c.S.DeviceBootloaderUnlockSupported) {
                Cancelled = true;
                // ' cancel if not unlockable
                inf.detail.code = "UB-BLX"; // Unlock Bootloader - Bootloader X (BLU is not supported)
                // ErrorInfo = (1, "Oh no... Bootloader unlock is not supported on your device.") 'you can enable with checkbox
                throw new Exception();
            }

            Home.bar.Value = 17;
            Managed.Adb.Device dev = madb.GetListOfDevice()[0];
            Home.bar.Value = 25;
            // ' detected but not in fastboot
            GA_SetProgressText.Run("Checking connection status...", -1);
            if (c.S.DeviceState == "Connected (ADB)") // '''''SUCCESS
            {
                Home.bar.Value = 30;
                GA_SetProgressText.Run("Device is connected (ADB).", -1);
                if (inf.Run(inf.lvls.Question, "Rebooting your device!",
                              $"We need to reboot your device to access fastboot mode and proceed with unlocking.\n\n" +
                              $"Please save your work then confirm the reboot.",
                            ("Reboot", "Cancel"))) // '''''SUCCESS
                {
                    Home.bar.Value = 35;
                    dev.Reboot("bootloader");
                    Home.bar.Value = 40;
                    GA_SetProgressText.Run("Waiting for your device to enter fastboot...", -1);
                    fbCMD.fbDo("wait-for-device"); // ''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    Home.bar.Value = 45;
                    goto DeviceInFastboot; // '''''SUCCESS
                } else {
                    Home.bar.Value = 35;
                    Cancelled = true;
                    inf.detail.code = "UB-uX"; // Unlock Bootloader - Unlock X (BLU cancelled)
                    // ErrorInfo = (0, "You have cancelled the process.")
                    GA_Log.LogEvent("Unlock Bootloader Cancelled", 1);
                    throw new Exception();
                }
            } else if (!(c.S.DeviceState == "Fastboot mode")) {
                Home.bar.Value = 30;
                Cancelled = true;
                if (c.S.DeviceState == "Disconnected") // failsafe  
                {
                    GA_SetProgressText.Run("Device is disconnected.", 0);
                    inf.detail.code = "UB-xX"; // Unlock Bootloader - x error X (device disconnected)
                }
                // ErrorInfo = (1, $"We lost contact with your device!\n" & My.R.TroubleshootConnection)
                else // not adb and not fastboot and not disconnected 
                {
                    GA_SetProgressText.Run("Device is not in adb or fastboot mode.", 0);
                    inf.detail.code = "UB-rX";
                    // ErrorInfo = (0, $"We cannot reboot into fastboot while your device is in {S.DeviceState}.\n" & My.R.TroubleshootConnection)
                } // Unlock Bootloader - reboot X (Device is not in adb or fastboot (cant reboot to fastboot))

                Home.bar.Value = 32;
                throw new Exception();
            }



            // check bootloader state

            DeviceInFastboot:;
            Home.bar.Value = 45;
            Cancelled = false; // failsafe

            // If Not S.DeviceBootloaderUnlocked Then

            // 'ErrorInfo = (1, "Sorry we can't proceed with a locked bootloader")
            // 'Throw New Exception
            // End If

            Home.bar.Value = 46;
            // ' if unlockable  make sure it is unlocked ("fastboot oem device-info" -> "Device unlocked: true")
            GA_SetProgressText.Run("Checking current bootloader state.", -1);
            if (fbCMD.fbDo("oem device-info").Contains("Device unlocked: true")) {
                Home.bar.Value = 100;
                Cancelled = true;
                inf.detail.code = "UB-U1"; // Unlock Bootloader - Unlock 1 (BL Unlocked already)
                // ErrorInfo = (0, $"Hooray! The Bootloader is unlocked already.\nNo need to unlock it once more.")
                throw new Exception();
            }

            Home.bar.Value = 50;
            inf.detail.code = "UB-UXn"; // Unlock Bootloader - Unlock X new (Attempt BLU (new method))
            GA_SetProgressText.Run("Attempting to unlock bootloader...", -1);
            fbCMD.fbDo($"flashing unlock");
            if (fbCMD.fbOutput.ToLower().Contains("err") | fbCMD.fbOutput.ToLower().Contains("fail")) {
                Home.bar.Value = 52;
                inf.detail.code = "UB-UXo"; // Unlock Bootloader - Unlock X old (Attempt BLU (old method)) 
                GA_SetProgressText.Run("New unlock method failed... Attempting old method...", -1);
                Home.bar.Value = 55;
                fbCMD.fbDo($"oem unlock");
                if (fbCMD.fbOutput.ToLower().Contains("err") | fbCMD.fbOutput.ToLower().Contains("fail")) {
                    Home.bar.Value = 57;
                    // ErrorInfo = (10, $"Failed to unlock your device bootloader.")
                    throw new Exception(fbCMD.fbOutput);
                }
            }

            Home.bar.Value = 80;
            GA_Log.LogAppendText(fbCMD.fbOutput, -1);
            GA_SetProgressText.Run("Process finished. Rebooting...", -1);
            Home.bar.Value = 100;
            fbCMD.fbDo("reboot");
        } catch (Exception ex) {
            GA_Wait.Run(false); // Close before error dialog 
            inf.Run(inf.detail.lvl, inf.currentTitle, inf.detail.msg, ex.ToString());
            if (!Cancelled) {
                if (c.S.DeviceState == "Connected (ADB)" | c.S.DeviceState == "Fastboot mode") {
                    if (inf.Run(inf.lvls.Question, inf.currentTitle,
                                  "We are sorry... Seems like we failed.\nDo you want to reboot your device?",
                                ("Reboot", "Do Nothing")))
                        fbCMD.fbDo("reboot");
                }
            }
        }

        GA_Wait.Run(false); // Close if Try was successful
        c.Working = false;
    }
}