
using GeekAssistant.Forms;
using System;
using System.Windows.Forms;

internal class MagiskRoot : MagiskRootCompanion {
    private static Home Home = null;
    public static async void Run() {
        bool Cancelled = false;
        if (c.Working) {
            inf.Run(inf.lvls.Error, "Magisk Root", prop.strings.WaitForCurrentProcess, null);
            return;
        }
        //Refresh current Home instance
        foreach (Form home in Application.OpenForms)
            if (home.GetType() == typeof(Home))
                Home = (Home)home;


        Home Home = new Home();
        Home.bar.Value = 0;
        inf.currentTitle = "Unlock Bootloader";
        c.Working = true;
        inf.detail.workCode = "UB-00"; // Unlock Bootloader - Start
        GA_Log.LogEvent(inf.currentTitle, 2);
        GA_Wait.Run(true);

        Home.bar.Value = 0;
        try {
            //! template progress
            GA_SetProgressText.Run("Clearing previous device information.", -1);
            inf.detail = ("AD-CD", inf.lvls.FatalError, inf.currentTitle, "We had trouble while clearing previous device information.", null); // Auto Detect - Clear Device



            Home.bar.Value = 100;
        } catch (Exception ex) {
            GA_Wait.Run(false); // Close before error dialog

            inf.detail.fullFatalError = ex.ToString();
            inf.Run();

        }
    }


}