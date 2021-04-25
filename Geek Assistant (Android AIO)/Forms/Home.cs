using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using Transitions;

namespace GeekAssistant.Forms {
    public partial class Home : Form {
        public Home() {
            InitializeComponent();
        }
        private void AssignEvents() {
            EventWatcher.EventArrived += EventWatcher_EventArrived;

            Delayed_DeviceChanged_Timer.Tick += Delayed_DeviceChanged_Timer_Tick;

            FormClosing += Home_FormClosing;
            Move += Home_Move;
            HelpButtonClicked += Home_Help;
            MouseMove += Main_MouseMove;

            HomeLoad_Delay_Timer.Tick += HomeLoad_Delay_Timer_Tick;

            AutoDetectDeviceInfo_Button.MouseEnter += AutoDetectDeviceInfo_Button_MouseEnter;
            AutoDetectDeviceInfo_Button.MouseDown += AutoDetectDeviceInfo_Button_MouseDown; AutoDetectDeviceInfo_Button.KeyDown += AutoDetectDeviceInfo_Button_MouseDown;
            AutoDetectDeviceInfo_Button.MouseUp += AutoDetectDeviceInfo_Button_MouseUp; AutoDetectDeviceInfo_Button.KeyUp += AutoDetectDeviceInfo_Button_MouseUp;
            AutoDetectDeviceInfo_Button.Click += AutoDetectDeviceInfo_Button_Click;

            ShowPleaseWaitThenAutoDetect_Timer.Tick += ShowPleaseWaitThenAutoDetect_Timer_Tick;

            EventHandler Ev__logMouseEnter = new(ShowLog_MouseEnter);
            ShowLog_Button.MouseEnter += Ev__logMouseEnter; log.MouseEnter += Ev__logMouseEnter; ShowLog_Button.MouseEnter += Ev__logMouseEnter;
            ProgressFakeBG_UI.MouseEnter += Ev__logMouseEnter; ProgressBarLabel.MouseEnter += Ev__logMouseEnter;
            EventHandler Ev__log = new(ShowLog_Button_Click);
            ShowLog_Button.Click += Ev__log;

            ShowLog_ErrorBlink_Timer.Tick += ShowLog_ErrorBlink_Timer_Tick;
            ShowLog_InfoBlink_Timer.Tick += ShowLog_InfoBlink_Timer_Tick;

            SettingsSave_Timer.Tick += SettingsSave_Timer_Tick;

            FlashZip_ChooseFile_Button.Click += FlashZip_ChooseFile_Button_Click;
            FlashZip_Button.Click += FlashZip_Button_Click;
            FlashZip_ChooseFile_TextBox.DoubleClick += FlashZip_ChooseFile_TextBox_DoubleClick;

            log.TextChanged += log_TextChanged;

            bar.MouseEnter += bar_MouseEnter;
            ProgressBarLabel.MouseEnter += ProgressBarLabel_MouseEnter;
            ProgressBarLabel.Click += Ev__log; bar.Click += Ev__log;

            Manufacturer_ComboBox.MouseEnter += Manufacturer_ComboBox_MouseEnter;

            AndroidVersion_ComboBox.MouseEnter += AndroidVersion_ComboBox_MouseEnter;


            UnlockBL_Button.Click += UnlockBL_Button_Click;
            MagiskRoot_Button.Click += MagiskRoot_Button_Click;
            InstallBusybox_Button.Click += InstallBusybox_Button_Click;
            GA_About_Label.Click += GA_About_Label_Click; GeekAssistant.Click += GA_About_Label_Click; GeekAssistant_Icon.Click += GA_About_Label_Click;

            GA_About_Label_Click_Timer.Tick += GA_About_Label_Click_Timer_Tick;


            #region #Debug#


            MetroButton1.Click += MetroButton1_Click;
            MetroButton11.Click += MetroButton11_Click;
            MetroButton2.Click += MetroButton2_Click;
            MetroButton3.Click += MetroButton3_Click;
            MetroButton4.Click += MetroButton4_Click;
            MetroButton6.Click += MetroButton6_Click;
            MetroButton7.Click += MetroButton7_Click;
            MetroButton8.Click += MetroButton8_Click;

            #endregion 


            #region Left area

            DeviceState_Label.TextChanged += DeviceState_Label_TextChanged;

            Manufacturer_ComboBox.SelectedIndexChanged += Manufacturer_ComboBox_SelectedIndexChanged;
            AndroidVersion_ComboBox.SelectedIndexChanged += AndroidVersion_ComboBox_SelectedIndexChanged;

            BootloaderUnlockable_CheckBox.CheckedChanged += BootloaderUnlockable_CheckBox_CheckedChanged;

            Rooted_Checkbox.CheckedChanged += Rooted_Checkbox_CheckedChanged;

            CustomROM_CheckBox.CheckedChanged += CustomROM_CheckBox_CheckedChanged;

            CustomRecovery_CheckBox.CheckedChanged += CustomRecovery_CheckBox_CheckedChanged;

            #endregion


            #region Upper right buttons

            Settings_Button.MouseEnter += Settings_Button_MouseEnter;
            Settings_Button.Click += Settings_Button_Click;

            About_Button.MouseEnter += About_Button_MouseEnter;
            About_Button.Click += About_Button_Click;

            Donate_Button.Click += Donate_Button_Click;
            Donate_Button.MouseEnter += Donate_Button_MouseEnter;

            Feedback_Button.MouseEnter += Feedback_Button_MouseEnter;
            Feedback_Button.Click += Feedback_Button_Click;

            SwitchTheme_Button.Click += SwitchTheme_Button_Click;
            SwitchTheme_Button.MouseEnter += SwitchTheme_Button_MouseEnter;

            #endregion


            #region "log area"

            CopyLogToClipboard.MouseEnter += CopyLogToClipboard_MouseEnter;
            CopyLogToClipboard.MouseDown += CopyLogToClipboard_MouseDown;

            CopyLogToClipboard.MouseUp += CopyLogToClipboard_MouseUp;
            CopyLogToClipboard.Click += CopyLogToClipboard_Click;

            ClearLog_Button.MouseEnter += ClearLog_Button_MouseEnter;
            ClearLog_Button.MouseDown += ClearLog_Button_MouseDown; ClearLog_Button.KeyDown += ClearLog_Button_MouseDown;
            ClearLog_Button.MouseUp += ClearLog_Button_MouseUp; ClearLog_Button.KeyUp += ClearLog_Button_MouseUp;
            ClearLog_Button.Click += ClearLog_Button_Click;

            OpenLogFolder.MouseEnter += OpenLogFolder_MouseEnter;
            OpenLogFolder.MouseDown += OpenLogFolder_MouseDown; OpenLogFolder.KeyDown += OpenLogFolder_MouseDown;
            OpenLogFolder.MouseUp += OpenLogFolder_MouseUp; OpenLogFolder.KeyUp += OpenLogFolder_MouseUp;
            OpenLogFolder.Click += OpenLogFolder_Click;

            //manualCMD_TextBox.MouseEnter += manualCMD_TextBox_MouseEnter_MouseLeave_TextChanged; manualCMD_TextBox.MouseLeave += manualCMD_TextBox_MouseEnter_MouseLeave_TextChanged; manualCMD_TextBox.TextChanged += manualCMD_TextBox_MouseEnter_MouseLeave_TextChanged;
            //manualCMD_TextBox.KeyDown += manualCMD_TextBox_KeyDown;
            //manualCMD_TextBox.KeyUp += manualCMD_TextBox_KeyUp;

            #endregion
        }

