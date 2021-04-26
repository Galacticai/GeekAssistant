
using System.Drawing;
using System.Windows.Forms;

internal static partial class GA_SwitchButton_Style {

    // Public Shared Top As Integer
    // Public Shared Left As Integer
    // Public Shared ButtonOriginalPosition As Integer()
    private static Color Current_bg_Active() {
        if (c.S.DarkTheme) {
            return Color.FromArgb(0, 120, 0);
        } else {
            return Color.Green;
        }
    }

    private static Color Current_bg_Hover() {
        if (c.S.DarkTheme) {
            return Color.FromArgb(32, 72, 32);
        } else {
            return Color.Honeydew;
        }
    }

    private static Color Current_bg_Neutral() {
        if (c.S.DarkTheme) {
            return Color.FromArgb(32, 32, 32);
        } else {
            return Color.WhiteSmoke;
        }
    }

    public static bool ButtonPressedAlready;

    public static void SettingsButtonSwitch_Style_EnableIfTrue(ref Button aButton, bool aBoolean) {
        if (aBoolean) {
            aButton.ForeColor = Color.White;
            aButton.BackColor = Current_bg_Active();
        } else {
            aButton.ForeColor = GA_SetTheme.Current_fgColor();
            aButton.BackColor = Current_bg_Neutral();
        }
    }

    private static (int x, int y) aButton_xy;

    public static void SettingsButtonSwitch_Style_MouseDown_KeyDown(ref Button aButton) {
        // '
        // ' Fixing button flying away problem when long clicking with keyboard (repeating KeyDown event)
        // ' 
        aButton_xy = (aButton.Left, aButton.Top);
        if (ButtonPressedAlready) {
            return;
        }

        ButtonPressedAlready = true;
        aButton.ForeColor = Color.White;
        aButton.Left += 1;
        aButton.Top += 2;
    }

    public static void SettingsButtonSwitch_Style_MouseUp_KeyUp(ref Button aButton) {
        ButtonPressedAlready = false;
        aButton.ForeColor = GA_SetTheme.Current_fgColor();
        if (aButton.BackColor == Color.Green | aButton.BackColor == Color.FromArgb(0, 130, 0)) {
            aButton.ForeColor = Color.White;
        }
        // If Not S.DarkTheme Then
        // aButton.BackColor = Color.FromArgb(32, 32, 32)
        // End If
        aButton.Left = aButton_xy.x;
        aButton.Top = aButton_xy.y;
    }

    public static void SettingsButtonSwitch_Style_MouseEnter(ref Button aButton, bool aBoolean) {
        if (aBoolean) {
            aButton.BackColor = Color.FromArgb(0, 130, 0);
            aButton.ForeColor = Color.White;
        } else {
            aButton.BackColor = Current_bg_Hover();
            aButton.ForeColor = GA_SetTheme.Current_fgColor();
        }
    }

    public static void SettingsButtonSwitch_Style_MouseLeave(ref Button aButton, bool aBoolean) {
        if (aBoolean) {
            aButton.BackColor = Current_bg_Active();
            aButton.ForeColor = Color.White;
        } else {
            aButton.BackColor = Current_bg_Neutral();
            aButton.ForeColor = GA_SetTheme.Current_fgColor();
        }
    }

    public static void SettingsButtonSwitch_Style_MouseClick(ref Button aButton, bool aBoolean, ref ToolTip aTooltip, string aTooltip_txt) {
        if (aBoolean) {
            aButton.BackColor = Current_bg_Neutral();
            aBoolean = false;
            c.S.Save();
            if (aTooltip is object & aTooltip_txt is object)
                aTooltip.SetToolTip(aButton, $"(Disabled) {aTooltip_txt}");
        } else {
            aButton.BackColor = Current_bg_Active();
            aBoolean = true;
            c.S.Save();
            if (aTooltip is object & aTooltip_txt is object)
                aTooltip.SetToolTip(aButton, $"(Enabled) {aTooltip_txt}");
        }
    }
}