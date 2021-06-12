
using System.Drawing;
using System.Windows.Forms;
using GeekAssistant.Modules.Global.Companion;
using GeekAssistant.Modules.Global.Companion.Style;

namespace GeekAssistant.Controls {
    internal static class SwitchButton_Style {

        // Public Shared Top As Integer
        // Public Shared Left As Integer
        // Public Shared ButtonOriginalPosition As Integer() 



        public static bool ButtonPressedAlready;

        private static (int x, int y) aButton_xy;

        public static void MouseDown(Control aButton) {

            // Fixing button flying away problem when long clicking with keyboard (repeating KeyDown event) 
            aButton_xy = (aButton.Left, aButton.Top);
            if (ButtonPressedAlready) return;

            ButtonPressedAlready = true;
            aButton.ForeColor = Color.White;

            aButton.Left += 1;
            aButton.Top += 2;
        }

        public static void MouseUp(Control aButton) {
            ButtonPressedAlready = false;
            aButton.ForeColor = colors.UI.fg();
            if (aButton.BackColor == Color.Green | aButton.BackColor == Color.FromArgb(0, 130, 0)) {
                aButton.ForeColor = Color.White;
            }

            aButton.Left = aButton_xy.x;
            aButton.Top = aButton_xy.y;
        }

        public static void MouseEnter(Control aButton, bool aBoolean) {
            if (aBoolean) {
                aButton.BackColor = Color.FromArgb(0, 130, 0);
                aButton.ForeColor = Color.White;
            } else {
                aButton.BackColor = colors.UI.SwitchButton.bg_Hover();
                aButton.ForeColor = colors.UI.fg();
            }
        }

        public static void MouseLeave(Control aButton, bool aBoolean) {
            if (aBoolean) {
                aButton.BackColor = colors.UI.SwitchButton.bg_Active();
                aButton.ForeColor = Color.White;
            } else {
                aButton.BackColor = colors.UI.SwitchButton.bg();
                aButton.ForeColor = colors.UI.fg();
            }
        }

        public static ToolTip tooltip = new() {
            AutomaticDelay = 100,
            AutoPopDelay = 10000,
            InitialDelay = 100,
            ReshowDelay = 0,
            ToolTipIcon = ToolTipIcon.Info,
            ToolTipTitle = "Selected:"
        };
        /// <summary>
        /// <list><item>Example:</item>
        /// <item>c.S.prop</item>
        /// <list><item>= GA_SwitchButton_Style.MouseClick(prop_SwitchButton, c.S.prop, prop_SwitchButton_ToolTip);  
        /// </item>
        /// </list></list>
        /// </summary>
        /// <param name="aButton">Button to control</param>
        /// <param name="prop">Setting to flip</param>
        /// <param name="aTooltip_txt">Tooltip text</param>
        /// <returns></returns>
        public static bool MouseClick(Control aButton, bool prop, string aTooltip_txt) {
            if (prop) aButton.BackColor = colors.UI.SwitchButton.bg();
            else aButton.BackColor = colors.UI.SwitchButton.bg_Active();

            if (!string.IsNullOrEmpty(aTooltip_txt))
                tooltip.SetToolTip(aButton, $"({(prop ? "Disabled" : "Enabled")}) {aTooltip_txt}");

            return !prop;
            //c.S.Save();
        }

        public static void EnableIfTrue(Control aButton, bool prop) {
            if (prop) {
                aButton.ForeColor = Color.White;
                aButton.BackColor = colors.UI.SwitchButton.bg_Active();
            } else {
                aButton.ForeColor = colors.UI.fg();
                aButton.BackColor = colors.UI.SwitchButton.bg();
            }
            if (!string.IsNullOrEmpty(tooltip.GetToolTip(aButton)))
                tooltip.SetToolTip(aButton, $"({(prop ? "Disabled" : "Enabled")}) {txt.WithoutState_SwitchButton_tooltipTxt(aButton)}");
        }
    }
}
