using GeekAssistant.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

internal class c {

    #region GA Directories
    ///<summary> Geek Assistant home directory ( ...\AppData\Roaming\Geek Assistant (Android AIO) ) </summary>
    public static readonly string GA = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}"
                                      + @"\Geek Assistant (Android AIO)";
    /// <summary> Geek Assistant tools directory (adb, fastboot, and others) ( {GA}\tools ) </summary>
    public static readonly string GA_tools = $@"{GA}\tools";
    /// <summary> Geek Assistant logs directory (Saved every session) ( {GA}\log ) </summary>
    public static readonly string GA_logs = $@"{GA}\log";
    #endregion


    #region Forms 
    public static bool FormisRunning<form>() where form : Form
        => Application.OpenForms.OfType<form>().Any();
    private static form Forms<form>() where form : Form
        => Application.OpenForms.OfType<form>().FirstOrDefault();
    public static Preparing Preparing => Forms<Preparing>() ?? new();
    public static Wait Wait => Forms<Wait>() ?? new();
    public static AppMode AppMode => Forms<AppMode>() ?? new();
    public static Donate Donate => Forms<Donate>() ?? new();
    public static Home Home => Forms<Home>() ?? new();
    public static Info Info => Forms<Info>() ?? new();
    public static Settings Settings => Forms<Settings>() ?? new();
    public static ToU ToU => Forms<ToU>() ?? new();

    #endregion


    #region prop 

    private static prop.S _S;
    public static prop.S S => _S ??= new();
    public static bool theme(bool anti = false) => anti ? !S.DarkTheme : S.DarkTheme;

    #endregion

    #region Public Abbreviations 

    /// <summary> Get current copyright string </summary>
    public static readonly string C = System.Diagnostics.FileVersionInfo.GetVersionInfo(
                                          System.Reflection.Assembly.GetExecutingAssembly().Location
                                      ).LegalCopyright;
    /// <summary> Get current version field </summary>
    public static readonly Version V = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
    /// <summary> Simple .NET new line (Environment.NewLine) </summary>
    public static readonly string n = Environment.NewLine;
    /// <summary> Simple html new line (&lt;br/&gt;) </summary>
    public static readonly string br = "<br/>";
    /// <summary> Tab: (Unicode) U+3000 | (HTML) And#12288; | (Description) Ideographic Space </summary>
    public static readonly string tab = @"　";
    /// <summary> Double Tab: (Unicode) U+3000 | (HTML) And#12288; | (Description) Ideographic Space </summary>
    public static readonly string tab2 = @"　　";

    #endregion


    #region Public variables

    /// <summary> <list>
    /// <item>Flagged on when a process is ongoing.</item>
    /// <item>Blocks other processes from starting while another is already ongoing</item>
    /// </list> </summary>
    public static bool Working = false;

    #endregion

}