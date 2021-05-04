using Eto.Forms;
using System;

namespace GeekAssistant_CrossPlatform_Test.Gtk {
    class MainClass {
        [STAThread]
        public static void Main(string[] args) {
            new Application(Eto.Platforms.Gtk).Run(new MainForm());
        }
    }
}
