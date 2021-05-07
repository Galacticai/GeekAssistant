using GeekAssistant.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;

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


    #region GA Colors
    /// <summary> Dynamically selected colors according to global Light/Dark Theme </summary>
    public struct colors {

        public struct SwitchButton {
            public static Color bg { get => c.S.DarkTheme ? Color.FromArgb(32, 32, 32) : Color.WhiteSmoke; }
            public static Color bg_Hover { get => c.S.DarkTheme ? Color.FromArgb(32, 72, 32) : Color.Honeydew; }
            public static Color bg_Active { get => c.S.DarkTheme ? Color.FromArgb(0, 120, 0) : Color.Green; }
        }
        public static Color bg { get => S.DarkTheme ? constColors.bg_Dark : constColors.bg; }
        public static Color fg { get => S.DarkTheme ? constColors.fg_Dark : constColors.fg; }
        public static Color Green { get => S.DarkTheme ? constColors.Green_Dark : constColors.Green; }
        public static MetroThemeStyle Metro { get => S.DarkTheme ? MetroThemeStyle.Dark : MetroThemeStyle.Light; }

        #region infColorRes
        public static Color infBlue { get => S.DarkTheme ? constColors.infBlue_Dark : constColors.infBlue; }
        public static Color warnYellow { get => S.DarkTheme ? constColors.warnYellow_Dark : constColors.warnYellow; }
        public static Color errRed { get => S.DarkTheme ? constColors.errRed_Dark : constColors.errRed; }
        public static Color questBlue { get => S.DarkTheme ? constColors.questBlue_Dark : constColors.questBlue; }
        #endregion

        /// <summary> Constant colors not affected by themes or anything </summary>
        public struct constColors {
            /// <summary> Color.White </summary>
            public static Color bg { get => Color.White; }
            /// <summary> Color.FromArgb(17, 17, 17) </summary>
            public static Color bg_Dark { get => Color.FromArgb(17, 17, 17); }

            /// <summary> SystemColors.ControlText </summary>
            public static Color fg { get => SystemColors.ControlText; }
            /// <summary> Color.White </summary>
            public static Color fg_Dark { get => Color.White; }

            /// <summary> Color.FromArgb(95, 191, 119) </summary>
            public static Color Green_Dark { get => Color.FromArgb(95, 191, 119); }
            /// <summary> Color.FromArgb(0, 128, 32) </summary>
            public static Color Green { get => Color.FromArgb(0, 128, 32); }

            /// <summary> Color.FromArgb(191, 236, 255) </summary>
            public static Color infBlue_Dark { get => Color.FromArgb(191, 236, 255); }
            /// <summary> Color.FromArgb(0, 80, 115) </summary>
            public static Color infBlue { get => Color.FromArgb(0, 80, 115); }

            /// <summary> Color.FromArgb(255, 238, 191) </summary>
            public static Color warnYellow_Dark { get => Color.FromArgb(255, 238, 191); }
            /// <summary> Color.FromArgb(115, 84, 0) </summary>
            public static Color warnYellow { get => Color.FromArgb(115, 84, 0); }

            /// <summary> Color.FromArgb(255, 191, 191) </summary>
            public static Color errRed_Dark { get => Color.FromArgb(255, 191, 191); }
            /// <summary> Color.FromArgb(154, 0, 0) </summary>
            public static Color errRed { get => Color.FromArgb(154, 0, 0); }

            /// <summary> Color.FromArgb(191, 223, 255) </summary>
            public static Color questBlue_Dark { get => Color.FromArgb(191, 223, 255); }
            /// <summary> Color.FromArgb(64, 109, 128) </summary>
            public static Color questBlue { get => Color.FromArgb(64, 109, 128); }
        }

    }
    #endregion
}