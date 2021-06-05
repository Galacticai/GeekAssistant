using GeekAssistant.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

internal static partial class UnlockBL {
    private static string workCode_init => "UB";
    private static string workTitle => "Unlock Bootloader";

    // Private ErrorInfo As (lvl As Integer, msg As String) 
    // ' https://source.android.com/devices/bootloader/locking_unlocking

    public static void Run() {
        bool Cancelled = false;
        if (c.Working) {
            if (!Application.OpenForms.OfType<Info>().Any()) //failsafe
                inf.Run(inf.lvls.Error, workTitle, prop.strings.WaitForCurrentProcess, null);
            return;
        }

        //Refresh current Home instance
        Home Home = null;
        foreach (Form home in Application.OpenForms)
            if (home.GetType() == typeof(Home))
                Home = (Home)home;
        inf.workTitle = workTitle;
        c.Working = true;
        inf.detail.workCode = $"{workCode_init}-00"; // Unlock Bootloader - Start
        Log.LogEvent(inf.workTitle, 2);
        GAwait.Run(true);
        try {
            Home.bar.Value = 0;

            // check if fb compatible 
            Home.bar.Value = 10;
            if (!ConnectionIsCompatible.fbIsCompatible()) {
                Cancelled = true;
                if (inf.detail.workCode.Contains("-DS"))
                    inf.detail.msg = $"{txt.GetFirstLine(inf.detail.msg)}\n"
                                     + (inf.detail.workCode.Last().Equals('o') ? prop.strings.UnlockBL_Samsung_old
                                                                               : prop.strings.UnlockBL_Samsung);
                throw new Exception();
            }

            Home.bar.Value = 15;
            SetProgressText.Run("Checking bootloader unlock support status...", -1);
            if (!c.S.DeviceBootloaderUnlockSupported) {
                Cancelled = true;
                // ' cancel if not unlockable
                inf.detail.workCode = $"{workCode_init}-BLX"; // Unlock Bootloader - Bootloader X (BLU is not supported)
                                                              // ErrorInfo = (1, "Oh no... Bootloader unlock is not supported on your device.") 'you can enable with checkbox
                throw new Exception();
            }

            Home.bar.Value = 17;
            Managed.Adb.Device dev = madb.GetListOfDevice().Result[0];
            Home.bar.Value = 25;
            // ' detected but not in fastboot
            SetProgressText.Run("Checking connection status...", -1);
            if (c.S.DeviceState == "Connected (ADB)") // '''''SUCCESS
            {
                Home.bar.Value = 30;
                SetProgressText.Run("Device is connected (ADB).", -1);
                if (inf.Run(inf.lvls.Question, "Rebooting your device!",
                              $"We need to reboot your device to access fastboot mode and proceed with unlocking.\n\n" +
                              $"Please save your work then confirm the reboot.",
                            ("Reboot", "Cancel"))) // '''''SUCCESS
                {
                    Home.bar.Value = 35;
                    dev.Reboot("bootloader");
                    Home.bar.Value = 40;
                    SetProgressText.Run("Waiting for your device to enter fastboot...", -1);
                    fbCMD.fbDo("wait-for-device"); // ''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    Home.bar.Value = 45;
                    goto DeviceInFastboot; // '''''SUCCESS
                } else {
                    Home.bar.Value = 35;
                    Cancelled = true;
                    inf.detail.workCode = $"{workCode_init}-uX"; // Unlock Bootloader - Unlock X (BLU cancelled)
                                                                 // ErrorInfo = (0, "You have cancelled the process.")
                    Log.LogEvent("Unlock Bootloader Cancelled", 1);
                    throw new Exception();
                }
            } else if (!(c.S.DeviceState == "Fastboot mode")) {
                Home.bar.Value = 30;
                Cancelled = true;
                if (c.S.DeviceState == "Disconnected") { // failsafe   
                    SetProgressText.Run("Device is disconnected.", 0);
                    inf.detail.workCode = $"{workCode_init}-xX"; // Unlock Bootloader - x error X (device disconnected)

                } else {// not adb and not fastboot and not disconnected  
                    SetProgressText.Run("Device is not in adb or fastboot mode.", 0);
                    inf.detail.workCode = $"{workCode_init}-rX";
                } // Unlock Bootloader - reboot X (Device is not in adb or fastboot (cant reboot to fastboot))

                Home.bar.Value = 32;
                throw new Exception();
            }



            // check bootloader state

            DeviceInFastboot:;
            Home.bar.Value = 45;
            Cancelled = false; // failsafe

            // If Not S.DeviceBootloaderUnlocked Then


            Home.bar.Value = 46;
            // ' if unlockable  make sure it is unlocked ("fastboot oem device-info" -> "Device unlocked: true")
            SetProgressText.Run("Checking current bootloader state.", -1);
            if (fbCMD.fbDo("oem device-info").Contains("Device unlocked: true")) {
                Home.bar.Value = 100;
                Cancelled = true;
                inf.detail.workCode = $"{workCode_init}-U1"; // Unlock Bootloader - Unlock 1 (BL Unlocked already)
                                                             // ErrorInfo = (0, $"Hooray! The Bootloader is unlocked already.\nNo need to unlock it once more.")
                throw new Exception();
            }

            Home.bar.Value = 50;
            inf.detail.workCode = $"{workCode_init}-UXn"; // Unlock Bootloader - Unlock X new (Attempt BLU (new method))
            SetProgressText.Run("Attempting to unlock bootloader...", -1);
            fbCMD.fbDo($"flashing unlock");
            if (fbCMD.fbOutput.ToLower().Contains("err") | fbCMD.fbOutput.ToLower().Contains("fail")) {
                Home.bar.Value = 52;
                inf.detail.workCode = $"{workCode_init}-UXo"; // Unlock Bootloader - Unlock X old (Attempt BLU (old method)) 
                SetProgressText.Run("New unlock method failed... Attempting old method...", -1);
                Home.bar.Value = 55;
                fbCMD.fbDo($"oem unlock");
                if (fbCMD.fbOutput.ToLower().Contains("err") | fbCMD.fbOutput.ToLower().Contains("fail")) {
                    Home.bar.Value = 57;
                    // ErrorInfo = (10, $"Failed to unlock your device bootloader.")
                    throw new Exception(fbCMD.fbOutput);
                }
            }

            Home.bar.Value = 80;
            Log.LogAppendText(fbCMD.fbOutput, -1);
            SetProgressText.Run("Process finished. Rebooting...", -1);
            Home.bar.Value = 100;
            fbCMD.fbDo("reboot");
        } catch (Exception ex) {
            GAwait.Run(false); // Close before error dialog 
            inf.Run(inf.detail.lvl, inf.workTitle, inf.detail.msg, ex.ToString());
            if (!Cancelled)
                if (c.S.DeviceState == "Connected (ADB)" | c.S.DeviceState == "Fastboot mode")
                    if (inf.Run(inf.lvls.Question, inf.workTitle,
                                  "We are sorry... Seems like we failed.\nDo you want to reboot your device?",
                                ("Reboot", "Do Nothing")))
                        fbCMD.fbDo("reboot");
        }

        GAwait.Run(false); // Close if Try was successful
        c.Working = false;
    }
}