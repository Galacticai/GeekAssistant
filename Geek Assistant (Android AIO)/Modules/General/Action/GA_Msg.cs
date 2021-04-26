using System;
using System.Linq;
using System.Windows.Forms;
using GeekAssistant.Forms; 

internal static partial class GA_Msg {

    // Private ErrorCode As String
    public static string msgIcon = " ⚠  ";

    public static void DoMsg(int level, string msg, int lines = 1, string FullError = "") // , Optional YesProcessStart As String = "")  
    {

        // '
        // ' TODO: Separate title and body input
        // '

        // Media.SystemSounds.Beep.Play()
        if (level == 1 | level == 10) // —1—Error  '—10—FatalError 10
        {
            msgIcon = " ❌  ";
            common.S.info_MsgLevel = 1;
            common.Home.ShowLog_InfoBlink_Timer.Enabled = false;
            common.Home.ShowLog_ErrorBlink_Timer.Enabled = true;
            common.Home.ProgressBar.Style = MetroFramework.MetroColorStyle.Red;
        } else if (level == 2) // —2—Ask  
          {
            common.S.info_MsgLevel = 2;
            common.Home.ShowLog_ErrorBlink_Timer.Enabled = false;
            common.Home.ShowLog_InfoBlink_Timer.Enabled = true;
            common.Home.ProgressBar.Style = MetroFramework.MetroColorStyle.Blue;
            msgIcon = " ❔  ";
        } else // level = 0 '—0—Info  
          {
            common.S.info_MsgLevel = 0;
            common.Home.ShowLog_ErrorBlink_Timer.Enabled = false;
            common.Home.ShowLog_InfoBlink_Timer.Enabled = true;
            common.Home.ProgressBar.Style = MetroFramework.MetroColorStyle.Orange;
            msgIcon = " ⚠  ";
        }

        // Set title
        string msgTitle = txt.GetFirstLine(msg);
        GA_SetProgressText.Run(msgIcon + msgTitle, level);
        if (level == 10)
            msg += $"\n{prop.strings.ContactDevFix}";
        if (common.S.VerboseLogging & !string.IsNullOrEmpty(FullError)) {
            msg += $"\n\n" +
                $"————— #Verbose Logging# Full Error:\n" +
                $" ❰{common.ErrorInfo.code}❱" +
                $"\n{FullError}\n" +
                $" ❰/{common.ErrorInfo.code}❱\n" +
                $"————— #Verbose Logging# End —————";
        } else if (level == 10)
            msg += $"\n > {prop.strings.EnableVerboseLogging}";
        GA_Log.LogAppendText($"{msgIcon} ❰{common.ErrorInfo.code}❱ {msgTitle}\n{txt.CutFirstLine(msg)}", lines);
        if (common.S.PopupMessages) {
            common.S.info_Msg = txt.CutFirstLine(msg);
            common.S.info_MsgTitle = msgTitle;
            common.S.info_MsgLevel = level;
            common.S.Save(); 
            if (Application.OpenForms.OfType<Info>().Any())
                return;
            try {
                common.Info.ShowDialog();
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Error while loading the error... Yup it happens...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}