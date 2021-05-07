
using System.Drawing;
using System.Windows.Forms;

public partial class SwitchButton : Button {
    public SwitchButton() {
        SetStyle(
            ControlStyles.SupportsTransparentBackColor |
            ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.ResizeRedraw |
            ControlStyles.UserPaint, true
        );

        BackColor = c.colors.fg;
        ForeColor = c.colors.bg;
        Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);


    }
}