        private ManagementEventWatcher EventWatcher;
        private WqlEventQuery EventQuery = new();
        private int saved_devCount = -1; //not 0 or 1 to initialize
        private Timer Delayed_DeviceChanged_Timer = new() { Interval = 200 }; //delay to avoid repeating the code when the event is firing too many times 
        private void EventWatcher_EventArrived(object sender, EventArrivedEventArgs ev) {
            Invoke(new Action(() => { Delayed_DeviceChanged_Timer.Enabled = true; }));
        }
        private void Delayed_DeviceChanged_Timer_Tick(object sender, EventArgs e) {
            var devCount = madb.GetDeviceCount();
            if (saved_devCount != devCount) {
                saved_devCount = devCount;
                (new Action(() => MessageBox.Show("Hello"))).BeginInvoke(null, null);
                Invoke(new Action(() => {
                    AutoDetect.Run(true);
                    GA_Log.LogEvent(DeviceState_Label.Text, 1);
                }));
            }
            Delayed_DeviceChanged_Timer.Stop();
        }

        void Home_FormClosing(object sender, EventArgs e) {
            if (Application.OpenForms.OfType<PleaseWait>().Any()) { //Cancel if a process by GA is currently running
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            if (GA_HideAllForms.HiddenFormsList.Count > 0) return; //Stop if hiding all forms
            EventWatcher.Stop();

            GA_Log.LogEvent("End", 3);
            GA_Log.CreateLog();
            common.S.Save();
            //Environment.Exit(Environment.ExitCode)   //Quit all threads while closing
            Process.GetCurrentProcess().Kill(); //Kill Geek Assistant completely in case any thread was locking Environment.Exit
        }
        private void Home_Move(object sender, EventArgs e) { //MyBase.Move
                                                             //24, 97  
            var titleHeight = RectangleToScreen(ClientRectangle).Top - Top;
            common.PleaseWait.SetBounds(Location.X + 24, Location.Y + 97 + titleHeight, common.PleaseWait.Width, common.PleaseWait.Height);
        }
        private void Home_Help(object sender, EventArgs e) {
            common.ToU.ShowDialog();
        }

        private Timer HomeLoad_Delay_Timer = new() { Interval = 200 };
        private void Home_Load(object sender, EventArgs e) {
            AssignEvents();
            Opacity = 0;

            common.Preparing.Show();
            common.Preparing.BringToFront();
            HomeLoad_Delay_Timer.Enabled = true;
        }
        private void HomeLoad_Delay_Timer_Tick(object sender, EventArgs e) {

            HomeLoad_Delay_Timer.Stop();
            GA_SetTheme.Run(Name, true);
            Width = 690; //Set width to avoid using the width selected while developing

            Text = GA_Ver.Run("MainTitle");
            GA_About_Label.Text = GA_Ver.Run("Main");
            log.Text = GA_Ver.Run("log");
            //htmlLog.DocumentText = Markdig.Markdown.ToHtml($"### {GA_Ver.Run("log")}")

            if (common.S.AutoClearLogs)
                GA_Log.ClearIf30days();
            GA_Log.LogEvent("Start", 1);
            GA_PrepareAppdata.Run();
            GA_adb_Functions.PrepareAndroidDictionary();
            GA_adb_Functions.ResetDeviceInfo();

            AutoDetect.Run(true);
            if (DeviceState_Label.Text != "Disconnected")
                GA_Log.LogEvent(DeviceState_Label.Text, 1);

            EventQuery = new WqlEventQuery("Select * from Win32_DeviceChangeEvent"); //("SELECT * FROM __InstanceCreationEvent  WITHIN 2 WHERE TargetInstance ISA //Win32_PnPEntity//") //("Select * from Win32_DeviceChangeEvent") 
            EventWatcher = new ManagementEventWatcher(EventQuery);
            EventWatcher.Start();

            DoNeutral();
            AutoDetectDeviceInfo_Button.Select();
            BringToFront();
            //####### DEBUG #####################################
            if (common.V.Revision == 3) debuggingBox.Visible = true;
            //###################################################
            Opacity = 100;

        }

        private void Main_HelpButtonClicked() {
            MessageBox.Show(prop.strings.FeatureUnavailable, "Help - Geek Assistant", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Media.SystemSounds.Beep.Play();
        }
        private void Main_MouseMove(object sender, EventArgs e) {
            GA_SetTooltipInfo.Run(ref Main_ToolTip, this, "Selected:", null);
        }

        private void AutoDetectDeviceInfo_Button_MouseEnter(object sender, EventArgs e) {
            GA_SetTooltipInfo.Run(ref Main_ToolTip, AutoDetectDeviceInfo_Button, "Auto Detect", "Let Geek Assistant automatically detect your device//s information");
        }
        private void AutoDetectDeviceInfo_Button_MouseDown(object sender, EventArgs e) {
            if (common.S.DarkTheme) {
                AutoDetectDeviceInfo_Button.ForeColor = Color.FromArgb(0, 128, 32);
                AutoDetectDeviceInfo_Button.Image = prop.x64.AutoDetect_64;
            } else {
                AutoDetectDeviceInfo_Button.ForeColor = Color.FromArgb(95, 191, 119);
                AutoDetectDeviceInfo_Button.Image = prop.x64.AutoDetect_dark_64;
            }
        }
        private void AutoDetectDeviceInfo_Button_MouseUp(object sender, EventArgs e) {
            if (common.S.DarkTheme) {
                AutoDetectDeviceInfo_Button.ForeColor = Color.FromArgb(95, 191, 119);
                AutoDetectDeviceInfo_Button.Image = prop.x64.AutoDetect_dark_64;
            } else {
                AutoDetectDeviceInfo_Button.ForeColor = Color.FromArgb(0, 128, 32);
                AutoDetectDeviceInfo_Button.Image = prop.x64.AutoDetect_64;
            }
        }
        private void AutoDetectDeviceInfo_Button_Click(object sender, EventArgs e) {
            GA_PleaseWait.Run(true);
            ShowPleaseWaitThenAutoDetect_Timer.Start(); //delay to let PleaseWait completely render before it closes (looks like a glitch without a delay)
        }
        private Timer ShowPleaseWaitThenAutoDetect_Timer = new() { Interval = 100 };
        private void ShowPleaseWaitThenAutoDetect_Timer_Tick(object sender, EventArgs e) {
            ShowPleaseWaitThenAutoDetect_Timer.Enabled = false;
            AutoDetect.Run();
        }

        //private void AutoDetectFlash_Timer_Tick(object sender, EventArgs e) { AutoDetectFlash_Timer_Deprecated.Tick
        //    if ( AutoDetectDeviceInfo_Button.BackColor = SystemColors.ButtonFace ) {
        //        AutoDetectDeviceInfo_Button.ForeColor = Color.FromArgb(95, 191, 119)
        //        AutoDetectDeviceInfo_Button.BackColor = Color.FromArgb(190, 240, 190)
        //        AutoDetectDeviceInfo_Button.BackgroundImage = My.Resources.LightBlue_Up_Gradient
        //    } else {
        //        AutoDetectDeviceInfo_Button.ForeColor = Color.FromArgb(0, 128, 32)
        //        AutoDetectDeviceInfo_Button.BackColor = SystemColors.ButtonFace
        //        AutoDetectDeviceInfo_Button.BackgroundImage = null
        //    }
        //} 
        private int[] HomeWidth = { 690, 1190 };
        private void ShowLog_MouseEnter(object sender, EventArgs e) {
            GA_SetTooltipInfo.Run(ref Main_ToolTip, ShowLog_Button, "Show log", "Click to show/hide the log");
            GA_Log.StopNotifyIfLogSeen();
        }
        private void ShowLog_Button_Click(object sender, EventArgs e) {
            ShowLog_ErrorBlink_Timer.Stop();
            ShowLog_InfoBlink_Timer.Stop();
            if (Width == HomeWidth[1]) {
                if (!common.S.PerformAnimations) {
                    Width = HomeWidth[0];
                    return;
                }
                Transition.run(this, "Width", HomeWidth[0], new TransitionType_CriticalDamping(500));
            } else if (Width == HomeWidth[0]) {
                if (common.S.PerformAnimations)
                    Transition.run(this, "Width", HomeWidth[1], new TransitionType_CriticalDamping(500));
                else Width = HomeWidth[1];
            }
        }


        private void ShowLog_ErrorBlink_Timer_Tick(object sender, EventArgs e) {

            MaterialSkin.Controls.MaterialFlatButton slb = ShowLog_Button;
            {
                if ((string)slb.Tag == " ") {
                    slb.Tag = "  ";
                    if (common.S.DarkTheme) slb.Icon = prop.x24.Warning_Red_dark_24;
                    else slb.Icon = prop.x24.Warning_Red_24;

                } else {
                    slb.Tag = " ";
                    if (common.S.DarkTheme) slb.Icon = prop.x24.Warning_Red_24;
                    else slb.Icon = prop.x24.Warning_Red_dark_24;

                }
            }
        }

        private void ShowLog_InfoBlink_Timer_Tick(object sender, EventArgs e) {
            if (ShowLog_ErrorBlink_Timer.Enabled) {
                MaterialSkin.Controls.MaterialFlatButton slb = ShowLog_Button;
                {
                    if ((string)slb.Tag == " ") {
                        slb.Tag = "  ";
                        if (common.S.DarkTheme) slb.Icon = prop.x24.Info_Yellow_dark_24;
                        else slb.Icon = prop.x24.Info_Yellow_24;
                    } else {
                        slb.Tag = " ";
                        if (common.S.DarkTheme) slb.Icon = prop.x24.Info_Yellow_24;
                        else slb.Icon = prop.x24.Info_Yellow_dark_24;

                    }
                }
            }
        }

        private void SettingsSave_Timer_Tick(object sender, EventArgs e) {
            common.S.Save();
        }

        private void FlashZip_ChooseFile_Button_Click(object sender, EventArgs e) {
            if (FlashZip_OpenFileDialog.ShowDialog() == DialogResult.OK) {
                GA_Log.LogAppendText($"// Flash ZIP //\nSelected file: {FlashZip_OpenFileDialog.FileName}", 2);
                FlashZip_ChooseFile_TextBox.Text = FlashZip_OpenFileDialog.FileName;
            }
        }

        private void FlashZip_Button_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(FlashZip_OpenFileDialog.FileName))
                FlashZip_ChooseFile_Button.PerformClick();
            if (String.IsNullOrEmpty(FlashZip_OpenFileDialog.FileName))
                return;

            //FlashFiles.Run(FlashZip_OpenFileDialog.FileName)
        }
        private void FlashZip_ChooseFile_TextBox_DoubleClick(object sender, EventArgs e) {
            FlashZip_ChooseFile_Button.PerformClick();
        }

