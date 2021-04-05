Module FeatureUnavailable_MessageBox
    Public Sub Run(title As String)
        Dim state As String = "cooking progress"
        Select Case My.Application.Info.Version.Revision
            Case 1
                state = "beta phase"
            Case 2
                state = "testing phase"
            Case 3
                state = "development phase"
        End Select
        DoMsg(0, $"{title}{vbCrLf}Geek Assistant is still in {state}... {title} might be added in future updates. Stay tuned!")
    End Sub
End Module
