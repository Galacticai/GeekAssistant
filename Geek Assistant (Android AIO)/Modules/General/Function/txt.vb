Module txt
    ''' <summary>
    ''' Remove everything except the first line of a string
    ''' </summary>
    ''' <param name="txt">Input string</param>
    ''' <returns>[[0-----------]]{vbcrlf}</returns>
    Public Function txt_GetFirstLine(txt As String) As String
        'Foolproof
        If String.IsNullOrEmpty(txt) Then Return Nothing

        'Failsafe: return if only 1 line
        If txt.IndexOf(Environment.NewLine) < 1 Then Return txt

        'Do
        Return txt.Substring(0, txt.IndexOf(Environment.NewLine))

    End Function

    ''' <summary>
    ''' Remove the first line of a string
    ''' </summary>
    ''' <param name="txt">Input</param>
    ''' <returns>0---------{vbcrlf}[[---------- ...]]</returns>
    Public Function txt_CutFirstLine(txt As String) As String
        'Foolproof
        If String.IsNullOrEmpty(txt) Then Return Nothing

        'Failsafe: return if only 1 line
        If txt.IndexOf(Environment.NewLine) < 1 Then Return txt

        'Do
        '' Text Example>>(\n)blabla bla<<
        Return txt.Substring(txt.IndexOf(Environment.NewLine) + 1)

    End Function

    ''' <summary>
    ''' Remove the first word of a string
    ''' </summary>
    ''' <param name="txt">Input</param>
    ''' <returns>0---- [[--- ------ --- ...]]</returns>
    Public Function txt_CutFirstWord(txt As String) As String
        'Foolproof
        If String.IsNullOrEmpty(txt) Then Return Nothing
        'Failsafe: return if no spaces (1 word only)
        If txt.IndexOf(" ") < 1 Then Return txt
        'Remove double space if present
        Dim index As Integer = 1
        If GetChar(txt, txt.IndexOf(" ")) = GetChar(txt, txt.IndexOf(" ") + 1) Then index += 1
        'Do
        Return txt.Substring(txt.IndexOf(" ") + index, txt.Length)
    End Function

    ''' <param name="bool">Input</param>
    ''' <returns>"Yes" if True, "No" if False</returns>
    Public Function txt_ConvertBooleanYesNo(bool As Boolean) As String
        If bool Then Return "Yes" Else Return "No"
    End Function


    ''' <returns>Random string from a preset String() (open to edit preset array)</returns>
    Public Function txt_RandomWorkingText() As String
        Dim returnArr As String() = {
            "Hold on... We're doing magic!",
            "Stuff... Please be patient...",
            "Wait a second... Magic ongoing...",
            "Things are happening... Please wait.",
            "Things are happening... Please be patient",
            "Working... Please be patient.",
            "Progressing... Wait a moment.",
            "Hold on... Things are happening...",
            "Preparing... It shall take seconds.",
            "Sit tight! This won't take long.",
            "Magic rays everywhere! Please wait.",
            "Magic rays everywhere! Please be patient.",
            "Something is happening... Please be patient.",
            "Progressing, we will finish soon",
            "Want a snack? Finishing soon..."
        }
        Return math_RandomObjectFromArr(returnArr)
    End Function
End Module
