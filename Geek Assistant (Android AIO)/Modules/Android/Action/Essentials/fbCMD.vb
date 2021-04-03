Module fbCMD
    Private ReadOnly fb_process As New Process
    Public fbOutput As String
    ''' <summary>
    ''' Sends a command to $"{GA_tools}\fastboot.exe" and waits for process output 
    ''' Do not include "fastboot" in the arguments parameter
    ''' </summary>
    ''' <param name="arguments">fastboot command arguments</param>
    ''' <returns>Output of a fastboot command As String + fbOutput public string (to avoid repeating command for the same output)</returns>
    Public Function fbDo(arguments As String)
        '>Failsafe - Should never happen
        If arguments.Length = 0 Then
            ErrorCodeTrack(My.Settings.ErrorCode & "-fbDo-null") ' error code (last process) - adbDo - null
            DoMsg(10, "Unable to run the fastboot command.", 2)
        End If

        'kill all fastboot instances before starting a new one
        Dim processes = Process.GetProcessesByName("fastboot")
        If processes.Count > 0 Then
            For Each p As Process In processes
                p.Kill()
            Next
        End If

        '<Failsafe
        With fb_process.StartInfo
            .FileName = $"{GA_tools}\fastboot.exe"
            .Arguments = arguments
            .UseShellExecute = False
            .CreateNoWindow = True
            .RedirectStandardOutput = True
            .RedirectStandardInput = True
            .RedirectStandardError = True
        End With
        'Start
        fb_process.Start()
        fb_process.WaitForExit()
        'Return output
        ''''Return as global string (Use to avoid repeating command for output)
        fbOutput = fb_process.StandardOutput.ReadToEnd
        ''''Return as function (repeat command to return output)
        Return fbOutput
    End Function
End Module