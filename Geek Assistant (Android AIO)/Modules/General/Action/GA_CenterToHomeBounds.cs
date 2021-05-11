

using GeekAssistant.Forms;
using System;
using System.Windows.Forms;

internal static partial class GA_CenterToHomeBounds {
    public static void Run(Form f) {
        int[] xy;
        Home h = null;

        foreach (Form home in Application.OpenForms)
            if (home.GetType() == typeof(Home)) h = (Home)home;

        if (h != null)
            xy = new[] { (h.Width / 2) - (f.Width / 2) + h.Location.X,      // Center horizontally (relative to home)
                         h.Top };                                           // Top (relative to home)
        else {
            var currentScreenRect = Screen.FromControl(f).WorkingArea;
            xy = new[] { (h.Width / 2) - (f.Width / 2) + h.Location.X,      // Center horizontally (relative to screen)
                         (currentScreenRect.Height / 2) - (f.Height / 2) }; // Center Vertically  (relative to screen)
        }
        f.SetBounds(xy[0], xy[1], f.Width, f.Height);
    }
}