        private void log_TextChanged(object sender, EventArgs e) {
            if (log.Visible) return;
            if (ShowLog_ErrorBlink_Timer.Enabled == false) ShowLog_InfoBlink_Timer.Enabled = true;

        }
        //Already Done above 
        //private void log_MouseEnter(object sender, EventArgs e) { log.MouseEnter
        //    StopNotifyIfLogSeen()
        //}

        private void bar_MouseEnter(object sender, EventArgs e) {
            GA_SetTooltipInfo.Run(ref Main_ToolTip, bar, "Status percentage", "Click to show/hide the log");
        }
        private void ProgressBarLabel_MouseEnter(object sender, EventArgs e) {
            GA_SetTooltipInfo.Run(ref Main_ToolTip, ProgressBarLabel, "Status", "Click to show/hide the log");
        }
        //private void ProgressBarLabel_Mousedown_KeyDown(object sender, EventArgs e) { ProgressBarLabel.MouseDown, ProgressBarLabel.KeyDown
        //    With ProgressBarLabel
        //        .BackColor = Color.FromArgb(77, 104, 124)
        //        .ForeColor = Color.White
        //    End With
        //}
        //private void ProgressBarLabel_MouseUp_KeyUp(object sender, EventArgs e) { ProgressBarLabel.MouseUp, ProgressBarLabel.KeyUp
        //    With ProgressBarLabel
        //        .BackColor = Color.White
        //        .ForeColor = SystemColors.ControlText
        //    End With
        //}
        private void Manufacturer_ComboBox_MouseEnter(object sender, EventArgs e) {
            GA_SetTooltipInfo.Run(ref Main_ToolTip, Manufacturer_ComboBox, "Manufacturer", "(Required) Select your device//s manufacturer");
        }

