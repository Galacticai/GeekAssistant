Imports Transitions

Module GA_SetTheme
    Public Sub Run(FormName As String, Optional initiating As Boolean = False)
        ' DarkTheme = My.Settings.DarkTheme
        initiatingbool = initiating

        'If initiating And Not My.Settings.DarkTheme And FormName <> "Main" Then
        '    Exit Sub
        'End If

        Select Case FormName
            Case AppMode.Name
                SetControlTheme(AppMode)
                AppMode.startup_dontShow.ForeColor = Current_fgColor()
            Case Donate.Name
                Donate_Theme()
            Case info.Name
                info_Theme()
            Case Main.Name

                If My.Settings.VerboseLogging Then
                    Dim ThemeString = "dark theme"
                    If My.Settings.DarkTheme Then ThemeString = "Light Theme"
                    GA_SetProgressText.Run($"Switched to {ThemeString}.", -1)
                End If

                If Not initiating And My.Settings.PerformAnimations Then
                    If My.Settings.DarkTheme Then
                        Main.SwitchTheme_Back_UI.Top = -Main.SwitchTheme_Back_UI.Height
                        'Main.SwitchTheme_Mid_UI.Top = -Main.SwitchTheme_Back_UI.Height - 50
                        'Main.SwitchTheme_Fore_UI.Top = -Main.SwitchTheme_Fore_UI.Height - 100
                        Transition.run(Main.SwitchTheme_Back_UI, "Top", Main.Height, New TransitionType_CriticalDamping(1000))
                        'Transition.run(Main.SwitchTheme_Mid_UI, "Top", Main.Height + 50, New TransitionType_CriticalDamping(1000))
                        'Transition.run(Main.SwitchTheme_Fore_UI, "Top", Main.Height + 100, New TransitionType_CriticalDamping(1000))
                    Else
                        Main.SwitchTheme_Back_UI.Top = Main.Height
                        'Main.SwitchTheme_Mid_UI.Top = Main.Height + 50
                        'Main.SwitchTheme_Fore_UI.Top = Main.Height + 100
                        Transition.run(Main.SwitchTheme_Back_UI, "Top", -Main.SwitchTheme_Back_UI.Height, New TransitionType_CriticalDamping(1000))
                        'Transition.run(Main.SwitchTheme_Mid_UI, "Top", -Main.SwitchTheme_Mid_UI.Height - 50, New TransitionType_CriticalDamping(1000))
                        'Transition.run(Main.SwitchTheme_Fore_UI, "Top", -Main.SwitchTheme_Fore_UI.Height - 100, New TransitionType_CriticalDamping(1000))
                    End If
                End If

                MainTheme_delayTimer.Enabled = True
            Case PleaseWait.Name
                PleaseWait_Theme()
            Case GA_Settings.Name
                Settings_Theme()
            Case ToU.Name
                ToU_Theme()
            Case Preparing.Name
                Preparing.Preparing_Label.ForeColor = Current_fgColor()
                Preparing.BackColor = Current_bgColor()
        End Select
    End Sub


#Region "Donate"

    Private Sub Donate_Theme()
        SetControlsArrTheme({Donate,
                            Donate.BitcoinAddress,
                            Donate.BitcoinNote})
        If My.Settings.DarkTheme Then
            Donate.ButtonsBG_UI.BackColor = Color.FromArgb(32, 32, 32)
            Donate.Close_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64)
            Donate.pic.Image = My.Resources.DonateHeart_Dark_64
            Donate.title.ForeColor = Color.FromArgb(255, 191, 217)
            Donate.BitcoinAddressQR.Image = My.Resources.BTCAddressQR_Dark
            Donate.GooglePayLink.Image = My.Resources.linkIcon_dark_16
        Else
            Donate.ButtonsBG_UI.BackColor = Color.WhiteSmoke
            Donate.Close_Button.FlatAppearance.MouseOverBackColor = Color.Silver
            Donate.pic.Image = My.Resources.DonateHeart_64
            Donate.title.ForeColor = Color.FromArgb(128, 0, 87)
            Donate.BitcoinAddressQR.Image = My.Resources.BTCAddressQR
            Donate.GooglePayLink.Image = My.Resources.linkIcon_16
        End If
        Donate.GeekAssistant_PictureBox.BackColor = Donate.ButtonsBG_UI.BackColor
    End Sub

#End Region

