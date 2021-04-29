using System;
using System.Drawing;
using System.Windows.Forms;
using GeekAssistant.Forms;

internal static partial class GA_SetTheme {
    private static Timer HomeTheme_delayTimer = new() { Interval = 100 };

    private static PleaseWait pw = null;
    private static Preparing p = null;
    private static AppMode am = null;
    private static Donate d = null;
    private static Info i = null;
    private static Home h = null;
    private static Settings s = null;
    private static ToU t = null;
    public static void Run(Form f, bool initiating = false) {
        //Form Preparing = Application.OpenForms[0];
        //Form AppMode = new();
        //Form Home = new();
        //var form = f;
        //FormName = FormName[..(FormName.Length-2)]; //remove the () at the end which exists in C# form.Name
        initiatingbool = initiating;
        switch (f) { 
        case PleaseWait:
            pw = (PleaseWait)f;
            PleaseWait_Theme(); 
            break;
        case Preparing:
            p = (Preparing)f;
            p.Preparing_Label.ForeColor = c.colors.fg;
            p.BackColor = c.colors.bg;
            break;
        case AppMode:
            am = (AppMode)f;
            //Control am = AppMode;
            SetControlTheme(am);
            am.startup_dontShow.ForeColor = c.colors.fg;
            break;
        case Donate:
            d = (Donate)f;
            Donate_Theme();
            break;
        case Info:
            i = (Info)f;
            Info_Theme();
            break;
        case Home:
            h = (Home)f;
            HomeTheme_delayTimer.Tick += new(HomeTheme_delayTimer_Tick);
            if (c.S.VerboseLogging) {
                string ThemeString = "dark theme";
                if (c.S.DarkTheme)
                    ThemeString = "Light Theme";
                GA_SetProgressText.Run($"Switched to {ThemeString}.", -1);
            }
            if (!initiating & c.S.PerformAnimations) {
                if (c.S.DarkTheme) {
                    h.SwitchTheme_Back_UI.Top = -h.SwitchTheme_Back_UI.Height;
                    Animate.Run(h.SwitchTheme_Back_UI, "Top", new Home().Height, 1000);
                } else {
                    h.SwitchTheme_Back_UI.Top = new Home().Height;
                    Animate.Run(h.SwitchTheme_Back_UI, "Top", -h.SwitchTheme_Back_UI.Height, 1000);
                }
            }
            HomeTheme_delayTimer.Start();
            break;
        case Settings:
            s = (Settings)f;
            Settings_Theme();
            break;
        case ToU:
            t = (ToU)f;
            ToU_Theme();
            break;
        }

    }


    #region Donate
    private static void Donate_Theme() {
        //Donate d = new();
        SetControlsArrTheme(new Control[] { d, d.BitcoinAddress, d.BitcoinNote });
        {
            if (c.S.DarkTheme) {
                d.ButtonsBG_UI.BackColor = Color.FromArgb(32, 32, 32);
                d.Close_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
                d.pic.Image = prop.x64.DonateHeart_Dark_64;
                d.title.ForeColor = Color.FromArgb(255, 191, 217);
                d.BitcoinAddressQR.Image = prop.xXX.BTCAddressQR_Dark;
                d.GooglePayLink.Image = prop.x16.linkIcon_dark_16;
            } else {
                d.ButtonsBG_UI.BackColor = Color.WhiteSmoke;
                d.Close_Button.FlatAppearance.MouseOverBackColor = Color.Silver;
                d.pic.Image = prop.x64.DonateHeart_64;
                d.title.ForeColor = Color.FromArgb(128, 0, 87);
                d.BitcoinAddressQR.Image = prop.xXX.BTCAddressQR;
                d.GooglePayLink.Image = prop.x16.linkIcon_16;
            }
            d.GeekAssistant_PictureBox.BackColor = d.ButtonsBG_UI.BackColor;
        }
    }

    #endregion

