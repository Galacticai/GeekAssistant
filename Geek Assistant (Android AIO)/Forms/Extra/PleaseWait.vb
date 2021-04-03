Class PleaseWait

    Private Sub PleaseWait_MainEnabled(bool As Boolean)
        Main.AutoDetectDeviceInfo_Button.Enabled = bool
        Main.SwitchTheme_Button.Enabled = bool
        Main.Settings_Button.Enabled = bool
        Main.About_Button.Enabled = bool
        Main.Feedback_Button.Enabled = bool
        Main.Donate_Button.Enabled = bool
    End Sub

    Public UserClosing As Boolean = True 'lock to true by default
    Private Sub PleaseWait_FormClosing(ByVal sender As Object, ByVal ev As FormClosingEventArgs) Handles MyBase.FormClosing
        If UserClosing Or ev.CloseReason = CloseReason.WindowsShutDown Then 'Prevent shutdown while working 'Block user closing the form
            ev.Cancel = True
            Exit Sub
        Else
            UserClosing = True 'reset for next use
            Close()
        End If
    End Sub
    Private Sub PleaseWait_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        PleaseWait_MainEnabled(True)
    End Sub

    Private Sub PleaseWait_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GA_SetTheme.Run(Name)
        '24, 97 
        Dim titleHeight = Main.RectangleToScreen(Main.ClientRectangle).Top - Main.Top
        SetBounds(Main.Location.X + 24, Main.Location.Y + 97 + titleHeight, Width, Height)

        PleaseWait_MainEnabled(False)

        PleaseWait_text.Text = txt_RandomWorkingText()
    End Sub

    Private Sub StopProcess_Button_Click(sender As Object, e As EventArgs) Handles StopProcess_Button.Click

        If GA_infoAsk.Run("Stop current process",
                          $"Be careful! This leads to unexpected results.{vbCrLf}" &
                            $"Are you sure you want to stop the running process?{vbCrLf}{vbCrLf}{vbCrLf}" &
                            $"This will also stop all adb and fastboot processes that are currently running!",
                          "Stop Now!", "Return") Then

            Managed.Adb.AndroidDebugBridge.Terminate()
            Dim p_adb_arr = Process.GetProcessesByName("adb")
            If p_adb_arr.Count > 0 Then
                For Each p_adb As Process In p_adb_arr
                    p_adb.Kill()
                Next
            End If

            Dim p_fb_arr = Process.GetProcessesByName("fastboot")
            If p_fb_arr.Count > 0 Then
                For Each p_fb As Process In p_fb_arr
                    p_fb.Kill()
                Next
            End If
        End If
        Close()
    End Sub
End Class