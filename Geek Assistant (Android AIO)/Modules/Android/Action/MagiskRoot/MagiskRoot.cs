﻿
using GeekAssistant.Forms;
using System;
using System.Windows.Forms;

class MagiskRoot : MagiskRootHelper {
    private static Home Home = null;
    public static void Run() {
        //Refresh current Home instance
        foreach (Form home in Application.OpenForms)
            if (home.GetType() == typeof(Home))
                Home = (Home)home;


        inf.currentTitle = "Auto Detect";
        c.Working = true;
        inf.detail.code = "AD-00";  // adb Auto - Begin

        GA_Log.LogEvent("Magisk Root", 2);

        Home.bar.Value = 0;
        try {
            GA_SetProgressText.Run("Clearing previous device information.", -1);
            inf.detail = ("AD-CD", inf.lvls.FatalError, inf.currentTitle, "We had trouble while clearing previous device information.", null); // Auto Detect - Clear Device
            string url = MagiskAPK_url;
            if (url == "") throw new Exception();


            Home.bar.Value = 100;
        } catch (Exception ex) {
            GA_Wait.Run(false); // Close before error dialog

            inf.detail.fullFatalError = ex.ToString();
            inf.Run();

        }
    }


}