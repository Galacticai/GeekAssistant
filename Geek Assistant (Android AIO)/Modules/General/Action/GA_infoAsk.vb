Module GA_infoAsk
    Public infoAnswer As Boolean = False
    Public infoButtonText As (LeftButton As String, RightButton As String)
    ''' <summary>
    ''' Uses My.Forms.info to ask the user something + allows custom buttons text
    ''' </summary>
    ''' <param name="Title">Title of the question</param>
    ''' <param name="body">More text to view below the title</param>
    ''' <param name="YesButton">Text of the Left YesButton</param>
    ''' <param name="NoButton">Text of the Right NoButton</param> 
    ''' <returns>True if YesButton was clicked or False if NoButton was clicked</returns>
    Public Function Run(Title As String, body As String, YesButton As String, NoButton As String,
                        Optional IconLight As Image = Nothing,
                        Optional IconDark As Image = Nothing,
                        Optional TextColorLight As Object = Nothing,
                        Optional TextColorDark As Object = Nothing) As Boolean
        If String.IsNullOrEmpty(NoButton) Then Return False
        If String.IsNullOrEmpty(YesButton) Then Return False
        If String.IsNullOrEmpty(body) Then Return False
        If String.IsNullOrEmpty(Title) Then Return False
        If IconDark IsNot Nothing Then info.info_IconDark = IconDark
        If IconLight IsNot Nothing Then info.info_IconLight = IconLight
        If TextColorLight IsNot Nothing Then info.info_TextColorLight = TextColorLight
        If TextColorDark IsNot Nothing Then info.info_TextColorDark = TextColorDark

        infoAnswer = False
        infoButtonText = (YesButton, NoButton)
        My.Settings.info_MsgLevel = 2 'Question
        My.Settings.info_MsgTitle = Title
        My.Settings.info_Msg = body
        info.ShowDialog()
        Return infoAnswer
    End Function
End Module
