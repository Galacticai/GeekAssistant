using GeekAssistant.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Interfaces;

internal class SetTheme : SetThemeCompanion {
    public static bool Running = false;

    private static bool initiatingbool = false;

    private static bool dark => c.S.DarkTheme;

    private static Wait pw => c.Wait;
    private static Preparing p => c.Preparing;
    private static AppMode am => c.AppMode;
    private static Donate d => c.Donate;
    private static Info i => c.Info;
    private static Home h => c.Home;
    private static Settings s => c.Settings;
    private static ToU t => c.ToU;
    public static void Run(Form f, bool initiating = false) {
        Running = true;
        initiatingbool = initiating;

        if (c.S.VerboseLogging & h != null)
            SetProgressText.Run($"Switched to {(dark ? "dark" : "light")} theme.", -1);

        switch (f) {
            case Wait:
                //pw = (Wait)f;
                Wait_Theme();
                break;

            case Preparing:
                //p = (Preparing)f;
                p.Preparing_Label.ForeColor = colors.UI.fg();
                p.BackColor = colors.UI.bg();
                break;

            case AppMode:
                //am = (AppMode)f;
                //Control am = AppMode;
                SetControlTheme(am);
                am.startup_dontShow.ForeColor = colors.UI.fg();
                break;

            case Donate:
                //d = (Donate)f;
                Donate_Theme();
                break;

            case Info:
                //i = (Info)f;
                Info_Theme();
                break;
            case Home:
                //h = (Home)f;
                Home_Theme();
                break;

            case Settings:
                //s = (Settings)f;
                Settings_Theme();
                break;

            case ToU:
                //t = (ToU)f;
                ToU_Theme();
                break;
        }
        Running = false;
    }


    #region Donate
    private static void Donate_Theme() {
        //Donate d = new();
        SetControlsArrTheme(new Control[] { d, d.BitcoinAddress, d.BitcoinNote });
        {
            if (dark) {
                d.ButtonsBG_UI.BackColor = Color.FromArgb(32, 32, 32);
                d.Close_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
                d.pic.Image = prop.x64.DonateHeart_dark_64;
                d.BitcoinAddressQR.Image = prop.xXX.BTCAddressQR_Dark;
                d.GooglePayLink.Image = prop.x16.linkIcon_dark_16;
            } else {
                d.ButtonsBG_UI.BackColor = Color.WhiteSmoke;
                d.Close_Button.FlatAppearance.MouseOverBackColor = Color.Silver;
                d.pic.Image = prop.x64.DonateHeart_64;
                d.BitcoinAddressQR.Image = prop.xXX.BTCAddressQR;
                d.GooglePayLink.Image = prop.x16.linkIcon_16;
            }
            d.title.ForeColor = colors.Iconcolors.Donate();
            d.GeekAssistant_PictureBox.BackColor = d.ButtonsBG_UI.BackColor;
        }
    }

    #endregion

    #region Info
    private static void Info_Theme() {
        //Info i = new();
        SetControlsArrTheme(new Control[] { i, i.info_PictureBox, i.msg_Textbox, i.No_Button });
        {
            i.Copy_Button.FlatAppearance.MouseOverBackColor = colors.UI.Buttons.FlatAppearance.MouseOverBackColor();
            i.Yes_Button.FlatAppearance.MouseOverBackColor = colors.UI.Buttons.FlatAppearance.MouseOverBackColor();
            i.No_Button.FlatAppearance.MouseOverBackColor = colors.UI.Buttons.FlatAppearance.MouseOverBackColor();

            i.ButtonsBG_UI.BackColor = colors.UI.Buttons.BarBG();
            i.Yes_Button.ForeColor = i.title_Label.ForeColor;
            i.Yes_Button.FlatAppearance.MouseDownBackColor = i.title_Label.ForeColor;
            i.GeekAssistant_PictureBox.BackColor = i.ButtonsBG_UI.BackColor;
        }
    }
    #endregion

