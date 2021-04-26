
using System.Drawing;
using System.Windows.Forms;

public partial class TransparentTextBox : TextBox {
    public TransparentTextBox() {
        SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
         
        BackColor = Color.Transparent;
        Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
    }
}