#Region "info"
    Private Sub info_Theme()
        SetControlsArrTheme({info,
                             info.info_PictureBox,
                             info.msg_Textbox,
                             info.No_Button})
        If My.Settings.DarkTheme Then
            info.ButtonsBG_UI.BackColor = Color.FromArgb(32, 32, 32)
            info.Copy_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64)
            info.Yes_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64)
            info.No_Button.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64)
        Else
            info.ButtonsBG_UI.BackColor = Color.WhiteSmoke
            info.Copy_Button.FlatAppearance.MouseOverBackColor = Color.Silver
            info.Yes_Button.FlatAppearance.MouseOverBackColor = Color.Silver
            info.No_Button.FlatAppearance.MouseOverBackColor = Color.Silver
        End If
        info.GeekAssistant_PictureBox.BackColor = info.ButtonsBG_UI.BackColor
        'info.Copy_Button.ForeColor = Current_fgColor()
        'info.Copy_Button.BackColor = Current_bgColor()
        'info.Close_Button.ForeColor = Current_fgColor()
        'info.Close_Button.BackColor = Current_bgColor()
        'info.DownloadDrivers_Button.ForeColor = Current_fgColor()
        'info.DownloadDrivers_Button.BackColor = Current_bgColor()


    End Sub
#End Region

#Region "Main"
    Private WithEvents MainTheme_delayTimer As New Timer() With {.Interval = 100}
    Private initiatingbool As Boolean = False
    Private Sub MainTheme_delayTimer_Tick(sender As Object, e As EventArgs) Handles MainTheme_delayTimer.Tick
        Dim Controls_array As Object() = {Main,
                                          Main.ManualInfo_GroupBox,
                                          Main.ProgressFakeBG_UI,
                                          Main.Main_Tabs,
                                          Main.PrepareYourDevice_Tab,
                                          Main.FlashZip_Tab,
                                          Main.MoreTools_Tab,
                                          Main.log,
                                          Main.BootloaderUnlockable_CheckBox,
                                          Main.CustomROM_CheckBox,
                                          Main.CustomRecovery_CheckBox
                                         }
        Dim MetroControls_array As Object() = {
                                               Main.Main_Tabs,
                                               Main.PrepareYourDevice_Tab,
                                               Main.FlashZip_Tab,
                                               Main.MoreTools_Tab,
                                               Main.GA_About_Label,
                                               Main.UnlockBL_Label,
                                               Main.MagiskRoot_Label,
                                               Main.Manufacturer_ComboBox,
                                               Main.AndroidVersion_ComboBox,
                                               Main.ProgressBar,
                                               Main.manualCMD_TextBox,
                                               Main.FlashZip_ChooseFile_TextBox,
                                               Main.UnlockBL_Button,
                                               Main.MagiskRoot_Button,
                                               Main.FlashZip_Button,
                                               Main.ProgressBarLabel
                                              }
        SetControlsArrTheme_Metro(MetroControls_array)


        If initiatingbool Then GoTo NoAnimation
        SetControlsArrTheme(Controls_array)
NoAnimation:
        If Not initiatingbool Then GoTo skipNoAnimation
        For Each c As Object In Controls_array
            c.BackColor = Current_bgColor()
            c.ForeColor = Current_fgColor()
        Next
