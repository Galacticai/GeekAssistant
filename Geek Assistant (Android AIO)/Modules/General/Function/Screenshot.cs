using System.Drawing;
using System.Drawing.Imaging;

internal static partial class Screenshot {
    public static Image Run(Rectangle rect) {
        Bitmap bmp = new(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
        Graphics.FromImage(bmp).
            CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
        return bmp;
    }
}
