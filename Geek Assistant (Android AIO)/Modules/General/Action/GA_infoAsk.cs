
using GeekAssistant.Forms;
using System;
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
                           Image IconLight= null,
                           Image IconDark = null,
                           Color ? TextColorLight = null,
                           Color ? TextColorDark = null) {
        common.ErrorInfo.code = $"{txt.GA_GetErrorInitials()}-null-"; 
        try {
            if (string.IsNullOrEmpty(Title))
                common.ErrorInfo.code += "t"; 
            if (string.IsNullOrEmpty(body))
                common.ErrorInfo.code += "b"; 
            if (string.IsNullOrEmpty(YesButton))
                common.ErrorInfo.code += "y"; 
            if (string.IsNullOrEmpty(NoButton))
                common.ErrorInfo.code += "n";
            if (common.ErrorInfo.code != $"{txt.GA_GetErrorInitials()}-null-") throw new ArgumentException();
        } catch (ArgumentException ex) {
            GA_Msg.DoMsg(10, "Something went wrong\nWe encountered a problem while trying to ask you something...",2,ex.ToString());
        } 
        if (IconDark != null) common.Info.info_IconDark = IconDark;
        if (IconLight != null) common.Info.info_IconLight = IconLight;
        if (TextColorLight != Color.Empty) common.Info.info_TextColorLight = TextColorLight ?? Color.Empty;
        if (TextColorDark != Color.Empty) common.Info.info_TextColorDark = TextColorDark ?? Color.Empty;


        infoAnswer = false;
        infoButtonText = (YesButton, NoButton);
        common.S.info_MsgLevel = 2; // Question
        common.S.info_MsgTitle = Title;
        common.S.info_Msg = body;
        common.Info.ShowDialog();
        return infoAnswer;
    } 
}