using GeekAssistant.Forms;
using System.Windows.Forms;

internal static partial class GA_PleaseWait {
    private static PleaseWait PleaseWait = new PleaseWait();
    public static void Run(bool Enable) {
        if (Enable) {
            if (!PleaseWait.IsDisposed) PleaseWait.Dispose();
            PleaseWait = new PleaseWait();
            PleaseWait.Show();
        } else {
            foreach (Form pw in Application.OpenForms)
                if (pw.GetType() == typeof(PleaseWait))
                    PleaseWait = (PleaseWait)pw;
            PleaseWait.UserClosing = false;
            PleaseWait.Close();
        }

        //c.Home.AutoDetectDeviceInfo_Button.Enabled = Enable;
        //c.Home.SwitchTheme_Button.Enabled = Enable;
        //c.Home.Settings_Button.Enabled = Enable;
        //c.Home.About_Button.Enabled = Enable;
        //c.Home.Feedback_Button.Enabled = Enable;
        //c.Home.Donate_Button.Enabled = Enable;
    }
}