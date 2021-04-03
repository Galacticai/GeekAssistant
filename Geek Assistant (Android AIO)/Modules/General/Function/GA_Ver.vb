Module GA_Ver
    'Dim Gaver As String
    Public Function Run(level As String) As String
        Dim cDateByNHKomaiha As String = "©2021 By NHKomaiha"
        Dim result As String = $"v{Version.Major}.{Version.Minor}"

        Select Case Version.Revision
            'Case 0
            '    GAver &= Nothing '(Normal)
            Case 1
                result &= " #Beta"
            Case 2
                result &= " #Test"
            Case 3
                result &= " #Dev"
        End Select
        Select Case level
            Case "log"
                result = $"Geek Assistant {result} {cDateByNHKomaiha}."
            Case "Main"
                result &= $" {cDateByNHKomaiha}."
            Case "MainTitle"
                result = $"Geek Assistant — {result}"
            Case "ToU"
                result = $"{My.Application.Info.Copyright}. {result}"
        End Select

        Return result
    End Function
End Module
