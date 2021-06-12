
using System.Windows.Forms;
using MetroFramework.Controls;
using GeekAssistant.Controls;
using System.Drawing;
using GeekAssistant.Controls.Material;

namespace GeekAssistant.Forms {
    partial class Home : Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.OpenLogFolder = new System.Windows.Forms.Button();
            this.Toggle_ManualDeviceInfo_Button = new GeekAssistant.Controls.Material.FlatButton();
            this.FlashZip_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CustomRecovery_CheckBox = new System.Windows.Forms.CheckBox();
            this.CustomROM_CheckBox = new System.Windows.Forms.CheckBox();
            this.ManualInfo_GroupBox = new System.Windows.Forms.GroupBox();
            this.AndroidVersion_ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.Manufacturer_ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.Rooted_Checkbox = new System.Windows.Forms.CheckBox();
            this.BootloaderUnlockable_CheckBox = new System.Windows.Forms.CheckBox();
            this.DeviceState_Label = new System.Windows.Forms.Label();
            this.DeviceStateTitle_Label = new System.Windows.Forms.Label();
            this.FlashZip_Button = new GeekAssistant.Controls.Material.FlatButton();
            this.About_Button = new GeekAssistant.Controls.Material.FlatButton();
            this.Settings_Button = new GeekAssistant.Controls.Material.FlatButton();
            this.Feedback_Button = new GeekAssistant.Controls.Material.FlatButton();
            this.FlashZip_RebootWhenComplete_Checkbox = new System.Windows.Forms.CheckBox();
            this.AutoDetectDeviceInfo_Button = new System.Windows.Forms.Button();
            this.ClearLog_Button = new System.Windows.Forms.Button();
            this.FlashZip_Title = new System.Windows.Forms.Label();
            this.CopyLogToClipboard = new System.Windows.Forms.Button();
            this.GeekAssistant = new System.Windows.Forms.PictureBox();
            this.FlashZip_ChooseFile_Button = new System.Windows.Forms.Button();
            this.ShowLog_Button = new GeekAssistant.Controls.Material.FlatButton();
            this.log_TextBox = new System.Windows.Forms.TextBox();
            this.ProgressBarLabel = new System.Windows.Forms.Label();
            this.SwitchTheme_Button = new GeekAssistant.Controls.Material.FlatButton();
            this.Donate_Button = new GeekAssistant.Controls.Material.FlatButton();
            this.MainLayout_PictureBox = new System.Windows.Forms.PictureBox();
            this.ProgressFakeBG_UI = new System.Windows.Forms.PictureBox();
            this.Main_Tabs_old = new MetroFramework.Controls.MetroTabControl();
            this.MoreTools_Tab_old = new MetroFramework.Controls.MetroTabPage();
            this.FlashImg_Tab_old = new MetroFramework.Controls.MetroTabPage();
            this.PrepareYourDevice_Tab_old = new MetroFramework.Controls.MetroTabPage();
            this.UnlockBL_Label = new System.Windows.Forms.Label();
            this.MagiskRoot_Label = new System.Windows.Forms.Label();
            this.MagiskRoot_PictureBox = new System.Windows.Forms.PictureBox();
            this.UnlockBL_PictureBox = new System.Windows.Forms.PictureBox();
            this.MagiskRoot_Title = new System.Windows.Forms.Label();
            this.UnlockBL_Title = new System.Windows.Forms.Label();
            this.MagiskRoot_Button = new GeekAssistant.Controls.Material.FlatButton();
            this.MaterialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.UnlockBL_Button = new GeekAssistant.Controls.Material.FlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Button4 = new System.Windows.Forms.Button();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.InstallBusybox_Button = new MetroFramework.Controls.MetroButton();
            this.HotReboot_Button = new MetroFramework.Controls.MetroButton();
            this.GA_About_Label = new System.Windows.Forms.Label();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.SwitchTheme_UI = new System.Windows.Forms.PictureBox();
            this.GeekAssistant_Icon = new System.Windows.Forms.PictureBox();
            this.bar = new MetroFramework.Controls.MetroProgressBar();
            this.ShowLog_ErrorBlink_Timer = new System.Windows.Forms.Timer(this.components);
            this.ShowLog_InfoBlink_Timer = new System.Windows.Forms.Timer(this.components);
            this.SettingsSave_Timer = new System.Windows.Forms.Timer(this.components);
            this.AutoDetectFlash_Timer_Deprecated = new System.Windows.Forms.Timer(this.components);
            this.Wait_PostDelay_adbDetect = new System.Windows.Forms.Timer(this.components);
            this.Main_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Unavalable_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Manufacturer_Title_Label = new System.Windows.Forms.Label();
            this.Manufacturer_Label = new System.Windows.Forms.Label();
            this.AndroidVersion_Title_Label = new System.Windows.Forms.Label();
            this.AndroidVersion_Label = new System.Windows.Forms.Label();
            this.BootloaderUnlockable_Title_Label = new System.Windows.Forms.Label();
            this.BootloaderUnlockable_Label = new System.Windows.Forms.Label();
            this.Rooted_Title_Label = new System.Windows.Forms.Label();
            this.Rooted_Label = new System.Windows.Forms.Label();
            this.CustomRecovery_Title_Label = new System.Windows.Forms.Label();
            this.CustomRecovery_Label = new System.Windows.Forms.Label();
            this.CustomROM_Title_Label = new System.Windows.Forms.Label();
            this.CustomROM_Label = new System.Windows.Forms.Label();
            this.Home_Tabs = new MaterialSkin.Controls.MaterialTabControl();
            this.Prepare_Tab = new System.Windows.Forms.TabPage();
            this.Flash_Tab = new System.Windows.Forms.TabPage();
            this.More_Tab = new System.Windows.Forms.TabPage();
            this.debuggingBox = new System.Windows.Forms.GroupBox();
            this.MetroButton4 = new MetroFramework.Controls.MetroButton();
            this.MetroButton8 = new MetroFramework.Controls.MetroButton();
            this.MetroButton7 = new MetroFramework.Controls.MetroButton();
            this.MetroButton6 = new MetroFramework.Controls.MetroButton();
            this.MetroButton11 = new MetroFramework.Controls.MetroButton();
            this.MetroButton3 = new MetroFramework.Controls.MetroButton();
            this.MetroButton2 = new MetroFramework.Controls.MetroButton();
            this.MetroButton1 = new MetroFramework.Controls.MetroButton();
            this.materialTabSelector1 = new GeekAssistant.Controls.Material.TabSelector();
            this.SwitchTheme_Light_UI_Icon = new System.Windows.Forms.PictureBox();
            this.SwitchTheme_Dark_UI_Icon = new System.Windows.Forms.PictureBox();
            this.manualCMD_TextBox = new GeekAssistant.Controls.Material.MaterialTextBox();
            this.ManualInfo_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeekAssistant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainLayout_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressFakeBG_UI)).BeginInit();
            this.Main_Tabs_old.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MagiskRoot_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnlockBL_PictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchTheme_UI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeekAssistant_Icon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.Home_Tabs.SuspendLayout();
            this.Prepare_Tab.SuspendLayout();
            this.Flash_Tab.SuspendLayout();
            this.More_Tab.SuspendLayout();
            this.debuggingBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchTheme_Light_UI_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchTheme_Dark_UI_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenLogFolder
            // 
            this.OpenLogFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenLogFolder.BackColor = System.Drawing.Color.Transparent;
            this.OpenLogFolder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OpenLogFolder.FlatAppearance.BorderSize = 0;
            this.OpenLogFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.OpenLogFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.OpenLogFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenLogFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenLogFolder.Image = global::prop.x24.OpenFolder_B_24;
            this.OpenLogFolder.Location = new System.Drawing.Point(1078, 553);
            this.OpenLogFolder.Name = "OpenLogFolder";
            this.OpenLogFolder.Size = new System.Drawing.Size(28, 27);
            this.OpenLogFolder.TabIndex = 85598;
            this.OpenLogFolder.UseVisualStyleBackColor = false;
            // 
            // Toggle_ManualDeviceInfo_Button
            // 
            this.Toggle_ManualDeviceInfo_Button.Depth = 0;
            this.Toggle_ManualDeviceInfo_Button.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Toggle_ManualDeviceInfo_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Toggle_ManualDeviceInfo_Button.Icon = null;
            this.Toggle_ManualDeviceInfo_Button.Location = new System.Drawing.Point(24, 482);
            this.Toggle_ManualDeviceInfo_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Toggle_ManualDeviceInfo_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Toggle_ManualDeviceInfo_Button.Name = "Toggle_ManualDeviceInfo_Button";
            this.Toggle_ManualDeviceInfo_Button.Primary = true;
            this.Toggle_ManualDeviceInfo_Button.Size = new System.Drawing.Size(243, 36);
            this.Toggle_ManualDeviceInfo_Button.TabIndex = 85352;
            this.Toggle_ManualDeviceInfo_Button.Text = "Select Device Info Manually";
            this.Toggle_ManualDeviceInfo_Button.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Toggle_ManualDeviceInfo_Button.UseVisualStyleBackColor = false;
            // 
            // FlashZip_OpenFileDialog
            // 
            this.FlashZip_OpenFileDialog.DefaultExt = "zip";
            this.FlashZip_OpenFileDialog.Filter = "Zip files|*.zip";
            // 
            // CustomRecovery_CheckBox
            // 
            this.CustomRecovery_CheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomRecovery_CheckBox.Location = new System.Drawing.Point(20, 201);
            this.CustomRecovery_CheckBox.Name = "CustomRecovery_CheckBox";
            this.CustomRecovery_CheckBox.Size = new System.Drawing.Size(137, 21);
            this.CustomRecovery_CheckBox.TabIndex = 85598;
            this.CustomRecovery_CheckBox.Text = "* Custom Recovery";
            // 
            // CustomROM_CheckBox
            // 
            this.CustomROM_CheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomROM_CheckBox.Location = new System.Drawing.Point(20, 174);
            this.CustomROM_CheckBox.Name = "CustomROM_CheckBox";
            this.CustomROM_CheckBox.Size = new System.Drawing.Size(114, 21);
            this.CustomROM_CheckBox.TabIndex = 85599;
            this.CustomROM_CheckBox.Text = "* Custom ROM";
            // 
            // ManualInfo_GroupBox
            // 
            this.ManualInfo_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ManualInfo_GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ManualInfo_GroupBox.Controls.Add(this.AndroidVersion_ComboBox);
            this.ManualInfo_GroupBox.Controls.Add(this.Manufacturer_ComboBox);
            this.ManualInfo_GroupBox.Controls.Add(this.Rooted_Checkbox);
            this.ManualInfo_GroupBox.Controls.Add(this.BootloaderUnlockable_CheckBox);
            this.ManualInfo_GroupBox.Controls.Add(this.CustomRecovery_CheckBox);
            this.ManualInfo_GroupBox.Controls.Add(this.CustomROM_CheckBox);
            this.ManualInfo_GroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ManualInfo_GroupBox.Location = new System.Drawing.Point(24, 482);
            this.ManualInfo_GroupBox.Name = "ManualInfo_GroupBox";
            this.ManualInfo_GroupBox.Size = new System.Drawing.Size(243, 0);
            this.ManualInfo_GroupBox.TabIndex = 85591;
            this.ManualInfo_GroupBox.TabStop = false;
            this.ManualInfo_GroupBox.Text = "Manual Device Information";
            // 
            // AndroidVersion_ComboBox
            // 
            this.AndroidVersion_ComboBox.FormattingEnabled = true;
            this.AndroidVersion_ComboBox.ItemHeight = 23;
            this.AndroidVersion_ComboBox.Items.AddRange(new object[] {
            "Android 11 R (And Above)",
            "Android 10 Q",
            "Pie 9.x",
            "Oreo 8.x",
            "Nougat 7.x",
            "Marshmallow 6.x",
            "Lollipop 5.x",
            "KitKat 4.4 (And Below)"});
            this.AndroidVersion_ComboBox.Location = new System.Drawing.Point(20, 75);
            this.AndroidVersion_ComboBox.Name = "AndroidVersion_ComboBox";
            this.AndroidVersion_ComboBox.PromptText = "Select Android version";
            this.AndroidVersion_ComboBox.Size = new System.Drawing.Size(199, 29);
            this.AndroidVersion_ComboBox.Style = MetroFramework.MetroColorStyle.Green;
            this.AndroidVersion_ComboBox.TabIndex = 85596;
            this.AndroidVersion_ComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AndroidVersion_ComboBox.UseSelectable = true;
            // 
            // Manufacturer_ComboBox
            // 
            this.Manufacturer_ComboBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Manufacturer_ComboBox.FormattingEnabled = true;
            this.Manufacturer_ComboBox.ItemHeight = 23;
            this.Manufacturer_ComboBox.Items.AddRange(new object[] {
            "Google",
            "OnePlus",
            "Samsung",
            "Xiaomi",
            "Huawei",
            "Nokia",
            "LG"});
            this.Manufacturer_ComboBox.Location = new System.Drawing.Point(20, 31);
            this.Manufacturer_ComboBox.Name = "Manufacturer_ComboBox";
            this.Manufacturer_ComboBox.PromptText = "Select manufacturer";
            this.Manufacturer_ComboBox.Size = new System.Drawing.Size(199, 29);
            this.Manufacturer_ComboBox.Style = MetroFramework.MetroColorStyle.Green;
            this.Manufacturer_ComboBox.TabIndex = 85595;
            this.Manufacturer_ComboBox.Tag = "";
            this.Manufacturer_ComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Manufacturer_ComboBox.UseSelectable = true;
            // 
            // Rooted_Checkbox
            // 
            this.Rooted_Checkbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rooted_Checkbox.Location = new System.Drawing.Point(20, 147);
            this.Rooted_Checkbox.Name = "Rooted_Checkbox";
            this.Rooted_Checkbox.Size = new System.Drawing.Size(70, 21);
            this.Rooted_Checkbox.TabIndex = 85597;
            this.Rooted_Checkbox.Text = "Rooted";
            // 
            // BootloaderUnlockable_CheckBox
            // 
            this.BootloaderUnlockable_CheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BootloaderUnlockable_CheckBox.Location = new System.Drawing.Point(20, 120);
            this.BootloaderUnlockable_CheckBox.Name = "BootloaderUnlockable_CheckBox";
            this.BootloaderUnlockable_CheckBox.Size = new System.Drawing.Size(158, 21);
            this.BootloaderUnlockable_CheckBox.TabIndex = 85597;
            this.BootloaderUnlockable_CheckBox.Text = "Bootloader unlockable";
            // 
            // DeviceState_Label
            // 
            this.DeviceState_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeviceState_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeviceState_Label.ForeColor = System.Drawing.Color.Gray;
            this.DeviceState_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeviceState_Label.Location = new System.Drawing.Point(103, 10);
            this.DeviceState_Label.Name = "DeviceState_Label";
            this.DeviceState_Label.Size = new System.Drawing.Size(137, 25);
            this.DeviceState_Label.TabIndex = 85597;
            this.DeviceState_Label.Text = "Disconnected";
            this.DeviceState_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeviceStateTitle_Label
            // 
            this.DeviceStateTitle_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeviceStateTitle_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeviceStateTitle_Label.Location = new System.Drawing.Point(3, 10);
            this.DeviceStateTitle_Label.Name = "DeviceStateTitle_Label";
            this.DeviceStateTitle_Label.Size = new System.Drawing.Size(94, 25);
            this.DeviceStateTitle_Label.TabIndex = 85594;
            this.DeviceStateTitle_Label.Text = "Device State:";
            this.DeviceStateTitle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FlashZip_Button
            // 
            this.FlashZip_Button.Depth = 0;
            this.FlashZip_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FlashZip_Button.Icon = null;
            this.FlashZip_Button.Location = new System.Drawing.Point(19, 298);
            this.FlashZip_Button.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.FlashZip_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.FlashZip_Button.Name = "FlashZip_Button";
            this.FlashZip_Button.Primary = false;
            this.FlashZip_Button.Size = new System.Drawing.Size(94, 36);
            this.FlashZip_Button.TabIndex = 85583;
            this.FlashZip_Button.Text = "Start Flashing";
            this.FlashZip_Button.TextAlignment = System.Drawing.StringAlignment.Near;
            this.FlashZip_Button.UseVisualStyleBackColor = false;
            // 
            // About_Button
            // 
            this.About_Button.Depth = 0;
            this.About_Button.FlatAppearance.BorderSize = 0;
            this.About_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.About_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.About_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.About_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.About_Button.Icon = global::prop.x24.ToU_24;
            this.About_Button.Location = new System.Drawing.Point(528, 30);
            this.About_Button.Margin = new System.Windows.Forms.Padding(0);
            this.About_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.About_Button.Name = "About_Button";
            this.About_Button.Primary = true;
            this.About_Button.Size = new System.Drawing.Size(36, 36);
            this.About_Button.TabIndex = 85587;
            this.About_Button.TextAlignment = System.Drawing.StringAlignment.Near;
            this.About_Button.UseVisualStyleBackColor = false;
            // 
            // Settings_Button
            // 
            this.Settings_Button.Depth = 0;
            this.Settings_Button.FlatAppearance.BorderSize = 0;
            this.Settings_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Settings_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Settings_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Settings_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Settings_Button.Icon = global::prop.x24.Settings_24;
            this.Settings_Button.Location = new System.Drawing.Point(567, 30);
            this.Settings_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Settings_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.Primary = true;
            this.Settings_Button.Size = new System.Drawing.Size(36, 36);
            this.Settings_Button.TabIndex = 85588;
            this.Settings_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Settings_Button.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Settings_Button.UseVisualStyleBackColor = false;
            // 
            // Feedback_Button
            // 
            this.Feedback_Button.Depth = 0;
            this.Feedback_Button.FlatAppearance.BorderSize = 0;
            this.Feedback_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Feedback_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Feedback_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Feedback_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Feedback_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Feedback_Button.Icon = global::prop.x24.Smile_24;
            this.Feedback_Button.Location = new System.Drawing.Point(489, 30);
            this.Feedback_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Feedback_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Feedback_Button.Name = "Feedback_Button";
            this.Feedback_Button.Primary = true;
            this.Feedback_Button.Size = new System.Drawing.Size(36, 36);
            this.Feedback_Button.TabIndex = 85589;
            this.Feedback_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Feedback_Button.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Feedback_Button.UseVisualStyleBackColor = false;
            // 
            // FlashZip_RebootWhenComplete_Checkbox
            // 
            this.FlashZip_RebootWhenComplete_Checkbox.BackColor = System.Drawing.Color.Transparent;
            this.FlashZip_RebootWhenComplete_Checkbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlashZip_RebootWhenComplete_Checkbox.Location = new System.Drawing.Point(25, 271);
            this.FlashZip_RebootWhenComplete_Checkbox.Name = "FlashZip_RebootWhenComplete_Checkbox";
            this.FlashZip_RebootWhenComplete_Checkbox.Size = new System.Drawing.Size(149, 19);
            this.FlashZip_RebootWhenComplete_Checkbox.TabIndex = 85581;
            this.FlashZip_RebootWhenComplete_Checkbox.Text = "Reboot when complete";
            this.FlashZip_RebootWhenComplete_Checkbox.UseVisualStyleBackColor = false;
            // 
            // AutoDetectDeviceInfo_Button
            // 
            this.AutoDetectDeviceInfo_Button.BackColor = System.Drawing.Color.Honeydew;
            this.AutoDetectDeviceInfo_Button.BackgroundImage = global::prop.layout.LightBlue_Up_Gradient;
            this.AutoDetectDeviceInfo_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AutoDetectDeviceInfo_Button.FlatAppearance.BorderSize = 0;
            this.AutoDetectDeviceInfo_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AutoDetectDeviceInfo_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.AutoDetectDeviceInfo_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoDetectDeviceInfo_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AutoDetectDeviceInfo_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.AutoDetectDeviceInfo_Button.Image = global::prop.x64.AutoDetect_64;
            this.AutoDetectDeviceInfo_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AutoDetectDeviceInfo_Button.Location = new System.Drawing.Point(24, 122);
            this.AutoDetectDeviceInfo_Button.Name = "AutoDetectDeviceInfo_Button";
            this.AutoDetectDeviceInfo_Button.Size = new System.Drawing.Size(243, 63);
            this.AutoDetectDeviceInfo_Button.TabIndex = 85574;
            this.AutoDetectDeviceInfo_Button.Text = "Automatic &Detection   ";
            this.AutoDetectDeviceInfo_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AutoDetectDeviceInfo_Button.UseVisualStyleBackColor = false;
            // 
            // ClearLog_Button
            // 
            this.ClearLog_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearLog_Button.BackColor = System.Drawing.Color.Transparent;
            this.ClearLog_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ClearLog_Button.FlatAppearance.BorderSize = 0;
            this.ClearLog_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.ClearLog_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ClearLog_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearLog_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearLog_Button.Image = global::prop.x24.Backspace_B_24;
            this.ClearLog_Button.Location = new System.Drawing.Point(1134, 553);
            this.ClearLog_Button.Name = "ClearLog_Button";
            this.ClearLog_Button.Size = new System.Drawing.Size(28, 27);
            this.ClearLog_Button.TabIndex = 85596;
            this.ClearLog_Button.UseVisualStyleBackColor = false;
            // 
            // FlashZip_Title
            // 
            this.FlashZip_Title.BackColor = System.Drawing.Color.Transparent;
            this.FlashZip_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlashZip_Title.Location = new System.Drawing.Point(15, 14);
            this.FlashZip_Title.Name = "FlashZip_Title";
            this.FlashZip_Title.Size = new System.Drawing.Size(175, 21);
            this.FlashZip_Title.TabIndex = 85575;
            this.FlashZip_Title.Text = "Choose the files to flash";
            // 
            // CopyLogToClipboard
            // 
            this.CopyLogToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyLogToClipboard.BackColor = System.Drawing.Color.Transparent;
            this.CopyLogToClipboard.FlatAppearance.BorderSize = 0;
            this.CopyLogToClipboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.CopyLogToClipboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.CopyLogToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyLogToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CopyLogToClipboard.Image = global::prop.x24.Copy_B_24;
            this.CopyLogToClipboard.Location = new System.Drawing.Point(1106, 553);
            this.CopyLogToClipboard.Name = "CopyLogToClipboard";
            this.CopyLogToClipboard.Size = new System.Drawing.Size(28, 27);
            this.CopyLogToClipboard.TabIndex = 85597;
            this.CopyLogToClipboard.UseVisualStyleBackColor = false;
            // 
            // GeekAssistant
            // 
            this.GeekAssistant.BackColor = System.Drawing.Color.Transparent;
            this.GeekAssistant.Image = ((System.Drawing.Image)(resources.GetObject("GeekAssistant.Image")));
            this.GeekAssistant.Location = new System.Drawing.Point(112, 22);
            this.GeekAssistant.Name = "GeekAssistant";
            this.GeekAssistant.Size = new System.Drawing.Size(294, 52);
            this.GeekAssistant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GeekAssistant.TabIndex = 85593;
            this.GeekAssistant.TabStop = false;
            // 
            // FlashZip_ChooseFile_Button
            // 
            this.FlashZip_ChooseFile_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(164)))), ((int)(((byte)(50)))));
            this.FlashZip_ChooseFile_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FlashZip_ChooseFile_Button.FlatAppearance.BorderSize = 0;
            this.FlashZip_ChooseFile_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.FlashZip_ChooseFile_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.FlashZip_ChooseFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlashZip_ChooseFile_Button.Image = global::prop.x24.OpenFile_24_noBG;
            this.FlashZip_ChooseFile_Button.Location = new System.Drawing.Point(270, 14);
            this.FlashZip_ChooseFile_Button.Name = "FlashZip_ChooseFile_Button";
            this.FlashZip_ChooseFile_Button.Size = new System.Drawing.Size(25, 25);
            this.FlashZip_ChooseFile_Button.TabIndex = 85580;
            this.FlashZip_ChooseFile_Button.UseVisualStyleBackColor = false;
            // 
            // ShowLog_Button
            // 
            this.ShowLog_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowLog_Button.Depth = 0;
            this.ShowLog_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ShowLog_Button.FlatAppearance.BorderSize = 0;
            this.ShowLog_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.ShowLog_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ShowLog_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowLog_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShowLog_Button.Icon = global::prop.x24.Commands_24;
            this.ShowLog_Button.Location = new System.Drawing.Point(608, 544);
            this.ShowLog_Button.Margin = new System.Windows.Forms.Padding(0);
            this.ShowLog_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowLog_Button.Name = "ShowLog_Button";
            this.ShowLog_Button.Primary = false;
            this.ShowLog_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowLog_Button.Size = new System.Drawing.Size(36, 36);
            this.ShowLog_Button.TabIndex = 85585;
            this.ShowLog_Button.Tag = " ";
            this.ShowLog_Button.TextAlignment = System.Drawing.StringAlignment.Near;
            this.ShowLog_Button.UseVisualStyleBackColor = true;
            // 
            // log
            // 
            this.log_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log_TextBox.BackColor = System.Drawing.Color.White;
            this.log_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log_TextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.log_TextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.log_TextBox.Location = new System.Drawing.Point(683, 22);
            this.log_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.log_TextBox.Multiline = true;
            this.log_TextBox.Name = "log";
            this.log_TextBox.ReadOnly = true;
            this.log_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log_TextBox.Size = new System.Drawing.Size(508, 525);
            this.log_TextBox.TabIndex = 85590;
            this.log_TextBox.Text = "Geek Assistant vX.x #Phase ©2021 By NHKomaiha.\r\n// hh:mm:ss.ff // Start //";
            // 
            // ProgressBarLabel
            // 
            this.ProgressBarLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgressBarLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgressBarLabel.Location = new System.Drawing.Point(38, 544);
            this.ProgressBarLabel.Name = "ProgressBarLabel";
            this.ProgressBarLabel.Size = new System.Drawing.Size(570, 36);
            this.ProgressBarLabel.TabIndex = 85610;
            this.ProgressBarLabel.Text = "Current process information will be written here. Click for more information >>";
            this.ProgressBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SwitchTheme_Button
            // 
            this.SwitchTheme_Button.Depth = 0;
            this.SwitchTheme_Button.FlatAppearance.BorderSize = 0;
            this.SwitchTheme_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SwitchTheme_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SwitchTheme_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SwitchTheme_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SwitchTheme_Button.Icon = global::prop.x24.Theme_light_24;
            this.SwitchTheme_Button.Location = new System.Drawing.Point(450, 30);
            this.SwitchTheme_Button.Margin = new System.Windows.Forms.Padding(0);
            this.SwitchTheme_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwitchTheme_Button.Name = "SwitchTheme_Button";
            this.SwitchTheme_Button.Primary = false;
            this.SwitchTheme_Button.Size = new System.Drawing.Size(36, 36);
            this.SwitchTheme_Button.TabIndex = 85589;
            this.SwitchTheme_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SwitchTheme_Button.TextAlignment = System.Drawing.StringAlignment.Near;
            this.SwitchTheme_Button.UseVisualStyleBackColor = false;
            // 
            // Donate_Button
            // 
            this.Donate_Button.Depth = 0;
            this.Donate_Button.FlatAppearance.BorderSize = 0;
            this.Donate_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Donate_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Donate_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Donate_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Donate_Button.Icon = global::prop.x24.DonateHeart_24;
            this.Donate_Button.Location = new System.Drawing.Point(606, 30);
            this.Donate_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Donate_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Donate_Button.Name = "Donate_Button";
            this.Donate_Button.Primary = false;
            this.Donate_Button.Size = new System.Drawing.Size(36, 36);
            this.Donate_Button.TabIndex = 85618;
            this.Donate_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Donate_Button.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Donate_Button.UseVisualStyleBackColor = false;
            // 
            // MainLayout_PictureBox
            // 
            this.MainLayout_PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MainLayout_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.MainLayout_PictureBox.Image = global::prop.layout.Layout_3DLine_toRight;
            this.MainLayout_PictureBox.Location = new System.Drawing.Point(673, 12);
            this.MainLayout_PictureBox.Name = "MainLayout_PictureBox";
            this.MainLayout_PictureBox.Size = new System.Drawing.Size(10, 574);
            this.MainLayout_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainLayout_PictureBox.TabIndex = 85599;
            this.MainLayout_PictureBox.TabStop = false;
            // 
            // ProgressFakeBG_UI
            // 
            this.ProgressFakeBG_UI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgressFakeBG_UI.Location = new System.Drawing.Point(29, 544);
            this.ProgressFakeBG_UI.Name = "ProgressFakeBG_UI";
            this.ProgressFakeBG_UI.Size = new System.Drawing.Size(615, 36);
            this.ProgressFakeBG_UI.TabIndex = 85606;
            this.ProgressFakeBG_UI.TabStop = false;
            // 
            // Main_Tabs_old
            // 
            this.Main_Tabs_old.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Main_Tabs_old.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Main_Tabs_old.Controls.Add(this.MoreTools_Tab_old);
            this.Main_Tabs_old.Controls.Add(this.FlashImg_Tab_old);
            this.Main_Tabs_old.Controls.Add(this.PrepareYourDevice_Tab_old);
            this.Main_Tabs_old.Location = new System.Drawing.Point(273, 117);
            this.Main_Tabs_old.Name = "Main_Tabs_old";
            this.Main_Tabs_old.Padding = new System.Drawing.Point(6, 8);
            this.Main_Tabs_old.SelectedIndex = 0;
            this.Main_Tabs_old.Size = new System.Drawing.Size(377, 12);
            this.Main_Tabs_old.Style = MetroFramework.MetroColorStyle.Green;
            this.Main_Tabs_old.TabIndex = 85609;
            this.Main_Tabs_old.UseSelectable = true;
            // 
            // MoreTools_Tab_old
            // 
            this.MoreTools_Tab_old.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MoreTools_Tab_old.HorizontalScrollbarBarColor = true;
            this.MoreTools_Tab_old.HorizontalScrollbarHighlightOnWheel = false;
            this.MoreTools_Tab_old.HorizontalScrollbarSize = 3;
            this.MoreTools_Tab_old.Location = new System.Drawing.Point(4, 41);
            this.MoreTools_Tab_old.Name = "MoreTools_Tab_old";
            this.MoreTools_Tab_old.Size = new System.Drawing.Size(369, 0);
            this.MoreTools_Tab_old.TabIndex = 2;
            this.MoreTools_Tab_old.Text = "More Tools";
            this.MoreTools_Tab_old.VerticalScrollbarBarColor = true;
            this.MoreTools_Tab_old.VerticalScrollbarHighlightOnWheel = false;
            this.MoreTools_Tab_old.VerticalScrollbarSize = 3;
            // 
            // FlashImg_Tab_old
            // 
            this.FlashImg_Tab_old.BackColor = System.Drawing.Color.White;
            this.FlashImg_Tab_old.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlashImg_Tab_old.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FlashImg_Tab_old.HorizontalScrollbarBarColor = true;
            this.FlashImg_Tab_old.HorizontalScrollbarHighlightOnWheel = false;
            this.FlashImg_Tab_old.HorizontalScrollbarSize = 12;
            this.FlashImg_Tab_old.Location = new System.Drawing.Point(4, 41);
            this.FlashImg_Tab_old.Name = "FlashImg_Tab_old";
            this.FlashImg_Tab_old.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FlashImg_Tab_old.Size = new System.Drawing.Size(369, -33);
            this.FlashImg_Tab_old.TabIndex = 1;
            this.FlashImg_Tab_old.Text = "Flash img files";
            this.FlashImg_Tab_old.VerticalScrollbarBarColor = true;
            this.FlashImg_Tab_old.VerticalScrollbarHighlightOnWheel = false;
            this.FlashImg_Tab_old.VerticalScrollbarSize = 12;
            // 
            // PrepareYourDevice_Tab_old
            // 
            this.PrepareYourDevice_Tab_old.BackColor = System.Drawing.Color.White;
            this.PrepareYourDevice_Tab_old.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrepareYourDevice_Tab_old.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PrepareYourDevice_Tab_old.HorizontalScrollbarBarColor = true;
            this.PrepareYourDevice_Tab_old.HorizontalScrollbarHighlightOnWheel = false;
            this.PrepareYourDevice_Tab_old.HorizontalScrollbarSize = 12;
            this.PrepareYourDevice_Tab_old.Location = new System.Drawing.Point(4, 41);
            this.PrepareYourDevice_Tab_old.Name = "PrepareYourDevice_Tab_old";
            this.PrepareYourDevice_Tab_old.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PrepareYourDevice_Tab_old.Size = new System.Drawing.Size(369, -33);
            this.PrepareYourDevice_Tab_old.Style = MetroFramework.MetroColorStyle.Green;
            this.PrepareYourDevice_Tab_old.TabIndex = 0;
            this.PrepareYourDevice_Tab_old.Text = "Prepare your device";
            this.PrepareYourDevice_Tab_old.VerticalScrollbarBarColor = true;
            this.PrepareYourDevice_Tab_old.VerticalScrollbarHighlightOnWheel = false;
            this.PrepareYourDevice_Tab_old.VerticalScrollbarSize = 12;
            // 
            // UnlockBL_Label
            // 
            this.UnlockBL_Label.BackColor = System.Drawing.Color.Transparent;
            this.UnlockBL_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnlockBL_Label.Location = new System.Drawing.Point(9, 44);
            this.UnlockBL_Label.Margin = new System.Windows.Forms.Padding(0);
            this.UnlockBL_Label.Name = "UnlockBL_Label";
            this.UnlockBL_Label.Size = new System.Drawing.Size(268, 38);
            this.UnlockBL_Label.TabIndex = 7;
            this.UnlockBL_Label.Text = "Check fastboot status then attempt to unlock\nyour device bootloader";
            // 
            // MagiskRoot_Label
            // 
            this.MagiskRoot_Label.BackColor = System.Drawing.Color.Transparent;
            this.MagiskRoot_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MagiskRoot_Label.Location = new System.Drawing.Point(9, 219);
            this.MagiskRoot_Label.Name = "MagiskRoot_Label";
            this.MagiskRoot_Label.Size = new System.Drawing.Size(248, 38);
            this.MagiskRoot_Label.TabIndex = 7;
            this.MagiskRoot_Label.Text = "Download the latest Magisk zip and apk \r\nthen attempt to install them";
            // 
            // MagiskRoot_PictureBox
            // 
            this.MagiskRoot_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.MagiskRoot_PictureBox.Image = global::prop.xXX.Magisk_gray_alpha;
            this.MagiskRoot_PictureBox.Location = new System.Drawing.Point(238, 220);
            this.MagiskRoot_PictureBox.Name = "MagiskRoot_PictureBox";
            this.MagiskRoot_PictureBox.Size = new System.Drawing.Size(128, 128);
            this.MagiskRoot_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MagiskRoot_PictureBox.TabIndex = 5;
            this.MagiskRoot_PictureBox.TabStop = false;
            // 
            // UnlockBL_PictureBox
            // 
            this.UnlockBL_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.UnlockBL_PictureBox.Image = global::prop.xXX.UnlockBL_gray_alpha;
            this.UnlockBL_PictureBox.Location = new System.Drawing.Point(238, 37);
            this.UnlockBL_PictureBox.Name = "UnlockBL_PictureBox";
            this.UnlockBL_PictureBox.Size = new System.Drawing.Size(128, 128);
            this.UnlockBL_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UnlockBL_PictureBox.TabIndex = 5;
            this.UnlockBL_PictureBox.TabStop = false;
            // 
            // MagiskRoot_Title
            // 
            this.MagiskRoot_Title.BackColor = System.Drawing.Color.Transparent;
            this.MagiskRoot_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MagiskRoot_Title.Location = new System.Drawing.Point(9, 185);
            this.MagiskRoot_Title.Name = "MagiskRoot_Title";
            this.MagiskRoot_Title.Size = new System.Drawing.Size(131, 21);
            this.MagiskRoot_Title.TabIndex = 2;
            this.MagiskRoot_Title.Text = "Root with Magisk";
            // 
            // UnlockBL_Title
            // 
            this.UnlockBL_Title.BackColor = System.Drawing.Color.Transparent;
            this.UnlockBL_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnlockBL_Title.Location = new System.Drawing.Point(9, 13);
            this.UnlockBL_Title.Name = "UnlockBL_Title";
            this.UnlockBL_Title.Size = new System.Drawing.Size(138, 21);
            this.UnlockBL_Title.TabIndex = 2;
            this.UnlockBL_Title.Text = "Unlock Bootloader";
            // 
            // MagiskRoot_Button
            // 
            this.MagiskRoot_Button.Depth = 0;
            this.MagiskRoot_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MagiskRoot_Button.Icon = null;
            this.MagiskRoot_Button.Location = new System.Drawing.Point(9, 295);
            this.MagiskRoot_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MagiskRoot_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.MagiskRoot_Button.Name = "MagiskRoot_Button";
            this.MagiskRoot_Button.Primary = false;
            this.MagiskRoot_Button.Size = new System.Drawing.Size(222, 36);
            this.MagiskRoot_Button.TabIndex = 6;
            this.MagiskRoot_Button.Text = "Start Rooting";
            this.MagiskRoot_Button.TextAlignment = System.Drawing.StringAlignment.Near;
            this.MagiskRoot_Button.UseVisualStyleBackColor = false;
            // 
            // MaterialDivider1
            // 
            this.MaterialDivider1.BackColor = System.Drawing.Color.Gainsboro;
            this.MaterialDivider1.Depth = 0;
            this.MaterialDivider1.Location = new System.Drawing.Point(2, 171);
            this.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialDivider1.Name = "MaterialDivider1";
            this.MaterialDivider1.Size = new System.Drawing.Size(363, 1);
            this.MaterialDivider1.TabIndex = 3;
            this.MaterialDivider1.Text = "MaterialDivider1";
            // 
            // UnlockBL_Button
            // 
            this.UnlockBL_Button.Depth = 0;
            this.UnlockBL_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UnlockBL_Button.Icon = null;
            this.UnlockBL_Button.Location = new System.Drawing.Point(9, 112);
            this.UnlockBL_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UnlockBL_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.UnlockBL_Button.Name = "UnlockBL_Button";
            this.UnlockBL_Button.Primary = false;
            this.UnlockBL_Button.Size = new System.Drawing.Size(222, 36);
            this.UnlockBL_Button.TabIndex = 6;
            this.UnlockBL_Button.Text = "Start Unlocking";
            this.UnlockBL_Button.TextAlignment = System.Drawing.StringAlignment.Near;
            this.UnlockBL_Button.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.FlashZip_ChooseFile_Button);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.Button1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.Button2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.Button3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.Button4);
            this.groupBox1.Location = new System.Drawing.Point(48, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 178);
            this.groupBox1.TabIndex = 85595;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(73, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 25);
            this.textBox1.TabIndex = 85594;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(73, 146);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(198, 25);
            this.textBox5.TabIndex = 85594;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(164)))), ((int)(((byte)(50)))));
            this.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Image = global::prop.x24.OpenFile_24_noBG;
            this.Button1.Location = new System.Drawing.Point(270, 113);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(25, 25);
            this.Button1.TabIndex = 85585;
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(73, 113);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(197, 25);
            this.textBox4.TabIndex = 85594;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(164)))), ((int)(((byte)(50)))));
            this.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Image = global::prop.x24.OpenFile_24_noBG;
            this.Button2.Location = new System.Drawing.Point(270, 47);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(25, 25);
            this.Button2.TabIndex = 85587;
            this.Button2.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(73, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 25);
            this.textBox3.TabIndex = 85594;
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(164)))), ((int)(((byte)(50)))));
            this.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Image = global::prop.x24.OpenFile_24_noBG;
            this.Button3.Location = new System.Drawing.Point(270, 80);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(25, 25);
            this.Button3.TabIndex = 85589;
            this.Button3.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(73, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 25);
            this.textBox2.TabIndex = 85594;
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(164)))), ((int)(((byte)(50)))));
            this.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button4.FlatAppearance.BorderSize = 0;
            this.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Image = global::prop.x24.OpenFile_24_noBG;
            this.Button4.Location = new System.Drawing.Point(270, 146);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(25, 25);
            this.Button4.TabIndex = 85591;
            this.Button4.UseVisualStyleBackColor = false;
            // 
            // PictureBox3
            // 
            this.PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox3.Image = global::prop.xXX.FlashZip_gray_alpha;
            this.PictureBox3.Location = new System.Drawing.Point(241, 223);
            this.PictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(128, 128);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox3.TabIndex = 5;
            this.PictureBox3.TabStop = false;
            // 
            // InstallBusybox_Button
            // 
            this.InstallBusybox_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InstallBusybox_Button.BackColor = System.Drawing.Color.Transparent;
            this.InstallBusybox_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InstallBusybox_Button.Highlight = true;
            this.InstallBusybox_Button.Location = new System.Drawing.Point(22, 62);
            this.InstallBusybox_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.InstallBusybox_Button.Name = "InstallBusybox_Button";
            this.InstallBusybox_Button.Size = new System.Drawing.Size(172, 36);
            this.InstallBusybox_Button.Style = MetroFramework.MetroColorStyle.Green;
            this.InstallBusybox_Button.TabIndex = 9;
            this.InstallBusybox_Button.Text = "Install Busybox";
            this.InstallBusybox_Button.UseSelectable = true;
            this.InstallBusybox_Button.UseVisualStyleBackColor = false;
            // 
            // HotReboot_Button
            // 
            this.HotReboot_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HotReboot_Button.BackColor = System.Drawing.Color.Transparent;
            this.HotReboot_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HotReboot_Button.Highlight = true;
            this.HotReboot_Button.Location = new System.Drawing.Point(22, 14);
            this.HotReboot_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.HotReboot_Button.Name = "HotReboot_Button";
            this.HotReboot_Button.Size = new System.Drawing.Size(172, 36);
            this.HotReboot_Button.Style = MetroFramework.MetroColorStyle.Green;
            this.HotReboot_Button.TabIndex = 8;
            this.HotReboot_Button.Text = "Hot Reboot";
            this.HotReboot_Button.UseSelectable = true;
            this.HotReboot_Button.UseVisualStyleBackColor = false;
            // 
            // GA_About_Label
            // 
            this.GA_About_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GA_About_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GA_About_Label.Location = new System.Drawing.Point(112, 74);
            this.GA_About_Label.Name = "GA_About_Label";
            this.GA_About_Label.Size = new System.Drawing.Size(180, 19);
            this.GA_About_Label.TabIndex = 85611;
            this.GA_About_Label.Text = "vX.x #Beta  - By NHKomaiha.";
            // 
            // PictureBox4
            // 
            this.PictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox4.Location = new System.Drawing.Point(0, 0);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(677, 599);
            this.PictureBox4.TabIndex = 85613;
            this.PictureBox4.TabStop = false;
            // 
            // SwitchTheme_UI
            // 
            this.SwitchTheme_UI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SwitchTheme_UI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SwitchTheme_UI.Location = new System.Drawing.Point(-6, 601);
            this.SwitchTheme_UI.Name = "SwitchTheme_UI";
            this.SwitchTheme_UI.Size = new System.Drawing.Size(1184, 929);
            this.SwitchTheme_UI.TabIndex = 85614;
            this.SwitchTheme_UI.TabStop = false;
            // 
            // GeekAssistant_Icon
            // 
            this.GeekAssistant_Icon.Image = global::prop.GA.G_noG;
            this.GeekAssistant_Icon.Location = new System.Drawing.Point(24, 22);
            this.GeekAssistant_Icon.Name = "GeekAssistant_Icon";
            this.GeekAssistant_Icon.Size = new System.Drawing.Size(70, 69);
            this.GeekAssistant_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GeekAssistant_Icon.TabIndex = 85615;
            this.GeekAssistant_Icon.TabStop = false;
            // 
            // bar
            // 
            this.bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bar.Location = new System.Drawing.Point(24, 538);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(626, 48);
            this.bar.Style = MetroFramework.MetroColorStyle.Green;
            this.bar.TabIndex = 85612;
            this.bar.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ShowLog_ErrorBlink_Timer
            // 
            this.ShowLog_ErrorBlink_Timer.Interval = 700;
            // 
            // ShowLog_InfoBlink_Timer
            // 
            this.ShowLog_InfoBlink_Timer.Interval = 700;
            // 
            // SettingsSave_Timer
            // 
            this.SettingsSave_Timer.Interval = 1000;
            // 
            // AutoDetectFlash_Timer_Deprecated
            // 
            this.AutoDetectFlash_Timer_Deprecated.Interval = 650;
            // 
            // Wait_PostDelay_adbDetect
            // 
            this.Wait_PostDelay_adbDetect.Interval = 200;
            // 
            // Main_ToolTip
            // 
            this.Main_ToolTip.Active = false;
            this.Main_ToolTip.AutomaticDelay = 1000;
            this.Main_ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Unavalable_Tooltip
            // 
            this.Unavalable_Tooltip.AutomaticDelay = 0;
            this.Unavalable_Tooltip.AutoPopDelay = 10000;
            this.Unavalable_Tooltip.InitialDelay = 0;
            this.Unavalable_Tooltip.ReshowDelay = 0;
            this.Unavalable_Tooltip.StripAmpersands = true;
            this.Unavalable_Tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DeviceState_Label, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DeviceStateTitle_Label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Manufacturer_Title_Label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Manufacturer_Label, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.AndroidVersion_Title_Label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.AndroidVersion_Label, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BootloaderUnlockable_Title_Label, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.BootloaderUnlockable_Label, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Rooted_Title_Label, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Rooted_Label, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.CustomRecovery_Title_Label, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.CustomRecovery_Label, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.CustomROM_Title_Label, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.CustomROM_Label, 1, 7);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 191);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(243, 262);
            this.tableLayoutPanel1.TabIndex = 85619;
            // 
            // Manufacturer_Title_Label
            // 
            this.Manufacturer_Title_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Manufacturer_Title_Label.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Manufacturer_Title_Label.Location = new System.Drawing.Point(3, 65);
            this.Manufacturer_Title_Label.Name = "Manufacturer_Title_Label";
            this.Manufacturer_Title_Label.Size = new System.Drawing.Size(94, 32);
            this.Manufacturer_Title_Label.TabIndex = 85598;
            this.Manufacturer_Title_Label.Text = "Manufacturer";
            this.Manufacturer_Title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Manufacturer_Label
            // 
            this.Manufacturer_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Manufacturer_Label.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Manufacturer_Label.Location = new System.Drawing.Point(103, 65);
            this.Manufacturer_Label.Name = "Manufacturer_Label";
            this.Manufacturer_Label.Size = new System.Drawing.Size(137, 32);
            this.Manufacturer_Label.TabIndex = 85599;
            this.Manufacturer_Label.Text = "N/A";
            this.Manufacturer_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AndroidVersion_Title_Label
            // 
            this.AndroidVersion_Title_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AndroidVersion_Title_Label.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AndroidVersion_Title_Label.Location = new System.Drawing.Point(3, 97);
            this.AndroidVersion_Title_Label.Name = "AndroidVersion_Title_Label";
            this.AndroidVersion_Title_Label.Size = new System.Drawing.Size(94, 32);
            this.AndroidVersion_Title_Label.TabIndex = 85600;
            this.AndroidVersion_Title_Label.Text = "Android Version";
            this.AndroidVersion_Title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AndroidVersion_Label
            // 
            this.AndroidVersion_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AndroidVersion_Label.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AndroidVersion_Label.Location = new System.Drawing.Point(103, 97);
            this.AndroidVersion_Label.Name = "AndroidVersion_Label";
            this.AndroidVersion_Label.Size = new System.Drawing.Size(137, 32);
            this.AndroidVersion_Label.TabIndex = 85601;
            this.AndroidVersion_Label.Text = "N/A";
            this.AndroidVersion_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BootloaderUnlockable_Title_Label
            // 
            this.BootloaderUnlockable_Title_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BootloaderUnlockable_Title_Label.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BootloaderUnlockable_Title_Label.Location = new System.Drawing.Point(3, 129);
            this.BootloaderUnlockable_Title_Label.Name = "BootloaderUnlockable_Title_Label";
            this.BootloaderUnlockable_Title_Label.Size = new System.Drawing.Size(94, 32);
            this.BootloaderUnlockable_Title_Label.TabIndex = 85602;
            this.BootloaderUnlockable_Title_Label.Text = "Bootloader Unlockable";
            this.BootloaderUnlockable_Title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BootloaderUnlockable_Label
            // 
            this.BootloaderUnlockable_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BootloaderUnlockable_Label.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BootloaderUnlockable_Label.Location = new System.Drawing.Point(103, 129);
            this.BootloaderUnlockable_Label.Name = "BootloaderUnlockable_Label";
            this.BootloaderUnlockable_Label.Size = new System.Drawing.Size(137, 32);
            this.BootloaderUnlockable_Label.TabIndex = 85603;
            this.BootloaderUnlockable_Label.Text = "N/A";
            this.BootloaderUnlockable_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Rooted_Title_Label
            // 
            this.Rooted_Title_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rooted_Title_Label.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rooted_Title_Label.Location = new System.Drawing.Point(3, 161);
            this.Rooted_Title_Label.Name = "Rooted_Title_Label";
            this.Rooted_Title_Label.Size = new System.Drawing.Size(94, 32);
            this.Rooted_Title_Label.TabIndex = 85604;
            this.Rooted_Title_Label.Text = "Rooted";
            this.Rooted_Title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Rooted_Label
            // 
            this.Rooted_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rooted_Label.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rooted_Label.Location = new System.Drawing.Point(103, 161);
            this.Rooted_Label.Name = "Rooted_Label";
            this.Rooted_Label.Size = new System.Drawing.Size(137, 32);
            this.Rooted_Label.TabIndex = 85605;
            this.Rooted_Label.Text = "N/A";
            this.Rooted_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomRecovery_Title_Label
            // 
            this.CustomRecovery_Title_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomRecovery_Title_Label.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomRecovery_Title_Label.Location = new System.Drawing.Point(3, 225);
            this.CustomRecovery_Title_Label.Name = "CustomRecovery_Title_Label";
            this.CustomRecovery_Title_Label.Size = new System.Drawing.Size(94, 37);
            this.CustomRecovery_Title_Label.TabIndex = 85606;
            this.CustomRecovery_Title_Label.Text = "Custom Recovery";
            this.CustomRecovery_Title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomRecovery_Label
            // 
            this.CustomRecovery_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomRecovery_Label.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomRecovery_Label.Location = new System.Drawing.Point(103, 225);
            this.CustomRecovery_Label.Name = "CustomRecovery_Label";
            this.CustomRecovery_Label.Size = new System.Drawing.Size(137, 37);
            this.CustomRecovery_Label.TabIndex = 85607;
            this.CustomRecovery_Label.Text = "N/A";
            this.CustomRecovery_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomROM_Title_Label
            // 
            this.CustomROM_Title_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomROM_Title_Label.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomROM_Title_Label.Location = new System.Drawing.Point(3, 193);
            this.CustomROM_Title_Label.Name = "CustomROM_Title_Label";
            this.CustomROM_Title_Label.Size = new System.Drawing.Size(94, 32);
            this.CustomROM_Title_Label.TabIndex = 85608;
            this.CustomROM_Title_Label.Text = "Custom System";
            this.CustomROM_Title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomROM_Label
            // 
            this.CustomROM_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomROM_Label.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomROM_Label.Location = new System.Drawing.Point(103, 193);
            this.CustomROM_Label.Name = "CustomROM_Label";
            this.CustomROM_Label.Size = new System.Drawing.Size(137, 32);
            this.CustomROM_Label.TabIndex = 85609;
            this.CustomROM_Label.Text = "N/A";
            this.CustomROM_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Home_Tabs
            // 
            this.Home_Tabs.Controls.Add(this.Prepare_Tab);
            this.Home_Tabs.Controls.Add(this.Flash_Tab);
            this.Home_Tabs.Controls.Add(this.More_Tab);
            this.Home_Tabs.Depth = 0;
            this.Home_Tabs.Location = new System.Drawing.Point(273, 153);
            this.Home_Tabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.Home_Tabs.Name = "Home_Tabs";
            this.Home_Tabs.SelectedIndex = 0;
            this.Home_Tabs.Size = new System.Drawing.Size(377, 379);
            this.Home_Tabs.TabIndex = 85620;
            // 
            // Prepare_Tab
            // 
            this.Prepare_Tab.BackColor = System.Drawing.Color.White;
            this.Prepare_Tab.Controls.Add(this.UnlockBL_Title);
            this.Prepare_Tab.Controls.Add(this.UnlockBL_Button);
            this.Prepare_Tab.Controls.Add(this.UnlockBL_Label);
            this.Prepare_Tab.Controls.Add(this.MaterialDivider1);
            this.Prepare_Tab.Controls.Add(this.MagiskRoot_Label);
            this.Prepare_Tab.Controls.Add(this.MagiskRoot_Button);
            this.Prepare_Tab.Controls.Add(this.MagiskRoot_PictureBox);
            this.Prepare_Tab.Controls.Add(this.MagiskRoot_Title);
            this.Prepare_Tab.Controls.Add(this.UnlockBL_PictureBox);
            this.Prepare_Tab.Location = new System.Drawing.Point(4, 24);
            this.Prepare_Tab.Name = "Prepare_Tab";
            this.Prepare_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Prepare_Tab.Size = new System.Drawing.Size(369, 351);
            this.Prepare_Tab.TabIndex = 0;
            this.Prepare_Tab.Text = "Prepare";
            // 
            // Flash_Tab
            // 
            this.Flash_Tab.BackColor = System.Drawing.Color.White;
            this.Flash_Tab.Controls.Add(this.PictureBox3);
            this.Flash_Tab.Controls.Add(this.FlashZip_Button);
            this.Flash_Tab.Controls.Add(this.groupBox1);
            this.Flash_Tab.Controls.Add(this.FlashZip_RebootWhenComplete_Checkbox);
            this.Flash_Tab.Controls.Add(this.FlashZip_Title);
            this.Flash_Tab.Location = new System.Drawing.Point(4, 24);
            this.Flash_Tab.Name = "Flash_Tab";
            this.Flash_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Flash_Tab.Size = new System.Drawing.Size(369, 351);
            this.Flash_Tab.TabIndex = 1;
            this.Flash_Tab.Text = "Flash";
            // 
            // More_Tab
            // 
            this.More_Tab.Controls.Add(this.InstallBusybox_Button);
            this.More_Tab.Controls.Add(this.HotReboot_Button);
            this.More_Tab.Controls.Add(this.debuggingBox);
            this.More_Tab.Location = new System.Drawing.Point(4, 24);
            this.More_Tab.Name = "More_Tab";
            this.More_Tab.Size = new System.Drawing.Size(369, 351);
            this.More_Tab.TabIndex = 0;
            this.More_Tab.Text = "More";
            this.More_Tab.UseVisualStyleBackColor = true;
            // 
            // debuggingBox
            // 
            this.debuggingBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.debuggingBox.BackColor = System.Drawing.Color.Transparent;
            this.debuggingBox.Controls.Add(this.MetroButton4);
            this.debuggingBox.Controls.Add(this.MetroButton8);
            this.debuggingBox.Controls.Add(this.MetroButton7);
            this.debuggingBox.Controls.Add(this.MetroButton6);
            this.debuggingBox.Controls.Add(this.MetroButton11);
            this.debuggingBox.Controls.Add(this.MetroButton3);
            this.debuggingBox.Controls.Add(this.MetroButton2);
            this.debuggingBox.Controls.Add(this.MetroButton1);
            this.debuggingBox.Location = new System.Drawing.Point(3, 143);
            this.debuggingBox.Name = "debuggingBox";
            this.debuggingBox.Size = new System.Drawing.Size(363, 198);
            this.debuggingBox.TabIndex = 10;
            this.debuggingBox.TabStop = false;
            this.debuggingBox.Text = "Super dooper debugging (Visible in vX.x.x.3)";
            // 
            // MetroButton4
            // 
            this.MetroButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroButton4.Location = new System.Drawing.Point(6, 203);
            this.MetroButton4.Name = "MetroButton4";
            this.MetroButton4.Size = new System.Drawing.Size(224, 26);
            this.MetroButton4.TabIndex = 9;
            this.MetroButton4.Text = "web log";
            this.MetroButton4.UseSelectable = true;
            // 
            // MetroButton8
            // 
            this.MetroButton8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroButton8.Location = new System.Drawing.Point(6, 84);
            this.MetroButton8.Name = "MetroButton8";
            this.MetroButton8.Size = new System.Drawing.Size(224, 26);
            this.MetroButton8.TabIndex = 8;
            this.MetroButton8.Text = "Terminate Bridge";
            this.MetroButton8.UseSelectable = true;
            // 
            // MetroButton7
            // 
            this.MetroButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroButton7.Location = new System.Drawing.Point(160, 52);
            this.MetroButton7.Name = "MetroButton7";
            this.MetroButton7.Size = new System.Drawing.Size(70, 26);
            this.MetroButton7.TabIndex = 7;
            this.MetroButton7.Text = "false";
            this.MetroButton7.UseSelectable = true;
            // 
            // MetroButton6
            // 
            this.MetroButton6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroButton6.Location = new System.Drawing.Point(6, 52);
            this.MetroButton6.Name = "MetroButton6";
            this.MetroButton6.Size = new System.Drawing.Size(148, 26);
            this.MetroButton6.TabIndex = 6;
            this.MetroButton6.Text = "CreateBridge start true";
            this.MetroButton6.UseSelectable = true;
            // 
            // MetroButton11
            // 
            this.MetroButton11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroButton11.Location = new System.Drawing.Point(160, 20);
            this.MetroButton11.Name = "MetroButton11";
            this.MetroButton11.Size = new System.Drawing.Size(70, 26);
            this.MetroButton11.TabIndex = 5;
            this.MetroButton11.Text = "false";
            this.MetroButton11.UseSelectable = true;
            // 
            // MetroButton3
            // 
            this.MetroButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroButton3.Location = new System.Drawing.Point(6, 148);
            this.MetroButton3.Name = "MetroButton3";
            this.MetroButton3.Size = new System.Drawing.Size(224, 26);
            this.MetroButton3.TabIndex = 2;
            this.MetroButton3.Text = "State";
            this.MetroButton3.UseSelectable = true;
            // 
            // MetroButton2
            // 
            this.MetroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroButton2.Location = new System.Drawing.Point(6, 116);
            this.MetroButton2.Name = "MetroButton2";
            this.MetroButton2.Size = new System.Drawing.Size(224, 26);
            this.MetroButton2.TabIndex = 1;
            this.MetroButton2.Text = "Count";
            this.MetroButton2.UseSelectable = true;
            // 
            // MetroButton1
            // 
            this.MetroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroButton1.Location = new System.Drawing.Point(6, 20);
            this.MetroButton1.Name = "MetroButton1";
            this.MetroButton1.Size = new System.Drawing.Size(148, 26);
            this.MetroButton1.TabIndex = 0;
            this.MetroButton1.Text = "CreateBridge true";
            this.MetroButton1.UseSelectable = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.Home_Tabs;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(273, 122);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(377, 31);
            this.materialTabSelector1.TabIndex = 85621;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // SwitchTheme_Light_UI_Icon
            // 
            this.SwitchTheme_Light_UI_Icon.Image = global::prop.x64.Theme_light_64;
            this.SwitchTheme_Light_UI_Icon.Location = new System.Drawing.Point(738, 601);
            this.SwitchTheme_Light_UI_Icon.Margin = new System.Windows.Forms.Padding(0);
            this.SwitchTheme_Light_UI_Icon.Name = "SwitchTheme_Light_UI_Icon";
            this.SwitchTheme_Light_UI_Icon.Size = new System.Drawing.Size(64, 64);
            this.SwitchTheme_Light_UI_Icon.TabIndex = 85622;
            this.SwitchTheme_Light_UI_Icon.TabStop = false;
            // 
            // SwitchTheme_Dark_UI_Icon
            // 
            this.SwitchTheme_Dark_UI_Icon.Image = global::prop.x64.Theme_dark_64;
            this.SwitchTheme_Dark_UI_Icon.Location = new System.Drawing.Point(776, 601);
            this.SwitchTheme_Dark_UI_Icon.Margin = new System.Windows.Forms.Padding(0);
            this.SwitchTheme_Dark_UI_Icon.Name = "SwitchTheme_Dark_UI_Icon";
            this.SwitchTheme_Dark_UI_Icon.Size = new System.Drawing.Size(64, 64);
            this.SwitchTheme_Dark_UI_Icon.TabIndex = 85622;
            this.SwitchTheme_Dark_UI_Icon.TabStop = false;
            // 
            // manualCMD_TextBox
            // 
            this.manualCMD_TextBox.Depth = 0;
            this.manualCMD_TextBox.Hint = "Type your own adb or fastboot command here";
            this.manualCMD_TextBox.Location = new System.Drawing.Point(689, 557);
            this.manualCMD_TextBox.MaxLength = 32767;
            this.manualCMD_TextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.manualCMD_TextBox.Name = "manualCMD_TextBox";
            this.manualCMD_TextBox.PasswordChar = '\0';
            this.manualCMD_TextBox.SelectedText = "";
            this.manualCMD_TextBox.SelectionLength = 0;
            this.manualCMD_TextBox.SelectionStart = 0;
            this.manualCMD_TextBox.Size = new System.Drawing.Size(383, 23);
            this.manualCMD_TextBox.TabIndex = 85623;
            this.manualCMD_TextBox.TabStop = false;
            this.manualCMD_TextBox.UseSystemPasswordChar = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1174, 599);
            this.Controls.Add(this.SwitchTheme_Light_UI_Icon);
            this.Controls.Add(this.SwitchTheme_Dark_UI_Icon);
            this.Controls.Add(this.SwitchTheme_UI);
            this.Controls.Add(this.AutoDetectDeviceInfo_Button);
            this.Controls.Add(this.manualCMD_TextBox);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.Home_Tabs);
            this.Controls.Add(this.Toggle_ManualDeviceInfo_Button);
            this.Controls.Add(this.ManualInfo_GroupBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ShowLog_Button);
            this.Controls.Add(this.ProgressBarLabel);
            this.Controls.Add(this.ProgressFakeBG_UI);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.Donate_Button);
            this.Controls.Add(this.GeekAssistant_Icon);
            this.Controls.Add(this.GA_About_Label);
            this.Controls.Add(this.Main_Tabs_old);
            this.Controls.Add(this.About_Button);
            this.Controls.Add(this.SwitchTheme_Button);
            this.Controls.Add(this.Feedback_Button);
            this.Controls.Add(this.Settings_Button);
            this.Controls.Add(this.GeekAssistant);
            this.Controls.Add(this.MainLayout_PictureBox);
            this.Controls.Add(this.PictureBox4);
            this.Controls.Add(this.OpenLogFolder);
            this.Controls.Add(this.CopyLogToClipboard);
            this.Controls.Add(this.ClearLog_Button);
            this.Controls.Add(this.log_TextBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1190, 672);
            this.MinimumSize = new System.Drawing.Size(690, 638);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geek Assistant";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Load += new System.EventHandler(this.Home_Load);
            this.ManualInfo_GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GeekAssistant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainLayout_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressFakeBG_UI)).EndInit();
            this.Main_Tabs_old.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MagiskRoot_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnlockBL_PictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchTheme_UI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeekAssistant_Icon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Home_Tabs.ResumeLayout(false);
            this.Prepare_Tab.ResumeLayout(false);
            this.Flash_Tab.ResumeLayout(false);
            this.Flash_Tab.PerformLayout();
            this.More_Tab.ResumeLayout(false);
            this.debuggingBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SwitchTheme_Light_UI_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchTheme_Dark_UI_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public GeekAssistant.Controls.Material.FlatButton Toggle_ManualDeviceInfo_Button;
        public Button OpenLogFolder;
        public OpenFileDialog FlashZip_OpenFileDialog;
        public GroupBox ManualInfo_GroupBox;
        public Label DeviceStateTitle_Label;
        public GeekAssistant.Controls.Material.FlatButton About_Button;
        public CheckBox FlashZip_RebootWhenComplete_Checkbox;
        public Button AutoDetectDeviceInfo_Button;
        public Button ClearLog_Button;
        public Label FlashZip_Title;
        public Button CopyLogToClipboard;
        public PictureBox GeekAssistant;
        public TextBox log_TextBox;
        public GeekAssistant.Controls.Material.FlatButton Feedback_Button;
        public Button Settings;
        public PictureBox MainLayout_PictureBox;
        public GeekAssistant.Controls.Material.FlatButton Settings_Button;
        public GeekAssistant.Controls.Material.FlatButton FlashZip_Button;
        public GeekAssistant.Controls.Material.FlatButton ShowLog_Button;
        public PictureBox ProgressFakeBG_UI;
        public MetroTabControl Main_Tabs_old;
        public MetroTabPage PrepareYourDevice_Tab_old;
        public MetroTabPage FlashImg_Tab_old;
        public Label UnlockBL_Title;
        public Label MagiskRoot_Title;
        public MetroComboBox Manufacturer_ComboBox;
        public CheckBox BootloaderUnlockable_CheckBox;
        public MetroComboBox AndroidVersion_ComboBox;
        public CheckBox CustomRecovery_CheckBox;
        public CheckBox CustomROM_CheckBox;
        public Label ProgressBarLabel;
        public Label GA_About_Label;
        public MaterialSkin.Controls.MaterialDivider MaterialDivider1;
        public MetroTabPage MoreTools_Tab_old;
        public PictureBox MagiskRoot_PictureBox;
        public PictureBox UnlockBL_PictureBox;
        public ToolTip Main_ToolTip;
        public GeekAssistant.Controls.Material.FlatButton UnlockBL_Button;
        public GeekAssistant.Controls.Material.FlatButton MagiskRoot_Button;
        public Label UnlockBL_Label;
        public Label MagiskRoot_Label;
        public PictureBox PictureBox3;
        public MetroProgressBar ProgressBar;
        public PictureBox PictureBox4;
        public GeekAssistant.Controls.Material.FlatButton SwitchTheme_Button;
        public Button FlashZip_ChooseFile_Button;
        public Label DeviceState_Label;
        public PictureBox GeekAssistant_Icon;
        public PictureBox SwitchTheme_UI;
        public CheckBox Rooted_Checkbox;
        public GeekAssistant.Controls.Material.FlatButton Donate_Button;
        public MetroButton HotReboot_Button;
        public MetroButton InstallBusybox_Button;
        public Button Button4;
        public MetroTextBox MetroTextBox4;
        public Button Button3;
        public MetroTextBox MetroTextBox3;
        public Button Button2;
        public MetroTextBox MetroTextBox2;
        public Button Button1;
        public MetroTextBox MetroTextBox1;
        public MetroTextBox MetroTextBox5;
        public MetroProgressBar bar;
        public Timer ShowLog_ErrorBlink_Timer;
        public Timer ShowLog_InfoBlink_Timer;
        public Timer AutoDetectFlash_Timer_Deprecated;
        public Timer Wait_PostDelay_adbDetect;
        public Timer SettingsSave_Timer;
        public ToolTip Unavalable_Tooltip;
        public TextBox textBox1;
        public GroupBox groupBox1;
        public TextBox textBox5;
        public TextBox textBox4;
        public TextBox textBox3;
        public TextBox textBox2;
        public TableLayoutPanel tableLayoutPanel1;
        public Label Manufacturer_Title_Label;
        public Label Manufacturer_Label;
        public Label AndroidVersion_Title_Label;
        public Label AndroidVersion_Label;
        public Label BootloaderUnlockable_Title_Label;
        public Label BootloaderUnlockable_Label;
        public Label Rooted_Title_Label;
        public Label Rooted_Label;
        public Label CustomRecovery_Label;
        public Label CustomROM_Title_Label;
        public Label CustomROM_Label;
        public Label CustomRecovery_Title_Label;
        public GroupBox debuggingBox;
        public MetroButton MetroButton4;
        public MetroButton MetroButton8;
        public MetroButton MetroButton7;
        public MetroButton MetroButton6;
        public MetroButton MetroButton11;
        public MetroButton MetroButton3;
        public MetroButton MetroButton2;
        public MetroButton MetroButton1;
        public MaterialSkin.Controls.MaterialTabControl Home_Tabs;
        public TabPage Prepare_Tab;
        public TabPage Flash_Tab;
        public Controls.Material.TabSelector materialTabSelector1;
        public TabPage More_Tab;
        public PictureBox SwitchTheme_Light_UI_Icon;
        public PictureBox SwitchTheme_Dark_UI_Icon;
        private Controls.Material.MaterialTextBox manualCMD_TextBox;
    }
}