
using GeekAssistant.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

internal class MagiskRoot : MagiskRootCompanion {
    private const string workCode_init = "MR", workTitle = "Magisk Root";
    public static async void Run() {
        bool Cancelled = false;
        if (c.Working) {
            if (!c.FormisRunning<Info>())
                inf.Run(inf.lvls.Error, workTitle, prop.strings.WaitForCurrentProcess, null);
            return;
        }
        //Refresh current home instance
        using var home = c.Home;

        home.bar.Value = 0;
        inf.workTitle = workTitle;
        c.Working = true;
        inf.detail.workCode = $"{workCode_init}-00"; // Unlock Bootloader - Start
        Log.LogEvent(inf.workTitle, 2);
        GAwait.Run(true);

        home.bar.Value = 0;
        try {
            //! template progress
            SetProgressText.Run("Clearing previous device information.", -1);
            inf.detail = ($"{workCode_init}-CD", inf.lvls.FatalError, inf.workTitle, "We had trouble while clearing previous device information.", null); // Auto Detect - Clear Device



            home.bar.Value = 100;
        } catch (Exception ex) {
            GAwait.Run(false); // Close before error dialog 
            inf.detail.fullFatalError = ex.ToString();
            inf.Run();
            if (!Cancelled)
                //! template error
                if (inf.Run(inf.lvls.Question, inf.workTitle,
                              "We are sorry... Seems like we failed.\nDo you want to reboot your device?",
                            ("Reboot", "Cancel")))
                    /*fbCMD.Run("reboot")*/
                    ;


        }
    }


}