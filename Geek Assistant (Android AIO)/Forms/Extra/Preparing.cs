using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace GeekAssistant.Forms {
    public partial class Preparing : Form {
        public Preparing() {
            InitializeComponent();
        }
        private void AssignEvents() {
            CheckADBProcess_Timer.Tick += CheckADBProcess_Timer_Tick;
        }
        private Timer CheckADBProcess_Timer = new() { Interval = 100 };
        private void Preparing_Load(object sender, EventArgs e) {
            AssignEvents();
            GA_SetTheme.Run(Name, true);
            Preparing_Label.Text = txt.RandomWorkText();
            CheckADBProcess_Timer.Enabled = true;
        }
        private void CheckADBProcess_Timer_Tick(object sender, EventArgs e) {
            if (Process.GetProcessesByName("adb").Count() > 0) {
                CheckADBProcess_Timer.Enabled = false;
                common.Home.Show();
                Dispose();
            }
        }
    }
}
