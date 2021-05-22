using System;

internal static partial class c {

    #region GA Directories
    ///<summary> Geek Assistant home directory ( ...\AppData\Roaming\Geek Assistant (Android AIO) ) </summary>
    public static readonly string GA = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Geek Assistant (Android AIO)";
    /// <summary> Geek Assistant tools directory (adb, fastboot, and others) ( {GA}\tools ) </summary>
    public static readonly string GA_tools = $@"{GA}\tools";
    /// <summary> Geek Assistant logs directory (Saved every session) ( {GA}\log ) </summary>
    public static readonly string GA_logs = $@"{GA}\log";
    #endregion


    /*#region GA Forms 

    /// <summary> A manually set (at code time) list of all forms in this project </summary>
    public static readonly Form[] AllForms = { new Wait(), new AppMode(), new Donate(), new Home(), new Info(), new Settings(), new ToU() };

    #endregion*/

    #region prop 

    public static prop.S S = new();
    public static bool theme(bool anti = false) => anti ? !S.DarkTheme : S.DarkTheme;

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