    #region Info
    private static void Info_Theme() {
        //Info i = new();
        SetControlsArrTheme(new Control[] { i, i.info_PictureBox, i.msg_Textbox, i.No_Button });
        {
            if (c.S.DarkTheme) {
                i.ButtonsBG_UI.BackColor = Color.FromArgb(32, 32, 32);
                i.Copy_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
                i.Yes_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
                i.No_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            } else {
                i.ButtonsBG_UI.BackColor = Color.WhiteSmoke;
                i.Copy_Button.FlatAppearance.MouseOverBackColor = Color.Silver;
                i.Yes_Button.FlatAppearance.MouseOverBackColor = Color.Silver;
                i.No_Button.FlatAppearance.MouseOverBackColor = Color.Silver;
            }

            i.Yes_Button.ForeColor = i.title_Label.ForeColor;
            i.Yes_Button.FlatAppearance.MouseDownBackColor = i.title_Label.ForeColor;
            i.GeekAssistant_PictureBox.BackColor = i.ButtonsBG_UI.BackColor;
        }
    }
    #endregion

    #region Home 
    private static bool initiatingbool = false;
    private static void HomeTheme_delayTimer_Tick(object sender, EventArgs e) {
        //Home h = new();
        Control[] Controls_array = new Control[] {
            h,
            h.log,
            h.ManualInfo_GroupBox,
            h.ProgressFakeBG_UI,
            h.Main_Tabs,
            h.PrepareYourDevice_Tab,
            h.FlashImg_Tab,
            h.MoreTools_Tab,
            h.BootloaderUnlockable_CheckBox,
            h.CustomROM_CheckBox,
            h.CustomRecovery_CheckBox
        };
        MetroFramework.Interfaces.IMetroControl[] MetroControls_array = new MetroFramework.Interfaces.IMetroControl[] {
            h.Main_Tabs,
            h.PrepareYourDevice_Tab,
            h.FlashImg_Tab,
            h.MoreTools_Tab,
            h.GA_About_Label,
            h.UnlockBL_Label,
            h.MagiskRoot_Label,
            h.Manufacturer_ComboBox,
            h.AndroidVersion_ComboBox,
            h.bar,
            h.UnlockBL_Button,
            h.MagiskRoot_Button,
            h.FlashZip_Button,
            h.ProgressBarLabel
        };//, c.Home.FlashZip_ChooseFile_TextBox, common.Home.manualCMD_TextBox };

        SetControlsArrTheme_Metro(MetroControls_array);

        if (initiatingbool) {

            for (int i = 0; i < Controls_array.Length; i++){
                Controls_array[i].BackColor = c.colors.bg;
                Controls_array[i].ForeColor = c.colors.fg;
            } 

        } else SetControlsArrTheme(Controls_array);

        var h_addb = h.AutoDetectDeviceInfo_Button;
        if (c.S.DarkTheme) {
            // Main.SwitchTheme_Mid_UI.BackColor = Color.FromArgb(235, 245, 235)
            // Transition.run(Main.SwitchTheme_Mid_UI, "BackColor", Color.FromArgb(0, 20, 0), New TransitionType_CriticalDamping(1000))
            h.Main_ToolTip.BackColor = SystemColors.InfoText;
            h.Main_ToolTip.ForeColor = SystemColors.Info;
            {
                {
                    h_addb.ForeColor = Color.FromArgb(95, 191, 119);
                    h_addb.BackColor = Color.FromArgb(64, 64, 64);
                    h_addb.FlatAppearance.MouseDownBackColor = Color.Honeydew;
                    h_addb.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 74);
                    h_addb.Image = prop.x64.AutoDetect_dark_64;
                }
                // .DeviceState_Label.ForeColor = Color.FromArgb(95, 191, 119)
                h.Donate_Button.Icon = prop.x24.DonateHeart_Dark_24;
                h.SwitchTheme_Button.Icon = prop.x24.Theme_Dark_24;
                h.GeekAssistant.Image = prop.GA.Geek_Assistant___25_;
                h.Feedback_Button.Icon = prop.x24.Smile_dark_24;
                h.About_Button.Icon = prop.x24.ToU_dark_24;
                h.Settings_Button.Icon = prop.x24.Settings_dark_24;
                h.ShowLog_Button.Icon = prop.x24.Commands_dark_24;
                //hom.manualCMD_TextBox.Icon = prop.x16.Commands_dark_16;
            }
        } else // Light Theme
          {
            // Main.SwitchTheme_Mid_UI.BackColor = Color.FromArgb(0, 20, 0)
            // Transition.run(Main.SwitchTheme_Mid_UI, "BackColor", Color.FromArgb(235, 245, 235), New TransitionType_CriticalDamping(1000))
            h.Main_ToolTip.BackColor = SystemColors.Info;
            h.Main_ToolTip.ForeColor = SystemColors.InfoText;
            {
                {
                    h_addb.ForeColor = Color.FromArgb(0, 128, 32);
                    h_addb.BackColor = Color.Honeydew;
                    h_addb.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
                    h_addb.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 245, 230);
                    h_addb.Image = prop.x64.AutoDetect_64;
                }
                // .DeviceState_Label.ForeColor = Color.FromArgb(0, 128, 32)
                h.Donate_Button.Icon = prop.x24.DonateHeart_24;
                h.SwitchTheme_Button.Icon = prop.x24.Theme_Light_24;
                h.GeekAssistant.Image = prop.GA.Geek_Assistant;
                h.Feedback_Button.Icon = prop.x24.Smile_24;
                h.About_Button.Icon = prop.x24.ToU_24;
                h.Settings_Button.Icon = prop.x24.Settings_24;
                h.ShowLog_Button.Icon = prop.x24.Commands_24;
                //hom.manualCMD_TextBox.Icon = prop.x16.Commands_16;
            }
        }
        // Animate.Run(Main.log, "ForeColor", Current_fgColor())
        HomeTheme_delayTimer.Enabled = false;
    }
    #endregion

    #region PleaseWait
    private static void PleaseWait_Theme() {
        //PleaseWait p = new();
        SetControlsArrTheme(new Control[] { pw,  pw.PleaseWait_ProgressText });

        var p_spb = pw.StopProcess_Button;
        var p_spb_fa = p_spb.FlatAppearance;
        if (c.S.DarkTheme) {
            //p.PleaseWait_text.ForeColor = Color.FromArgb(0, 200, 0);
            {
                p_spb.ForeColor = Color.FromArgb(230, 255, 230);
                p_spb.BackColor = Color.FromArgb(55, 28, 25);
                {
                    p_spb_fa.MouseOverBackColor = Color.FromArgb(128, 0, 0);
                    p_spb_fa.MouseDownBackColor = Color.FromArgb(80, 0, 0);
                }
            }
        } else {
            pw.PleaseWait_text.ForeColor = Color.FromArgb(0, 100, 0);
            pw.StopProcess_Button.BackColor = Color.FromArgb(255, 228, 225);
            {
                p_spb.BackColor = Color.FromArgb(255, 228, 225);
                p_spb.ForeColor = Color.DarkRed;
                {
                    p_spb_fa.MouseOverBackColor = Color.FromArgb(240, 128, 128);
                    p_spb_fa.MouseDownBackColor = Color.FromArgb(128, 0, 0);
                }
            }
        }
    }
    #endregion

    #region Settings
    private static void Settings_Theme() {
        //Settings s = new();
        SetControlsArrTheme(new Control[] { s, s.ResetGA_GroupBox, s.Close_Button });

        var s_rsa = s.ResetGA_SelectAll;
        if (c.S.DarkTheme) {
            s.ButtonsBG_UI.BackColor = Color.FromArgb(32, 32, 32);
            s.ResetGA_LogsOnly_CheckBox_Label.ForeColor = Color.FromArgb(100, 100, 100);
            s.ResetGA_Settings_CheckBox_Label.ForeColor = Color.FromArgb(100, 100, 100);
            s.OpenLogsFolder.ForeColor = Color.FromArgb(100, 100, 100);
            s.ResetGA.FlatAppearance.MouseOverBackColor = Color.FromArgb(135, 83, 59);
            {
                s_rsa.Image = prop.x24.SelectAll_W_24;
                s_rsa.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
                s_rsa.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 100, 100);
            }

            s.SettingsIcon_PictureBox.Image = prop.x64.Settings_dark_64;
            s.SettingsTitle_Label.ForeColor = Color.FromArgb(184, 243, 254);
            s.Close_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
        } else {
            s.ButtonsBG_UI.BackColor = Color.WhiteSmoke;
            s.ResetGA_LogsOnly_CheckBox_Label.ForeColor = Color.FromArgb(64, 64, 64);
            s.ResetGA_Settings_CheckBox_Label.ForeColor = Color.FromArgb(64, 64, 64);
            s.OpenLogsFolder.ForeColor = Color.FromArgb(64, 64, 64);
            s.ResetGA.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 203, 179);
            {
                s_rsa.Image = prop.x24.SelectAll_B_24;
                s_rsa.FlatAppearance.MouseOverBackColor = Color.Silver;
                s_rsa.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            }
            s.SettingsIcon_PictureBox.Image = prop.x64.Settings_64;
            s.SettingsTitle_Label.ForeColor = Color.FromArgb(0, 106, 128);
            s.Close_Button.FlatAppearance.MouseOverBackColor = Color.Silver;

        }
        {
            s.ResetGA.BackColor = s.ButtonsBG_UI.BackColor;
            s.ResetGA_SelectAll.BackColor = s.ButtonsBG_UI.BackColor;
            s.GeekAssistant_PictureBox.BackColor = s.ButtonsBG_UI.BackColor;
            s.Close_Button.BackColor = s.BackColor;
        }
    }
    #endregion

    #region ToU
    private static void ToU_Theme() {
        //ToU t = new();
        SetControlsArrTheme(new Control[] { t, t.TermsOfUse_Box, t.ToU_Reject, t.ToU_Accept });

        // Do this hell
        if (c.S.DarkTheme) {
            t.ButtonsBG_UI.BackColor = Color.FromArgb(32, 32, 32);
            t.Icon_PictureBox.Image = prop.x64.ToU_dark_64;
            t.ToUTitle_Label.ForeColor = Color.FromArgb(178, 255, 220);
        } else {
            t.ButtonsBG_UI.BackColor = Color.WhiteSmoke;
            t.Icon_PictureBox.Image = prop.x64.ToU_64;
            t.ToUTitle_Label.ForeColor = Color.FromArgb(0, 102, 71);
        }

        t.AcceptCheck_ToU.ForeColor = t.ToUTitle_Label.ForeColor;
        t.Copyright_Label.ForeColor = t.ToUTitle_Label.ForeColor;
        t.AcceptCheck_ToU.ForeColor = c.colors.fg;
        t.DontShow_ToU.ForeColor = c.colors.fg;
        t.AcceptCheck_ToU.BackColor = t.ButtonsBG_UI.BackColor;
        t.DontShow_ToU.BackColor = t.ButtonsBG_UI.BackColor;
        t.GeekAssistant_PictureBox.BackColor = t.ButtonsBG_UI.BackColor;
    }
    #endregion


    #region Theming Mechanism

    private static void SetControlsArrTheme(Control[] ControlsObj) {
        for (int i = 0; i < ControlsObj.Length; i++)
             SetControlTheme(  ControlsObj[i]); 
    } 
    private static void SetControlTheme(  Control ControlObj) {
        Animate.Run(  ControlObj, "ForeColor", c.colors.fg);
        Animate.Run(  ControlObj, "BackColor", c.colors.bg);
    }

    private static void SetControlsArrTheme_Metro(MetroFramework.Interfaces.IMetroControl[] ControlsObj) {
        for (int i = 0; i < ControlsObj.Length; i++)
            SetControlTheme_Metro(  ControlsObj[i]);
    }
    private static void SetControlTheme_Metro(  MetroFramework.Interfaces.IMetroControl ControlObj) {
        ControlObj.Theme = c.colors.Metro;
        // Cannot animate "Theme" 'Transition.run(ControlObj, "Theme", Current_Theme_Metro(), New TransitionType_CriticalDamping(500))
    }

    #endregion
}