    #region Home 
    private static void Home_Theme() {

        if (!initiatingbool & c.S.PerformAnimations)
            if (dark) {
                h.SwitchTheme_Back_UI.Top = -h.SwitchTheme_Back_UI.Height;
                Animate.Run(h.SwitchTheme_Back_UI, "Top", new Home().Height, 1000);
            } else {
                h.SwitchTheme_Back_UI.Top = new Home().Height;
                Animate.Run(h.SwitchTheme_Back_UI, "Top", -h.SwitchTheme_Back_UI.Height, 1000);
            }

        Timer HomeTheme_delayTimer = new() { Interval = 100 };
        HomeTheme_delayTimer.Start();
        HomeTheme_delayTimer.Tick += (sender, ev) => {

            Control[] Controls_array = new Control[] {
                    h,
                    //h.log,
                    h.ManualInfo_GroupBox,
                    h.ProgressFakeBG_UI,
                    h.Main_Tabs_old,
                    h.PrepareYourDevice_Tab_old,
                    h.FlashImg_Tab_old,
                    h.MoreTools_Tab_old,
                    h.BootloaderUnlockable_CheckBox,
                    h.CustomROM_CheckBox,
                    h.UnlockBL_Button,
                    h.MagiskRoot_Button,
                    h.FlashZip_Button,
                    h.CustomRecovery_CheckBox,
                    h.ProgressBarLabel,
                    h.GA_About_Label,
                    h.UnlockBL_Label,
                    h.MagiskRoot_Label
            };
            IMetroControl[] MetroControls_array = new IMetroControl[] {
                    h.Main_Tabs_old,
                    h.PrepareYourDevice_Tab_old,
                    h.FlashImg_Tab_old,
                    h.MoreTools_Tab_old,
                    h.Manufacturer_ComboBox,
                    h.AndroidVersion_ComboBox,
                    h.bar,
            };//, c.Home.FlashZip_ChooseFile_TextBox, common.Home.manualCMD_TextBox };

            SetControlsArrTheme_Metro(MetroControls_array);

            if (initiatingbool & c.S.PerformAnimations) {
                var saved_PerformAnimations = c.S.PerformAnimations;//save
                c.S.PerformAnimations = false;//temp
                SetControlsArrTheme(Controls_array);
                c.S.PerformAnimations = saved_PerformAnimations;//retrun to normal
            } else SetControlsArrTheme(Controls_array);


            using var h_add_b = h.AutoDetectDeviceInfo_Button;
            if (dark) {
                // Main.SwitchTheme_Mid_UI.BackColor = Color.FromArgb(235, 245, 235)
                // Transition.run(Main.SwitchTheme_Mid_UI, "BackColor", Color.FromArgb(0, 20, 0), New TransitionType_CriticalDamping(1000))
                h.Main_ToolTip.BackColor = SystemColors.InfoText;
                h.Main_ToolTip.ForeColor = SystemColors.Info;
                {
                    h_add_b.BackColor = Color.FromArgb(64, 64, 64);
                    h_add_b.FlatAppearance.MouseDownBackColor = Color.Honeydew;
                    h_add_b.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 74);
                    h_add_b.Image = prop.x64.AutoDetect_dark_64;
                }
            } else { // Light Theme 
                // Main.SwitchTheme_Mid_UI.BackColor = Color.FromArgb(0, 20, 0)
                // Transition.run(Main.SwitchTheme_Mid_UI, "BackColor", Color.FromArgb(235, 245, 235), New TransitionType_CriticalDamping(1000))
                h.Main_ToolTip.BackColor = SystemColors.Info;
                h.Main_ToolTip.ForeColor = SystemColors.InfoText;
                {
                    h_add_b.BackColor = Color.Honeydew;
                    h_add_b.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
                    h_add_b.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 245, 230);
                    h_add_b.Image = prop.x64.AutoDetect_64;
                }
            }
            h.SwitchTheme_Button.ForeColor = colors.Iconcolors.SwitchTheme();
            h.Feedback_Button.ForeColor = colors.Iconcolors.Smile();
            h.About_Button.ForeColor = colors.Iconcolors.ToU();
            h.Settings_Button.ForeColor = colors.Iconcolors.Settings();
            h.Donate_Button.ForeColor = colors.Iconcolors.Donate();
            h.ShowLog_Button.Icon = icons.x24.Commands();

            h.SwitchTheme_Button.Icon = icons.x24.SwitchTheme();
            h.Feedback_Button.Icon = icons.x24.Smile();
            h.About_Button.Icon = icons.x24.ToU();
            h.Settings_Button.Icon = icons.x24.Settings();
            h.Donate_Button.Icon = icons.x24.Donate();
            h.ShowLog_Button.ForeColor = colors.Iconcolors.Commands();

