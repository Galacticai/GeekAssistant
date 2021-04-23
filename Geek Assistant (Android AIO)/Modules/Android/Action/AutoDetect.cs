using System;
using GeekAssistant.Forms;
using Managed;

internal static partial class AutoDetect {

    // Private ErrorInfo As (lvl As Integer, msg As String)
    public static void Run(bool Silent = false) {
        // madbStart(True).Start()

        // (ROOT) 
        // Remove screen lock: "adb shell su -c rm /data/system/*.key" && "adb shell su -c rm /data/system/locksettings*"
        // Hot reboot: "adb shell su -c busybox killall system_server"
        // Clear dulvik cache: "adb shell su -c rm -R /data/dalvik-cache"
        // Factory Reset: "adb shell su -c recovery --wipe_data"

        common.Working = true;
        common.ErrorInfo.code="AD-00";  // adb Auto - Begin
        if (!Silent)
            GA_Log.LogEvent("Auto Detect", 2);
        common.Home.ProgressBar.Value = 0;
        try {
            if (!Silent)
                GA_SetProgressText.Run("Clearing previous device information.", -1);
            common.ErrorInfo = ("AD-CD", 10, "We had trouble while clearing previous device information."); // Auto Detect - Clear Device
            GA_adb_Functions.ResetDeviceInfo();
            common.Home.ProgressBar.Value = 2;
            if (!Silent)
                GA_SetProgressText.Run("Preparing the environment... Please be patient.", -1);
            common.ErrorInfo = ("AD-PE", 10, "Things didn't go as planned while preparing the environment."); // Auto Detect - Prepare Environment
            madb.madbBridge();
            common.Home.ProgressBar.Value = 5;
            if (!Silent)
                GA_SetProgressText.Run("Counting the connected devices...", -1);
            common.ErrorInfo = ("AD-Dc", 10, "Math...oh no we couldn't count the devices."); // Auto Detect - Device count X
            switch (madb.GetDeviceCount()) {
            case 0: {
                common.Home.DeviceState_Label.Text = "Disconnected";
                common.ErrorInfo = ("AD-D0", 0, $"We haven't found any device.\n{prop.strings.TroubleshootConnection}"); // Auto Detect - Device 0 (0 devices connected) 
                throw new Exception(); 
            }

            case var @case when @case > 1: {
                common.Home.DeviceState_Label.Text = "Multiple";
                common.ErrorInfo = ("AD-DX", 0, $"Oh there are several devices.\nWould you mind keeping 1 and disconnecting the rest please?"); // Auto Detect - Device X-number (More than 1 connected)
                throw new Exception(); 
            }
            }

            common.Home.ProgressBar.Value = 7;
            if (!Silent)
                GA_SetProgressText.Run("Communicating with your device...", -1);
            common.ErrorInfo = ("AD-Ds", 1, "We have trouble reading your device."); // Auto Detect - Device count (failed to count devices)
            string DeviceState_String = "Device is ";
            switch (madb.GetDeviceState()) {
            case 5: // unknown
                {
                common.Home.DeviceState_Label.Text = "Unknown";
                DeviceState_String += $"in an unknown state...\n{prop.strings.TroubleshootConnection}";
                ErrorInfo = ("AD-DU", -1, DeviceState_String); // Auto Detect - Device 0 (No devices connected) 
                throw new Exception(); 
            }

            case 2: // offline
                {
                common.Home.DeviceState_Label.Text = "Offline";
                DeviceState_String += $"offline. \n{prop.strings.TroubleshootConnection}";
                common.ErrorInfo = ("AD-DO", 0, DeviceState_String); // Auto Detect - Device Offline (PC not allowed to debug device) 
                throw new Exception(); 
            }

            case 0: // recovery
                {
                common.Home.DeviceState_Label.Text = "Recovery mode";
                DeviceState_String += $"in recovery mode.\nPlease enter adb mode and try again."; // Please enter adb mode or reboot to system and try again."
                common.ErrorInfo = ("AD-DR", 0, DeviceState_String); // Auto Detect - Device Recovery 
                throw new Exception(); 
            }

            case 4: // download
                {
                common.Home.DeviceState_Label.Text = "Download mode";
                DeviceState_String += $"in download mode.\nPlease enter adb mode and try again.";
                common.ErrorInfo = ("AD-DD", 0, DeviceState_String); // Auto Detect - Device Download 
                throw new Exception(); 
            }

            // ^^   All the above will jump to > Catch e As Exception   ^^
            // vv            All the below will continue code           vv

            case 1: // bootloader 
                {
                DeviceState_String += $"in fastboot mode.";
                common.Home.DeviceState_Label.Text = "Fastboot mode";
                common.ErrorInfo.code = "AD-DF"; // Auto Detect - Device Fastboot
                common.Home.ProgressBar.Value = 10;
                if (!Silent) {
                    var DeviceInFastboot_ContinueAsk = GA_infoAsk.Run($"{DeviceState_String}", $"We cannot read much in this mode.\nDo you want to continue detection in fastboot mode?", "Continue", "Cancel");
                    if (DeviceInFastboot_ContinueAsk) {
                        common.ErrorInfo.lvl = 1;
                        GA_Msg.DoMsg(1, $"Oh no this is currently unavailable.\n{prop.strings.FeatureUnavailable}", 2);
                    }
                    // later maybe will be implemented 
                    // ''''''''''''''''''''''''''''''''

                    else {
                        GA_SetProgressText.Run("Detection cancelled by user.", 0);
                    }
                }

                break;
            }

            case 3: // online
                {
                common.Home.ProgressBar.Value = 10;
                common.ErrorInfo = ("AD-DlX", 10, "Sorry we can't see your device anymore..."); // Auto Detect - Device list X
                Managed.Adb.Device dev = madb.GetListOfDevice()[0]; // Set dev as first device
                DeviceState_String += $"in adb mode.";
                common.Home.DeviceState_Label.Text = "Connected (ADB)";
                common.Home.ProgressBar.Value = 11;
                common.ErrorInfo = ("AD-D-m", 1, "Failed to check your device manufacturer information."); // Auto Detect - Device - manufacturer
                if (!Silent)
                    GA_SetProgressText.Run("Fetching device manufacturer, model, and codename...", -1);
                var Manufacturer_CommandResultReceiver = new Managed.Adb.CommandResultReceiver();
                common.Home.ProgressBar.Value = 13;
                dev.ExecuteShellCommand($"getprop ro.product.manufacturer", Manufacturer_CommandResultReceiver);
                common.Home.ProgressBar.Value = 15;
                common.S.DeviceManufacturer =  GA_adb_Functions.FixManufacturerString((string)Manufacturer_CommandResultReceiver.Result);
                common.S.Save();
                common.Home.Manufacturer_ComboBox.Text = common.S.DeviceManufacturer;
                common.ErrorInfo = ("AD-D-mc", 1, "Failed to check your device model or codename."); // Auto Detect - Device - model codename
                if (!Silent)
                    GA_Log.LogAppendText($" ❱ {common.S.DeviceManufacturer} {dev.Model} ({dev.Product})", 1);
                common.Home.ProgressBar.Value = 17;
                common.ErrorInfo = ("AD-D-s", 1, "Failed to check your device serial number."); // Auto Detect - Device - serial
                if (!Silent)
                    GA_SetProgressText.Run("Fetching device serial#...", -1);
                common.S.DeviceSerial = dev.SerialNumber;
                common.S.Save();
                if (!Silent)
                    GA_Log.LogAppendText($" | Serial: {common.S.DeviceSerial}", 1);
                common.Home.ProgressBar.Value = 20;
                common.ErrorInfo = ("AD-D-su", 1, "Failed to check your device root status."); // Auto Detect - Device - su
                if (!Silent)
                    GA_SetProgressText.Run("Fetching root state...", -1);
                common.S.DeviceRooted = dev.CanSU();
                common.S.Save();
                common.Home.Rooted_Checkbox.Checked = common.S.DeviceRooted;
                if (!Silent)
                    GA_Log.LogAppendText($" | Rooted: {txt.ConvertBoolYesNo(common.S.DeviceRooted)}", 1);
                common.Home.ProgressBar.Value = 23;
                common.ErrorInfo = ("AD-D-bb", 1, "Failed to check your device busybox availability."); // Auto Detect - Device - busybox
                if (!Silent)
                    GA_SetProgressText.Run("Fetching busybox availability...", -1);
                common.S.DeviceBusyBoxReady = dev.BusyBox.Available;
                common.S.Save();
                if (!Silent)
                    GA_Log.LogAppendText($" | Busybox available: {txt.ConvertBoolYesNo(common.S.DeviceBusyBoxReady)}", 1);
                common.Home.ProgressBar.Value = 25;
                common.ErrorInfo = ("AD-D-blu", 1, "Failed to check your device bootloader unlock support."); // Auto Detect - Device - bootloader unlock
                if (!Silent)
                    GA_SetProgressText.Run("Fetching bootloader unlock support state...", -1);
                var BLunlockable_CommandResultReceiver = new Managed.Adb.CommandResultReceiver();
                common.Home.ProgressBar.Value = 26;
                dev.ExecuteShellCommand($"getprop ro.oem_unlock_supported", BLunlockable_CommandResultReceiver);
                common.S.DeviceBootloaderUnlockSupported = Convert.ToBoolean( BLunlockable_CommandResultReceiver.Result);
                common.S.Save();
                common.Home.BootloaderUnlockable_CheckBox.Checked = common.S.DeviceBootloaderUnlockSupported;
                common.Home.ProgressBar.Value = 27;
                if (!Silent)
                    GA_Log.LogAppendText($" | Bootloader unlock allowed: {txt.ConvertBoolYesNo(common.S.DeviceBootloaderUnlockSupported)}", 1);
                common.Home.ProgressBar.Value = 30;
                common.ErrorInfo = ("AD-D-al", 1, "Failed to check your device API level."); // Auto Detect - Device - API level
                if (!Silent)
                    GA_SetProgressText.Run("Fetching Android API level...", -1);
                var API_CommandResultReceiver = new Managed.Adb.CommandResultReceiver();
                common.Home.ProgressBar.Value = 31;
                dev.ExecuteShellCommand($"getprop {Managed.Adb.Device.PROP_BUILD_API_LEVEL}", API_CommandResultReceiver);
                common.Home.ProgressBar.Value = 32;
                common.S.DeviceAPILevel = Convert.ToInt32(API_CommandResultReceiver.Result);
                common.S.Save();
                common.ErrorInfo = ("AD-D-atv", 1, "Failed to convert the API level to Android version."); // Auto Detect - Device - API to Version
                common.Home.AndroidVersion_ComboBox.Text = GA_adb_Functions.ConvertAPILevelToAVer(common.S.DeviceAPILevel)[1];
                if (!Silent)
                    GA_SetProgressText.Run("Converting API level to Android name...", -1);
                common.Home.ProgressBar.Value = 33;
                if (!Silent)
                    GA_Log.LogAppendText($" | Android version: {GA_adb_Functions.ConvertAPILevelToAVer(common.S.DeviceAPILevel)[0]} (API: {common.S.DeviceAPILevel})", 1);
                common.Home.ProgressBar.Value = 35;
                common.ErrorInfo = ("AD-D-b", 1, "Failed to check your device battery level."); // Auto Detect - Device - battery
                if (!Silent)
                    GA_SetProgressText.Run("Fetching battery level...", -1);
                common.Home.ProgressBar.Value = 36;
                string batteryString;
                if (dev.GetBatteryInfo().Present) {
                    common.S.DeviceBatteryLevel = dev.GetBatteryInfo().Level;
                    batteryString = $"{common.S.DeviceBatteryLevel}%";
                } else {
                    common.S.DeviceBatteryLevel = -1; // no level. Not present
                    if (!Silent)
                        GA_SetProgressText.Run("Battery not present!", -1);
                    batteryString = "❌";
                } 
                common.S.Save();
                common.Home.ProgressBar.Value = 38;
                if (!Silent)
                    GA_Log.LogAppendText($" | Battery: {batteryString}", 1);
                common.Home.ProgressBar.Value = 40;
                if (!Silent)
                    GA_SetProgressText.Run(DeviceState_String, -1); // This is after retrieving info to stay written in Progress Text
                break;
            }
            }

            common.Home.ProgressBar.Value = 100;
        } catch (Exception ex) {
            GA_PleaseWait.Run(false); // Close before error dialog
            if (!Silent) {
                GA_Msg.DoMsg(common.ErrorInfo.lvl, common.ErrorInfo.msg, 2, ex.ToString());
            } else {
                common.Home.DoNeutral();
            }
        }

        common.S.DeviceState = common.Home.DeviceState_Label.Text;
        GA_PleaseWait.Run(false); // Close if Try was successful
        common.Working = false;
    }
}