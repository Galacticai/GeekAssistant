﻿
using GeekAssistant.Forms;
using System;
using GeekAssistant.Modules.General;

namespace GeekAssistant.Modules.Android.MagiskRoot {

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
            inf.detail.title = workTitle;
            c.Working = true;
            inf.detail.code = $"{workCode_init}-00"; // Unlock Bootloader - Start
            log.Event(inf.detail.title, 2);
            wait.Run(true);

            home.bar.Value = 0;
            try {
                //! template progress
                SetProgressText.Run("Clearing previous device information.", inf.lvls.Information);
                inf.detail = ($"{workCode_init}-CD", inf.lvls.FatalError, inf.detail.title, "We had trouble while clearing previous device information.", null); // Auto Detect - Clear Device



                home.bar.Value = 100;
            } catch (Exception ex) {
                wait.Run(false); // Close before error dialog 
                inf.detail.fullFatalError = ex.ToString();
                inf.Run();
                if (!Cancelled)
                    //! template error
                    if (inf.Run(inf.lvls.Question, inf.detail.title,
                                  "We are sorry... Seems like we failed.\nDo you want to reboot your device?",
                                ("Reboot", "Cancel")))
                        /*fbCMD.Run("reboot")*/
                        ;


            }
        }
    }
}
