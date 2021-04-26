using System.IO;

internal static partial class GA_PrepareAppdata {
    public static void Run() {
        if (!Directory.Exists(common.GA))
            Directory.CreateDirectory(common.GA);
        if (!Directory.Exists(common.GA_tools))
            Directory.CreateDirectory(common.GA_tools);
        if (!File.Exists($@"{common.GA_tools}\adb.exe"))
            File.WriteAllBytes($@"{common.GA_tools}\adb.exe", prop.tools.adb);
        if (!File.Exists($@"{common.GA_tools}\AdbWinApi.dll"))
            File.WriteAllBytes($@"{common.GA_tools}\AdbWinApi.dll", prop.tools.AdbWinApi);
        if (!File.Exists($@"{common.GA_tools}\AdbWinUsbApi.dll"))
            File.WriteAllBytes($@"{common.GA_tools}\AdbWinUsbApi.dll", prop.tools.AdbWinUsbApi);
        if (!File.Exists($@"{common.GA_tools}\fastboot.exe"))
            File.WriteAllBytes($@"{common.GA_tools}\fastboot.exe", prop.tools.fastboot);
        if (!File.Exists($@"{common.GA_tools}\busybox"))
            File.WriteAllBytes($@"{common.GA_tools}\busybox", prop.tools.busybox);
    }
}