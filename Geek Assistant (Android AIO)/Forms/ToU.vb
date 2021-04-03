Imports System.IO

Public Class ToU
    Public Shared RunningAlready As Boolean = False

    Private Sub TermsOfUse_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        My.Settings.Save()
        RunningAlready = False
        If ToURead_Timer.Enabled Then ToURead_Timer.Stop()

    End Sub

    Public ToURead_TimeAmount As Integer
    Private Sub TermsOfUse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GA_SetTheme.Run(Name)

        Copyright.Text = GA_Ver.Run("ToU")

        'TermsOfUse.rtf 
        Dim Current_ToUrtf As String
        If Not Directory.Exists(GA) Then Directory.CreateDirectory(GA)
        If My.Settings.DarkTheme Then
            Current_ToUrtf = $"{GA}\TermsOfUse-Dark.rtf"
            If File.Exists(Current_ToUrtf) Then File.Delete(Current_ToUrtf)
            File.WriteAllText(Current_ToUrtf, My.Resources.TermsOfUse_Dark)
        Else
            Current_ToUrtf = $"{GA}\TermsOfUse.rtf"
            If File.Exists(Current_ToUrtf) Then File.Delete(Current_ToUrtf)
            File.WriteAllText(Current_ToUrtf, My.Resources.TermsOfUse)
        End If
        With TermsOfUse_Box
            .SelectionLength = 0
            .LoadFile(Current_ToUrtf)
        End With
        ToU_Reject.Select()


        'Accept || xy // Size xy: 337, 405 // 173, 46
        'Reject || xy // Size xy: 204, 405 // 133, 46
        If RunningAlready Then
            SetBounds((Main.Width / 2) - (Width / 2) + Main.Location.X, Main.Top, Width, Height)
            TermsOfUse_Box.Height = Height - 202
            AcceptCheck_ToU.Visible = False
            'With DontSkip_Label
            '    .Left = 363
            '    .ForeColor = Color.DimGray
            '    .Text = "Terms of use"
            'End With
            DontShow_ToU.Visible = False
            With ToU_Reject
                .Text = "✖"
                .Left = 394
                .Width = 58
            End With
            With ToU_Accept
                .Left = 452
                .Width = 58
                .Enabled = True
                .BackColor = Color.White
                .Text = "✔"
                .Font = New Font("Segoe UI", 13)
            End With
            'With Copyright
            '    .Left = 26
            '    .Top = Height - 84
            '    .Font = New Font("Segoe UI", 12, FontStyle.Regular)
            '    .ForeColor = Color.FromArgb(64, 64, 64)
            '    .BackColor = ButtonsBG_UI.BackColor
            'End With
            ToU_Accept.Select()
            Exit Sub
        End If

        If Version.Revision < 3 Then
            ToURead_Timer.Start()
        Else ''Skip the 6sec timer for #Dev version
            ToURead_TimeAmount = 6
            AcceptCheck_ToU.Checked = True
        End If

        If My.Settings.ToU_dontShow Then  'ToU:[ Dont show ToU >> Show Startup:[ Don't show AppMode >> Start newbie/moderate ] ]
            If My.Settings.AppMode_dontshow Then Main.Show() Else AppMode.Show()
            Close()
        End If
    End Sub
    Private Sub ToU_Reject_MouseEnter_MouseDown_KeyDown(sender As Object, e As EventArgs) Handles ToU_Reject.MouseEnter, ToU_Reject.MouseDown, ToU_Reject.KeyDown
        ToU_Reject.ForeColor = Current_bgColor()
    End Sub
    Private Sub ToU_Reject_MouseLeave_KeyUp(sender As Object, e As EventArgs) Handles ToU_Reject.MouseLeave, ToU_Reject.KeyUp
        ToU_Reject.ForeColor = Current_fgColor()
    End Sub
    Private Sub ToU_Reject_Click(sender As Object, e As EventArgs) Handles ToU_Reject.Click

        '>DEPRECATED
        'If RunningAlready Then
        '    Close()
        '    Exit Sub
        'End If
        '<DEPRECATED

        ErrorCodeTrack("ToU-R-H") ' ToU Rejected Hide
        GA_HideAllForms.Run(True, Nothing)
        Dim RejectTou_MessageBox = GA_infoAsk.Run("Rejected the terms of use", "Sorry for any inconvenience. You could contact the developer for further discussion.", "Exit Geek Assistant", "Return")
        If RejectTou_MessageBox Then
            Application.Exit()
        Else
            ErrorCodeTrack("ToU-R-S")
            GA_HideAllForms.Run(False, Me)
        End If
    End Sub

    Private Sub ToU_Accept_MouseEnter_MouseDown_KeyDown(sender As Object, e As EventArgs) Handles ToU_Accept.MouseEnter, ToU_Accept.MouseDown, ToU_Accept.KeyDown
        ToU_Accept.ForeColor = Current_bgColor()
    End Sub
    Private Sub ToU_Accept_MouseLeave_KeyUp(sender As Object, e As EventArgs) Handles ToU_Accept.MouseLeave, ToU_Accept.KeyUp
        ToU_Accept.ForeColor = Current_fgColor()
    End Sub
    Private Sub ToU_Accept_Click(sender As Object, e As EventArgs) Handles ToU_Accept.Click
        If DontShow_ToU.Checked Then My.Settings.ToU_dontShow = True
        If RunningAlready Then
            Close()
            Exit Sub
        End If
        If My.Settings.AppMode_dontshow Then Main.Show() Else AppMode.Show()
        Close()
    End Sub

    Private Sub AcceptCheck_ToU_CheckedChanged(sender As Object, e As EventArgs) Handles AcceptCheck_ToU.CheckedChanged
        If AcceptCheck_ToU.Checked And ToURead_TimeAmount = 6 Then
            With ToU_Accept
                .Enabled = True
                .BackColor = BackColor
            End With
        Else
            With ToU_Accept
                .Enabled = False
                .BackColor = ButtonsBG_UI.BackColor
            End With
        End If
    End Sub

    Private Sub ToURead_Timer_Tick(sender As Object, e As EventArgs) Handles ToURead_Timer.Tick
        If ToURead_TimeAmount = 5 Then
            ToURead_Timer.Stop()
        End If
        ToURead_TimeAmount += 1
        ToU_Accept.Text = "&ACCEPT (" & (6 - ToURead_TimeAmount).ToString & ")"
        If ToURead_TimeAmount = 6 Then
            ToU_Accept.Text = "&ACCEPT"
            If AcceptCheck_ToU.Checked Then
                With ToU_Accept
                    .Enabled = True
                    .BackColor = Color.White
                End With
            End If
        End If
    End Sub

    Private Sub DontShow_ToU_CheckedChanged(sender As Object, e As EventArgs) Handles DontShow_ToU.CheckedChanged

    End Sub
End Class