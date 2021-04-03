Imports System.IO

Module GA_Reset

    Public Sub Run(Data As Boolean, logs As Boolean)
        ErrorCodeTrack("")
        LogEvent("Reset Geek Assistant", 2)
        If Not GA_infoAsk.Run("Reset Geek Assistant",
                          $"Are you sure you want to {GA_Settings.willClear}?",
                          "Continue", "Cancel") Then
            LogAppendText("Reset Geek Assistant Cancelled.", 1)
            Exit Sub
        End If

        LogAppendText($"Resetting Geek Assistant... {vbCrLf}({GA_Settings.willClear})", 1)
        Try
            Dim notify As String = "Process Complete. "
            If Data Then
                ErrorCodeTrack("GAr-S") 'GA reset - Settings
                My.Settings.Reset()
                My.Settings.Save()
                notify &= $"{vbCrLf}Do you want to relaunch Geek Assistant?{vbCrLf}{vbCrLf}{vbCrLf}" &
                           "⚠ Warning: Relaunching will recreate some files needed to run Geek Assistant."
            End If

            If logs Then
                ErrorCodeTrack("GAr-L") 'GA reset - Logs
                If Directory.Exists(GA_logs) Then
                    For Each foundName As String In My.Computer.FileSystem.GetFiles(GA_logs, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                        If File.Exists($"{foundName}\*.*") Then
                            My.Computer.FileSystem.DeleteFile(foundName, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
                        End If
                    Next
                    My.Computer.FileSystem.DeleteDirectory(GA_logs, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
                End If
            End If

            LogAppendText(notify, 1)
            If Data Then
                My.Settings.VerboseLoggingPrompt = False 'disable to avoid asking on exit
                If GA_infoAsk.Run("Reset Geek Assistant", notify, "Relaunch", "Exit") Then
                    My.Settings.VerboseLoggingPrompt = True ' enable again (true is default)
                    Application.Restart()
                Else
                    My.Settings.VerboseLoggingPrompt = True ' enable again (true is default)
                    Application.Exit()
                End If
            Else
                MessageBox.Show(notify, "Reset Geek Assistant", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Catch e As Exception
            DoMsg(10, "Error while resetting.", 3, e.ToString)
        End Try
    End Sub

End Module
