using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic; // Install-Package Microsoft.VisualBasic

internal static partial class GA_SetTheme { 
      private static Timer HomeTheme_delayTimer = new() { Interval = 100 };

    private static readonly string AppModeName = common.AppMode.Name; 
    private static readonly string DonateName = common.Donate.Name;
    private static readonly string InfoName = common.Info.Name;
    private static readonly string HomeName = common.Home.Name;
    private static readonly string PleaseWaitName = common.PleaseWait.Name;
    private static readonly string SettingsName = common.Settings.Name;
    private static readonly string ToUName = common.ToU.Name;
    private static readonly string PreparingName = common.Preparing.Name;

    public static void Run(string FormName, bool initiating = false) {
        initiatingbool = initiating;
        if (FormName== AppModeName) {
            SetControlTheme(  common.AppMode);
            common.AppMode.startup_dontShow.ForeColor = Current_fgColor(); 
        }else if(FormName == DonateName)   Donate_Theme(); 
         else if (FormName == InfoName)   Info_Theme(); 
         else if (FormName == HomeName) {
            if (common.S.VerboseLogging) {
                string ThemeString = "dark theme";
                if (common.S.DarkTheme)
                    ThemeString = "Light Theme";
                GA_SetProgressText.Run($"Switched to {ThemeString}.", -1);
            }

            if (!initiating & common.S.PerformAnimations) {
                if (common.S.DarkTheme) {
                    common.Home.SwitchTheme_Back_UI.Top = -common.Home.SwitchTheme_Back_UI.Height;
                    Animate.Run(  common.Home.SwitchTheme_Back_UI, "Top", common.Home.Height, 1000);
                } else {
                    common.Home.SwitchTheme_Back_UI.Top = common.Home.Height;
                    Animate.Run(  common.Home.SwitchTheme_Back_UI, "Top", -common.Home.SwitchTheme_Back_UI.Height, 1000);
                }
            }

            HomeTheme_delayTimer.Start(); 
        } else if (FormName == PleaseWaitName)     PleaseWait_Theme(); 
         else if (FormName == SettingsName)    Settings_Theme(); 
         else if (FormName == ToUName)   ToU_Theme(); 
         else if (FormName == PreparingName) {
            common.Preparing.Preparing_Label.ForeColor = Current_fgColor();
            common.Preparing.BackColor = Current_bgColor(); 
        } 
        }
     


    #region Donate
    private static void Donate_Theme() {
        SetControlsArrTheme(  new object[] { common.Donate, common.Donate.BitcoinAddress, common.Donate.BitcoinNote } );
        var dnt =common.Donate;
        {
            if (common.S.DarkTheme) {
                dnt.ButtonsBG_UI.BackColor = Color.FromArgb(32, 32, 32);
                dnt.Close_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
                dnt.pic.Image = prop.x64.DonateHeart_Dark_64;
                dnt.title.ForeColor = Color.FromArgb(255, 191, 217);
                dnt.BitcoinAddressQR.Image = prop.xXX.BTCAddressQR_Dark;
                dnt.GooglePayLink.Image = prop.x16.linkIcon_dark_16;
            } else {
                dnt.ButtonsBG_UI.BackColor = Color.WhiteSmoke;
                dnt.Close_Button.FlatAppearance.MouseOverBackColor = Color.Silver;
                dnt.pic.Image = prop.x64.DonateHeart_64;
                dnt.title.ForeColor = Color.FromArgb(128, 0, 87);
                dnt.BitcoinAddressQR.Image = prop.xXX.BTCAddressQR;
                dnt.GooglePayLink.Image = prop.x16.linkIcon_16;
            }

            dnt.GeekAssistant_PictureBox.BackColor = common.Donate.ButtonsBG_UI.BackColor;
        }
    }

    #endregion    #region 

    #region Info
    private static void Info_Theme() {
        SetControlsArrTheme(new object[] { common.Info, common.Info.info_PictureBox, common.Info.msg_Textbox, common.Info.No_Button });
        var inf = common.Info;
        {
            if (common.S.DarkTheme) {
                inf.ButtonsBG_UI.BackColor = Color.FromArgb(32, 32, 32);
                inf.Copy_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
                inf.Yes_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
                inf.No_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            } else {
                inf.ButtonsBG_UI.BackColor = Color.WhiteSmoke;
                inf.Copy_Button.FlatAppearance.MouseOverBackColor = Color.Silver;
                inf.Yes_Button.FlatAppearance.MouseOverBackColor = Color.Silver;
                inf.No_Button.FlatAppearance.MouseOverBackColor = Color.Silver;
            }

            inf.Yes_Button.ForeColor = common.Info.title_Label.ForeColor;
            inf.Yes_Button.FlatAppearance.MouseDownBackColor = common.Info.title_Label.ForeColor;
            inf.GeekAssistant_PictureBox.BackColor = common.Info.ButtonsBG_UI.BackColor;
        }
    }
#endregion

