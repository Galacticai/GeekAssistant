
internal static partial class ConnectionIsCompatible {


    /// <param name="ErrorCode_init">Error code initials (XX)-yy</param>
    /// <returns>True if the device is ready for adb commands</returns>
    public static bool adbIsReady() {
        GA_SetProgressText.Run("Checking adb state...", -1);
        if (!adbIsCompatible()) return false; // connected 
        if ((int)madb.GetListOfDevice().Result[0].State != 3) return false; // online 
        return true;
    }

    /// <param name="ErrorCode_init">Error code initials (XX)-yy</param>
    /// <returns>True if the device is compatible with adb mode</returns>
    public static bool adbIsCompatible() {
        GA_SetProgressText.Run("Checking adb compatibility...", -1);
        if (!IsConnected()) return false;
        return true;
    }


    /// <param name="ErrorCode_init">Error code initials (XX)-yy</param>
    /// <returns>True if the device is ready for fastboot commands</returns>
    public static bool fbIsReady() {
        GA_SetProgressText.Run("Checking fastboot state...", -1);
        if (!fbIsCompatible()) return false;
        if ((int)madb.GetListOfDevice().Result[0].State != 1) return false; // bootloader 
        return true;
    }
    /// <param name="ErrorCode_init">Error code initials (XX)-yy</param>
    /// <returns>True if the device is compatible with fastboot mode</returns>
    public static bool fbIsCompatible() {
        GA_SetProgressText.Run("Checking fastboot compatibility...", -1);
        if (!IsConnected()) return false;

        if (c.S.DeviceManufacturer == "Samsung") {
            inf.detail = ($"{txt.GA_current_workCode}-DS{(c.S.DeviceAPILevel <= 25 ? "o" : "n")}",  // Unlock Bootloader - Device Samsung (Samsung is not supported) (api<=25? old | new)
                inf.lvls.Error, inf.workTitle,
                $"Sorry we cannot access fastboot mode on Samsung devices.\n > Process Aborted.", null);
            return false;
        }
        return true;
    }

    /// <param name="ErrorCode_init">Error code initials (XX)-yy</param>
    /// <returns>True if 1 device is connected</returns>
    private static bool IsConnected() {
        if (string.IsNullOrEmpty(c.S.DeviceState)) return false; // failsafe

        if (c.S.DeviceState == "" | c.S.DeviceState == "Disconnected") {
            AutoDetect.Run(true);
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