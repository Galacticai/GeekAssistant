/*
using System;
using System.Linq;
using System.Windows.Forms;
using GeekAssistant.Forms;

internal static partial class GA_Msg_Deprecated {

    // Private ErrorCode As String

    public static void DoMsg(int level, string msg, int lines = 1, string FullError = "") // , Optional YesProcessStart As String = "")  
    {

        // '
        // ' TODO: Separate title and body input
        // '

        // Media.SystemSounds.Beep.Play()
        if (level == 1 | level == 10) // —1—Error  '—10—FatalError 10
        {
            msgIcon = " ❌  ";
            c.S.info_MsgLevel = 1;
            c.Home.ShowLog_InfoBlink_Timer.Enabled = false;
            c.Home.ShowLog_ErrorBlink_Timer.Enabled = true;
            c.Home.bar.Style = MetroFramework.MetroColorStyle.Red;
        } else if (level == 2) // —2—Ask  
          {
            c.S.info_MsgLevel = 2;
            c.Home.ShowLog_ErrorBlink_Timer.Enabled = false;
            c.Home.ShowLog_InfoBlink_Timer.Enabled = true;
            c.Home.bar.Style = MetroFramework.MetroColorStyle.Blue;
            msgIcon = " ❔  ";
        } else // level = 0 '—0—Info()  
          {
            c.S.info_MsgLevel = 0;
            c.Home.ShowLog_ErrorBlink_Timer.Enabled = false;
            c.Home.ShowLog_InfoBlink_Timer.Enabled = true;
            c.Home.bar.Style = MetroFramework.MetroColorStyle.Orange;
            msgIcon = " ⚠  ";
        }

        // Set title
        string msgTitle = txt.GetFirstLine(msg);
        GA_SetProgressText.Run(msgIcon + msgTitle, level);
        if (level == 10)
            msg += $"\n{prop.strings.ContactDevFix}";
        if (c.S.VerboseLogging & !string.IsNullOrEmpty(FullError)) {
            msg += $"\n\n" +
                $"————— #Verbose Logging# Full Error:\n" +
                $" ❰{inf.detail.workCode}❱" +
                $"\n{FullError}\n" +
                $" ❰/{inf.detail.workCode}❱\n" +
                $"————— #Verbose Logging# End —————";
        } else if (level == 10)
            msg += $"\n > {prop.strings.EnableVerboseLogging}";
        GA_Log.LogAppendText($"{msgIcon} ❰{inf.detail.workCode}❱ {msgTitle}\n{txt.CutFirstLine(msg)}", lines);
        if (c.S.PopupMessages) {
            c.S.info_Msg = txt.CutFirstLine(msg);
            c.S.info_MsgTitle = msgTitle;
            c.S.info_MsgLevel = level;
            c.S.Save();
            if (Application.OpenForms.OfType<Info>().Any())
                return;
            try {
                c.Info.ShowDialog();
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Error while loading the error... Yup it happens...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
*/