        private void AndroidVersion_ComboBox_MouseEnter(object sender, EventArgs e) {
            GA_SetTooltipInfo.Run(ref Main_ToolTip, AndroidVersion_ComboBox, "Android Version", "Select your device//s android version");
        }

        public void DoNeutral() {
            ShowLog_InfoBlink_Timer.Enabled = false;
            ShowLog_ErrorBlink_Timer.Enabled = false;
            if (common.S.DarkTheme) {
                ShowLog_Button.Icon = prop.x24.Commands_dark_24;
            } else {
                ShowLog_Button.Icon = prop.x24.Commands_24;
            }
            bar.Style = MetroFramework.MetroColorStyle.Green;
            bar.Value = 0;
            ProgressBarLabel.Text = "Current process information will be written here. Click for more information >>";
        }

        private void UnlockBL_Button_Click(object sender, EventArgs e) {
            UnlockBL.Run();
        }

        private void MagiskRoot_Button_Click(object sender, EventArgs e) {
            common.ErrorInfo.code = "MR-00";
            GA_FeatureUnavailable.Run("Root with magisk");
        }

        private void HotReboot_Button_Click(object sender, EventArgs e) {
            if (!CheckConnectionIsCompatible.adbIsCompatible("HR")) { // Hot Reboot 
                GA_Msg.DoMsg(common.ErrorInfo.lvl, common.ErrorInfo.msg, 1);
                return;
            }
            GA_Log.LogEvent("Hot Reboot", 2);
            GA_SetProgressText.Run("Attempting hot reboot...", -1);
            var hr = GA_adb_Functions.HotReboot("HR");
            if (!String.IsNullOrEmpty(hr))
                GA_Log.LogAppendText(hr, 1);

        }

