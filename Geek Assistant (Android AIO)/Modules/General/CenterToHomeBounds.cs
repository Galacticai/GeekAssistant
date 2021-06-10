

using GeekAssistant.Forms;
using System.Windows.Forms;

internal static class CenterToHomeBounds {
    public static void Run(Form f) {
        int[] xy;

        //foreach (Form home in Application.OpenForms)
        //    if (home.GetType() == typeof(Home))
        //        h = (Home)home;

        /*   _______________________                   
          *  |      |         |      |  <= Home
          *  |      |         | <= f |
          *  |      |_________|      |
          *  |                       |
          *  |_______________________|
          */
        if (!c.FormisRunning<Home>())
            xy = new[] { (c.Home.Width / 2) - (f.Width / 2) + c.Home.Location.X,
                         c.Home.Top };
        /*   _______________________                   
          *  |       _________       |  <= Screen
          *  |      |         | <= f |
          *  |      |         |      |
          *  |      |_________|      |
          *  |_______________________|
          */
        else {
            var currentScreenRect = Screen.FromControl(f).WorkingArea;
            xy = new[] { (currentScreenRect.Width / 2) - (f.Width / 2) + currentScreenRect.Location.X,
                         (currentScreenRect.Height / 2) - (f.Height / 2) };
        }

        f.SetBounds(xy[0], xy[1], f.Width, f.Height);
    }
}
