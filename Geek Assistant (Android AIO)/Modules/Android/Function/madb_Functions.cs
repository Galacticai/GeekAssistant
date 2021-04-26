using System.Collections.Generic;
using Managed;

internal static partial class madb {

    /// <summary>
    /// Get adb server at $"{GA_tools}\adb.exe"
    /// </summary>
    /// <param name="forceNewBridge">Kill previous server if true</param>
    /// <returns>Managed.Adb.AndroidDebugBridge</returns>
    public static Managed.Adb.AndroidDebugBridge madbBridge(bool forceNewBridge = false) {
        return Managed.Adb.AndroidDebugBridge.CreateBridge($@"{c.GA_tools}\adb.exe", forceNewBridge); // .Start()
    }
    /// <summary>
    /// Start adb server at $"{GA_tools}\adb.exe"
    /// </summary>
    /// <param name="forceNewBridge">Kill previous server if true</param>
    public static void madbBridgeStart(bool forceNewBridge = false) {
        madbBridge(forceNewBridge).Start(); // .Start()
    }
    /// <summary>
    /// Terminate madb
    /// </summary>
    public static void madbStop() {
        Managed.Adb.AndroidDebugBridge.Terminate();
    }

    /// <summary>
    /// Count how many devices are currently connected
    /// </summary>
    /// <returns>Get the count of madb_DeviceList() </returns>
    public static int GetDeviceCount() {
        madbBridge(); // Failsafe 
        return GetListOfDevice().Count;
    }

    /// <returns>Get a list of the devices connected as List(Of Managed.Adb.Device)</returns>
    public static List<Managed.Adb.Device> GetListOfDevice() {
        madbBridge(); // Failsafe  
        return Managed.Adb.AdbHelper.Instance.GetDevices(Managed.Adb.AndroidDebugBridge.SocketAddress);
    }

    /// <summary>
    /// Check if any connected device serial# matches the input serial# and return as Managed.Adb.Device
    /// </summary>
    /// <param name="serial">Serial number to check against the connected devices</param>
    /// <returns>Get the Managed.Adb.Device that matches the serial number</returns>
    public static Managed.Adb.Device GetDeviceFromSerial(string serial) {
        madbBridge(); // Failsafe
        List<Managed.Adb.Device> devices = Managed.Adb.AdbHelper.Instance.GetDevices(Managed.Adb.AndroidDebugBridge.SocketAddress);
        foreach (Managed.Adb.Device dev in devices) {
            if (dev.SerialNumber == serial)
                return dev;
        }

        return default;
    }

    /// <summary>
    /// Get the state of the first device connected
    /// </summary>
    /// <returns>(Integer): 0 recovery | 1 bootloader | 2 offline | 3 online | 4 download | 5 unknown</returns>
    public static int GetDeviceState() {
        madbBridge(); // Failsafe
        return (int)GetListOfDevice()[0].State;
    }
    /// <summary>
    /// Converts madb_GetDeviceState() to the corresponding string
    /// </summary>
    /// <returns>(String): 0 recovery | 1 bootloader | 2 offline | 3 online | 4 download | 5 unknown</returns>
    public static string Convert_DeviceState_IntToString() {
        string result = "";
        switch (GetDeviceState()) {

        case 0: {
            result = "recovery";
            break;
        }

        case 1: {
            result = "bootloader";
            break;
        }

        case 2: {
            result = "offline";
            break;
        }

        case 3: {
            result = "online";
            break;
        }

        case 4: {
            result = "download";
            break;
        }

        case 5: {
            result = "unknown";
            break;
        }
        }

        return result;
    }

    /// <param name="ErrorCode_init">Error Beginning "(XX)-xx"</param>
    /// <returns>True if Device is can SU</returns>
    public static bool madb_IsRooted(string ErrorCode_init) {
        var dev = GetListOfDevice()[0];
        if (!dev.CanSU()) {
            c.ErrorInfo = ($"{ErrorCode_init}-Xsu", 1, $"Your device is not rooted.\n > Process aborted."); // X su (Device cannot run su)
            return false;
        }

        return true;
    }
}