

using GeekAssistant.Forms;
using System.Windows.Forms;

internal static partial class GA_CenterToHomeBounds {
    public static void Run(Form f) {
        try {
            Home h = (Home)Application.OpenForms[0];
            f.SetBounds((h.Width / 2) - (f.Width / 2) + h.Location.X,
                        h.Top,
                        f.Width, f.Height);
        } catch {
            var currentScreenRect = Screen.FromControl(f).WorkingArea;
            f.SetBounds((currentScreenRect.Width / 2) - (f.Width / 2),
                        (currentScreenRect.Height / 2) - (f.Height / 2),
                        f.Width, f.Height);
        }
    }
}
