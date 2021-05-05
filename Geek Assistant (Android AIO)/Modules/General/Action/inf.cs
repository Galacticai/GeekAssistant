using GeekAssistant.Forms;
using System;
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
    //public struct detail {
    //    public static string code;
    //    public static lvls lvl;
    //    public static string title;
    //    public static string msg;
    //    public static string fullFatalError;
    //}
    /// <summary> YesButton can be null or empty </summary>
    public static (string YesButton, string NoButton) YesNoButtons;
    /// <summary> Use index [0] as light color and [1] as dark color </summary>
    public static (Image[] icon, Color[] color) theme;
    public enum lvls { Information = -1, Warn = 0, Error = 1, FatalError = 10, Question = 2 }

    #endregion

    /// <summary>
    /// Inform the user using Info() form by pulling info from inf + implicitly or explicity determining the icon/color
    /// </summary>
    /// <param name="infDetail">info details provided by inf.detail</param> 
    /// <param name="YesNoButtons">Text of the Left(true) and right(false) buttons(YesButton, NoButton)</param>
    /// <returns>True if YesButton was clicked or False if NoButton was clicked</returns>
    public static bool Run((string code, lvls lvl, string title, string msg, string fullFatalError) infDetail,
                           (string YesButton, string NoButton) YesNoButtons = default) {

        if (!string.IsNullOrEmpty(detail.code)) detail.code = infDetail.code;
        if (!string.IsNullOrEmpty(detail.fullFatalError)) detail.fullFatalError = infDetail.fullFatalError;

        return Run(infDetail.lvl, infDetail.title, infDetail.msg, YesNoButtons, default, infDetail.fullFatalError);
    }

    /// <summary>
    /// Inform the user using Info() form by pulling info from inf + implicitly or explicity determining the icon/color
    /// </summary>
    /// <param name="lvl">info level as System.Windows.Forms.DialogResult lvls</param>
    /// <param name="title">Title of the question</param>
    /// <param name="msg">More text to view below the title</param>
    /// <param name="fullFatalError">Fatal error text (full error)</param>  
    /// <returns>True if YesButton was clicked or False if NoButton was clicked</returns>
    public static bool Run(lvls _lvl, string _title, string _msg, string _fullFatalError)
            => Run(_lvl, _title, _msg, default, default, _fullFatalError);

    public static bool Run(lvls _lvl,
                           string _title, string _msg,
                           (string YesButton, string NoButton) _YesNoButtons = default,
                           (Image[] icon, Color[] color) _theme = default,
                           string _fullFatalError = null) {

        infoAnswer = false; //reset
        ////default do we even need this at all
        //detail = (detail.code, lvls.Information, null, null, null);
        //YesNoButtons = (null, null);
        //theme = (null, null);

        //set
        detail = (detail.code, _lvl, _title, _msg, _fullFatalError);
        YesNoButtons = _YesNoButtons;
        theme = _theme;

        Info Info = new();
        Info.ShowDialog();
        return infoAnswer;
    }
    private static string detailcode => string.IsNullOrEmpty(detail.code) ? $"{detail.title}" : $"❰{detail.code}❱";
    public static string WindowTitle
        => detail.lvl switch {
            lvls.Warn => $" ⚠  Warn: {detailcode} — Geek Assistant", // 0
            lvls.Error => $" ❌  Error: {detailcode} — Geek Assistant", // 1 // 10
            lvls.FatalError => $" ❌  Fatal Error: {detailcode} — Geek Assistant",
            _ => $"{detail.title} — Geek Assistant"  // -1 and 2
        };
    public static Image infIcon
        => detail.lvl switch {
            lvls.Warn => infIconRes.Warn, // 0
            lvls.Error => infIconRes.Error, // 1 
            lvls.FatalError => infIconRes.Error, // 10
            lvls.Question => infIconRes.Question, // 2
            _ => infIconRes.Information  // -1
        };
    public static Color infColor
        => detail.lvl switch {
            lvls.Warn => c.colors.warnYellow, // 0
            lvls.Error => c.colors.errRed, // 1
            lvls.FatalError => c.colors.errRed, // 10
            lvls.Question => c.colors.questBlue, // 2
            _ => c.colors.infBlue  // -1
        };

    public struct infIconRes {
        public static Image Information { get => c.S.DarkTheme ? prop.x64.Info_Blue_dark_64 : prop.x64.Info_Blue_64; }
        public static Image Warn { get => c.S.DarkTheme ? prop.x64.Info_Yellow_dark_64 : prop.x64.Info_Yellow_64; }
        public static Image Question { get => c.S.DarkTheme ? prop.x64.Question_Blue_dark_64 : prop.x64.Question_Blue_64; }
        public static Image Error { get => c.S.DarkTheme ? prop.x64.Warning_Red_dark_64 : prop.x64.Warning_Red_64; }
    }
}