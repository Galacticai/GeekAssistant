using Managed.Adb;
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

            devMon.Server.DeviceChanged += new(madb_devChanged);

            //Delayed_DeviceChanged_Timer.Tick += new(Delayed_DeviceChanged_Timer_Tick);

            FormClosing += new(Home_FormClosing);
            Move += new(Home_Move);
            GotFocus += new(Home_GotFocus);
            //HelpButtonClicked += new (Home_Help);
            MouseMove += new(Main_MouseMove);

            HomeLoad_Delay_Timer.Tick += new(HomeLoad_Delay_Timer_Tick);

            AutoDetectDeviceInfo_Button.MouseEnter += new(AutoDetectDeviceInfo_Button_MouseEnter);
            AutoDetectDeviceInfo_Button.MouseDown += new(AutoDetectDeviceInfo_Button_MouseDown); AutoDetectDeviceInfo_Button.KeyDown += new(AutoDetectDeviceInfo_Button_MouseDown);
            AutoDetectDeviceInfo_Button.MouseUp += new(AutoDetectDeviceInfo_Button_MouseUp); AutoDetectDeviceInfo_Button.KeyUp += new(AutoDetectDeviceInfo_Button_MouseUp);
            AutoDetectDeviceInfo_Button.Click += new(AutoDetectDeviceInfo_Button_Click);

            ShowPleaseWaitThenAutoDetect_Timer.Tick += new(ShowPleaseWaitThenAutoDetect_Timer_Tick);

            EventHandler Ev__logMouseEnter = new(ShowLog_MouseEnter);
            ShowLog_Button.MouseEnter += Ev__logMouseEnter; log.MouseEnter += Ev__logMouseEnter; ShowLog_Button.MouseEnter += Ev__logMouseEnter;
            ProgressFakeBG_UI.MouseEnter += Ev__logMouseEnter; ProgressBarLabel.MouseEnter += Ev__logMouseEnter;
            EventHandler Ev__log = new(ShowLog_Button_Click);
            ShowLog_Button.Click += Ev__log;

            ShowLog_ErrorBlink_Timer.Tick += new(ShowLog_ErrorBlink_Timer_Tick);
            ShowLog_InfoBlink_Timer.Tick += new(ShowLog_InfoBlink_Timer_Tick);

            SettingsSave_Timer.Tick += new(SettingsSave_Timer_Tick);

            FlashZip_ChooseFile_Button.Click += new(FlashZip_ChooseFile_Button_Click);
            FlashZip_Button.Click += new(FlashZip_Button_Click);
            //X     FlashZip_ChooseFile_TextBox.DoubleClick += new(FlashZip_ChooseFile_TextBox_DoubleClick); 

            log.TextChanged += new(log_TextChanged);

            bar.MouseEnter += new(bar_MouseEnter);
            ProgressBarLabel.MouseEnter += new(ProgressBarLabel_MouseEnter);
            ProgressBarLabel.Click += Ev__log; bar.Click += Ev__log;

            Manufacturer_ComboBox.MouseEnter += new(Manufacturer_ComboBox_MouseEnter);

            AndroidVersion_ComboBox.MouseEnter += new(AndroidVersion_ComboBox_MouseEnter);


            UnlockBL_Button.Click += new(UnlockBL_Button_Click);
            MagiskRoot_Button.Click += new(MagiskRoot_Button_Click);
            InstallBusybox_Button.Click += new(InstallBusybox_Button_Click);
            GA_About_Label.Click += new(GA_About_Label_Click); GeekAssistant.Click += new(GA_About_Label_Click); GeekAssistant_Icon.Click += new(GA_About_Label_Click);

            GA_About_Label_Click_Timer.Tick += new(GA_About_Label_Click_Timer_Tick);


            #region #Debug#

            MetroButton1.Click += new(MetroButton1_Click);
            MetroButton11.Click += new(MetroButton11_Click);
            MetroButton2.Click += new(MetroButton2_Click);
            MetroButton3.Click += new(MetroButton3_Click);
            MetroButton4.Click += new(MetroButton4_Click);
            MetroButton6.Click += new(MetroButton6_Click);
            MetroButton7.Click += new(MetroButton7_Click);
            MetroButton8.Click += new(MetroButton8_Click);

            #endregion 


            #region Left area

            DeviceState_Label.TextChanged += new(DeviceState_Label_TextChanged);

            Manufacturer_ComboBox.SelectedIndexChanged += new(Manufacturer_ComboBox_SelectedIndexChanged);
            AndroidVersion_ComboBox.SelectedIndexChanged += new(AndroidVersion_ComboBox_SelectedIndexChanged);

            BootloaderUnlockable_CheckBox.CheckedChanged += new(BootloaderUnlockable_CheckBox_CheckedChanged);

            Rooted_Checkbox.CheckedChanged += new(Rooted_Checkbox_CheckedChanged);

            CustomROM_CheckBox.CheckedChanged += new(CustomROM_CheckBox_CheckedChanged);

            CustomRecovery_CheckBox.CheckedChanged += new(CustomRecovery_CheckBox_CheckedChanged);

            #endregion


            #region Upper right buttons

            Settings_Button.MouseEnter += new(Settings_Button_MouseEnter);
            Settings_Button.Click += new(Settings_Button_Click);

            About_Button.MouseEnter += new(About_Button_MouseEnter);
            About_Button.Click += new(About_Button_Click);

            Donate_Button.Click += new(Donate_Button_Click);
            Donate_Button.MouseEnter += new(Donate_Button_MouseEnter);

            Feedback_Button.MouseEnter += new(Feedback_Button_MouseEnter);
            Feedback_Button.Click += new(Feedback_Button_Click);

            SwitchTheme_Button.Click += new(SwitchTheme_Button_Click);
            SwitchTheme_Button.MouseEnter += new(SwitchTheme_Button_MouseEnter);

            #endregion


            #region "log area"

            CopyLogToClipboard.MouseEnter += new(CopyLogToClipboard_MouseEnter);
            CopyLogToClipboard.MouseDown += new(CopyLogToClipboard_MouseDown);

            CopyLogToClipboard.MouseUp += new(CopyLogToClipboard_MouseUp);
            CopyLogToClipboard.Click += new(CopyLogToClipboard_Click);

            ClearLog_Button.MouseEnter += new(ClearLog_Button_MouseEnter);
            ClearLog_Button.MouseDown += new(ClearLog_Button_MouseDown); ClearLog_Button.KeyDown += new(ClearLog_Button_MouseDown);
            ClearLog_Button.MouseUp += new(ClearLog_Button_MouseUp); ClearLog_Button.KeyUp += new(ClearLog_Button_MouseUp);
            ClearLog_Button.Click += new(ClearLog_Button_Click);

            OpenLogFolder.MouseEnter += new(OpenLogFolder_MouseEnter);
            OpenLogFolder.MouseDown += new(OpenLogFolder_MouseDown); OpenLogFolder.KeyDown += new(OpenLogFolder_MouseDown);
            OpenLogFolder.MouseUp += new(OpenLogFolder_MouseUp); OpenLogFolder.KeyUp += new(OpenLogFolder_MouseUp);
            OpenLogFolder.Click += new(OpenLogFolder_Click);

            //manualCMD_TextBox.MouseEnter += new(manualCMD_TextBox_MouseEnter_MouseLeave_TextChanged; manualCMD_TextBox.MouseLeave += new(manualCMD_TextBox_MouseEnter_MouseLeave_TextChanged; manualCMD_TextBox.TextChanged += new(manualCMD_TextBox_MouseEnter_MouseLeave_TextChanged;
            //manualCMD_TextBox.KeyDown += new(manualCMD_TextBox_KeyDown;
            //manualCMD_TextBox.KeyUp += new(manualCMD_TextBox_KeyUp;

            #endregion
        }

        private DeviceMonitor devMon = new(AndroidDebugBridge.Bridge);
        private void madb_devChanged(object sender, EventArgs e) {
            if (!finishedLoading) return; //Cancel while loading Home()
            //Invoke(new Action(() => { Delayed_DeviceChanged_Timer.Start(); }));
            Invoke(new Action(() => {
                AutoDetect.Run(true);
                GA_Log.LogEvent(DeviceState_Label.Text, 1);
            }));
        }
        /*//private ManagementEventWatcher EventWatcher;
       //private WqlEventQuery EventQuery = new();
       private int saved_devCount = -1; //not 0 or 1 to initialize
       //private Timer Delayed_DeviceChanged_Timer = new() { Interval = 200 }; //delay to avoid repeating the code when the event is firing too many times 
       //private void EventWatcher_EventArrived(object sender, EventArrivedEventArgs ev) {
       //    if (!finishedLoading) return; //Cancel while loading Home()
       //    Invoke(new Action(() => { Delayed_DeviceChanged_Timer.Start(); }));
       //}
      private void Delayed_DeviceChanged_Timer_Tick(object sender, DeviceEventArgs e) {
           //if (e.Device.IsOffline)
           var devCount = madb.GetDeviceCount();
           if (saved_devCount != devCount) {
               saved_devCount = devCount;
           }
           Delayed_DeviceChanged_Timer.Stop();
       }*/

        private void Home_FormClosing(object sender, EventArgs e) {
            if (Application.OpenForms.OfType<PleaseWait>().Any()) { //Cancel if a process by GA is currently running
                System.Media.SystemSounds.Beep.Play();
                return;
            }
            if (GA_HideAllForms.HiddenForms != null) return; //Stop if hiding all forms
            //EventWatcher.Stop();

            GA_Log.LogEvent("End", 3);
            GA_Log.CreateLog();
            c.S.Save();
            //Environment.Exit(Environment.ExitCode)   //Quit all threads while closing
            Process.GetCurrentProcess().Kill(); //Kill Geek Assistant completely in case any thread was locking Environment.Exit
        }
        private void Home_GotFocus(object sender, EventArgs e) {
            if (!finishedLoading) new PleaseWait().BringToFront();
        }
        private void Home_Move(object sender, EventArgs e) {
            //if () ;
            //24, 97  
            PleaseWait PleaseWait = new PleaseWait();
            var titleHeight = RectangleToScreen(ClientRectangle).Top - Top;
            PleaseWait.SetBounds(Location.X + 24, Location.Y + 97 + titleHeight, PleaseWait.Width, PleaseWait.Height);
        }
        /*private void Home_Help(object sender, EventArgs e) {
            common.ToU().ShowDialog();
        }*/
        private bool finishedLoading = false;
        private Timer HomeLoad_Delay_Timer = new() { Interval = 200 };
        private void Home_Load(object sender, EventArgs e) {
            //EventQuery = new WqlEventQuery("Select * from Win32_DeviceChangeEvent"); //("SELECT * FROM __InstanceCreationEvent  WITHIN 2 WHERE TargetInstance ISA //Win32_PnPEntity//") //("Select * from Win32_DeviceChangeEvent") 
            //EventWatcher = new ManagementEventWatcher(EventQuery);
            //EventWatcher.Start();
            devMon.Start();

            AssignEvents();

            Enabled = false; //Opacity = 0;
            Width = 690;

            Preparing Preparing = new Preparing();
            Preparing.Show();
            Preparing.TopMost = true;
            Preparing.BringToFront();
            HomeLoad_Delay_Timer.Enabled = true;
        }
        private bool OneTimebool_HomeLoad_Delay_Timer_Tick = true;
        private void HomeLoad_Delay_Timer_Tick(object sender, EventArgs e) {

            GA_SetTheme.Run(this, true); //Set width to avoid using the width selected while developing
            if (OneTimebool_HomeLoad_Delay_Timer_Tick) { OneTimebool_HomeLoad_Delay_Timer_Tick = false; return; }

            HomeLoad_Delay_Timer.Enabled = false;
            Text = GA_Ver.Run("MainTitle");
            GA_About_Label.Text = GA_Ver.Run("Main");
            log.Text = GA_Ver.Run("log");
            //htmlLog.DocumentText = Markdig.Markdown.ToHtml($"### {GA_Ver.Run("log")}")

            if (c.S.AutoClearLogs) GA_Log.ClearIf30days();
            GA_Log.LogEvent("Start", 1);
            GA_PrepareAppdata.Run();
            GA_adb_Functions.PrepareAndroidDictionary();
            GA_adb_Functions.ResetDeviceInfo();

            AutoDetect.Run(true);
            if (DeviceState_Label.Text != "Disconnected")
                GA_Log.LogEvent(DeviceState_Label.Text, 1);

            DoNeutral();
            AutoDetectDeviceInfo_Button.Select();
            BringToFront();
            //####### DEBUG #####################################
            if (c.V.Revision == 3) debuggingBox.Visible = true;
            //###################################################
            Enabled = true; //Opacity = 100;
            finishedLoading = true;
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
            if (c.S.DarkTheme) {
                AutoDetectDeviceInfo_Button.ForeColor = Color.FromArgb(0, 128, 32);
                AutoDetectDeviceInfo_Button.Image = prop.x64.AutoDetect_64;
            } else {
                AutoDetectDeviceInfo_Button.ForeColor = Color.FromArgb(95, 191, 119);
                AutoDetectDeviceInfo_Button.Image = prop.x64.AutoDetect_dark_64;
            }
        }
        private void AutoDetectDeviceInfo_Button_MouseUp(object sender, EventArgs e) {
            if (c.S.DarkTheme) {
                AutoDetectDeviceInfo_Button.ForeColor = Color.FromArgb(95, 191, 119);
                AutoDetectDeviceInfo_Button.Image = prop.x64.AutoDetect_dark_64;
            } else {
                AutoDetectDeviceInfo_Button.ForeColor = Color.FromArgb(0, 128, 32);
                AutoDetectDeviceInfo_Button.Image = prop.x64.AutoDetect_64;
            }
        }
        private void AutoDetectDeviceInfo_Button_Click(object sender, EventArgs e) {
            GA_PleaseWait.Run(true);
            ShowPleaseWaitThenAutoDetect_Timer.Start(); //delay to let PleaseWait() completely render before it closes (looks like a glitch without a delay)
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
                if (!c.S.PerformAnimations) {
                    Width = HomeWidth[0];
                    return;
                }
                Transition.run(this, "Width", HomeWidth[0], new TransitionType_CriticalDamping(500));
            } else if (Width == HomeWidth[0]) {
                if (c.S.PerformAnimations)
                    Transition.run(this, "Width", HomeWidth[1], new TransitionType_CriticalDamping(500));
                else Width = HomeWidth[1];
            }
        }


        private void ShowLog_ErrorBlink_Timer_Tick(object sender, EventArgs e) {

            MaterialSkin.Controls.MaterialFlatButton slb = ShowLog_Button;
            {
                if ((string)slb.Tag == " ") {
                    slb.Tag = "  ";
                    if (c.S.DarkTheme) slb.Icon = prop.x24.Warning_Red_dark_24;
                    else slb.Icon = prop.x24.Warning_Red_24;

                } else {
                    slb.Tag = " ";
                    if (c.S.DarkTheme) slb.Icon = prop.x24.Warning_Red_24;
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
                        if (c.S.DarkTheme) slb.Icon = prop.x24.Info_Yellow_dark_24;
                        else slb.Icon = prop.x24.Info_Yellow_24;
                    } else {
                        slb.Tag = " ";
                        if (c.S.DarkTheme) slb.Icon = prop.x24.Info_Yellow_24;
                        else slb.Icon = prop.x24.Info_Yellow_dark_24;

                    }
                }
            }
        }

        private void SettingsSave_Timer_Tick(object sender, EventArgs e) {
            c.S.Save();
        }

        private void FlashZip_ChooseFile_Button_Click(object sender, EventArgs e) {
            if (FlashZip_OpenFileDialog.ShowDialog() == DialogResult.OK) {
                GA_Log.LogAppendText($"// Flash ZIP //\nSelected file: {FlashZip_OpenFileDialog.FileName}", 2);
                //FlashZip_ChooseFile_TextBox.Text = FlashZip_OpenFileDialog.FileName;
            }
        }

        private void FlashZip_Button_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(FlashZip_OpenFileDialog.FileName))
                FlashZip_ChooseFile_Button.PerformClick();
            if (string.IsNullOrEmpty(FlashZip_OpenFileDialog.FileName))
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
            if (c.S.DarkTheme) ShowLog_Button.Icon = prop.x24.Commands_dark_24;
            else ShowLog_Button.Icon = prop.x24.Commands_24;

            bar.Style = MetroFramework.MetroColorStyle.Green;
            bar.Value = 0;
            ProgressBarLabel.Text = "Current process information will be written here. Click for more information >>";
        }

        private void UnlockBL_Button_Click(object sender, EventArgs e) {
            UnlockBL.Run();
        }

        private void MagiskRoot_Button_Click(object sender, EventArgs e) {
            inf.detail.code = "MR-00";
            GA_FeatureUnavailable.Run("Root with magisk");
        }

        private void HotReboot_Button_Click(object sender, EventArgs e) {
            if (!CheckConnectionIsCompatible.adbIsCompatible("HR")) { // Hot Reboot 
                inf.Run(inf.detail.lvl, inf.detail.title, inf.detail.msg);
                return;
            }
            GA_Log.LogEvent("Hot Reboot", 2);
            GA_SetProgressText.Run("Attempting hot reboot...", -1);
            var hr = GA_adb_Functions.HotReboot("HR");
            if (!string.IsNullOrEmpty(hr))
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
                    if (c.S.DarkTheme) {
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
            if (c.Working) Manufacturer_ComboBox.Text = c.S.DeviceManufacturer;
            else c.S.DeviceManufacturer = Manufacturer_ComboBox.Text;
        }
        private void AndroidVersion_ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (c.Working) AndroidVersion_ComboBox.Text = GA_adb_Functions.ConvertAPILevelToAVer(c.S.DeviceAPILevel, true)[0];
            //TODO: //else common.S.DeviceAPILevel = GA_adb_Functions.ConvertAVerToAPILevel(AndroidVersion_ComboBox.Text);
        }
        private void BootloaderUnlockable_CheckBox_CheckedChanged(object sender, EventArgs e) {
            if (c.Working) BootloaderUnlockable_CheckBox.Checked = c.S.DeviceBootloaderUnlockSupported;
            else c.S.DeviceBootloaderUnlockSupported = BootloaderUnlockable_CheckBox.Checked;
        }
        private void Rooted_Checkbox_CheckedChanged(object sender, EventArgs e) {
            if (c.Working) Rooted_Checkbox.Checked = c.S.DeviceRooted;
            else c.S.DeviceRooted = Rooted_Checkbox.Checked;
        }
        private void CustomROM_CheckBox_CheckedChanged(object sender, EventArgs e) {
            if (c.Working) CustomROM_CheckBox.Checked = c.S.DeviceCustomROM;
            else c.S.DeviceCustomROM = CustomROM_CheckBox.Checked;
        }
        private void CustomRecovery_CheckBox_CheckedChanged(object sender, EventArgs e) {
            if (c.Working) CustomRecovery_CheckBox.Checked = c.S.DeviceCustomRecovery;
            else c.S.DeviceCustomRecovery = CustomRecovery_CheckBox.Checked;

        }

        #endregion

        #region Upper right buttons
        private void Settings_Button_MouseEnter(object sender, EventArgs e) {
            GA_SetTooltipInfo.Run(ref Main_ToolTip, Settings_Button, "Settings()", "Reset / Modify various options inside Geek Assistant");
        }
        private void Settings_Button_Click(object sender, EventArgs e) {
            Settings Settings = new Settings(); Settings.ShowDialog();
        }

        private void About_Button_MouseEnter(object sender, EventArgs e) {
            GA_SetTooltipInfo.Run(ref Main_ToolTip, About_Button, "About Geek Assistant", "View some information about this program");
        }
        private void About_Button_Click(object sender, EventArgs e) {
            ToU ToU = new ToU();
            ToU.RunningAlready = true;
            ToU.ShowDialog();
        }
        private void Donate_Button_Click(object sender, EventArgs e) {
            Donate Donate = new Donate();
            if (Application.OpenForms.OfType<Donate>().Any())
                Donate.Close();
            Donate.Show();
        }
        private void Donate_Button_MouseEnter(object sender, EventArgs e) {
            GA_SetTooltipInfo.Run(ref Main_ToolTip, Donate_Button, "Send love", "Support the Developer.");
        }

        private void Feedback_Button_MouseEnter(object sender, EventArgs e) {
            GA_SetTooltipInfo.Run(ref Main_ToolTip, Feedback_Button, "Send Feedback", $"Reach out to the developer.");
        }
        private void Feedback_Button_Click(object sender, EventArgs e) {
            if (inf.Run(inf.lvls.Question,
                        "Send Feedback",
                          $"Redirecting you to Geek Assistant issues section on github...\n\nDo you want To Continue?",
                        ("Continue", "Close"),
                        (new Image[2] { prop.x64.Smile_64, prop.x64.Smile_dark_64 },
                        new Color[2] { Color.FromArgb(0, 102, 71), Color.FromArgb(191, 255, 191) })))
                Process.Start(new ProcessStartInfo("https://github.com/NHKomaiha/Geek-Assistant/issues") { UseShellExecute = true, Verb = "open" });
        }
        private void SwitchTheme_Button_Click(object sender, EventArgs e) {
            GA_SetTheme.Run(this);
            c.S.DarkTheme = !c.S.DarkTheme;
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
            GA_SetTooltipInfo.Run(ref Main_ToolTip, OpenLogFolder, "Open logs folder", c.GA_logs);
        }
        private void OpenLogFolder_MouseDown(object sender, EventArgs e) {
            OpenLogFolder.Image = prop.x24.OpenFolder_W_24;
        }
        private void OpenLogFolder_MouseUp(object sender, EventArgs e) {
            OpenLogFolder.Image = prop.x24.OpenFolder_B_24;
        }

        private void OpenLogFolder_Click(object sender, EventArgs e) {
            Process.Start(c.GA_logs);
        }

        private void manualCMD_TextBox_MouseEnter_MouseLeave_TextChanged(object sender, EventArgs e) {
            DoNeutral();
        }

        private void Main_ToolTip_Popup(object sender, PopupEventArgs e) {

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

