using GeekAssistant.Forms;
using System.Windows.Forms;

internal static partial class SetProgressText {


    // Private t As String
    // Private l As Integer

    // Delegate Sub SetLabelTextInvoker(text As String, level As Integer)
    public static void Run(string text, int ErrorLevel) {
        Home Home = (Home)Application.OpenForms["Home"];
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

        if ((Wait)Application.OpenForms["Wait"] != null) { //failsafe (avoid if no Wait)
            Wait Wait = (Wait)Application.OpenForms["Wait"];
            Wait.Wait_ProgressText.Text = text;
        }

        Home.ProgressBarLabel.Text = text;
        if (c.S.VerboseLogging & ErrorLevel == -1) {
            Log.LogAppendText(Home.ProgressBarLabel.Text, 1);
        }
    }
}