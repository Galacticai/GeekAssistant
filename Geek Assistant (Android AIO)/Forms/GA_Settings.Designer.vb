<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GA_Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GA_Settings))
        Me.ResetGA_GroupBox = New System.Windows.Forms.GroupBox()
        Me.AutoClearLogs_SwitchButton = New System.Windows.Forms.Button()
        Me.OpenLogsFolder = New System.Windows.Forms.Label()
        Me.ResetGA = New System.Windows.Forms.Button()
        Me.ResetGA_LogsOnly_CheckBox = New System.Windows.Forms.CheckBox()
        Me.ResetGA_Settings_CheckBox_Label = New System.Windows.Forms.Label()
        Me.ResetGA_LogsOnly_CheckBox_Label = New System.Windows.Forms.Label()
        Me.ResetGA_SelectAll = New System.Windows.Forms.Button()
        Me.ResetGA_Settings_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PopupMessages_SwitchButton = New System.Windows.Forms.Button()
        Me.ShowToolTips_SwitchButton = New System.Windows.Forms.Button()
        Me.ToU_SwitchButton = New System.Windows.Forms.Button()
        Me.AppMode_SwitchButton = New System.Windows.Forms.Button()
        Me.VerbousLoggingPrompt_SwitchButton = New System.Windows.Forms.Button()
        Me.VerbousLogging_SwitchButton = New System.Windows.Forms.Button()
        Me.ButtonsBG_UI = New System.Windows.Forms.PictureBox()
        Me.PerformAnimation_SwitchButton = New System.Windows.Forms.Button()
        Me.SettingsIcon_PictureBox = New System.Windows.Forms.PictureBox()
        Me.SettingsTitle_Label = New System.Windows.Forms.Label()
        Me.GeekAssistant_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Thanks_Label = New System.Windows.Forms.Label()
        Me.ResetGA_GroupBox.SuspendLayout()
        CType(Me.ButtonsBG_UI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingsIcon_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeekAssistant_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ResetGA_GroupBox
        '
        Me.ResetGA_GroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ResetGA_GroupBox.Controls.Add(Me.AutoClearLogs_SwitchButton)
        Me.ResetGA_GroupBox.Controls.Add(Me.OpenLogsFolder)
        Me.ResetGA_GroupBox.Controls.Add(Me.ResetGA)
        Me.ResetGA_GroupBox.Controls.Add(Me.ResetGA_LogsOnly_CheckBox)
        Me.ResetGA_GroupBox.Controls.Add(Me.ResetGA_Settings_CheckBox_Label)
        Me.ResetGA_GroupBox.Controls.Add(Me.ResetGA_LogsOnly_CheckBox_Label)
        Me.ResetGA_GroupBox.Controls.Add(Me.ResetGA_SelectAll)
        Me.ResetGA_GroupBox.Controls.Add(Me.ResetGA_Settings_CheckBox)
        Me.ResetGA_GroupBox.Location = New System.Drawing.Point(247, 95)
        Me.ResetGA_GroupBox.Name = "ResetGA_GroupBox"
        Me.ResetGA_GroupBox.Size = New System.Drawing.Size(230, 240)
        Me.ResetGA_GroupBox.TabIndex = 85558
        Me.ResetGA_GroupBox.TabStop = False
        Me.ResetGA_GroupBox.Text = "Reset Geek Assistant"
        '
        'AutoClearLogs_SwitchButton
        '
        Me.AutoClearLogs_SwitchButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.AutoClearLogs_SwitchButton.FlatAppearance.BorderSize = 0
        Me.AutoClearLogs_SwitchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AutoClearLogs_SwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AutoClearLogs_SwitchButton.Location = New System.Drawing.Point(6, 156)
        Me.AutoClearLogs_SwitchButton.Name = "AutoClearLogs_SwitchButton"
        Me.AutoClearLogs_SwitchButton.Size = New System.Drawing.Size(218, 38)
        Me.AutoClearLogs_SwitchButton.TabIndex = 85564
        Me.AutoClearLogs_SwitchButton.Text = "Auto Clear Logs ( > 30 days)"
        Me.ToolTip.SetToolTip(Me.AutoClearLogs_SwitchButton, "Auto delete log files that are older than 30 days")
        Me.AutoClearLogs_SwitchButton.UseVisualStyleBackColor = False
        '
        'OpenLogsFolder
        '
        Me.OpenLogsFolder.BackColor = System.Drawing.Color.Transparent
        Me.OpenLogsFolder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OpenLogsFolder.Location = New System.Drawing.Point(141, 98)
        Me.OpenLogsFolder.Name = "OpenLogsFolder"
        Me.OpenLogsFolder.Size = New System.Drawing.Size(82, 17)
        Me.OpenLogsFolder.TabIndex = 85564
        Me.OpenLogsFolder.Text = "(Open folder)"
        Me.OpenLogsFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ResetGA
        '
        Me.ResetGA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ResetGA.FlatAppearance.BorderSize = 0
        Me.ResetGA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ResetGA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ResetGA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetGA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetGA.Image = Global.GeekAssistant.My.Resources.Resources.Clear_Data_50_24
        Me.ResetGA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ResetGA.Location = New System.Drawing.Point(39, 200)
        Me.ResetGA.Name = "ResetGA"
        Me.ResetGA.Size = New System.Drawing.Size(190, 38)
        Me.ResetGA.TabIndex = 3
        Me.ResetGA.Text = "⠀⠀⠀⠀⠀ &Reset G.A"
        Me.ResetGA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ResetGA.UseVisualStyleBackColor = False
        '
        'ResetGA_LogsOnly_CheckBox
        '
        Me.ResetGA_LogsOnly_CheckBox.AutoSize = True
        Me.ResetGA_LogsOnly_CheckBox.Location = New System.Drawing.Point(12, 99)
        Me.ResetGA_LogsOnly_CheckBox.Name = "ResetGA_LogsOnly_CheckBox"
        Me.ResetGA_LogsOnly_CheckBox.Size = New System.Drawing.Size(50, 17)
        Me.ResetGA_LogsOnly_CheckBox.TabIndex = 2
        Me.ResetGA_LogsOnly_CheckBox.Text = "&Logs"
        Me.ToolTip.SetToolTip(Me.ResetGA_LogsOnly_CheckBox, "Only logs folder & files ""%appdata%\Geek Assistant (Android)\logs""")
        Me.ResetGA_LogsOnly_CheckBox.UseVisualStyleBackColor = True
        '
        'ResetGA_Settings_CheckBox_Label
        '
        Me.ResetGA_Settings_CheckBox_Label.AutoSize = True
        Me.ResetGA_Settings_CheckBox_Label.BackColor = System.Drawing.Color.Transparent
        Me.ResetGA_Settings_CheckBox_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ResetGA_Settings_CheckBox_Label.Location = New System.Drawing.Point(12, 54)
        Me.ResetGA_Settings_CheckBox_Label.Name = "ResetGA_Settings_CheckBox_Label"
        Me.ResetGA_Settings_CheckBox_Label.Size = New System.Drawing.Size(179, 26)
        Me.ResetGA_Settings_CheckBox_Label.TabIndex = 85563
        Me.ResetGA_Settings_CheckBox_Label.Text = "Reset all values used internally by" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Geek Assistant"
        Me.ToolTip.SetToolTip(Me.ResetGA_Settings_CheckBox_Label, "Internal saved values (like device information and others)")
        '
        'ResetGA_LogsOnly_CheckBox_Label
        '
        Me.ResetGA_LogsOnly_CheckBox_Label.AutoSize = True
        Me.ResetGA_LogsOnly_CheckBox_Label.BackColor = System.Drawing.Color.Transparent
        Me.ResetGA_LogsOnly_CheckBox_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ResetGA_LogsOnly_CheckBox_Label.Location = New System.Drawing.Point(11, 121)
        Me.ResetGA_LogsOnly_CheckBox_Label.Name = "ResetGA_LogsOnly_CheckBox_Label"
        Me.ResetGA_LogsOnly_CheckBox_Label.Size = New System.Drawing.Size(202, 13)
        Me.ResetGA_LogsOnly_CheckBox_Label.TabIndex = 85563
        Me.ResetGA_LogsOnly_CheckBox_Label.Text = "Delete per-session saved logging files"
        Me.ToolTip.SetToolTip(Me.ResetGA_LogsOnly_CheckBox_Label, "Logs folder & files ""%appdata%\Geek Assistant (Android)\logs""")
        '
        'ResetGA_SelectAll
        '
        Me.ResetGA_SelectAll.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ResetGA_SelectAll.FlatAppearance.BorderSize = 0
        Me.ResetGA_SelectAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ResetGA_SelectAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ResetGA_SelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetGA_SelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetGA_SelectAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetGA_SelectAll.Image = Global.GeekAssistant.My.Resources.Resources.SelectAll_B_24
        Me.ResetGA_SelectAll.Location = New System.Drawing.Point(1, 200)
        Me.ResetGA_SelectAll.Name = "ResetGA_SelectAll"
        Me.ResetGA_SelectAll.Size = New System.Drawing.Size(36, 38)
        Me.ResetGA_SelectAll.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.ResetGA_SelectAll, "Tick / Untick all of the above")
        Me.ResetGA_SelectAll.UseVisualStyleBackColor = False
        '
        'ResetGA_Settings_CheckBox
        '
        Me.ResetGA_Settings_CheckBox.AutoSize = True
        Me.ResetGA_Settings_CheckBox.Location = New System.Drawing.Point(12, 32)
        Me.ResetGA_Settings_CheckBox.Name = "ResetGA_Settings_CheckBox"
        Me.ResetGA_Settings_CheckBox.Size = New System.Drawing.Size(93, 17)
        Me.ResetGA_Settings_CheckBox.TabIndex = 1
        Me.ResetGA_Settings_CheckBox.Text = "&Internal Data"
        Me.ToolTip.SetToolTip(Me.ResetGA_Settings_CheckBox, "Internal saved values (like device information and others)")
        Me.ResetGA_Settings_CheckBox.UseVisualStyleBackColor = True
        '
        'Close_Button
        '
        Me.Close_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_Button.FlatAppearance.BorderSize = 0
        Me.Close_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Close_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close_Button.Location = New System.Drawing.Point(386, 360)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(91, 30)
        Me.Close_Button.TabIndex = 6
        Me.Close_Button.Text = "Close"
        Me.Close_Button.UseVisualStyleBackColor = True
        '
        'ToolTip
        '
        Me.ToolTip.AutomaticDelay = 100
        Me.ToolTip.AutoPopDelay = 10000
        Me.ToolTip.InitialDelay = 100
        Me.ToolTip.ReshowDelay = 0
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip.ToolTipTitle = "Selected:"
        '
        'PopupMessages_SwitchButton
        '
        Me.PopupMessages_SwitchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PopupMessages_SwitchButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PopupMessages_SwitchButton.FlatAppearance.BorderSize = 0
        Me.PopupMessages_SwitchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PopupMessages_SwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PopupMessages_SwitchButton.Location = New System.Drawing.Point(24, 184)
        Me.PopupMessages_SwitchButton.Name = "PopupMessages_SwitchButton"
        Me.PopupMessages_SwitchButton.Size = New System.Drawing.Size(207, 32)
        Me.PopupMessages_SwitchButton.TabIndex = 4
        Me.PopupMessages_SwitchButton.Text = "Pop-up Messages"
        Me.ToolTip.SetToolTip(Me.PopupMessages_SwitchButton, "View a window for messages like errors and info... etc")
        Me.PopupMessages_SwitchButton.UseVisualStyleBackColor = False
        '
        'ShowToolTips_SwitchButton
        '
        Me.ShowToolTips_SwitchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ShowToolTips_SwitchButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ShowToolTips_SwitchButton.FlatAppearance.BorderSize = 0
        Me.ShowToolTips_SwitchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ShowToolTips_SwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowToolTips_SwitchButton.Location = New System.Drawing.Point(24, 262)
        Me.ShowToolTips_SwitchButton.Name = "ShowToolTips_SwitchButton"
        Me.ShowToolTips_SwitchButton.Size = New System.Drawing.Size(207, 32)
        Me.ShowToolTips_SwitchButton.TabIndex = 5
        Me.ShowToolTips_SwitchButton.Text = "Show Tooltips"
        Me.ToolTip.SetToolTip(Me.ShowToolTips_SwitchButton, "Show tooltips on various controls for clarification")
        Me.ShowToolTips_SwitchButton.UseVisualStyleBackColor = False
        '
        'ToU_SwitchButton
        '
        Me.ToU_SwitchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToU_SwitchButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToU_SwitchButton.FlatAppearance.BorderSize = 0
        Me.ToU_SwitchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToU_SwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToU_SwitchButton.Location = New System.Drawing.Point(24, 106)
        Me.ToU_SwitchButton.Name = "ToU_SwitchButton"
        Me.ToU_SwitchButton.Size = New System.Drawing.Size(207, 32)
        Me.ToU_SwitchButton.TabIndex = 85561
        Me.ToU_SwitchButton.Text = "Skip Terms of Use on startup"
        Me.ToolTip.SetToolTip(Me.ToU_SwitchButton, "View a window for messages like errors and info... etc")
        Me.ToU_SwitchButton.UseVisualStyleBackColor = False
        '
        'AppMode_SwitchButton
        '
        Me.AppMode_SwitchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AppMode_SwitchButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.AppMode_SwitchButton.FlatAppearance.BorderSize = 0
        Me.AppMode_SwitchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AppMode_SwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AppMode_SwitchButton.Location = New System.Drawing.Point(24, 145)
        Me.AppMode_SwitchButton.Name = "AppMode_SwitchButton"
        Me.AppMode_SwitchButton.Size = New System.Drawing.Size(207, 32)
        Me.AppMode_SwitchButton.TabIndex = 85562
        Me.AppMode_SwitchButton.Text = "Skip App Mode on startup"
        Me.ToolTip.SetToolTip(Me.AppMode_SwitchButton, "View a window for messages like errors and info... etc")
        Me.AppMode_SwitchButton.UseVisualStyleBackColor = False
        '
        'VerbousLoggingPrompt_SwitchButton
        '
        Me.VerbousLoggingPrompt_SwitchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.VerbousLoggingPrompt_SwitchButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.VerbousLoggingPrompt_SwitchButton.FlatAppearance.BorderSize = 0
        Me.VerbousLoggingPrompt_SwitchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VerbousLoggingPrompt_SwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerbousLoggingPrompt_SwitchButton.Location = New System.Drawing.Point(185, 223)
        Me.VerbousLoggingPrompt_SwitchButton.Name = "VerbousLoggingPrompt_SwitchButton"
        Me.VerbousLoggingPrompt_SwitchButton.Size = New System.Drawing.Size(46, 32)
        Me.VerbousLoggingPrompt_SwitchButton.TabIndex = 85563
        Me.VerbousLoggingPrompt_SwitchButton.Text = "(Ask)"
        Me.ToolTip.SetToolTip(Me.VerbousLoggingPrompt_SwitchButton, "Show tooltips on various controls for clarification")
        Me.VerbousLoggingPrompt_SwitchButton.UseVisualStyleBackColor = False
        '
        'VerbousLogging_SwitchButton
        '
        Me.VerbousLogging_SwitchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.VerbousLogging_SwitchButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.VerbousLogging_SwitchButton.FlatAppearance.BorderSize = 0
        Me.VerbousLogging_SwitchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VerbousLogging_SwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerbousLogging_SwitchButton.Location = New System.Drawing.Point(24, 223)
        Me.VerbousLogging_SwitchButton.Name = "VerbousLogging_SwitchButton"
        Me.VerbousLogging_SwitchButton.Size = New System.Drawing.Size(159, 32)
        Me.VerbousLogging_SwitchButton.TabIndex = 5
        Me.VerbousLogging_SwitchButton.Text = "Verbous Logging"
        Me.ToolTip.SetToolTip(Me.VerbousLogging_SwitchButton, "Show tooltips on various controls for clarification")
        Me.VerbousLogging_SwitchButton.UseVisualStyleBackColor = False
        '
        'ButtonsBG_UI
        '
        Me.ButtonsBG_UI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonsBG_UI.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonsBG_UI.Enabled = False
        Me.ButtonsBG_UI.Location = New System.Drawing.Point(-5, 349)
        Me.ButtonsBG_UI.Name = "ButtonsBG_UI"
        Me.ButtonsBG_UI.Size = New System.Drawing.Size(508, 54)
        Me.ButtonsBG_UI.TabIndex = 85560
        Me.ButtonsBG_UI.TabStop = False
        '
        'PerformAnimation_SwitchButton
        '
        Me.PerformAnimation_SwitchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PerformAnimation_SwitchButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PerformAnimation_SwitchButton.FlatAppearance.BorderSize = 0
        Me.PerformAnimation_SwitchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PerformAnimation_SwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PerformAnimation_SwitchButton.Location = New System.Drawing.Point(24, 303)
        Me.PerformAnimation_SwitchButton.Name = "PerformAnimation_SwitchButton"
        Me.PerformAnimation_SwitchButton.Size = New System.Drawing.Size(207, 32)
        Me.PerformAnimation_SwitchButton.TabIndex = 5
        Me.PerformAnimation_SwitchButton.Text = "Perform Animations"
        Me.PerformAnimation_SwitchButton.UseVisualStyleBackColor = False
        '
        'SettingsIcon_PictureBox
        '
        Me.SettingsIcon_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.SettingsIcon_PictureBox.Image = Global.GeekAssistant.My.Resources.Resources.Settings_64
        Me.SettingsIcon_PictureBox.Location = New System.Drawing.Point(24, 13)
        Me.SettingsIcon_PictureBox.Name = "SettingsIcon_PictureBox"
        Me.SettingsIcon_PictureBox.Size = New System.Drawing.Size(64, 64)
        Me.SettingsIcon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SettingsIcon_PictureBox.TabIndex = 85575
        Me.SettingsIcon_PictureBox.TabStop = False
        '
        'SettingsTitle_Label
        '
        Me.SettingsTitle_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SettingsTitle_Label.BackColor = System.Drawing.Color.Transparent
        Me.SettingsTitle_Label.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsTitle_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.SettingsTitle_Label.Location = New System.Drawing.Point(103, 13)
        Me.SettingsTitle_Label.Name = "SettingsTitle_Label"
        Me.SettingsTitle_Label.Size = New System.Drawing.Size(374, 45)
        Me.SettingsTitle_Label.TabIndex = 85576
        Me.SettingsTitle_Label.Text = "Settings"
        Me.SettingsTitle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GeekAssistant_PictureBox
        '
        Me.GeekAssistant_PictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GeekAssistant_PictureBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GeekAssistant_PictureBox.Image = Global.GeekAssistant.My.Resources.Resources.Geek_Assistant___50__alpha40
        Me.GeekAssistant_PictureBox.Location = New System.Drawing.Point(24, 360)
        Me.GeekAssistant_PictureBox.Name = "GeekAssistant_PictureBox"
        Me.GeekAssistant_PictureBox.Size = New System.Drawing.Size(150, 30)
        Me.GeekAssistant_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GeekAssistant_PictureBox.TabIndex = 85577
        Me.GeekAssistant_PictureBox.TabStop = False
        '
        'Thanks_Label
        '
        Me.Thanks_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Thanks_Label.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thanks_Label.Location = New System.Drawing.Point(107, 55)
        Me.Thanks_Label.Name = "Thanks_Label"
        Me.Thanks_Label.Size = New System.Drawing.Size(370, 20)
        Me.Thanks_Label.TabIndex = 85591
        Me.Thanks_Label.Text = "How do you want things to roll?"
        Me.Thanks_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GA_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(501, 400)
        Me.Controls.Add(Me.Thanks_Label)
        Me.Controls.Add(Me.GeekAssistant_PictureBox)
        Me.Controls.Add(Me.SettingsTitle_Label)
        Me.Controls.Add(Me.SettingsIcon_PictureBox)
        Me.Controls.Add(Me.VerbousLoggingPrompt_SwitchButton)
        Me.Controls.Add(Me.AppMode_SwitchButton)
        Me.Controls.Add(Me.ToU_SwitchButton)
        Me.Controls.Add(Me.PopupMessages_SwitchButton)
        Me.Controls.Add(Me.PerformAnimation_SwitchButton)
        Me.Controls.Add(Me.ShowToolTips_SwitchButton)
        Me.Controls.Add(Me.VerbousLogging_SwitchButton)
        Me.Controls.Add(Me.Close_Button)
        Me.Controls.Add(Me.ResetGA_GroupBox)
        Me.Controls.Add(Me.ButtonsBG_UI)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GA_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings — Geek Assistant"
        Me.ResetGA_GroupBox.ResumeLayout(False)
        Me.ResetGA_GroupBox.PerformLayout()
        CType(Me.ButtonsBG_UI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingsIcon_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeekAssistant_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ResetGA As Button
    Friend WithEvents ResetGA_GroupBox As GroupBox
    Friend WithEvents ResetGA_LogsOnly_CheckBox As CheckBox
    Friend WithEvents ResetGA_Settings_CheckBox As CheckBox
    Friend WithEvents Close_Button As Button
    Friend WithEvents ResetGA_SelectAll As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ButtonsBG_UI As PictureBox
    Friend WithEvents VerbousLogging_SwitchButton As Button
    Friend WithEvents PopupMessages_SwitchButton As Button
    Friend WithEvents ResetGA_Settings_CheckBox_Label As Label
    Friend WithEvents ResetGA_LogsOnly_CheckBox_Label As Label
    Friend WithEvents ShowToolTips_SwitchButton As Button
    Friend WithEvents ToU_SwitchButton As Button
    Friend WithEvents AppMode_SwitchButton As Button
    Friend WithEvents OpenLogsFolder As Label
    Friend WithEvents VerbousLoggingPrompt_SwitchButton As Button
    Friend WithEvents AutoClearLogs_SwitchButton As Button
    Friend WithEvents PerformAnimation_SwitchButton As Button
    Friend WithEvents SettingsIcon_PictureBox As PictureBox
    Friend WithEvents SettingsTitle_Label As Label
    Friend WithEvents GeekAssistant_PictureBox As PictureBox
    Friend WithEvents Thanks_Label As Label
End Class
