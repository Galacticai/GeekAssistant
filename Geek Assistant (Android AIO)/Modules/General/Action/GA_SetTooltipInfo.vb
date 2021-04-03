Module GA_SetTooltipInfo

    Public Sub SetToolTipInfo(ByRef ToolTipName As ToolTip, ByRef obj As Object, ToolTipTitle As String, ToolTipText As String)
        If My.Settings.ShowToolTips Then
            If Not ToolTipTitle = ToolTipName.ToolTipTitle Then ToolTipName.ToolTipTitle = ToolTipTitle
            If Not ToolTipText = ToolTipName.GetToolTip(obj) Then ToolTipName.SetToolTip(obj, ToolTipText)
        Else
            ToolTipName.SetToolTip(obj, Nothing)
        End If
    End Sub
End Module
