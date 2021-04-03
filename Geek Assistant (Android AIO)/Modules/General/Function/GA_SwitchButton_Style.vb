Module GA_SwitchButton_Style

    'Public Shared Top As Integer
    'Public Shared Left As Integer
    'Public Shared ButtonOriginalPosition As Integer()
    Private Function Current_bg_Active() As Color
        If My.Settings.DarkTheme Then
            Return Color.FromArgb(0, 120, 0)
        Else Return Color.Green
        End If
    End Function
    Private Function Current_bg_Hover() As Color
        If My.Settings.DarkTheme Then
            Return Color.FromArgb(32, 72, 32)
        Else Return Color.Honeydew
        End If
    End Function

    Private Function Current_bg_Neutral() As Color
        If My.Settings.DarkTheme Then
            Return Color.FromArgb(32, 32, 32)
        Else Return Color.WhiteSmoke
        End If
    End Function

    Public ButtonPressedAlready As Boolean
    Public Sub SettingsButtonSwitch_Style_EnableIfTrue(ByRef aButton As Button, ByRef aBoolean As Boolean)
        If aBoolean Then
            aButton.ForeColor = Color.White()
            aButton.BackColor = Current_bg_Active()
        Else
            aButton.ForeColor = Current_fgColor()
            aButton.BackColor = Current_bg_Neutral()
        End If
    End Sub

    Public Sub SettingsButtonSwitch_Style_MouseDown_KeyDown(ByRef aButton As Button)
        ''
        '' Fixing button flying away problem when long clicking with keyboard (repeating KeyDown event)
        '' 
        If ButtonPressedAlready Then
            Exit Sub
        End If
        ButtonPressedAlready = True

        aButton.ForeColor = Color.White()
        aButton.Top += 2
        aButton.Left += 1

    End Sub

    Public Sub SettingsButtonSwitch_Style_MouseUp_KeyUp(ByRef aButton As Button)
        ButtonPressedAlready = False
        aButton.ForeColor = Current_fgColor()
        If aButton.BackColor = Color.Green Or aButton.BackColor = Color.FromArgb(0, 130, 0) Then
            aButton.ForeColor = Color.White
        End If
        'If Not My.Settings.DarkTheme Then
        '    aButton.BackColor = Color.FromArgb(32, 32, 32)
        'End If
        aButton.Top -= 2
        aButton.Left -= 1
    End Sub

    Public Sub SettingsButtonSwitch_Style_MouseEnter(ByRef aButton As Button, ByRef aBoolean As Boolean)
        If aBoolean Then
            aButton.BackColor = Color.FromArgb(0, 130, 0)
            aButton.ForeColor = Color.White()
        Else
            aButton.BackColor = Current_bg_Hover()
            aButton.ForeColor = Current_fgColor()
        End If
    End Sub

    Public Sub SettingsButtonSwitch_Style_MouseLeave(ByRef aButton As Button, ByRef aBoolean As Boolean)
        If aBoolean Then
            aButton.BackColor = Current_bg_Active()
            aButton.ForeColor = Color.White()
        Else
            aButton.BackColor = Current_bg_Neutral()
            aButton.ForeColor = Current_fgColor()
        End If
    End Sub

    Public Sub SettingsButtonSwitch_Style_MouseClick(ByRef aButton As Button, ByRef aBoolean As Boolean, ByRef aTooltip As ToolTip, aTooltip_txt As String)
        If aBoolean Then
            aButton.BackColor = Color.Transparent
            aBoolean = False
            My.Settings.Save()
            If aTooltip IsNot Nothing And aTooltip_txt IsNot Nothing Then _
                aTooltip.SetToolTip(aButton, $"(Disabled) {aTooltip_txt}")
        Else
            aButton.BackColor = Current_bg_Active()
            aBoolean = True
            My.Settings.Save()
            If aTooltip IsNot Nothing And aTooltip_txt IsNot Nothing Then _
                aTooltip.SetToolTip(aButton, $"(Enabled) {aTooltip_txt}")
        End If
    End Sub

End Module
