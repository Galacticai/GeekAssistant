
using System.Windows.Forms;

namespace GeekAssistant.Forms {
    partial class Settings : System.Windows.Forms.Form {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.ResetGA_GroupBox = new System.Windows.Forms.GroupBox();
            this.AutoClearLogs_SwitchButton = new System.Windows.Forms.Button();
            this.OpenLogsFolder = new System.Windows.Forms.Label();
            this.ResetGA = new System.Windows.Forms.Button();
            this.ResetGA_LogsOnly_CheckBox = new System.Windows.Forms.CheckBox();
            this.ResetGA_Settings_CheckBox_Label = new System.Windows.Forms.Label();
            this.ResetGA_LogsOnly_CheckBox_Label = new System.Windows.Forms.Label();
            this.ResetGA_SelectAll = new System.Windows.Forms.Button();
            this.ResetGA_Settings_CheckBox = new System.Windows.Forms.CheckBox();
            this.ResetGA_LogsOnly_UI = new System.Windows.Forms.PictureBox();
            this.ResetGA_Settings_UI = new System.Windows.Forms.PictureBox();
            this.Close_Button = new System.Windows.Forms.Button();
            this.PopupMessages_SwitchButton = new System.Windows.Forms.Button();
            this.ShowToolTips_SwitchButton = new System.Windows.Forms.Button();
            this.ToU_SwitchButton = new System.Windows.Forms.Button();
            this.AppMode_SwitchButton = new System.Windows.Forms.Button();
            this.VerbousLoggingPrompt_SwitchButton = new System.Windows.Forms.Button();
            this.VerbousLogging_SwitchButton = new System.Windows.Forms.Button();
            this.PerformAnimation_SwitchButton = new System.Windows.Forms.Button();
            this.ButtonsBG_UI = new System.Windows.Forms.PictureBox();
            this.SettingsIcon_PictureBox = new System.Windows.Forms.PictureBox();
            this.SettingsTitle_Label = new System.Windows.Forms.Label();
            this.GeekAssistant_PictureBox = new System.Windows.Forms.PictureBox();
            this.Thanks_Label = new System.Windows.Forms.Label();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ResetGA_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResetGA_LogsOnly_UI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetGA_Settings_UI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonsBG_UI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsIcon_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeekAssistant_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ResetGA_GroupBox
            // 
            this.ResetGA_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResetGA_GroupBox.Controls.Add(this.AutoClearLogs_SwitchButton);
            this.ResetGA_GroupBox.Controls.Add(this.OpenLogsFolder);
            this.ResetGA_GroupBox.Controls.Add(this.ResetGA);
            this.ResetGA_GroupBox.Controls.Add(this.ResetGA_LogsOnly_CheckBox);
            this.ResetGA_GroupBox.Controls.Add(this.ResetGA_Settings_CheckBox_Label);
            this.ResetGA_GroupBox.Controls.Add(this.ResetGA_LogsOnly_CheckBox_Label);
            this.ResetGA_GroupBox.Controls.Add(this.ResetGA_SelectAll);
            this.ResetGA_GroupBox.Controls.Add(this.ResetGA_Settings_CheckBox);
            this.ResetGA_GroupBox.Controls.Add(this.ResetGA_LogsOnly_UI);
            this.ResetGA_GroupBox.Controls.Add(this.ResetGA_Settings_UI);
            this.ResetGA_GroupBox.Location = new System.Drawing.Point(247, 97);
            this.ResetGA_GroupBox.Name = "ResetGA_GroupBox";
            this.ResetGA_GroupBox.Size = new System.Drawing.Size(230, 237);
            this.ResetGA_GroupBox.TabIndex = 85558;
            this.ResetGA_GroupBox.TabStop = false;
            this.ResetGA_GroupBox.Text = "Reset Geek Assistant";
            // 
            // AutoClearLogs_SwitchButton
            // 
            this.AutoClearLogs_SwitchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoClearLogs_SwitchButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AutoClearLogs_SwitchButton.FlatAppearance.BorderSize = 0;
            this.AutoClearLogs_SwitchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AutoClearLogs_SwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoClearLogs_SwitchButton.Location = new System.Drawing.Point(6, 160);
            this.AutoClearLogs_SwitchButton.Name = "AutoClearLogs_SwitchButton";
            this.AutoClearLogs_SwitchButton.Size = new System.Drawing.Size(218, 32);
            this.AutoClearLogs_SwitchButton.TabIndex = 85564;
            this.AutoClearLogs_SwitchButton.Text = "Auto Clear Logs ( > 30 days)";
            this.tooltip.SetToolTip(this.AutoClearLogs_SwitchButton, "Auto delete log files that are older than 30 days");
            this.AutoClearLogs_SwitchButton.UseVisualStyleBackColor = false;
            // 
            // OpenLogsFolder
            // 
            this.OpenLogsFolder.BackColor = System.Drawing.Color.Transparent;
            this.OpenLogsFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpenLogsFolder.Location = new System.Drawing.Point(136, 102);
            this.OpenLogsFolder.Name = "OpenLogsFolder";
            this.OpenLogsFolder.Size = new System.Drawing.Size(82, 20);
            this.OpenLogsFolder.TabIndex = 85564;
            this.OpenLogsFolder.Text = "(Open folder)";
            this.OpenLogsFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetGA
            // 
            this.ResetGA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetGA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResetGA.FlatAppearance.BorderSize = 0;
            this.ResetGA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(0)))));
            this.ResetGA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(179)))));
            this.ResetGA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetGA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetGA.Image = global::prop.xXX.Clear_Data_50_24;
            this.ResetGA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetGA.Location = new System.Drawing.Point(39, 197);
            this.ResetGA.Name = "ResetGA";
            this.ResetGA.Size = new System.Drawing.Size(190, 38);
            this.ResetGA.TabIndex = 3;
            this.ResetGA.Text = "⠀⠀⠀⠀⠀ &Reset Geek Assistant";
            this.ResetGA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetGA.UseVisualStyleBackColor = false;
            // 
            // ResetGA_LogsOnly_CheckBox
            // 
            this.ResetGA_LogsOnly_CheckBox.AutoSize = true;
            this.ResetGA_LogsOnly_CheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetGA_LogsOnly_CheckBox.Location = new System.Drawing.Point(12, 104);
            this.ResetGA_LogsOnly_CheckBox.Name = "ResetGA_LogsOnly_CheckBox";
            this.ResetGA_LogsOnly_CheckBox.Size = new System.Drawing.Size(51, 19);
            this.ResetGA_LogsOnly_CheckBox.TabIndex = 2;
            this.ResetGA_LogsOnly_CheckBox.Text = "&Logs";
            this.tooltip.SetToolTip(this.ResetGA_LogsOnly_CheckBox, "Only logs folder & files \"%appdata%\\Geek Assistant (Android)\\logs\"");
            this.ResetGA_LogsOnly_CheckBox.UseVisualStyleBackColor = true;
            // 
            // ResetGA_Settings_CheckBox_Label
            // 
            this.ResetGA_Settings_CheckBox_Label.AutoSize = true;
            this.ResetGA_Settings_CheckBox_Label.BackColor = System.Drawing.Color.Transparent;
            this.ResetGA_Settings_CheckBox_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResetGA_Settings_CheckBox_Label.Location = new System.Drawing.Point(12, 54);
            this.ResetGA_Settings_CheckBox_Label.Name = "ResetGA_Settings_CheckBox_Label";
            this.ResetGA_Settings_CheckBox_Label.Size = new System.Drawing.Size(179, 26);
            this.ResetGA_Settings_CheckBox_Label.TabIndex = 85563;
            this.ResetGA_Settings_CheckBox_Label.Text = "Reset all values used internally by\nGeek Assistant";
            this.tooltip.SetToolTip(this.ResetGA_Settings_CheckBox_Label, "Internal saved values (like device information and others)");
            // 
            // ResetGA_LogsOnly_CheckBox_Label
            // 
            this.ResetGA_LogsOnly_CheckBox_Label.AutoSize = true;
            this.ResetGA_LogsOnly_CheckBox_Label.BackColor = System.Drawing.Color.Transparent;
            this.ResetGA_LogsOnly_CheckBox_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResetGA_LogsOnly_CheckBox_Label.Location = new System.Drawing.Point(12, 126);
            this.ResetGA_LogsOnly_CheckBox_Label.Name = "ResetGA_LogsOnly_CheckBox_Label";
            this.ResetGA_LogsOnly_CheckBox_Label.Size = new System.Drawing.Size(202, 13);
            this.ResetGA_LogsOnly_CheckBox_Label.TabIndex = 85563;
            this.ResetGA_LogsOnly_CheckBox_Label.Text = "Delete per-session saved logging files";
            this.tooltip.SetToolTip(this.ResetGA_LogsOnly_CheckBox_Label, "Logs folder & files \"%appdata%\\Geek Assistant (Android)\\logs\"");
            // 
            // ResetGA_SelectAll
            // 
            this.ResetGA_SelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResetGA_SelectAll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResetGA_SelectAll.FlatAppearance.BorderSize = 0;
            this.ResetGA_SelectAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResetGA_SelectAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ResetGA_SelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetGA_SelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetGA_SelectAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ResetGA_SelectAll.Image = global::prop.x24.SelectAll_B_24;
            this.ResetGA_SelectAll.Location = new System.Drawing.Point(1, 197);
            this.ResetGA_SelectAll.Name = "ResetGA_SelectAll";
            this.ResetGA_SelectAll.Size = new System.Drawing.Size(36, 38);
            this.ResetGA_SelectAll.TabIndex = 2;
            this.tooltip.SetToolTip(this.ResetGA_SelectAll, "Tick / Untick all of the above");
            this.ResetGA_SelectAll.UseVisualStyleBackColor = false;
            // 
            // ResetGA_Settings_CheckBox
            // 
            this.ResetGA_Settings_CheckBox.AutoSize = true;
            this.ResetGA_Settings_CheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetGA_Settings_CheckBox.Location = new System.Drawing.Point(12, 32);
            this.ResetGA_Settings_CheckBox.Name = "ResetGA_Settings_CheckBox";
            this.ResetGA_Settings_CheckBox.Size = new System.Drawing.Size(93, 19);
            this.ResetGA_Settings_CheckBox.TabIndex = 1;
            this.ResetGA_Settings_CheckBox.Text = "&Internal Data";
            this.tooltip.SetToolTip(this.ResetGA_Settings_CheckBox, "Internal saved values (like device information and others)");
            this.ResetGA_Settings_CheckBox.UseVisualStyleBackColor = true;
            // 
            // ResetGA_LogsOnly_UI
            // 
            this.ResetGA_LogsOnly_UI.Location = new System.Drawing.Point(1, 93);
            this.ResetGA_LogsOnly_UI.Name = "ResetGA_LogsOnly_UI";
            this.ResetGA_LogsOnly_UI.Size = new System.Drawing.Size(228, 64);
            this.ResetGA_LogsOnly_UI.TabIndex = 85566;
            this.ResetGA_LogsOnly_UI.TabStop = false;
            // 
            // ResetGA_Settings_UI
            // 
            this.ResetGA_Settings_UI.Location = new System.Drawing.Point(1, 22);
            this.ResetGA_Settings_UI.Name = "ResetGA_Settings_UI";
            this.ResetGA_Settings_UI.Size = new System.Drawing.Size(228, 65);
            this.ResetGA_Settings_UI.TabIndex = 85565;
            this.ResetGA_Settings_UI.TabStop = false;
            // 
            // Close_Button
            // 
            this.Close_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_Button.FlatAppearance.BorderSize = 0;
            this.Close_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Close_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Close_Button.Location = new System.Drawing.Point(386, 360);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(91, 30);
            this.Close_Button.TabIndex = 6;
            this.Close_Button.Text = "Close";
            this.Close_Button.UseVisualStyleBackColor = true;
            // 
            // PopupMessages_SwitchButton
            // 
            this.PopupMessages_SwitchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PopupMessages_SwitchButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PopupMessages_SwitchButton.FlatAppearance.BorderSize = 0;
            this.PopupMessages_SwitchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PopupMessages_SwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PopupMessages_SwitchButton.Location = new System.Drawing.Point(24, 182);
            this.PopupMessages_SwitchButton.Name = "PopupMessages_SwitchButton";
            this.PopupMessages_SwitchButton.Size = new System.Drawing.Size(207, 32);
            this.PopupMessages_SwitchButton.TabIndex = 4;
            this.PopupMessages_SwitchButton.Text = "Pop-up Messages";
            this.tooltip.SetToolTip(this.PopupMessages_SwitchButton, "View a window for messages like errors and info... etc");
            this.PopupMessages_SwitchButton.UseVisualStyleBackColor = false;
            // 
            // ShowToolTips_SwitchButton
            // 
            this.ShowToolTips_SwitchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowToolTips_SwitchButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShowToolTips_SwitchButton.FlatAppearance.BorderSize = 0;
            this.ShowToolTips_SwitchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShowToolTips_SwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowToolTips_SwitchButton.Location = new System.Drawing.Point(24, 260);
            this.ShowToolTips_SwitchButton.Name = "ShowToolTips_SwitchButton";
            this.ShowToolTips_SwitchButton.Size = new System.Drawing.Size(207, 32);
            this.ShowToolTips_SwitchButton.TabIndex = 5;
            this.ShowToolTips_SwitchButton.Text = "Show Tooltips";
            this.tooltip.SetToolTip(this.ShowToolTips_SwitchButton, "Show tooltips on various controls for clarification");
            this.ShowToolTips_SwitchButton.UseVisualStyleBackColor = false;
            // 
            // ToU_SwitchButton
            // 
            this.ToU_SwitchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ToU_SwitchButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ToU_SwitchButton.FlatAppearance.BorderSize = 0;
            this.ToU_SwitchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToU_SwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToU_SwitchButton.Location = new System.Drawing.Point(24, 104);
            this.ToU_SwitchButton.Name = "ToU_SwitchButton";
            this.ToU_SwitchButton.Size = new System.Drawing.Size(207, 32);
            this.ToU_SwitchButton.TabIndex = 85561;
            this.ToU_SwitchButton.Text = "Skip Terms of Use on startup";
            this.tooltip.SetToolTip(this.ToU_SwitchButton, "View a window for messages like errors and info... etc");
            this.ToU_SwitchButton.UseVisualStyleBackColor = false;
            // 
            // AppMode_SwitchButton
            // 
            this.AppMode_SwitchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AppMode_SwitchButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AppMode_SwitchButton.FlatAppearance.BorderSize = 0;
            this.AppMode_SwitchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AppMode_SwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppMode_SwitchButton.Location = new System.Drawing.Point(24, 143);
            this.AppMode_SwitchButton.Name = "AppMode_SwitchButton";
            this.AppMode_SwitchButton.Size = new System.Drawing.Size(207, 32);
            this.AppMode_SwitchButton.TabIndex = 85562;
            this.AppMode_SwitchButton.Text = "Skip App Mode on startup";
            this.tooltip.SetToolTip(this.AppMode_SwitchButton, "View a window for messages like errors and info... etc");
            this.AppMode_SwitchButton.UseVisualStyleBackColor = false;
            // 
            // VerbousLoggingPrompt_SwitchButton
            // 
            this.VerbousLoggingPrompt_SwitchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VerbousLoggingPrompt_SwitchButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.VerbousLoggingPrompt_SwitchButton.FlatAppearance.BorderSize = 0;
            this.VerbousLoggingPrompt_SwitchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VerbousLoggingPrompt_SwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerbousLoggingPrompt_SwitchButton.Location = new System.Drawing.Point(185, 221);
            this.VerbousLoggingPrompt_SwitchButton.Name = "VerbousLoggingPrompt_SwitchButton";
            this.VerbousLoggingPrompt_SwitchButton.Size = new System.Drawing.Size(46, 32);
            this.VerbousLoggingPrompt_SwitchButton.TabIndex = 85563;
            this.VerbousLoggingPrompt_SwitchButton.Text = "(Ask)";
            this.tooltip.SetToolTip(this.VerbousLoggingPrompt_SwitchButton, "Show tooltips on various controls for clarification");
            this.VerbousLoggingPrompt_SwitchButton.UseVisualStyleBackColor = false;
            // 
            // VerbousLogging_SwitchButton
            // 
            this.VerbousLogging_SwitchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VerbousLogging_SwitchButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.VerbousLogging_SwitchButton.FlatAppearance.BorderSize = 0;
            this.VerbousLogging_SwitchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VerbousLogging_SwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerbousLogging_SwitchButton.Location = new System.Drawing.Point(24, 221);
            this.VerbousLogging_SwitchButton.Name = "VerbousLogging_SwitchButton";
            this.VerbousLogging_SwitchButton.Size = new System.Drawing.Size(159, 32);
            this.VerbousLogging_SwitchButton.TabIndex = 5;
            this.VerbousLogging_SwitchButton.Text = "Verbous Logging";
            this.tooltip.SetToolTip(this.VerbousLogging_SwitchButton, "Show tooltips on various controls for clarification");
            this.VerbousLogging_SwitchButton.UseVisualStyleBackColor = false;
            // 
            // PerformAnimation_SwitchButton
            // 
            this.PerformAnimation_SwitchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PerformAnimation_SwitchButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PerformAnimation_SwitchButton.FlatAppearance.BorderSize = 0;
            this.PerformAnimation_SwitchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PerformAnimation_SwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PerformAnimation_SwitchButton.Location = new System.Drawing.Point(24, 301);
            this.PerformAnimation_SwitchButton.Name = "PerformAnimation_SwitchButton";
            this.PerformAnimation_SwitchButton.Size = new System.Drawing.Size(207, 32);
            this.PerformAnimation_SwitchButton.TabIndex = 5;
            this.PerformAnimation_SwitchButton.Text = "Perform Animations";
            this.PerformAnimation_SwitchButton.UseVisualStyleBackColor = false;
            // 
            // ButtonsBG_UI
            // 
            this.ButtonsBG_UI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsBG_UI.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonsBG_UI.Enabled = false;
            this.ButtonsBG_UI.Location = new System.Drawing.Point(-5, 349);
            this.ButtonsBG_UI.Name = "ButtonsBG_UI";
            this.ButtonsBG_UI.Size = new System.Drawing.Size(508, 54);
            this.ButtonsBG_UI.TabIndex = 85560;
            this.ButtonsBG_UI.TabStop = false;
            // 
            // SettingsIcon_PictureBox
            // 
            this.SettingsIcon_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SettingsIcon_PictureBox.Image = global::prop.x64.Settings_64;
            this.SettingsIcon_PictureBox.Location = new System.Drawing.Point(24, 13);
            this.SettingsIcon_PictureBox.Name = "SettingsIcon_PictureBox";
            this.SettingsIcon_PictureBox.Size = new System.Drawing.Size(64, 64);
            this.SettingsIcon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingsIcon_PictureBox.TabIndex = 85575;
            this.SettingsIcon_PictureBox.TabStop = false;
            // 
            // SettingsTitle_Label
            // 
            this.SettingsTitle_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsTitle_Label.BackColor = System.Drawing.Color.Transparent;
            this.SettingsTitle_Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsTitle_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(128)))));
            this.SettingsTitle_Label.Location = new System.Drawing.Point(103, 13);
            this.SettingsTitle_Label.Name = "SettingsTitle_Label";
            this.SettingsTitle_Label.Size = new System.Drawing.Size(374, 45);
            this.SettingsTitle_Label.TabIndex = 85576;
            this.SettingsTitle_Label.Text = "Settings";
            this.SettingsTitle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GeekAssistant_PictureBox
            // 
            this.GeekAssistant_PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GeekAssistant_PictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GeekAssistant_PictureBox.Image = global::prop.GA.Geek_Assistant___50__alpha40;
            this.GeekAssistant_PictureBox.Location = new System.Drawing.Point(24, 360);
            this.GeekAssistant_PictureBox.Name = "GeekAssistant_PictureBox";
            this.GeekAssistant_PictureBox.Size = new System.Drawing.Size(150, 30);
            this.GeekAssistant_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GeekAssistant_PictureBox.TabIndex = 85577;
            this.GeekAssistant_PictureBox.TabStop = false;
            // 
            // Thanks_Label
            // 
            this.Thanks_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Thanks_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Thanks_Label.Location = new System.Drawing.Point(107, 51);
            this.Thanks_Label.Name = "Thanks_Label";
            this.Thanks_Label.Size = new System.Drawing.Size(370, 18);
            this.Thanks_Label.TabIndex = 85591;
            this.Thanks_Label.Text = "How do you want things to roll?";
            this.Thanks_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tooltip
            // 
            this.tooltip.AutomaticDelay = 100;
            this.tooltip.AutoPopDelay = 10000;
            this.tooltip.InitialDelay = 100;
            this.tooltip.ReshowDelay = 0;
            this.tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltip.ToolTipTitle = "Selected:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 400);
            this.Controls.Add(this.Thanks_Label);
            this.Controls.Add(this.GeekAssistant_PictureBox);
            this.Controls.Add(this.SettingsTitle_Label);
            this.Controls.Add(this.SettingsIcon_PictureBox);
            this.Controls.Add(this.VerbousLoggingPrompt_SwitchButton);
            this.Controls.Add(this.AppMode_SwitchButton);
            this.Controls.Add(this.ToU_SwitchButton);
            this.Controls.Add(this.PopupMessages_SwitchButton);
            this.Controls.Add(this.PerformAnimation_SwitchButton);
            this.Controls.Add(this.VerbousLogging_SwitchButton);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.ResetGA_GroupBox);
            this.Controls.Add(this.ButtonsBG_UI);
            this.Controls.Add(this.ShowToolTips_SwitchButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings — Geek Assistant";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResetGA_GroupBox.ResumeLayout(false);
            this.ResetGA_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResetGA_LogsOnly_UI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetGA_Settings_UI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonsBG_UI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsIcon_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeekAssistant_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        public Button ResetGA;
        public GroupBox ResetGA_GroupBox;
        public CheckBox ResetGA_LogsOnly_CheckBox;
        public CheckBox ResetGA_Settings_CheckBox;
        public Button Close_Button;
        public Button ResetGA_SelectAll;
        public PictureBox ButtonsBG_UI;
        public Button VerbousLogging_SwitchButton;
        public Button PopupMessages_SwitchButton;
        public Label ResetGA_Settings_CheckBox_Label;
        public Label ResetGA_LogsOnly_CheckBox_Label;
        public Button ShowToolTips_SwitchButton;
        public Button ToU_SwitchButton;
        public Button AppMode_SwitchButton;
        public Label OpenLogsFolder;
        public ToolTip tooltip;
        public Button VerbousLoggingPrompt_SwitchButton;
        public Button AutoClearLogs_SwitchButton;
        public Button PerformAnimation_SwitchButton;
        public PictureBox SettingsIcon_PictureBox;
        public Label SettingsTitle_Label;
        public PictureBox GeekAssistant_PictureBox;
        public Label Thanks_Label;
        public PictureBox ResetGA_LogsOnly_UI;
        public PictureBox ResetGA_Settings_UI;
        #endregion
    }
}