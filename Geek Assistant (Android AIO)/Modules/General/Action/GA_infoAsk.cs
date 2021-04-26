
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
        c.ErrorInfo.code = $"{txt.GA_GetErrorInitials()}-null-"; 
        try {
            if (string.IsNullOrEmpty(Title))
                c.ErrorInfo.code += "t"; 
            if (string.IsNullOrEmpty(body))
                c.ErrorInfo.code += "b"; 
            if (string.IsNullOrEmpty(YesButton))
                c.ErrorInfo.code += "y"; 
            if (string.IsNullOrEmpty(NoButton))
                c.ErrorInfo.code += "n";
            if (c.ErrorInfo.code != $"{txt.GA_GetErrorInitials()}-null-") throw new ArgumentException();
        } catch (ArgumentException ex) {
            GA_Msg.DoMsg(10, "Something went wrong\nWe encountered a problem while trying to ask you something...",2,ex.ToString());
        } 
        if (IconDark != null) c.Info().info_IconDark = IconDark;
        if (IconLight != null) c.Info().info_IconLight = IconLight;
        if (TextColorLight != Color.Empty) c.Info().info_TextColorLight = TextColorLight ?? Color.Empty;
        if (TextColorDark != Color.Empty) c.Info().info_TextColorDark = TextColorDark ?? Color.Empty;


        infoAnswer = false;
        infoButtonText = (YesButton, NoButton);
        c.S.info_MsgLevel = 2; // Question
        c.S.info_MsgTitle = Title;
        c.S.info_Msg = body;
        c.Info().ShowDialog();
        return infoAnswer;
    } 
}