using GeekAssistant.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

internal static partial class Log {
    private static string latestLogName;
    private static string latestLogPath;

    private static Home Home => c.Home;
    //private static void RefresHome() {
    //    foreach (Form h in Application.OpenForms)
    //        if (h.GetType() == typeof(Home))
    //            Home = (Home)h;
    //}
    public static void CreateLog() {
        //RefresHome();

        if (!Directory.Exists(c.GA)) Directory.CreateDirectory(c.GA);
        if (!Directory.Exists($@"{c.GA}\log")) Directory.CreateDirectory($@"{c.GA}\log");

        latestLogName = $"GA-log_{DateTime.Now:(yyy.MM.dd)-hh.mm.ss}.log";
        latestLogPath = $@"{c.GA}\log\{latestLogName}";
        File.Create(latestLogPath).Dispose();
        StreamWriter swriter = new(latestLogPath);
        swriter.WriteLine(Home.log.Text);
        swriter.Close();
    }

    public static void LogEvent(string EventName, int lines) {
        LogAppendText($"// {DateTime.Now:hhh:mm:ss.ff} // {EventName} //", lines);
    }

    public static void ResetLog() {
        //RefresHome();

        LogEvent("Log Cleared", 3);
        CreateLog();
        Home.log.Text = GAver.Run("log");
        LogAppendText($"// Previous log saved //  {latestLogName}  //", 1);
        LogEvent("Continue", 1);
    }

    public static void LogAppendText(string logText, int lines) {
        //RefresHome();

        // Dim StringLines As String() = logText.Split(New String() {Environment.NewLine}, StringSplitOptions.None)

        for (int newline = 1, loopTo = lines; newline <= loopTo; newline++) {
            // Main.htmlLog.DocumentText &= br
            Home.log.Text += c.n;
        }
        Home.log.Text += logText;
        // For Each item In StringLines
        // Main.htmlLog.DocumentText &= Markdown.ToHtml(StringLines(item))
        // If StringLines.Count - 1 <> item Then Main.htmlLog.DocumentText &= br 'new line if not finished
        // Next

        // Main.htmlLog.DocumentText &= logText 'Markdown.ToHtml(logText)
    }

    public static void StopNotifyIfLogSeen() {
        //RefresHome();

        if (Home.log.Visible & (Home.ShowLog_ErrorBlink_Timer.Enabled | Home.ShowLog_InfoBlink_Timer.Enabled)) {
            Home.ShowLog_ErrorBlink_Timer.Stop();
            Home.ShowLog_InfoBlink_Timer.Stop();
            Home.ShowLog_Button.Icon = icons.x24.Commands();
            Home.ProgressBarLabel.ForeColor = colors.UI.fg();
        }
    }

    public static void ClearIf30days() {
        if (!Directory.Exists(c.GA_logs)) return; // Exit if doesn't exist 
        foreach (FileInfo file in new DirectoryInfo(c.GA_logs).GetFiles("*.txt"))
            if ((DateTime.Now - file.CreationTime).Days > 30)
                file.Delete();
    }
}