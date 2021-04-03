'Imports System.IO
'Imports System.ComponentModel
'Imports Managed.Adb
'Module adb_DeviceInfo_Deprecated
'    'Dim adbStopOnError As Boolean
'    'Dim adbItems As String()
'    'Private WithEvents adbWorker As New BackgroundWorker
'    'Public Sub adbDetect(StopOnError As Boolean, Items As String())
'    '    adbStopOnError = StopOnError 'Setup adbStopOnError
'    '    If Items IsNot Nothing Then adbItems = Items 'Setup adbItems if not null
'    '    RemoveHandler adbWorker.DoWork, AddressOf adbDetect_start 'Remove handled (in case it is handled already) to avoid multiple handlers
'    '    AddHandler adbWorker.DoWork, AddressOf adbDetect_start 'Start Handling the event
'    '    adbWorker.WorkerReportsProgress = True
'    '    adbWorker.RunWorkerAsync() 'Start Async adb 
'    'End Sub

'    'Private SetProgressText_text, LogEvent_EventName, LogAppendText_text As String
'    'Private SetProgressText_level, LogEvent_lines, LogAppendText_lines As Integer
'    'Private Do_SetProgressText, Do_LogEvent, Do_LogAppendText As Boolean
'    'Private Sub adbWorker_ProgressChanged(sender As Object, ev As ProgressChangedEventArgs) Handles adbWorker.ProgressChanged
'    '    Main.ProgressBar.Value = ev.ProgressPercentage
'    '    'Update 
'    '    'If Do_SetProgressText Then SetProgressText.Run(SetProgressText_text, SetProgressText_level)
'    '    'If Do_LogEvent Then LogEvent(LogEvent_EventName, LogEvent_lines)
'    '    'If Do_LogAppendText Then LogAppendText(LogAppendText_text, LogAppendText_lines)
'    '    ''Reset flags to false
'    '    'Do_SetProgressText = False
'    '    'Do_LogEvent = False
'    '    'Do_LogAppendText = False
'    'End Sub
'    Public Sub adbDetect(adbStopOnError As Boolean, adbItems As String()) 'adbDetect_start(sender As Object, e As DoWorkEventArgs)

'        'If Not Main.adb_Initiated Then Exit Sub '

'        ''''''''DEBUG''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'        'DetectDevices.Run()
'        'Exit Sub
'        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

'        Dim lines As Integer
'        If My.Settings.VerboseLogging Then lines = 1 Else lines = 0
'        'Main.ShowLog_ErrorBlink_Timer.Enabled = False
'        If Not Directory.Exists(GA_tools) Then
'            GA_PrepareAppdata.Run()
'        End If


'        'Do_SetProgressText = True
'        'SetProgressText_text = "Starting Detection..."
'        'SetProgressText_level = 0
'        'Do_LogEvent = True
'        'LogEvent_EventName = "Auto Detect Device Information"
'        'LogEvent_lines = 2
'        'Do_LogAppendText = True
'        'LogAppendText_text = " ⚠  You can manually set all of the paremeters if you think the auto system is wrong."
'        'LogAppendText_lines = 1
'        'adbWorker.ReportProgress(0)
'        Main.ProgressBar.Value = 0
'        GA_SetProgressText.Run("Starting Detection...", -1)
'        LogEvent("Auto Detect Device Information", 2)
'        LogAppendText(" >  Please select the real info if you have modded your system info.", 1)

'        'Start adb if not running
'        Main.ProgressBar.Value = 5
'        'Dim processes() As Process
'        'processes = Process.GetProcessesByName("adb")
'        'If processes.Count = 0 Then
'        GA_SetProgressText.Run("Launching adb server... Please be patient.", -1)

'        adbDo("devices")
'        'End If

'RetryDetect:

'        If adbItems.Contains("count") Or adbItems.Contains("all") Then

'            ErrorCodeTrack("Da-L0")
'            Try 'Devices Count
'                ShowDeviceCountChanged = False
'                GA_SetProgressText.Run("Detecting Devices count...", -1)

'                adbDo("devices")
'                'Do_SetProgressText = True
'                'SetProgressText_text = "Saving aquired information..."
'                'SetProgressText_level = 0
'                'adbWorker.ReportProgress(10)
'                Main.ProgressBar.Value = 10
'                GA_SetProgressText.Run("Saving aquired information...", -1)

'                DeviceInfoSave("", Text.RegularExpressions.Regex.Split(adb_output, "device").Length - 2, "", 0, "", "", "")
'                'adbWorker.ReportProgress(20)
'                Main.ProgressBar.Value = 20

