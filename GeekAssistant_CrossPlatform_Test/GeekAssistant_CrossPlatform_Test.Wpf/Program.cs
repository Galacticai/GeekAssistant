using Eto.Forms;
using System;

namespace GeekAssistant_CrossPlatform_Test.Wpf {
    class MainClass {
        [STAThread]
        public static void Main(string[] args) {
            new Application(Eto.Platforms.Wpf).Run(new MainForm());
        }
    }
}
