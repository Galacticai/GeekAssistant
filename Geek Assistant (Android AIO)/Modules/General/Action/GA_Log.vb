Imports System.IO

Module GA_Log
    Private latestLogName As String
    Private latestLogPath As String
    Public Sub CreateLog()
        If Not Directory.Exists(GA) Then Directory.CreateDirectory(GA)
        If Not Directory.Exists($"{GA}\log") Then Directory.CreateDirectory($"{GA}\log")
        latestLogName = $"GA-log_{Now:(yyy.MM.dd)-hh.mm.ss}.log"
        latestLogPath = $"{GA}\log\{latestLogName}"
        File.Create(latestLogPath).Dispose()
        Dim swriter As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(latestLogPath, False)
        swriter.WriteLine(Main.log.Text)
        swriter.Close()
    End Sub
    Public Sub LogEvent(EventName As String, lines As Integer)
        LogAppendText($"// {Now:hhh:mm:ss.ff} // {EventName} //", lines)
    End Sub

    Public Sub ResetLog()
        LogEvent("Log Cleared", 3)
        CreateLog()

        Main.log.Text = GA_Ver.Run("log")

        LogAppendText($"// Previous log saved //  {latestLogName}  //", 1)
        LogEvent("Continue", 1)
    End Sub

    Public Sub LogAppendText(logText As String, lines As Integer)
        For newline As Integer = 1 To lines
            Main.log.AppendText(vbCrLf)
        Next
        Main.log.AppendText(logText)
    End Sub

    Public Sub StopNotifyIfLogSeen()
        If Main.log.Visible And (Main.ShowLog_ErrorBlink_Timer.Enabled Or Main.ShowLog_InfoBlink_Timer.Enabled) Then
            With Main
                .ShowLog_ErrorBlink_Timer.Enabled = False
                .ShowLog_InfoBlink_Timer.Enabled = False
                If My.Settings.DarkTheme Then
                    .ShowLog_Button.Icon = My.Resources.Commands_dark_24
                Else .ShowLog_Button.Icon = My.Resources.Commands_24
                End If
                '.ShowLog_Button.BackColor = Color.White
                .ProgressBarLabel.ForeColor = SystemColors.ControlText
            End With
        End If
    End Sub

    Public Sub ClearIf30days()
        If Not Directory.Exists(GA_logs) Then Exit Sub 'Exit if doesn't exist
        For Each file As FileInfo In New DirectoryInfo(GA_logs).GetFiles("*.txt")
            If (Now - file.CreationTime).Days > 30 Then file.Delete()
        Next
    End Sub
End Module