'                If My.Settings.adbDeviceCount <> 0 Then
'                    If My.Settings.VerboseLogging Then lines = 2 Else lines = 1
'                    'Do_LogAppendText = True
'                    'LogAppendText_text = "~ Connected devices: " & My.Settings.DevicesCount.ToString
'                    'LogAppendText_lines = lines
'                    'adbWorker.ReportProgress(Main.ProgressBar.Value)
'                    LogAppendText("~ Connected devices: " & My.Settings.adbDeviceCount.ToString, lines)
'                    Main.DeviceCount.Value = My.Settings.adbDeviceCount
'                End If
'                'Do_SetProgressText = True
'                'SetProgressText_text = "Device count aquired."
'                'SetProgressText_level = 0
'                GA_SetProgressText.Run("Device count aquired.", -1)
'                'adbWorker.ReportProgress(30)
'                Main.ProgressBar.Value = 30
'                ShowDeviceCountChanged = True

'                adbStopOnError = False
'            Catch ex As Exception
'                DoMsg(1, ex.ToString, 2)
'                ShowDeviceCountChanged = True

'                If adbStopOnError Then GoTo EndDetect
'            End Try

'            '//TODO maybe: count Is being set without setting settings.count
'            Select Case Main.DeviceCount.Value
'                Case 0
'                    'PleaseWait.Close()
'                    GA_PleaseWait.Run(False)
'                    Dim TroubleshootConnection As String = vbCrLf & "-Did you install the USB drivers for your device?" & vbCrLf & "-Did you turn on USB Debugging?" & vbCrLf & "-Did you allow this PC to access your device?" & vbCrLf & "-Did you unlock the lockscreen?" & vbCrLf & "-Did you try another USB cable / port?" & vbCrLf & "Make sure to properly connect your device and try again..." & vbCrLf & " >  Process aborted."

'                    'MessageBox.Show("Did you install the USB drivers for your device?" & vbCrLf & "You can start the installation of Google universal USB Drivers right now if you wish.")

'                    If Text.RegularExpressions.Regex.Split(adb_output, "offline").Length - 1 >= 1 Then
'                        ErrorCodeTrack("Da-L00") 'Device adb - Level 0 0 (Device count, status) ''error info: Device count fail, Device is offline
'                        DoMsg(1, "Device is offline." & TroubleshootConnection, 2)
'                        Exit Sub
'                    End If
'                    'Main.ShowLog_InfoBlink_Timer.Enabled = True
'                    ErrorCodeTrack("Da-L01") 'Device adb - Level 0 1 (Device count, connection) ''error info: Device count fail, No device
'                    DoMsg(0, "There are no devices connected." & TroubleshootConnection, 2)
'                    Exit Sub

'                Case > 1
'                    'Main.ShowLog_InfoBlink_Timer.Enabled = True
'                    ErrorCodeTrack("Da-L00e") 'Device adb - Level 0 1e (Device count, extra connections) ''error info: Device count success, more than 1 device is connected
'                    DoMsg(0, "Please Connect 1 device only." & vbCrLf & " >  Process aborted.", 2)
'                    Exit Sub
'            End Select

'        End If 'Items.Contains("count")
'        If adbItems.Contains("serialno") Or adbItems.Contains("all") Then
'            Try 'Serial number 
'                ErrorCodeTrack("Da-L1") 'Device adb - Level 1 0 (Device Serial Number) ''error info: Device count fail, Device is offline
'                GA_PleaseWait.Run(True)
'                GA_SetProgressText.Run("Detecting device serial number.", -1)
'                adbDo("get-serialno")
'                DeviceInfoSave(adb_output, -1, "", 0, "", "", "")
'                LogAppendText("~ Serial #: " & My.Settings.DeviceSerial, 1)
'                GA_PleaseWait.Run(False)

'            Catch ex As Exception
'                GA_PleaseWait.Run(False)
'                'Main.ShowLog_InfoBlink_Timer.Enabled = True
'                ErrorCodeTrack("Da-L1") 'Device adb - Level 1 0 (Device Serial Number) ''error info: Device count fail, Device is offline
'                DoMsg(0, "Please Connect 1 device only." & vbCrLf & "Process aborted.", 2)
'                Exit Sub
'            End Try
'        End If

'        If adbItems.Contains("manufacturer") Or adbItems.Contains("all") Then

