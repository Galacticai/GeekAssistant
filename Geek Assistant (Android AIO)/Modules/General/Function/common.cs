using GeekAssistant;
using GeekAssistant.Forms;
using System;
using System.Linq;

internal static partial class common {

    #region GA Directories
    /// <summary>
    /// Geek Assistant home directory ( ...\AppData\Roaming\Geek Assistant (Android AIO) )
    /// </summary>
    public readonly static string GA = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Geek Assistant (Android AIO)";
    /// <summary>
    /// Geek Assistant tools directory (adb, fastboot, and others) ( {GA}\tools )
    /// </summary>
    public readonly static string GA_tools = $@"{GA}\tools";
    /// <summary>
    /// Geek Assistant logs directory (Saved every session) ( {GA}\log )
    /// </summary>
    public readonly static string GA_logs = $@"{GA}\log";

    #endregion


    #region GA Elements 

    public readonly static PleaseWait PleaseWait = new PleaseWait();
    public readonly static Preparing Preparing = new Preparing();
    public readonly static AppMode AppMode = new AppMode();
    public readonly static Donate Donate = new Donate();
    public readonly static Home Home = new Home();
    public readonly static Info Info = new Info();
    public readonly static Settings Settings = new Settings();
    public readonly static ToU ToU = new ToU();

    public readonly static prop.S S = new prop.S();
    /*
    public readonly static prop.GA RGA = new prop.GA();
    public readonly static prop.strings Pstrings = new prop.strings();
    public readonly static prop.layout Playout = new prop.layout();
    public readonly static prop.tools Ptools = new prop.tools();
    public readonly static prop.x64 Px64 = new prop.x64();
    public readonly static prop.x24 Px24 = new prop.x24();
    public readonly static prop.x16 Px16 = new prop.x16();
    public readonly static prop.xXX PxXX = new prop.xXX();
    */
    #endregion

    #region Public Abbreviations

    public readonly static Version V = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
    /// <summary>
    /// Simple .NET new line (Environment.NewLine)
    /// </summary>
    public readonly static string n = Environment.NewLine;
    /// <summary>
    /// Simple html new line (&lt;br/&gt;)
    /// </summary>
    public readonly static string br = "<br/>";
    /// <summary>
    /// Tab: (Unicode) U+3000 | (HTML) And#12288; | (Description) Ideographic Space
    /// </summary>
    public readonly static string tab = "　";
    /// <summary>
    /// Double Tab: (Unicode) U+3000 | (HTML) And#12288; | (Description) Ideographic Space
    /// </summary>
    public readonly static string tab2 = "　　";

    #endregion


    #region Public variables

    /// <summary>
    /// <list>
    /// <item>Flagged on when a process is ongoing.</item>
    /// <item>Blocks other processes from starting while another is already ongoing</item>
    /// </list>
    /// </summary>
    public static bool Working = false;

    private static (string code, int lvl, string msg) _ErrorInfo;
    /// <summary>
    /// <list>
    /// <item>Current Error lvl and msg </item>
    /// <item>Set while a process is running;</item>
    /// <item>When an Exception is thrown the (info) form will use this ErrorInfo</item>
    /// </list>
    /// </summary>
    public static (string code, int lvl, string msg) ErrorInfo; /*{
        get { return _ErrorInfo; }
        set {
            if (value.lvl >= - 1 && value.lvl <= 10)
                throw new Exception(); else _ErrorInfo.lvl = value.lvl; 
            if (value.code == null) 
                throw new Exception(); else _ErrorInfo.code = value.code;
        }*/
    } 
     
    #endregion 
 