skipNoAnimation:

        If My.Settings.DarkTheme Then
            'Main.SwitchTheme_Mid_UI.BackColor = Color.FromArgb(235, 245, 235)
            'Transition.run(Main.SwitchTheme_Mid_UI, "BackColor", Color.FromArgb(0, 20, 0), New TransitionType_CriticalDamping(1000))
            Main.Main_ToolTip.BackColor = SystemColors.InfoText
            Main.Main_ToolTip.ForeColor = SystemColors.Info
            With Main
                With .AutoDetectDeviceInfo_Button
                    .ForeColor = Color.FromArgb(95, 191, 119)
                    .BackColor = Color.FromArgb(64, 64, 64)
                    .FlatAppearance.MouseDownBackColor = Color.Honeydew
                    .FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 74)
                    .Image = My.Resources.AutoDetect_dark_64
                End With

                '.DeviceState_Label.ForeColor = Color.FromArgb(95, 191, 119)
                .Donate_Button.Icon = My.Resources.DonateHeart_Dark_24
                .SwitchTheme_Button.Icon = My.Resources.Theme_Dark_24
                .GeekAssistant.Image = My.Resources.Geek_Assistant_Dark
                .Feedback_Button.Icon = My.Resources.Smile_dark_24
                .About_Button.Icon = My.Resources.ToU_dark_24
                .Settings_Button.Icon = My.Resources.Settings_dark_24
                .ShowLog_Button.Icon = My.Resources.Commands_dark_24
                .manualCMD_TextBox.Icon = My.Resources.Commands_dark_16
            End With
        Else 'Light Theme
            'Main.SwitchTheme_Mid_UI.BackColor = Color.FromArgb(0, 20, 0)
            'Transition.run(Main.SwitchTheme_Mid_UI, "BackColor", Color.FromArgb(235, 245, 235), New TransitionType_CriticalDamping(1000))
            Main.Main_ToolTip.BackColor = SystemColors.Info
            Main.Main_ToolTip.ForeColor = SystemColors.InfoText

            With Main
                With .AutoDetectDeviceInfo_Button
                    .ForeColor = Color.FromArgb(0, 128, 32)
                    .BackColor = Color.Honeydew
                    .FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64)
                    .FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 245, 230)
                    .Image = My.Resources.AutoDetect_64
                End With
                '.DeviceState_Label.ForeColor = Color.FromArgb(0, 128, 32)
                .Donate_Button.Icon = My.Resources.DonateHeart_24
                .SwitchTheme_Button.Icon = My.Resources.Theme_Light_24
                .GeekAssistant.Image = My.Resources.Geek_Assistant
                .Feedback_Button.Icon = My.Resources.Smile_24
                .About_Button.Icon = My.Resources.ToU_24
                .Settings_Button.Icon = My.Resources.Settings_24
                .ShowLog_Button.Icon = My.Resources.Commands_24
                .manualCMD_TextBox.Icon = My.Resources.Commands_16
            End With
        End If
        MainTheme_delayTimer.Enabled = False
    End Sub
#End Region

#Region "PleaseWait"
    Private Sub PleaseWait_Theme()
        SetControlsArrTheme({PleaseWait,
                            PleaseWait.PleaseWait_ProgressText})
        If My.Settings.DarkTheme Then
            PleaseWait.PleaseWait_text.ForeColor = Color.FromArgb(0, 200, 0)
            With PleaseWait.StopProcess_Button
                .ForeColor = Color.FromArgb(230, 255, 230)
                .BackColor = Color.FromArgb(55, 28, 25)
                With .FlatAppearance
                    .MouseOverBackColor = Color.FromArgb(128, 0, 0)
                    .MouseDownBackColor = Color.FromArgb(80, 0, 0)
                End With
            End With
        Else
            PleaseWait.PleaseWait_text.ForeColor = Color.FromArgb(0, 100, 0)
            PleaseWait.StopProcess_Button.BackColor = Color.FromArgb(255, 228, 225)
            With PleaseWait.StopProcess_Button
                .BackColor = Color.FromArgb(255, 228, 225)
                .ForeColor = Color.DarkRed
                With .FlatAppearance
                    .MouseOverBackColor = Color.FromArgb(240, 128, 128)
                    .MouseDownBackColor = Color.FromArgb(128, 0, 0)
                End With
            End With

        End If
    End Sub
#End Region

#Region "Settings"
    Private Sub Settings_Theme()
        SetControlsArrTheme({GA_Settings,
                            GA_Settings.ResetGA_GroupBox,
                            GA_Settings.Close_Button})

        If My.Settings.DarkTheme Then
            GA_Settings.ButtonsBG_UI.BackColor = Color.FromArgb(32, 32, 32)
            GA_Settings.ResetGA_LogsOnly_CheckBox_Label.ForeColor = Color.FromArgb(100, 100, 100)
            GA_Settings.ResetGA_Settings_CheckBox_Label.ForeColor = Color.FromArgb(100, 100, 100)
            GA_Settings.OpenLogsFolder.ForeColor = Color.FromArgb(100, 100, 100)
            GA_Settings.ResetGA.FlatAppearance.MouseOverBackColor = Color.FromArgb(135, 83, 59)
            GA_Settings.ResetGA_SelectAll.Image = My.Resources.SelectAll_W_24
            GA_Settings.ResetGA_SelectAll.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64)
            GA_Settings.ResetGA_SelectAll.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 100, 100)
            GA_Settings.SettingsIcon_PictureBox.Image = My.Resources.Settings_dark_64
            GA_Settings.SettingsTitle_Label.ForeColor = Color.FromArgb(184, 243, 254)
        Else
            GA_Settings.ButtonsBG_UI.BackColor = Color.WhiteSmoke
            GA_Settings.ResetGA_LogsOnly_CheckBox_Label.ForeColor = Color.FromArgb(64, 64, 64)
            GA_Settings.ResetGA_Settings_CheckBox_Label.ForeColor = Color.FromArgb(64, 64, 64)
            GA_Settings.OpenLogsFolder.ForeColor = Color.FromArgb(64, 64, 64)
            GA_Settings.ResetGA.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 203, 179)
            GA_Settings.ResetGA_SelectAll.Image = My.Resources.SelectAll_B_24
            GA_Settings.ResetGA_SelectAll.FlatAppearance.MouseOverBackColor = Color.Silver
            GA_Settings.ResetGA_SelectAll.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64)
            GA_Settings.SettingsIcon_PictureBox.Image = My.Resources.Settings_64
            GA_Settings.SettingsTitle_Label.ForeColor = Color.FromArgb(0, 106, 128)

        End If
        GA_Settings.ResetGA.BackColor = GA_Settings.ButtonsBG_UI.BackColor
        GA_Settings.ResetGA_SelectAll.BackColor = GA_Settings.ButtonsBG_UI.BackColor
        GA_Settings.GeekAssistant_PictureBox.BackColor = GA_Settings.ButtonsBG_UI.BackColor
        GA_Settings.Close_Button.BackColor = GA_Settings.BackColor
    End Sub
