using MetroFramework;
using System.Drawing;

internal static class colors {
    private static bool dark { get => c.S.DarkTheme; }
    private static bool theme(bool anti) => dark & !anti;
    public struct UI {
        public static Color bg(bool anti = false) => theme(anti) ? constColors.bg_Dark : constColors.bg;
        public static Color fg(bool anti = false) => theme(anti) ? constColors.fg_Dark : constColors.fg;
        public static MetroThemeStyle Metro(bool anti = false) => theme(anti) ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
    }
    /// <summary> Dynamically selected colors according to global Light/Dark c.S.DarkTheme & !instance.inverseTheme </summary>  
    public struct SwitchButton {
        public static Color bg(bool anti = false) => theme(anti) ? ColorTranslator.FromHtml("#202020") : Color.WhiteSmoke;
        public static Color bg_Hover(bool anti = false) => Color.FromArgb(128, Misc.Green(anti));
        public static Color bg_Active(bool anti = false) => Misc.Green(anti);
    }

    public struct Misc {
        public static Color Green(bool anti = false) => theme(anti) ? constColors.Misc.Green_Dark : constColors.Misc.Green;
        public static Color Purple(bool anti = false) => theme(anti) ? constColors.Misc.Purple_Dark : constColors.Misc.Purple;
    }
    public struct infColorRes {
        public static Color infBlue(bool anti = false) => theme(anti) ? constColors.infColorRes.infBlue_Dark : constColors.infColorRes.infBlue;
        public static Color warnYellow(bool anti = false) => theme(anti) ? constColors.infColorRes.warnYellow_Dark : constColors.infColorRes.warnYellow;
        public static Color errRed(bool anti = false) => theme(anti) ? constColors.infColorRes.errRed_Dark : constColors.infColorRes.errRed;
        public static Color questBlue(bool anti = false) => theme(anti) ? constColors.infColorRes.questBlue_Dark : constColors.infColorRes.questBlue;
    }

    public struct Iconcolors {
        public static Color Donate(bool anti = false) => theme(anti) ? constColors.Iconcolors.Donate_Dark : constColors.Iconcolors.Donate;
        public static Color SwitchTheme(bool anti = false) => theme(anti) ? constColors.Iconcolors.Theme_Dark : constColors.Iconcolors.SwitchTheme;
        public static Color Smile(bool anti = false) => theme(anti) ? constColors.Iconcolors.Smile_Dark : constColors.Iconcolors.Smile;
        public static Color Settings(bool anti = false) => theme(anti) ? constColors.Iconcolors.Settings_Dark : constColors.Iconcolors.Settings;
        public static Color ToU(bool anti = false) => theme(anti) ? constColors.Iconcolors.ToU_Dark : constColors.Iconcolors.ToU;
        public static Color Commands(bool anti = false) => theme(anti) ? constColors.Iconcolors.Commands_Dark : constColors.Iconcolors.Commands;
    }

    /// <summary> Constant colors not affected by themes or anything </summary>
    public struct constColors {
        /// <summary> Color.White </summary>
        public static Color bg { get => Color.White; }

        /// <summary> ColorTranslator.FromHtml(17, 17, 17) </summary>
        public static Color bg_Dark { get => ColorTranslator.FromHtml("#111111"); }
        /// <summary> SystemColors.ControlText </summary>
        public static Color fg { get => SystemColors.ControlText; }
        /// <summary> Color.White </summary>
        public static Color fg_Dark { get => Color.White; }

        public struct infColorRes {
            /// <summary> #bfecff </summary>
            public static Color infBlue_Dark { get => ColorTranslator.FromHtml("#bfecff"); }
            /// <summary> #005073 </summary>
            public static Color infBlue { get => ColorTranslator.FromHtml("#005073"); }

            /// <summary> #ffeebf </summary>
            public static Color warnYellow_Dark { get => ColorTranslator.FromHtml("#ffeebf"); }
            /// <summary> #735400 </summary>
            public static Color warnYellow { get => ColorTranslator.FromHtml("#735400"); }

            /// <summary> #ffbfbf </summary>
            public static Color errRed_Dark { get => ColorTranslator.FromHtml("#ffbfbf"); }
            /// <summary> #9a0000 </summary>
            public static Color errRed { get => ColorTranslator.FromHtml("#9a0000"); }

            /// <summary> #bfdfff </summary>
            public static Color questBlue_Dark { get => ColorTranslator.FromHtml("#bfdfff"); }
            /// <summary> #406d80 </summary>
            public static Color questBlue { get => ColorTranslator.FromHtml("#406d80"); }
        }

        public struct Iconcolors {
            /// <summary> #ffbfd9 </summary>
            public static Color Donate_Dark { get => ColorTranslator.FromHtml("#ffbfd9"); }
            /// <summary> #800057 </summary>
            public static Color Donate { get => ColorTranslator.FromHtml("#800057"); }

            /// <summary> #bfcdff </summary>
            public static Color Theme_Dark { get => ColorTranslator.FromHtml("#bfcdff"); }
            /// <summary> #665200 </summary>
            public static Color SwitchTheme { get => ColorTranslator.FromHtml("#665200"); }

            /// <summary> #BFFFBF </summary>
            public static Color Smile_Dark { get => ColorTranslator.FromHtml("#BFFFBF"); }
            /// <summary> #006647 </summary>
            public static Color Smile { get => ColorTranslator.FromHtml("#006647"); }

            /// <summary> #BFF4FF </summary>
            public static Color Settings_Dark { get => ColorTranslator.FromHtml("#BFF4FF"); }
            /// <summary> #006A80 </summary>
            public static Color Settings { get => ColorTranslator.FromHtml("#006A80"); }

            /// <summary> #B2FFDC </summary>
            public static Color ToU_Dark { get => ColorTranslator.FromHtml("#B2FFDC"); }
            /// <summary> #006647 </summary>
            public static Color ToU { get => ColorTranslator.FromHtml("#006647"); }

            /// <summary> #C0D0FF </summary>
            public static Color Commands_Dark { get => ColorTranslator.FromHtml("#C0D0FF"); }
            /// <summary> #1F4099 </summary>
            public static Color Commands { get => ColorTranslator.FromHtml("#1F4099"); }
        }

        public struct Misc {
            /// <summary> #5FBF77 </summary>
            public static Color Green_Dark { get => ColorTranslator.FromHtml("#5FBF77"); }
            /// <summary> #008020 </summary>
            public static Color Green { get => ColorTranslator.FromHtml("#008020"); }

            /// <summary> #FF7AFF </summary>
            public static Color Purple_Dark { get => ColorTranslator.FromHtml("#FF7AFF"); }
            /// <summary> #800080 </summary>
            public static Color Purple { get => ColorTranslator.FromHtml("#800080"); }
        }
    }
}