
internal static partial class GA_SetProgressText {


    // Private t As String
    // Private l As Integer

    // Delegate Sub SetLabelTextInvoker(text As String, level As Integer)
    public static void Run(string text, int ErrorLevel) {
        common.S.LastProgress = text;
        switch (ErrorLevel) {
        case -1: {
            // common.PleaseWait.PleaseWait_ProgressText.ForeColor = SystemColors.ControlText
            common.Home.ProgressBar.Style = MetroFramework.MetroColorStyle.Green;
            break;
        }

        case 0: {
            // common.PleaseWait.PleaseWait_ProgressText.ForeColor = Color.DarkOrange
            common.Home.ProgressBar.Style = MetroFramework.MetroColorStyle.Orange;
            System.Media.SystemSounds.Beep.Play();
            break;
        }

        case 1: {
            // common.PleaseWait.PleaseWait_ProgressText.ForeColor = Color.Firebrick
            // common.PleaseWait.PleaseWait_ProgressText.Text = $"({S.ErrorCode}) {text}"
            common.Home.ProgressBar.Style = MetroFramework.MetroColorStyle.Red;
            common.Home.ProgressBarLabel.Text = $"({common.ErrorInfo.code}) {text}";
            System.Media.SystemSounds.Asterisk.Play();
            return;
        }
        }

        common.PleaseWait.PleaseWait_ProgressText.Text = text;
        common.Home.ProgressBarLabel.Text = text;
        if (common.S.VerboseLogging & ErrorLevel == -1)
            GA_Log.LogAppendText(common.Home.ProgressBarLabel.Text, 1);
    }

    // Private Sub ProgressBarLabel_SetText()
    // Select Case l
    // Case 0
    // 'PleaseWait.PleaseWait_ProgressText.ForeColor = SystemColors.ControlText
    // Main.ProgressBarLabel.ForeColor = SystemColors.ControlText
    // Case 1
    // 'PleaseWait.PleaseWait_ProgressText.ForeColor = Color.DarkOrange
    // Main.ProgressBarLabel.ForeColor = Color.DarkOrange
    // Case 2
    // 'PleaseWait.PleaseWait_ProgressText.ForeColor = Color.Firebrick
    // 'PleaseWait.PleaseWait_ProgressText.Text = "(" & common.S.ErrorCode & ") " & t
    // Main.ProgressBarLabel.ForeColor = Color.Firebrick
    // Main.ProgressBarLabel.Text = "(" & common.S.ErrorCode & ") " & t
    // Exit Sub
    // End Select
    // 'PleaseWait.PleaseWait_ProgressText.Text = t
    // Main.ProgressBarLabel.Text = t
    // If common.S.VerbousLogging Then
    // 'LogAppendText(PleaseWait.PleaseWait_ProgressText.Text, 1)
    // GA_Log.LogAppendText(Main.ProgressBarLabel.Text, 1)
    // End If
    // End Sub
}