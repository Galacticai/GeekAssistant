Module GA_PleaseWait
    Public Sub Run(Enable As Boolean)
        If Enable Then
            PleaseWait.Show()
        Else
            PleaseWait.UserClosing = False
            PleaseWait.Close()
        End If
    End Sub
End Module
