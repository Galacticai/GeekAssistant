Imports System.ComponentModel
Imports System.Management
Imports Transitions

Public Class Main
    Private WithEvents EventWatcher As ManagementEventWatcher
    Private EventQuery As New WqlEventQuery
    Private saved_devCount As Integer = -1 'not 0 or 1 to initialize
    Private WithEvents Delayed_DeviceChanged_Timer As Timer = New Timer With {.Interval = 200} 'delay to avoid repeating the code when the event is firing too many times 
    Private Sub EventWatcher_EventArrived(sender As Object, ev As EventArrivedEventArgs) Handles EventWatcher.EventArrived
        Invoke(Sub() Delayed_DeviceChanged_Timer.Enabled = True)
    End Sub
    Private Sub Delayed_DeviceChanged_Timer_Tick() Handles Delayed_DeviceChanged_Timer.Tick
        Dim devCount = madb_GetDeviceCount()
        If saved_devCount <> devCount Then
            saved_devCount = devCount
            Invoke(Sub()
                       AutoDetect.Run(True)
                       LogEvent(DeviceState_Label.Text, 1)
                   End Sub)
        End If
        Delayed_DeviceChanged_Timer.Enabled = False
    End Sub

    Sub Main_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        If Application.OpenForms.OfType(Of PleaseWait).Any Then 'Cancel if a process by GA is currently running
            Media.SystemSounds.Beep.Play()
            Exit Sub
        End If
        EventWatcher.Stop()

        LogEvent("End", 3)
        CreateLog()
        My.Settings.Save()
        Environment.Exit(Environment.ExitCode) 'Quit all threads while closing
        Process.GetCurrentProcess.Kill() 'Kill Geek Assistant completely in case any thread was locking Environment.Exit
    End Sub
    Private Sub Main_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        '24, 97  
        Dim titleHeight = RectangleToScreen(ClientRectangle).Top - Top
        PleaseWait.SetBounds(Location.X + 24, Location.Y + 97 + titleHeight, PleaseWait.Width, PleaseWait.Height)
    End Sub
    Private Sub Main_Help(sender As Object, e As EventArgs) Handles MyBase.HelpButtonClicked
        ToU.ShowDialog()
    End Sub
    Private WithEvents MainLoad_Delay_Timer As New Timer With {.Interval = 100}
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0

        Preparing.Show()
        Preparing.BringToFront()
        MainLoad_Delay_Timer.Enabled = True
    End Sub
    Private Sub MainLoad_Delay_Timer_Tick() Handles MainLoad_Delay_Timer.Tick

        'WindowState = FormWindowState.Normal
        MainLoad_Delay_Timer.Enabled = False
        GA_SetTheme.Run(Name, True)
        Width = 690 'Set width to avoid using the width selected while developing

        Text = GA_Ver.Run("MainTitle")
        GA_About_Label.Text = GA_Ver.Run("Main")
        log.Text = GA_Ver.Run("log")

        If My.Settings.AutoClearLogs Then GA_Log.ClearIf30days()
        LogEvent("Start", 1)
        GA_PrepareAppdata.Run()
        PrepareAndroidDictionary()
        ResetDeviceInfo()

        AutoDetect.Run(True)

        If DeviceState_Label.Text <> "Disconnected" Then LogEvent(DeviceState_Label.Text, 1)

        EventQuery = New WqlEventQuery("Select * from Win32_DeviceChangeEvent") '("SELECT * FROM __InstanceCreationEvent  WITHIN 2 WHERE TargetInstance ISA 'Win32_PnPEntity'") '("Select * from Win32_DeviceChangeEvent") 
        EventWatcher = New ManagementEventWatcher(EventQuery)
        EventWatcher.Start()

        DoNeutral()
        AutoDetectDeviceInfo_Button.Select()

        Opacity = 100
        BringToFront()
    End Sub

    Private Sub Main_HelpButtonClicked() Handles MyBase.HelpButtonClicked
        MessageBox.Show(My.Resources.FeatureUnavailable, "Help - Geek Assistant", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Media.SystemSounds.Beep.Play()
    End Sub
    Private Sub Main_MouseMove() Handles MyBase.MouseMove
        SetToolTipInfo(Main_ToolTip, Me, "Selected:", Nothing)
    End Sub
    'Private bool1Time As Boolean = True
    Private Sub AutoDetectDeviceInfo_Button_MouseEnter() Handles AutoDetectDeviceInfo_Button.MouseEnter
        SetToolTipInfo(Main_ToolTip, AutoDetectDeviceInfo_Button, "Auto Detect", "Let Geek Assistant automatically detect your device's information")
        'AutoDetectDeviceInfo_Button.BackColor = Color.Honeydew
        'AutoDetectDeviceInfo_Button.BackgroundImage = My.Resources.LightBlue_Up_Gradient
        'AutoDetectFlash_Timer_Deprecated.Enabled = False
        'If bool1Time Then
        '    bool1Time = False
        '    MessageBox.Show("imagine the pressed down style is the normal one," & vbCrLf& " and the normal style as pressed down")
        'End If
    End Sub
    Private Sub AutoDetectDeviceInfo_Button_MouseDown_KeyDown() Handles AutoDetectDeviceInfo_Button.MouseDown, AutoDetectDeviceInfo_Button.KeyDown
        If My.Settings.DarkTheme Then
            AutoDetectDeviceInfo_Button.ForeColor = Color.FromArgb(0, 128, 32)
            AutoDetectDeviceInfo_Button.Image = My.Resources.AutoDetect_64
        Else
            AutoDetectDeviceInfo_Button.ForeColor = Color.FromArgb(95, 191, 119)
            AutoDetectDeviceInfo_Button.Image = My.Resources.AutoDetect_dark_64
        End If
    End Sub
    Private Sub AutoDetectDeviceInfo_Button_MouseUp_KeyUp() Handles AutoDetectDeviceInfo_Button.MouseUp, AutoDetectDeviceInfo_Button.KeyUp
        If My.Settings.DarkTheme Then
            AutoDetectDeviceInfo_Button.ForeColor = Color.FromArgb(95, 191, 119)
            AutoDetectDeviceInfo_Button.Image = My.Resources.AutoDetect_dark_64
        Else
            AutoDetectDeviceInfo_Button.ForeColor = Color.FromArgb(0, 128, 32)
            AutoDetectDeviceInfo_Button.Image = My.Resources.AutoDetect_64
        End If
    End Sub
    Private Sub AutoDetectDeviceInfo_Button_Click() Handles AutoDetectDeviceInfo_Button.Click
        GA_PleaseWait.Run(True)
        ShowPleaseWaitThenAutoDetect_Timer.Enabled = True 'delay to let PleaseWait completely render before it closes (looks like a glitch without a delay)
    End Sub
    Private WithEvents ShowPleaseWaitThenAutoDetect_Timer As New Timer With {.Interval = 100}
    Private Sub delayedClose_Timer_Tick() Handles ShowPleaseWaitThenAutoDetect_Timer.Tick
        ShowPleaseWaitThenAutoDetect_Timer.Enabled = False
        AutoDetect.Run()
    End Sub

    'Private Sub AutoDetectFlash_Timer_Tick(sender As Object, e As EventArgs) Handles AutoDetectFlash_Timer_Deprecated.Tick
    '    If AutoDetectDeviceInfo_Button.BackColor = SystemColors.ButtonFace Then
    '        AutoDetectDeviceInfo_Button.ForeColor = Color.FromArgb(95, 191, 119)
    '        AutoDetectDeviceInfo_Button.BackColor = Color.FromArgb(190, 240, 190)
    '        AutoDetectDeviceInfo_Button.BackgroundImage = My.Resources.LightBlue_Up_Gradient
    '    Else
    '        AutoDetectDeviceInfo_Button.ForeColor = Color.FromArgb(0, 128, 32)
    '        AutoDetectDeviceInfo_Button.BackColor = SystemColors.ButtonFace
    '        AutoDetectDeviceInfo_Button.BackgroundImage = Nothing
    '    End If
    'End Sub 

    Private Sub ShowLog_MouseEnter(sender As Object, e As EventArgs) Handles ShowLog_Button.MouseEnter, log.MouseEnter, ShowLog_Button.MouseEnter, ProgressFakeBG_UI.MouseEnter, ProgressBarLabel.MouseEnter
        SetToolTipInfo(Main_ToolTip, ShowLog_Button, "Show log", "Click to show/hide the log")
        StopNotifyIfLogSeen()
    End Sub
    Private Sub ShowLog_Click(sender As Object, e As EventArgs) Handles ShowLog_Button.Click
        ShowLog_ErrorBlink_Timer.Enabled = False
        ShowLog_InfoBlink_Timer.Enabled = False
        If Width = 1190 Then
            If Not My.Settings.PerformAnimations Then
                Width = 690
                Exit Sub
            End If
            Transition.run(Me, "Width", 690, New TransitionType_CriticalDamping(500))
        ElseIf Width = 690 Then
            If Not My.Settings.PerformAnimations Then
                Width = 1190
                Exit Sub
            End If
            Transition.run(Me, "Width", 1190, New TransitionType_CriticalDamping(500))
        End If
    End Sub

    Private Sub ShowLog_Button_ErrorBlink_Timer_Tick(sender As Object, e As EventArgs) Handles ShowLog_ErrorBlink_Timer.Tick
        If My.Settings.DarkTheme Then
            If ShowLog_Button.Tag = " " Then
                ShowLog_Button.Tag = "  "
                ShowLog_Button.Icon = My.Resources.Warning_Red_dark_24
            Else
                ShowLog_Button.Tag = " "
                ShowLog_Button.Icon = My.Resources.Warning_Red_24
            End If

        Else
            If ShowLog_Button.Tag = " " Then
                ShowLog_Button.Tag = "  "
                ShowLog_Button.Icon = My.Resources.Warning_Red_24
            Else
                ShowLog_Button.Tag = " "
                ShowLog_Button.Icon = My.Resources.Warning_Red_dark_24
            End If
        End If
    End Sub

    Private Sub ShowLog_InfoBlink_Timer_Tick(sender As Object, e As EventArgs) Handles ShowLog_InfoBlink_Timer.Tick
        If ShowLog_ErrorBlink_Timer.Enabled Then Exit Sub
        If My.Settings.DarkTheme Then
            If ShowLog_Button.Tag = " " Then
                ShowLog_Button.Tag = "  "
                ShowLog_Button.Icon = My.Resources.Info_Yellow_dark_24
            Else
                ShowLog_Button.Tag = " "
                ShowLog_Button.Icon = My.Resources.Info_Yellow_24
            End If

        Else
            If ShowLog_Button.Tag = " " Then
                ShowLog_Button.Tag = "  "
                ShowLog_Button.Icon = My.Resources.Info_Yellow_24
            Else
                ShowLog_Button.Tag = " "
                ShowLog_Button.Icon = My.Resources.Info_Yellow_dark_24
            End If
        End If
    End Sub

    Private Sub SettingsSave_Timer_Tick(sender As Object, e As EventArgs) Handles SettingsSave_Timer.Tick
        My.Settings.Save()
    End Sub

    Private Sub FlashZip_ChooseFile_Button_Click(sender As Object, e As EventArgs) Handles FlashZip_ChooseFile_Button.Click
        If FlashZip_OpenFileDialog.ShowDialog = DialogResult.OK Then
            LogAppendText($"// Flash ZIP //{vbCrLf}Selected file: {FlashZip_OpenFileDialog.FileName}", 2)
            'FlashZip_ChooseFile_TextBox.BackColor = Color.White
            'FlashZip_ChooseFile_TextBox.ForeColor = SystemColors.WindowText
            FlashZip_ChooseFile_TextBox.Text = FlashZip_OpenFileDialog.FileName
        End If
    End Sub
    Private Sub FlashZip_Start_Button_Click(sender As Object, e As EventArgs) Handles FlashZip_Button.Click
        If String.IsNullOrEmpty(FlashZip_OpenFileDialog.FileName) Then
            FlashZip_ChooseFile_Button.PerformClick()
            If String.IsNullOrEmpty(FlashZip_OpenFileDialog.FileName) Then Exit Sub
        End If
        FlashFiles.Run(FlashZip_OpenFileDialog.FileName)
    End Sub
    Private Sub FlashZip_ChooseFile_TextBox_DoubleClick(sender As Object, e As EventArgs) Handles FlashZip_ChooseFile_TextBox.DoubleClick
        FlashZip_ChooseFile_Button.PerformClick()
    End Sub

    Private Sub log_TextChanged(sender As Object, e As EventArgs) Handles log.TextChanged
        If log.Visible Then Exit Sub

        If ShowLog_ErrorBlink_Timer.Enabled = False Then
            ShowLog_InfoBlink_Timer.Enabled = True
        End If
    End Sub
    'Already Done above 
    'Private Sub log_MouseEnter(sender As Object, e As EventArgs) Handles log.MouseEnter
    '    StopNotifyIfLogSeen()
    'End Sub

    Private Sub ProgressBar_MouseEnter(sender As Object, e As EventArgs) Handles ProgressBar.MouseEnter
        SetToolTipInfo(Main_ToolTip, ProgressBar, "Status percentage", "Click to show/hide the log")
    End Sub
    Private Sub ProgressBar_Click(sender As Object, e As EventArgs) Handles ProgressBar.Click
        ShowLog_Button.PerformClick()
    End Sub

    Private Sub ProgressBarLabel_MouseEnter(sender As Object, e As EventArgs) Handles ProgressBarLabel.MouseEnter
        SetToolTipInfo(Main_ToolTip, ProgressBarLabel, "Status", "Click to show/hide the log")
    End Sub
    Private Sub ProgressBarLabel_Click(sender As Object, e As EventArgs) Handles ProgressBarLabel.Click
        ShowLog_Button.PerformClick()
    End Sub
    Private Sub ProgressBarLabel_Mousedown_KeyDown(sender As Object, e As EventArgs) Handles ProgressBarLabel.MouseDown, ProgressBarLabel.KeyDown
        With ProgressBarLabel
            .BackColor = Color.FromArgb(77, 104, 124)
            .ForeColor = Color.White
        End With
    End Sub
    Private Sub ProgressBarLabel_MouseUp_KeyUp(sender As Object, e As EventArgs) Handles ProgressBarLabel.MouseUp, ProgressBarLabel.KeyUp
        With ProgressBarLabel
            .BackColor = Color.White
            .ForeColor = SystemColors.ControlText
        End With
    End Sub
    Private Sub Manufacturer_ComboBox_MouseEnter(sender As Object, e As EventArgs) Handles Manufacturer_ComboBox.MouseEnter
        SetToolTipInfo(Main_ToolTip, Manufacturer_ComboBox, "Manufacturer", "(Required) Select your device's manufacturer")
    End Sub

    Private Sub AndroidVersion_ComboBox_MouseEnter(sender As Object, e As EventArgs) Handles AndroidVersion_ComboBox.MouseEnter
        SetToolTipInfo(Main_ToolTip, AndroidVersion_ComboBox, "Android Version", "Select your device's android version")
    End Sub
    'Private Sub DeviceCount_ValueChanged(sender As Object, e As EventArgs) Handles DeviceCount.ValueChanged
    '    If ShowDeviceCountChanged Then
    '        My.Settings.adbDeviceCount = DeviceCount.Value
    '        My.Settings.Save()
    '        Dim msg As String = $"Device count saved. ({DeviceCount.Value.ToString})"
    '        LogAppendText(msg, 2)
    '        ProgressBarLabel.Text = msg
    '    End If
    'End Sub

    Public Sub DoNeutral()
        ShowLog_InfoBlink_Timer.Enabled = False
        ShowLog_ErrorBlink_Timer.Enabled = False
        If My.Settings.DarkTheme Then
            ShowLog_Button.Icon = My.Resources.Commands_dark_24
        Else ShowLog_Button.Icon = My.Resources.Commands_24
        End If
        ProgressBar.Style = MetroFramework.MetroColorStyle.Green
        ProgressBar.Value = 0
        ProgressBarLabel.Text = "Current process information will be written here. Click for more information >>"
    End Sub

    '#Region "Tabs Animation"

    '    Private Sub AnimateTab(RequestedTabBox As GroupBox)

    '    End Sub

    '#End Region

#Region "Left area"

    Private Sub DeviceState_Label_TextChanged() Handles DeviceState_Label.TextChanged
        Select Case DeviceState_Label.Text
            Case "Disconnected", "Unknown"
                DeviceState_Label.ForeColor = Color.FromArgb(128, 128, 128)
            Case "Offline"
                DeviceState_Label.ForeColor = Color.FromArgb(128, 0, 0)
            Case "Download mode", "Recovery mode", "Fastboot mode"
                DeviceState_Label.ForeColor = Color.FromArgb(128, 128, 0)
            Case "Connected (ADB)"
                If My.Settings.DarkTheme Then
                    DeviceState_Label.ForeColor = Color.FromArgb(95, 191, 119)
                Else DeviceState_Label.ForeColor = Color.FromArgb(0, 128, 32)
                End If
            Case "Multiple"
                DeviceState_Label.ForeColor = Color.FromArgb(128, 0, 128)
        End Select
    End Sub

    Private Sub Manufacturer_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Manufacturer_ComboBox.SelectedIndexChanged
        If Not Working Then My.Settings.DeviceManufacturer = Manufacturer_ComboBox.Text
    End Sub
    Private Sub AndroidVersion_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AndroidVersion_ComboBox.SelectedIndexChanged
        If Not Working Then My.Settings.DeviceAPILevel = ConvertAVerToAPILevel(AndroidVersion_ComboBox.Text)
    End Sub
    Private Sub BootloaderUnlockable_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BootloaderUnlockable_CheckBox.CheckedChanged
        If Not Working Then My.Settings.DeviceBootloaderUnlockSupported = BootloaderUnlockable_CheckBox.Checked
    End Sub
    Private Sub Rooted_Checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles Rooted_Checkbox.CheckedChanged
        If Not Working Then My.Settings.DeviceRooted = Rooted_Checkbox.Checked
    End Sub
    Private Sub CustomROM_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CustomROM_CheckBox.CheckedChanged
        If Not Working Then My.Settings.DeviceCustomROM = CustomROM_CheckBox.Checked
    End Sub
    Private Sub CustomRecovery_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CustomRecovery_CheckBox.CheckedChanged
        If Not Working Then My.Settings.DeviceCustomRecovery = CustomRecovery_CheckBox.Checked
    End Sub

#End Region

#Region "Upper right buttons"
    Private Sub Settings_Button_MouseEnter(sender As Object, e As EventArgs) Handles Settings.MouseEnter, Settings_Button.MouseEnter
        SetToolTipInfo(Main_ToolTip, Settings_Button, "Settings", "Reset / Modify various options inside Geek Assistant")
    End Sub
    'Private Sub Settings_Button_MouseLeave_MouseUp_KeyUp() Handles Settings_Button.MouseLeave, Settings_Button.MouseUp, Settings_Button.KeyUp
    '    Settings_Button.Image = My.Resources.Settings_B_24
    'End Sub
    'Private Sub Settings_Button_MouseDown_KeyDown() Handles Settings.MouseDown, Settings_Button.KeyDown
    '    Settings_Button.Image = My.Resources.Settings_W_24
    'End Sub
    Private Sub Settings_Button_Click(sender As Object, e As EventArgs) Handles Settings_Button.Click
        GA_Settings.ShowDialog()
    End Sub

    Private Sub About_Button_MouseEnter(sender As Object, e As EventArgs) Handles About_Button.MouseEnter
        SetToolTipInfo(Main_ToolTip, About_Button, "About Geek Assistant", "View some information about this program")
    End Sub
    'Private Sub About_Button_MouseLeave_MouseUp_KeyUp(sender As Object, e As EventArgs) Handles About_Button.MouseLeave, About_Button.MouseUp, About_Button.KeyUp
    '    About_Button.Image = My.Resources.info_B_24
    'End Sub
    'Private Sub About_Button_MouseDown_KeyDown(sender As Object, e As EventArgs) Handles About_Button.MouseDown, About_Button.KeyDown
    '    About_Button.Image = My.Resources.info_W_24
    'End Sub
    'Private Sub About_Button_Clic(sender As Object, e As EventArgs) Handles 

    'End Sub
    Private Sub About_Button_Click(sender As Object, e As EventArgs) Handles About_Button.Click
        ToU.RunningAlready = True
        ToU.ShowDialog()
    End Sub
    Private Sub Donate_Button_Click(sender As Object, e As EventArgs) Handles Donate_Button.Click
        If My.Application.OpenForms.OfType(Of Donate).Any Then _
             Donate.Close()
        Donate.Show()
        Donate.BringToFront()
    End Sub
    Private Sub Donate_Button_MouseEnter(sender As Object, e As EventArgs) Handles Donate_Button.MouseEnter
        SetToolTipInfo(Main_ToolTip, Donate_Button, "Send love", "Support the Developer.")
    End Sub

    Private Sub Feedback_Button_MouseEnter(sender As Object, e As EventArgs) Handles Feedback_Button.MouseEnter, SwitchTheme_Button.MouseEnter
        SetToolTipInfo(Main_ToolTip, Feedback_Button, "Send Feedback", $"Reach out to the developer.")
    End Sub
    'Private Sub Feedback_Button_MouseLeave_MouseUp_KeyUp(sender As Object, e As EventArgs) Handles Feedback_Button.MouseLeave, Feedback_Button.MouseUp, Feedback_Button.KeyUp
    '    Feedback_Button.Image = My.Resources.report_B_24
    'End Sub
    'Private Sub Feedback_Button_MouseDown_KeyDown(sender As Object, e As EventArgs) Handles Feedback_Button.MouseDown, Feedback_Button.KeyDown
    '    Feedback_Button.Image = My.Resources.report_W_24
    'End Sub
    Private Sub Feedback_Button_Click(sender As Object, e As EventArgs) Handles Feedback_Button.Click
        Dim Feedback_Answer = GA_infoAsk.Run("Send Feedback",
                                            $" - Mailing To ""nhkomaiha@gmail.com""{vbCrLf}{vbCrLf}You will be redirected To your Default mailing program.{vbCrLf}Do you want To Continue?",
                                             "Continue to mail", "Cancel")
        If Feedback_Answer Then Process.Start("mailto:nhkomaiha@gmail.com")
    End Sub
    Private Sub SwitchTheme_Click(sender As Object, e As EventArgs) Handles SwitchTheme_Button.Click
        If My.Settings.DarkTheme Then
            GA_SetTheme.Run(Name)
            My.Settings.DarkTheme = False
        Else
            GA_SetTheme.Run(Name)
            My.Settings.DarkTheme = True
        End If
    End Sub
    Private Sub SwitchTheme_MouseEnter(sender As Object, e As EventArgs) Handles SwitchTheme_Button.MouseEnter
        SetToolTipInfo(Main_ToolTip, SwitchTheme_Button, "Switch Theme", "Turn the lights on or off!")
    End Sub
#End Region

#Region "log area"
    Private Sub CopyLogToClipboard_MouseEnter(sender As Object, e As EventArgs) Handles CopyLogToClipboard.MouseEnter
        SetToolTipInfo(Main_ToolTip, CopyLogToClipboard, "Copy log", "Copy the current log contents to clipboard")
    End Sub
    Private Sub CopyLogToClipboard_MouseDown(sender As Object, e As MouseEventArgs) Handles CopyLogToClipboard.MouseDown
        CopyLogToClipboard.Image = My.Resources.Copy_W_24
    End Sub
    Private Sub CopyLogToClipboard_MouseUp(sender As Object, e As MouseEventArgs) Handles CopyLogToClipboard.MouseUp
        CopyLogToClipboard.Image = My.Resources.Copy_B_24
    End Sub
    Private Sub CopyLogToClipboard_Click(sender As Object, e As EventArgs) Handles CopyLogToClipboard.Click
        LogEvent("Copied log to clipboard.", 2)
        Clipboard.SetText(log.Text)
    End Sub

    Private Sub ClearLog_Button_MouseEnter(sender As Object, e As EventArgs) Handles ClearLog_Button.MouseEnter
        SetToolTipInfo(Main_ToolTip, ClearLog_Button, "Clear log", "Save the current log and continue with a new fresh one")
    End Sub
    Private Sub ClearLog_Button_MouseDown_KeyDown(sender As Object, e As EventArgs) Handles ClearLog_Button.MouseDown, ClearLog_Button.KeyDown
        ClearLog_Button.Image = My.Resources.Backspace_W_24
    End Sub
    Private Sub ClearLog_Button_MouseUp_KeyUp(sender As Object, e As EventArgs) Handles ClearLog_Button.MouseUp, ClearLog_Button.KeyUp
        ClearLog_Button.Image = My.Resources.Backspace_B_24
    End Sub
    Private Sub ClearLog_Button_Click(sender As Object, e As EventArgs) Handles ClearLog_Button.Click
        ResetLog()
    End Sub

    Private Sub OpenLogFolder_MouseEnter(sender As Object, e As EventArgs) Handles OpenLogFolder.MouseEnter
        SetToolTipInfo(Main_ToolTip, OpenLogFolder, "Open logs folder", GA_logs)
    End Sub
    Private Sub OpenLogFolder_MouseDown_KeyDown(sender As Object, e As EventArgs) Handles OpenLogFolder.MouseDown, OpenLogFolder.KeyDown
        OpenLogFolder.Image = My.Resources.OpenFolder_W_24
    End Sub
    Private Sub OpenLogFolder_MouseUp_KeyUp(sender As Object, e As EventArgs) Handles OpenLogFolder.MouseUp, OpenLogFolder.KeyUp
        OpenLogFolder.Image = My.Resources.OpenFolder_B_24
    End Sub

    Private Sub OpenLogFolder_Click(sender As Object, e As EventArgs) Handles OpenLogFolder.Click
        Process.Start(GA_logs)
    End Sub

    Private Sub adbManualCMD_TextBox_MouseEnter_MouseLeave_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles manualCMD_TextBox.MouseEnter, manualCMD_TextBox.MouseLeave, manualCMD_TextBox.TextChanged
        DoNeutral()
    End Sub

    Private cmd_Previous, cmd_Current As String
    Private Sub adbManualCMD_TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles manualCMD_TextBox.KeyDown
        If e.KeyCode = Keys.Enter Then manualCMD_TextBox.BackColor = Color.LightBlue
    End Sub

    Private Sub UnlockBL_Button_Click(sender As Object, e As EventArgs) Handles UnlockBL_Button.Click
        'FeatureUnavailable_MessageBox.Run("Unlock Bootloader")
        UnlockBL.Run()
    End Sub

    Private Sub MagiskRoot_Button_Click(sender As Object, e As EventArgs) Handles MagiskRoot_Button.Click
        FeatureUnavailable_MessageBox.Run("Root with magisk")
    End Sub

    Private Sub AutoDetectDeviceInfo_Button_Click(sender As Object, e As EventArgs) Handles AutoDetectDeviceInfo_Button.Click

    End Sub

    Private Sub DeviceState_Label_Click(sender As Object, e As EventArgs) Handles DeviceState_Label.Click

    End Sub

    Private Sub manualCMD_TextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles manualCMD_TextBox.KeyUp

        Select Case e.KeyCode
            Case Keys.Enter  'And adbManualCMD_TextBox.Text <> ""
                manualCMD_TextBox.BackColor = Color.White
                ErrorCodeTrack("manualCmd")
                cmd.Run(manualCMD_TextBox.Text)

                cmd_Previous = manualCMD_TextBox.Text
                GA_SetProgressText.Run("Running adb command...", -1)
                'adbDo(manualCMD_TextBox.Text)
                ''LogEvent("Manual ADB Command", 2)
                manualCMD_TextBox.Text = ""
                ShowLog_InfoBlink_Timer.Start()

            Case Keys.Up
                If cmd_Current <> manualCMD_TextBox.Text Then cmd_Current = manualCMD_TextBox.Text
                If manualCMD_TextBox.Text <> cmd_Previous Then
                    With manualCMD_TextBox
                        .Text = cmd_Previous
                        .SelectionStart = manualCMD_TextBox.Text.Length + 99
                        .SelectionLength = 0
                    End With
                End If
            Case Keys.Down

                With manualCMD_TextBox
                    .Text = cmd_Current
                    .SelectionStart = manualCMD_TextBox.Text.Length + 99
                    .SelectionLength = 0
                End With
        End Select

        'ElseIf e.KeyCode = Keys.Control Or e.KeyCode = Keys.Back Then
        '    SendKeys.SendWait("^+{LEFT}{BACKSPACE}") 'Wait for LCtrl+Back combination
        '    'Dim spaceCount As Integer = 0
        '    'For Each c As Char In manualCMD_TextBox.Text
        '    '    If c = " " Then
        '    '        spaceCount += 1
        '    '    End If
        '    'Next
        '    'If spaceCount = 0 Then Exit Sub

        '    Dim pos As Integer = manualCMD_TextBox.Text.LastIndexOf("\")
        '    If pos <> -1 Then manualCMD_TextBox.Text = manualCMD_TextBox.Text.Substring(0, pos)
        '    'manualCMD_TextBox.Text = manualCMD_TextBox.Text.Substring(0, manualCMD_TextBox.Text.LastIndexOf(" "))
        'End If
    End Sub

#End Region

End Class