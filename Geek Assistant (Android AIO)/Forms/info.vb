Class info

    Public info_IconLight As Image = Nothing
    Public info_IconDark As Image = Nothing
    Public info_TextColorLight As Color = Nothing
    Public info_TextColorDark As Color = Nothing

    Private Sub info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GA_SetTheme.Run(Name)

        'Reset info answer
        infoAnswer = False
        No_Button.Select()

        If My.Settings.info_MsgTitle Is Nothing Or My.Settings.info_Msg Is Nothing Or My.Settings.info_MsgLevel < -1 Then
            DoMsg(10, $"Where's the error message??{vbCrLf}If you see this please contact the developer to fix this bug.{vbCrLf}Please provide the log when reporting.", 2)
            Close()
        End If

        'Reset to default
        No_Button.Text = "Close"
        Yes_Button.Text = "(Yes)"
        'GeekAssistant_PictureBox.Visible = False
        Yes_Button.Visible = False
        Copy_Button.Visible = True

        Dim msglevelText As String = "Warning"
        If My.Settings.info_MsgLevel = 1 Or My.Settings.info_MsgLevel = 10 Then
            msglevelText = "Error"
            If My.Settings.DarkTheme Then
                info_PictureBox.Image = My.Resources.Warning_Red_dark_64
                title_Label.ForeColor = Color.FromArgb(255, 191, 191)
            Else
                info_PictureBox.Image = My.Resources.Warning_Red_64
                title_Label.ForeColor = Color.FromArgb(154, 0, 0)
            End If
        ElseIf My.Settings.info_MsgLevel = 2 Then
            'msglevelText = "Question"
            No_Button.Text = infoButtonText.RightButton
            Yes_Button.Text = infoButtonText.LeftButton
            Yes_Button.Visible = True
            Text = $"{My.Settings.info_MsgTitle} — Geek Assistant"
            title_Label.Text = My.Settings.info_MsgTitle
            'GeekAssistant_PictureBox.Visible = True
            Copy_Button.Visible = False
            If My.Settings.DarkTheme Then
                info_PictureBox.Image = My.Resources.Question_Blue_Dark_64
                title_Label.ForeColor = Color.FromArgb(186, 221, 253)
            Else
                info_PictureBox.Image = My.Resources.Question_Blue_64
                title_Label.ForeColor = Color.FromArgb(64, 109, 128)
            End If
        Else
            If My.Settings.DarkTheme Then
                info_PictureBox.Image = My.Resources.Info_Yellow_dark_64
                title_Label.ForeColor = Color.FromArgb(255, 238, 191)
            Else
                info_PictureBox.Image = My.Resources.Info_Yellow_64
                title_Label.ForeColor = Color.FromArgb(115, 84, 0)
            End If
        End If

        ''''Special Cases
        If title_Label.Text = "Send Feedback" Then
            If My.Settings.DarkTheme Then
                info_PictureBox.Image = My.Resources.Smile_dark_64
                title_Label.ForeColor = Color.FromArgb(191, 255, 191)
            Else
                info_PictureBox.Image = My.Resources.Smile_64
                title_Label.ForeColor = Color.FromArgb(0, 102, 71)
            End If
        End If

        If My.Settings.info_MsgLevel <> 2 Then   'Avoid when it is a question
            Text = $"{msgIcon}{msglevelText}: ❰{My.Settings.ErrorCode}❱ — Geek Assistant"
            title_Label.Text = $"❰{My.Settings.ErrorCode}❱ {My.Settings.info_MsgTitle}"
        End If
        msg_Textbox.Text = My.Settings.info_Msg

        Width = 566
        Height = 355
        Select Case msg_Textbox.Text.Length
            Case < 150
                Width = 520
                Height -= 50
            Case > 400
                Width = 620
                Height += 50
        End Select
        SetBounds((Main.Width / 2) - (Width / 2) + Main.Location.X, Main.Top, Width, Height)
    End Sub

    Private Sub OK_Button_Mousedown(sender As Object, e As EventArgs) Handles Yes_Button.MouseDown
        Yes_Button.ForeColor = Color.White
    End Sub
    Private Sub OK_Button_MouseUp(sender As Object, e As EventArgs) Handles Yes_Button.MouseUp
        Yes_Button.ForeColor = SystemColors.Highlight
    End Sub
    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles Yes_Button.Click
        If My.Settings.info_MsgLevel = 2 Then
            infoAnswer = True
            Close()
        Else
            Process.Start("https://developer.android.com/studio/run/oem-usb")
        End If
    End Sub

    'Private Sub Close_Button_MouseDown(sender As Object, e As EventArgs) Handles Close_Button.MouseDown
    '    Close_Button.ForeColor = Color.White
    'End Sub
    'Private Sub Close_Button_MouseUp(sender As Object, e As EventArgs) Handles Close_Button.MouseUp
    '    Close_Button.ForeColor = SystemColors.ControlText
    'End Sub
    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles No_Button.Click
        If Not My.Settings.VerboseLogging And My.Settings.VerboseLoggingPrompt _
            And My.Settings.DeviceAPILevel <> 2 And Not title_Label.Text = "Enable Verbose Logging?" And Not title_Label.Text = "Send Feedback" Then
            'Close()
            Dispose()
            Main.BringToFront()
            If GA_infoAsk.Run("Enable Verbose Logging?",
                              "For easier troubleshooting, enable verbose logging in Settings and try again",
                              "Enable Verbose Logging", "Close") Then
                GA_Settings.ShowDialog()
            End If
            My.Settings.VerboseLoggingPrompt = False
        End If
        If My.Settings.info_MsgLevel = 2 Then
            infoAnswer = False
        End If
        Close()
        'Dispose()
    End Sub

    Private Sub CopyToClipboard_MouseDown(sender As Object, e As EventArgs) Handles Copy_Button.MouseDown
        Copy_Button.Image = My.Resources.Copy_W_24
        Copy_Button.ForeColor = Color.White
    End Sub
    Private Sub CopyToClipboard_MouseUp(sender As Object, e As EventArgs) Handles Copy_Button.MouseUp
        Copy_Button.Image = My.Resources.Copy_B_24
        If CopyToClipboard_Timer.Enabled Then
            Copy_Button.ForeColor = Color.DarkGreen
        Else Copy_Button.ForeColor = SystemColors.ControlText
        End If
    End Sub
    Private Sub CopyToClipboard_Click(sender As Object, e As EventArgs) Handles Copy_Button.Click
        CopyToClipboard_Timer.Enabled = False
        Clipboard.SetText(title_Label.Text & vbCrLf & vbCrLf & msg_Textbox.Text)
        Copy_Button.ForeColor = Color.DarkGreen
        Copy_Button.Text = "Copied "
        CopyToClipboard_Timer.Enabled = True
    End Sub

    Private Sub CopyToClipboard_Timer_Tick(sender As Object, e As EventArgs) Handles CopyToClipboard_Timer.Tick
        CopyToClipboard_Timer.Enabled = False
        Copy_Button.Text = "Copy  "
        Copy_Button.ForeColor = SystemColors.ControlText
    End Sub

    Private Sub title_Label_TextChanged(sender As Object, e As EventArgs) Handles title_Label.TextChanged
        If title_Label.Text.Length < 25 Then
            title_Label.Font = New Font("Segoe UI", 15.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
        Else
            title_Label.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular, GraphicsUnit.Point, 0)
        End If
    End Sub

    Private WithEvents title_Label_Click_Timer As New Timer With {.Interval = 1500}
    Private savedTitle As String
    Private CopiedText As String = "Copied Error info..."
    Private Sub title_Label_Click(sender As Object, e As EventArgs) Handles title_Label.Click
        If title_Label.Text = CopiedText Then Exit Sub
        If My.Settings.info_MsgLevel <> 2 Then
            savedTitle = title_Label.Text
            title_Label.Text = CopiedText
            Clipboard.SetText(savedTitle)
            title_Label_Click_Timer.Enabled = True
        End If
    End Sub
    Private Sub title_Label_Click_Timer_Tick() Handles title_Label_Click_Timer.Tick
        title_Label.Text = savedTitle
        title_Label_Click_Timer.Enabled = False
    End Sub
End Class