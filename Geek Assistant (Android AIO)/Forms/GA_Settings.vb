'Imports GeekAssistant.Modules

Class GA_Settings
    Private ReadOnly PopupMessages_SwitchButton_ToolTip As String = "View a window for messages like errors and info... etc"
    Private ReadOnly VerbousLogging_SwitchButton_ToolTip As String = "Add more details to logs like current ongoing actions " & vbCrLf & "and behind the scenes actions that may not be interesting"
    Private ReadOnly VerbousLoggingPrompt_Tooltip As String = "Ask to enable verbous logging when an error occurs"
    Private ReadOnly ShowTooltips_SwitchButton_ToolTip As String = "Show tooltips on various controls for clarification"
    Private ReadOnly ToU_SwitchButton_ToolTip As String = "Skip Terms of Use window when starting Geek Assistant. [= Accept always]"
    Private ReadOnly AppMode_SwitchButton_ToolTip As String = "Skip App Mode window and enter the last chosen " & vbCrLf & "mode the next time starting Geek Assistant"
    Private ReadOnly AutoClearLogs_SwitchButton_ToolTip As String = "Auto delete log files that are older than 30 days"
    Private ReadOnly PerformThemeAnimation_SwitchButton_ToolTip As String = "Perform animations while switching between Light/Dark themes." & vbCrLf & "Recommended to disable this for old systems."

    Private Sub GA_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GA_SetTheme.Run(Name)
        SetBounds((Main.Width / 2) - (Width / 2) + Main.Location.X, Main.Top, Width, Height)

        ResetGA_Settings_CheckBox.Checked = False
        ResetGA_LogsOnly_CheckBox.Checked = False

        SettingsButtonSwitch_Style_EnableIfTrue(ToU_SwitchButton, My.Settings.ToU_dontShow)
        SettingsButtonSwitch_Style_EnableIfTrue(AppMode_SwitchButton, My.Settings.AppMode_dontshow)
        SettingsButtonSwitch_Style_EnableIfTrue(PopupMessages_SwitchButton, My.Settings.PopupMessages)
        SettingsButtonSwitch_Style_EnableIfTrue(VerbousLogging_SwitchButton, My.Settings.VerboseLogging)
        VerbousLoggingStateSet()
        SettingsButtonSwitch_Style_EnableIfTrue(ShowToolTips_SwitchButton, My.Settings.ShowToolTips)
        SettingsButtonSwitch_Style_EnableIfTrue(AutoClearLogs_SwitchButton, My.Settings.AutoClearLogs)
        SettingsButtonSwitch_Style_EnableIfTrue(PerformAnimation_SwitchButton, My.Settings.PerformAnimations)
    End Sub


#Region "ResetGA"
    Private Sub ResetGA_Click(sender As Object, e As EventArgs) Handles ResetGA.Click
        ErrorCodeTrack("GAr-00")
        If Not ResetGA_LogsOnly_CheckBox.Checked And Not ResetGA_Settings_CheckBox.Checked Then
            DoMsg(0, "Select something to clear first.", 1)
            Exit Sub
        End If
        GA_Reset.Run(Data, logs)
    End Sub
    Private Sub ResetGA_MouseEnter(sender As Object, e As EventArgs) Handles ResetGA.MouseEnter
        SetToolTipInfo(ToolTip, ResetGA, "Reset Geek Assistant", willClear)
        If willClear = Nothing Then
            SetToolTipInfo(ToolTip, ResetGA, "Reset Geek Assistant", "First, select something of the above.")
            Exit Sub
        End If
        If willClear.Length <= 9 Then SetToolTipInfo(ToolTip, ResetGA, "Reset Geek Assistant", "First, select something of the above.")
    End Sub
    Private Sub ResetGA_MouseDown(sender As Object, e As EventArgs) Handles ResetGA.MouseDown
        ResetGA.ForeColor = Current_bgColor()
    End Sub
    Private Sub ResetGA_MouseUp(sender As Object, e As EventArgs) Handles ResetGA.MouseUp
        ResetGA.ForeColor = Current_fgColor()
    End Sub

    Private Sub Close_Button_MouseDown(sender As Object, e As EventArgs) Handles Close_Button.MouseDown
        Close_Button.ForeColor = Current_fgColor()
    End Sub
    Private Sub Close_Button_MouseUp(sender As Object, e As EventArgs) Handles Close_Button.MouseUp
        Close_Button.ForeColor = Current_bgColor()
    End Sub
    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        Close()
    End Sub

