using GeekAssistant;
using GeekAssistant.Forms;
using System; 

internal static partial class common {

    #region Geek Assistant
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


    #region Public constants

    public readonly static Version V = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
    public readonly static prop.S S = new  prop.S();

    public readonly static PleaseWait PleaseWait = new PleaseWait();
    public readonly static Preparing Preparing = new Preparing();
    public readonly static AppMode AppMode = new AppMode();
    public readonly static Donate Donate = new Donate();
    public readonly static Home Home = new Home();
    public readonly static Info Info = new Info();
    public readonly static Settings Settings = new Settings();
    public readonly static ToU ToU = new ToU();
    //public readonly static Managed.Adb ADB = new Managed.Adb;
    /**/
    public readonly static prop.GA RGA = new prop.GA();
    public readonly static prop.strings Pstrings = new prop.strings();
    public readonly static prop.layout Playout = new prop.layout();
    public readonly static prop.tools Ptools = new prop.tools();
    public readonly static prop.x64 Px64 = new prop.x64();
    public readonly static prop.x24 Px24 = new prop.x24();
    public readonly static prop.x16 Px16 = new prop.x16();
    public readonly static prop.xXX PxXX = new prop.xXX();
    /**/
    //public readonly static GeekAssistant.Home Main;

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

    /// <summary>
    /// <list>
    /// <item>Current Error lvl and msg </item>
    /// <item>Set while a process is running;</item>
    /// <item>When an Exception is thrown the (info) form will use this ErrorInfo</item>
    /// </list>
    /// </summary>
    public static (string code, int lvl, string msg) ErrorInfo;
    // ' 'Public Property ErrorInfo = () As (lvl As Integer, msg As String)
    // ' '    Get
    // ' '        Return _ErrorInfo : End Get
    // ' '    Set(value As (lvl As Integer, msg As String))
    // ' '        If value.lvl <= 10 And value.lvl >= -1 Then _ErrorInfo.lvl = value.lvl
    // ' '        If Not String.IsNullOrEmpty(value.msg) Then _ErrorInfo.msg = value.msg
    // ' '    End Set
    // ' 'End Property
    // 'Public Structure ErrorInfo_
    // '    Public Shared Property lvl As Integer
    // '        Get
    // '            Return _ErrorInfo.lvl : End Get
    // '        Set(value As Integer)
    // '            If value <= 10 And value >= -1 Then _ErrorInfo.lvl = value
    // '        End Set
    // '    End Property
    // '    Public Shared Property msg As String
    // '        Get
    // '            Return _ErrorInfo.msg : End Get
    // '        Set(value As String)
    // '            If Not String.IsNullOrEmpty(value) Then _ErrorInfo.msg = value
    // '        End Set
    // '    End Property
    // 'End Structure
    // Public Function ErrorInfo = (Optional lvl As Integer = -100, Optional msg As String = Nothing) As (lvl As Integer, msg As String)
    // If lvl <= 10 And lvl >= -1 Then _ErrorInfo.lvl = lvl
    // If Not String.IsNullOrEmpty(msg) Then _ErrorInfo.msg = msg
    // Return (lvl, msg)
    // End Function
     
    #endregion 

}