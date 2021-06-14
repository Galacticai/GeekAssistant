using System.Drawing;
using System.Windows.Forms;
using GeekAssistant.Modules.General.Companion.Style;

namespace GeekAssistant.Controls.Themed {
    public class Themed_Label : Label {
        public override Color ForeColor {
            get => colors.UI.fg();
            set {
                base.ForeColor = colors.UI.fg();
                Invalidate();
            }
        }
        public override Color BackColor {
            get => colors.UI.bg();
            set {
                base.BackColor = colors.UI.bg();
                Invalidate();
            }
        }
    }
}