        private void InstallBusybox_Button_Click(object sender, EventArgs e) {
            InitializeBusybox.Run(false);
        }

        private Timer GA_About_Label_Click_Timer = new() { Interval = 1500 };
        private string saved_GA_About_Label_Text;
        private void GA_About_Label_Click(object sender, EventArgs e) {
            Clipboard.SetText("Geek Assistant " + GA_About_Label.Text.Substring(0, GA_About_Label.Text.IndexOf("By") - 1));
            saved_GA_About_Label_Text = GA_About_Label.Text;
            GA_About_Label.Text = "Copied version information...";
            GA_About_Label_Click_Timer.Enabled = true;
        }
        private void GA_About_Label_Click_Timer_Tick(object sender, EventArgs e) {
            GA_About_Label_Click_Timer.Enabled = false;
            GA_About_Label.Text = saved_GA_About_Label_Text;
        }

        #region #Debug#
        private void MetroButton1_Click(object sender, EventArgs e) {//MetroButton1.Click
            madb.madbBridgeStart(true);
            GA_Log.LogAppendText("ran madbCreateBridge(true)", 1);
        }
        private void MetroButton11_Click(object sender, EventArgs e) {//MetroButton11.Click
            madb.madbBridgeStart(false);
            GA_Log.LogAppendText("ran madbCreateBridge(false)", 1);
        }
        private void MetroButton2_Click(object sender, EventArgs e) {//MetroButton2.Click
            var i = madb.GetDeviceCount();
            GA_Log.LogAppendText("ran madb_GetDeviceCount()", 1);
            GA_Log.LogAppendText($"Count: {i}", 1);
        }
        private void MetroButton6_Click(object sender, EventArgs e) {//MetroButton6.Click
            madb.madbBridgeStart(true);
            GA_Log.LogAppendText("ran madbCreateBridge_Return(true).Start()", 1);
        }
        private void MetroButton7_Click(object sender, EventArgs e) {//MetroButton7.Click
            madb.madbBridgeStart(false);
            GA_Log.LogAppendText("ran madbBridgeStart(false)", 1);
        }
        private void MetroButton8_Click(object sender, EventArgs e) {//MetroButton8.Click
            madb.madbStop();
            GA_Log.LogAppendText("ran madbStop()", 1);
        }
        private void MetroButton3_Click(object sender, EventArgs e) {//MetroButton3.Click
            var i = madb.GetDeviceState();
            GA_Log.LogAppendText("ran madb_GetDeviceState()", 1);
            var i_s = madb.Convert_DeviceState_IntToString();
            GA_Log.LogAppendText("ran madb_Convert_DeviceState_IntToString()", 1);
            GA_Log.LogAppendText($"State: {i} - {i_s}", 1);
        }

