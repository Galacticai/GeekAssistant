Module GA_Msg

    Private ErrorCode As String
    Public msgIcon As String = " ⚠  "
    ''' <summary>
    ''' Set ErrorCode and My.Settings.ErrorCode values and save settings
    ''' </summary>
    ''' <param name="e">Error code</param>
    Public Sub ErrorCodeTrack(e As String)
        ErrorCode = e
        My.Settings.ErrorCode = e
        My.Settings.Save()
    End Sub
    Public Sub DoMsg(level As Integer, msg As String, lines As Integer, Optional FullError As String = "") ', Optional YesProcessStart As String = "")  

        ''
        '' TODO: Separate title and body input
        ''

        'Media.SystemSounds.Beep.Play()
        If level = 1 Or level = 10 Then '—1—Error  '—10—FatalError 10
            msgIcon = " ❌  "
            My.Settings.info_MsgLevel = 1
            Main.ShowLog_InfoBlink_Timer.Enabled = False
            Main.ShowLog_ErrorBlink_Timer.Enabled = True
            Main.ProgressBar.Style = MetroFramework.MetroColorStyle.Red
        ElseIf level = 2 Then '—2—Ask  
            My.Settings.info_MsgLevel = 2
            Main.ShowLog_ErrorBlink_Timer.Enabled = False
            Main.ShowLog_InfoBlink_Timer.Enabled = True
            Main.ProgressBar.Style = MetroFramework.MetroColorStyle.Blue
            msgIcon = " ❔  "
        Else 'level = 0 '—0—Info  
            My.Settings.info_MsgLevel = 0
            Main.ShowLog_ErrorBlink_Timer.Enabled = False
            Main.ShowLog_InfoBlink_Timer.Enabled = True
            Main.ProgressBar.Style = MetroFramework.MetroColorStyle.Orange
            msgIcon = " ⚠  "
        End If

        'Set title
        Dim msgTitle As String = txt_GetFirstLine(msg)
        GA_SetProgressText.Run(msgIcon & msgTitle, -1)

        If level = 10 Then msg &= $"{vbCrLf}{My.Resources.ContactDevFix}"
        If My.Settings.VerboseLogging And FullError <> "" Then
            msg &= $"{vbCrLf}{vbCrLf} ————— #Verbose Logging# Full Error:{vbCrLf}" &
                $" ❰{My.Settings.ErrorCode}❱{vbCrLf}{FullError}{vbCrLf}❰/{My.Settings.ErrorCode}❱{vbCrLf}" &
                "————— #Verbose Logging# End"
        Else
            If level = 10 Then msg &= $"{vbCrLf} > {My.Resources.EnableVerboseLogging}"
        End If
        LogAppendText($"{msgIcon} ❰{My.Settings.ErrorCode}❱ {msgTitle}{vbCrLf}{txt_CutFirstLine(msg)}", lines)

        If My.Settings.PopupMessages Then
            My.Settings.info_Msg = txt_CutFirstLine(msg)
            My.Settings.info_MsgTitle = msgTitle
            My.Settings.info_MsgLevel = level
            My.Settings.Save()
            If Application.OpenForms.OfType(Of info).Any Then Exit Sub
            info.ShowDialog()
        End If
    End Sub
End Module
