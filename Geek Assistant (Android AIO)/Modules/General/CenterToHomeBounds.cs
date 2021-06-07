

using GeekAssistant.Forms;
using System.Windows.Forms;

internal static partial class CenterToHomeBounds {
    public static void Run(Form f) {
        int[] xy;
        Home h = c.Home;

        //foreach (Form home in Application.OpenForms)
        //    if (home.GetType() == typeof(Home))
        //        h = (Home)home;

        //   _______________________                   
        //  |      |         |      |  <= Home
        //  |      |         | <= f |
        //  |      |_________|      |
        //  |                       |
        //  |_______________________|
        //
        if (h != null)
            xy = new[] { (h.Width / 2) - (f.Width / 2) + h.Location.X,
                         h.Top };
        //   _______________________                   
        //  |       _________       |  <= Screen
        //  |      |         | <= f |
        //  |      |         |      |
        //  |      |_________|      |
        //  |_______________________|
        //
        else {
            var currentScreenRect = Screen.FromControl(f).WorkingArea;
            xy = new[] { (currentScreenRect.Width / 2) - (f.Width / 2) + currentScreenRect.Location.X,
                         (currentScreenRect.Height / 2) - (f.Height / 2) };
        }
        f.SetBounds(xy[0], xy[1], f.Width, f.Height);
    }
}