'            Try 'Manufacturer
'                ErrorCodeTrack("Da-L20") 'Device adb - Level 2 0 (Device info, Manufacturer) ''error info: Error getting Manufacturer (check e string for details) 
'                Main.ProgressBar.Value = 35
'                GA_SetProgressText.Run("Checking manufacturer...", -1)
'                adbDo("shell getprop ro.product.manufacturer")
'                GA_SetProgressText.Run("Saving aquired information...", -1)
'                If adb_output.Length = 0 Then ''Error detected. fixing automatically... 
'                    LogAppendText(" >  Manually set device count problem detected. Restarting with 0 count", 2)
'                    Dim tempString As String = Main.log.Text
'                    Main.DeviceCount.Value = 0
'                    Main.log.Text = tempString
'                    GoTo RetryDetect
'                End If
'                FixManufacturerString(adb_output)
'                DeviceInfoSave("", -1, ManufacturerString_Fixed, 0, "", "", "")
'                If My.Settings.VerboseLogging Then lines = 1 Else lines = 0
'                LogAppendText("~ Manufacturer: " & ManufacturerString_Fixed, lines)
'                Main.Manufacturer_ComboBox.Text = ManufacturerString_Fixed
'                Main.ProgressBar.Value = 50
'                GA_SetProgressText.Run("Manufacturer information aquired.", -1)

'                adbStopOnError = False
'            Catch ex As Exception
'                DoMsg(1, ex.ToString, 2)
'                If adbStopOnError Then GoTo EndDetect
'            End Try

'        End If 'Items.Contains("manufacturer")


'        If adbItems.Contains("version") Or adbItems.Contains("all") Then

'            If My.Settings.VerboseLogging Then lines = 1 Else lines = 0
'            Try 'Android Version
'                ErrorCodeTrack("Da-L21") 'Device adb - Level 2 1 (Device info, Android Version) ''extra: Error getting Android Version (check e string for details)
'                GA_SetProgressText.Run("Checking android sdk & version...", -1)
'                'adbWorker.ReportProgress(55)
'                Main.ProgressBar.Value = 55
'                GA_SetProgressText.Run("Checking sdk version...", -1)
'                adbDo("shell getprop ro.build.version.sdk")

'                GA_SetProgressText.Run("Saving aquired information...", -1)
'                DeviceInfoSave("", -1, "", Convert.ToInt32(adb_output), "", "", "")
'                LogAppendText("~ Android API Level: " & adb_output, lines)
'                'adbWorker.ReportProgress(60)
'                Main.ProgressBar.Value = 60

'                GA_SetProgressText.Run("Determining android version from sdk...", -1)
'                DetermineVersionFromSDK(Convert.ToInt32(adb_output), True)
'                'adbWorker.ReportProgress(80)
'                Main.ProgressBar.Value = 80

'                LogAppendText("~ Android Version: " & AndroidVersion, lines)
'                DetermineVersionFromSDK(Convert.ToInt32(adb_output), False)
'                'adbWorker.ReportProgress(100)
'                Main.ProgressBar.Value = 100
'                GA_SetProgressText.Run("Android sdk & version aquired.", -1)

'                adbStopOnError = False
'            Catch ex As Exception
'                DoMsg(1, ex.ToString, 2)
'                If adbStopOnError Then GoTo EndDetect
'            End Try

'        End If 'Items.Contains("version")

'        If Main.ShowLog_ErrorBlink_Timer.Enabled = False Then GA_SetProgressText.Run("Device information aquired.", -1)

'EndDetect:
'        GA_PleaseWait.Run(False)
'        adbStopOnError = False
'    End Sub

'    Public Sub DeviceInfoSave(DeviceSerial As String, DevicesCount As Integer, DeviceManufacturer As String, DeviceAPILevel As Integer, DeviceUnlockedBootloader As String, DeviceCustomRecovery As String, DeviceCustomRom As String)
'        If DeviceSerial.Length > 0 Then
'            My.Settings.DeviceSerial = DeviceSerial
'        End If
'        If Not DevicesCount = -1 Then
'            My.Settings.adbDeviceCount = DevicesCount
'        End If
'        If DeviceManufacturer.Length > 0 Then
'            My.Settings.DeviceManufacturer = DeviceManufacturer
'        End If
'        If DeviceAPILevel > 0 Then
'            My.Settings.DeviceAPILevel = DeviceAPILevel
'        End If
'        If DeviceUnlockedBootloader.Length > 0 Then
'            My.Settings.DeviceUnlockedBootloader = DeviceUnlockedBootloader
'        End If
'        If DeviceUnlockedBootloader.Length > 0 Then
'            My.Settings.DeviceCustomRecovery = DeviceCustomRecovery
'        End If
'        If DeviceUnlockedBootloader.Length > 0 Then
'            My.Settings.DeviceCustomROM = DeviceCustomRom
'        End If
'        My.Settings.Save()
'    End Sub

'    Private ManufacturerString_Fixed As String
'    Public Sub FixManufacturerString(ManufacturerString As String)
'        ManufacturerString = ManufacturerString.Substring(0, 1).ToUpper() & ManufacturerString.Substring(1).ToLower()
'        If ManufacturerString = "Lge" Then
'            ManufacturerString = "LG"
'        End If
'        ManufacturerString_Fixed = ManufacturerString
'    End Sub


