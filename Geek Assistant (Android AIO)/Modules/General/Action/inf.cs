using GeekAssistant.Forms;
using System.Drawing;
/// <summary>
/// Inform the user using Info() form by pulling info from inf + implicitly or explicity determining the icon/color
/// </summary>
internal static partial class inf { //inform

    #region Info

    public static bool infoAnswer = false;

    public static string workTitle;
    /// <summary>
    /// <list>
    /// <item>Current Error lvl and msg </item>
    /// <item>Set while a process is running;</item>
    /// <item>When an Exception is thrown the (info) form will use this ErrorInfo</item>
    /// </list>
    /// </summary>
    public static (string workCode, lvls lvl, string title, string msg, string fullFatalError) detail;
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
    /// <param name="YesNoButtons">Text of the Left(true) and right(false) buttons(YesButton, NoButton)</param>
    /// <returns>True if YesButton was clicked or False if NoButton was clicked</returns>
    public static bool Run((string YesButton, string NoButton) YesNoButtons = default)
        => Run(detail);
    /// <summary>
    /// Inform the user using Info() form by pulling info from inf + implicitly or explicity determining the icon/color
    /// </summary>
    /// <param name="infDetail">info details provided by inf.detail</param> 
    /// <param name="YesNoButtons">Text of the Left(true) and right(false) buttons(YesButton, NoButton)</param>
    /// <returns>True if YesButton was clicked or False if NoButton was clicked</returns>
    public static bool Run((string workCode, lvls lvl, string title, string msg, string fullFatalError) infDetail,
                           (string YesButton, string NoButton) YesNoButtons = default) {

        if (!string.IsNullOrEmpty(detail.workCode)) {
            detail.workCode = infDetail.workCode;
        }

        if (!string.IsNullOrEmpty(detail.fullFatalError)) {
            detail.fullFatalError = infDetail.fullFatalError;
        }

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
        detail = (detail.workCode, _lvl, _title, _msg, _fullFatalError);
        YesNoButtons = _YesNoButtons;
        theme = _theme;

        Info Info = new();
        Info.ShowDialog();
        return infoAnswer;
    }
    private static string detailcode => string.IsNullOrEmpty(detail.workCode) ? $"{detail.title}" : $"❰{detail.workCode}❱";
    public static string WindowTitle
        => detail.lvl switch {
            lvls.Warn => $" ⚠  Warn: {detailcode} — Geek Assistant", // 0
            lvls.Error => $" ❌  Error: {detailcode} — Geek Assistant", // 1 // 10
            lvls.FatalError => $" ❌  Fatal Error: {detailcode} — Geek Assistant",
            _ => $"{detail.title} — Geek Assistant"  // -1 and 2
        };




}