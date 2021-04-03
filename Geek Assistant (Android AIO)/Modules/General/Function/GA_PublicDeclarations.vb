Imports System.IO

Module GA_PublicDeclarations
    Public ReadOnly Version As Version = My.Application.Info.Version
    Public ReadOnly GA As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Geek Assistant (Android AIO)")
    Public ReadOnly GA_tools As String = Path.Combine(GA, "tools")
    Public ReadOnly GA_logs As String = Path.Combine(GA, "log")
    Public ErrorInfo As (lvl As Integer, msg As String)
    Public Working As Boolean = False
End Module
