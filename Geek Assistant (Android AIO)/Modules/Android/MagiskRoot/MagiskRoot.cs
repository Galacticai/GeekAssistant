﻿
using GeekAssistant.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

internal class MagiskRoot : MagiskRootCompanion {
    private const string workCode_init = "MR", workTitle = "Magisk Root";
    public static async void Run() {
        bool Cancelled = false;
        if (c.Working) {
            if (!Application.OpenForms.OfType<Info>().Any())
                inf.Run(inf.lvls.Error, workTitle, prop.strings.WaitForCurrentProcess, null);
            return;
        }
        //Refresh current Home instance
        Home Home = null;
        //{
        foreach (Form home in Application.OpenForms)
            if (home.GetType() == typeof(Home))
                Home = (Home)home;
        //    if (Home == null) {
        //        inf.Run((workCode, inf.lvls.Error, workTitle,
        //                 "We have encountered an error, but we can still continue with limited functionality.\n"
        //                 + "Do you want to continue with limited", null), ("Keep going", "Stop (Recommended)"));
        //        return;
        //    }
        //}
        if (Home != null) Home.bar.Value = 0;
        inf.workTitle = workTitle;
        c.Working = true;
        inf.detail.workCode = $"{workCode_init}-00"; // Unlock Bootloader - Start
        Log.LogEvent(inf.workTitle, 2);
        GAwait.Run(true);

        if (Home != null) Home.bar.Value = 0;
        try {
            //! template progress
            SetProgressText.Run("Clearing previous device information.", -1);
            inf.detail = ($"{workCode_init}-CD", inf.lvls.FatalError, inf.workTitle, "We had trouble while clearing previous device information.", null); // Auto Detect - Clear Device



            if (Home != null) Home.bar.Value = 100;
        } catch (Exception ex) {
            GAwait.Run(false); // Close before error dialog 
            inf.detail.fullFatalError = ex.ToString();
            inf.Run();
            if (!Cancelled)
                //! template error
                if (inf.Run(inf.lvls.Question, inf.workTitle,
                              "We are sorry... Seems like we failed.\nDo you want to reboot your device?",
                            ("Reboot", "Cancel"))) {
                    //fbCMD.Run("reboot");
                }

        }
    }


}