

Module GA_adb_Functions

#Region "GA Custom adb"

    Public Sub DeviceInfoSave(DeviceSerial As String, DeviceState As String,
                                DeviceManufacturer As String, DeviceAPILevel As Integer,
                                DeviceUnlockedBootloader As Boolean, DeviceCustomRecovery As Boolean,
                                DeviceCustomRom As Boolean)

        If DeviceSerial IsNot Nothing Then My.Settings.DeviceSerial = DeviceSerial

        If DeviceState IsNot Nothing Then My.Settings.DeviceState = DeviceState

        If DeviceManufacturer IsNot Nothing Then My.Settings.DeviceManufacturer = DeviceManufacturer

        If DeviceAPILevel > 0 Then My.Settings.DeviceAPILevel = DeviceAPILevel

        If DeviceUnlockedBootloader <> Nothing Then My.Settings.DeviceBootloaderUnlockSupported = DeviceUnlockedBootloader

        If DeviceUnlockedBootloader <> Nothing Then My.Settings.DeviceCustomRecovery = DeviceCustomRecovery

        If DeviceUnlockedBootloader <> Nothing Then My.Settings.DeviceCustomROM = DeviceCustomRom

        My.Settings.Save()
    End Sub

    ''' <summary>
    ''' Capitalize the first letter. And "lge" becomes "LG" 
    ''' </summary>
    ''' <param name="ManufacturerString">Raw string to work on and fix</param>
    ''' <returns>ManufacturerString As String</returns>
    Public Function FixManufacturerString(ManufacturerString As String)
        ManufacturerString = ManufacturerString.Substring(0, 1).ToUpper() & ManufacturerString.Substring(1).ToLower()
        If ManufacturerString = "Lge" Then ManufacturerString = "LG" 'Special case for LG 
        Return ManufacturerString
    End Function

    ''' <summary>
    ''' Pushes Wsource path to {/sdcard/0/GeekAssistant/}(FileName.extension)"
    ''' </summary>
    ''' <param name="Wsource">Path(Folder\FileName) to push to Android</param>
    ''' <param name="customAdestination">(Optional) Custom destination path(Folder/) on Android (Default: {/sdcard/0/GeekAssistant/}...)</param>
    Public Sub Push(Wsource As String, Optional customAdestination As String = "/sdcard/0/GeekAssistant/")
        adbDo($"push ""{Wsource}"" ""{customAdestination}{IO.Path.GetFileName(Wsource)}""")
    End Sub

    ''' <summary>
    ''' Pulls Asource path from Android to Wdestination path on Windows
    ''' </summary>
    ''' <param name="Asource">Source path(Folder/fileName) to pull from Android</param>
    ''' <param name="Wdestination">Destination path(Folder\) on Windows </param>
    Public Sub Pull(Asource As String, Wdestination As String)
        adbDo($"pull ""{Asource}"" ""{Wdestination}""")
    End Sub

    Private AndroidVersion As String
    Private ApiToVer As New Dictionary(Of Integer, String())
    ' Public Shared AndroidVerToComboBox As New Dictionary(Of Integer, String).Start()
    Public Sub PrepareAndroidDictionary()
        ApiToVer.Clear()

        Dim K_ = "KitKat 4.4 (And Below)"
        Dim L_ = "Lollipop 5.x"
        Dim M_ = "Marshmallow 6.x"
        Dim N_ = "Nougat 7.x"
        Dim O_ = "Oreo 8.x"
        Dim P_ = "Pie 9.x"
        Dim Q_ = "Android 10 Q"
        Dim R_ = "Android 11 R (And Above)"
        With ApiToVer
            .Add(1, {"1.0", K_})
            .Add(2, {"1.1", K_})
            .Add(3, {"Cupcake 1.5", K_})
            .Add(4, {"Donut 1.6", K_})
            .Add(5, {"Eclair 2.0", K_})
            .Add(6, {"Eclair 2.0", K_})
            .Add(7, {"Eclair 2.1", K_})
            .Add(8, {"Froyo 2.2", K_})
            .Add(9, {"Gingerbread 2.3", K_})
            .Add(10, {"Gingerbread 2.3", K_})
            .Add(11, {"Honeycomb 3.0", K_})
            .Add(12, {"Honeycomb 3.1", K_})
            .Add(13, {"Honeycomb 3.2", K_})
            .Add(14, {"ICS 4.0", K_})
            .Add(15, {"ICS 4.0", K_})
            .Add(16, {"Jelly Bean 4.1", K_})
            .Add(17, {"Jelly Bean 4.2", K_})
            .Add(18, {"Jelly Bean 4.3", K_})
            .Add(19, {"KitKat 4.4", K_})
            .Add(21, {"Lollipop 5.0", L_})
            .Add(22, {"Lollipop 5.1", L_})
            .Add(23, {"Marshmallow 6.0", M_})
            .Add(24, {"Nougat 7.0", N_})
            .Add(25, {"Nougat 7.1", N_})
            .Add(26, {"Oreo 8.0", O_})
            .Add(27, {"Oreo 8.1", O_})
            .Add(28, {P_, P_})
            .Add(29, {Q_, Q_})
            .Add(30, {R_, R_})
        End With
    End Sub
    'Public Sub PrepareDeviceInfo(APIlevel As Integer, Manufacturer As Boolean, Count As Boolean)
    '    If My.Settings.DeviceManufacturer.Length > 0 Then
    '        GA_SetProgressText.Run("Detected previous device info.", 0)
    '    Else GA_SetProgressText.Run("No previous device info. Setting default values.", 0)
    '    End If
    '    'If Not APIlevel = 0 Then
    '    DetermineVersionFromSDK_OLD(APIlevel, False)

    '    If Manufacturer And My.Settings.DeviceManufacturer.Length > 0 Then
    '        Main.Manufacturer_ComboBox.Text = FixManufacturerString(My.Settings.DeviceManufacturer)
    '    End If
    '    'If AndroidVersion And My.Settings.DeviceAPILevel > 0 Then
    '    '    Main.AndroidVersion_ComboBox.Text = 
    '    'End If
    '    If Count And My.Settings.DeviceState <> "Disconnected" Then
    '        Main.DeviceState_Label.Text = My.Settings.DeviceState
    '    End If
    'End Sub

    Private AnyStringArray As String()
    Public Sub DetermineVersionFromSDK_OLD(APIlevel As Integer, Optional GetMain As Boolean = False)
        Dim APINull As Boolean = False
        If ApiToVer.Count = 0 Then PrepareAndroidDictionary()

        If GetMain Then
            GA_SetProgressText.Run("Converting api level to version string...", 0)
            ApiToVer.TryGetValue(APIlevel, AnyStringArray)
            GA_SetProgressText.Run("Setting api version string...", 0)
            AndroidVersion = AnyStringArray(0)
        Else
            If APIlevel = 0 And My.Settings.DeviceAPILevel > 0 Then
                APIlevel = My.Settings.DeviceAPILevel
            ElseIf My.Settings.DeviceAPILevel = 0 Then
                AndroidVersion = "Select Android Version"
                APINull = True
            End If
            If Not APINull Then
                ApiToVer.TryGetValue(APIlevel, AnyStringArray)
                AndroidVersion = AnyStringArray(1)
            End If
            Main.AndroidVersion_ComboBox.Text = AndroidVersion
        End If
    End Sub

    Public Function ConvertAPILevelToAVer(APIint As Integer) As String()
        If APIint <= 0 Then
            DoMsg(10, "Error while processing your device API level!", 2)
            Return {"❌", "❌"}
        Else
            Dim disposableDictionary As String() = {"", ""}
            ApiToVer.TryGetValue(APIint, disposableDictionary)
            Return disposableDictionary
        End If
    End Function
    Public Function ConvertAVerToAPILevel(AVer As String) As Integer

        If AVer Is Nothing Or AVer = "" Then
            'DoMsg(10, "Error while processing your device Android Version!", 2)
            Return 0
        Else
            Dim K_ = "KitKat 4.4 (And Below)"
            Dim L_ = "Lollipop 5.x"
            Dim M_ = "Marshmallow 6.x"
            Dim N_ = "Nougat 7.x"
            Dim O_ = "Oreo 8.x"
            Dim P_ = "Pie 9.x"
            Dim Q_ = "Android 10 Q"
            Dim R_ = "Android 11 R (And Above)"
            Dim result As Integer = 0
            Select Case AVer
                Case 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19
                    result = K_
                Case 21, 22
                    result = L_
                Case 23
                    result = m_
                Case 24, 25
                    result = q_
                Case 26, 27
                    result = q_
                Case 29
                    result = Q_
                Case 30
                    result = R_
            End Select
            Return result
        End If
    End Function

    Public Sub ResetDeviceInfo()
        With My.Settings
            .DeviceAPILevel = 0
            .DeviceBatteryLevel = 0
            .DeviceBootloaderUnlockSupported = False
            .DeviceCount = 0
            .DeviceCustomRecovery = False
            .DeviceCustomROM = False
            .DeviceManufacturer = ""
            .DeviceRooted = False
            .DeviceSerial = ""
            .DeviceState = ""
        End With
        With Main
            .Manufacturer_ComboBox.SelectedIndex = -1
            .AndroidVersion_ComboBox.SelectedIndex = -1
            .BootloaderUnlockable_CheckBox.Checked = False
            .Rooted_Checkbox.Checked = False
            .CustomROM_CheckBox.Checked = False
            .CustomRecovery_CheckBox.Checked = False
        End With
    End Sub

#End Region

End Module
