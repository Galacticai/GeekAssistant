Public Class Preparing

    'Private Sub Preparing_Load(sender As Object, e As EventArgs) Handles MyBase.

    'End Sub
    Private WithEvents CheckADBProcess_Timer As New Timer With {.Interval = 100}
    Private Sub Preparing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GA_SetTheme.Run(Name, True)
        Preparing_Label.Text = txt_RandomWorkingText()
        CheckADBProcess_Timer.Enabled = True
    End Sub
    Private Sub CheckADBProcess_Timer_Tick() Handles CheckADBProcess_Timer.Tick
        If Process.GetProcessesByName("adb").Count > 0 Then
            CheckADBProcess_Timer.Enabled = False
            Main.Show()
            Close()
        End If
    End Sub
End Class