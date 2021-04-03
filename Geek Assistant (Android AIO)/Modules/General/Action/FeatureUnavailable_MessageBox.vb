Module FeatureUnavailable_MessageBox

    Public Sub Run(title As String)
        Dim state As String = "cooking progress"
        Select Case My.Application.Info.Version.Revision
            Case 1
                state = "beta"
            Case 2
                state = "testing stages"
            Case 3
                state = "development"
        End Select
        MessageBox.Show("Geek Assistant is still in " & state & "... " & title & " might be added in future updates. Stay tuned!", title & " - Geek Assistant", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Module
