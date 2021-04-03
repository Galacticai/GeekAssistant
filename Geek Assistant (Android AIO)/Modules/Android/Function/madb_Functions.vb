Imports Managed

Module madb_Functions

#Region "madb assited"

    ''' <summary>
    ''' Start adb server at $"{GA_tools}\adb.exe" or skip if already running
    ''' </summary>
    Public Sub madbStart()
        'Dim madb = 
        Adb.AndroidDebugBridge.CreateBridge($"{GA_tools}\adb.exe", False)
        'madb.Start()
    End Sub

    ''' <summary>
    ''' Terminate adb server 
    ''' </summary>
    Public Sub madbStop()
        Adb.AndroidDebugBridge.Terminate()
    End Sub

    ''' <summary>
    ''' Count how many devices are currently connected
    ''' </summary>
    ''' <returns>Get the count of madb_DeviceList() As Integer ( /List(Of Adb.Device)/ .Count)</returns>
    Public Function madb_GetDeviceCount() As Integer
        madbStart() 'Failsafe
        Return madb_GetListOfDevice.Count
    End Function

    ''' <summary>
    ''' Get a list of the devices connected as List(Of Adb.Device)
    ''' </summary>
    ''' <returns>Get a list of the devices connected as List(Of Adb.Device)</returns>
    Public Function madb_GetListOfDevice() As List(Of Adb.Device)
        madbStart() 'Failsafe
        Dim DeviceList As List(Of Adb.Device) = Adb.AdbHelper.Instance.GetDevices(Adb.AndroidDebugBridge.SocketAddress)
        Return DeviceList
    End Function

    ''' <summary>
    ''' Check if any connected device serial# matches the input serial# and return as Adb.Device
    ''' </summary>
    ''' <param name="serial">Serial number to check against the connected devices</param>
    ''' <returns>Get the Adb.Device that matches the serial number</returns>
    Public Function madb_GetDeviceFromSerial(serial As String) As Adb.Device
        madbStart() 'Failsafe
        Dim devices As List(Of Adb.Device) = Adb.AdbHelper.Instance.GetDevices(Adb.AndroidDebugBridge.SocketAddress)
        For Each dev As Adb.Device In devices
            If dev.SerialNumber = serial Then Return dev
        Next
        Return Nothing
    End Function
    ''' <summary>
    ''' Get the state of the first device connected
    ''' </summary>
    ''' <returns></returns>
    Public Function madb_GetDeviceState() As Integer
        madbStart() 'Failsafe
        Return madb_GetListOfDevice(0).State
    End Function

#End Region

End Module
