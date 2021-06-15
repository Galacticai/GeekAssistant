
using Managed.Adb;
using System;
using System.Threading.Tasks;
using GeekAssistant.Modules.General;
using GeekAssistant.Modules.General.Companion;
using GeekAssistant.Modules.Android.Companion;

namespace GeekAssistant.Modules.Android {

    // (ROOT)
    // Remove screen lock: $"{workCode_init}b shell su -c rm /data/system/*.key" && $"{workCode_init}b shell su -c rm /data/system/locksettings*"
    // Hot reboot: $"{workCode_init}b shell su -c busybox killall system_server"
    // Clear dulvik cache: $"{workCode_init}b shell su -c rm -R /data/dalvik-cache"
    // Factory Reset: $"{workCode_init}b shell su -c recovery --wipe_data"
    // Root check: << "adb shell su" example >> "su: not found" 
    // Root check: << set uid= for /f "delims=" %%a in ('adb -s devicename shell "su 0 id -u 2>/dev/null"') do set uid=%%a && echo %uid%
    //             >> 0 or 1

    internal class AutoDetect {
        private const string workCode_init = "AD", workTitle = "Auto Detect";

        private static bool RunningInBetween = false;
        public static async Task Run(bool Silent = false) {

            //Refresh current home instance
            var home = c.Home;

            RunningInBetween = c.Working; //true if auto detecting while running another process
            c.Working = true;

            if (!RunningInBetween) inf.detail.title = workTitle;
            inf.detail.code =
                $"{(RunningInBetween ? $"{inf.detail.code}-" : string.Empty)}{workCode_init}-00"; // (RunningInBetween? {workCode_init} -) Auto Detect - Begin
            if (!Silent) log.Event(workTitle, 2);

            try {
                home.bar.Value = 0;
                if (!Silent) SetProgressText.Run("Clearing previous device information.", inf.lvls.Information);
                inf.detail = ($"{workCode_init}-CD", inf.lvls.FatalError, inf.detail.title, "We had trouble while clearing previous device information.", null); // Auto Detect - Clear Device
                GA_adb.ResetDeviceInfo();

                home.bar.Value = 2;
                if (!Silent) SetProgressText.Run("c.Preparing the environment... Please be patient.", inf.lvls.Information);

                inf.detail = ($"{workCode_init}-PE", inf.lvls.FatalError, inf.detail.title, "Things didn't go as planned while preparing the environment.", null); // Auto Detect - Prepare Environment
                await Task.Run(() => madb.madbBridge().Result);


                home.bar.Value = 5;
                if (!Silent) SetProgressText.Run("Counting the connected devices...", inf.lvls.Information);

                inf.detail = ($"{workCode_init}-Dc", inf.lvls.FatalError, inf.detail.title, "Math...oh no we couldn't count the devices.", null); // Auto Detect - Device count X
                switch (await Task.Run(() => madb.GetDeviceCount().Result)) {
                    case 0:
                        home.DeviceState_Label.Text = "Disconnected";
                        inf.detail = ($"{workCode_init}-D0", inf.lvls.Warn, inf.detail.title, $"We haven't found any device.{c.n}{prop.strings.TroubleshootConnection}", null); // Auto Detect - Device 0 (0 devices connected)
                        throw new Exception();
                    case > 1:
                        home.DeviceState_Label.Text = "Multiple";
                        inf.detail = ($"{workCode_init}-DX", inf.lvls.Warn, inf.detail.title, $"Oh there are several devices.{c.n}Would you mind keeping 1 and disconnecting the rest please?", null); // Auto Detect - Device X-number (More than 1 connected)
                        throw new Exception();
                }

                home.bar.Value = 7;
                if (!Silent) SetProgressText.Run("Communicating with your device...", inf.lvls.Information);

                inf.detail = ($"{workCode_init}-Ds", inf.lvls.Warn, inf.detail.title, "We have trouble reading your device.", null); // Auto Detect - Device count (failed to count devices)
                string DeviceState_String = "Device is ";
                switch (madb.GetDeviceState().Result) {
                    case DeviceState.Unknown: // unknown 
                        home.DeviceState_Label.Text = "Unknown";
                        DeviceState_String += $"in an unknown state...{c.n}{prop.strings.TroubleshootConnection}";
                        inf.detail = ($"{workCode_init}-DU", inf.lvls.Information, inf.detail.title, DeviceState_String, null); // Auto Detect - Device 0 (No devices connected)
                        throw new Exception();
                    case DeviceState.Offline: // offline 
                        home.DeviceState_Label.Text = "Offline";
                        DeviceState_String += $"offline. {c.n}{prop.strings.TroubleshootConnection}";
                        inf.detail = ($"{workCode_init}-DO", inf.lvls.Warn, inf.detail.title, DeviceState_String, null); // Auto Detect - Device Offline (PC not allowed to debug device)
                        throw new Exception();
                    case DeviceState.Recovery: // recovery 
                        home.DeviceState_Label.Text = "Recovery mode";
                        DeviceState_String += $"in recovery mode.{c.n}Please enter adb mode and try again."; // Please enter adb mode or reboot to system and try again."
                        inf.detail = ($"{workCode_init}-DR", inf.lvls.Warn, inf.detail.title, DeviceState_String, null); // Auto Detect - Device Recovery
                        throw new Exception();
                    case DeviceState.Download: // download 
                        home.DeviceState_Label.Text = "Download mode";
                        DeviceState_String += $"in download mode.{c.n}Please enter adb mode and try again.";
                        inf.detail = ($"{workCode_init}-DD", inf.lvls.Warn, inf.detail.title, DeviceState_String, null); // Auto Detect - Device Download
                        throw new Exception();

                    // ^^   All the above will jump to >> catch (Exception ex) { >>  ^^
                    // vv              All the below will continue code              vv

                    case DeviceState.BootLoader: // bootloader 
                        DeviceState_String += $"in fastboot mode.";
                        home.DeviceState_Label.Text = "Fastboot mode";
                        inf.detail.code = $"{workCode_init}-DF"; // Auto Detect - Device Fastboot
                        home.bar.Value = 10;
                        if (!Silent) {
                            var DeviceInFastboot_ContinueAsk =
                                inf.Run(inf.lvls.Question, $"{DeviceState_String}",
                                          $"We cannot read much in this mode.{c.n}Do you want to continue detection in fastboot mode?",
                                        ("Continue", "Close"));
                            if (DeviceInFastboot_ContinueAsk) {
                                inf.detail.lvl = inf.lvls.Error;
                                inf.Run(inf.lvls.Error, inf.detail.title,
                                       $"Oh no this is currently unavailable.{c.n}{prop.strings.FeatureUnavailable}");
                            }
                            // later maybe will be implemented
                            // ''''''''''''''''''''''''''''''''
                            else {
                                SetProgressText.Run("Detection cancelled by user.", 0);
                            }
                        }
                        break;

                    case DeviceState.Online: // online 
                        home.bar.Value = 10;
                        inf.detail = ($"{workCode_init}-DlX", inf.lvls.Error, inf.detail.title, "Sorry we can't see your device anymore...", null);// Auto Detect - Device list X
                        Device dev = madb.GetListOfDevice().Result[0]; // Set dev as first device
                        DeviceState_String += $"in adb mode.";
                        home.DeviceState_Label.Text = "Connected (ADB)";
                        home.bar.Value = 11;

                        inf.detail = ($"{workCode_init}-D-m", inf.lvls.Error, inf.detail.title, "Failed to check your device manufacturer information.", null); // Auto Detect - Device - manufacturer
                        if (!Silent)
                            SetProgressText.Run("Fetching device manufacturer, model, and codename...", inf.lvls.Information);

                        home.bar.Value = 13;

                        home.bar.Value = 15;
                        c.S.DeviceManufacturer =
                            GA_adb.FixManufacturerString(
                                cmd.madbShell(dev, "getprop ro.product.manufacturer").Result);
                        c.S.Save();
                        home.Manufacturer_ComboBox.Text = c.S.DeviceManufacturer;

                        inf.detail = ($"{workCode_init}-D-mc", inf.lvls.Error, inf.detail.title, "Failed to check your device model or codename.", null);// Auto Detect - Device - model codename
                        if (!Silent) log.AppendText($" ❱ {c.S.DeviceManufacturer} {dev.Model} ({dev.Product})", 1);

                        home.bar.Value = 17;

                        inf.detail = ($"{workCode_init}-D-s", inf.lvls.Error, inf.detail.title, "Failed to check your device serial number.", null);// Auto Detect - Device - serial
                        if (!Silent)
                            SetProgressText.Run("Fetching device serial#...", inf.lvls.Information);

                        c.S.DeviceSerial = dev.SerialNumber;
                        c.S.Save();
                        if (!Silent) log.AppendText($" | Serial: {c.S.DeviceSerial}", 1);

                        home.bar.Value = 20;

                        inf.detail = ($"{workCode_init}-D-su", inf.lvls.Error, inf.detail.title, "Failed to check your device root status.", null);// Auto Detect - Device - su
                        if (!Silent)
                            SetProgressText.Run("Fetching root state...", inf.lvls.Information);

                        c.S.DeviceRooted = dev.CanSU();
                        c.S.Save();
                        home.Rooted_Checkbox.Checked = c.S.DeviceRooted;
                        if (!Silent) log.AppendText($" | Rooted: {convert.Bool.ToYesNo(c.S.DeviceRooted)}", 1);

                        home.bar.Value = 23;

                        inf.detail = ($"{workCode_init}-D-bb", inf.lvls.Error, inf.detail.title, "Failed to check your device busybox availability.", null);// Auto Detect - Device - busybox
                        if (!Silent) SetProgressText.Run("Fetching busybox availability...", inf.lvls.Information);

                        c.S.DeviceBusyBoxReady = dev.BusyBox.Available;
                        c.S.Save();
                        if (!Silent) log.AppendText($" | Busybox available: {convert.Bool.ToYesNo(c.S.DeviceBusyBoxReady)}", 1);

                        home.bar.Value = 25;

                        inf.detail = ($"{workCode_init}-D-blu", inf.lvls.Error, inf.detail.title, "Failed to check your device bootloader unlock support.", null); // Auto Detect - Device - bootloader unlock
                        if (!Silent) SetProgressText.Run("Fetching bootloader unlock support state...", inf.lvls.Information);

                        home.bar.Value = 26;
                        c.S.DeviceBootloaderUnlockSupported =
                             convert.String.ToBool(cmd.madbShell(dev, "getprop ro.oem_unlock_supported").Result);
                        c.S.Save();
                        home.BootloaderUnlockable_CheckBox.Checked = c.S.DeviceBootloaderUnlockSupported;
                        home.bar.Value = 27;
                        if (!Silent) log.AppendText($" | Bootloader unlock allowed: {convert.Bool.ToYesNo(c.S.DeviceBootloaderUnlockSupported)}", 1);

                        home.bar.Value = 30;

                        inf.detail = ($"{workCode_init}-D-al", inf.lvls.Error, inf.detail.title, "Failed to check your device API level.", null);// Auto Detect - Device - API level
                        if (!Silent) SetProgressText.Run("Fetching Android API level...", inf.lvls.Information);

                        home.bar.Value = 32;
                        c.S.DeviceAPILevel = Convert.ToInt32(cmd.madbShell(dev, $"getprop {Device.PROP_BUILD_API_LEVEL}"));
                        c.S.Save();
                        inf.detail = ($"{workCode_init}-D-atv", inf.lvls.Error, inf.detail.title, "Failed to convert the API level to Android version.", null);// Auto Detect - Device - API level version
                        home.AndroidVersion_ComboBox.Text = GA_adb.ConvertAPILevelToAVer(c.S.DeviceAPILevel)[1];
                        if (!Silent) SetProgressText.Run("Converting API level to Android name...", inf.lvls.Information);

                        home.bar.Value = 33;
                        if (!Silent) log.AppendText($" | Android version: {GA_adb.ConvertAPILevelToAVer(c.S.DeviceAPILevel)[0]} (API: {c.S.DeviceAPILevel})", 1);

                        home.bar.Value = 35;
                        inf.detail = ($"{workCode_init}-D-b", inf.lvls.Error, inf.detail.title, "Failed to check your device battery level.", null); // Auto Detect - Device - battery
                        if (!Silent) SetProgressText.Run("Fetching battery level...", inf.lvls.Information);

                        home.bar.Value = 36;
                        string batteryString;
                        if (dev.GetBatteryInfo().Present) {
                            c.S.DeviceBatteryLevel = dev.GetBatteryInfo().Level;
                            batteryString = $"{c.S.DeviceBatteryLevel}%";
                        } else {
                            c.S.DeviceBatteryLevel = -1; // no level. Not present
                            if (!Silent) SetProgressText.Run("Battery not present!", inf.lvls.Information);
                            batteryString = "❌";
                        }
                        c.S.Save();
                        home.bar.Value = 38;
                        if (!Silent) log.AppendText($" | Battery: {batteryString}", 1);

                        home.bar.Value = 40;
                        if (!Silent) SetProgressText.Run(DeviceState_String, inf.lvls.Information); // This is after retrieving info to stay written in Progress Text

                        break;
                }

                home.bar.Value = 100;
            } catch (Exception ex) {
                if (!RunningInBetween) wait.Run(false); // Close before error dialog
                if (!Silent) {
                    inf.detail.fullFatalError = ex.ToString();
                    inf.Run();
                } else home.DoNeutral();
            }

            c.S.DeviceState = home.DeviceState_Label.Text;
            if (!RunningInBetween) wait.Run(false); // Close if Try was successful
            c.Working = RunningInBetween;
        }
    }
}
