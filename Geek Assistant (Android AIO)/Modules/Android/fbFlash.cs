﻿using System;
using System.ComponentModel;
using GeekAssistant.Modules.General;
using GeekAssistant.Modules.Android.Companion;
using GeekAssistant.Modules.Android.Companion.Essentials;
using System.Threading.Tasks;

namespace GeekAssistant.Modules.Android {
    internal static class fbFlash {
        private const string workCode_init = "fbF", workTitle = "Fastboot Flash";

        /// <returns>Type of .img file as <see cref="string"/>
        /// <list type="bullet"> 
        /// <item><paramref name="type"/> 0  boot </item>
        /// <item><paramref name="type"/> 1  bootloader </item>
        /// <item><paramref name="type"/> 2  radio </item>
        /// <item><paramref name="type"/> 3  recovery</item>
        /// <item><paramref name="type"/> 4  system </item>
        /// <item><paramref name="type"/> 5  vendor </item>
        /// </list></returns> 
        public enum imgType {
            [Description("Type of .img file")]
            boot = 0,
            bootlaoder = 1,
            radio = 2,
            recovery = 3,
            system = 4,
            vendor = 5
        }
        public static async Task Run(string img, imgType imgtype) {
            if (c.Working) {
                inf.Run(inf.lvls.Error, workTitle, "We need to wait the other process to finish first...");
                return;
            }

            inf.detail.title = workTitle;
            c.Working = true;
            inf.detail.code = $"{workCode_init}-00";
            log.Event(inf.detail.title, 2);
            wait.Run(true);
            try {
                if (string.IsNullOrEmpty(img)) { // check zip string  
                    inf.detail = ($"{workCode_init}-F0", inf.lvls.FatalError, inf.detail.title, "File name is not set!", null);
                    throw new Exception();
                }

                // ' check if fb compatible 
                if (!await devConnection.fbIsCompatible()) throw new Exception(); //inf.detail is already set inside this 


                Managed.Adb.Device dev = madb.GetListOfDevice().Result[0];

                // ' detected but not in fastboot
                if (c.S.DeviceState == "Connected (ADB)") {
                    if (inf.Run(inf.lvls.Question, "Rebooting your device!",
                                  $"Now we need to reboot your device into fastboot mode to proceed with the installation.\n\n" +
                                  $"Please save your work then confirm the reboot.",
                                ("Reboot", "Cancel"))) {
                        dev.Reboot("bootloader");
                        SetProgressText.Run("Waiting for your device to enter fastboot...", inf.lvls.Information);
                        await fastboot.Run("wait-for-device"); // ''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        goto DeviceInFastboot;
                    } else {
                        inf.detail.code = $"{workCode_init}-uX";
                        // ErrorInfo = (0, "You have cancelled the process.")
                        log.Event("Fastboot Flash Cancelled", 1);
                        throw new Exception();
                    }
                } else if (!(c.S.DeviceState == "Fastboot mode")) {
                    if (c.S.DeviceState == "Disconnected") {// failsafe 
                        inf.detail.code = $"{workCode_init}-xX";
                    } else { // not adb and not fastboot and not disconnected 
                        inf.detail.code = $"{workCode_init}-rX";
                        // ErrorInfo = (0, $"We cannot reboot into fastboot while your device is in {S.DeviceState}.\n" & My.R.TroubleshootConnection)
                    }

                    throw new Exception();
                }



                // check bootloader state

                DeviceInFastboot:;

                if (!c.S.DeviceBootloaderUnlockSupported) {
                    // ' cancel if not unlockable
                    inf.detail.code = $"{workCode_init}-BLX";
                    // ErrorInfo = (1, "Bootloader unlock is not supported.") 'you can enable with checkbox
                    throw new Exception();
                }


                // If Not S.DeviceBootloaderUnlocked Then

                // 'ErrorInfo = (1, "Sorry we can't proceed with a locked bootloader")
                // 'Throw New Exception
                // End If

                // ' if unlockable  make sure it is unlocked ("fastboot oem device-info" -> "Device unlocked: true")

                if (!(await fastboot.Run("oem device-info")).Contains("Device unlocked: true")) {
                    inf.detail.code = $"{workCode_init}-BLuX";
                    // ErrorInfo = (1, $"Your device bootloader is locked.\nYou have to unlock the bootloader first or you will brick your device.")
                    throw new Exception();
                }

                // ' push zip to /sdcard/0/GeekAssistant tmp dir
                inf.detail.code = $"{workCode_init}-F";
                string fbFlashOutput = await fastboot.Run($"flash {imgtype} \"{img}\"");
                if (fbFlashOutput.Contains("error")) {
                    inf.detail.code = "FF-BLuX";
                    // ErrorInfo = (1, $"Your device bootloader is locked.\nYou have to unlock the bootloader first.")
                    throw new Exception();
                }

                log.AppendText(fbFlashOutput, -1);
                // Push(zip)
                // Dim zipInAndroid = $"/sdcard/0/GeekAssistant/{IO.Path.GetFileName(zip)}"
                inf.detail.code = $"{workCode_init}-rX";
            } catch (Exception ex) {
                wait.Run(false); // Close before error dialog 
                inf.detail.fullFatalError = ex.ToString();
                inf.Run();
            }

            wait.Run(false); // Close if Try was successful
            c.Working = false;
        }
    }
}
