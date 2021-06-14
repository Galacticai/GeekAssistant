using GeekAssistant.Forms;
using System.Windows.Forms;

namespace GeekAssistant.Modules.General {
    internal static class SetProgressText {

        // Private t As String
        // Private l As Integer

        // Delegate Sub SetLabelTextInvoker(text As String, level As Integer)
        public static void Run(string text, inf.lvls lvl = inf.lvls.Information) {
            Home Home = c.Home;
            c.S.LastProgress = text;
            switch (lvl) {
                case inf.lvls.Information:
                    Home.bar.Style = MetroFramework.MetroColorStyle.Green;
                    break;
                case inf.lvls.Warn:
                    Home.bar.Style = MetroFramework.MetroColorStyle.Orange;
                    System.Media.SystemSounds.Beep.Play();
                    break;
                case inf.lvls.Error:
                case inf.lvls.FatalError:
                    Home.bar.Style = MetroFramework.MetroColorStyle.Red;
                    Home.ProgressBarLabel.Text = $"({inf.detail.code}) {text}";
                    System.Media.SystemSounds.Asterisk.Play();
                    return;
            }

            if (c.FormisRunning<Wait>())  //failsafe (avoid if no Wait) 
                c.Wait.Wait_ProgressText.Text = text;

            Home.ProgressBarLabel.Text = text;
            if (c.S.VerboseLogging & lvl == inf.lvls.Information)
                log.AppendText(Home.ProgressBarLabel.Text, 1);
        }
    }
}
