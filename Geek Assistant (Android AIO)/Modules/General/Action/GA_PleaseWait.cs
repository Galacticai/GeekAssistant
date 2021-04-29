
internal static partial class GA_PleaseWait {
    public static void Run(bool Enable) {
        GeekAssistant.Forms.PleaseWait PleaseWait = new GeekAssistant.Forms.PleaseWait();
        if (Enable) PleaseWait.Show();
        else {
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