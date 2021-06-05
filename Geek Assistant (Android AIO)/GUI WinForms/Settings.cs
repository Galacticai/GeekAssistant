using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GeekAssistant.Forms {
    public partial class Settings : Form {
        private readonly string PopupMessages_SwitchButton_ToolTip = "View a window for messages like errors and info... etc";
        private readonly string VerbousLogging_SwitchButton_ToolTip = $"Add more details to logs like current ongoing actions{c.n}and behind the scenes actions that may not be interesting";
        private readonly string VerbousLoggingPrompt_Tooltip = "Ask to enable verbous logging when an error occurs";
        private readonly string ShowTooltips_SwitchButton_ToolTip = "Show tooltips on various controls for clarification";
        private readonly string ToU_SwitchButton_ToolTip = "Skip Terms of Use window when starting Geek Assistant. [= Accept always]";
        private readonly string AppMode_SwitchButton_ToolTip = $"Skip App Mode window and enter the last chosen{c.n}mode the next time starting Geek Assistant";
        private readonly string AutoClearLogs_SwitchButton_ToolTip = "Auto delete log files that are older than 30 days";
        private readonly string PerformAnimation_SwitchButton_ToolTip = $"Perform theme and movement animations.{c.n}Recommended: Disable for old systems.";

        //private ToolTip tooltip = new ToolTip {};
        public Settings() {
            InitializeComponent();
        }
        private void AssignEvents() {
            Close_Button.Click += new(Close_Button_Click);

            ResetGA.Click += new(ResetGA_Click);
            ResetGA.MouseEnter += new(ResetGA_MouseEnter);
            ResetGA.MouseDown += new(ResetGA_MouseDown);
            ResetGA.MouseUp += new(ResetGA_MouseUp);

            ResetGA_SelectAll.MouseEnter += new(ResetGA_SelectAll_MouseEnter); ResetGA_SelectAll.MouseDown += new(ResetGA_SelectAll_MouseDown);
            ResetGA_SelectAll.MouseUp += new(ResetGA_SelectAll_MouseUp); ResetGA_SelectAll.Click += new(ResetGA_SelectAll_Click);


            ResetGA_Settings_CheckBox.CheckedChanged += new(ResetGA_Settings_LogsOnly_CheckBox_CheckedChanged); ResetGA_LogsOnly_CheckBox.CheckedChanged += new(ResetGA_Settings_LogsOnly_CheckBox_CheckedChanged);
            ResetGA_Settings_CheckBox.MouseEnter += new(ResetGA_Settings_CheckBox_AndLabel_MouseEnter); ResetGA_Settings_CheckBox_Label.MouseEnter += new(ResetGA_Settings_CheckBox_AndLabel_MouseEnter);
            ResetGA_Settings_CheckBox_Label.Click += new(ClearData_Settings_CheckBox_Label_Click); ResetGA_Settings_UI.Click += new(ClearData_Settings_CheckBox_Label_Click);

            ResetGA_LogsOnly_CheckBox.MouseEnter += new(ResetGA_LogsOnly_CheckBox_AndLabel_MouseEnter); ResetGA_LogsOnly_CheckBox_Label.MouseEnter += new(ResetGA_LogsOnly_CheckBox_AndLabel_MouseEnter);
            ResetGA_LogsOnly_CheckBox_Label.Click += new(ResetGA_LogsOnly_CheckBox_Label_Click);
            ResetGA_LogsOnly_UI.Click += new(ResetGA_LogsOnly_CheckBox_Label_Click);

            ToU_SwitchButton.MouseDown += new(ToU_SwitchButton_MouseDown); ToU_SwitchButton.KeyDown += new(ToU_SwitchButton_MouseDown);
            ToU_SwitchButton.MouseUp += new(ToU_SwitchButton_MouseUp); ToU_SwitchButton.KeyUp += new(ToU_SwitchButton_MouseUp);
            ToU_SwitchButton.MouseEnter += new(ToU_SwitchButton_MouseEnter); ToU_SwitchButton.MouseEnter += new(ToU_SwitchButton_MouseEnter);
            ToU_SwitchButton.MouseUp += new(ToU_SwitchButton_MouseUp); ToU_SwitchButton.KeyUp += new(ToU_SwitchButton_MouseUp);
            ToU_SwitchButton.MouseLeave += new(ToU_SwitchButton_MouseLeave);
            ToU_SwitchButton.Click += new(ToU_SwitchButton_Click);

            AppMode_SwitchButton.MouseDown += new(AppMode_SwitchButton_MouseDown); AppMode_SwitchButton.KeyDown += new(AppMode_SwitchButton_MouseDown);
            AppMode_SwitchButton.MouseUp += new(AppMode_SwitchButton_MouseUp); AppMode_SwitchButton.KeyUp += new(AppMode_SwitchButton_MouseUp);
            AppMode_SwitchButton.MouseEnter += new(AppMode_SwitchButton_MouseEnter);
            AppMode_SwitchButton.MouseLeave += new(AppMode_SwitchButton_MouseLeave);
            AppMode_SwitchButton.Click += new(AppMode_SwitchButton_Click);

            PopupMessages_SwitchButton.MouseUp += new(PopupMessages_SwitchButton_MouseUp); PopupMessages_SwitchButton.KeyUp += new(PopupMessages_SwitchButton_MouseUp);
            PopupMessages_SwitchButton.MouseDown += new(PopupMessages_SwitchButton_MouseDown); PopupMessages_SwitchButton.KeyDown += new(PopupMessages_SwitchButton_MouseDown);
            PopupMessages_SwitchButton.MouseEnter += new(PopupMessages_SwitchButton_MouseEnter);
            PopupMessages_SwitchButton.MouseLeave += new(PopupMessages_SwitchButton_MouseLeave);
            PopupMessages_SwitchButton.Click += new(PopupMessages_SwitchButton_Click);

            VerbousLogging_SwitchButton.MouseDown += new(VerbousLogging_SwitchButton_MouseDown); VerbousLogging_SwitchButton.KeyDown += new(VerbousLogging_SwitchButton_MouseDown);
            VerbousLogging_SwitchButton.MouseUp += new(VerbousLogging_SwitchButton_MouseUp); VerbousLogging_SwitchButton.KeyUp += new(VerbousLogging_SwitchButton_MouseUp);
            VerbousLogging_SwitchButton.MouseEnter += new(VerbousLogging_SwitchButton_MouseEnter);
            VerbousLogging_SwitchButton.MouseLeave += new(VerbousLogging_SwitchButton_MouseLeave);
            VerbousLogging_SwitchButton.Click += new(VerbousLogging_SwitchButton_Click);

            VerbousLoggingPrompt_SwitchButton.MouseDown += new(VerbousLoggingPrompt_SwitchButton_MouseDown); VerbousLoggingPrompt_SwitchButton.KeyDown += new(VerbousLoggingPrompt_SwitchButton_MouseDown);
            VerbousLoggingPrompt_SwitchButton.MouseUp += new(VerbousLoggingPrompt_SwitchButton_MouseUp); VerbousLoggingPrompt_SwitchButton.KeyUp += new(VerbousLoggingPrompt_SwitchButton_MouseUp);
            VerbousLoggingPrompt_SwitchButton.MouseEnter += new(VerbousLoggingPrompt_SwitchButton_MouseEnter);
            VerbousLoggingPrompt_SwitchButton.MouseLeave += new(VerbousLoggingPrompt_SwitchButton_MouseLeave);
            VerbousLoggingPrompt_SwitchButton.Click += new(VerbousLoggingPrompt_SwitchButton_Click);

            ShowToolTips_SwitchButton.MouseDown += new(ShowToolTips_SwitchButton_MouseDown); ShowToolTips_SwitchButton.KeyDown += new(ShowToolTips_SwitchButton_MouseDown);
            ShowToolTips_SwitchButton.MouseUp += new(ShowToolTips_SwitchButton_MouseUp); ShowToolTips_SwitchButton.KeyUp += new(ShowToolTips_SwitchButton_MouseUp);
            ShowToolTips_SwitchButton.MouseEnter += new(ShowToolTips_SwitchButton_MouseEnter);
            ShowToolTips_SwitchButton.MouseLeave += new(ShowToolTips_SwitchButton_MouseLeave);
            ShowToolTips_SwitchButton.Click += new(ShowToolTips_SwitchButton_Click);

            OpenLogsFolder.MouseEnter += new(OpenLogsFolder_MouseEnter);
            OpenLogsFolder.MouseLeave += new(OpenLogsFolder_MouseLeave);
            OpenLogsFolder.MouseDown += new(OpenLogsFolder_MouseDown); OpenLogsFolder.KeyDown += new(OpenLogsFolder_MouseDown);
            OpenLogsFolder.MouseUp += new(OpenLogsFolder_MouseUp); OpenLogsFolder.KeyUp += new(OpenLogsFolder_MouseUp);
            OpenLogsFolder.Click += new(OpenLogsFolder_Click);

            AutoClearLogs_SwitchButton.MouseDown += new(AutoClearLogs_SwitchButton_MouseDown); AutoClearLogs_SwitchButton.KeyDown += new(AutoClearLogs_SwitchButton_MouseDown);
            AutoClearLogs_SwitchButton.MouseUp += new(AutoClearLogs_SwitchButton_MouseUp); AutoClearLogs_SwitchButton.KeyUp += new(AutoClearLogs_SwitchButton_MouseUp);
            AutoClearLogs_SwitchButton.MouseEnter += new(AutoClearLogs_SwitchButton_MouseEnter);
            AutoClearLogs_SwitchButton.MouseLeave += new(AutoClearLogs_SwitchButton_MouseLeave);
            AutoClearLogs_SwitchButton.Click += new(AutoClearLogs_SwitchButton_Click);

            PerformAnimation_SwitchButton.MouseDown += new(PerformAnimation_SwitchButton_MouseDown); PerformAnimation_SwitchButton.KeyDown += new(PerformAnimation_SwitchButton_MouseDown);
            PerformAnimation_SwitchButton.MouseUp += new(PerformAnimation_SwitchButton_MouseUp); PerformAnimation_SwitchButton.KeyUp += new(PerformAnimation_SwitchButton_MouseUp);
            PerformAnimation_SwitchButton.MouseEnter += new(PerformAnimation_SwitchButton_MouseEnter);
            PerformAnimation_SwitchButton.MouseLeave += new(PerformAnimation_SwitchButton_MouseLeave);
            PerformAnimation_SwitchButton.Click += new(PerformAnimation_SwitchButton_Click);
        }
        private void Settings_Load(object sender, EventArgs e) {
            AssignEvents();

            CenterToHomeBounds.Run(this);


            SetTheme.Run(this);

            ResetGA_Settings_CheckBox.Checked = false;
            ResetGA_LogsOnly_CheckBox.Checked = false;
            SwitchButton_Style.EnableIfTrue(ToU_SwitchButton, c.S.ToU_dontShow);
            SwitchButton_Style.EnableIfTrue(AppMode_SwitchButton, c.S.AppMode_dontshow);
            SwitchButton_Style.EnableIfTrue(PopupMessages_SwitchButton, c.S.PopupMessages);
            SwitchButton_Style.EnableIfTrue(VerbousLogging_SwitchButton, c.S.VerboseLogging);
            VerbousLoggingStateSet();
            SwitchButton_Style.EnableIfTrue(ShowToolTips_SwitchButton, c.S.ShowToolTips);
            SwitchButton_Style.EnableIfTrue(AutoClearLogs_SwitchButton, c.S.AutoClearLogs);
            SwitchButton_Style.EnableIfTrue(PerformAnimation_SwitchButton, c.S.PerformAnimations);

        }
        #region ResetGA
        private Timer ResetGA_NoItems_Timer = new Timer { Interval = 1500 };
        private void ResetGA_Click(object sender, EventArgs e) {
            inf.detail.workCode = "GAr-00";
            if (!ResetGA_LogsOnly_CheckBox.Checked && !ResetGA_Settings_CheckBox.Checked) {
                ResetGA.Text = "⠀⠀⠀⠀⠀ Select something ...";
                ResetGA_NoItems_Timer.Start();
                ResetGA_NoItems_Timer.Tick += ResetGA_NoItems_Timer_Tick;
                return;
            }
            GAreset.Run(Data, logs);
        }
        private void ResetGA_NoItems_Timer_Tick(object sender, EventArgs e) {
            ResetGA.Text = "⠀⠀⠀⠀⠀ &Reset Geek Assistant";
        }

        private void ResetGA_MouseEnter(object sender, EventArgs e) {
            SetTooltipInfo.Run(ref tooltip, ResetGA, "Reset Geek Assistant", willClear);
            if (willClear == null) {
                SetTooltipInfo.Run(ref tooltip, ResetGA, "Reset Geek Assistant", "First, select something of the above.");
                return;
            }
            if (willClear.Length <= 9) {
                SetTooltipInfo.Run(ref tooltip, ResetGA, "Reset Geek Assistant", "First, select something of the above.");
            }
        }
        private void ResetGA_MouseDown(object sender, EventArgs e) {
            ResetGA.ForeColor = colors.UI.bg();
        }
        private void ResetGA_MouseUp(object sender, EventArgs e) {
            ResetGA.ForeColor = colors.UI.fg();
        }

        //private void Close_Button_MouseDown(object sender, EventArgs e) { Close_Button.MouseDown
        //    Close_Button.ForeColor = GA_SetTheme.Current_fgColor()
        //}
        //private void Close_Button_MouseUp(object sender, EventArgs e) { Close_Button.MouseUp
        //    Close_Button.ForeColor = GA_SetTheme.GA_SetTheme.Current_bgColor()
        //}
        private void Close_Button_Click(object sender, EventArgs e) {
            Close();
        }

        #endregion

        #region "ResetGA_SelectAll"
        private void ResetGA_SelectAll_MouseEnter(object sender, EventArgs e) {
            SetTooltipInfo.Run(ref tooltip, ResetGA_SelectAll, "Select All", tooltip.GetToolTip(ResetGA_SelectAll));
        }
        private void ResetGA_SelectAll_MouseDown(object sender, EventArgs e) {
            if (c.S.DarkTheme) {
                ResetGA_SelectAll.Image = prop.x24.SelectAll_B_24;
            } else {
                ResetGA_SelectAll.Image = prop.x24.SelectAll_W_24;
            }
        }
        private void ResetGA_SelectAll_MouseUp(object sender, EventArgs e) {
            if (c.S.DarkTheme) {
                ResetGA_SelectAll.Image = prop.x24.SelectAll_W_24;
            } else {
                ResetGA_SelectAll.Image = prop.x24.SelectAll_B_24;
            }
        }
        private void ResetGA_SelectAll_Click(object sender, EventArgs e) {
            if (ResetGA_Settings_CheckBox.Checked && ResetGA_LogsOnly_CheckBox.Checked) {
                ResetGA_Settings_CheckBox.Checked = false;
                ResetGA_LogsOnly_CheckBox.Checked = false;
                return;
            }
            ResetGA_Settings_CheckBox.Checked = true;
            ResetGA_LogsOnly_CheckBox.Checked = true;
        }
        #endregion


        public static string willClear;
        private string andstr = " and ";
        private bool Data = false;
        private bool logs = false;
        private void ResetGA_Settings_LogsOnly_CheckBox_CheckedChanged(object sender, EventArgs e) {
            //Directories = false
            Data = false;

            logs = false;

            willClear = "clear";
            if (ResetGA_LogsOnly_CheckBox.Checked) {
                logs = true;
                willClear += " logs";
            }
            if (ResetGA_Settings_CheckBox.Checked) {
                Data = true;
                andstr = " and";
                if (!ResetGA_LogsOnly_CheckBox.Checked) {
                    andstr = "";
                }
                willClear += andstr + " internal data";
            }
            //if ( ResetGA_Settings_CheckBox.Checked <> ResetGA_LogsOnly_CheckBox.Checked ) {
            //    willClear += " only"
            //}
            //willClear += "?"
            SetTooltipInfo.Run(ref tooltip, ResetGA, "Reset Geek Assistant", willClear);
            if (!ResetGA_LogsOnly_CheckBox.Checked && !ResetGA_Settings_CheckBox.Checked) {
                SetTooltipInfo.Run(ref tooltip, ResetGA, "Reset Geek Assistant", "First, select something of the above.");
            }
        }

        ////ResetGA_Settings_CheckBox - Label
        private void ResetGA_Settings_CheckBox_AndLabel_MouseEnter(object sender, EventArgs e) {
            SetTooltipInfo.Run(ref tooltip, ResetGA_Settings_CheckBox, "Internal Data", tooltip.GetToolTip(ResetGA_Settings_CheckBox));
            SetTooltipInfo.Run(ref tooltip, ResetGA_Settings_CheckBox_Label, "Internal Data", tooltip.GetToolTip(ResetGA_Settings_CheckBox_Label));
        }
        private void ClearData_Settings_CheckBox_Label_Click(object sender, EventArgs e) {
            ResetGA_Settings_CheckBox.Checked = !ResetGA_Settings_CheckBox.Checked;
        }

        ////ResetGA_LogsOnly_CheckBox - Label
        private void ResetGA_LogsOnly_CheckBox_AndLabel_MouseEnter(object sender, EventArgs e) {
            SetTooltipInfo.Run(ref tooltip, ResetGA_LogsOnly_CheckBox, "Log files", tooltip.GetToolTip(ResetGA_LogsOnly_CheckBox));
            SetTooltipInfo.Run(ref tooltip, ResetGA_LogsOnly_CheckBox_Label, "Log files", tooltip.GetToolTip(ResetGA_LogsOnly_CheckBox_Label));
        }
        private void ResetGA_LogsOnly_CheckBox_Label_Click(object sender, EventArgs e) {
            ResetGA_LogsOnly_CheckBox.Checked = !ResetGA_LogsOnly_CheckBox.Checked;
        }

        ////ToU_SwitchButton
        private void ToU_SwitchButton_MouseDown(object sender, EventArgs e) {
            SwitchButton_Style.MouseDown(ToU_SwitchButton);
        }
        private void ToU_SwitchButton_MouseUp(object sender, EventArgs e) {
            SwitchButton_Style.MouseUp(ToU_SwitchButton);
        }
        private void ToU_SwitchButton_MouseEnter(object sender, EventArgs e) {
            SetTooltipInfo.Run(ref tooltip, ToU_SwitchButton, "Skip Terms of Use on startup", tooltip.GetToolTip(ToU_SwitchButton));
            SwitchButton_Style.MouseEnter(ToU_SwitchButton, c.S.ToU_dontShow);
        }
        private void ToU_SwitchButton_MouseLeave(object sender, EventArgs e) {
            SwitchButton_Style.MouseLeave(ToU_SwitchButton, c.S.ToU_dontShow);
        }
        private void ToU_SwitchButton_Click(object sender, EventArgs e) {
            c.S.ToU_dontShow =
                SwitchButton_Style.MouseClick(ToU_SwitchButton, c.S.ToU_dontShow, ToU_SwitchButton_ToolTip);
        }

        ////AppMode_SwitchButton
        private void AppMode_SwitchButton_MouseDown(object sender, EventArgs e) {
            SwitchButton_Style.MouseDown(AppMode_SwitchButton);
        }
        private void AppMode_SwitchButton_MouseUp(object sender, EventArgs e) {
            SwitchButton_Style.MouseUp(AppMode_SwitchButton);
        }
        private void AppMode_SwitchButton_MouseEnter(object sender, EventArgs e) {
            SetTooltipInfo.Run(ref tooltip, AppMode_SwitchButton, "Skip App Mode on startup", tooltip.GetToolTip(AppMode_SwitchButton));
            SwitchButton_Style.MouseEnter(AppMode_SwitchButton, c.S.AppMode_dontshow);
        }
        private void AppMode_SwitchButton_MouseLeave(object sender, EventArgs e) {
            SwitchButton_Style.MouseLeave(AppMode_SwitchButton, c.S.AppMode_dontshow);
        }
        private void AppMode_SwitchButton_Click(object sender, EventArgs e) {
            c.S.AppMode_dontshow =
                SwitchButton_Style.MouseClick(AppMode_SwitchButton, c.S.AppMode_dontshow, AppMode_SwitchButton_ToolTip);
        }

        ////PopupMessages_SwitchButton
        private void PopupMessages_SwitchButton_MouseDown(object sender, EventArgs e) {

            SwitchButton_Style.MouseDown(PopupMessages_SwitchButton);
        }
        private void PopupMessages_SwitchButton_MouseUp(object sender, EventArgs e) {
            SwitchButton_Style.MouseUp(PopupMessages_SwitchButton);
        }
        private void PopupMessages_SwitchButton_MouseEnter(object sender, EventArgs e) {

            SetTooltipInfo.Run(ref tooltip, PopupMessages_SwitchButton, "Pop-up Messages", tooltip.GetToolTip(PopupMessages_SwitchButton));
            SwitchButton_Style.MouseEnter(PopupMessages_SwitchButton, c.S.PopupMessages);
        }
        private void PopupMessages_SwitchButton_MouseLeave(object sender, EventArgs e) {
            SwitchButton_Style.MouseLeave(PopupMessages_SwitchButton, c.S.PopupMessages);
        }
        private void PopupMessages_SwitchButton_Click(object sender, EventArgs e) {
            c.S.PopupMessages =
                SwitchButton_Style.MouseClick(PopupMessages_SwitchButton, c.S.PopupMessages, PopupMessages_SwitchButton_ToolTip);
        }

        ////VerbousLogging_SwitchButton
        private void VerbousLogging_SwitchButton_MouseDown(object sender, EventArgs e) {
            SwitchButton_Style.MouseDown(VerbousLogging_SwitchButton);
        }
        private void VerbousLogging_SwitchButton_MouseUp(object sender, EventArgs e) {
            SwitchButton_Style.MouseUp(VerbousLogging_SwitchButton);
        }
        private void VerbousLogging_SwitchButton_MouseEnter(object sender, EventArgs e) {

            SetTooltipInfo.Run(ref tooltip, VerbousLogging_SwitchButton, "Verbous Logging", tooltip.GetToolTip(VerbousLogging_SwitchButton));
            SwitchButton_Style.MouseEnter(VerbousLogging_SwitchButton, c.S.VerboseLogging);
        }
        private void VerbousLogging_SwitchButton_MouseLeave(object sender, EventArgs e) {
            SwitchButton_Style.MouseLeave(VerbousLogging_SwitchButton, c.S.VerboseLogging);
        }
        private void VerbousLogging_SwitchButton_Click(object sender, EventArgs e) {
            c.S.VerboseLogging =
                SwitchButton_Style.MouseClick(VerbousLogging_SwitchButton, c.S.VerboseLogging, VerbousLogging_SwitchButton_ToolTip);
            VerbousLoggingStateSet();
        }
        private void VerbousLoggingStateSet() {
            if (c.S.VerboseLogging) {
                if (c.S.VerboseLoggingPrompt) {
                    VerbousLoggingPrompt_SwitchButton.PerformClick();
                    if (c.S.DarkTheme) {
                        VerbousLoggingPrompt_SwitchButton.BackColor = Color.FromArgb(64, 64, 64);
                    } else {
                        VerbousLoggingPrompt_SwitchButton.BackColor = Color.FromArgb(191, 191, 191);
                    }
                }
                VerbousLoggingPrompt_SwitchButton.Enabled = false;
            } else {
                VerbousLoggingPrompt_SwitchButton.Enabled = true;
                SwitchButton_Style.EnableIfTrue(VerbousLoggingPrompt_SwitchButton, c.S.VerboseLoggingPrompt);
            }
        }

        ////VerbousLoggingPrompt_SwitchButton
        private void VerbousLoggingPrompt_SwitchButton_MouseDown(object sender, EventArgs e) {
            SwitchButton_Style.MouseDown(VerbousLoggingPrompt_SwitchButton);
        }
        private void VerbousLoggingPrompt_SwitchButton_MouseUp(object sender, EventArgs e) {
            SwitchButton_Style.MouseUp(VerbousLoggingPrompt_SwitchButton);
        }
        private void VerbousLoggingPrompt_SwitchButton_MouseEnter(object sender, EventArgs e) {
            SetTooltipInfo.Run(ref tooltip, VerbousLoggingPrompt_SwitchButton, "Verbous Logging Prompt", tooltip.GetToolTip(VerbousLoggingPrompt_SwitchButton));
            SwitchButton_Style.MouseEnter(VerbousLoggingPrompt_SwitchButton, c.S.VerboseLoggingPrompt);
        }
        private void VerbousLoggingPrompt_SwitchButton_MouseLeave(object sender, EventArgs e) {
            SwitchButton_Style.MouseLeave(VerbousLoggingPrompt_SwitchButton, c.S.VerboseLoggingPrompt);
        }
        private void VerbousLoggingPrompt_SwitchButton_Click(object sender, EventArgs e) {
            c.S.VerboseLoggingPrompt =
                SwitchButton_Style.MouseClick(VerbousLoggingPrompt_SwitchButton, c.S.VerboseLoggingPrompt, VerbousLoggingPrompt_Tooltip);
        }

        ////ShowToolTips_SwitchButton
        private void ShowToolTips_SwitchButton_MouseDown(object sender, EventArgs e) {

            SwitchButton_Style.MouseDown(ShowToolTips_SwitchButton);
        }
        private void ShowToolTips_SwitchButton_MouseUp(object sender, EventArgs e) {

            SwitchButton_Style.MouseUp(ShowToolTips_SwitchButton);
        }
        private void ShowToolTips_SwitchButton_MouseEnter(object sender, EventArgs e) {
            SetTooltipInfo.Run(ref tooltip, ShowToolTips_SwitchButton, "Show Tooltips", tooltip.GetToolTip(ShowToolTips_SwitchButton));
            SwitchButton_Style.MouseEnter(ShowToolTips_SwitchButton, c.S.ShowToolTips);
        }
        private void ShowToolTips_SwitchButton_MouseLeave(object sender, EventArgs e) {
            SwitchButton_Style.MouseLeave(ShowToolTips_SwitchButton, c.S.ShowToolTips);
        }
        private void ShowToolTips_SwitchButton_Click(object sender, EventArgs e) {
            c.S.ShowToolTips =
                SwitchButton_Style.MouseClick(ShowToolTips_SwitchButton, c.S.ShowToolTips, ShowTooltips_SwitchButton_ToolTip);
        }

        ////OpenLogsFolder
        private void OpenLogsFolder_MouseEnter(object sender, EventArgs e) {
            OpenLogsFolder.BackColor = Color.Silver;
        }
        private void OpenLogsFolder_MouseLeave(object sender, EventArgs e) {
            OpenLogsFolder.BackColor = Color.Transparent;
        }
        private void OpenLogsFolder_MouseDown(object sender, EventArgs e) {
            OpenLogsFolder.ForeColor = Color.White;
            OpenLogsFolder.BackColor = Color.FromArgb(64, 64, 64);
        }
        private void OpenLogsFolder_MouseUp(object sender, EventArgs e) {

            OpenLogsFolder.ForeColor = Color.FromArgb(64, 64, 64);
            OpenLogsFolder.BackColor = Color.Transparent;
        }
        private void OpenLogsFolder_Click(object sender, EventArgs e) {
            Process.Start(c.GA_logs);
        }

        ////AutoClearLogs_SwitchButton
        private void AutoClearLogs_SwitchButton_MouseDown(object sender, EventArgs e) {
            SwitchButton_Style.MouseDown(AutoClearLogs_SwitchButton);
        }
        private void AutoClearLogs_SwitchButton_MouseUp(object sender, EventArgs e) {
            SwitchButton_Style.MouseUp(AutoClearLogs_SwitchButton);
        }
        private void AutoClearLogs_SwitchButton_MouseEnter(object sender, EventArgs e) {
            SetTooltipInfo.Run(ref tooltip, AutoClearLogs_SwitchButton, "Auto Clear Logs", tooltip.GetToolTip(AutoClearLogs_SwitchButton));
            SwitchButton_Style.MouseEnter(AutoClearLogs_SwitchButton, c.S.AutoClearLogs);
        }
        private void AutoClearLogs_SwitchButton_MouseLeave(object sender, EventArgs e) {
            SwitchButton_Style.MouseLeave(AutoClearLogs_SwitchButton, c.S.AutoClearLogs);
        }
        private void AutoClearLogs_SwitchButton_Click(object sender, EventArgs e) {
            c.S.AutoClearLogs =
                SwitchButton_Style.MouseClick(AutoClearLogs_SwitchButton, c.S.AutoClearLogs, AutoClearLogs_SwitchButton_ToolTip);
        }

        ////PerformAnimation_SwitchButton
        private void PerformAnimation_SwitchButton_MouseDown(object sender, EventArgs e) {
            SwitchButton_Style.MouseDown(PerformAnimation_SwitchButton);
        }
        private void PerformAnimation_SwitchButton_MouseUp(object sender, EventArgs e) {
            SwitchButton_Style.MouseUp(PerformAnimation_SwitchButton);
        }
        private void PerformAnimation_SwitchButton_MouseEnter(object sender, EventArgs e) {
            SetTooltipInfo.Run(ref tooltip, PerformAnimation_SwitchButton, "Perform Theme Animation", tooltip.GetToolTip(PerformAnimation_SwitchButton));
            SwitchButton_Style.MouseEnter(PerformAnimation_SwitchButton, c.S.PerformAnimations);
        }
        private void PerformAnimation_SwitchButton_MouseLeave(object sender, EventArgs e) {
            SwitchButton_Style.MouseLeave(PerformAnimation_SwitchButton, c.S.PerformAnimations);
        }
        private void PerformAnimation_SwitchButton_Click(object sender, EventArgs e) {
            c.S.PerformAnimations =
                SwitchButton_Style.MouseClick(PerformAnimation_SwitchButton, c.S.PerformAnimations, PerformAnimation_SwitchButton_ToolTip);
        }
    }
}