Module GA_SetProgressText


    'Private t As String
    'Private l As Integer

    'Delegate Sub SetLabelTextInvoker(text As String, level As Integer)
    Public Sub Run(text As String, ErrorLevel As Integer)
        My.Settings.LastProgress = text

        Select Case ErrorLevel
            Case -1
                PleaseWait.PleaseWait_ProgressText.ForeColor = SystemColors.ControlText
                Main.ProgressBar.Style = MetroFramework.MetroColorStyle.Green
            Case 0
                PleaseWait.PleaseWait_ProgressText.ForeColor = Color.DarkOrange
                Main.ProgressBar.Style = MetroFramework.MetroColorStyle.Orange
                Media.SystemSounds.Beep.Play()
            Case 1
                PleaseWait.PleaseWait_ProgressText.ForeColor = Color.Firebrick
                PleaseWait.PleaseWait_ProgressText.Text = $"({My.Settings.ErrorCode}) {text}"
                Main.ProgressBar.Style = MetroFramework.MetroColorStyle.Red
                Main.ProgressBarLabel.Text = $"({My.Settings.ErrorCode}) {text}"
                Media.SystemSounds.Asterisk.Play()
                Exit Sub
        End Select
        PleaseWait.PleaseWait_ProgressText.Text = text
        Main.ProgressBarLabel.Text = text

        If My.Settings.VerboseLogging Then
            'LogAppendText(PleaseWait.PleaseWait_ProgressText.Text, 1)
            LogAppendText(Main.ProgressBarLabel.Text, 1)
        End If

        't = text
        'l = level

        ''Dim mi As MethodInvoker = AddressOf Run_Invoked
        ''If Not IsHandleCreated Then
        ''    CreateHandle()
        ''End If
        'If ProgressBarLabel.InvokeRequired Then
        '    ProgressBarLabel.Invoke(New SetLabelTextInvoker(AddressOf ProgressBarLabel_SetText), t, l)
        'Else
        '    ProgressBarLabel_SetText()
        'End If

    End Sub

    'Private Sub ProgressBarLabel_SetText()
    '    Select Case l
    '        Case 0
    '            'PleaseWait.PleaseWait_ProgressText.ForeColor = SystemColors.ControlText
    '            Main.ProgressBarLabel.ForeColor = SystemColors.ControlText
    '        Case 1
    '            'PleaseWait.PleaseWait_ProgressText.ForeColor = Color.DarkOrange
    '            Main.ProgressBarLabel.ForeColor = Color.DarkOrange
    '        Case 2
    '            'PleaseWait.PleaseWait_ProgressText.ForeColor = Color.Firebrick
    '            'PleaseWait.PleaseWait_ProgressText.Text = "(" & My.Settings.ErrorCode & ") " & t
    '            Main.ProgressBarLabel.ForeColor = Color.Firebrick
    '            Main.ProgressBarLabel.Text = "(" & My.Settings.ErrorCode & ") " & t
    '            Exit Sub
    '    End Select
    '    'PleaseWait.PleaseWait_ProgressText.Text = t
    '    Main.ProgressBarLabel.Text = t
    '    If My.Settings.VerbousLogging Then
    '        'LogAppendText(PleaseWait.PleaseWait_ProgressText.Text, 1)
    '        LogAppendText(Main.ProgressBarLabel.Text, 1)
    '    End If
    'End Sub
End Module

