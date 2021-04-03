Module GA_HideAllForms

    Private HiddenFormsList As New List(Of Form)
    ''' <summary>
    ''' Hides/Shows All forms currently opened by Geek Assistant
    ''' </summary>
    ''' <param name="Hide">Set if it should hide or not (show)</param>
    ''' <param name="FormToFront">Bring this form to front when done</param>
    Public Sub Run(Hide As Boolean, FormToFront As Form)
        'SET ERROR CODE WHEN CALLING, DO NOT SET HERE
        If Hide Then
            HiddenFormsList.Clear() 'Clear forms list
            For Each formname As Form In Application.OpenForms 'Save all forms to HiddenFormsList then hide
                HiddenFormsList.Add(formname)
                formname.Hide()
            Next
        Else
            If HiddenFormsList.Count = 0 Then 'failsafe
                DoMsg(10, "Error while reviving hidden windows.", 2)
                Exit Sub
            End If
            For Each formname As Form In HiddenFormsList 'Show all forms saved in list
                formname.Show()
            Next
            If FormToFront IsNot Nothing Then _ 'Failsafe
                FormToFront.BringToFront()
        End If
    End Sub
End Module