    #region Home

    private static bool initiatingbool = false; 
    private static void HomeTheme_delayTimer_Tick(object sender, EventArgs e) {
        Control[] Controls_array = new Control[] { 
            common.Home, 
            common.Home.log, 
            common.Home.ManualInfo_GroupBox, 
            common.Home.ProgressFakeBG_UI, 
            common.Home.Main_Tabs, 
            common.Home.PrepareYourDevice_Tab, 
            common.Home.FlashImg_Tab, 
            common.Home.MoreTools_Tab, 
            common.Home.BootloaderUnlockable_CheckBox, 
            common.Home.CustomROM_CheckBox, 
            common.Home.CustomRecovery_CheckBox 
        };
        MetroFramework.Interfaces.IMetroControl[] MetroControls_array = new MetroFramework.Interfaces.IMetroControl[] { 
            common.Home.Main_Tabs, 
            common.Home.PrepareYourDevice_Tab, 
            common.Home.FlashImg_Tab, 
            common.Home.MoreTools_Tab, 
            common.Home.GA_About_Label, 
            common.Home.UnlockBL_Label, 
            common.Home.MagiskRoot_Label, 
            common.Home.Manufacturer_ComboBox, 
            common.Home.AndroidVersion_ComboBox,
            common.Home.ProgressBar, 
            common.Home.FlashZip_ChooseFile_TextBox, 
            common.Home.UnlockBL_Button, 
            common.Home.MagiskRoot_Button, 
            common.Home.FlashZip_Button, 
            common.Home.ProgressBarLabel 
        };// , common.Home.manualCMD_TextBox };
        
        SetControlsArrTheme_Metro(MetroControls_array);
         
        if (initiatingbool) {

            foreach (var c in Controls_array) {
                c.BackColor = Current_bgColor();
                c.ForeColor = Current_fgColor();
            }

        } else SetControlsArrTheme(Controls_array);

        if (common.S.DarkTheme) {
            // Main.SwitchTheme_Mid_UI.BackColor = Color.FromArgb(235, 245, 235)
            // Transition.run(Main.SwitchTheme_Mid_UI, "BackColor", Color.FromArgb(0, 20, 0), New TransitionType_CriticalDamping(1000))
            common.Home.Main_ToolTip.BackColor = SystemColors.InfoText;
            common.Home.Main_ToolTip.ForeColor = SystemColors.Info;
             
                var hom = common.Home;
            {  
                    var hom_addb = hom.AutoDetectDeviceInfo_Button;
                    { 
                    hom_addb.ForeColor = Color.FromArgb(95, 191, 119);
                    hom_addb.BackColor = Color.FromArgb(64, 64, 64);
                    hom_addb.FlatAppearance.MouseDownBackColor = Color.Honeydew;
                    hom_addb.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 74);
                    hom_addb.Image = prop.x64.AutoDetect_dark_64;
                    } 

                // .DeviceState_Label.ForeColor = Color.FromArgb(95, 191, 119)
                hom.Donate_Button.Icon = prop.x24.DonateHeart_Dark_24;
                hom.SwitchTheme_Button.Icon = prop.x24.Theme_Dark_24;
                hom.GeekAssistant.Image = prop.GA.Geek_Assistant___25_;
                hom.Feedback_Button.Icon = prop.x24.Smile_dark_24;
                hom.About_Button.Icon = prop.x24.ToU_dark_24;
                hom.Settings_Button.Icon = prop.x24.Settings_dark_24;
                hom.ShowLog_Button.Icon = prop.x24.Commands_dark_24;
                //hom.manualCMD_TextBox.Icon = prop.x16.Commands_dark_16;
             }
        } else // Light Theme
          {
            // Main.SwitchTheme_Mid_UI.BackColor = Color.FromArgb(0, 20, 0)
            // Transition.run(Main.SwitchTheme_Mid_UI, "BackColor", Color.FromArgb(235, 245, 235), New TransitionType_CriticalDamping(1000))
            common.Home.Main_ToolTip.BackColor = SystemColors.Info;
            common.Home.Main_ToolTip.ForeColor = SystemColors.InfoText;

            var hom = common.Home;
            {
                var hom_addb = hom.AutoDetectDeviceInfo_Button;
                {
                    hom_addb.ForeColor = Color.FromArgb(0, 128, 32);
                    hom_addb.BackColor = Color.Honeydew;
                    hom_addb.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
                    hom_addb.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 245, 230);
                    hom_addb.Image = prop.x64.AutoDetect_64;
                }
                // .DeviceState_Label.ForeColor = Color.FromArgb(0, 128, 32)
                hom.Donate_Button.Icon = prop.x24.DonateHeart_24;
                hom.SwitchTheme_Button.Icon = prop.x24.Theme_Light_24;
                hom.GeekAssistant.Image = prop.GA.Geek_Assistant;
                hom.Feedback_Button.Icon = prop.x24.Smile_24;
                hom.About_Button.Icon = prop.x24.ToU_24;
                hom.Settings_Button.Icon = prop.x24.Settings_24;
                hom.ShowLog_Button.Icon = prop.x24.Commands_24;
                //hom.manualCMD_TextBox.Icon = prop.x16.Commands_16;
            }
        }
        // Animate.Run(Main.log, "ForeColor", Current_fgColor())
        HomeTheme_delayTimer.Enabled = false;
    }
    #endregion

    #region PleaseWait
    private static void PleaseWait_Theme() {
    SetControlsArrTheme(new object[] { common.PleaseWait, common.PleaseWait.PleaseWait_ProgressText });
        if (common.S.DarkTheme) {
            common.PleaseWait.PleaseWait_text.ForeColor = Color.FromArgb(0, 200, 0);
            
                var pw_spb = common.PleaseWait.StopProcess_Button;
            {
                pw_spb.ForeColor = Color.FromArgb(230, 255, 230);
                pw_spb.BackColor = Color.FromArgb(55, 28, 25);
                
                    var pw_spb_fa = pw_spb.FlatAppearance;
                {
                    pw_spb_fa.MouseOverBackColor = Color.FromArgb(128, 0, 0);
                    pw_spb_fa.MouseDownBackColor = Color.FromArgb(80, 0, 0);
                }
            }
        } else {
            common.PleaseWait.PleaseWait_text.ForeColor = Color.FromArgb(0, 100, 0);
            common.PleaseWait.StopProcess_Button.BackColor = Color.FromArgb(255, 228, 225);
            
                var pw_spb = common.PleaseWait.StopProcess_Button;
            {
                pw_spb.BackColor = Color.FromArgb(255, 228, 225);
                pw_spb.ForeColor = Color.DarkRed;
                
                    var pw_spb_fa = pw_spb.FlatAppearance;
                {
                    pw_spb_fa.MouseOverBackColor = Color.FromArgb(240, 128, 128);
                    pw_spb_fa.MouseDownBackColor = Color.FromArgb(128, 0, 0);
                }
            }
        }
    }
    #endregion

    #region Settings
    private static void Settings_Theme() {
        SetControlsArrTheme(new object[] { common.Settings, common.Settings.ResetGA_GroupBox, common.Settings.Close_Button });
        if (common.S.DarkTheme) {
            
                var stg = common.Settings;
            {
                stg.ButtonsBG_UI.BackColor = Color.FromArgb(32, 32, 32);
                stg.ResetGA_LogsOnly_CheckBox_Label.ForeColor = Color.FromArgb(100, 100, 100);
                stg.ResetGA_Settings_CheckBox_Label.ForeColor = Color.FromArgb(100, 100, 100);
                stg.OpenLogsFolder.ForeColor = Color.FromArgb(100, 100, 100);
                stg.ResetGA.FlatAppearance.MouseOverBackColor = Color.FromArgb(135, 83, 59);
                {
                    var stg_rsa = stg.ResetGA_SelectAll;
                    stg_rsa.Image = prop.x24.SelectAll_W_24;
                    stg_rsa.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
                    stg_rsa.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 100, 100);
                }

                stg.SettingsIcon_PictureBox.Image = prop.x64.Settings_dark_64;
                stg.SettingsTitle_Label.ForeColor = Color.FromArgb(184, 243, 254);
                stg.Close_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            }
        } else {
            
                 
            {
                common.Settings.ButtonsBG_UI.BackColor = Color.WhiteSmoke;
                common.Settings.ResetGA_LogsOnly_CheckBox_Label.ForeColor = Color.FromArgb(64, 64, 64);
                common.Settings.ResetGA_Settings_CheckBox_Label.ForeColor = Color.FromArgb(64, 64, 64);
                common.Settings.OpenLogsFolder.ForeColor = Color.FromArgb(64, 64, 64);
                common.Settings.ResetGA.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 203, 179);
                   
                {
                    common.Settings.ResetGA_SelectAll.Image = prop.x24.SelectAll_B_24;
                    common.Settings.ResetGA_SelectAll.FlatAppearance.MouseOverBackColor = Color.Silver;
                    common.Settings.ResetGA_SelectAll.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
                }

                common.Settings.SettingsIcon_PictureBox.Image = prop.x64.Settings_64;
                common.Settings.SettingsTitle_Label.ForeColor = Color.FromArgb(0, 106, 128);
                common.Settings.Close_Button.FlatAppearance.MouseOverBackColor = Color.Silver;
            }
        }
         
        {
            common.Settings.ResetGA.BackColor = common.Settings.ButtonsBG_UI.BackColor;
            common.Settings.ResetGA_SelectAll.BackColor = common.Settings.ButtonsBG_UI.BackColor;
            common.Settings.GeekAssistant_PictureBox.BackColor = common.Settings.ButtonsBG_UI.BackColor;
            common.Settings.Close_Button.BackColor = common.Settings.BackColor;
        }
    }
    #endregion

    #region ToU
    private static void ToU_Theme() {
        SetControlsArrTheme(new object[] {common.ToU,common.ToU.TermsOfUse_Box,common.ToU.ToU_Reject,common.ToU.ToU_Accept });

        // Do this hell
        if (common.S.DarkTheme) {
           common.ToU.ButtonsBG_UI.BackColor = Color.FromArgb(32, 32, 32);
           common.ToU.Icon_PictureBox.Image = prop.x64.ToU_dark_64;
           common.ToU.ToUTitle_Label.ForeColor = Color.FromArgb(178, 255, 220);
        } else {
           common.ToU.ButtonsBG_UI.BackColor = Color.WhiteSmoke;
           common.ToU.Icon_PictureBox.Image = prop.x64.ToU_64;
           common.ToU.ToUTitle_Label.ForeColor = Color.FromArgb(0, 102, 71);
        }

       common.ToU.AcceptCheck_ToU.ForeColor =common.ToU.ToUTitle_Label.ForeColor;
       common.ToU.Copyright_Label.ForeColor =common.ToU.ToUTitle_Label.ForeColor;
       common.ToU.AcceptCheck_ToU.ForeColor = Current_fgColor();
       common.ToU.DontShow_ToU.ForeColor = Current_fgColor();
       common.ToU.AcceptCheck_ToU.BackColor =common.ToU.ButtonsBG_UI.BackColor;
       common.ToU.DontShow_ToU.BackColor =common.ToU.ButtonsBG_UI.BackColor;
       common.ToU.GeekAssistant_PictureBox.BackColor =common.ToU.ButtonsBG_UI.BackColor;
    }