#End Region

#Region "ResetGA_SelectAll"
    Private Sub ResetGA_SelectAll_MouseEnter() Handles ResetGA_SelectAll.MouseEnter, ResetGA_SelectAll.MouseEnter
        SetToolTipInfo(ToolTip, ResetGA_SelectAll, "Select All", ToolTip.GetToolTip(ResetGA_SelectAll))
    End Sub
    Private Sub ResetGA_SelectAll_MouseDown(sender As Object, e As EventArgs) Handles ResetGA_SelectAll.MouseDown
        If My.Settings.DarkTheme Then
            ResetGA_SelectAll.Image = My.Resources.SelectAll_B_24
        Else ResetGA_SelectAll.Image = My.Resources.SelectAll_W_24
        End If
    End Sub
    Private Sub ResetGA_SelectAll_MouseUp(sender As Object, e As EventArgs) Handles ResetGA_SelectAll.MouseUp
        If My.Settings.DarkTheme Then
            ResetGA_SelectAll.Image = My.Resources.SelectAll_W_24
        Else ResetGA_SelectAll.Image = My.Resources.SelectAll_B_24
        End If
    End Sub
    Private Sub ResetGA_SelectAll_Click(sender As Object, e As EventArgs) Handles ResetGA_SelectAll.Click
        If ResetGA_Settings_CheckBox.Checked And ResetGA_LogsOnly_CheckBox.Checked Then
            ResetGA_Settings_CheckBox.Checked = False
            ResetGA_LogsOnly_CheckBox.Checked = False
            Exit Sub
        End If
        ResetGA_Settings_CheckBox.Checked = True
        ResetGA_LogsOnly_CheckBox.Checked = True
    End Sub
