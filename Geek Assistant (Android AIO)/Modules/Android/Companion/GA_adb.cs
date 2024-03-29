﻿using System.Collections.Generic;
using System.IO;
using GeekAssistant.Modules.General;
using GeekAssistant.Modules.Android.Companion.Essentials;
using System.Threading.Tasks;

namespace GeekAssistant.Modules.Android.Companion {
    internal static class GA_adb {

        /// <summary>
        /// Capitalize the first letter. And "lge" becomes "LG"
        /// </summary>
        /// <param name="ManufacturerString">Raw string to work on and fix</param>
        /// <returns>ManufacturerString As String</returns>
        public static string FixManufacturerString(string ManufacturerString) {
            string mStr = ManufacturerString.ToString();
            mStr = mStr.Substring(0, 1).ToUpper() + mStr.Substring(1).ToLower();
            if (mStr == "Lge") mStr = "LG"; // Special case for LG  
            return mStr;
        }

        /// <summary>
        /// Pushes Wsource path to {/sdcard/0/GeekAssistant/}(FileName.extension)"
        /// </summary>
        /// <param name="Wsource">Path(Folder\FileName) to push to Android</param>
        /// <param name="customAdestination">(Optional) Custom destination path(Folder/) on Android (Default: {/sdcard/0/GeekAssistant/}...)</param>
        public static async Task adb_Push(string Wsource, string customAdestination = "/sdcard/0/GeekAssistant/") {
            await adb.Run($"push \"{Wsource}\" \"{customAdestination}{Path.GetFileName(Wsource)}\"");
        }

        /// <summary>
        /// Pulls Asource path from Android to Wdestination path on Windows
        /// </summary>
        /// <param name="Asource">Source path(Folder/fileName) to pull from Android</param>
        /// <param name="Wdestination">Destination path(Folder\) on Windows </param>
        public static async Task Adb_Pull(string Asource, string Wdestination) {
            await adb.Run($@"pull ""{Asource}"" ""{Wdestination}""");
        }

        private static Dictionary<int, string[]> _ApiToVer;
        public static Dictionary<int, string[]> ApiToVer {
            get {
                if (_ApiToVer.Count > 0) return _ApiToVer;

                _ApiToVer.Clear();
                string K_ = "KitKat 4.4 (And Below)",
                       L_ = "Lollipop 5.x",
                       M_ = "Marshmallow 6.x",
                       N_ = "Nougat 7.x",
                       O_ = "Oreo 8.x",
                       P_ = "Pie 9.x",
                       Q_ = "Android 10 Q",
                       R_ = "Android 11 R (And Above)";
                {
                    var av = _ApiToVer;
                    av.Add(1, new[] { "1.0", K_ });
                    av.Add(2, new[] { "1.1", K_ });
                    av.Add(3, new[] { "Cupcake 1.5", K_ });
                    av.Add(4, new[] { "Donut 1.6", K_ });
                    av.Add(5, new[] { "Eclair 2.0", K_ });
                    av.Add(6, new[] { "Eclair 2.0", K_ });
                    av.Add(7, new[] { "Eclair 2.1", K_ });
                    av.Add(8, new[] { "Froyo 2.2", K_ });
                    av.Add(9, new[] { "Gingerbread 2.3", K_ });
                    av.Add(10, new[] { "Gingerbread 2.3", K_ });
                    av.Add(11, new[] { "Honeycomb 3.0", K_ });
                    av.Add(12, new[] { "Honeycomb 3.1", K_ });
                    av.Add(13, new[] { "Honeycomb 3.2", K_ });
                    av.Add(14, new[] { "ICS 4.0", K_ });
                    av.Add(15, new[] { "ICS 4.0", K_ });
                    av.Add(16, new[] { "Jelly Bean 4.1", K_ });
                    av.Add(17, new[] { "Jelly Bean 4.2", K_ });
                    av.Add(18, new[] { "Jelly Bean 4.3", K_ });
                    av.Add(19, new[] { "KitKat 4.4", K_ });
                    av.Add(21, new[] { "Lollipop 5.0", L_ });
                    av.Add(22, new[] { "Lollipop 5.1", L_ });
                    av.Add(23, new[] { "Marshmallow 6.0", M_ });
                    av.Add(24, new[] { "Nougat 7.0", N_ });
                    av.Add(25, new[] { "Nougat 7.1", N_ });
                    av.Add(26, new[] { "Oreo 8.0", O_ });
                    av.Add(27, new[] { "Oreo 8.1", O_ });
                    av.Add(28, new[] { P_, P_ });
                    av.Add(29, new[] { Q_, Q_ });
                    av.Add(30, new[] { R_, R_ });
                }
                return _ApiToVer;
            }
        }
        // Public Sub PrepareDeviceInfo(APIlevel As Integer, Manufacturer As Boolean, Count As Boolean)
        // If S.DeviceManufacturer.Length > 0 Then
        // GA_SetProgressText.Run("Detected previous device info.", 0)
        // Else GA_SetProgressText.Run("No previous device info. Setting default values.", 0)
        // End If
        // 'If Not APIlevel = 0 Then
        // DetermineVersionFromSDK_OLD(APIlevel, False)

