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

        c.Working = true;
        c.ErrorInfo.code = "AD-00";  // adb Auto - Begin
        if (!Silent)
            GA_Log.LogEvent("Auto Detect", 2);
        c.Home.bar.Value = 0;
        try {
            if (!Silent)
                GA_SetProgressText.Run("Clearing previous device information.", -1);
            c.ErrorInfo = ("AD-CD", 10, "We had trouble while clearing previous device information."); // Auto Detect - Clear Device
            GA_adb_Functions.ResetDeviceInfo();
            c.Home.bar.Value = 2;
            if (!Silent)
                GA_SetProgressText.Run("Preparing the environment... Please be patient.", -1);
            c.ErrorInfo = ("AD-PE", 10, "Things didn't go as planned while preparing the environment."); // Auto Detect - Prepare Environment
            madb.madbBridge();
            c.Home.bar.Value = 5;
            if (!Silent)
                GA_SetProgressText.Run("Counting the connected devices...", -1);
            c.ErrorInfo = ("AD-Dc", 10, "Math...oh no we couldn't count the devices."); // Auto Detect - Device count X
            switch (madb.GetDeviceCount()) {
            case 0: {
                c.Home.DeviceState_Label.Text = "Disconnected";
                c.ErrorInfo = ("AD-D0", 0, $"We haven't found any device.\n{prop.strings.TroubleshootConnection}"); // Auto Detect - Device 0 (0 devices connected) 
                throw new Exception();
            }

            case var @case when @case > 1: {
                c.Home.DeviceState_Label.Text = "Multiple";
                c.ErrorInfo = ("AD-DX", 0, $"Oh there are several devices.\nWould you mind keeping 1 and disconnecting the rest please?"); // Auto Detect - Device X-number (More than 1 connected)
                throw new Exception();
            }
            }

            c.Home.bar.Value = 7;
            if (!Silent)
                GA_SetProgressText.Run("Communicating with your device...", -1);
            c.ErrorInfo = ("AD-Ds", 1, "We have trouble reading your device."); // Auto Detect - Device count (failed to count devices)
            string DeviceState_String = "Device is ";
            switch (madb.GetDeviceState()) {
            case 5: // unknown
                {
                c.Home.DeviceState_Label.Text = "Unknown";
                DeviceState_String += $"in an unknown state...\n{prop.strings.TroubleshootConnection}";
                c.ErrorInfo = ("AD-DU", -1, DeviceState_String); // Auto Detect - Device 0 (No devices connected) 
                throw new Exception();
            }

            case 2: // offline
                {
                c.Home.DeviceState_Label.Text = "Offline";
                DeviceState_String += $"offline. \n{prop.strings.TroubleshootConnection}";
                c.ErrorInfo = ("AD-DO", 0, DeviceState_String); // Auto Detect - Device Offline (PC not allowed to debug device) 
                throw new Exception();
            }

            case 0: // recovery
                {
                c.Home.DeviceState_Label.Text = "Recovery mode";
                DeviceState_String += $"in recovery mode.\nPlease enter adb mode and try again."; // Please enter adb mode or reboot to system and try again."
                c.ErrorInfo = ("AD-DR", 0, DeviceState_String); // Auto Detect - Device Recovery 
                throw new Exception();
            }

            case 4: // download
                {
                c.Home.DeviceState_Label.Text = "Download mode";
                DeviceState_String += $"in download mode.\nPlease enter adb mode and try again.";
                c.ErrorInfo = ("AD-DD", 0, DeviceState_String); // Auto Detect - Device Download 
                throw new Exception();
            }

            // ^^   All the above will jump to > Catch e As Exception   ^^
            // vv            All the below will continue code           vv

            case 1: // bootloader 
                {
                DeviceState_String += $"in fastboot mode.";
                c.Home.DeviceState_Label.Text = "Fastboot mode";
                c.ErrorInfo.code = "AD-DF"; // Auto Detect - Device Fastboot
                c.Home.bar.Value = 10;
                if (!Silent) {
                    var DeviceInFastboot_ContinueAsk = GA_infoAsk.Run($"{DeviceState_String}", $"We cannot read much in this mode.\nDo you want to continue detection in fastboot mode?", "Continue", "Cancel");
                    if (DeviceInFastboot_ContinueAsk) {
                        c.ErrorInfo.lvl = 1;
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
                c.Home.bar.Value = 10;
                c.ErrorInfo = ("AD-DlX", 10, "Sorry we can't see your device anymore..."); // Auto Detect - Device list X
                Managed.Adb.Device dev = madb.GetListOfDevice()[0]; // Set dev as first device
                DeviceState_String += $"in adb mode.";
                c.Home.DeviceState_Label.Text = "Connected (ADB)";
                c.Home.bar.Value = 11;
                c.ErrorInfo = ("AD-D-m", 1, "Failed to check your device manufacturer information."); // Auto Detect - Device - manufacturer
                if (!Silent)
                    GA_SetProgressText.Run("Fetching device manufacturer, model, and codename...", -1);
                var Manufacturer_CommandResultReceiver = new Managed.Adb.CommandResultReceiver();
                c.Home.bar.Value = 13;
                dev.ExecuteShellCommand($"getprop ro.product.manufacturer", Manufacturer_CommandResultReceiver);
                c.Home.bar.Value = 15;
                c.S.DeviceManufacturer = GA_adb_Functions.FixManufacturerString((string)Manufacturer_CommandResultReceiver.Result);
                c.S.Save();
                c.Home.Manufacturer_ComboBox.Text = c.S.DeviceManufacturer;
                c.ErrorInfo = ("AD-D-mc", 1, "Failed to check your device model or codename."); // Auto Detect - Device - model codename
                if (!Silent)
                    GA_Log.LogAppendText($" ❱ {c.S.DeviceManufacturer} {dev.Model} ({dev.Product})", 1);
                c.Home.bar.Value = 17;
                c.ErrorInfo = ("AD-D-s", 1, "Failed to check your device serial number."); // Auto Detect - Device - serial
                if (!Silent)
                    GA_SetProgressText.Run("Fetching device serial#...", -1);
                c.S.DeviceSerial = dev.SerialNumber;
                c.S.Save();
                if (!Silent)
                    GA_Log.LogAppendText($" | Serial: {c.S.DeviceSerial}", 1);
                c.Home.bar.Value = 20;
                c.ErrorInfo = ("AD-D-su", 1, "Failed to check your device root status."); // Auto Detect - Device - su
                if (!Silent)
                    GA_SetProgressText.Run("Fetching root state...", -1);
                c.S.DeviceRooted = dev.CanSU();
                c.S.Save();
                c.Home.Rooted_Checkbox.Checked = c.S.DeviceRooted;
                if (!Silent)
                    GA_Log.LogAppendText($" | Rooted: {txt.ConvertBoolYesNo(c.S.DeviceRooted)}", 1);
                c.Home.bar.Value = 23;
                c.ErrorInfo = ("AD-D-bb", 1, "Failed to check your device busybox availability."); // Auto Detect - Device - busybox
                if (!Silent)
                    GA_SetProgressText.Run("Fetching busybox availability...", -1);
                c.S.DeviceBusyBoxReady = dev.BusyBox.Available;
                c.S.Save();
                if (!Silent)
                    GA_Log.LogAppendText($" | Busybox available: {txt.ConvertBoolYesNo(c.S.DeviceBusyBoxReady)}", 1);
                c.Home.bar.Value = 25;
                c.ErrorInfo = ("AD-D-blu", 1, "Failed to check your device bootloader unlock support."); // Auto Detect - Device - bootloader unlock
                if (!Silent)
                    GA_SetProgressText.Run("Fetching bootloader unlock support state...", -1);
                var BLunlockable_CommandResultReceiver = new Managed.Adb.CommandResultReceiver();
                c.Home.bar.Value = 26;
                dev.ExecuteShellCommand($"getprop ro.oem_unlock_supported", BLunlockable_CommandResultReceiver);
                c.S.DeviceBootloaderUnlockSupported = Convert.ToBoolean(BLunlockable_CommandResultReceiver.Result);
                c.S.Save();
                c.Home.BootloaderUnlockable_CheckBox.Checked = c.S.DeviceBootloaderUnlockSupported;
                c.Home.bar.Value = 27;
                if (!Silent)
                    GA_Log.LogAppendText($" | Bootloader unlock allowed: {txt.ConvertBoolYesNo(c.S.DeviceBootloaderUnlockSupported)}", 1);
                c.Home.bar.Value = 30;
                c.ErrorInfo = ("AD-D-al", 1, "Failed to check your device API level."); // Auto Detect - Device - API level
                if (!Silent)
                    GA_SetProgressText.Run("Fetching Android API level...", -1);
                var API_CommandResultReceiver = new Managed.Adb.CommandResultReceiver();
                c.Home.bar.Value = 31;
                dev.ExecuteShellCommand($"getprop {Managed.Adb.Device.PROP_BUILD_API_LEVEL}", API_CommandResultReceiver);
                c.Home.bar.Value = 32;
                c.S.DeviceAPILevel = Convert.ToInt32(API_CommandResultReceiver.Result);
                c.S.Save();
                c.ErrorInfo = ("AD-D-atv", 1, "Failed to convert the API level to Android version."); // Auto Detect - Device - API to Version
                c.Home.AndroidVersion_ComboBox.Text = GA_adb_Functions.ConvertAPILevelToAVer(c.S.DeviceAPILevel)[1];
                if (!Silent)
                    GA_SetProgressText.Run("Converting API level to Android name...", -1);
                c.Home.bar.Value = 33;
                if (!Silent)
                    GA_Log.LogAppendText($" | Android version: {GA_adb_Functions.ConvertAPILevelToAVer(c.S.DeviceAPILevel)[0]} (API: {c.S.DeviceAPILevel})", 1);
                c.Home.bar.Value = 35;
                c.ErrorInfo = ("AD-D-b", 1, "Failed to check your device battery level."); // Auto Detect - Device - battery
                if (!Silent)
                    GA_SetProgressText.Run("Fetching battery level...", -1);
                c.Home.bar.Value = 36;
                string batteryString;
                if (dev.GetBatteryInfo().Present) {
                    c.S.DeviceBatteryLevel = dev.GetBatteryInfo().Level;
                    batteryString = $"{c.S.DeviceBatteryLevel}%";
                } else {
                    c.S.DeviceBatteryLevel = -1; // no level. Not present
                    if (!Silent)
                        GA_SetProgressText.Run("Battery not present!", -1);
                    batteryString = "❌";
                }
                c.S.Save();
                c.Home.bar.Value = 38;
                if (!Silent)
                    GA_Log.LogAppendText($" | Battery: {batteryString}", 1);
                c.Home.bar.Value = 40;
                if (!Silent)
                    GA_SetProgressText.Run(DeviceState_String, -1); // This is after retrieving info to stay written in Progress Text
                break;
            }
            }

            c.Home.bar.Value = 100;
        } catch (Exception ex) {
            GA_PleaseWait.Run(false); // Close before error dialog
            if (!Silent) {
                GA_Msg.DoMsg(c.ErrorInfo.lvl, c.ErrorInfo.msg, 2, ex.ToString());
            } else {
                c.Home.DoNeutral();
            }
        }

        c.S.DeviceState = c.Home.DeviceState_Label.Text;
        GA_PleaseWait.Run(false); // Close if Try was successful
        c.Working = false;
    }
}