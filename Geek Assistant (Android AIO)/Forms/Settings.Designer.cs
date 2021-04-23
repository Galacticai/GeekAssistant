
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

            this.tooltip.AutomaticDelay = 100;
            this.tooltip.AutoPopDelay = 10000;
            this.tooltip.InitialDelay = 100;
            this.tooltip.ReshowDelay = 0;
            this.tooltip.ToolTipIcon = ToolTipIcon.Info;
            this.tooltip.ToolTipTitle = "Selected:";
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
            this.SettingsTitle_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(125)))));
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
            this.Controls.Add(this.ShowToolTips_SwitchButton);
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
            ResetGA.Click += ResetGA_Click;

            ResetGA.MouseEnter += ResetGA_MouseEnter;

            ResetGA.MouseDown += ResetGA_MouseDown;

            Close_Button.Click += Close_Button_Click;

            ResetGA.MouseUp += ResetGA_MouseUp;

            ResetGA_SelectAll.MouseEnter += ResetGA_SelectAll_MouseEnter; ResetGA_SelectAll.MouseDown += ResetGA_SelectAll_MouseDown;
            ResetGA_SelectAll.MouseUp += ResetGA_SelectAll_MouseUp; ResetGA_SelectAll.Click += ResetGA_SelectAll_Click;

            ResetGA_Settings_CheckBox.CheckedChanged += ResetGA_Settings_LogsOnly_CheckBox_CheckedChanged; ResetGA_LogsOnly_CheckBox.CheckedChanged += ResetGA_Settings_LogsOnly_CheckBox_CheckedChanged;
            ResetGA_Settings_CheckBox.MouseEnter += ResetGA_Settings_CheckBox_AndLabel_MouseEnter; ResetGA_Settings_CheckBox_Label.MouseEnter += ResetGA_Settings_CheckBox_AndLabel_MouseEnter;
            ResetGA_Settings_CheckBox_Label.Click += ClearData_Settings_CheckBox_Label_Click; ResetGA_Settings_UI.Click += ClearData_Settings_CheckBox_Label_Click;

            ResetGA_LogsOnly_CheckBox.MouseEnter += ResetGA_LogsOnly_CheckBox_AndLabel_MouseEnter; ResetGA_LogsOnly_CheckBox_Label.MouseEnter += ResetGA_LogsOnly_CheckBox_AndLabel_MouseEnter;
            ResetGA_LogsOnly_CheckBox_Label.Click += ResetGA_LogsOnly_CheckBox_Label_Click;
            ResetGA_LogsOnly_UI.Click += ResetGA_LogsOnly_CheckBox_Label_Click;

            ToU_SwitchButton.MouseDown += ToU_SwitchButton_MouseDown; ToU_SwitchButton.KeyDown += ToU_SwitchButton_MouseDown;
            ToU_SwitchButton.MouseUp += ToU_SwitchButton_MouseUp; ToU_SwitchButton.KeyUp += ToU_SwitchButton_MouseUp;
            ToU_SwitchButton.MouseEnter += ToU_SwitchButton_MouseEnter; ToU_SwitchButton.MouseEnter += ToU_SwitchButton_MouseEnter;
            ToU_SwitchButton.MouseUp += ToU_SwitchButton_MouseUp; ToU_SwitchButton.KeyUp += ToU_SwitchButton_MouseUp;
            ToU_SwitchButton.MouseLeave += ToU_SwitchButton_MouseLeave;
            ToU_SwitchButton.Click += ToU_SwitchButton_Click;

            AppMode_SwitchButton.MouseDown += AppMode_SwitchButton_MouseDown; AppMode_SwitchButton.KeyDown += AppMode_SwitchButton_MouseDown;
            AppMode_SwitchButton.MouseUp += AppMode_SwitchButton_MouseUp; AppMode_SwitchButton.KeyUp += AppMode_SwitchButton_MouseUp;
            AppMode_SwitchButton.MouseEnter += AppMode_SwitchButton_MouseEnter;
            AppMode_SwitchButton.MouseLeave += AppMode_SwitchButton_MouseLeave;
            AppMode_SwitchButton.Click += AppMode_SwitchButton_Click;

            PopupMessages_SwitchButton.MouseUp += PopupMessages_SwitchButton_MouseUp; PopupMessages_SwitchButton.KeyUp += PopupMessages_SwitchButton_MouseUp;
            PopupMessages_SwitchButton.MouseDown += PopupMessages_SwitchButton_MouseDown; PopupMessages_SwitchButton.KeyDown+= PopupMessages_SwitchButton_MouseDown;
            PopupMessages_SwitchButton.MouseEnter += PopupMessages_SwitchButton_MouseEnter;
            PopupMessages_SwitchButton.MouseLeave += PopupMessages_SwitchButton_MouseLeave;
            PopupMessages_SwitchButton.Click += PopupMessages_SwitchButton_Click;

            VerbousLogging_SwitchButton.MouseDown += VerbousLogging_SwitchButton_MouseDown; VerbousLogging_SwitchButton.KeyDown += VerbousLogging_SwitchButton_MouseDown;
            VerbousLogging_SwitchButton.MouseUp += VerbousLogging_SwitchButton_MouseUp; VerbousLogging_SwitchButton.KeyUp += VerbousLogging_SwitchButton_MouseUp;
            VerbousLogging_SwitchButton.MouseEnter += VerbousLogging_SwitchButton_MouseEnter;
            VerbousLogging_SwitchButton.MouseLeave += VerbousLogging_SwitchButton_MouseLeave;
            VerbousLogging_SwitchButton.Click += VerbousLogging_SwitchButton_Click;

            VerbousLoggingPrompt_SwitchButton.MouseDown += VerbousLoggingPrompt_SwitchButton_MouseDown; VerbousLoggingPrompt_SwitchButton.KeyDown += VerbousLoggingPrompt_SwitchButton_MouseDown;
            VerbousLoggingPrompt_SwitchButton.MouseUp += VerbousLoggingPrompt_SwitchButton_MouseUp; VerbousLoggingPrompt_SwitchButton.KeyUp+=VerbousLoggingPrompt_SwitchButton_MouseUp;
            VerbousLoggingPrompt_SwitchButton.MouseEnter += VerbousLoggingPrompt_SwitchButton_MouseEnter;
            VerbousLoggingPrompt_SwitchButton.MouseLeave += VerbousLoggingPrompt_SwitchButton_MouseLeave;
            VerbousLoggingPrompt_SwitchButton.Click += VerbousLoggingPrompt_SwitchButton_Click;

            ShowToolTips_SwitchButton.MouseDown += ShowToolTips_SwitchButton_MouseDown; ShowToolTips_SwitchButton.KeyDown += ShowToolTips_SwitchButton_MouseDown;
            ShowToolTips_SwitchButton.MouseUp += ShowToolTips_SwitchButton_MouseUp; ShowToolTips_SwitchButton.KeyUp += ShowToolTips_SwitchButton_MouseUp;
            ShowToolTips_SwitchButton.MouseEnter += ShowToolTips_SwitchButton_MouseEnter;
            ShowToolTips_SwitchButton.MouseLeave += ShowToolTips_SwitchButton_MouseLeave;
            ShowToolTips_SwitchButton.Click += ShowToolTips_SwitchButton_Click;

            OpenLogsFolder.MouseEnter += OpenLogsFolder_MouseEnter;
            OpenLogsFolder.MouseLeave += OpenLogsFolder_MouseLeave;
            OpenLogsFolder.MouseDown += OpenLogsFolder_MouseDown; OpenLogsFolder.KeyDown += OpenLogsFolder_MouseDown;
            OpenLogsFolder.MouseUp += OpenLogsFolder_MouseUp; OpenLogsFolder.KeyUp += OpenLogsFolder_MouseUp;
            OpenLogsFolder.Click += OpenLogsFolder_Click;

            AutoClearLogs_SwitchButton.MouseDown += AutoClearLogs_SwitchButton_MouseDown; AutoClearLogs_SwitchButton.KeyDown += AutoClearLogs_SwitchButton_MouseDown;
            AutoClearLogs_SwitchButton.MouseUp += AutoClearLogs_SwitchButton_MouseUp; AutoClearLogs_SwitchButton.KeyUp += AutoClearLogs_SwitchButton_MouseUp;
            AutoClearLogs_SwitchButton.MouseEnter += AutoClearLogs_SwitchButton_MouseEnter;
            AutoClearLogs_SwitchButton.MouseLeave += AutoClearLogs_SwitchButton_MouseLeave;
            AutoClearLogs_SwitchButton.Click += AutoClearLogs_SwitchButton_Click;

            PerformAnimation_SwitchButton.MouseDown += PerformAnimation_SwitchButton_MouseDown;  PerformAnimation_SwitchButton.KeyDown += PerformAnimation_SwitchButton_MouseDown;
            PerformAnimation_SwitchButton.MouseUp += PerformAnimation_SwitchButton_MouseUp; PerformAnimation_SwitchButton.KeyUp += PerformAnimation_SwitchButton_MouseUp;
            PerformAnimation_SwitchButton.MouseEnter += PerformAnimation_SwitchButton_MouseEnter;
            PerformAnimation_SwitchButton.MouseLeave += PerformAnimation_SwitchButton_MouseLeave;
            PerformAnimation_SwitchButton.Click += PerformAnimation_SwitchButton_Click;

            this.ResetGA_GroupBox.ResumeLayout(false);
            this.ResetGA_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResetGA_LogsOnly_UI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetGA_Settings_UI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonsBG_UI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsIcon_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeekAssistant_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        private Button ResetGA;
        private GroupBox ResetGA_GroupBox;
        private CheckBox ResetGA_LogsOnly_CheckBox;
        private CheckBox ResetGA_Settings_CheckBox;
        private Button Close_Button;
        private Button ResetGA_SelectAll; 
        private PictureBox ButtonsBG_UI;
        private Button VerbousLogging_SwitchButton;
        private Button PopupMessages_SwitchButton;
        private Label ResetGA_Settings_CheckBox_Label;
        private Label ResetGA_LogsOnly_CheckBox_Label;
        private Button ShowToolTips_SwitchButton;
        private Button ToU_SwitchButton;
        private Button AppMode_SwitchButton;
        private Label OpenLogsFolder;
        private ToolTip tooltip;
        private Button VerbousLoggingPrompt_SwitchButton;
        private Button AutoClearLogs_SwitchButton;
        private Button PerformAnimation_SwitchButton;
        private PictureBox SettingsIcon_PictureBox;
        private Label SettingsTitle_Label;
        private PictureBox GeekAssistant_PictureBox;
        private Label Thanks_Label;
        private PictureBox ResetGA_LogsOnly_UI;
        private PictureBox ResetGA_Settings_UI;
        #endregion
    }
}