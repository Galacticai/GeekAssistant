
internal static partial class CheckConnectionIsCompatible {


    /// <param name="ErrorCode_init">Error code initials (XX)-yy</param>
    /// <returns>True if the device is ready for adb commands</returns>
    public static bool adbIsReady(string ErrorCode_init) {
        GA_SetProgressText.Run("Checking adb state...", -1);
        if (!adbIsCompatible(ErrorCode_init))
            return false; // connected
        if ((int)madb.GetListOfDevice()[0].State != 3)
            return false; // online
        return true;
    }

    /// <param name="ErrorCode_init">Error code initials (XX)-yy</param>
    /// <returns>True if the device is compatible with adb mode</returns>
    public static bool adbIsCompatible(string ErrorCode_init) {
        GA_SetProgressText.Run("Checking adb compatibility...", -1);
        if (!IsConnected(ErrorCode_init))
            return false;
        return true;
    }


    /// <param name="ErrorCode_init">Error code initials (XX)-yy</param>
    /// <returns>True if the device is ready for fastboot commands</returns>
    public static bool fbIsReady(string ErrorCode_init) {
        GA_SetProgressText.Run("Checking fastboot state...", -1);
        if (!fbIsCompatible(ErrorCode_init))
            return false;
        if ((int)madb.GetListOfDevice()[0].State != 1)
            return false; // bootloader
        return true;
    }
    /// <param name="ErrorCode_init">Error code initials (XX)-yy</param>
    /// <returns>True if the device is compatible with fastboot mode</returns>
    public static bool fbIsCompatible(string ErrorCode_init) {
        GA_SetProgressText.Run("Checking fastboot compatibility...", -1);
        if (!IsConnected(ErrorCode_init))
            return false;
        if (c.S.DeviceManufacturer == "Samsung") {
            c.ErrorInfo = ($"{ErrorCode_init}-DS", 1, $"Sorry we cannot access fastboot mode on Samsung devices.\n > Process Aborted."); // Unlock Bootloader - Device Samsung (Samsung is not supported)
            return false;
        }

        // if passed all then compatible
        return true;
    }

    /// <param name="ErrorCode_init">Error code initials (XX)-yy</param>
    /// <returns>True if 1 device is connected</returns>
    private static bool IsConnected(string ErrorCode_init) {
        if (string.IsNullOrEmpty(c.S.DeviceState))
            return false; // failsafe
        if (c.S.DeviceState == "" | c.S.DeviceState == "Disconnected") {
            AutoDetect.Run(true);
            if (c.S.DeviceState == "" | c.S.DeviceState == "Disconnected") {
                c.ErrorInfo = ($"{ErrorCode_init}-D0", 0, $"We haven't found any device.\n{prop.strings.TroubleshootConnection}"); // Unlock Bootloader - Device 0 (No device is connected)
                return false;
            }
        }

        if (c.S.DeviceState == "Multiple") {
            c.ErrorInfo = ($"{ErrorCode_init}-D2", 0, $"There are several devices connected.\nWould you mind keeping 1 and disconnecting the rest please?\n > Process Aborted."); // Unlock Bootloader - Device 2 or more (Multiple devices connected)
            return false;
        }

        return true;
    }
}