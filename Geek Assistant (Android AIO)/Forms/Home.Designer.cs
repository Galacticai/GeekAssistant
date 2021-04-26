
using System.Windows.Forms;

namespace GeekAssistant.Forms {
    partial class Home : System.Windows.Forms.Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
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
            this.FlashZip_Button = new MetroFramework.Controls.MetroButton();
            this.About_Button = new MaterialSkin.Controls.MaterialFlatButton();
            this.Settings_Button = new MaterialSkin.Controls.MaterialFlatButton();
            this.Feedback_Button = new MaterialSkin.Controls.MaterialFlatButton();
            this.FlashZip_RebootWhenComplete_Checkbox = new System.Windows.Forms.CheckBox();
            this.AutoDetectDeviceInfo_Button = new System.Windows.Forms.Button();
            this.ClearLog_Button = new System.Windows.Forms.Button();
            this.FlashZip_Title = new System.Windows.Forms.Label();
            this.CopyLogToClipboard = new System.Windows.Forms.Button();
            this.GeekAssistant = new System.Windows.Forms.PictureBox();
            this.FlashZip_ChooseFile_Button = new System.Windows.Forms.Button();
            this.ShowLog_Button = new MaterialSkin.Controls.MaterialFlatButton();
            this.log = new System.Windows.Forms.TextBox();
            this.ProgressBarLabel = new MetroFramework.Controls.MetroLabel();
            this.SwitchTheme_Button = new MaterialSkin.Controls.MaterialFlatButton();
            this.Donate_Button = new MaterialSkin.Controls.MaterialFlatButton();
            this.MainLayout_PictureBox = new System.Windows.Forms.PictureBox();
            this.ProgressFakeBG_UI = new System.Windows.Forms.PictureBox();
            this.Main_Tabs = new MetroFramework.Controls.MetroTabControl();
            this.PrepareYourDevice_Tab = new MetroFramework.Controls.MetroTabPage();
            this.UnlockBL_Label = new MetroFramework.Controls.MetroLabel();
            this.MagiskRoot_Label = new MetroFramework.Controls.MetroLabel();
            this.MagiskRoot_PictureBox = new System.Windows.Forms.PictureBox();
            this.UnlockBL_PictureBox = new System.Windows.Forms.PictureBox();
            this.MagiskRoot_Title = new System.Windows.Forms.Label();
            this.UnlockBL_Title = new System.Windows.Forms.Label();
            this.MagiskRoot_Button = new MetroFramework.Controls.MetroButton();
            this.MaterialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.UnlockBL_Button = new MetroFramework.Controls.MetroButton();
            this.FlashImg_Tab = new MetroFramework.Controls.MetroTabPage();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.MoreTools_Tab = new MetroFramework.Controls.MetroTabPage();
            this.debuggingBox = new System.Windows.Forms.GroupBox();
            this.MetroButton4 = new MetroFramework.Controls.MetroButton();
            this.MetroButton8 = new MetroFramework.Controls.MetroButton();
            this.MetroButton7 = new MetroFramework.Controls.MetroButton();
            this.MetroButton6 = new MetroFramework.Controls.MetroButton();
            this.MetroButton11 = new MetroFramework.Controls.MetroButton();
            this.MetroButton3 = new MetroFramework.Controls.MetroButton();
            this.MetroButton2 = new MetroFramework.Controls.MetroButton();
            this.MetroButton1 = new MetroFramework.Controls.MetroButton();
            this.InstallBusybox_Button = new MetroFramework.Controls.MetroButton();
            this.HotReboot_Button = new MetroFramework.Controls.MetroButton();
            this.GA_About_Label = new MetroFramework.Controls.MetroLabel();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.SwitchTheme_Back_UI = new System.Windows.Forms.PictureBox();
            this.GeekAssistant_Icon = new System.Windows.Forms.PictureBox();
            this.SwitchTheme_Mid_UI = new System.Windows.Forms.PictureBox();
            this.SwitchTheme_Fore_UI = new System.Windows.Forms.PictureBox();
            this.bar = new MetroFramework.Controls.MetroProgressBar();
            this.ShowLog_ErrorBlink_Timer = new System.Windows.Forms.Timer(this.components);
            this.ShowLog_InfoBlink_Timer = new System.Windows.Forms.Timer(this.components);
            this.SettingsSave_Timer = new System.Windows.Forms.Timer(this.components);
            this.AutoDetectFlash_Timer_Deprecated = new System.Windows.Forms.Timer(this.components);
            this.PleaseWait_PostDelay_adbDetect = new System.Windows.Forms.Timer(this.components);
            this.Main_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Unavalable_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ManualInfo_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeekAssistant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainLayout_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressFakeBG_UI)).BeginInit();
            this.Main_Tabs.SuspendLayout();
            this.PrepareYourDevice_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MagiskRoot_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnlockBL_PictureBox)).BeginInit();
            this.FlashImg_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.MoreTools_Tab.SuspendLayout();
            this.debuggingBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchTheme_Back_UI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeekAssistant_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchTheme_Mid_UI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchTheme_Fore_UI)).BeginInit();
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
            // FlashZip_OpenFileDialog
            // 
            this.FlashZip_OpenFileDialog.DefaultExt = "zip";
            this.FlashZip_OpenFileDialog.Filter = "Zip files|*.zip";
            // 
            // CustomRecovery_CheckBox
            // 
            this.CustomRecovery_CheckBox.AutoSize = true;
            this.CustomRecovery_CheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomRecovery_CheckBox.Location = new System.Drawing.Point(20, 227);
            this.CustomRecovery_CheckBox.Name = "CustomRecovery_CheckBox";
            this.CustomRecovery_CheckBox.Size = new System.Drawing.Size(137, 21);
            this.CustomRecovery_CheckBox.TabIndex = 85598;
            this.CustomRecovery_CheckBox.Text = "* Custom Recovery";
            // 
            // CustomROM_CheckBox
            // 
            this.CustomROM_CheckBox.AutoSize = true;
            this.CustomROM_CheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomROM_CheckBox.Location = new System.Drawing.Point(20, 200);
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
            this.ManualInfo_GroupBox.Location = new System.Drawing.Point(24, 242);
            this.ManualInfo_GroupBox.Name = "ManualInfo_GroupBox";
            this.ManualInfo_GroupBox.Size = new System.Drawing.Size(243, 270);
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
            this.AndroidVersion_ComboBox.Location = new System.Drawing.Point(20, 92);
            this.AndroidVersion_ComboBox.Name = "AndroidVersion_ComboBox";
            this.AndroidVersion_ComboBox.Size = new System.Drawing.Size(199, 29);
            this.AndroidVersion_ComboBox.Style = MetroFramework.MetroColorStyle.Green;
            this.AndroidVersion_ComboBox.TabIndex = 85596;
            this.AndroidVersion_ComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.Manufacturer_ComboBox.Location = new System.Drawing.Point(20, 48);
            this.Manufacturer_ComboBox.Name = "Manufacturer_ComboBox";
            this.Manufacturer_ComboBox.Size = new System.Drawing.Size(199, 29);
            this.Manufacturer_ComboBox.Style = MetroFramework.MetroColorStyle.Green;
            this.Manufacturer_ComboBox.TabIndex = 85595;
            this.Manufacturer_ComboBox.Tag = "";
            this.Manufacturer_ComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Rooted_Checkbox
            // 
            this.Rooted_Checkbox.AutoSize = true;
            this.Rooted_Checkbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rooted_Checkbox.Location = new System.Drawing.Point(20, 173);
            this.Rooted_Checkbox.Name = "Rooted_Checkbox";
            this.Rooted_Checkbox.Size = new System.Drawing.Size(70, 21);
            this.Rooted_Checkbox.TabIndex = 85597;
            this.Rooted_Checkbox.Text = "Rooted";
            // 
            // BootloaderUnlockable_CheckBox
            // 
            this.BootloaderUnlockable_CheckBox.AutoSize = true;
            this.BootloaderUnlockable_CheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BootloaderUnlockable_CheckBox.Location = new System.Drawing.Point(20, 146);
            this.BootloaderUnlockable_CheckBox.Name = "BootloaderUnlockable_CheckBox";
            this.BootloaderUnlockable_CheckBox.Size = new System.Drawing.Size(158, 21);
            this.BootloaderUnlockable_CheckBox.TabIndex = 85597;
            this.BootloaderUnlockable_CheckBox.Text = "Bootloader unlockable";
            // 
            // DeviceState_Label
            // 
            this.DeviceState_Label.AutoSize = true;
            this.DeviceState_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeviceState_Label.ForeColor = System.Drawing.Color.Gray;
            this.DeviceState_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeviceState_Label.Location = new System.Drawing.Point(120, 206);
            this.DeviceState_Label.Name = "DeviceState_Label";
            this.DeviceState_Label.Size = new System.Drawing.Size(86, 17);
            this.DeviceState_Label.TabIndex = 85597;
            this.DeviceState_Label.Text = "Disconnected";
            // 
            // DeviceStateTitle_Label
            // 
            this.DeviceStateTitle_Label.AutoSize = true;
            this.DeviceStateTitle_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeviceStateTitle_Label.Location = new System.Drawing.Point(41, 206);
            this.DeviceStateTitle_Label.Name = "DeviceStateTitle_Label";
            this.DeviceStateTitle_Label.Size = new System.Drawing.Size(82, 17);
            this.DeviceStateTitle_Label.TabIndex = 85594;
            this.DeviceStateTitle_Label.Text = "Device State:";
            // 
            // FlashZip_Button
            // 
            this.FlashZip_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlashZip_Button.Highlight = true;
            this.FlashZip_Button.Location = new System.Drawing.Point(19, 303);
            this.FlashZip_Button.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.FlashZip_Button.Name = "FlashZip_Button";
            this.FlashZip_Button.Size = new System.Drawing.Size(160, 36);
            this.FlashZip_Button.Style = MetroFramework.MetroColorStyle.Green;
            this.FlashZip_Button.TabIndex = 85583;
            this.FlashZip_Button.Text = "Start Flashing";
            // 
            // About_Button
            // 
            this.About_Button.AutoSize = true;
            this.About_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.About_Button.BackColor = System.Drawing.Color.Transparent;
            this.About_Button.Depth = 0;
            this.About_Button.FlatAppearance.BorderSize = 0;
            this.About_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.About_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.About_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.About_Button.Icon = global::prop.x24.ToU_24;
            this.About_Button.Location = new System.Drawing.Point(518, 30);
            this.About_Button.Margin = new System.Windows.Forms.Padding(0);
            this.About_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.About_Button.Name = "About_Button";
            this.About_Button.Primary = true;
            this.About_Button.Size = new System.Drawing.Size(44, 36);
            this.About_Button.TabIndex = 85587;
            this.About_Button.UseVisualStyleBackColor = false;
            // 
            // Settings_Button
            // 
            this.Settings_Button.AutoSize = true;
            this.Settings_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Settings_Button.BackColor = System.Drawing.Color.Transparent;
            this.Settings_Button.Depth = 0;
            this.Settings_Button.FlatAppearance.BorderSize = 0;
            this.Settings_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Settings_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Settings_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Settings_Button.Icon = global::prop.x24.Settings_24;
            this.Settings_Button.Location = new System.Drawing.Point(562, 30);
            this.Settings_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Settings_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.Primary = true;
            this.Settings_Button.Size = new System.Drawing.Size(44, 36);
            this.Settings_Button.TabIndex = 85588;
            this.Settings_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Settings_Button.UseVisualStyleBackColor = false;
            // 
            // Feedback_Button
            // 
            this.Feedback_Button.AutoSize = true;
            this.Feedback_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Feedback_Button.BackColor = System.Drawing.Color.Transparent;
            this.Feedback_Button.Depth = 0;
            this.Feedback_Button.FlatAppearance.BorderSize = 0;
            this.Feedback_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Feedback_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Feedback_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Feedback_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Feedback_Button.Icon = global::prop.x24.Smile_24;
            this.Feedback_Button.Location = new System.Drawing.Point(474, 30);
            this.Feedback_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Feedback_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Feedback_Button.Name = "Feedback_Button";
            this.Feedback_Button.Primary = true;
            this.Feedback_Button.Size = new System.Drawing.Size(44, 36);
            this.Feedback_Button.TabIndex = 85589;
            this.Feedback_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Feedback_Button.UseVisualStyleBackColor = false;
            // 
            // FlashZip_RebootWhenComplete_Checkbox
            // 
            this.FlashZip_RebootWhenComplete_Checkbox.AutoSize = true;
            this.FlashZip_RebootWhenComplete_Checkbox.BackColor = System.Drawing.Color.Transparent;
            this.FlashZip_RebootWhenComplete_Checkbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlashZip_RebootWhenComplete_Checkbox.Location = new System.Drawing.Point(49, 274);
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
            this.FlashZip_Title.AutoSize = true;
            this.FlashZip_Title.BackColor = System.Drawing.Color.Transparent;
            this.FlashZip_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlashZip_Title.Location = new System.Drawing.Point(15, 19);
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
            this.FlashZip_ChooseFile_Button.Location = new System.Drawing.Point(269, 67);
            this.FlashZip_ChooseFile_Button.Name = "FlashZip_ChooseFile_Button";
            this.FlashZip_ChooseFile_Button.Size = new System.Drawing.Size(29, 27);
            this.FlashZip_ChooseFile_Button.TabIndex = 85580;
            this.FlashZip_ChooseFile_Button.UseVisualStyleBackColor = false;
            // 
            // ShowLog_Button
            // 
            this.ShowLog_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowLog_Button.AutoSize = true;
            this.ShowLog_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowLog_Button.Depth = 0;
            this.ShowLog_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ShowLog_Button.FlatAppearance.BorderSize = 0;
            this.ShowLog_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.ShowLog_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ShowLog_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowLog_Button.Icon = global::prop.x24.Commands_24;
            this.ShowLog_Button.Location = new System.Drawing.Point(600, 544);
            this.ShowLog_Button.Margin = new System.Windows.Forms.Padding(0);
            this.ShowLog_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowLog_Button.Name = "ShowLog_Button";
            this.ShowLog_Button.Primary = false;
            this.ShowLog_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowLog_Button.Size = new System.Drawing.Size(44, 36);
            this.ShowLog_Button.TabIndex = 85585;
            this.ShowLog_Button.Tag = " ";
            this.ShowLog_Button.UseVisualStyleBackColor = true;
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.BackColor = System.Drawing.Color.White;
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.log.ForeColor = System.Drawing.SystemColors.ControlText;
            this.log.Location = new System.Drawing.Point(683, 22);
            this.log.Margin = new System.Windows.Forms.Padding(5);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log.Size = new System.Drawing.Size(508, 525);
            this.log.TabIndex = 85590;
            this.log.Text = "Geek Assistant vX.x #Phase ©2021 By NHKomaiha.\n// hh:mm:ss.ff // Start //";
            // 
            // ProgressBarLabel
            // 
            this.ProgressBarLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgressBarLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ProgressBarLabel.Location = new System.Drawing.Point(38, 544);
            this.ProgressBarLabel.Name = "ProgressBarLabel";
            this.ProgressBarLabel.Size = new System.Drawing.Size(562, 36);
            this.ProgressBarLabel.Style = MetroFramework.MetroColorStyle.Green;
            this.ProgressBarLabel.TabIndex = 85610;
            this.ProgressBarLabel.Text = "Current process information will be written here. Click for more information >>";
            this.ProgressBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SwitchTheme_Button
            // 
            this.SwitchTheme_Button.AutoSize = true;
            this.SwitchTheme_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SwitchTheme_Button.BackColor = System.Drawing.Color.Transparent;
            this.SwitchTheme_Button.Depth = 0;
            this.SwitchTheme_Button.FlatAppearance.BorderSize = 0;
            this.SwitchTheme_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SwitchTheme_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SwitchTheme_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SwitchTheme_Button.Icon = global::prop.x24.Theme_Light_24;
            this.SwitchTheme_Button.Location = new System.Drawing.Point(430, 30);
            this.SwitchTheme_Button.Margin = new System.Windows.Forms.Padding(0);
            this.SwitchTheme_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwitchTheme_Button.Name = "SwitchTheme_Button";
            this.SwitchTheme_Button.Primary = false;
            this.SwitchTheme_Button.Size = new System.Drawing.Size(44, 36);
            this.SwitchTheme_Button.TabIndex = 85589;
            this.SwitchTheme_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SwitchTheme_Button.UseVisualStyleBackColor = false;
            // 
            // Donate_Button
            // 
            this.Donate_Button.AutoSize = true;
            this.Donate_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Donate_Button.BackColor = System.Drawing.Color.Transparent;
            this.Donate_Button.Depth = 0;
            this.Donate_Button.FlatAppearance.BorderSize = 0;
            this.Donate_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Donate_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Donate_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Donate_Button.Icon = global::prop.x24.DonateHeart_24;
            this.Donate_Button.Location = new System.Drawing.Point(606, 30);
            this.Donate_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Donate_Button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Donate_Button.Name = "Donate_Button";
            this.Donate_Button.Primary = false;
            this.Donate_Button.Size = new System.Drawing.Size(44, 36);
            this.Donate_Button.TabIndex = 85618;
            this.Donate_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // Main_Tabs
            // 
            this.Main_Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Main_Tabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Main_Tabs.Controls.Add(this.PrepareYourDevice_Tab);
            this.Main_Tabs.Controls.Add(this.FlashImg_Tab);
            this.Main_Tabs.Controls.Add(this.MoreTools_Tab);
            this.Main_Tabs.Location = new System.Drawing.Point(273, 117);
            this.Main_Tabs.Name = "Main_Tabs";
            this.Main_Tabs.Padding = new System.Drawing.Point(6, 8);
            this.Main_Tabs.SelectedIndex = 0;
            this.Main_Tabs.Size = new System.Drawing.Size(377, 401);
            this.Main_Tabs.Style = MetroFramework.MetroColorStyle.Green;
            this.Main_Tabs.TabIndex = 85609;
            // 
            // PrepareYourDevice_Tab
            // 
            this.PrepareYourDevice_Tab.BackColor = System.Drawing.Color.White;
            this.PrepareYourDevice_Tab.Controls.Add(this.UnlockBL_Label);
            this.PrepareYourDevice_Tab.Controls.Add(this.MagiskRoot_Label);
            this.PrepareYourDevice_Tab.Controls.Add(this.MagiskRoot_PictureBox);
            this.PrepareYourDevice_Tab.Controls.Add(this.UnlockBL_PictureBox);
            this.PrepareYourDevice_Tab.Controls.Add(this.MagiskRoot_Title);
            this.PrepareYourDevice_Tab.Controls.Add(this.UnlockBL_Title);
            this.PrepareYourDevice_Tab.Controls.Add(this.MagiskRoot_Button);
            this.PrepareYourDevice_Tab.Controls.Add(this.MaterialDivider1);
            this.PrepareYourDevice_Tab.Controls.Add(this.UnlockBL_Button);
            this.PrepareYourDevice_Tab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrepareYourDevice_Tab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PrepareYourDevice_Tab.HorizontalScrollbarBarColor = true;
            this.PrepareYourDevice_Tab.HorizontalScrollbarSize = 12;
            this.PrepareYourDevice_Tab.Location = new System.Drawing.Point(4, 38);
            this.PrepareYourDevice_Tab.Name = "PrepareYourDevice_Tab";
            this.PrepareYourDevice_Tab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PrepareYourDevice_Tab.Size = new System.Drawing.Size(369, 359);
            this.PrepareYourDevice_Tab.Style = MetroFramework.MetroColorStyle.Green;
            this.PrepareYourDevice_Tab.TabIndex = 0;
            this.PrepareYourDevice_Tab.Text = "Prepare your device";
            this.PrepareYourDevice_Tab.VerticalScrollbarBarColor = true;
            this.PrepareYourDevice_Tab.VerticalScrollbarSize = 12;
            // 
            // UnlockBL_Label
            // 
            this.UnlockBL_Label.AutoSize = true;
            this.UnlockBL_Label.BackColor = System.Drawing.Color.Transparent;
            this.UnlockBL_Label.Location = new System.Drawing.Point(10, 50);
            this.UnlockBL_Label.Margin = new System.Windows.Forms.Padding(0);
            this.UnlockBL_Label.Name = "UnlockBL_Label";
            this.UnlockBL_Label.Size = new System.Drawing.Size(268, 38);
            this.UnlockBL_Label.Style = MetroFramework.MetroColorStyle.Green;
            this.UnlockBL_Label.TabIndex = 7;
            this.UnlockBL_Label.Text = "Check fastboot status then attempt to unlock\nyour device bootloader";
            // 
            // MagiskRoot_Label
            // 
            this.MagiskRoot_Label.AutoSize = true;
            this.MagiskRoot_Label.BackColor = System.Drawing.Color.Transparent;
            this.MagiskRoot_Label.Location = new System.Drawing.Point(10, 225);
            this.MagiskRoot_Label.Name = "MagiskRoot_Label";
            this.MagiskRoot_Label.Size = new System.Drawing.Size(248, 38);
            this.MagiskRoot_Label.Style = MetroFramework.MetroColorStyle.Green;
            this.MagiskRoot_Label.TabIndex = 7;
            this.MagiskRoot_Label.Text = "Download the latest Magisk zip & apk then\nattempt to install them";
            // 
            // MagiskRoot_PictureBox
            // 
            this.MagiskRoot_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.MagiskRoot_PictureBox.Image = global::prop.xXX.Magisk_gray_alpha;
            this.MagiskRoot_PictureBox.Location = new System.Drawing.Point(239, 226);
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
            this.UnlockBL_PictureBox.Location = new System.Drawing.Point(239, 43);
            this.UnlockBL_PictureBox.Name = "UnlockBL_PictureBox";
            this.UnlockBL_PictureBox.Size = new System.Drawing.Size(128, 128);
            this.UnlockBL_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UnlockBL_PictureBox.TabIndex = 5;
            this.UnlockBL_PictureBox.TabStop = false;
            // 
            // MagiskRoot_Title
            // 
            this.MagiskRoot_Title.AutoSize = true;
            this.MagiskRoot_Title.BackColor = System.Drawing.Color.Transparent;
            this.MagiskRoot_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MagiskRoot_Title.Location = new System.Drawing.Point(10, 191);
            this.MagiskRoot_Title.Name = "MagiskRoot_Title";
            this.MagiskRoot_Title.Size = new System.Drawing.Size(131, 21);
            this.MagiskRoot_Title.TabIndex = 2;
            this.MagiskRoot_Title.Text = "Root with Magisk";
            // 
            // UnlockBL_Title
            // 
            this.UnlockBL_Title.AutoSize = true;
            this.UnlockBL_Title.BackColor = System.Drawing.Color.Transparent;
            this.UnlockBL_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnlockBL_Title.Location = new System.Drawing.Point(10, 19);
            this.UnlockBL_Title.Name = "UnlockBL_Title";
            this.UnlockBL_Title.Size = new System.Drawing.Size(138, 21);
            this.UnlockBL_Title.TabIndex = 2;
            this.UnlockBL_Title.Text = "Unlock Bootloader";
            // 
            // MagiskRoot_Button
            // 
            this.MagiskRoot_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MagiskRoot_Button.BackColor = System.Drawing.Color.Transparent;
            this.MagiskRoot_Button.Highlight = true;
            this.MagiskRoot_Button.Location = new System.Drawing.Point(10, 301);
            this.MagiskRoot_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MagiskRoot_Button.Name = "MagiskRoot_Button";
            this.MagiskRoot_Button.Size = new System.Drawing.Size(172, 36);
            this.MagiskRoot_Button.Style = MetroFramework.MetroColorStyle.Green;
            this.MagiskRoot_Button.TabIndex = 6;
            this.MagiskRoot_Button.Text = "Start Rooting";
            this.MagiskRoot_Button.UseVisualStyleBackColor = false;
            // 
            // MaterialDivider1
            // 
            this.MaterialDivider1.BackColor = System.Drawing.Color.Gainsboro;
            this.MaterialDivider1.Depth = 0;
            this.MaterialDivider1.Location = new System.Drawing.Point(3, 177);
            this.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialDivider1.Name = "MaterialDivider1";
            this.MaterialDivider1.Size = new System.Drawing.Size(363, 1);
            this.MaterialDivider1.TabIndex = 3;
            this.MaterialDivider1.Text = "MaterialDivider1";
            // 
            // UnlockBL_Button
            // 
            this.UnlockBL_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UnlockBL_Button.BackColor = System.Drawing.Color.Transparent;
            this.UnlockBL_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UnlockBL_Button.Highlight = true;
            this.UnlockBL_Button.Location = new System.Drawing.Point(10, 118);
            this.UnlockBL_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UnlockBL_Button.Name = "UnlockBL_Button";
            this.UnlockBL_Button.Size = new System.Drawing.Size(172, 36);
            this.UnlockBL_Button.Style = MetroFramework.MetroColorStyle.Green;
            this.UnlockBL_Button.TabIndex = 6;
            this.UnlockBL_Button.Text = "Start Unlocking";
            this.UnlockBL_Button.UseVisualStyleBackColor = false;
            // 
            // FlashImg_Tab
            // 
            this.FlashImg_Tab.BackColor = System.Drawing.Color.White;
            this.FlashImg_Tab.Controls.Add(this.Button5);
            this.FlashImg_Tab.Controls.Add(this.Button4);
            this.FlashImg_Tab.Controls.Add(this.Button3);
            this.FlashImg_Tab.Controls.Add(this.Button2);
            this.FlashImg_Tab.Controls.Add(this.Button1);
            this.FlashImg_Tab.Controls.Add(this.FlashZip_ChooseFile_Button);
            this.FlashImg_Tab.Controls.Add(this.FlashZip_Title);
            this.FlashImg_Tab.Controls.Add(this.FlashZip_RebootWhenComplete_Checkbox);
            this.FlashImg_Tab.Controls.Add(this.FlashZip_Button);
            this.FlashImg_Tab.Controls.Add(this.PictureBox3);
            this.FlashImg_Tab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlashImg_Tab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FlashImg_Tab.HorizontalScrollbarBarColor = true;
            this.FlashImg_Tab.HorizontalScrollbarSize = 12;
            this.FlashImg_Tab.Location = new System.Drawing.Point(4, 38);
            this.FlashImg_Tab.Name = "FlashImg_Tab";
            this.FlashImg_Tab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FlashImg_Tab.Size = new System.Drawing.Size(369, 359);
            this.FlashImg_Tab.TabIndex = 1;
            this.FlashImg_Tab.Text = "Flash img files";
            this.FlashImg_Tab.VerticalScrollbarBarColor = true;
            this.FlashImg_Tab.VerticalScrollbarSize = 12;
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(164)))), ((int)(((byte)(50)))));
            this.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button5.FlatAppearance.BorderSize = 0;
            this.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Image = global::prop.x24.OpenFile_24_noBG;
            this.Button5.Location = new System.Drawing.Point(269, 232);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(29, 27);
            this.Button5.TabIndex = 85593;
            this.Button5.UseVisualStyleBackColor = false;
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
            this.Button4.Location = new System.Drawing.Point(269, 199);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(29, 27);
            this.Button4.TabIndex = 85591;
            this.Button4.UseVisualStyleBackColor = false;
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
            this.Button3.Location = new System.Drawing.Point(269, 133);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(29, 27);
            this.Button3.TabIndex = 85589;
            this.Button3.UseVisualStyleBackColor = false;
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
            this.Button2.Location = new System.Drawing.Point(269, 100);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(29, 27);
            this.Button2.TabIndex = 85587;
            this.Button2.UseVisualStyleBackColor = false;
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
            this.Button1.Location = new System.Drawing.Point(269, 166);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(29, 27);
            this.Button1.TabIndex = 85585;
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // PictureBox3
            // 
            this.PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox3.Image = global::prop.xXX.FlashZip_gray_alpha;
            this.PictureBox3.Location = new System.Drawing.Point(241, 228);
            this.PictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(128, 128);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox3.TabIndex = 5;
            this.PictureBox3.TabStop = false;
            // 
            // MoreTools_Tab
            // 
            this.MoreTools_Tab.Controls.Add(this.debuggingBox);
            this.MoreTools_Tab.Controls.Add(this.InstallBusybox_Button);
            this.MoreTools_Tab.Controls.Add(this.HotReboot_Button);
            this.MoreTools_Tab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MoreTools_Tab.HorizontalScrollbarBarColor = true;
            this.MoreTools_Tab.HorizontalScrollbarSize = 3;
            this.MoreTools_Tab.Location = new System.Drawing.Point(4, 38);
            this.MoreTools_Tab.Name = "MoreTools_Tab";
            this.MoreTools_Tab.Size = new System.Drawing.Size(369, 359);
            this.MoreTools_Tab.TabIndex = 2;
            this.MoreTools_Tab.Text = "More Tools";
            this.MoreTools_Tab.VerticalScrollbarBarColor = true;
            this.MoreTools_Tab.VerticalScrollbarSize = 3;
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
            this.debuggingBox.Location = new System.Drawing.Point(3, 108);
            this.debuggingBox.Name = "debuggingBox";
            this.debuggingBox.Size = new System.Drawing.Size(363, 0);
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
            this.MetroButton4.Size = new System.Drawing.Size(351, 26);
            this.MetroButton4.TabIndex = 9;
            this.MetroButton4.Text = "web log";
            // 
            // MetroButton8
            // 
            this.MetroButton8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroButton8.Location = new System.Drawing.Point(6, 84);
            this.MetroButton8.Name = "MetroButton8";
            this.MetroButton8.Size = new System.Drawing.Size(351, 26);
            this.MetroButton8.TabIndex = 8;
            this.MetroButton8.Text = "Terminate Bridge";
            // 
            // MetroButton7
            // 
            this.MetroButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroButton7.Location = new System.Drawing.Point(287, 52);
            this.MetroButton7.Name = "MetroButton7";
            this.MetroButton7.Size = new System.Drawing.Size(70, 26);
            this.MetroButton7.TabIndex = 7;
            this.MetroButton7.Text = "false";
            // 
            // MetroButton6
            // 
            this.MetroButton6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroButton6.Location = new System.Drawing.Point(6, 52);
            this.MetroButton6.Name = "MetroButton6";
            this.MetroButton6.Size = new System.Drawing.Size(275, 26);
            this.MetroButton6.TabIndex = 6;
            this.MetroButton6.Text = "CreateBridge start true";
            // 
            // MetroButton11
            // 
            this.MetroButton11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroButton11.Location = new System.Drawing.Point(287, 20);
            this.MetroButton11.Name = "MetroButton11";
            this.MetroButton11.Size = new System.Drawing.Size(70, 26);
            this.MetroButton11.TabIndex = 5;
            this.MetroButton11.Text = "false";
            // 
            // MetroButton3
            // 
            this.MetroButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroButton3.Location = new System.Drawing.Point(6, 148);
            this.MetroButton3.Name = "MetroButton3";
            this.MetroButton3.Size = new System.Drawing.Size(351, 26);
            this.MetroButton3.TabIndex = 2;
            this.MetroButton3.Text = "State";
            // 
            // MetroButton2
            // 
            this.MetroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroButton2.Location = new System.Drawing.Point(6, 116);
            this.MetroButton2.Name = "MetroButton2";
            this.MetroButton2.Size = new System.Drawing.Size(351, 26);
            this.MetroButton2.TabIndex = 1;
            this.MetroButton2.Text = "Count";
            // 
            // MetroButton1
            // 
            this.MetroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroButton1.Location = new System.Drawing.Point(6, 20);
            this.MetroButton1.Name = "MetroButton1";
            this.MetroButton1.Size = new System.Drawing.Size(275, 26);
            this.MetroButton1.TabIndex = 0;
            this.MetroButton1.Text = "CreateBridge true";
            // 
            // InstallBusybox_Button
            // 
            this.InstallBusybox_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InstallBusybox_Button.BackColor = System.Drawing.Color.Transparent;
            this.InstallBusybox_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InstallBusybox_Button.Highlight = true;
            this.InstallBusybox_Button.Location = new System.Drawing.Point(39, 15);
            this.InstallBusybox_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.InstallBusybox_Button.Name = "InstallBusybox_Button";
            this.InstallBusybox_Button.Size = new System.Drawing.Size(172, 36);
            this.InstallBusybox_Button.Style = MetroFramework.MetroColorStyle.Green;
            this.InstallBusybox_Button.TabIndex = 9;
            this.InstallBusybox_Button.Text = "Install Busybox";
            this.InstallBusybox_Button.UseVisualStyleBackColor = false;
            // 
            // HotReboot_Button
            // 
            this.HotReboot_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HotReboot_Button.BackColor = System.Drawing.Color.Transparent;
            this.HotReboot_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HotReboot_Button.Highlight = true;
            this.HotReboot_Button.Location = new System.Drawing.Point(39, 63);
            this.HotReboot_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.HotReboot_Button.Name = "HotReboot_Button";
            this.HotReboot_Button.Size = new System.Drawing.Size(172, 36);
            this.HotReboot_Button.Style = MetroFramework.MetroColorStyle.Green;
            this.HotReboot_Button.TabIndex = 8;
            this.HotReboot_Button.Text = "Hot Reboot";
            this.HotReboot_Button.UseVisualStyleBackColor = false;
            // 
            // GA_About_Label
            // 
            this.GA_About_Label.AutoSize = true;
            this.GA_About_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GA_About_Label.Location = new System.Drawing.Point(112, 74);
            this.GA_About_Label.Name = "GA_About_Label";
            this.GA_About_Label.Size = new System.Drawing.Size(180, 19);
            this.GA_About_Label.Style = MetroFramework.MetroColorStyle.Green;
            this.GA_About_Label.TabIndex = 85611;
            this.GA_About_Label.Text = "vX.x #Beta  - By NHKomaiha.";
            // 
            // PictureBox4
            // 
            this.PictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox4.Location = new System.Drawing.Point(0, 1);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(677, 599);
            this.PictureBox4.TabIndex = 85613;
            this.PictureBox4.TabStop = false;
            // 
            // SwitchTheme_Back_UI
            // 
            this.SwitchTheme_Back_UI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SwitchTheme_Back_UI.Location = new System.Drawing.Point(-6, 601);
            this.SwitchTheme_Back_UI.Name = "SwitchTheme_Back_UI";
            this.SwitchTheme_Back_UI.Size = new System.Drawing.Size(1184, 929);
            this.SwitchTheme_Back_UI.TabIndex = 85614;
            this.SwitchTheme_Back_UI.TabStop = false;
            // 
            // GeekAssistant_Icon
            // 
            this.GeekAssistant_Icon.Image = ((System.Drawing.Image)(resources.GetObject("GeekAssistant_Icon.Image")));
            this.GeekAssistant_Icon.Location = new System.Drawing.Point(24, 22);
            this.GeekAssistant_Icon.Name = "GeekAssistant_Icon";
            this.GeekAssistant_Icon.Size = new System.Drawing.Size(70, 69);
            this.GeekAssistant_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GeekAssistant_Icon.TabIndex = 85615;
            this.GeekAssistant_Icon.TabStop = false;
            // 
            // SwitchTheme_Mid_UI
            // 
            this.SwitchTheme_Mid_UI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SwitchTheme_Mid_UI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.SwitchTheme_Mid_UI.Location = new System.Drawing.Point(-6, 602);
            this.SwitchTheme_Mid_UI.Name = "SwitchTheme_Mid_UI";
            this.SwitchTheme_Mid_UI.Size = new System.Drawing.Size(1184, 929);
            this.SwitchTheme_Mid_UI.TabIndex = 85616;
            this.SwitchTheme_Mid_UI.TabStop = false;
            this.SwitchTheme_Mid_UI.Visible = false;
            // 
            // SwitchTheme_Fore_UI
            // 
            this.SwitchTheme_Fore_UI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SwitchTheme_Fore_UI.BackColor = System.Drawing.Color.Transparent;
            this.SwitchTheme_Fore_UI.Location = new System.Drawing.Point(-6, 602);
            this.SwitchTheme_Fore_UI.Name = "SwitchTheme_Fore_UI";
            this.SwitchTheme_Fore_UI.Size = new System.Drawing.Size(1184, 929);
            this.SwitchTheme_Fore_UI.TabIndex = 85617;
            this.SwitchTheme_Fore_UI.TabStop = false;
            this.SwitchTheme_Fore_UI.Visible = false;
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
            // PleaseWait_PostDelay_adbDetect
            // 
            this.PleaseWait_PostDelay_adbDetect.Interval = 200;
            // 
            // Main_ToolTip
            // 
            this.Main_ToolTip.AutomaticDelay = 1000;
            this.Main_ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Main_ToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.Main_ToolTip_Popup);
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1174, 599);
            this.Controls.Add(this.ShowLog_Button);
            this.Controls.Add(this.ProgressBarLabel);
            this.Controls.Add(this.ProgressFakeBG_UI);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.SwitchTheme_Fore_UI);
            this.Controls.Add(this.SwitchTheme_Mid_UI);
            this.Controls.Add(this.SwitchTheme_Back_UI);
            this.Controls.Add(this.Donate_Button);
            this.Controls.Add(this.DeviceState_Label);
            this.Controls.Add(this.GeekAssistant_Icon);
            this.Controls.Add(this.DeviceStateTitle_Label);
            this.Controls.Add(this.GA_About_Label);
            this.Controls.Add(this.Main_Tabs);
            this.Controls.Add(this.About_Button);
            this.Controls.Add(this.SwitchTheme_Button);
            this.Controls.Add(this.Feedback_Button);
            this.Controls.Add(this.Settings_Button);
            this.Controls.Add(this.ManualInfo_GroupBox);
            this.Controls.Add(this.AutoDetectDeviceInfo_Button);
            this.Controls.Add(this.GeekAssistant);
            this.Controls.Add(this.MainLayout_PictureBox);
            this.Controls.Add(this.PictureBox4);
            this.Controls.Add(this.OpenLogFolder);
            this.Controls.Add(this.CopyLogToClipboard);
            this.Controls.Add(this.ClearLog_Button);
            this.Controls.Add(this.log);
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
            this.ManualInfo_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeekAssistant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainLayout_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressFakeBG_UI)).EndInit();
            this.Main_Tabs.ResumeLayout(false);
            this.PrepareYourDevice_Tab.ResumeLayout(false);
            this.PrepareYourDevice_Tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MagiskRoot_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnlockBL_PictureBox)).EndInit();
            this.FlashImg_Tab.ResumeLayout(false);
            this.FlashImg_Tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.MoreTools_Tab.ResumeLayout(false);
            this.debuggingBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchTheme_Back_UI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeekAssistant_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchTheme_Mid_UI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchTheme_Fore_UI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
         
        public Button OpenLogFolder;  
        public OpenFileDialog FlashZip_OpenFileDialog; 
        public GroupBox ManualInfo_GroupBox; 
        public Label DeviceStateTitle_Label;
        public MaterialSkin.Controls.MaterialFlatButton About_Button;
        public CheckBox FlashZip_RebootWhenComplete_Checkbox;
        public Button AutoDetectDeviceInfo_Button;
        public Button ClearLog_Button;
        public Label FlashZip_Title;
        public Button CopyLogToClipboard; 
        public PictureBox GeekAssistant;
        public TextBox log;
        public MaterialSkin.Controls.MaterialFlatButton Feedback_Button;
        public Button Settings;
        public PictureBox MainLayout_PictureBox;
        public MaterialSkin.Controls.MaterialFlatButton Settings_Button;
        public MetroFramework.Controls.MetroButton FlashZip_Button;
        public MaterialSkin.Controls.MaterialFlatButton ShowLog_Button;
        public PictureBox ProgressFakeBG_UI;
        public MetroFramework.Controls.MetroTabControl Main_Tabs;
        public MetroFramework.Controls.MetroTabPage PrepareYourDevice_Tab;
        public MetroFramework.Controls.MetroTabPage FlashImg_Tab;
        public Label UnlockBL_Title;
        public Label MagiskRoot_Title;
        public MetroFramework.Controls.MetroComboBox Manufacturer_ComboBox;
        public CheckBox BootloaderUnlockable_CheckBox;
        public MetroFramework.Controls.MetroComboBox AndroidVersion_ComboBox;
        public CheckBox CustomRecovery_CheckBox;
        public CheckBox CustomROM_CheckBox;
        public MetroFramework.Controls.MetroLabel ProgressBarLabel;
        public MetroFramework.Controls.MetroLabel GA_About_Label;
        public MaterialSkin.Controls.MaterialDivider MaterialDivider1;
        public MetroFramework.Controls.MetroTabPage MoreTools_Tab;
        public PictureBox MagiskRoot_PictureBox;
        public PictureBox UnlockBL_PictureBox;
        public ToolTip Main_ToolTip;
        public MetroFramework.Controls.MetroButton UnlockBL_Button;
        public MetroFramework.Controls.MetroButton MagiskRoot_Button;
        public MetroFramework.Controls.MetroLabel UnlockBL_Label;
        public MetroFramework.Controls.MetroLabel MagiskRoot_Label;
        public PictureBox PictureBox3;
        public MetroFramework.Controls.MetroProgressBar ProgressBar;
        public PictureBox PictureBox4;
        public PictureBox SwitchTheme_Back_UI;
        public MaterialSkin.Controls.MaterialFlatButton SwitchTheme_Button;
        public Button FlashZip_ChooseFile_Button;
        public Label DeviceState_Label;
        public PictureBox GeekAssistant_Icon;
        public PictureBox SwitchTheme_Mid_UI;
        public PictureBox SwitchTheme_Fore_UI;
        public CheckBox Rooted_Checkbox;
        public MaterialSkin.Controls.MaterialFlatButton Donate_Button;
        public MetroFramework.Controls.MetroButton HotReboot_Button;
        public MetroFramework.Controls.MetroButton InstallBusybox_Button;
        public Button Button4;
        public MetroFramework.Controls.MetroTextBox MetroTextBox4;
        public Button Button3;
        public MetroFramework.Controls.MetroTextBox MetroTextBox3;
        public Button Button2;
        public MetroFramework.Controls.MetroTextBox MetroTextBox2;
        public Button Button1;
        public MetroFramework.Controls.MetroTextBox MetroTextBox1;
        public Button Button5;
        public MetroFramework.Controls.MetroTextBox MetroTextBox5;
        public GroupBox debuggingBox;
        public MetroFramework.Controls.MetroButton MetroButton3;
        public MetroFramework.Controls.MetroButton MetroButton2;
        public MetroFramework.Controls.MetroButton MetroButton1;
        public MetroFramework.Controls.MetroButton MetroButton11;
        public MetroFramework.Controls.MetroButton MetroButton7;
        public MetroFramework.Controls.MetroButton MetroButton6;
        public MetroFramework.Controls.MetroButton MetroButton8;
        public MetroFramework.Controls.MetroButton MetroButton4;

        public MetroFramework.Controls.MetroProgressBar bar;
        public Timer ShowLog_ErrorBlink_Timer;
        public Timer ShowLog_InfoBlink_Timer;
        public Timer AutoDetectFlash_Timer_Deprecated;
        public Timer PleaseWait_PostDelay_adbDetect;
        public Timer SettingsSave_Timer;
        public ToolTip Unavalable_Tooltip;
    }
}