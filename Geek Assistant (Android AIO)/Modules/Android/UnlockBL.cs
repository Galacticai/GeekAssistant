﻿using GeekAssistant.Forms;
using System;
using System.Linq;
using GeekAssistant.Modules.General;
using GeekAssistant.Modules.General.Companion;
using GeekAssistant.Modules.Android.Companion;
using GeekAssistant.Modules.Android.Companion.Essentials;
using System.Threading.Tasks;

namespace GeekAssistant.Modules.Android {
    internal static class UnlockBL {
        private const string workCode_init = "UB", workTitle = "Unlock Bootloader";

        // Private ErrorInfo As (lvl As Integer, msg As String) 
        // ' https://source.android.com/devices/bootloader/locking_unlocking

        public static async Task Run() {
            bool Cancelled = false;
            if (c.Working) {
                if (!c.FormisRunning<Info>()) //failsafe
                    inf.Run(inf.lvls.Error, workTitle, prop.strings.WaitForCurrentProcess, null);
                return;
            }

            //Refresh current home instance
            using var home = c.Home;

            inf.detail.title = workTitle;
            c.Working = true;
            inf.detail.code = $"{workCode_init}-00"; // Unlock Bootloader - Start
            log.Event(inf.detail.title, 2);
            wait.Run(true);
            try {
                home.bar.Value = 0;

                // check if fb compatible 
                home.bar.Value = 10;
                if (!await devConnection.fbIsCompatible()) {
                    Cancelled = true;
                    if (inf.detail.code.Contains("-DS"))
                        inf.detail.msg = $"{txt.GetFirstLine(inf.detail.msg)}\n"
                                         + (inf.detail.code.Last().Equals('o') ? prop.strings.UnlockBL_Samsung_old
                                                                                   : prop.strings.UnlockBL_Samsung);
                    throw new Exception();
                }

                home.bar.Value = 15;
                SetProgressText.Run("Checking bootloader unlock support status...", inf.lvls.Information);
                if (!c.S.DeviceBootloaderUnlockSupported) {
                    Cancelled = true;
                    // ' cancel if not unlockable
                    inf.detail.code = $"{workCode_init}-BLX"; // Unlock Bootloader - Bootloader X (BLU is not supported)
                                                              // ErrorInfo = (1, "Oh no... Bootloader unlock is not supported on your device.") 'you can enable with checkbox
                    throw new Exception();
                }

                home.bar.Value = 17;
                Managed.Adb.Device dev = madb.GetListOfDevice().Result[0];
                home.bar.Value = 25;
                // ' detected but not in fastboot
                SetProgressText.Run("Checking connection status...", inf.lvls.Information);
                if (c.S.DeviceState == "Connected (ADB)") // '''''SUCCESS
                {
                    home.bar.Value = 30;
                    SetProgressText.Run("Device is connected (ADB).", inf.lvls.Information);
                    if (inf.Run(inf.lvls.Question, "Rebooting your device!",
                                  $"We need to reboot your device to access fastboot mode and proceed with unlocking.\n\n" +
                                  $"Please save your work then confirm the reboot.",
                                ("Reboot", "Cancel"))) // '''''SUCCESS
                    {
                        home.bar.Value = 35;
                        dev.Reboot("bootloader");
                        home.bar.Value = 40;
                        SetProgressText.Run("Waiting for your device to enter fastboot...", inf.lvls.Information);
                        fastboot.Run("wait-for-device"); // ''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        home.bar.Value = 45;
                        goto DeviceInFastboot; // '''''SUCCESS
                    } else {
                        home.bar.Value = 35;
                        Cancelled = true;
                        inf.detail.code = $"{workCode_init}-uX"; // Unlock Bootloader - Unlock X (BLU cancelled)
                                                                 // ErrorInfo = (0, "You have cancelled the process.")
                        log.Event("Unlock Bootloader Cancelled", 1);
                        throw new Exception();
                    }
                } else if (!(c.S.DeviceState == "Fastboot mode")) {
                    home.bar.Value = 30;
                    Cancelled = true;
                    if (c.S.DeviceState == "Disconnected") { // failsafe   
                        SetProgressText.Run("Device is disconnected.", 0);
                        inf.detail.code = $"{workCode_init}-xX"; // Unlock Bootloader - x error X (device disconnected)

                    } else {// not adb and not fastboot and not disconnected  
                        SetProgressText.Run("Device is not in adb or fastboot mode.", 0);
                        inf.detail.code = $"{workCode_init}-rX";
                    } // Unlock Bootloader - reboot X (Device is not in adb or fastboot (cant reboot to fastboot))

                    home.bar.Value = 32;
                    throw new Exception();
                }



                // check bootloader state

                DeviceInFastboot:;
                home.bar.Value = 45;
                Cancelled = false; // failsafe

                // If Not S.DeviceBootloaderUnlocked Then


                home.bar.Value = 46;
                // ' if unlockable  make sure it is unlocked ("fastboot oem device-info" -> "Device unlocked: true")
                SetProgressText.Run("Checking current bootloader state.", inf.lvls.Information);
                if ((await fastboot.Run("oem device-info")).Contains("Device unlocked: true")) {
                    home.bar.Value = 100;
                    Cancelled = true;
                    inf.detail.code = $"{workCode_init}-U1"; // Unlock Bootloader - Unlock 1 (BL Unlocked already)
                                                             // ErrorInfo = (0, $"Hooray! The Bootloader is unlocked already.\nNo need to unlock it once more.")
                    throw new Exception();
                }

                home.bar.Value = 50;
                inf.detail.code = $"{workCode_init}-UXn"; // Unlock Bootloader - Unlock X new (Attempt BLU (new method))
                SetProgressText.Run("Attempting to unlock bootloader...", inf.lvls.Information);
                string fbOut;
                fbOut = await fastboot.Run($"flashing unlock");
                if (fbOut.ToLower().Contains("err") | fbOut.ToLower().Contains("fail")) {
                    home.bar.Value = 52;
                    inf.detail.code = $"{workCode_init}-UXo"; // Unlock Bootloader - Unlock X old (Attempt BLU (old method)) 
                    SetProgressText.Run("New unlock method failed... Attempting old method...", inf.lvls.Information);
                    home.bar.Value = 55;
                    fbOut = await fastboot.Run($"oem unlock");
                    if (fbOut.ToLower().Contains("err") | fbOut.ToLower().Contains("fail")) {
                        home.bar.Value = 57;
                        // ErrorInfo = (10, $"Failed to unlock your device bootloader.")
                        throw new Exception(fbOut);
                    }
                }

                home.bar.Value = 80;
                log.AppendText(fbOut, -1);
                SetProgressText.Run("Process finished. Rebooting...", inf.lvls.Information);
                home.bar.Value = 100;
                fastboot.Run("reboot");
            } catch (Exception ex) {
                wait.Run(false); // Close before error dialog 
                inf.Run(inf.detail.lvl, inf.detail.title, inf.detail.msg, ex.ToString());
                if (!Cancelled)
                    if (c.S.DeviceState == "Connected (ADB)" | c.S.DeviceState == "Fastboot mode")
                        if (inf.Run(inf.lvls.Question, inf.detail.title,
                                      "We are sorry... Seems like we failed.\nDo you want to reboot your device?",
                                    ("Reboot", "Do Nothing")))
                            fastboot.Run("reboot");
            }

            wait.Run(false); // Close if Try was successful
            c.Working = false;
        }
    }
}
