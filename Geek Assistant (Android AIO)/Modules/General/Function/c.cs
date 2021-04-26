using GeekAssistant;
using GeekAssistant.Forms;
using System;
using System.Windows.Forms;

internal static partial class c {

    #region GA Directories
    /// <summary>
    /// Geek Assistant home directory ( ...\AppData\Roaming\Geek Assistant (Android AIO) )
    /// </summary>
    public static readonly string GA = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Geek Assistant (Android AIO)";
    /// <summary>
    /// Geek Assistant tools directory (adb, fastboot, and others) ( {GA}\tools )
    /// </summary>
    public static readonly string GA_tools = $@"{GA}\tools";
    /// <summary>
    /// Geek Assistant logs directory (Saved every session) ( {GA}\log )
    /// </summary>
    public static readonly string GA_logs = $@"{GA}\log";

    #endregion


    #region GA Forms  

    public static Form[] AllForms = { 
            Preparing,
            AppMode,
            Donate(),
            Home,
            Info(),
            Settings(),
            ToU()
        };
     
    public static PleaseWait PleaseWait() => new PleaseWait();
    public static Preparing Preparing = new Preparing();
    public static AppMode AppMode = new AppMode();
    public static Donate Donate() => new Donate();
    public static Home Home = new Home();
    public static Info Info() => new Info();
    public static Settings Settings() => new Settings();
    public static ToU ToU() => new ToU();

    #endregion


    #region prop 

    public static prop.S S = new prop.S(); 

    public static readonly prop.GA RGA = new prop.GA();
    public static readonly prop.strings Pstrings = new prop.strings();
    public static readonly prop.layout Playout = new prop.layout();
    public static readonly prop.tools Ptools = new prop.tools();
    public static readonly prop.x64 Px64 = new prop.x64();
    public static readonly prop.x24 Px24 = new prop.x24();
    public static readonly prop.x16 Px16 = new prop.x16();
    public static readonly prop.xXX PxXX = new prop.xXX();

    #endregion


    #region Public Abbreviations
     

    /// <summary>
    /// Get current copyright string
    /// </summary>
    public static readonly string C = System.Diagnostics.FileVersionInfo.GetVersionInfo(
                                          System.Reflection.Assembly.GetExecutingAssembly().Location
                                      ).LegalCopyright;
    /// <summary>
    /// Get current version field
    /// </summary>
    public static readonly Version V = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
    /// <summary>
    /// Simple .NET new line (Environment.NewLine)
    /// </summary>
    public static readonly string n = Environment.NewLine;
    /// <summary>
    /// Simple html new line (&lt;br/&gt;)
    /// </summary>
    public static readonly string br = "<br/>";
    /// <summary>
    /// Tab: (Unicode) U+3000 | (HTML) And#12288; | (Description) Ideographic Space
    /// </summary>
    public static readonly string tab = "　";
    /// <summary>
    /// Double Tab: (Unicode) U+3000 | (HTML) And#12288; | (Description) Ideographic Space
    /// </summary>
    public static readonly string tab2 = "　　";

    #endregion


    #region Public variables

    /// <summary>
    /// <list>
    /// <item>Flagged on when a process is ongoing.</item>
    /// <item>Blocks other processes from starting while another is already ongoing</item>
    /// </list>
    /// </summary>
    public static bool Working = false;

    /*private static (string code, int lvl, string msg) _ErrorInfo;
    {
        get { return _ErrorInfo; }
        set {
            if (value.lvl >= - 1 && value.lvl <= 10)
                throw new Exception(); else _ErrorInfo.lvl = value.lvl; 
            if (value.code == null) 
                throw new Exception(); else _ErrorInfo.code = value.code;
    }*/
    /// <summary>
    /// <list>
    /// <item>Current Error lvl and msg </item>
    /// <item>Set while a process is running;</item>
    /// <item>When an Exception is thrown the (info) form will use this ErrorInfo</item>
    /// </list>
    /// </summary>
    public static (string code, int lvl, string msg) ErrorInfo;
    #endregion
} 