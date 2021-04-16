using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic; // Install-Package Microsoft.VisualBasic

internal static partial class GA_SetTheme {
    static GA_SetTheme() {
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        MainTheme_delayTimer = new DateAndTime.Timer() { Interval = 100 };
    }

    public static void Run(string FormName, bool initiating = false) {
        initiatingbool = initiating;
        switch (FormName ?? "") {
        case var @case when @case == AppMode.Name: {
            SetControlTheme(ref AppMode);
            AppMode.startup_dontShow.ForeColor = Current_fgColor();
            break;
        }

        case var case1 when case1 == Donate.Name: {
            Donate_Theme();
            break;
        }

        case var case2 when case2 == info.Name: {
            info_Theme();
            break;
        }

        case var case3 when case3 == Home.Name: {
            if (S.VerboseLogging) {
                string ThemeString = "dark theme";
                if (S.DarkTheme)
                    ThemeString = "Light Theme";
                GA_SetProgressText.Run($"Switched to {ThemeString}.", -1);
            }

            if (!initiating & S.PerformAnimations) {
                if (S.DarkTheme) {
                    Home.SwitchTheme_Back_UI.Top = -Home.SwitchTheme_Back_UI.Height;
                    Animate.Run(Home.SwitchTheme_Back_UI, "Top", Home.Height, 1000);
                } else {
                    Home.SwitchTheme_Back_UI.Top = Home.Height;
                    Animate.Run(Home.SwitchTheme_Back_UI, "Top", -Home.SwitchTheme_Back_UI.Height, 1000);
                }
            }

            MainTheme_delayTimer.Enabled = true;
            break;
        }

        case var case4 when case4 == PleaseWait.Name: {
            PleaseWait_Theme();
            break;
        }

        case var case5 when case5 == GA_Settings.Name: {
            Settings_Theme();
            break;
        }

        case var case6 when case6 == ToU.Name: {
            ToU_Theme();
            break;
        }

        case var case7 when case7 == Preparing.Name: {
            Preparing.Preparing_Label.ForeColor = Current_fgColor();
            Preparing.BackColor = Current_bgColor();
            break;
        }
        }
    }


    /* TODO ERROR: Skipped RegionDirectiveTrivia */
    private static void Donate_Theme() {
        SetControlsArrTheme(new[] { Donate, Donate.BitcoinAddress, Donate.BitcoinNote });
        if (S.DarkTheme) {
            Donate.ButtonsBG_UI.BackColor = Color.FromArgb(32, 32, 32);
            Donate.Close_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Donate.pic.Image = My.Res.x64.DonateHeart_Dark_64;
            Donate.title.ForeColor = Color.FromArgb(255, 191, 217);
            Donate.BitcoinAddressQR.Image = My.Res.xXX.BTCAddressQR_Dark;
            Donate.GooglePayLink.Image = My.Res.x16.linkIcon_dark_16;
        } else {
            Donate.ButtonsBG_UI.BackColor = Color.WhiteSmoke;
            Donate.Close_Button.FlatAppearance.MouseOverBackColor = Color.Silver;
            Donate.pic.Image = My.Res.x64.DonateHeart_64;
            Donate.title.ForeColor = Color.FromArgb(128, 0, 87);
            Donate.BitcoinAddressQR.Image = My.Res.xXX.BTCAddressQR;
            Donate.GooglePayLink.Image = My.Res.x16.linkIcon_16;
        }

        Donate.GeekAssistant_PictureBox.BackColor = Donate.ButtonsBG_UI.BackColor;
    }

    /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    /* TODO ERROR: Skipped RegionDirectiveTrivia */
    private static void info_Theme() {
        SetControlsArrTheme(new[] { info, info.info_PictureBox, info.msg_Textbox, info.No_Button });
        if (S.DarkTheme) {
            info.ButtonsBG_UI.BackColor = Color.FromArgb(32, 32, 32);
            info.Copy_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            info.Yes_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            info.No_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
        } else {
            info.ButtonsBG_UI.BackColor = Color.WhiteSmoke;
            info.Copy_Button.FlatAppearance.MouseOverBackColor = Color.Silver;
            info.Yes_Button.FlatAppearance.MouseOverBackColor = Color.Silver;
            info.No_Button.FlatAppearance.MouseOverBackColor = Color.Silver;
        }

        info.Yes_Button.ForeColor = info.title_Label.ForeColor;
        info.Yes_Button.FlatAppearance.MouseDownBackColor = info.title_Label.ForeColor;
        info.GeekAssistant_PictureBox.BackColor = info.ButtonsBG_UI.BackColor;
    }