#End Region


    Public Shared willClear As String
    Private andstr As String = " and "
    Private Data As Boolean = False
    Private logs As Boolean = False
    Private Sub ResetGA_Settings_LogsOnly_CheckBox_CheckedChanged() Handles ResetGA_Settings_CheckBox.CheckedChanged, ResetGA_LogsOnly_CheckBox.CheckedChanged
        'Directories = False
        Data = False
        logs = False
        willClear = "clear"
        If ResetGA_LogsOnly_CheckBox.Checked Then
            logs = True
            willClear &= " logs"
        End If
        If ResetGA_Settings_CheckBox.Checked Then
            Data = True
            andstr = " and"
            If Not ResetGA_LogsOnly_CheckBox.Checked Then
                andstr = ""
            End If
            willClear &= andstr & " internal data"
        End If
        'If ResetGA_Settings_CheckBox.Checked <> ResetGA_LogsOnly_CheckBox.Checked Then
        '    willClear &= " only"
        'End If
        'willClear &= "?"
        SetToolTipInfo(ToolTip, ResetGA, "Reset Geek Assistant", willClear)
        If Not ResetGA_LogsOnly_CheckBox.Checked And Not ResetGA_Settings_CheckBox.Checked Then _
            SetToolTipInfo(ToolTip, ResetGA, "Reset Geek Assistant", "First, select something of the above.")
    End Sub

    ''ResetGA_Settings_CheckBox - Label
    Private Sub ResetGA_Settings_CheckBox_AndLabel_MouseEnter() Handles ResetGA_Settings_CheckBox.MouseEnter, ResetGA_Settings_CheckBox_Label.MouseEnter
        SetToolTipInfo(ToolTip, ResetGA_Settings_CheckBox, "Internal Data", ToolTip.GetToolTip(ResetGA_Settings_CheckBox))
        SetToolTipInfo(ToolTip, ResetGA_Settings_CheckBox_Label, "Internal Data", ToolTip.GetToolTip(ResetGA_Settings_CheckBox_Label))
    End Sub
    Private Sub ClearData_Settings_CheckBox_Label_Click(sender As Object, e As EventArgs) Handles ResetGA_Settings_CheckBox_Label.Click
        If ResetGA_Settings_CheckBox.Checked Then
            ResetGA_Settings_CheckBox.Checked = False
        ElseIf Not ResetGA_Settings_CheckBox.Checked Then
            ResetGA_Settings_CheckBox.Checked = True
        End If
    End Sub

    ''ResetGA_LogsOnly_CheckBox - Label
    Private Sub ResetGA_LogsOnly_CheckBox_AndLabel_MouseEnter() Handles ResetGA_LogsOnly_CheckBox.MouseEnter, ResetGA_LogsOnly_CheckBox_Label.MouseEnter
        SetToolTipInfo(ToolTip, ResetGA_LogsOnly_CheckBox, "Log files", ToolTip.GetToolTip(ResetGA_LogsOnly_CheckBox))
        SetToolTipInfo(ToolTip, ResetGA_LogsOnly_CheckBox_Label, "Log files", ToolTip.GetToolTip(ResetGA_LogsOnly_CheckBox_Label))
    End Sub
    Private Sub ResetGA_LogsOnly_CheckBox_Label_Click(sender As Object, e As EventArgs) Handles ResetGA_LogsOnly_CheckBox_Label.Click
        If ResetGA_LogsOnly_CheckBox.Checked Then
            ResetGA_LogsOnly_CheckBox.Checked = False
        ElseIf Not ResetGA_LogsOnly_CheckBox.Checked Then
            ResetGA_LogsOnly_CheckBox.Checked = True
        End If
    End Sub

    ''ToU_SwitchButton
    Private Sub ToU_SwitchButton_MouseDown(sender As Object, e As EventArgs) Handles ToU_SwitchButton.MouseDown, ToU_SwitchButton.KeyDown
        SettingsButtonSwitch_Style_MouseDown_KeyDown(ToU_SwitchButton)
    End Sub
    Private Sub ToU_SwitchButton_MouseUp(sender As Object, e As EventArgs) Handles ToU_SwitchButton.MouseUp, ToU_SwitchButton.KeyUp
        SettingsButtonSwitch_Style_MouseUp_KeyUp(ToU_SwitchButton)
    End Sub
    Private Sub ToU_SwitchButton_MouseEnter(sender As Object, e As EventArgs) Handles ToU_SwitchButton.MouseEnter
        SetToolTipInfo(ToolTip, ToU_SwitchButton, "Skip Terms of Use on startup", ToolTip.GetToolTip(ToU_SwitchButton)) ' ToolTip.GetToolTip(ShowToolTips_SwitchButton))
        SettingsButtonSwitch_Style_MouseEnter(ToU_SwitchButton, My.Settings.ToU_dontShow)
    End Sub
    Private Sub ToU_SwitchButton_MouseLeave(sender As Object, e As EventArgs) Handles ToU_SwitchButton.MouseLeave
        SettingsButtonSwitch_Style_MouseLeave(ToU_SwitchButton, My.Settings.ToU_dontShow)
    End Sub
    Private Sub ToU_SwitchButton_Click(sender As Object, e As EventArgs) Handles ToU_SwitchButton.Click
        SettingsButtonSwitch_Style_MouseClick(ToU_SwitchButton, My.Settings.ToU_dontShow, ToolTip, ToU_SwitchButton_ToolTip)
    End Sub

    ''AppMode_SwitchButton
    Private Sub AppMode_SwitchButton_MouseDown(sender As Object, e As EventArgs) Handles AppMode_SwitchButton.MouseDown, AppMode_SwitchButton.KeyDown
        SettingsButtonSwitch_Style_MouseDown_KeyDown(AppMode_SwitchButton)
    End Sub
    Private Sub AppMode_SwitchButton_MouseUp(sender As Object, e As EventArgs) Handles AppMode_SwitchButton.MouseUp, AppMode_SwitchButton.KeyUp
        SettingsButtonSwitch_Style_MouseUp_KeyUp(AppMode_SwitchButton)
    End Sub
    Private Sub AppMode_SwitchButton_MouseEnter(sender As Object, e As EventArgs) Handles AppMode_SwitchButton.MouseEnter
        SetToolTipInfo(ToolTip, AppMode_SwitchButton, "Skip App Mode on startup", ToolTip.GetToolTip(AppMode_SwitchButton))
        SettingsButtonSwitch_Style_MouseEnter(AppMode_SwitchButton, My.Settings.AppMode_dontshow)
    End Sub
    Private Sub AppMode_SwitchButton_MouseLeave(sender As Object, e As EventArgs) Handles AppMode_SwitchButton.MouseLeave
        SettingsButtonSwitch_Style_MouseLeave(AppMode_SwitchButton, My.Settings.AppMode_dontshow)
    End Sub
    Private Sub AppMode_SwitchButton_Click(sender As Object, e As EventArgs) Handles AppMode_SwitchButton.Click
        SettingsButtonSwitch_Style_MouseClick(AppMode_SwitchButton, My.Settings.AppMode_dontshow, ToolTip, AppMode_SwitchButton_ToolTip)
    End Sub

    ''PopupMessages_SwitchButton
    Private Sub PopupMessages_SwitchButton_MouseDown(sender As Object, e As EventArgs) Handles PopupMessages_SwitchButton.MouseDown, PopupMessages_SwitchButton.KeyDown
        SettingsButtonSwitch_Style_MouseDown_KeyDown(PopupMessages_SwitchButton)
    End Sub
    Private Sub PopupMessages_SwitchButton_MouseUp(sender As Object, e As EventArgs) Handles PopupMessages_SwitchButton.MouseUp, PopupMessages_SwitchButton.KeyUp
        SettingsButtonSwitch_Style_MouseUp_KeyUp(PopupMessages_SwitchButton)
    End Sub
    Private Sub PopupMessages_SwitchButton_MouseEnter(sender As Object, e As EventArgs) Handles PopupMessages_SwitchButton.MouseEnter
        SetToolTipInfo(ToolTip, PopupMessages_SwitchButton, "Pop-up Messages", ToolTip.GetToolTip(PopupMessages_SwitchButton))
        SettingsButtonSwitch_Style_MouseEnter(PopupMessages_SwitchButton, My.Settings.PopupMessages)
    End Sub
    Private Sub PopupMessages_SwitchButton_MouseLeave(sender As Object, e As EventArgs) Handles PopupMessages_SwitchButton.MouseLeave
        SettingsButtonSwitch_Style_MouseLeave(PopupMessages_SwitchButton, My.Settings.PopupMessages)
    End Sub
    Private Sub PopupMessages_SwitchButton_Click(sender As Object, e As EventArgs) Handles PopupMessages_SwitchButton.Click
        SettingsButtonSwitch_Style_MouseClick(PopupMessages_SwitchButton, My.Settings.PopupMessages, ToolTip, PopupMessages_SwitchButton_ToolTip)
    End Sub

    ''VerbousLogging_SwitchButton
    Private Sub VerbousLogging_SwitchButton_MouseDown(sender As Object, e As EventArgs) Handles VerbousLogging_SwitchButton.MouseDown, VerbousLogging_SwitchButton.KeyDown
        SettingsButtonSwitch_Style_MouseDown_KeyDown(VerbousLogging_SwitchButton)
    End Sub
    Private Sub VerbousLogging_SwitchButton_MouseUp(sender As Object, e As EventArgs) Handles VerbousLogging_SwitchButton.MouseUp, VerbousLogging_SwitchButton.KeyUp
        SettingsButtonSwitch_Style_MouseUp_KeyUp(VerbousLogging_SwitchButton)
    End Sub
    Private Sub VerbousLogging_SwitchButton_MouseEnter(sender As Object, e As EventArgs) Handles VerbousLogging_SwitchButton.MouseEnter
        SetToolTipInfo(ToolTip, VerbousLogging_SwitchButton, "Verbous Logging", ToolTip.GetToolTip(VerbousLogging_SwitchButton))
        SettingsButtonSwitch_Style_MouseEnter(VerbousLogging_SwitchButton, My.Settings.VerboseLogging)
    End Sub
    Private Sub VerbousLogging_SwitchButton_MouseLeave(sender As Object, e As EventArgs) Handles VerbousLogging_SwitchButton.MouseLeave
        SettingsButtonSwitch_Style_MouseLeave(VerbousLogging_SwitchButton, My.Settings.VerboseLogging)
    End Sub
    Private Sub VerbousLogging_SwitchButton_Click(sender As Object, e As EventArgs) Handles VerbousLogging_SwitchButton.Click
        SettingsButtonSwitch_Style_MouseClick(VerbousLogging_SwitchButton, My.Settings.VerboseLogging, ToolTip, VerbousLogging_SwitchButton_ToolTip)
        VerbousLoggingStateSet()
    End Sub
    Private Sub VerbousLoggingStateSet()
        If My.Settings.VerboseLogging Then
            If My.Settings.VerboseLoggingPrompt Then VerbousLoggingPrompt_SwitchButton.PerformClick()
            VerbousLoggingPrompt_SwitchButton.Enabled = False
        Else
            VerbousLoggingPrompt_SwitchButton.Enabled = True
            SettingsButtonSwitch_Style_EnableIfTrue(VerbousLoggingPrompt_SwitchButton, My.Settings.VerboseLoggingPrompt)
        End If
    End Sub

    ''VerbousLoggingPrompt_SwitchButton
    Private Sub VerbousLoggingPrompt_SwitchButton_MouseDown(sender As Object, e As EventArgs) Handles VerbousLoggingPrompt_SwitchButton.MouseDown, VerbousLoggingPrompt_SwitchButton.KeyDown
        SettingsButtonSwitch_Style_MouseDown_KeyDown(VerbousLoggingPrompt_SwitchButton)
    End Sub
    Private Sub VerbousLoggingPrompt_SwitchButton_MouseUp(sender As Object, e As EventArgs) Handles VerbousLoggingPrompt_SwitchButton.MouseUp, VerbousLoggingPrompt_SwitchButton.KeyUp
        SettingsButtonSwitch_Style_MouseUp_KeyUp(VerbousLoggingPrompt_SwitchButton)
    End Sub
    Private Sub VerbousLoggingPrompt_SwitchButton_MouseEnter(sender As Object, e As EventArgs) Handles VerbousLoggingPrompt_SwitchButton.MouseEnter
        SetToolTipInfo(ToolTip, VerbousLoggingPrompt_SwitchButton, "Verbous Logging", ToolTip.GetToolTip(VerbousLoggingPrompt_SwitchButton))
        SettingsButtonSwitch_Style_MouseEnter(VerbousLoggingPrompt_SwitchButton, My.Settings.VerboseLoggingPrompt)
    End Sub
    Private Sub VerbousLoggingPrompt_SwitchButton_MouseLeave(sender As Object, e As EventArgs) Handles VerbousLoggingPrompt_SwitchButton.MouseLeave
        SettingsButtonSwitch_Style_MouseLeave(VerbousLoggingPrompt_SwitchButton, My.Settings.VerboseLoggingPrompt)
    End Sub
    Private Sub VerbousLoggingPrompt_SwitchButton_Click(sender As Object, e As EventArgs) Handles VerbousLoggingPrompt_SwitchButton.Click
        SettingsButtonSwitch_Style_MouseClick(VerbousLoggingPrompt_SwitchButton, My.Settings.VerboseLoggingPrompt, ToolTip, VerbousLoggingPrompt_Tooltip)
    End Sub

    ''ShowToolTips_SwitchButton
    Private Sub ShowToolTips_SwitchButton_MouseDown(sender As Object, e As EventArgs) Handles ShowToolTips_SwitchButton.MouseDown, ShowToolTips_SwitchButton.KeyDown
        SettingsButtonSwitch_Style_MouseDown_KeyDown(ShowToolTips_SwitchButton)
    End Sub
    Private Sub ShowToolTips_SwitchButton_MouseUp(sender As Object, e As EventArgs) Handles ShowToolTips_SwitchButton.MouseUp, ShowToolTips_SwitchButton.KeyUp
        SettingsButtonSwitch_Style_MouseUp_KeyUp(ShowToolTips_SwitchButton)
    End Sub
    Private Sub ShowToolTips_SwitchButton_MouseEnter(sender As Object, e As EventArgs) Handles ShowToolTips_SwitchButton.MouseEnter
        SetToolTipInfo(ToolTip, ShowToolTips_SwitchButton, "Show Tooltips", ToolTip.GetToolTip(ShowToolTips_SwitchButton))
        SettingsButtonSwitch_Style_MouseEnter(ShowToolTips_SwitchButton, My.Settings.ShowToolTips)
    End Sub
    Private Sub ShowToolTips_SwitchButton_MouseLeave(sender As Object, e As EventArgs) Handles ShowToolTips_SwitchButton.MouseLeave
        SettingsButtonSwitch_Style_MouseLeave(ShowToolTips_SwitchButton, My.Settings.ShowToolTips)
    End Sub
    Private Sub ShowToolTips_SwitchButton_Click(sender As Object, e As EventArgs) Handles ShowToolTips_SwitchButton.Click
        SettingsButtonSwitch_Style_MouseClick(ShowToolTips_SwitchButton, My.Settings.ShowToolTips, ToolTip, ShowTooltips_SwitchButton_ToolTip)
    End Sub

    ''OpenLogsFolder
    Private Sub OpenLogsFolder_MouseEnter(sender As Object, e As EventArgs) Handles OpenLogsFolder.MouseEnter
        OpenLogsFolder.BackColor = Color.Silver
    End Sub
    Private Sub OpenLogsFolder_MouseLeave(sender As Object, e As EventArgs) Handles OpenLogsFolder.MouseLeave
        OpenLogsFolder.BackColor = Color.Transparent
    End Sub
    Private Sub OpenLogsFolder_MouseDown_KeyDown(sender As Object, e As EventArgs) Handles OpenLogsFolder.MouseDown, OpenLogsFolder.KeyDown
        OpenLogsFolder.ForeColor = Color.White
        OpenLogsFolder.BackColor = Color.FromArgb(64, 64, 64)
    End Sub
    Private Sub OpenLogsFolder_MouseUp_KeyUp(sender As Object, e As EventArgs) Handles OpenLogsFolder.MouseUp, OpenLogsFolder.KeyUp
        OpenLogsFolder.ForeColor = Color.FromArgb(64, 64, 64)
        OpenLogsFolder.BackColor = Color.Transparent
    End Sub
    Private Sub OpenLogsFolder_Click(sender As Object, e As EventArgs) Handles OpenLogsFolder.Click
        Process.Start(GA_logs)
    End Sub

    ''AutoClearLogs_SwitchButton
    Private Sub AutoClearLogs_SwitchButton_MouseDown(sender As Object, e As EventArgs) Handles AutoClearLogs_SwitchButton.MouseDown, AutoClearLogs_SwitchButton.KeyDown
        SettingsButtonSwitch_Style_MouseDown_KeyDown(AutoClearLogs_SwitchButton)
    End Sub
    Private Sub AutoClearLogs_SwitchButton_MouseUp(sender As Object, e As EventArgs) Handles AutoClearLogs_SwitchButton.MouseUp, AutoClearLogs_SwitchButton.KeyUp
        SettingsButtonSwitch_Style_MouseUp_KeyUp(AutoClearLogs_SwitchButton)
    End Sub
    Private Sub AutoClearLogs_SwitchButton_MouseEnter(sender As Object, e As EventArgs) Handles AutoClearLogs_SwitchButton.MouseEnter
        SetToolTipInfo(ToolTip, AutoClearLogs_SwitchButton, "Auto Clear Logs", ToolTip.GetToolTip(AutoClearLogs_SwitchButton))
        SettingsButtonSwitch_Style_MouseEnter(AutoClearLogs_SwitchButton, My.Settings.AutoClearLogs)
    End Sub
    Private Sub AutoClearLogs_SwitchButton_MouseLeave(sender As Object, e As EventArgs) Handles AutoClearLogs_SwitchButton.MouseLeave
        SettingsButtonSwitch_Style_MouseLeave(AutoClearLogs_SwitchButton, My.Settings.AutoClearLogs)
    End Sub
    Private Sub AutoClearLogs_SwitchButton_Click(sender As Object, e As EventArgs) Handles AutoClearLogs_SwitchButton.Click
        SettingsButtonSwitch_Style_MouseClick(AutoClearLogs_SwitchButton, My.Settings.AutoClearLogs, ToolTip, AutoClearLogs_SwitchButton_ToolTip)
    End Sub

    ''PerformThemeAnimation_SwitchButton
    Private Sub PerformThemeAnimation_SwitchButton_MouseDown(sender As Object, e As EventArgs) Handles PerformAnimation_SwitchButton.MouseDown, PerformAnimation_SwitchButton.KeyDown
        SettingsButtonSwitch_Style_MouseDown_KeyDown(PerformAnimation_SwitchButton)
    End Sub
    Private Sub PerformThemeAnimation_SwitchButton_MouseUp(sender As Object, e As EventArgs) Handles PerformAnimation_SwitchButton.MouseUp, PerformAnimation_SwitchButton.KeyUp
        SettingsButtonSwitch_Style_MouseUp_KeyUp(PerformAnimation_SwitchButton)
    End Sub
    Private Sub PerformThemeAnimation_SwitchButton_MouseEnter(sender As Object, e As EventArgs) Handles PerformAnimation_SwitchButton.MouseEnter
        SetToolTipInfo(ToolTip, PerformAnimation_SwitchButton, "Perform Theme Animation", ToolTip.GetToolTip(PerformAnimation_SwitchButton))
        SettingsButtonSwitch_Style_MouseEnter(PerformAnimation_SwitchButton, My.Settings.PerformAnimations)
    End Sub
    Private Sub PerformThemeAnimation_SwitchButton_MouseLeave(sender As Object, e As EventArgs) Handles PerformAnimation_SwitchButton.MouseLeave
        SettingsButtonSwitch_Style_MouseLeave(PerformAnimation_SwitchButton, My.Settings.PerformAnimations)
    End Sub
    Private Sub PerformThemeAnimation_SwitchButton_Click(sender As Object, e As EventArgs) Handles PerformAnimation_SwitchButton.Click
        SettingsButtonSwitch_Style_MouseClick(PerformAnimation_SwitchButton, My.Settings.PerformAnimations, ToolTip, PerformThemeAnimation_SwitchButton_ToolTip)
    End Sub
End Class