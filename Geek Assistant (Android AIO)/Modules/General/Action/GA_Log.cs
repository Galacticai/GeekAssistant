using System.Drawing;
using GeekAssistant.Forms;
using System.IO;
using Markdig;
using Microsoft.VisualBasic; // Install-Package Microsoft.VisualBasic

internal static partial class GA_Log {
    private static string latestLogName;
    private static string latestLogPath;

    public static void CreateLog() {
        if (!Directory.Exists(common.GA))
            Directory.CreateDirectory(common.GA);
        if (!Directory.Exists($@"{common.GA}\log"))
            Directory.CreateDirectory($@"{common.GA}\log");
        latestLogName = $"GA-log_{DateAndTime.Now:(yyy.MM.dd)-hh.mm.ss}.log";
        latestLogPath = $@"{common.GA}\log\{latestLogName}";
        File.Create(latestLogPath).Dispose();
        StreamWriter swriter = new StreamWriter(latestLogPath);
        swriter.WriteLine(Home.log.Text);
        swriter.Close();
    }

    public static void LogEvent(string EventName, int lines) {
        LogAppendText($"// {DateAndTime.Now:hhh:mm:ss.ff} // {EventName} //", lines);
    }

    public static void ResetLog() {
        LogEvent("Log Cleared", 3);
        CreateLog();
        Home.log.Text = GA_Ver.Run("log");
        LogAppendText($"// Previous log saved //  {latestLogName}  //", 1);
        LogEvent("Continue", 1);
    }

    public static void LogAppendText(string logText, int lines) {
        // Dim StringLines As String() = logText.Split(New String() {Environment.NewLine}, StringSplitOptions.None)

        for (int newline = 1, loopTo = lines; newline <= loopTo; newline++) { 
            // Main.htmlLog.DocumentText &= br
            Home.log.Text += common.n;
        }
        Home.log.Text += logText;
        // For Each item In StringLines
        // Main.htmlLog.DocumentText &= Markdown.ToHtml(StringLines(item))
        // If StringLines.Count - 1 <> item Then Main.htmlLog.DocumentText &= br 'new line if not finished
        // Next

        // Main.htmlLog.DocumentText &= logText 'Markdown.ToHtml(logText)
    }

    public static void StopNotifyIfLogSeen() {
        if (Home.log.Visible & (Home.ShowLog_ErrorBlink_Timer.Enabled | Home.ShowLog_InfoBlink_Timer.Enabled)) {
            { 
                Home.ShowLog_ErrorBlink_Timer.Stop();
                Home.ShowLog_InfoBlink_Timer.Stop();
                if (common.S.DarkTheme) {
                    Home.ShowLog_Button.Icon = prop.x24.Commands_dark_24;
                } else {
                    Home.ShowLog_Button.Icon = prop.x24.Commands_24;
                }
                // .ShowLog_Button.BackColor = Color.White
                Home.ProgressBarLabel.ForeColor = SystemColors.ControlText;
            }
        }
    }

    public static void ClearIf30days() {
        if (!Directory.Exists(common.GA_logs))
            return; // Exit if doesn't exist
        foreach (FileInfo file in new DirectoryInfo(common.GA_logs).GetFiles("*.txt")) {
            if ((DateAndTime.Now - file.CreationTime).Days > 30)
                file.Delete();
        }
    }
}