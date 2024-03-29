﻿
using GeekAssistant.Modules.General;
using GeekAssistant.Modules.General.Companion;
using System.Threading.Tasks;

namespace GeekAssistant.Modules.Android.Companion {
    internal static class devConnection {

        /// <returns>True if the device is ready for adb commands</returns>
        public static async Task<bool> adbIsReady() {
            SetProgressText.Run("Checking adb state...", inf.lvls.Information);
            if (!(await adbIsCompatible())) return false; // connected 
            if ((int)madb.GetListOfDevice().Result[0].State != 3) return false; // online 
            return true;
        }
        /// <returns>True if the device is compatible with adb mode</returns>
        public static async Task<bool> adbIsCompatible() {
            SetProgressText.Run("Checking adb compatibility...", inf.lvls.Information);
            if (!(await IsConnected())) return false;
            return true;
        }

        /// <returns>True if the device is ready for fastboot commands</returns>
        public static async Task<bool> fbIsReady() {
            SetProgressText.Run("Checking fastboot state...", inf.lvls.Information);
            if (!(await fbIsCompatible())) return false;
            if ((int)madb.GetListOfDevice().Result[0].State != 1) return false; // bootloader 
            return true;
        }
        /// <returns>True if the device is compatible with fastboot mode</returns>
        public static async Task<bool> fbIsCompatible() {
            SetProgressText.Run("Checking fastboot compatibility...", inf.lvls.Information);
            if (!(await IsConnected())) return false;

            if (c.S.DeviceManufacturer == "Samsung") {
                inf.detail = ($"{txt.GA_current_workCode}-DS{(c.S.DeviceAPILevel <= 25 ? "o" : "n")}",  // Unlock Bootloader - Device Samsung (Samsung is not supported) (api<=25? old | new)
                    inf.lvls.Error, inf.detail.title,
                    $"Sorry we cannot access fastboot mode on Samsung devices.\n > Process Aborted.", null);
                return false;
            }
            return true;
        }

        /// <returns>True if 1 device is connected</returns>
        private static async Task<bool> IsConnected() {
            if (string.IsNullOrEmpty(c.S.DeviceState)) return false; // failsafe

            if (c.S.DeviceState == "" | c.S.DeviceState == "Disconnected") {
                await AutoDetect.Run(true);
                if (c.S.DeviceState == "" | c.S.DeviceState == "Disconnected") {
                    inf.detail = ($"{txt.GA_current_workCode}-D0", inf.lvls.Warn, $"We haven't found any device.", $"{prop.strings.TroubleshootConnection}", null); // Unlock Bootloader - Device 0 (No device is connected)
                    return false;
                }
            }
            if (c.S.DeviceState == "Multiple") {
                inf.detail = ($"{txt.GA_current_workCode}-D2", inf.lvls.Warn, $"There are several devices connected.", "Would you mind keeping 1 and disconnecting the rest please?\n > Process Aborted.", null); // Unlock Bootloader - Device 2 or more (Multiple devices connected)
                return false;
            }
            return true;
        }
    }
}
