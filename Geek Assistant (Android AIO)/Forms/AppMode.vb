

Public Class AppMode

    Private Sub Startup_Closed() Handles MyBase.Closed
        My.Settings.Save()
    End Sub
    Private Sub Startup_GotFocus() Handles MyBase.GotFocus, MyBase.LostFocus, MyBase.MouseEnter, MyBase.MouseLeave
        start_newbie.ForeColor = Color.Green
        start_default.ForeColor = SystemColors.Highlight
        start_expert.ForeColor = Color.Firebrick
    End Sub
    'Private Sub Startup_Disposed() Handles MyBase.Disposed
    '    MessageBox.Show("Disposed")
    '    Dispose()
    'End Sub
    Private Sub Startup_Load() Handles MyBase.Load
        If My.Settings.AppMode_dontshow Then
            If My.Settings.AppMode_newbie Then
                Startup_Do(0)
            ElseIf My.Settings.AppMode_moderate Then
                Startup_Do(1)
            End If
            Close()
        End If
        GA_SetTheme.Run(Name)
    End Sub

    Private Sub Startup_Do(StartupLevel As Integer)
        Select Case StartupLevel
            Case 0
                'My.Settings.startup_newbie = True
                'My.Settings.startup_moderate = False

            Case 1
                My.Settings.AppMode_newbie = False
                My.Settings.AppMode_moderate = True

                Main.Show()
                Close()

            Case 2
                Media.SystemSounds.Beep.Play()
                MessageBox.Show("Come on.. Experts don't need assitance.", "Expert Mode - Geek Assistant", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                MessageBox.Show("Okay... There's no ""Expert Mode"". You will be redirected to the default mode.", "Expert Mode - Geek Assistant", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                start_default.PerformClick()
        End Select
    End Sub

    Private Sub startup_dontShow_MouseEnter(sender As Object, e As EventArgs) Handles startup_dontShow.MouseEnter
        If My.Settings.AppMode_dontshow Then
            startup_dontShow.BackColor = Color.FromArgb(0, 130, 0)
            startup_dontShow.ForeColor = Color.White
        Else
            If My.Settings.DarkTheme Then
                startup_dontShow.BackColor = Color.FromArgb(0, 120, 0)
            Else startup_dontShow.BackColor = Color.Honeydew
            End If
            startup_dontShow.ForeColor = SystemColors.ControlText
        End If
    End Sub
    Private Sub startup_dontShow_MouseLeave(sender As Object, e As EventArgs) Handles startup_dontShow.MouseLeave
        If My.Settings.AppMode_dontshow Then
            startup_dontShow.BackColor = Color.Green
            startup_dontShow.ForeColor = Color.White
        Else
            startup_dontShow.BackColor = Color.Transparent()
            startup_dontShow.ForeColor = Current_fgColor()
        End If
    End Sub
    Private Sub startup_dontShow_MouseDown_KeyDown(sender As Object, e As EventArgs) Handles startup_dontShow.MouseDown, startup_dontShow.KeyDown
        SettingsButtonSwitch_Style_MouseDown_KeyDown(startup_dontShow)
    End Sub
    Private Sub startup_dontShow_Mouseup_Keyup(sender As Object, e As EventArgs) Handles startup_dontShow.MouseUp, startup_dontShow.KeyUp
        SettingsButtonSwitch_Style_MouseUp_KeyUp(startup_dontShow)
    End Sub
    Private Sub startup_dontShow_Click(sender As Object, e As EventArgs) Handles startup_dontShow.Click
        If My.Settings.AppMode_dontshow Then
            startup_dontShow.BackColor = Color.Transparent
            My.Settings.AppMode_dontshow = False
        Else
            startup_dontShow.BackColor = Color.Green
            My.Settings.AppMode_dontshow = True
            My.Settings.Save()
        End If
        My.Settings.Save()
    End Sub

#Region "start_newbie"
    Private Sub start_newbie_Click() Handles start_newbie.Click
        FeatureUnavailable_MessageBox.Run("Newbie Mode")
        Startup_Do(0)
    End Sub
    Private Sub start_newbie_MouseEnter_MouseUp_KeyUp() Handles start_newbie.MouseEnter, start_newbie.MouseUp, start_newbie.KeyUp
        start_newbie.ForeColor = Color.White
        start_default.ForeColor = SystemColors.Highlight
        start_expert.ForeColor = Color.Firebrick
    End Sub
    Private Sub start_newbie_MouseDown_KeyDown() Handles start_newbie.MouseDown, start_newbie.KeyDown
        start_newbie.ForeColor = Color.White
        start_default.ForeColor = SystemColors.Highlight
        start_expert.ForeColor = Color.Firebrick
    End Sub
    Private Sub start_newbie_MouseLeave() Handles start_newbie.MouseLeave
        start_newbie.ForeColor = Color.Green
        start_default.ForeColor = SystemColors.Highlight
        start_expert.ForeColor = Color.Firebrick
    End Sub
#End Region

#Region "start_moderate"
    Private Sub start_moderate_Click() Handles start_default.Click
        Startup_Do(1)
    End Sub
    Private Sub start_moderate_MouseEnter_MouseUp() Handles start_default.MouseEnter, start_default.MouseUp, start_default.KeyUp
        start_newbie.ForeColor = Color.Green
        start_default.ForeColor = Color.White
        start_expert.ForeColor = Color.Firebrick
    End Sub
    Private Sub start_moderate_MouseUp_KeyDown() Handles start_default.MouseDown, start_default.KeyDown
        start_newbie.ForeColor = Color.Green
        start_default.ForeColor = Color.White
        start_expert.ForeColor = Color.Firebrick
    End Sub
    Private Sub start_moderate_MouseLeave() Handles start_default.MouseLeave
        start_newbie.ForeColor = Color.Green
        start_default.ForeColor = SystemColors.Highlight
        start_expert.ForeColor = Color.Firebrick
    End Sub
#End Region

#Region "start_expert"
    Private Sub start_expert_Click() Handles start_expert.Click
        Startup_Do(2)
    End Sub
    Private Sub start_expert_MouseEnter_MouseUp() Handles start_expert.MouseEnter, start_expert.MouseUp, start_expert.KeyUp
        start_newbie.ForeColor = Color.Green
        start_default.ForeColor = SystemColors.Highlight
        start_expert.ForeColor = Color.White
    End Sub
    Private Sub start_expert_MouseDown_KeyDown() Handles start_expert.MouseDown, start_expert.KeyDown
        start_newbie.ForeColor = Color.Green
        start_default.ForeColor = SystemColors.Highlight
        start_expert.ForeColor = Color.White
    End Sub
    Private Sub start_expert_MouseLeave() Handles start_expert.MouseLeave
        start_newbie.ForeColor = Color.Green
        start_default.ForeColor = SystemColors.Highlight
        start_expert.ForeColor = Color.Firebrick
    End Sub

#End Region

End Class