#endregion

    #region Theming Mechanism
    private static void SetControlsArrTheme(object[] ControlsObj) {
        foreach (object controlObj in ControlsObj) SetControlTheme(controlObj);
    }

    private static void SetControlsArrTheme_Metro(object[] ControlsObj) {
        foreach (object c in ControlsObj) SetControlTheme_Metro(c);
    }

    private static void SetControlTheme(object ControlObj) {
        if (common.S.PerformAnimations) { 
            Animate.Run(ControlObj, "ForeColor", Current_fgColor());
            Animate.Run(ControlObj, "BackColor", Current_bgColor());
        } else { 
            ControlObj.ForeColor = Current_fgColor();
            ControlObj.BackColor = Current_bgColor();
        }
    }

    private static void SetControlTheme_Metro(object ControlObj) {
        ControlObj.Theme = Current_Theme_Metro();
        // Cannot animate "Theme" 'Transition.run(ControlObj, "Theme", Current_Theme_Metro(), New TransitionType_CriticalDamping(500))
    }

    #region Current Theme Colors
    public static Color Current_bgColor() {
        if (common.S.DarkTheme) return bgDark;
        else return bgLight;
         
    }

    public static Color Current_fgColor() {
        if (common.S.DarkTheme) return fgDark;
        else return fgLight; 
    }

    public static MetroFramework.MetroThemeStyle Current_Theme_Metro() {
        if (common.S.DarkTheme) return MetroFramework.MetroThemeStyle.Dark;
        else return MetroFramework.MetroThemeStyle.Default; 
        
    }
    #endregion

    #region Theme Colors
    private static readonly Color bgLight = Color.White;
    private static readonly Color fgLight = SystemColors.ControlText;
    private static readonly Color bgDark = Color.FromArgb(17, 17, 17);
    private static readonly Color fgDark = Color.White;
    #endregion

    #endregion
}