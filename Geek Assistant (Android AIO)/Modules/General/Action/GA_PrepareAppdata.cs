using System.IO;

internal static partial class GA_PrepareAppdata {
    public static void Run() {
        if (!Directory.Exists(GA))
            Directory.CreateDirectory(GA);
        if (!Directory.Exists(GA_tools))
            Directory.CreateDirectory(GA_tools);
        if (!File.Exists($@"{GA_tools}\adb.exe"))
            File.WriteAllBytes($@"{GA_tools}\adb.exe", My.Res.tools.adb);
        if (!File.Exists($@"{GA_tools}\AdbWinApi.dll"))
            File.WriteAllBytes($@"{GA_tools}\AdbWinApi.dll", My.Res.tools.AdbWinApi);
        if (!File.Exists($@"{GA_tools}\AdbWinUsbApi.dll"))
            File.WriteAllBytes($@"{GA_tools}\AdbWinUsbApi.dll", My.Res.tools.AdbWinUsbApi);
        if (!File.Exists($@"{GA_tools}\fastboot.exe"))
            File.WriteAllBytes($@"{GA_tools}\fastboot.exe", My.Res.tools.fastboot);
        if (!File.Exists($@"{GA_tools}\busybox"))
            File.WriteAllBytes($@"{GA_tools}\busybox", My.Res.tools.busybox);
    }
}