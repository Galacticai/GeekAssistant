



Module adbCMD
    Private ReadOnly adb_process As New Process
    Public adbOutput As String
    ''' <summary>
    ''' >>>>>>>>>>>>>>>>> UPDATE THIS TO UTILIZE Managed.Adb.Device.ExecuteShellCommand
    ''' 
    ''' Sends a command to $"{GA_tools}\adb.exe" and waits for process output 
    ''' Do not include "adb" in the arguments parameter
    ''' </summary>
    ''' <param name="arguments">adb command arguments</param>
    ''' <returns>Output of a adb command As String + adbOutput public string (to avoid repeating command for the same output)</returns>
    Public Function adbDo(arguments As String) As String
        '>Failsafe - Should never happen
        If arguments.Length = 0 Then
            ErrorCodeTrack($"{My.Settings.ErrorCode}-adbDo-null") ' error code (last process) - adbDo - null
            DoMsg(10, "Unable to run the adb command.", 2)
        End If

        'Inform if not running  
        If Process.GetProcessesByName("adb").Count = 0 Then GA_SetProgressText.Run("Launching Android bridge... Please be patient.", 1)


        '<Failsafe
        With adb_process.StartInfo
            .FileName = $"{GA_tools}\adb.exe"
            .Arguments = arguments
            .UseShellExecute = False
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardInput = True
            .RedirectStandardError = True
        End With
        'Start
        adb_process.Start()
        adb_process.WaitForExit()

        'Return output
        ''''Return as global string (Use to avoid repeating command for output)
        adbOutput = adb_process.StandardOutput.ReadToEnd
        ''''Return as function (repeat command to return output)
        Return adbOutput
    End Function

End Module