#End Region

#Region "ToU"
    Private Sub ToU_Theme()
        SetControlsArrTheme({ToU,
                            ToU.TermsOfUse_Box,
                            ToU.ToU_Reject,
                            ToU.ToU_Accept})

        'Do this hell
        If My.Settings.DarkTheme Then
            ToU.ButtonsBG_UI.BackColor = Color.FromArgb(32, 32, 32)
            ToU.Icon_PictureBox.Image = My.Resources.ToU_dark_64
            ToU.ToUTitle_Label.ForeColor = Color.FromArgb(178, 255, 220)
        Else
            ToU.ButtonsBG_UI.BackColor = Color.WhiteSmoke
            ToU.Icon_PictureBox.Image = My.Resources.ToU_64
            ToU.ToUTitle_Label.ForeColor = Color.FromArgb(0, 102, 71)
        End If

        ToU.Copyright.ForeColor = ToU.ToUTitle_Label.ForeColor
        ToU.AcceptCheck_ToU.ForeColor = Current_fgColor()
        ToU.DontShow_ToU.ForeColor = Current_fgColor()
        ToU.AcceptCheck_ToU.BackColor = ToU.ButtonsBG_UI.BackColor
        ToU.DontShow_ToU.BackColor = ToU.ButtonsBG_UI.BackColor
        ToU.GeekAssistant_PictureBox.BackColor = ToU.ButtonsBG_UI.BackColor

    End Sub
#End Region

#Region "Theming Mechanism"

    Private Sub SetControlsArrTheme(controlsObj As Object())
        For Each controlObj As Object In controlsObj
            SetControlTheme(controlObj)
        Next
    End Sub

    Private Sub SetControlsArrTheme_Metro(controlsObj As Object())
        For Each c As Object In controlsObj
            SetControlTheme_Metro(c)
        Next
    End Sub

    Private Sub SetControlTheme(ControlObj As Object)
        If Not My.Settings.PerformAnimations Then
            ControlObj.BackColor = Current_bgColor()
            ControlObj.ForeColor = Current_fgColor()
        Else
            Transition.run(ControlObj, "BackColor", Current_bgColor(), New TransitionType_CriticalDamping(500))
            Transition.run(ControlObj, "ForeColor", Current_fgColor(), New TransitionType_CriticalDamping(500))

        End If
    End Sub

    Private Sub SetControlTheme_Metro(ControlObj As Object)
        ' Cannot animate "Theme" 'Transition.run(ControlObj, "Theme", Current_Theme_Metro(), New TransitionType_CriticalDamping(500))
        ControlObj.Theme = Current_Theme_Metro()
    End Sub

    Public Function Current_bgColor() As Color
        If My.Settings.DarkTheme Then
            Return bgDark
        Else Return bgLight
        End If
    End Function

    Public Function Current_fgColor() As Color
        If My.Settings.DarkTheme Then
            Return fgDark
        Else Return fgLight
        End If
    End Function

    Public Function Current_Theme_Metro() As MetroFramework.MetroThemeStyle
        If My.Settings.DarkTheme Then
            Return MetroFramework.MetroThemeStyle.Dark
        Else Return MetroFramework.MetroThemeStyle.Default
        End If
    End Function

#Region "Theme Colors"
    Private bgLight As Color = Color.White
    Private fgLight As Color = SystemColors.ControlText
    Private bgDark As Color = Color.FromArgb(17, 17, 17)
    Private fgDark As Color = Color.White
#End Region

#End Region
End Module
