Imports System.IO

Module GA_PrepareAppdata
    Public Sub Run()
        If Not Directory.Exists(GA) Then _
            Directory.CreateDirectory(GA)
        If Not Directory.Exists(GA_tools) Then _
            Directory.CreateDirectory(GA_tools)
        If Not File.Exists($"{GA_tools}\adb.exe") Then _
            File.WriteAllBytes(GA_tools & "\adb.exe", My.Resources.adb)
        'If Not File.Exists(GA_tools & "\adbUniversalDrivers-byGoogle.exe") Then File.WriteAllBytes(GA_tools & "\adbUniversalDrivers-byGoogle.exe", My.Resources.ces.adbUniversalDrivers_byGoogle)
        If Not File.Exists($"{GA_tools}\AdbWinApi.dll") Then _
            File.WriteAllBytes(GA_tools & "\AdbWinApi.dll", My.Resources.AdbWinApi)
        If Not File.Exists($"{GA_tools}\AdbWinUsbApi.dll") Then _
            File.WriteAllBytes(GA_tools & "\AdbWinUsbApi.dll", My.Resources.AdbWinUsbApi)
        If Not File.Exists($"{GA_tools}\fastboot.exe") Then _
            File.WriteAllBytes(GA_tools & "\fastboot.exe", My.Resources.fastboot)
    End Sub
End Module
