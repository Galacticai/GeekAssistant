Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    'Inherits MaterialSkin.Controls.MaterialForm
    Inherits System.Windows.Forms.Form
    Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.OpenLogFolder = New System.Windows.Forms.Button()
        Me.ShowLog_InfoBlink_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.PleaseWait_PostDelay_adbDetect = New System.Windows.Forms.Timer(Me.components)
        Me.FlashZip_OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ShowLog_ErrorBlink_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Unavalable_Tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ManualInfo_GroupBox = New System.Windows.Forms.GroupBox()
        Me.AndroidVersion_ComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.Manufacturer_ComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.Rooted_Checkbox = New System.Windows.Forms.CheckBox()
        Me.BootloaderUnlockable_CheckBox = New System.Windows.Forms.CheckBox()
        Me.CustomRecovery_CheckBox = New System.Windows.Forms.CheckBox()
        Me.CustomROM_CheckBox = New System.Windows.Forms.CheckBox()
        Me.DeviceState_Label = New System.Windows.Forms.Label()
        Me.DeviceStateTitle_Label = New System.Windows.Forms.Label()
        Me.AutoDetectFlash_Timer_Deprecated = New System.Windows.Forms.Timer(Me.components)
        Me.SettingsSave_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.FlashZip_Button = New MetroFramework.Controls.MetroButton()
        Me.About_Button = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Settings_Button = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Feedback_Button = New MaterialSkin.Controls.MaterialFlatButton()
        Me.FlashZip_RebootWhenComplete_Checkbox = New System.Windows.Forms.CheckBox()
        Me.AutoDetectDeviceInfo_Button = New System.Windows.Forms.Button()
        Me.ClearLog_Button = New System.Windows.Forms.Button()
        Me.FlashZip_Title = New System.Windows.Forms.Label()
        Me.CopyLogToClipboard = New System.Windows.Forms.Button()
        Me.FlashZip_ChooseFile_TextBox = New MetroFramework.Controls.MetroTextBox()
        Me.GeekAssistant = New System.Windows.Forms.PictureBox()
        Me.FlashZip_ChooseFile_Button = New System.Windows.Forms.Button()
        Me.ShowLog_Button = New MaterialSkin.Controls.MaterialFlatButton()
        Me.log = New System.Windows.Forms.TextBox()
        Me.Main_ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ProgressBarLabel = New MetroFramework.Controls.MetroLabel()
        Me.ProgressBar = New MetroFramework.Controls.MetroProgressBar()
        Me.SwitchTheme_Button = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Donate_Button = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MainLayout_PictureBox = New System.Windows.Forms.PictureBox()
        Me.manualCMD_TextBox = New MetroFramework.Controls.MetroTextBox()
        Me.ProgressFakeBG_UI = New System.Windows.Forms.PictureBox()
        Me.Main_Tabs = New MetroFramework.Controls.MetroTabControl()
        Me.PrepareYourDevice_Tab = New MetroFramework.Controls.MetroTabPage()
        Me.UnlockBL_Label = New MetroFramework.Controls.MetroLabel()
        Me.MagiskRoot_Label = New MetroFramework.Controls.MetroLabel()
        Me.MagiskRoot_PictureBox = New System.Windows.Forms.PictureBox()
        Me.UnlockBL_PictureBox = New System.Windows.Forms.PictureBox()
        Me.MagiskRoot_Title = New System.Windows.Forms.Label()
        Me.UnlockBL_Title = New System.Windows.Forms.Label()
        Me.MagiskRoot_Button = New MetroFramework.Controls.MetroButton()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.UnlockBL_ProgressBar = New MaterialSkin.Controls.MaterialProgressBar()
        Me.UnlockBL_Button = New MetroFramework.Controls.MetroButton()
        Me.MagiskRoot_ProgressBar = New MaterialSkin.Controls.MaterialProgressBar()
        Me.FlashZip_Tab = New MetroFramework.Controls.MetroTabPage()
        Me.FlashZip_ProgressBar = New MaterialSkin.Controls.MaterialProgressBar()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MoreTools_Tab = New MetroFramework.Controls.MetroTabPage()
        Me.GA_About_Label = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.SwitchTheme_Back_UI = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SwitchTheme_Mid_UI = New System.Windows.Forms.PictureBox()
        Me.SwitchTheme_Fore_UI = New System.Windows.Forms.PictureBox()
        Me.ManualInfo_GroupBox.SuspendLayout()
        CType(Me.GeekAssistant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainLayout_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressFakeBG_UI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Main_Tabs.SuspendLayout()
        Me.PrepareYourDevice_Tab.SuspendLayout()
        CType(Me.MagiskRoot_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnlockBL_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlashZip_Tab.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwitchTheme_Back_UI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwitchTheme_Mid_UI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwitchTheme_Fore_UI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenLogFolder
        '
        Me.OpenLogFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenLogFolder.BackColor = System.Drawing.Color.Transparent
        Me.OpenLogFolder.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OpenLogFolder.FlatAppearance.BorderSize = 0
        Me.OpenLogFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.OpenLogFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.OpenLogFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpenLogFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenLogFolder.Image = Global.GeekAssistant.My.Resources.Resources.OpenFolder_B_24
        Me.OpenLogFolder.Location = New System.Drawing.Point(1078, 553)
        Me.OpenLogFolder.Name = "OpenLogFolder"
        Me.OpenLogFolder.Size = New System.Drawing.Size(28, 27)
        Me.OpenLogFolder.TabIndex = 85598
        Me.Main_ToolTip.SetToolTip(Me.OpenLogFolder, "Open logs folder")
        Me.OpenLogFolder.UseVisualStyleBackColor = False
        '
        'ShowLog_InfoBlink_Timer
        '
        Me.ShowLog_InfoBlink_Timer.Interval = 700
        '
        'PleaseWait_PostDelay_adbDetect
        '
        Me.PleaseWait_PostDelay_adbDetect.Interval = 200
        '
        'FlashZip_OpenFileDialog
        '
        Me.FlashZip_OpenFileDialog.DefaultExt = "zip"
        Me.FlashZip_OpenFileDialog.Filter = "Zip files|*.zip"
        '
        'ShowLog_ErrorBlink_Timer
        '
        Me.ShowLog_ErrorBlink_Timer.Interval = 700
        '
        'Unavalable_Tooltip
        '
        Me.Unavalable_Tooltip.AutomaticDelay = 0
        Me.Unavalable_Tooltip.AutoPopDelay = 10000
        Me.Unavalable_Tooltip.InitialDelay = 0
        Me.Unavalable_Tooltip.ReshowDelay = 0
        Me.Unavalable_Tooltip.StripAmpersands = True
        Me.Unavalable_Tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        '
        'ManualInfo_GroupBox
        '
        Me.ManualInfo_GroupBox.BackColor = System.Drawing.Color.Transparent
        Me.ManualInfo_GroupBox.Controls.Add(Me.AndroidVersion_ComboBox)
        Me.ManualInfo_GroupBox.Controls.Add(Me.Manufacturer_ComboBox)
        Me.ManualInfo_GroupBox.Controls.Add(Me.Rooted_Checkbox)
        Me.ManualInfo_GroupBox.Controls.Add(Me.BootloaderUnlockable_CheckBox)
        Me.ManualInfo_GroupBox.Controls.Add(Me.CustomRecovery_CheckBox)
        Me.ManualInfo_GroupBox.Controls.Add(Me.CustomROM_CheckBox)
        Me.ManualInfo_GroupBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ManualInfo_GroupBox.Location = New System.Drawing.Point(24, 242)
        Me.ManualInfo_GroupBox.Name = "ManualInfo_GroupBox"
        Me.ManualInfo_GroupBox.Size = New System.Drawing.Size(243, 270)
        Me.ManualInfo_GroupBox.TabIndex = 85591
        Me.ManualInfo_GroupBox.TabStop = False
        Me.ManualInfo_GroupBox.Text = "Manual Device Information"
        '
        'AndroidVersion_ComboBox
        '
        Me.AndroidVersion_ComboBox.FormattingEnabled = True
        Me.AndroidVersion_ComboBox.ItemHeight = 23
        Me.AndroidVersion_ComboBox.Items.AddRange(New Object() {"Android 11 R (And Above)", "Android 10 Q", "Pie 9.x", "Oreo 8.x", "Nougat 7.x", "Marshmallow 6.x", "Lollipop 5.x", "KitKat 4.4 (And Below)"})
        Me.AndroidVersion_ComboBox.Location = New System.Drawing.Point(20, 92)
        Me.AndroidVersion_ComboBox.Name = "AndroidVersion_ComboBox"
        Me.AndroidVersion_ComboBox.PromptText = "Select Android Version"
        Me.AndroidVersion_ComboBox.Size = New System.Drawing.Size(199, 29)
        Me.AndroidVersion_ComboBox.Style = MetroFramework.MetroColorStyle.Green
        Me.AndroidVersion_ComboBox.TabIndex = 85596
        Me.AndroidVersion_ComboBox.UseCustomForeColor = True
        Me.AndroidVersion_ComboBox.UseSelectable = True
        '
        'Manufacturer_ComboBox
        '
        Me.Manufacturer_ComboBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Manufacturer_ComboBox.FormattingEnabled = True
        Me.Manufacturer_ComboBox.ItemHeight = 23
        Me.Manufacturer_ComboBox.Items.AddRange(New Object() {"Google", "OnePlus", "Samsung", "Xiaomi", "Huawei", "Nokia", "LG"})
        Me.Manufacturer_ComboBox.Location = New System.Drawing.Point(20, 48)
        Me.Manufacturer_ComboBox.Name = "Manufacturer_ComboBox"
        Me.Manufacturer_ComboBox.PromptText = "*Select Manufacturer"
        Me.Manufacturer_ComboBox.Size = New System.Drawing.Size(199, 29)
        Me.Manufacturer_ComboBox.Style = MetroFramework.MetroColorStyle.Green
        Me.Manufacturer_ComboBox.TabIndex = 85595
        Me.Manufacturer_ComboBox.Tag = ""
        Me.Manufacturer_ComboBox.UseCustomForeColor = True
        Me.Manufacturer_ComboBox.UseSelectable = True
        '
        'Rooted_Checkbox
        '
        Me.Rooted_Checkbox.AutoSize = True
        Me.Rooted_Checkbox.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Rooted_Checkbox.Location = New System.Drawing.Point(20, 173)
        Me.Rooted_Checkbox.Name = "Rooted_Checkbox"
        Me.Rooted_Checkbox.Size = New System.Drawing.Size(70, 21)
        Me.Rooted_Checkbox.TabIndex = 85597
        Me.Rooted_Checkbox.Text = "Rooted"
        '
        'BootloaderUnlockable_CheckBox
        '
        Me.BootloaderUnlockable_CheckBox.AutoSize = True
        Me.BootloaderUnlockable_CheckBox.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BootloaderUnlockable_CheckBox.Location = New System.Drawing.Point(20, 146)
        Me.BootloaderUnlockable_CheckBox.Name = "BootloaderUnlockable_CheckBox"
        Me.BootloaderUnlockable_CheckBox.Size = New System.Drawing.Size(158, 21)
        Me.BootloaderUnlockable_CheckBox.TabIndex = 85597
        Me.BootloaderUnlockable_CheckBox.Text = "Bootloader unlockable"
        '
        'CustomRecovery_CheckBox
        '
        Me.CustomRecovery_CheckBox.AutoSize = True
        Me.CustomRecovery_CheckBox.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.CustomRecovery_CheckBox.Location = New System.Drawing.Point(20, 227)
        Me.CustomRecovery_CheckBox.Name = "CustomRecovery_CheckBox"
        Me.CustomRecovery_CheckBox.Size = New System.Drawing.Size(137, 21)
        Me.CustomRecovery_CheckBox.TabIndex = 85598
        Me.CustomRecovery_CheckBox.Text = "* Custom Recovery"
        Me.Unavalable_Tooltip.SetToolTip(Me.CustomRecovery_CheckBox, "Still in development...")
        '
        'CustomROM_CheckBox
        '
        Me.CustomROM_CheckBox.AutoSize = True
        Me.CustomROM_CheckBox.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.CustomROM_CheckBox.Location = New System.Drawing.Point(20, 200)
        Me.CustomROM_CheckBox.Name = "CustomROM_CheckBox"
        Me.CustomROM_CheckBox.Size = New System.Drawing.Size(114, 21)
        Me.CustomROM_CheckBox.TabIndex = 85599
        Me.CustomROM_CheckBox.Text = "* Custom ROM"
        Me.Unavalable_Tooltip.SetToolTip(Me.CustomROM_CheckBox, "Still in development...")
        '
        'DeviceState_Label
        '
        Me.DeviceState_Label.AutoSize = True
        Me.DeviceState_Label.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DeviceState_Label.ForeColor = System.Drawing.Color.Gray
        Me.DeviceState_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeviceState_Label.Location = New System.Drawing.Point(120, 206)
        Me.DeviceState_Label.Name = "DeviceState_Label"
        Me.DeviceState_Label.Size = New System.Drawing.Size(86, 17)
        Me.DeviceState_Label.TabIndex = 85597
        Me.DeviceState_Label.Text = "Disconnected"
        '
        'DeviceStateTitle_Label
        '
        Me.DeviceStateTitle_Label.AutoSize = True
        Me.DeviceStateTitle_Label.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeviceStateTitle_Label.Location = New System.Drawing.Point(41, 206)
        Me.DeviceStateTitle_Label.Name = "DeviceStateTitle_Label"
        Me.DeviceStateTitle_Label.Size = New System.Drawing.Size(82, 17)
        Me.DeviceStateTitle_Label.TabIndex = 85594
        Me.DeviceStateTitle_Label.Text = "Device State:"
        '
        'AutoDetectFlash_Timer_Deprecated
        '
        Me.AutoDetectFlash_Timer_Deprecated.Interval = 650
        '
        'SettingsSave_Timer
        '
        Me.SettingsSave_Timer.Interval = 1000
        '
        'FlashZip_Button
        '
        Me.FlashZip_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlashZip_Button.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.FlashZip_Button.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.FlashZip_Button.Highlight = True
        Me.FlashZip_Button.Location = New System.Drawing.Point(10, 137)
        Me.FlashZip_Button.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.FlashZip_Button.Name = "FlashZip_Button"
        Me.FlashZip_Button.Size = New System.Drawing.Size(160, 36)
        Me.FlashZip_Button.Style = MetroFramework.MetroColorStyle.Green
        Me.FlashZip_Button.TabIndex = 85583
        Me.FlashZip_Button.Text = "Start Flashing"
        Me.FlashZip_Button.UseSelectable = True
        '
        'About_Button
        '
        Me.About_Button.AutoSize = True
        Me.About_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.About_Button.BackColor = System.Drawing.Color.Transparent
        Me.About_Button.Depth = 0
        Me.About_Button.FlatAppearance.BorderSize = 0
        Me.About_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.About_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.About_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.About_Button.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.About_Button.Icon = Global.GeekAssistant.My.Resources.Resources.ToU_24
        Me.About_Button.Location = New System.Drawing.Point(518, 30)
        Me.About_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.About_Button.MouseState = MaterialSkin.MouseState.HOVER
        Me.About_Button.Name = "About_Button"
        Me.About_Button.Primary = True
        Me.About_Button.Size = New System.Drawing.Size(44, 36)
        Me.About_Button.TabIndex = 85587
        Me.Main_ToolTip.SetToolTip(Me.About_Button, "Terms of Use")
        Me.About_Button.UseVisualStyleBackColor = False
        '
        'Settings_Button
        '
        Me.Settings_Button.AutoSize = True
        Me.Settings_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Settings_Button.BackColor = System.Drawing.Color.Transparent
        Me.Settings_Button.Depth = 0
        Me.Settings_Button.FlatAppearance.BorderSize = 0
        Me.Settings_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Settings_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Settings_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Settings_Button.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Settings_Button.Icon = Global.GeekAssistant.My.Resources.Resources.Settings_24
        Me.Settings_Button.Location = New System.Drawing.Point(562, 30)
        Me.Settings_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.Settings_Button.MouseState = MaterialSkin.MouseState.HOVER
        Me.Settings_Button.Name = "Settings_Button"
        Me.Settings_Button.Primary = True
        Me.Settings_Button.Size = New System.Drawing.Size(44, 36)
        Me.Settings_Button.TabIndex = 85588
        Me.Settings_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Main_ToolTip.SetToolTip(Me.Settings_Button, "Settings")
        Me.Settings_Button.UseVisualStyleBackColor = False
        '
        'Feedback_Button
        '
        Me.Feedback_Button.AutoSize = True
        Me.Feedback_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Feedback_Button.BackColor = System.Drawing.Color.Transparent
        Me.Feedback_Button.Depth = 0
        Me.Feedback_Button.FlatAppearance.BorderSize = 0
        Me.Feedback_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Feedback_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Feedback_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Feedback_Button.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Feedback_Button.Icon = Global.GeekAssistant.My.Resources.Resources.Smile_24
        Me.Feedback_Button.Location = New System.Drawing.Point(474, 30)
        Me.Feedback_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.Feedback_Button.MouseState = MaterialSkin.MouseState.HOVER
        Me.Feedback_Button.Name = "Feedback_Button"
        Me.Feedback_Button.Primary = True
        Me.Feedback_Button.Size = New System.Drawing.Size(44, 36)
        Me.Feedback_Button.TabIndex = 85589
        Me.Feedback_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Main_ToolTip.SetToolTip(Me.Feedback_Button, "Feedback")
        Me.Feedback_Button.UseVisualStyleBackColor = False
        '
        'FlashZip_RebootWhenComplete_Checkbox
        '
        Me.FlashZip_RebootWhenComplete_Checkbox.AutoSize = True
        Me.FlashZip_RebootWhenComplete_Checkbox.BackColor = System.Drawing.Color.Transparent
        Me.FlashZip_RebootWhenComplete_Checkbox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlashZip_RebootWhenComplete_Checkbox.Location = New System.Drawing.Point(49, 99)
        Me.FlashZip_RebootWhenComplete_Checkbox.Name = "FlashZip_RebootWhenComplete_Checkbox"
        Me.FlashZip_RebootWhenComplete_Checkbox.Size = New System.Drawing.Size(149, 19)
        Me.FlashZip_RebootWhenComplete_Checkbox.TabIndex = 85581
        Me.FlashZip_RebootWhenComplete_Checkbox.Text = "Reboot when complete"
        Me.FlashZip_RebootWhenComplete_Checkbox.UseVisualStyleBackColor = False
        '
        'AutoDetectDeviceInfo_Button
        '
        Me.AutoDetectDeviceInfo_Button.BackColor = System.Drawing.Color.Honeydew
        Me.AutoDetectDeviceInfo_Button.BackgroundImage = Global.GeekAssistant.My.Resources.Resources.LightBlue_Up_Gradient
        Me.AutoDetectDeviceInfo_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AutoDetectDeviceInfo_Button.FlatAppearance.BorderSize = 0
        Me.AutoDetectDeviceInfo_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AutoDetectDeviceInfo_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AutoDetectDeviceInfo_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AutoDetectDeviceInfo_Button.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AutoDetectDeviceInfo_Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.AutoDetectDeviceInfo_Button.Image = CType(resources.GetObject("AutoDetectDeviceInfo_Button.Image"), System.Drawing.Image)
        Me.AutoDetectDeviceInfo_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AutoDetectDeviceInfo_Button.Location = New System.Drawing.Point(24, 122)
        Me.AutoDetectDeviceInfo_Button.Name = "AutoDetectDeviceInfo_Button"
        Me.AutoDetectDeviceInfo_Button.Size = New System.Drawing.Size(243, 63)
        Me.AutoDetectDeviceInfo_Button.TabIndex = 85574
        Me.AutoDetectDeviceInfo_Button.Text = "Automatic &Detection   "
        Me.AutoDetectDeviceInfo_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Main_ToolTip.SetToolTip(Me.AutoDetectDeviceInfo_Button, " ")
        Me.AutoDetectDeviceInfo_Button.UseVisualStyleBackColor = False
        '
        'ClearLog_Button
        '
        Me.ClearLog_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearLog_Button.BackColor = System.Drawing.Color.Transparent
        Me.ClearLog_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearLog_Button.FlatAppearance.BorderSize = 0
        Me.ClearLog_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.ClearLog_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ClearLog_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearLog_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearLog_Button.Image = Global.GeekAssistant.My.Resources.Resources.Backspace_B_24
        Me.ClearLog_Button.Location = New System.Drawing.Point(1134, 553)
        Me.ClearLog_Button.Name = "ClearLog_Button"
        Me.ClearLog_Button.Size = New System.Drawing.Size(28, 27)
        Me.ClearLog_Button.TabIndex = 85596
        Me.Main_ToolTip.SetToolTip(Me.ClearLog_Button, "Clear log")
        Me.ClearLog_Button.UseVisualStyleBackColor = False
        '
        'FlashZip_Title
        '
        Me.FlashZip_Title.AutoSize = True
        Me.FlashZip_Title.BackColor = System.Drawing.Color.Transparent
        Me.FlashZip_Title.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlashZip_Title.Location = New System.Drawing.Point(45, 19)
        Me.FlashZip_Title.Name = "FlashZip_Title"
        Me.FlashZip_Title.Size = New System.Drawing.Size(178, 21)
        Me.FlashZip_Title.TabIndex = 85575
        Me.FlashZip_Title.Text = "Choose a zip file to flash"
        '
        'CopyLogToClipboard
        '
        Me.CopyLogToClipboard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CopyLogToClipboard.BackColor = System.Drawing.Color.Transparent
        Me.CopyLogToClipboard.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CopyLogToClipboard.FlatAppearance.BorderSize = 0
        Me.CopyLogToClipboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.CopyLogToClipboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.CopyLogToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CopyLogToClipboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyLogToClipboard.Image = Global.GeekAssistant.My.Resources.Resources.Copy_B_24
        Me.CopyLogToClipboard.Location = New System.Drawing.Point(1106, 553)
        Me.CopyLogToClipboard.Name = "CopyLogToClipboard"
        Me.CopyLogToClipboard.Size = New System.Drawing.Size(28, 27)
        Me.CopyLogToClipboard.TabIndex = 85597
        Me.Main_ToolTip.SetToolTip(Me.CopyLogToClipboard, "Copy log to clipboard")
        Me.CopyLogToClipboard.UseVisualStyleBackColor = False
        '
        'FlashZip_ChooseFile_TextBox
        '
        Me.FlashZip_ChooseFile_TextBox.BackColor = System.Drawing.SystemColors.ButtonFace
        '
        '
        '
        Me.FlashZip_ChooseFile_TextBox.CustomButton.Image = Nothing
        Me.FlashZip_ChooseFile_TextBox.CustomButton.Location = New System.Drawing.Point(196, 1)
        Me.FlashZip_ChooseFile_TextBox.CustomButton.Name = ""
        Me.FlashZip_ChooseFile_TextBox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.FlashZip_ChooseFile_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Green
        Me.FlashZip_ChooseFile_TextBox.CustomButton.TabIndex = 1
        Me.FlashZip_ChooseFile_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.FlashZip_ChooseFile_TextBox.CustomButton.UseSelectable = True
        Me.FlashZip_ChooseFile_TextBox.CustomButton.Visible = False
        Me.FlashZip_ChooseFile_TextBox.DisplayIcon = True
        Me.FlashZip_ChooseFile_TextBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.FlashZip_ChooseFile_TextBox.Lines = New String(-1) {}
        Me.FlashZip_ChooseFile_TextBox.Location = New System.Drawing.Point(49, 56)
        Me.FlashZip_ChooseFile_TextBox.MaxLength = 32767
        Me.FlashZip_ChooseFile_TextBox.Name = "FlashZip_ChooseFile_TextBox"
        Me.FlashZip_ChooseFile_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FlashZip_ChooseFile_TextBox.PromptText = "Double Click... or click this ---->"
        Me.FlashZip_ChooseFile_TextBox.ReadOnly = True
        Me.FlashZip_ChooseFile_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.FlashZip_ChooseFile_TextBox.SelectedText = ""
        Me.FlashZip_ChooseFile_TextBox.SelectionLength = 0
        Me.FlashZip_ChooseFile_TextBox.SelectionStart = 0
        Me.FlashZip_ChooseFile_TextBox.ShortcutsEnabled = True
        Me.FlashZip_ChooseFile_TextBox.Size = New System.Drawing.Size(222, 27)
        Me.FlashZip_ChooseFile_TextBox.TabIndex = 85573
        Me.FlashZip_ChooseFile_TextBox.UseSelectable = True
        Me.FlashZip_ChooseFile_TextBox.WaterMark = "Double Click... or click this ---->"
        Me.FlashZip_ChooseFile_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlashZip_ChooseFile_TextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'GeekAssistant
        '
        Me.GeekAssistant.BackColor = System.Drawing.Color.Transparent
        Me.GeekAssistant.Image = Global.GeekAssistant.My.Resources.Resources.Geek_Assistant
        Me.GeekAssistant.Location = New System.Drawing.Point(112, 22)
        Me.GeekAssistant.Name = "GeekAssistant"
        Me.GeekAssistant.Size = New System.Drawing.Size(294, 52)
        Me.GeekAssistant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GeekAssistant.TabIndex = 85593
        Me.GeekAssistant.TabStop = False
        '
        'FlashZip_ChooseFile_Button
        '
        Me.FlashZip_ChooseFile_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlashZip_ChooseFile_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.FlashZip_ChooseFile_Button.FlatAppearance.BorderSize = 0
        Me.FlashZip_ChooseFile_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FlashZip_ChooseFile_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FlashZip_ChooseFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FlashZip_ChooseFile_Button.Image = Global.GeekAssistant.My.Resources.Resources.OpenFile_24_noBG
        Me.FlashZip_ChooseFile_Button.Location = New System.Drawing.Point(269, 56)
        Me.FlashZip_ChooseFile_Button.Name = "FlashZip_ChooseFile_Button"
        Me.FlashZip_ChooseFile_Button.Size = New System.Drawing.Size(29, 27)
        Me.FlashZip_ChooseFile_Button.TabIndex = 85580
        Me.FlashZip_ChooseFile_Button.UseVisualStyleBackColor = False
        '
        'ShowLog_Button
        '
        Me.ShowLog_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ShowLog_Button.AutoSize = True
        Me.ShowLog_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ShowLog_Button.Depth = 0
        Me.ShowLog_Button.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ShowLog_Button.FlatAppearance.BorderSize = 0
        Me.ShowLog_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.ShowLog_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ShowLog_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowLog_Button.Icon = Global.GeekAssistant.My.Resources.Resources.Commands_24
        Me.ShowLog_Button.Location = New System.Drawing.Point(600, 544)
        Me.ShowLog_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.ShowLog_Button.MouseState = MaterialSkin.MouseState.HOVER
        Me.ShowLog_Button.Name = "ShowLog_Button"
        Me.ShowLog_Button.Primary = False
        Me.ShowLog_Button.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowLog_Button.Size = New System.Drawing.Size(44, 36)
        Me.ShowLog_Button.TabIndex = 85585
        Me.ShowLog_Button.Tag = " "
        Me.Main_ToolTip.SetToolTip(Me.ShowLog_Button, "Show/Hide log")
        Me.ShowLog_Button.UseVisualStyleBackColor = True
        '
        'log
        '
        Me.log.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.log.BackColor = System.Drawing.Color.White
        Me.log.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.log.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.log.ForeColor = System.Drawing.SystemColors.ControlText
        Me.log.Location = New System.Drawing.Point(683, 22)
        Me.log.Margin = New System.Windows.Forms.Padding(5)
        Me.log.MaxLength = 69000
        Me.log.Multiline = True
        Me.log.Name = "log"
        Me.log.ReadOnly = True
        Me.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.log.Size = New System.Drawing.Size(508, 525)
        Me.log.TabIndex = 85590
        Me.log.Text = "Geek Assistant vX.x #Phase ©2021 By NHKomaiha." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "// hh:mm:ss.ff // Start //"
        '
        'Main_ToolTip
        '
        Me.Main_ToolTip.AutomaticDelay = 1000
        Me.Main_ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'ProgressBarLabel
        '
        Me.ProgressBarLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.ProgressBarLabel.Location = New System.Drawing.Point(38, 544)
        Me.ProgressBarLabel.Name = "ProgressBarLabel"
        Me.ProgressBarLabel.Size = New System.Drawing.Size(562, 36)
        Me.ProgressBarLabel.Style = MetroFramework.MetroColorStyle.Green
        Me.ProgressBarLabel.TabIndex = 85610
        Me.ProgressBarLabel.Text = "Current process information will be written here. Click for more information >>"
        Me.ProgressBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Main_ToolTip.SetToolTip(Me.ProgressBarLabel, "Click to show/hide log")
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(24, 538)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(626, 48)
        Me.ProgressBar.Style = MetroFramework.MetroColorStyle.Green
        Me.ProgressBar.TabIndex = 85612
        Me.ProgressBar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Main_ToolTip.SetToolTip(Me.ProgressBar, "Click to show/hide log")
        '
        'SwitchTheme_Button
        '
        Me.SwitchTheme_Button.AutoSize = True
        Me.SwitchTheme_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SwitchTheme_Button.BackColor = System.Drawing.Color.Transparent
        Me.SwitchTheme_Button.Depth = 0
        Me.SwitchTheme_Button.FlatAppearance.BorderSize = 0
        Me.SwitchTheme_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SwitchTheme_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.SwitchTheme_Button.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SwitchTheme_Button.Icon = Global.GeekAssistant.My.Resources.Resources.Theme_Light_24
        Me.SwitchTheme_Button.Location = New System.Drawing.Point(430, 30)
        Me.SwitchTheme_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.SwitchTheme_Button.MouseState = MaterialSkin.MouseState.HOVER
        Me.SwitchTheme_Button.Name = "SwitchTheme_Button"
        Me.SwitchTheme_Button.Primary = False
        Me.SwitchTheme_Button.Size = New System.Drawing.Size(44, 36)
        Me.SwitchTheme_Button.TabIndex = 85589
        Me.SwitchTheme_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Main_ToolTip.SetToolTip(Me.SwitchTheme_Button, "Switch Theme")
        Me.SwitchTheme_Button.UseVisualStyleBackColor = False
        '
        'Donate_Button
        '
        Me.Donate_Button.AutoSize = True
        Me.Donate_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Donate_Button.BackColor = System.Drawing.Color.Transparent
        Me.Donate_Button.Depth = 0
        Me.Donate_Button.FlatAppearance.BorderSize = 0
        Me.Donate_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Donate_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Donate_Button.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Donate_Button.Icon = Global.GeekAssistant.My.Resources.Resources.DonateHeart_24
        Me.Donate_Button.Location = New System.Drawing.Point(606, 30)
        Me.Donate_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.Donate_Button.MouseState = MaterialSkin.MouseState.HOVER
        Me.Donate_Button.Name = "Donate_Button"
        Me.Donate_Button.Primary = False
        Me.Donate_Button.Size = New System.Drawing.Size(44, 36)
        Me.Donate_Button.TabIndex = 85618
        Me.Donate_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Main_ToolTip.SetToolTip(Me.Donate_Button, "Support the developer")
        Me.Donate_Button.UseVisualStyleBackColor = False
        '
        'MainLayout_PictureBox
        '
        Me.MainLayout_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.MainLayout_PictureBox.Image = Global.GeekAssistant.My.Resources.Resources.Layout_3DLine_toRight
        Me.MainLayout_PictureBox.Location = New System.Drawing.Point(673, 12)
        Me.MainLayout_PictureBox.Name = "MainLayout_PictureBox"
        Me.MainLayout_PictureBox.Size = New System.Drawing.Size(10, 574)
        Me.MainLayout_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MainLayout_PictureBox.TabIndex = 85599
        Me.MainLayout_PictureBox.TabStop = False
        '
        'manualCMD_TextBox
        '
        Me.manualCMD_TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.manualCMD_TextBox.CustomButton.Image = Nothing
        Me.manualCMD_TextBox.CustomButton.Location = New System.Drawing.Point(369, 1)
        Me.manualCMD_TextBox.CustomButton.Name = ""
        Me.manualCMD_TextBox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.manualCMD_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Green
        Me.manualCMD_TextBox.CustomButton.TabIndex = 1
        Me.manualCMD_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.manualCMD_TextBox.CustomButton.UseSelectable = True
        Me.manualCMD_TextBox.CustomButton.Visible = False
        Me.manualCMD_TextBox.DisplayIcon = True
        Me.manualCMD_TextBox.Icon = Global.GeekAssistant.My.Resources.Resources.Commands_16
        Me.manualCMD_TextBox.Lines = New String(-1) {}
        Me.manualCMD_TextBox.Location = New System.Drawing.Point(683, 553)
        Me.manualCMD_TextBox.MaxLength = 32767
        Me.manualCMD_TextBox.Name = "manualCMD_TextBox"
        Me.manualCMD_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.manualCMD_TextBox.PromptText = "Type your own adb or fastboot command here"
        Me.manualCMD_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.manualCMD_TextBox.SelectedText = ""
        Me.manualCMD_TextBox.SelectionLength = 0
        Me.manualCMD_TextBox.SelectionStart = 0
        Me.manualCMD_TextBox.ShortcutsEnabled = True
        Me.manualCMD_TextBox.Size = New System.Drawing.Size(395, 27)
        Me.manualCMD_TextBox.Style = MetroFramework.MetroColorStyle.Green
        Me.manualCMD_TextBox.TabIndex = 85601
        Me.manualCMD_TextBox.Tag = "text"
        Me.manualCMD_TextBox.UseSelectable = True
        Me.manualCMD_TextBox.WaterMark = "Type your own adb or fastboot command here"
        Me.manualCMD_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.manualCMD_TextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ProgressFakeBG_UI
        '
        Me.ProgressFakeBG_UI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProgressFakeBG_UI.Location = New System.Drawing.Point(29, 544)
        Me.ProgressFakeBG_UI.Name = "ProgressFakeBG_UI"
        Me.ProgressFakeBG_UI.Size = New System.Drawing.Size(615, 36)
        Me.ProgressFakeBG_UI.TabIndex = 85606
        Me.ProgressFakeBG_UI.TabStop = False
        '
        'Main_Tabs
        '
        Me.Main_Tabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.Main_Tabs.Controls.Add(Me.PrepareYourDevice_Tab)
        Me.Main_Tabs.Controls.Add(Me.FlashZip_Tab)
        Me.Main_Tabs.Controls.Add(Me.MoreTools_Tab)
        Me.Main_Tabs.Location = New System.Drawing.Point(273, 117)
        Me.Main_Tabs.Name = "Main_Tabs"
        Me.Main_Tabs.SelectedIndex = 0
        Me.Main_Tabs.Size = New System.Drawing.Size(377, 401)
        Me.Main_Tabs.Style = MetroFramework.MetroColorStyle.Green
        Me.Main_Tabs.TabIndex = 85609
        Me.Main_Tabs.UseSelectable = True
        '
        'PrepareYourDevice_Tab
        '
        Me.PrepareYourDevice_Tab.BackColor = System.Drawing.Color.White
        Me.PrepareYourDevice_Tab.Controls.Add(Me.UnlockBL_Label)
        Me.PrepareYourDevice_Tab.Controls.Add(Me.MagiskRoot_Label)
        Me.PrepareYourDevice_Tab.Controls.Add(Me.MagiskRoot_PictureBox)
        Me.PrepareYourDevice_Tab.Controls.Add(Me.UnlockBL_PictureBox)
        Me.PrepareYourDevice_Tab.Controls.Add(Me.MagiskRoot_Title)
        Me.PrepareYourDevice_Tab.Controls.Add(Me.UnlockBL_Title)
        Me.PrepareYourDevice_Tab.Controls.Add(Me.MagiskRoot_Button)
        Me.PrepareYourDevice_Tab.Controls.Add(Me.MaterialDivider1)
        Me.PrepareYourDevice_Tab.Controls.Add(Me.UnlockBL_ProgressBar)
        Me.PrepareYourDevice_Tab.Controls.Add(Me.UnlockBL_Button)
        Me.PrepareYourDevice_Tab.Controls.Add(Me.MagiskRoot_ProgressBar)
        Me.PrepareYourDevice_Tab.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrepareYourDevice_Tab.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PrepareYourDevice_Tab.HorizontalScrollbarBarColor = True
        Me.PrepareYourDevice_Tab.HorizontalScrollbarHighlightOnWheel = False
        Me.PrepareYourDevice_Tab.HorizontalScrollbarSize = 12
        Me.PrepareYourDevice_Tab.Location = New System.Drawing.Point(4, 41)
        Me.PrepareYourDevice_Tab.Name = "PrepareYourDevice_Tab"
        Me.PrepareYourDevice_Tab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PrepareYourDevice_Tab.Size = New System.Drawing.Size(369, 356)
        Me.PrepareYourDevice_Tab.Style = MetroFramework.MetroColorStyle.Green
        Me.PrepareYourDevice_Tab.TabIndex = 0
        Me.PrepareYourDevice_Tab.Text = "Prepare your device"
        Me.PrepareYourDevice_Tab.VerticalScrollbarBarColor = True
        Me.PrepareYourDevice_Tab.VerticalScrollbarHighlightOnWheel = False
        Me.PrepareYourDevice_Tab.VerticalScrollbarSize = 12
        '
        'UnlockBL_Label
        '
        Me.UnlockBL_Label.AutoSize = True
        Me.UnlockBL_Label.BackColor = System.Drawing.Color.Transparent
        Me.UnlockBL_Label.Location = New System.Drawing.Point(10, 50)
        Me.UnlockBL_Label.Margin = New System.Windows.Forms.Padding(0)
        Me.UnlockBL_Label.Name = "UnlockBL_Label"
        Me.UnlockBL_Label.Size = New System.Drawing.Size(268, 38)
        Me.UnlockBL_Label.Style = MetroFramework.MetroColorStyle.Green
        Me.UnlockBL_Label.TabIndex = 7
        Me.UnlockBL_Label.Text = "Check fastboot status then attempt to unlock" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your device bootloader"
        '
        'MagiskRoot_Label
        '
        Me.MagiskRoot_Label.AutoSize = True
        Me.MagiskRoot_Label.BackColor = System.Drawing.Color.Transparent
        Me.MagiskRoot_Label.Location = New System.Drawing.Point(10, 225)
        Me.MagiskRoot_Label.Name = "MagiskRoot_Label"
        Me.MagiskRoot_Label.Size = New System.Drawing.Size(248, 38)
        Me.MagiskRoot_Label.Style = MetroFramework.MetroColorStyle.Green
        Me.MagiskRoot_Label.TabIndex = 7
        Me.MagiskRoot_Label.Text = "Download the latest Magisk zip & apk then" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "attempt to install them"
        '
        'MagiskRoot_PictureBox
        '
        Me.MagiskRoot_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.MagiskRoot_PictureBox.Image = Global.GeekAssistant.My.Resources.Resources.Magisk_gray_alpha
        Me.MagiskRoot_PictureBox.Location = New System.Drawing.Point(239, 226)
        Me.MagiskRoot_PictureBox.Name = "MagiskRoot_PictureBox"
        Me.MagiskRoot_PictureBox.Size = New System.Drawing.Size(128, 128)
        Me.MagiskRoot_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MagiskRoot_PictureBox.TabIndex = 5
        Me.MagiskRoot_PictureBox.TabStop = False
        '
        'UnlockBL_PictureBox
        '
        Me.UnlockBL_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.UnlockBL_PictureBox.Image = Global.GeekAssistant.My.Resources.Resources.UnlockBL_gray_alpha
        Me.UnlockBL_PictureBox.Location = New System.Drawing.Point(239, 43)
        Me.UnlockBL_PictureBox.Name = "UnlockBL_PictureBox"
        Me.UnlockBL_PictureBox.Size = New System.Drawing.Size(128, 128)
        Me.UnlockBL_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UnlockBL_PictureBox.TabIndex = 5
        Me.UnlockBL_PictureBox.TabStop = False
        '
        'MagiskRoot_Title
        '
        Me.MagiskRoot_Title.AutoSize = True
        Me.MagiskRoot_Title.BackColor = System.Drawing.Color.Transparent
        Me.MagiskRoot_Title.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MagiskRoot_Title.Location = New System.Drawing.Point(45, 191)
        Me.MagiskRoot_Title.Name = "MagiskRoot_Title"
        Me.MagiskRoot_Title.Size = New System.Drawing.Size(131, 21)
        Me.MagiskRoot_Title.TabIndex = 2
        Me.MagiskRoot_Title.Text = "Root with Magisk"
        '
        'UnlockBL_Title
        '
        Me.UnlockBL_Title.AutoSize = True
        Me.UnlockBL_Title.BackColor = System.Drawing.Color.Transparent
        Me.UnlockBL_Title.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnlockBL_Title.Location = New System.Drawing.Point(45, 19)
        Me.UnlockBL_Title.Name = "UnlockBL_Title"
        Me.UnlockBL_Title.Size = New System.Drawing.Size(138, 21)
        Me.UnlockBL_Title.TabIndex = 2
        Me.UnlockBL_Title.Text = "Unlock Bootloader"
        '
        'MagiskRoot_Button
        '
        Me.MagiskRoot_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MagiskRoot_Button.BackColor = System.Drawing.Color.Transparent
        Me.MagiskRoot_Button.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.MagiskRoot_Button.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.MagiskRoot_Button.Highlight = True
        Me.MagiskRoot_Button.Location = New System.Drawing.Point(10, 301)
        Me.MagiskRoot_Button.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MagiskRoot_Button.Name = "MagiskRoot_Button"
        Me.MagiskRoot_Button.Size = New System.Drawing.Size(172, 36)
        Me.MagiskRoot_Button.Style = MetroFramework.MetroColorStyle.Green
        Me.MagiskRoot_Button.TabIndex = 6
        Me.MagiskRoot_Button.Text = "Start Rooting"
        Me.MagiskRoot_Button.UseSelectable = True
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.Gainsboro
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(3, 177)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(363, 1)
        Me.MaterialDivider1.TabIndex = 3
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'UnlockBL_ProgressBar
        '
        Me.UnlockBL_ProgressBar.BackColor = System.Drawing.Color.Gainsboro
        Me.UnlockBL_ProgressBar.Depth = 0
        Me.UnlockBL_ProgressBar.Location = New System.Drawing.Point(10, 29)
        Me.UnlockBL_ProgressBar.MouseState = MaterialSkin.MouseState.HOVER
        Me.UnlockBL_ProgressBar.Name = "UnlockBL_ProgressBar"
        Me.UnlockBL_ProgressBar.Size = New System.Drawing.Size(28, 5)
        Me.UnlockBL_ProgressBar.TabIndex = 4
        '
        'UnlockBL_Button
        '
        Me.UnlockBL_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UnlockBL_Button.BackColor = System.Drawing.Color.Transparent
        Me.UnlockBL_Button.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.UnlockBL_Button.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.UnlockBL_Button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UnlockBL_Button.Highlight = True
        Me.UnlockBL_Button.Location = New System.Drawing.Point(10, 118)
        Me.UnlockBL_Button.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UnlockBL_Button.Name = "UnlockBL_Button"
        Me.UnlockBL_Button.Size = New System.Drawing.Size(172, 36)
        Me.UnlockBL_Button.Style = MetroFramework.MetroColorStyle.Green
        Me.UnlockBL_Button.TabIndex = 6
        Me.UnlockBL_Button.Text = "Start Unlocking"
        Me.UnlockBL_Button.UseSelectable = True
        '
        'MagiskRoot_ProgressBar
        '
        Me.MagiskRoot_ProgressBar.BackColor = System.Drawing.Color.Gainsboro
        Me.MagiskRoot_ProgressBar.Depth = 0
        Me.MagiskRoot_ProgressBar.Location = New System.Drawing.Point(10, 201)
        Me.MagiskRoot_ProgressBar.MouseState = MaterialSkin.MouseState.HOVER
        Me.MagiskRoot_ProgressBar.Name = "MagiskRoot_ProgressBar"
        Me.MagiskRoot_ProgressBar.Size = New System.Drawing.Size(28, 5)
        Me.MagiskRoot_ProgressBar.TabIndex = 4
        '
        'FlashZip_Tab
        '
        Me.FlashZip_Tab.BackColor = System.Drawing.Color.White
        Me.FlashZip_Tab.Controls.Add(Me.FlashZip_ProgressBar)
        Me.FlashZip_Tab.Controls.Add(Me.FlashZip_ChooseFile_Button)
        Me.FlashZip_Tab.Controls.Add(Me.FlashZip_ChooseFile_TextBox)
        Me.FlashZip_Tab.Controls.Add(Me.FlashZip_Title)
        Me.FlashZip_Tab.Controls.Add(Me.FlashZip_RebootWhenComplete_Checkbox)
        Me.FlashZip_Tab.Controls.Add(Me.FlashZip_Button)
        Me.FlashZip_Tab.Controls.Add(Me.PictureBox3)
        Me.FlashZip_Tab.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FlashZip_Tab.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FlashZip_Tab.HorizontalScrollbarBarColor = True
        Me.FlashZip_Tab.HorizontalScrollbarHighlightOnWheel = False
        Me.FlashZip_Tab.HorizontalScrollbarSize = 12
        Me.FlashZip_Tab.Location = New System.Drawing.Point(4, 41)
        Me.FlashZip_Tab.Name = "FlashZip_Tab"
        Me.FlashZip_Tab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FlashZip_Tab.Size = New System.Drawing.Size(369, 356)
        Me.FlashZip_Tab.TabIndex = 1
        Me.FlashZip_Tab.Text = "Flash zip file"
        Me.FlashZip_Tab.VerticalScrollbarBarColor = True
        Me.FlashZip_Tab.VerticalScrollbarHighlightOnWheel = False
        Me.FlashZip_Tab.VerticalScrollbarSize = 12
        '
        'FlashZip_ProgressBar
        '
        Me.FlashZip_ProgressBar.Depth = 0
        Me.FlashZip_ProgressBar.Location = New System.Drawing.Point(10, 29)
        Me.FlashZip_ProgressBar.MouseState = MaterialSkin.MouseState.HOVER
        Me.FlashZip_ProgressBar.Name = "FlashZip_ProgressBar"
        Me.FlashZip_ProgressBar.Size = New System.Drawing.Size(28, 5)
        Me.FlashZip_ProgressBar.TabIndex = 4
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.GeekAssistant.My.Resources.Resources.FlashZip_gray_alpha
        Me.PictureBox3.Location = New System.Drawing.Point(241, 228)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'MoreTools_Tab
        '
        Me.MoreTools_Tab.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MoreTools_Tab.HorizontalScrollbarBarColor = True
        Me.MoreTools_Tab.HorizontalScrollbarHighlightOnWheel = False
        Me.MoreTools_Tab.HorizontalScrollbarSize = 3
        Me.MoreTools_Tab.Location = New System.Drawing.Point(4, 41)
        Me.MoreTools_Tab.Name = "MoreTools_Tab"
        Me.MoreTools_Tab.Size = New System.Drawing.Size(369, 356)
        Me.MoreTools_Tab.TabIndex = 2
        Me.MoreTools_Tab.Text = "More Tools"
        Me.MoreTools_Tab.VerticalScrollbarBarColor = True
        Me.MoreTools_Tab.VerticalScrollbarHighlightOnWheel = False
        Me.MoreTools_Tab.VerticalScrollbarSize = 3
        '
        'GA_About_Label
        '
        Me.GA_About_Label.AutoSize = True
        Me.GA_About_Label.Location = New System.Drawing.Point(112, 74)
        Me.GA_About_Label.Name = "GA_About_Label"
        Me.GA_About_Label.Size = New System.Drawing.Size(180, 19)
        Me.GA_About_Label.Style = MetroFramework.MetroColorStyle.Green
        Me.GA_About_Label.TabIndex = 85611
        Me.GA_About_Label.Text = "vX.x #Beta  - By NHKomaiha."
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(677, 599)
        Me.PictureBox4.TabIndex = 85613
        Me.PictureBox4.TabStop = False
        '
        'SwitchTheme_Back_UI
        '
        Me.SwitchTheme_Back_UI.Location = New System.Drawing.Point(-6, 601)
        Me.SwitchTheme_Back_UI.Name = "SwitchTheme_Back_UI"
        Me.SwitchTheme_Back_UI.Size = New System.Drawing.Size(1184, 929)
        Me.SwitchTheme_Back_UI.TabIndex = 85614
        Me.SwitchTheme_Back_UI.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GeekAssistant.My.Resources.Resources.G_noG
        Me.PictureBox1.Location = New System.Drawing.Point(24, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 85615
        Me.PictureBox1.TabStop = False
        '
        'SwitchTheme_Mid_UI
        '
        Me.SwitchTheme_Mid_UI.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SwitchTheme_Mid_UI.Location = New System.Drawing.Point(-6, 602)
        Me.SwitchTheme_Mid_UI.Name = "SwitchTheme_Mid_UI"
        Me.SwitchTheme_Mid_UI.Size = New System.Drawing.Size(1184, 929)
        Me.SwitchTheme_Mid_UI.TabIndex = 85616
        Me.SwitchTheme_Mid_UI.TabStop = False
        Me.SwitchTheme_Mid_UI.Visible = False
        '
        'SwitchTheme_Fore_UI
        '
        Me.SwitchTheme_Fore_UI.BackColor = System.Drawing.Color.Transparent
        Me.SwitchTheme_Fore_UI.Location = New System.Drawing.Point(-6, 602)
        Me.SwitchTheme_Fore_UI.Name = "SwitchTheme_Fore_UI"
        Me.SwitchTheme_Fore_UI.Size = New System.Drawing.Size(1184, 929)
        Me.SwitchTheme_Fore_UI.TabIndex = 85617
        Me.SwitchTheme_Fore_UI.TabStop = False
        Me.SwitchTheme_Fore_UI.Visible = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1174, 599)
        Me.Controls.Add(Me.SwitchTheme_Fore_UI)
        Me.Controls.Add(Me.SwitchTheme_Mid_UI)
        Me.Controls.Add(Me.SwitchTheme_Back_UI)
        Me.Controls.Add(Me.Donate_Button)
        Me.Controls.Add(Me.DeviceState_Label)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DeviceStateTitle_Label)
        Me.Controls.Add(Me.ShowLog_Button)
        Me.Controls.Add(Me.ProgressBarLabel)
        Me.Controls.Add(Me.ProgressFakeBG_UI)
        Me.Controls.Add(Me.manualCMD_TextBox)
        Me.Controls.Add(Me.GA_About_Label)
        Me.Controls.Add(Me.Main_Tabs)
        Me.Controls.Add(Me.About_Button)
        Me.Controls.Add(Me.SwitchTheme_Button)
        Me.Controls.Add(Me.Feedback_Button)
        Me.Controls.Add(Me.Settings_Button)
        Me.Controls.Add(Me.ManualInfo_GroupBox)
        Me.Controls.Add(Me.AutoDetectDeviceInfo_Button)
        Me.Controls.Add(Me.GeekAssistant)
        Me.Controls.Add(Me.MainLayout_PictureBox)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.OpenLogFolder)
        Me.Controls.Add(Me.CopyLogToClipboard)
        Me.Controls.Add(Me.ClearLog_Button)
        Me.Controls.Add(Me.log)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1190, 672)
        Me.MinimumSize = New System.Drawing.Size(690, 638)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Geek Assistant"
        Me.TransparencyKey = System.Drawing.Color.Magenta
        Me.ManualInfo_GroupBox.ResumeLayout(False)
        Me.ManualInfo_GroupBox.PerformLayout()
        CType(Me.GeekAssistant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainLayout_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressFakeBG_UI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Main_Tabs.ResumeLayout(False)
        Me.PrepareYourDevice_Tab.ResumeLayout(False)
        Me.PrepareYourDevice_Tab.PerformLayout()
        CType(Me.MagiskRoot_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnlockBL_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlashZip_Tab.ResumeLayout(False)
        Me.FlashZip_Tab.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwitchTheme_Back_UI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwitchTheme_Mid_UI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwitchTheme_Fore_UI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenLogFolder As Button
    Friend WithEvents ShowLog_InfoBlink_Timer As Timer
    Friend WithEvents PleaseWait_PostDelay_adbDetect As Timer
    Friend WithEvents FlashZip_OpenFileDialog As OpenFileDialog
    Friend WithEvents ShowLog_ErrorBlink_Timer As Timer
    Friend WithEvents Unavalable_Tooltip As ToolTip
    Friend WithEvents ManualInfo_GroupBox As GroupBox
    Friend WithEvents AutoDetectFlash_Timer_Deprecated As Timer
    Friend WithEvents SettingsSave_Timer As Timer
    Friend WithEvents DeviceStateTitle_Label As Label
    Friend WithEvents About_Button As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents FlashZip_RebootWhenComplete_Checkbox As CheckBox
    Friend WithEvents AutoDetectDeviceInfo_Button As Button
    Friend WithEvents ClearLog_Button As Button
    Friend WithEvents FlashZip_Title As Label
    Friend WithEvents CopyLogToClipboard As Button
    Friend WithEvents FlashZip_ChooseFile_TextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GeekAssistant As PictureBox
    Friend WithEvents log As TextBox
    Friend WithEvents Feedback_Button As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Settings As Button
    Friend WithEvents MainLayout_PictureBox As PictureBox
    Friend WithEvents Settings_Button As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents FlashZip_Button As MetroFramework.Controls.MetroButton
    Friend WithEvents ShowLog_Button As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents manualCMD_TextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ProgressFakeBG_UI As PictureBox
    Friend WithEvents Main_Tabs As MetroFramework.Controls.MetroTabControl
    Friend WithEvents PrepareYourDevice_Tab As MetroFramework.Controls.MetroTabPage
    Friend WithEvents FlashZip_Tab As MetroFramework.Controls.MetroTabPage
    Friend WithEvents UnlockBL_Title As Label
    Friend WithEvents MagiskRoot_Title As Label
    Friend WithEvents Manufacturer_ComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents BootloaderUnlockable_CheckBox As CheckBox
    Friend WithEvents AndroidVersion_ComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents CustomRecovery_CheckBox As CheckBox
    Friend WithEvents CustomROM_CheckBox As CheckBox
    Friend WithEvents ProgressBarLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents GA_About_Label As MetroFramework.Controls.MetroLabel
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MoreTools_Tab As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MagiskRoot_ProgressBar As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents UnlockBL_ProgressBar As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents FlashZip_ProgressBar As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents MagiskRoot_PictureBox As PictureBox
    Friend WithEvents UnlockBL_PictureBox As PictureBox
    Friend WithEvents Main_ToolTip As ToolTip
    Friend WithEvents UnlockBL_Button As MetroFramework.Controls.MetroButton
    Friend WithEvents MagiskRoot_Button As MetroFramework.Controls.MetroButton
    Friend WithEvents UnlockBL_Label As MetroFramework.Controls.MetroLabel
    Friend WithEvents MagiskRoot_Label As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ProgressBar As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents SwitchTheme_Back_UI As PictureBox
    Friend WithEvents SwitchTheme_Button As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents FlashZip_ChooseFile_Button As Button
    Friend WithEvents DeviceState_Label As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SwitchTheme_Mid_UI As PictureBox
    Friend WithEvents SwitchTheme_Fore_UI As PictureBox
    Friend WithEvents Rooted_Checkbox As CheckBox
    Friend WithEvents Donate_Button As MaterialSkin.Controls.MaterialFlatButton
End Class