    private static Timer _MainTheme_delayTimer;

    private static Timer MainTheme_delayTimer {
        [MethodImpl(MethodImplOptions.Synchronized)]
        get {
            return _MainTheme_delayTimer;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        set {
            if (_MainTheme_delayTimer != null) {
                _MainTheme_delayTimer.Tick -= MainTheme_delayTimer_Tick;
            }

            _MainTheme_delayTimer = value;
            if (_MainTheme_delayTimer != null) {
                _MainTheme_delayTimer.Tick += MainTheme_delayTimer_Tick;
            }
        }
    }

    private static bool initiatingbool = false;

    private static void MainTheme_delayTimer_Tick(object sender, EventArgs e) {
        object[] Controls_array = new[] { Home, Home.log, Home.ManualInfo_GroupBox, Home.ProgressFakeBG_UI, Home.Main_Tabs, Home.PrepareYourDevice_Tab, Home.FlashImg_Tab, Home.MoreTools_Tab, Home.BootloaderUnlockable_CheckBox, Home.CustomROM_CheckBox, Home.CustomRecovery_CheckBox };
        object[] MetroControls_array = new[] { Home.Main_Tabs, Home.PrepareYourDevice_Tab, Home.FlashImg_Tab, Home.MoreTools_Tab, Home.GA_About_Label, Home.UnlockBL_Label, Home.MagiskRoot_Label, Home.Manufacturer_ComboBox, Home.AndroidVersion_ComboBox, Home.ProgressBar, Home.manualCMD_TextBox, Home.FlashZip_ChooseFile_TextBox, Home.UnlockBL_Button, Home.MagiskRoot_Button, Home.FlashZip_Button, Home.ProgressBarLabel };
        SetControlsArrTheme_Metro(MetroControls_array);
        if (initiatingbool)
            goto NoAnimation;
        SetControlsArrTheme(Controls_array);
        NoAnimation:
        ;
        if (!initiatingbool)
            goto skipNoAnimation;
        foreach (object c in Controls_array) {
            c.BackColor = Current_bgColor();
            c.ForeColor = Current_fgColor();
        }

        skipNoAnimation:
        ;
        if (S.DarkTheme) {
            // Main.SwitchTheme_Mid_UI.BackColor = Color.FromArgb(235, 245, 235)
            // Transition.run(Main.SwitchTheme_Mid_UI, "BackColor", Color.FromArgb(0, 20, 0), New TransitionType_CriticalDamping(1000))
            Home.Main_ToolTip.BackColor = SystemColors.InfoText;
            Home.Main_ToolTip.ForeColor = SystemColors.Info;
            {
                var withBlock = Home;
                {
                    var withBlock1 = withBlock.AutoDetectDeviceInfo_Button;
                    withBlock1.ForeColor = Color.FromArgb(95, 191, 119);
                    withBlock1.BackColor = Color.FromArgb(64, 64, 64);
                    withBlock1.FlatAppearance.MouseDownBackColor = Color.Honeydew;
                    withBlock1.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 74);
                    withBlock1.Image = My.Res.x64.AutoDetect_dark_64;
                }

                // .DeviceState_Label.ForeColor = Color.FromArgb(95, 191, 119)
                withBlock.Donate_Button.Icon = My.Res.x24.DonateHeart_Dark_24;
                withBlock.SwitchTheme_Button.Icon = My.Res.x24.Theme_Dark_24;
                withBlock.GeekAssistant.Image = My.Res.GA.GeekAssistant_25;
                withBlock.Feedback_Button.Icon = My.Res.x24.Smile_dark_24;
                withBlock.About_Button.Icon = My.Res.x24.ToU_dark_24;
                withBlock.Settings_Button.Icon = My.Res.x24.Settings_dark_24;
                withBlock.ShowLog_Button.Icon = My.Res.x24.Commands_dark_24;
                withBlock.manualCMD_TextBox.Icon = My.Res.x16.Commands_dark_16;
            }
        } else // Light Theme
          {
            // Main.SwitchTheme_Mid_UI.BackColor = Color.FromArgb(0, 20, 0)
            // Transition.run(Main.SwitchTheme_Mid_UI, "BackColor", Color.FromArgb(235, 245, 235), New TransitionType_CriticalDamping(1000))
            Home.Main_ToolTip.BackColor = SystemColors.Info;
            Home.Main_ToolTip.ForeColor = SystemColors.InfoText;
            {
                var withBlock2 = Home;
                {
                    var withBlock3 = withBlock2.AutoDetectDeviceInfo_Button;
                    withBlock3.ForeColor = Color.FromArgb(0, 128, 32);
                    withBlock3.BackColor = Color.Honeydew;
                    withBlock3.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
                    withBlock3.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 245, 230);
                    withBlock3.Image = My.Res.x64.AutoDetect_64;
                }
                // .DeviceState_Label.ForeColor = Color.FromArgb(0, 128, 32)
                withBlock2.Donate_Button.Icon = My.Res.x24.DonateHeart_24;
                withBlock2.SwitchTheme_Button.Icon = My.Res.x24.Theme_Light_24;
                withBlock2.GeekAssistant.Image = My.Res.GA.GeekAssistant;
                withBlock2.Feedback_Button.Icon = My.Res.x24.Smile_24;
                withBlock2.About_Button.Icon = My.Res.x24.ToU_24;
                withBlock2.Settings_Button.Icon = My.Res.x24.Settings_24;
                withBlock2.ShowLog_Button.Icon = My.Res.x24.Commands_24;
                withBlock2.manualCMD_TextBox.Icon = My.Res.x16.Commands_16;
            }
        }
        // Animate.Run(Main.log, "ForeColor", Current_fgColor())
        MainTheme_delayTimer.Enabled = false;
    }
    /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    /* TODO ERROR: Skipped RegionDirectiveTrivia */
    private static void PleaseWait_Theme() {
        SetControlsArrTheme(new[] { PleaseWait, PleaseWait.PleaseWait_ProgressText });
        if (S.DarkTheme) {
            PleaseWait.PleaseWait_text.ForeColor = Color.FromArgb(0, 200, 0);
            {
                var withBlock = PleaseWait.StopProcess_Button;
                withBlock.ForeColor = Color.FromArgb(230, 255, 230);
                withBlock.BackColor = Color.FromArgb(55, 28, 25);
                {
                    var withBlock1 = withBlock.FlatAppearance;
                    withBlock1.MouseOverBackColor = Color.FromArgb(128, 0, 0);
                    withBlock1.MouseDownBackColor = Color.FromArgb(80, 0, 0);
                }
            }
        } else {
            PleaseWait.PleaseWait_text.ForeColor = Color.FromArgb(0, 100, 0);
            PleaseWait.StopProcess_Button.BackColor = Color.FromArgb(255, 228, 225);
            {
                var withBlock2 = PleaseWait.StopProcess_Button;
                withBlock2.BackColor = Color.FromArgb(255, 228, 225);
                withBlock2.ForeColor = Color.DarkRed;
                {
                    var withBlock3 = withBlock2.FlatAppearance;
                    withBlock3.MouseOverBackColor = Color.FromArgb(240, 128, 128);
                    withBlock3.MouseDownBackColor = Color.FromArgb(128, 0, 0);
                }
            }
        }
    }
    /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    /* TODO ERROR: Skipped RegionDirectiveTrivia */
    private static void Settings_Theme() {
        SetControlsArrTheme(new[] { GA_Settings, GA_Settings.ResetGA_GroupBox, GA_Settings.Close_Button });
        if (S.DarkTheme) {
            {
                var withBlock = GA_Settings;
                withBlock.ButtonsBG_UI.BackColor = Color.FromArgb(32, 32, 32);
                withBlock.ResetGA_LogsOnly_CheckBox_Label.ForeColor = Color.FromArgb(100, 100, 100);
                withBlock.ResetGA_Settings_CheckBox_Label.ForeColor = Color.FromArgb(100, 100, 100);
                withBlock.OpenLogsFolder.ForeColor = Color.FromArgb(100, 100, 100);
                withBlock.ResetGA.FlatAppearance.MouseOverBackColor = Color.FromArgb(135, 83, 59);
                {
                    var withBlock1 = withBlock.ResetGA_SelectAll;
                    withBlock1.Image = My.Res.x24.SelectAll_W_24;
                    withBlock1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
                    withBlock1.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 100, 100);
                }

                withBlock.SettingsIcon_PictureBox.Image = My.Res.x64.Settings_dark_64;
                withBlock.SettingsTitle_Label.ForeColor = Color.FromArgb(184, 243, 254);
                withBlock.Close_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            }
        } else {
            {
                var withBlock2 = GA_Settings;
                withBlock2.ButtonsBG_UI.BackColor = Color.WhiteSmoke;
                withBlock2.ResetGA_LogsOnly_CheckBox_Label.ForeColor = Color.FromArgb(64, 64, 64);
                withBlock2.ResetGA_Settings_CheckBox_Label.ForeColor = Color.FromArgb(64, 64, 64);
                withBlock2.OpenLogsFolder.ForeColor = Color.FromArgb(64, 64, 64);
                withBlock2.ResetGA.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 203, 179);
                {
                    var withBlock3 = withBlock2.ResetGA_SelectAll;
                    withBlock3.Image = My.Res.x24.SelectAll_B_24;
                    withBlock3.FlatAppearance.MouseOverBackColor = Color.Silver;
                    withBlock3.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
                }

                withBlock2.SettingsIcon_PictureBox.Image = My.Res.x64.Settings_64;
                withBlock2.SettingsTitle_Label.ForeColor = Color.FromArgb(0, 106, 128);
                withBlock2.Close_Button.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
        }

        {
            var withBlock4 = GA_Settings;
            withBlock4.ResetGA.BackColor = GA_Settings.ButtonsBG_UI.BackColor;
            withBlock4.ResetGA_SelectAll.BackColor = GA_Settings.ButtonsBG_UI.BackColor;
            withBlock4.GeekAssistant_PictureBox.BackColor = GA_Settings.ButtonsBG_UI.BackColor;
            withBlock4.Close_Button.BackColor = GA_Settings.BackColor;
        }
    }
    /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    /* TODO ERROR: Skipped RegionDirectiveTrivia */
    private static void ToU_Theme() {
        SetControlsArrTheme(new[] { ToU, ToU.TermsOfUse_Box, ToU.ToU_Reject, ToU.ToU_Accept });

        // Do this hell
        if (S.DarkTheme) {
            ToU.ButtonsBG_UI.BackColor = Color.FromArgb(32, 32, 32);
            ToU.Icon_PictureBox.Image = My.Res.x64.ToU_dark_64;
            ToU.ToUTitle_Label.ForeColor = Color.FromArgb(178, 255, 220);
        } else {
            ToU.ButtonsBG_UI.BackColor = Color.WhiteSmoke;
            ToU.Icon_PictureBox.Image = My.Res.x64.ToU_64;
            ToU.ToUTitle_Label.ForeColor = Color.FromArgb(0, 102, 71);
        }

        ToU.AcceptCheck_ToU.ForeColor = ToU.ToUTitle_Label.ForeColor;
        ToU.Copyright.ForeColor = ToU.ToUTitle_Label.ForeColor;
        ToU.AcceptCheck_ToU.ForeColor = Current_fgColor();
        ToU.DontShow_ToU.ForeColor = Current_fgColor();
        ToU.AcceptCheck_ToU.BackColor = ToU.ButtonsBG_UI.BackColor;
        ToU.DontShow_ToU.BackColor = ToU.ButtonsBG_UI.BackColor;
        ToU.GeekAssistant_PictureBox.BackColor = ToU.ButtonsBG_UI.BackColor;
    }
    /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    /* TODO ERROR: Skipped RegionDirectiveTrivia */
    private static void SetControlsArrTheme(object[] ControlsObj) {
        foreach (object controlObj in ControlsObj)
            SetControlTheme(ref controlObj);
    }

    private static void SetControlsArrTheme_Metro(object[] ControlsObj) {
        foreach (object c in ControlsObj)
            SetControlTheme_Metro(ref c);
    }

    private static void SetControlTheme(ref object ControlObj) {
        Animate.Run(ControlObj, "ForeColor", Current_fgColor());
        Animate.Run(ControlObj, "BackColor", Current_bgColor());
    }

    private static void SetControlTheme_Metro(ref object ControlObj) {
        // Cannot animate "Theme" 'Transition.run(ControlObj, "Theme", Current_Theme_Metro(), New TransitionType_CriticalDamping(500))
        ControlObj.Theme = Current_Theme_Metro();
    }

    public static Color Current_bgColor() {
        if (S.DarkTheme) {
            return bgDark;
        } else {
            return bgLight;
        }
    }

    public static Color Current_fgColor() {
        if (S.DarkTheme) {
            return fgDark;
        } else {
            return fgLight;
        }
    }

    public static MetroFramework.MetroThemeStyle Current_Theme_Metro() {
        if (S.DarkTheme) {
            return MetroFramework.MetroThemeStyle.Dark;
        } else {
            return MetroFramework.MetroThemeStyle.Default;
        }
    }

    /* TODO ERROR: Skipped RegionDirectiveTrivia */
    private static Color bgLight = Color.White;
    private static Color fgLight = SystemColors.ControlText;
    private static Color bgDark = Color.FromArgb(17, 17, 17);
    private static Color fgDark = Color.White;
    /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
}