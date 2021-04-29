

using GeekAssistant.Forms;
using System.Windows.Forms;

namespace GeekAssistant {
    public static class GA_CenterToHomeBounds {
        public static void Run(Form f) { 
            Home h = (Home)Application.OpenForms[0];  
            f.SetBounds((h.Width / 2) - (f.Width / 2) + h.Location.X, h.Top, f.Width, f.Height);
        }
    }
}
