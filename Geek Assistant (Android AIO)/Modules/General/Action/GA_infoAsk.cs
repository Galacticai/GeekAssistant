
using GeekAssistant.Forms;
using System.Drawing;

internal static partial class GA_infoAsk {
    public static bool infoAnswer = false;
    public static (string LeftButton, string RightButton) infoButtonText;
    /// <summary>
    /// Uses My.Forms.info to ask the user something + allows custom buttons text
    /// </summary>
    /// <param name="Title">Title of the question</param>
    /// <param name="body">More text to view below the title</param>
    /// <param name="YesButton">Text of the Left YesButton</param>
    /// <param name="NoButton">Text of the Right NoButton</param>
    /// <returns>True if YesButton was clicked or False if NoButton was clicked</returns>
    public static bool Run(string Title, 
                           string body,
                           string YesButton, string NoButton, 
                           Image IconLight = default, 
                           Image IconDark = default, 
                           object TextColorLight = null, 
                           object TextColorDark = null) {
        // #Region "failsafe"
        // If String.IsNullOrEmpty(NoButton) Then Return False
        // If String.IsNullOrEmpty(YesButton) Then Return False
        // If String.IsNullOrEmpty(body) Then Return False
        // If String.IsNullOrEmpty(Title) Then Return False
        // If IconDark IsNot Nothing Then
        Info.info_IconDark = IconDark;
        // If IconLight IsNot Nothing Then
        Info.info_IconLight = IconLight;
        // If TextColorLight IsNot Nothing Then
        Info.info_TextColorLight = TextColorLight;
        // If TextColorDark IsNot Nothing Then
        Info.info_TextColorDark = TextColorDark;
        // #End Region

        infoAnswer = false;
        infoButtonText = (YesButton, NoButton);
        common.S.info_MsgLevel = 2; // Question
        common.S.info_MsgTitle = Title;
        common.S.info_Msg = body;
        Info.ShowDialog();
        return infoAnswer;
    }
}