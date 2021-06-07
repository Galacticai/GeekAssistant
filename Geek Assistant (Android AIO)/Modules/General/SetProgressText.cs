using GeekAssistant.Forms;
using System.Windows.Forms;

internal static class SetProgressText {


    // Private t As String
    // Private l As Integer

    // Delegate Sub SetLabelTextInvoker(text As String, level As Integer)
    public static void Run(string text, int ErrorLevel) {
        Home Home = c.Home;
        c.S.LastProgress = text;
        switch (ErrorLevel) {
            case -1: {
                Home.bar.Style = MetroFramework.MetroColorStyle.Green;
                break;
            }

            case 0: {
                Home.bar.Style = MetroFramework.MetroColorStyle.Orange;
                System.Media.SystemSounds.Beep.Play();
                break;
            }

            case 1: {
                Home.bar.Style = MetroFramework.MetroColorStyle.Red;
                Home.ProgressBarLabel.Text = $"({inf.detail.workCode}) {text}";
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
        }

        if (c.FormisRunning<Wait>())  //failsafe (avoid if no Wait) 
            c.Wait.Wait_ProgressText.Text = text;

        Home.ProgressBarLabel.Text = text;
        if (c.S.VerboseLogging & ErrorLevel == -1) {
            Log.AppendText(Home.ProgressBarLabel.Text, 1);
        }
    }
}