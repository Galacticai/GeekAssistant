using GeekAssistant.Forms;
using System;
using System.Windows.Forms;

internal static partial class c {

    #region GA Directories
    ///<summary> Geek Assistant home directory ( ...\AppData\Roaming\Geek Assistant (Android AIO) ) </summary>
    public static readonly string GA = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Geek Assistant (Android AIO)";
    /// <summary> Geek Assistant tools directory (adb, fastboot, and others) ( {GA}\tools ) </summary>
    public static readonly string GA_tools = $@"{GA}\tools";
    /// <summary> Geek Assistant logs directory (Saved every session) ( {GA}\log ) </summary>
    public static readonly string GA_logs = $@"{GA}\log";
    #endregion


    #region Forms 

    private static Preparing _Preparing;
    private static Wait _Wait;
    private static AppMode _AppMode;
    private static Donate _Donate;
    private static Home _Home;
    private static Info _Info;
    private static Settings _Settings;
    private static ToU _ToU;
    public static Preparing Preparing(bool getAgain = true) => (getAgain | _Preparing == null) ? _Preparing = (Preparing)Application.OpenForms[nameof(Preparing)] : _Preparing;
    public static Wait Wait(bool getAgain = true) => (getAgain | _Wait == null) ? _Wait = (Wait)Application.OpenForms[nameof(Wait)] : _Wait;
    public static AppMode AppMode(bool getAgain = true) => (getAgain | _AppMode == null) ? _AppMode = (AppMode)Application.OpenForms[nameof(AppMode)] : _AppMode;
    public static Donate Donate(bool getAgain = true) => (getAgain | _Donate == null) ? _Donate = (Donate)Application.OpenForms[nameof(Donate)] : _Donate;
    public static Home Home(bool getAgain = true) => (getAgain | _Home == null) ? _Home = (Home)Application.OpenForms[nameof(Home)] : _Home;
    public static Info Info(bool getAgain = true) => (getAgain | _Info == null) ? _Info = (Info)Application.OpenForms[nameof(Info)] : _Info;
    public static Settings Settings(bool getAgain = true) => (getAgain | _Settings == null) ? _Settings = (Settings)Application.OpenForms[nameof(Settings)] : _Settings;
    public static ToU ToU(bool getAgain = true) => (getAgain | _ToU == null) ? _ToU = (ToU)Application.OpenForms[nameof(ToU)] : _ToU;

    #endregion


    #region prop 

    private static prop.S _S;
    public static prop.S S => _S ?? new();
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