'    Private AndroidVersion As String
'    Private AnyStringArray As String()
'    Private ApiToVer As New Dictionary(Of Integer, String())
'    ' Public Shared AndroidVerToComboBox As New Dictionary(Of Integer, String)
'    Public Sub PrepareAndroidDictionary()
'        ApiToVer.Clear()
'        'Dim AndroidVer As Object = My.Resources.esourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, False, True)

'        Dim K_ = "KitKat 4.4 (And Below)"
'        Dim L_ = "Lollipop 5.x"
'        Dim M_ = "Marshmallow 6.x"
'        Dim N_ = "Nougat 7.x"
'        Dim O_ = "Oreo 8.x"
'        Dim P_ = "Pie 9.x"
'        Dim Q_ = "Android 10 Q"
'        Dim R_ = "Android 11 R (And Above)"
'        With ApiToVer
'            .Add(1, {"1.0", K_})
'            .Add(2, {"1.1", K_})
'            .Add(3, {"Cupcake 1.5", K_})
'            .Add(4, {"Donut 1.6", K_})
'            .Add(5, {"Eclair 2.0", K_})
'            .Add(6, {"Eclair 2.0", K_})
'            .Add(7, {"Eclair 2.1", K_})
'            .Add(8, {"Froyo 2.2", K_})
'            .Add(9, {"Gingerbread 2.3", K_})
'            .Add(10, {"Gingerbread 2.3", K_})
'            .Add(11, {"Honeycomb 3.0", K_})
'            .Add(12, {"Honeycomb 3.1", K_})
'            .Add(13, {"Honeycomb 3.2", K_})
'            .Add(14, {"ICS 4.0", K_})
'            .Add(15, {"ICS 4.0", K_})
'            .Add(16, {"Jelly Bean 4.1", K_})
'            .Add(17, {"Jelly Bean 4.2", K_})
'            .Add(18, {"Jelly Bean 4.3", K_})
'            .Add(19, {"KitKat 4.4", K_})
'            .Add(21, {"Lollipop 5.0", L_})
'            .Add(22, {"Lollipop 5.1", L_})
'            .Add(23, {"Marshmallow 6.0", M_})
'            .Add(24, {"Nougat 7.0", N_})
'            .Add(25, {"Nougat 7.1", N_})
'            .Add(26, {"Oreo 8.0", O_})
'            .Add(27, {"Oreo 8.1", O_})
'            .Add(28, {P_, P_})
'            .Add(29, {Q_, Q_})
'            .Add(30, {R_, R_})
'        End With
'    End Sub

'    Public Sub PrepareDeviceInfo(APIlevel As Integer, Manufacturer As Boolean, Count As Boolean)
'        If My.Settings.DeviceManufacturer.Length > 0 Then
'            GA_SetProgressText.Run("Detected previous device info.", 0)
'        Else GA_SetProgressText.Run("No previous device info. Setting default values.", 0)
'        End If
'        'If Not APIlevel = 0 Then
'        DetermineVersionFromSDK(APIlevel, False)

'        If Manufacturer And My.Settings.DeviceManufacturer.Length > 0 Then
'            FixManufacturerString(My.Settings.DeviceManufacturer)
'            Main.Manufacturer_ComboBox.Text = ManufacturerString_Fixed
'        End If
'        'If AndroidVersion And My.Settings.DeviceAPILevel > 0 Then
'        '    Main.AndroidVersion_ComboBox.Text = 
'        'End If
'        If Count And My.Settings.adbDeviceCount > 0 Then
'            Main.DeviceCount.Value = My.Settings.adbDeviceCount
'        End If
'    End Sub

'    Public Sub DetermineVersionFromSDK(APIlevel As Integer, GetMain As Boolean)
'        Dim APINull As Boolean = False
'        If ApiToVer.Count = 0 Then PrepareAndroidDictionary()

'        If GetMain Then
'            GA_SetProgressText.Run("Converting api level to version string...", 0)
'            ApiToVer.TryGetValue(APIlevel, AnyStringArray)
'            GA_SetProgressText.Run("Setting api version string...", 0)
'            AndroidVersion = AnyStringArray(0)
'        Else
'            If APIlevel = 0 And My.Settings.DeviceAPILevel > 0 Then
'                APIlevel = My.Settings.DeviceAPILevel
'            ElseIf My.Settings.DeviceAPILevel = 0 Then
'                AndroidVersion = "Select Android Version"
'                APINull = True
'            End If
'            If Not APINull Then
'                ApiToVer.TryGetValue(APIlevel, AnyStringArray)
'                AndroidVersion = AnyStringArray(1)
'            End If
'            Main.AndroidVersion_ComboBox.Text = AndroidVersion
'        End If
'    End Sub

'End Module
