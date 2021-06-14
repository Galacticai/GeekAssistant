using System.Collections.Generic;
using System.Threading.Tasks;
using GeekAssistant.Modules.General;
using GeekAssistant.Modules.General.Companion;

namespace GeekAssistant.Modules.Android.Companion {
    internal static class madb {

        /// <summary>
        /// Get adb server at $"{GA_tools}\adb.exe"
        /// </summary>
        /// <param name="forceNewBridge">Kill previous server if true</param>
        /// <returns>Managed.Adb.AndroidDebugBridge</returns>
        public static async Task<Managed.Adb.AndroidDebugBridge> madbBridge(bool forceNewBridge = false)
            => await Task.Run(() => Managed.Adb.AndroidDebugBridge.CreateBridge($@"{c.GA_tools}\adb.exe", forceNewBridge)); // .Start()

        /// <summary>
        /// Start adb server at $"{GA_tools}\adb.exe"
        /// </summary>
        /// <param name="forceNewBridge">Kill previous server if true</param>
        public static async void madbBridgeStart(bool forceNewBridge = false)
            => await Task.Run(() => madbBridge(forceNewBridge).Start());

        /// <summary>  Terminate madb </summary>
        public static void madbStop()
            => Managed.Adb.AndroidDebugBridge.Terminate();

        /// <summary> Count how many devices are currently connected </summary>
        /// <returns>Get the count of madb_DeviceList() </returns>
        public static async Task<int> GetDeviceCount() {
            await madbBridge(); // Failsafe 
            return GetListOfDevice().Result.Count;
        }

        /// <returns>Get a list of the devices connected as List(Of Managed.Adb.Device)</returns>
        public static async Task<List<Managed.Adb.Device>> GetListOfDevice() {
            await madbBridge(); // Failsafe  
            return Managed.Adb.AdbHelper.Instance.GetDevices(Managed.Adb.AndroidDebugBridge.SocketAddress);
        }

        /// <summary>
        /// Check if any connected device serial# matches the input serial# and return as Managed.Adb.Device
        /// </summary>
        /// <param name="serial">Serial number to check against the connected devices</param>
        /// <returns>Get the Managed.Adb.Device that matches the serial number</returns>
        public static async Task<Managed.Adb.Device> GetDeviceFromSerial(string serial) {
            await madbBridge();
            List<Managed.Adb.Device> devices = Managed.Adb.AdbHelper.Instance.GetDevices(Managed.Adb.AndroidDebugBridge.SocketAddress);
            foreach (Managed.Adb.Device dev in devices)
                if (dev.SerialNumber == serial)
                    return dev;
            return default;
        }

        /// <summary>
        /// Get the state of the first device connected
        /// </summary>
        /// <returns>(Integer): 0 recovery | 1 bootloader | 2 offline | 3 online | 4 download | 5 unknown</returns>
        public static async Task<Managed.Adb.DeviceState> GetDeviceState() {
            await madbBridge(); // Failsafe
            return GetListOfDevice().Result[0].State;
        }
        ///// <summary>
        ///// Converts madb_GetDeviceState() to the corresponding string
        ///// </summary>
        ///// <returns>(String): 0 recovery | 1 bootloader | 2 offline | 3 online | 4 download | 5 unknown</returns>
        //public static Task<string> Convert_DeviceState_IntToString( )
        //    => Task.Run(() => (GetDeviceState().Result) switch {
        //        0 => "recovery",
        //        1 => "bootloader",
        //        2 => "offline",
        //        3 => "online",
        //        4 => "download",
        //        5 => "unknown",
        //        _ => "unknown"
        //    });

        /// <returns>True if Device is can SU</returns>
        public static bool madb_IsRooted() {
            var dev = GetListOfDevice().Result[0];
            if (!dev.CanSU()) {
                inf.detail = ($"{txt.GA_current_workCode }-Xsu", // No su (Device cannot run su)
                              inf.lvls.Error, inf.detail.title, $"Your device is not rooted.\n > Process aborted.", null);
                return false;
            }
            return true;
        }
    }
}