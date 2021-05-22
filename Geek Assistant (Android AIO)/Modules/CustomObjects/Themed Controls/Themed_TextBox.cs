using System.Drawing;
using System.Windows.Forms;

namespace GeekAssistant.Controls.Themed {
    public class Themed_TextBox : TextBox {
        //public override Color ForeColor {
        //    get => base.ForeColor;
        //    set {
        //        Animate.Run(this, nameof(base.ForeColor), colors.UI.fg());
        //        Invalidate();
        //    }
        //}
        //public override Color BackColor {
        //    get => colors.UI.bg();
        //    set {
        //        Animate.Run(this, nameof(base.BackColor), colors.UI.bg());
        //        Invalidate();
        //    }
        //}
        protected override void OnPaint(PaintEventArgs pevent) {
            Theming.SetControlTheme(this);
            base.OnPaint(pevent);
        }

        protected override void OnCreateControl() {
            Theming.SetControlTheme(this);
            base.OnCreateControl();
        }
    }
}