        private void MetroButton4_Click(object sender, EventArgs e) {
            GA_Log.LogAppendText("## Test", 1);
            //WebBrowser1.DocumentText &= "test" & "<br/>" & "> text"
        }

        //private void TextBox1_TextChanged(object sender, EventArgs e)
        //    htmlLog.DocumentText = Markdig.Markdown.ToHtml(TextBox1.Text)
        //}

        #endregion 

        #region Left area

        private void DeviceState_Label_TextChanged(object sender, EventArgs e) {
            switch (DeviceState_Label.Text) {
            case "Disconnected":
            case "Unknown":
                DeviceState_Label.ForeColor = Color.FromArgb(128, 128, 128);
                break;
            case "Offline":
                DeviceState_Label.ForeColor = Color.FromArgb(128, 0, 0);
                break;
            case "Download mode":
            case "Recovery mode":
            case "Fastboot mode":
                DeviceState_Label.ForeColor = Color.FromArgb(128, 128, 0);
                break;
            case "Connected (ADB)":
                if (common.S.DarkTheme) {
                    DeviceState_Label.ForeColor = Color.FromArgb(95, 191, 119);
                } else {
                    DeviceState_Label.ForeColor = Color.FromArgb(0, 128, 32);
                }
                break;
            case "Multiple":
                DeviceState_Label.ForeColor = Color.FromArgb(128, 0, 128);
                break;
            }
        }