            h_add_b.ForeColor = colors.Misc.Green();
            h.Toggle_ManualDeviceInfo_Button.ForeColor = h_add_b.ForeColor;

            h.DeviceState_Label_TextChanged(h.DeviceState_Label, EventArgs.Empty);
            HomeTheme_delayTimer.Enabled = false;
        };

    }
    #endregion

    #region Wait
    private static void Wait_Theme() {
        //Wait p = new();
        SetControlsArrTheme(new Control[] { pw, pw.Wait_ProgressText });

        var p_spb = pw.StopProcess_Button;
        var p_spb_fa = p_spb.FlatAppearance;
        if (dark) {
            //p.Wait_text.ForeColor = Color.FromArgb(0, 200, 0);
            {
                p_spb.ForeColor = Color.FromArgb(230, 255, 230);
                p_spb.BackColor = Color.FromArgb(55, 28, 25);
                {
                    p_spb_fa.MouseOverBackColor = Color.FromArgb(128, 0, 0);
                    p_spb_fa.MouseDownBackColor = Color.FromArgb(80, 0, 0);
                }
            }
        } else {
            pw.Wait_text.ForeColor = Color.FromArgb(0, 100, 0);
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
        if (dark) {
            s.ResetGA_LogsOnly_CheckBox_Label.ForeColor = Color.FromArgb(100, 100, 100);
            s.ResetGA_Settings_CheckBox_Label.ForeColor = Color.FromArgb(100, 100, 100);
            s.OpenLogsFolder.ForeColor = Color.FromArgb(100, 100, 100);
            s.ResetGA.FlatAppearance.MouseOverBackColor = Color.FromArgb(135, 83, 59);
            {
                s_rsa.Image = prop.x24.SelectAll_W_24;
                s_rsa.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 100, 100);
            }
        } else {
            s.ResetGA_LogsOnly_CheckBox_Label.ForeColor = Color.FromArgb(64, 64, 64);
            s.ResetGA_Settings_CheckBox_Label.ForeColor = Color.FromArgb(64, 64, 64);
            s.OpenLogsFolder.ForeColor = Color.FromArgb(64, 64, 64);
            s.ResetGA.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 203, 179);
            {
                s_rsa.Image = prop.x24.SelectAll_B_24;
                s_rsa.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            }
        }
        s.ButtonsBG_UI.BackColor = colors.UI.Buttons.BarBG();
        s_rsa.FlatAppearance.MouseOverBackColor = colors.UI.Buttons.FlatAppearance.MouseOverBackColor();
        s.Close_Button.FlatAppearance.MouseOverBackColor = colors.UI.Buttons.FlatAppearance.MouseOverBackColor();
        s.SettingsIcon_PictureBox.Image = icons.x64.Settings();
        s.SettingsTitle_Label.ForeColor = colors.Iconcolors.Settings();
        s.ResetGA.BackColor = s.ButtonsBG_UI.BackColor;
        s.ResetGA_SelectAll.BackColor = s.ButtonsBG_UI.BackColor;
        s.GeekAssistant_PictureBox.BackColor = s.ButtonsBG_UI.BackColor;
        s.Close_Button.BackColor = s.BackColor;

    }
    #endregion

    #region ToU
    private static void ToU_Theme() {
        //ToU t = new();
        SetControlsArrTheme(new Control[] { t, t.TermsOfUse_Box, t.ToU_Reject, t.ToU_Accept });

        // Do this hell 
        t.ButtonsBG_UI.BackColor = colors.UI.Buttons.BarBG();
        t.Icon_PictureBox.Image = icons.x64.ToU();
        t.ToUTitle_Label.ForeColor = colors.Iconcolors.ToU();
        t.AcceptCheck_ToU.ForeColor = t.ToUTitle_Label.ForeColor;
        t.Copyright_Label.ForeColor = t.ToUTitle_Label.ForeColor;
        t.AcceptCheck_ToU.ForeColor = colors.UI.fg();
        t.DontShow_ToU.ForeColor = colors.UI.fg();
        t.AcceptCheck_ToU.BackColor = t.ButtonsBG_UI.BackColor;
        t.DontShow_ToU.BackColor = t.ButtonsBG_UI.BackColor;
        t.GeekAssistant_PictureBox.BackColor = t.ButtonsBG_UI.BackColor;
    }
    #endregion


}