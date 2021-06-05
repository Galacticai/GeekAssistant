using System.IO;
using System.Windows.Forms;
internal static partial class InitializeBusybox {
    private static string workCode_init => "BB";
    private static string workTitle => "Initialize Busybox";
    public static void Run(bool silent) {
        if (c.Working) { //dont change inf.workTitle while working
            inf.Run(inf.lvls.Error, workTitle, prop.strings.WaitForCurrentProcess);
            return;
        }
        inf.workTitle = workTitle;
        c.Working = true;
        inf.detail.workCode = $"{workCode_init}-00";
        if (!inf.Run(inf.lvls.Question, "madb_MakeBusyboxReady",
                       "This is not finished. Go?",
                     ("Go", "Cancel"))) {
            return;
        }

        inf.Run(inf.lvls.Error, "(Disabled) " + inf.workTitle,
                "This has been disabled by the developer");
        var dev = madb.GetListOfDevice().Result[0];
        if (dev.BusyBox.Available)
            goto Finish_madb_InstallBusyboxReady;


        if (!File.Exists($"{c.GA_tools}\\busybox"))
            PrepareAppdata.Run();


        adbCMD.adbDo("shell mkdir /data/busybox");
        Log.LogAppendText($"<< shell mkdir /data/busybox\n>>\n{adbCMD.adbOutput}", 1);
        if (adbCMD.adbOutput.ToLower().Contains("denied")) {
            adbCMD.adbDo("shell su -c 'mkdir /data/busybox'");
            Log.LogAppendText($"<< shell su -c 'mkdir /data/busybox'\n>>\n{adbCMD.adbOutput}", 1);
        } else if (adbCMD.adbOutput.ToLower().Contains("file exists")) {
            adbCMD.adbDo("shell su -c 'rm -rf /data/busybox'");
            Log.LogAppendText($"<< shell su -c 'rm -rf /data/busybox'\n>>\n{adbCMD.adbOutput}", 1);
        }

        adbCMD.adbDo($@"push ""{c.GA_tools}\busybox"" /sdcard/0/GeekAssistant/busybox");
        Log.LogAppendText($"<< push \"{c.GA_tools}\\busybox\" /sdcard/0/GeekAssistant/busybox\n>>\n{adbCMD.adbOutput}", 1);
        adbCMD.adbDo($"shell su -c 'mv /sdcard/0/GeekAssistant/busybox /data/busybox'");
        Log.LogAppendText($"<< shell su -c 'mv /sdcard/0/GeekAssistant/busybox /data/busybox'\n>>\n{adbCMD.adbOutput}", 1);
        adbCMD.adbDo("shell su -c 'chmod 664 /data/busybox'");
        Log.LogAppendText($"<< shell su -c 'chmod 664 /data/busybox'\n>>\n{adbCMD.adbOutput}", 1);
        adbCMD.adbDo("shell su -c './data/busybox --install'");
        Log.LogAppendText($"<< shell su -c './data/busybox --install'\n>>\n{adbCMD.adbOutput}", 1);
        if (dev.BusyBox.Available) MessageBox.Show("busybox available");
        else MessageBox.Show("busybox not installed");

        // adb shell mkdir /data/busybox
        // adb push busybox /data/busybox
        // adb shell
        // su
        // cd / Data / busybox
        // chmod 775 busybox
        // ./busybox --install
        // busybox

        return;

        //// Dim bbInstall = dev.BusyBox.Install($"{GA_tools}\busybox")
        //if (bbInstall) {
        //    // ErrorInfo = (1, "We had trouble while installing busybox.")
        //    goto Finish_madb_InstallBusyboxReady;
        //}
        // ErrorInfo = (0, "Busybox is set and ready for use.")
        Finish_madb_InstallBusyboxReady:;

        //if (!silent) inf.Run(inf.detail.lvl, inf.detail.msg, 1);
        c.Working = false;
    }
}