        private void Manufacturer_ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (common.Working) Manufacturer_ComboBox.Text = common.S.DeviceManufacturer;
            else common.S.DeviceManufacturer = Manufacturer_ComboBox.Text;
        }
        private void AndroidVersion_ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (common.Working) AndroidVersion_ComboBox.Text = GA_adb_Functions.ConvertAPILevelToAVer(common.S.DeviceAPILevel, true)[0];
            //TODO: //else common.S.DeviceAPILevel = GA_adb_Functions.ConvertAVerToAPILevel(AndroidVersion_ComboBox.Text);
        }
        private void BootloaderUnlockable_CheckBox_CheckedChanged(object sender, EventArgs e) {
            if (common.Working) BootloaderUnlockable_CheckBox.Checked = common.S.DeviceBootloaderUnlockSupported;
            else common.S.DeviceBootloaderUnlockSupported = BootloaderUnlockable_CheckBox.Checked;
        }
        private void Rooted_Checkbox_CheckedChanged(object sender, EventArgs e) {
            if (common.Working) Rooted_Checkbox.Checked = common.S.DeviceRooted;
            else common.S.DeviceRooted = Rooted_Checkbox.Checked;
        }
        private void CustomROM_CheckBox_CheckedChanged(object sender, EventArgs e) {
            if (common.Working) CustomROM_CheckBox.Checked = common.S.DeviceCustomROM;
            else common.S.DeviceCustomROM = CustomROM_CheckBox.Checked;
        }
        private void CustomRecovery_CheckBox_CheckedChanged(object sender, EventArgs e) {
            if (common.Working) CustomRecovery_CheckBox.Checked = common.S.DeviceCustomRecovery;
            else common.S.DeviceCustomRecovery = CustomRecovery_CheckBox.Checked;

        }

        #endregion

        #region Upper right buttons
        private void Settings_Button_MouseEnter(object sender, EventArgs e) {
            GA_SetTooltipInfo.Run(ref Main_ToolTip, Settings_Button, "Settings", "Reset / Modify various options inside Geek Assistant");
        }
        private void Settings_Button_Click(object sender, EventArgs e) {
            common.Settings.ShowDialog();
        }

        private void About_Button_MouseEnter(object sender, EventArgs e) {
            GA_SetTooltipInfo.Run(ref Main_ToolTip, About_Button, "About Geek Assistant", "View some information about this program");
        }
        private void About_Button_Click(object sender, EventArgs e) {
            common.ToU.RunningAlready = true;
            common.ToU.ShowDialog();
        }
        private void Donate_Button_Click(object sender, EventArgs e) {

            if (Application.OpenForms.OfType<Donate>().Any())
                common.Donate.Close();
            common.Donate.Show();
            common.Donate.BringToFront();
        }
        private void Donate_Button_MouseEnter(object sender, EventArgs e) {
            GA_SetTooltipInfo.Run(ref Main_ToolTip, Donate_Button, "Send love", "Support the Developer.");
        }

        private void Feedback_Button_MouseEnter(object sender, EventArgs e) {
            GA_SetTooltipInfo.Run(ref Main_ToolTip, Feedback_Button, "Send Feedback", $"Reach out to the developer.");
        }
        private void Feedback_Button_Click(object sender, EventArgs e) {
            if (GA_infoAsk.Run("Send Feedback",
       $"Redirecting you to Geek Assistant issues section on github...\n\nDo you want To Continue?",
      "Continue", "Cancel"))
                Process.Start("https://github.com/NHKomaiha/Geek-Assistant/issues");
        }
        private void SwitchTheme_Button_Click(object sender, EventArgs e) {
            if (common.S.DarkTheme) {
                GA_SetTheme.Run(Name);
                common.S.DarkTheme = false;
            } else {
                GA_SetTheme.Run(Name);
                common.S.DarkTheme = true;
            }
        }
        private void SwitchTheme_Button_MouseEnter(object sender, EventArgs e) {
            GA_SetTooltipInfo.Run(ref Main_ToolTip, SwitchTheme_Button, "Switch Theme", "Turn the lights on or off!");
        }
        #endregion

        #region "log area"
        private void CopyLogToClipboard_MouseEnter(object sender, EventArgs e) {
            GA_SetTooltipInfo.Run(ref Main_ToolTip, CopyLogToClipboard, "Copy log", "Copy the current log contents to clipboard");
        }
        private void CopyLogToClipboard_MouseDown(object sender, EventArgs e) {
            CopyLogToClipboard.Image = prop.x24.Copy_W_24;
        }
        private void CopyLogToClipboard_MouseUp(object sender, EventArgs e) {
            CopyLogToClipboard.Image = prop.x24.Copy_B_24;
        }
        private void CopyLogToClipboard_Click(object sender, EventArgs e) {
            GA_Log.LogEvent("Copied log to clipboard.", 2);
            Clipboard.SetText(log.Text);
        }

        private void ClearLog_Button_MouseEnter(object sender, EventArgs e) {
            GA_SetTooltipInfo.Run(ref Main_ToolTip, ClearLog_Button, "Clear log", "Save the current log and continue with a new fresh one");
        }
        private void ClearLog_Button_MouseDown(object sender, EventArgs e) {
            ClearLog_Button.Image = prop.x24.Backspace_W_24;
        }
        private void ClearLog_Button_MouseUp(object sender, EventArgs e) {
            ClearLog_Button.Image = prop.x24.Backspace_B_24;
        }
        private void ClearLog_Button_Click(object sender, EventArgs e) {
            GA_Log.ResetLog();
        }

        private void OpenLogFolder_MouseEnter(object sender, EventArgs e) {
            GA_SetTooltipInfo.Run(ref Main_ToolTip, OpenLogFolder, "Open logs folder", common.GA_logs);
        }
        private void OpenLogFolder_MouseDown(object sender, EventArgs e) {
            OpenLogFolder.Image = prop.x24.OpenFolder_W_24;
        }
        private void OpenLogFolder_MouseUp(object sender, EventArgs e) {
            OpenLogFolder.Image = prop.x24.OpenFolder_B_24;
        }

        private void OpenLogFolder_Click(object sender, EventArgs e) {
            Process.Start(common.GA_logs);
        }

        private void manualCMD_TextBox_MouseEnter_MouseLeave_TextChanged(object sender, EventArgs e) {
            DoNeutral();
        }

        /*private string cmd_Previous, cmd_Current;
        private void manualCMD_TextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                manualCMD_TextBox.BackColor = Color.LightBlue;
        }

        private void manualCMD_TextBox_KeyUp(object sender, KeyEventArgs e) {

            var mcmd = manualCMD_TextBox;
            switch (e.KeyCode) {
            case Keys.Enter:  //And adbManualCMD_TextBox.Text != ""
                manualCMD_TextBox.BackColor = Color.White;
                common.ErrorInfo.code = "manualCmd";
                cmd.Run(manualCMD_TextBox.Text);

                cmd_Previous = manualCMD_TextBox.Text;
                GA_SetProgressText.Run("Running adb command...", -1);
                //adbDo(manualCMD_TextBox.Text)
                ////GA_Log.LogEvent("Manual ADB Command", 2)
                manualCMD_TextBox.Text = "";
                ShowLog_InfoBlink_Timer.Start();

                break;
            case Keys.Up:
                if (cmd_Current != manualCMD_TextBox.Text)
                    cmd_Current = manualCMD_TextBox.Text;
                if (manualCMD_TextBox.Text != cmd_Previous) {
                    mcmd.Text = cmd_Previous;
                    mcmd.SelectionStart = manualCMD_TextBox.Text.Length + 99;
                    mcmd.SelectionLength = 0;
                }
                break;
            case Keys.Down:
                mcmd.Text = cmd_Current;
                mcmd.SelectionStart = manualCMD_TextBox.Text.Length + 99;
                mcmd.SelectionLength = 0;
                break;
            }
        }*/

        //} else if ( e.KeyCode = Keys.Control Or e.KeyCode = Keys.Back ) {
        //    SendKeys.SendWait("^+{LEFT}{BACKSPACE}") //Wait for LCtrl+Back combination
        //    //Dim spaceCount As int = 0
        //    //For Each c As Char In manualCMD_TextBox.Text
        //    //    if ( c = " " ) {
        //    //        spaceCount += 1
        //    //    }
        //    //Next
        //    //if ( spaceCount = 0 ) { return;

        //    Dim pos As int = manualCMD_TextBox.Text.LastIndexOf("\")
        //    if ( pos != -1 ) { manualCMD_TextBox.Text = manualCMD_TextBox.Text.Substring(0, pos)
        //    //manualCMD_TextBox.Text = manualCMD_TextBox.Text.Substring(0, manualCMD_TextBox.Text.LastIndexOf(" "))
        //}
    }

    #endregion


}

