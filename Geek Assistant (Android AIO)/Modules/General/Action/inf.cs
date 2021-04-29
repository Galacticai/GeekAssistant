using GeekAssistant.Forms;
using System.Drawing;
/// <summary>
/// Inform the user using Info() form by pulling info from inf + implicitly or explicity determining the icon/color
/// </summary>
internal static partial class inf { //inform
    #region Info

    public static bool infoAnswer = false;

    public static string currentTitle;
    /// <summary>
    /// <list>
    /// <item>Current Error lvl and msg </item>
    /// <item>Set while a process is running;</item>
    /// <item>When an Exception is thrown the (info) form will use this ErrorInfo</item>
    /// </list>
    /// </summary>
    public static (string code, lvls lvl, string title, string msg, string fullFatalError) detail;
    /// <summary>
    /// YesButton can be null or empty
    /// </summary>
    public static (string YesButton, string NoButton) ButtonText;
    /// <summary>
    /// Use index [0] as light color and [1] as dark color
    /// </summary>
    public static (Image[] icon, Color[] color) theme;
    public enum lvls { Information = -1, Warn = 0, Error = 1, FatalError = 10, Question = 2 }

    #endregion

    /// <summary>
    /// Inform the user using Info() form by pulling info from inf + implicitly or explicity determining the icon/color
    /// </summary>
    /// <param name="lvl">info level as System.Windows.Forms.DialogResult lvls</param>
    /// <param name="title">Title of the question</param>
    /// <param name="msg">More text to view below the title</param>
    /// <returns>True if YesButton was clicked or False if NoButton was clicked</returns>
    public static bool Run(lvls lvl, string title, string msg)
            => Do(lvl, title, msg, default, null, null, null);
    /// <summary>
    /// Inform the user using Info() form by pulling info from inf + implicitly or explicity determining the icon/color
    /// </summary>
    /// <param name="lvl">info level as System.Windows.Forms.DialogResult lvls</param>
    /// <param name="title">Title of the question</param>
    /// <param name="msg">More text to view below the title</param>
    /// <param name="fullFatalError">Fatal error text (full error)</param>  
    /// <returns>True if YesButton was clicked or False if NoButton was clicked</returns>
    public static bool Run(lvls lvl, string title, string msg, string fullFatalError)
            => Do(lvl, title, msg, default, fullFatalError, null, null);
    /// <summary>
    /// Inform the user using Info() form by pulling info from inf + implicitly or explicity determining the icon/color
    /// </summary>
    /// <param name="lvl">info level as System.Windows.Forms.DialogResult lvls</param>
    /// <param name="title">Title of the question</param>
    /// <param name="msg">More text to view below the title</param>
    /// <param name="YesNoButtons">Text of the Left(true) and right(false) buttons(YesButton, NoButton)</param>
    /// <returns>True if YesButton was clicked or False if NoButton was clicked</returns>
    public static bool Run(lvls lvl,
                           string title, string msg,
                           (string YesButton, string NoButton) YesNoButtons = default)
            => Do(lvl, title, msg, YesNoButtons, null, null, null);
    /// <summary>
    /// Inform the user using Info() form by pulling info from inf + implicitly or explicity determining the icon/color
    /// </summary>
    /// <param name="lvl">info level as System.Windows.Forms.DialogResult lvls</param>
    /// <param name="title">Title of the question</param>
    /// <param name="msg">More text to view below the title</param>
    /// <param name="YesNoButtons">Text of the Left(true) and right(false) buttons(YesButton, NoButton)</param> 
    /// <param name="icon">(Index 0 Dark, 1 Light) Message icon (Color derived from it) - Must be 64x64 for the best appearance</param>
    /// <param name="color">(Index 0 Dark, 1 Light) Message color (Auto determined unless defined here)</param>
    /// <returns>True if YesButton was clicked or False if NoButton was clicked</returns>
    public static bool Run(lvls lvl,
                           string title, string msg,
                           (string YesButton, string NoButton) YesNoButtons = default,
                           Image[] icon = null,
                           Color[] color = null) 
             => Do(lvl, title, msg, YesNoButtons, null, icon, color);
     
    private static bool Do(lvls lvl,
                           string title, string msg, 
                           (string YesButton, string NoButton) YesNoButtons = default,
                           string fullFatalError = null,
                           Image[] icon = null,
                           Color[] color = null) {
        //default 
        infoAnswer = false;
        detail = (detail.code, lvls.Information, null, null, null);
        ButtonText = (null, null);
        theme = (null, null);

        //set
        detail = (detail.code, lvl, title, msg, fullFatalError);
        ButtonText = YesNoButtons;
        theme = (icon, color);

        Info Info = new Info();
        Info.ShowDialog();
        return infoAnswer;
    }
    public static string WindowTitle { get =>
        detail.lvl switch {
                //lvls.Information => infIcon.Information, // -1
                lvls.Warn => $" ⚠  Warn: ❰{detail.code}❱ — Geek Assistant", // 0
                lvls.Error => $" ❌  Error: ❰{detail.code}❱ — Geek Assistant", // 1 // 10
                lvls.FatalError => $" ❌  Fatal Error: ❰{detail.code}❱ — Geek Assistant",
                //lvls.Question => detail.title, // 2
                _ => detail.title + " — Geek Assistant"  // -1
            };
    }
    public static Image infIcon(lvls lvl) =>
         lvl switch {
             //lvls.Information => infIcon.Information, // -1
             lvls.Warn => infIconRes.Warn, // 0
             lvls.Error | lvls.FatalError => infIconRes.Error, // 1 | 10
             lvls.Question => infIconRes.Question, // 2
             _ => infIconRes.Information  // -1
         }; 
    public static Color infColor (lvls lvl) =>
         lvl switch {
             //lvls.Information => infIcon.Information, // -1
             lvls.Warn => c.colors.warnYellow, // 0
             lvls.Error | lvls.FatalError => c.colors.errRed, // 1 | 10
             lvls.Question => c.colors.questBlue, // 2
             _ => c.colors.infBlue  // -1
         }; 

        //if (math.CompareImagesBritghtnessMatrix(icon , infIconRes.Warn)) return c.colors.warnYellow;// 0
        //else if (math.CompareImagesBritghtnessMatrix(icon , infIconRes.Error)) return c.colors.errRed; // 1 | 10
        //else if (math.CompareImagesBritghtnessMatrix(icon , infIconRes.Question)) return c.colors.questBlue;//2
        ///*if (icon == infIcon.Information)*/
        //else return c.colors.infBlue; //-1
    
    public struct infIconRes { 
        public static Image Information { get => c.S.DarkTheme ? prop.x64.Info_Blue_dark_64 : prop.x64.Info_Blue_64; } 
        public static Image Warn { get => c.S.DarkTheme ? prop.x64.Info_Yellow_dark_64 : prop.x64.Info_Yellow_64; }
        public static Image Question { get => c.S.DarkTheme ? prop.x64.Question_Blue_dark_64 : prop.x64.Question_Blue_64; }
        public static Image Error { get => c.S.DarkTheme ? prop.x64.Warning_Red_dark_64 : prop.x64.Warning_Red_64; }
    }
}