        // If Manufacturer And S.DeviceManufacturer.Length > 0 Then
        // Main.Manufacturer_ComboBox.Text = FixManufacturerString(S.DeviceManufacturer)
        // End If
        // 'If AndroidVersion And S.DeviceAPILevel > 0 Then
        // '    Main.AndroidVersion_ComboBox.Text = 
        // 'End If
        // If Count And S.DeviceState <> "Disconnected" Then
        // Main.DeviceState_Label.Text = S.DeviceState
        // End If
        // End Sub

        // Private AnyStringArray As String()
        // Public Sub DetermineVersionFromSDK_OLD(APIlevel As Integer, Optional GetMain As Boolean = False)
        // Dim APINull As Boolean = False
        // If ApiToVer.Count = 0 Then PrepareAndroidDictionary()

        // If GetMain Then
        // GA_SetProgressText.Run("Converting api level to version string...", 0)
        // ApiToVer.TryGetValue(APIlevel, AnyStringArray)
        // GA_SetProgressText.Run("Setting api version string...", 0)
        // AndroidVersion = AnyStringArray(0)
        // Else
        // If APIlevel = 0 And S.DeviceAPILevel > 0 Then
        // APIlevel = S.DeviceAPILevel
        // ElseIf S.DeviceAPILevel = 0 Then
        // AndroidVersion = "Select Android Version"
        // APINull = True
        // End If
        // If Not APINull Then
        // ApiToVer.TryGetValue(APIlevel, AnyStringArray)
        // AndroidVersion = AnyStringArray(1)
        // End If
        // Main.AndroidVersion_ComboBox.Text = AndroidVersion
        // End If
        // End Sub

        public static string[] ConvertAPILevelToAVer(int APIint, bool silent = false) {
            if (APIint <= 0) {
                if (!silent) inf.Run(inf.lvls.FatalError, inf.detail.title, "Error while processing your device API level!");
                return new[] { "❌", "❌" };
            }
            ApiToVer.TryGetValue(APIint, out string[] disposableDictionary);
            return disposableDictionary;
        }

        /*public static int ConvertAVerToAPILevel(string AVer) {
            if (string.IsNullOrEmpty(AVer))
                return 0;
            // DoMsg(10, "Error while processing your device Android Version!", 2)
            // Return 0
            string K_ = "KitKat 4.4 (And Below)";
            string L_ = "Lollipop 5.x";
            string M_ = "Marshmallow 6.x";
            string N_ = "Nougat 7.x";
            string O_ = "Oreo 8.x";
            string P_ = "Pie 9.x";
            string Q_ = "Android 10 Q";
            string R_ = "Android 11 R (And Above)";
            int result = 0;
            return AVer switch {
                1 => "lalala",
                2 => "blalbla",
                3 => "lolollo",
                _ => "default"
            };
            switch (AVer) {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
            case 16:
            case 17:
            case 18:
            case 19: {
                result = Conversions.ToInteger(K_); break;
            }
            case 21:
            case 22: {
                result = Conversions.ToInteger(L_); break;
            }

            case 23: {
                result = Conversions.ToInteger(M_);
                break;
            }

            case 24:
            case 25: {
                result = Conversions.ToInteger(Q_);
                break;
            }

            case 26:
            case 27: {
                result = Conversions.ToInteger(Q_);
                break;
            }

            case 29: {
                result = Conversions.ToInteger(Q_);
                break;
            }

            case 30: {
                result = Conversions.ToInteger(R_);
                break;
            }
            }

            return result;
        }*/

        public static void ResetDeviceInfo() {
            {
                c.S.DeviceAPILevel = 0;
                c.S.DeviceBatteryLevel = 0;
                c.S.DeviceBootloaderUnlockSupported = false;
                c.S.DeviceCount = 0;
                c.S.DeviceCustomRecovery = false;
                c.S.DeviceCustomROM = false;
                c.S.DeviceManufacturer = "";
                c.S.DeviceRooted = false;
                c.S.DeviceSerial = "";
                c.S.DeviceState = "";
            }
            //Refresh current home instance 
            var home = c.Home;
            home.Manufacturer_ComboBox.SelectedIndex = -1;
            home.AndroidVersion_ComboBox.SelectedIndex = -1;
            home.BootloaderUnlockable_CheckBox.Checked = false;
            home.Rooted_Checkbox.Checked = false;
            home.CustomROM_CheckBox.Checked = false;
            home.CustomRecovery_CheckBox.Checked = false;
        }

        public static async Task<string> HotReboot() {
            var scr = new Managed.Adb.CommandResultReceiver();
            var dev = madb.GetListOfDevice().Result[0];
            if (!(await madb.madb_IsRooted())) {
                inf.Run();
                return "";
            }
            if (!dev.BusyBox.Available) await InitializeBusybox.Run(true);

            await Task.Run(() => dev.ExecuteRootShellCommand($"busybox killall system_server", scr));
            return scr.Result;
        }
    }
}