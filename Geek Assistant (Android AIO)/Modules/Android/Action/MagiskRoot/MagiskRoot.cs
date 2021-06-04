
using GeekAssistant.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

internal class MagiskRoot : MagiskRootCompanion {
    private static string workCode => "MR";
    private static string currentTitle => "Magisk Root";
    public static async void Run() {
        bool Cancelled = false;
        if (c.Working) {
            if (!Application.OpenForms.OfType<Info>().Any())
                inf.Run(inf.lvls.Error, currentTitle, prop.strings.WaitForCurrentProcess, null);
            return;
        }
        //Refresh current Home instance
        Home Home = null;
        //{
        foreach (Form home in Application.OpenForms)
            if (home.GetType() == typeof(Home))
                Home = (Home)home;
        //    if (Home == null) {
        //        inf.Run((workCode, inf.lvls.Error, currentTitle,
        //                 "We have encountered an error, but we can still continue with limited functionality.\n"
        //                 + "Do you want to continue with limited", null), ("Keep going", "Stop (Recommended)"));
        //        return;
        //    }
        //}
        if (Home != null) Home.bar.Value = 0;
        inf.currentTitle = currentTitle;
        c.Working = true;
        inf.detail.workCode = $"{workCode}-00"; // Unlock Bootloader - Start
        GA_Log.LogEvent(inf.currentTitle, 2);
        GA_Wait.Run(true);

        if (Home != null) Home.bar.Value = 0;
        try {
            //! template progress
            GA_SetProgressText.Run("Clearing previous device information.", -1);
            inf.detail = ($"{workCode}-CD", inf.lvls.FatalError, inf.currentTitle, "We had trouble while clearing previous device information.", null); // Auto Detect - Clear Device



            if (Home != null) Home.bar.Value = 100;
        } catch (Exception ex) {
            GA_Wait.Run(false); // Close before error dialog 
            inf.detail.fullFatalError = ex.ToString();
            inf.Run();
            if (!Cancelled)
                //! template error
                if (inf.Run(inf.lvls.Question, inf.currentTitle,
                              "We are sorry... Seems like we failed.\nDo you want to reboot your device?",
                            ("Reboot", "Cancel"))) {
                    //fbCMD.fbDo("reboot");
                }

        }
    }


}