using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace GeekAssistant.Forms {
    public partial class Wait : Form {
        public Wait() {
            InitializeComponent();
        }

        private void AssignEvents() {
            FormClosing += new(Wait_FormClosing);
            Closed += new(Wait_Closed);
            StopProcess_Button.Click += new(StopProcess_Button_Click);
        }

        private void Wait_MainEnabled(bool b) {
            Home Home = null;
            foreach (Form home in Application.OpenForms) {
                if (home.GetType() == typeof(Home)) {
                    Home = (Home)home;
                }
            }

            if (Home == null) {
                inf.Run(($"{inf.detail.code}-W-HX", /* (code) - Wait - Home null*/
                         inf.lvls.FatalError, "Something went wrong...",
                         "Couldn't find the required instance to control", $"{nameof(Wait)} : NullReferenceException"));
            }

            Home.AutoDetectDeviceInfo_Button.Enabled = b;
            Home.SwitchTheme_Button.Enabled = b;
            Home.Settings_Button.Enabled = b;
            Home.About_Button.Enabled = b;
            Home.Feedback_Button.Enabled = b;
            Home.Donate_Button.Enabled = b;
        }
        /// <summary> Prevent closing unless unflagged in code </summary>
        public bool UserClosing = true; //lock to true by default
        private void Wait_FormClosing(object sender, FormClosingEventArgs ev) {
            if (UserClosing | ev.CloseReason == CloseReason.WindowsShutDown) { //Prevent shutdown while working //Block user closing the form
                ev.Cancel = true;
                return;
            } else {
                UserClosing = true; //reset for next use
                Wait_MainEnabled(true);
                Hide();
            }
        }
        private void Wait_Closed(object sender, EventArgs e) {
            Wait_MainEnabled(true);
        }
        private void Wait_Load(object sender, EventArgs e) {
            AssignEvents();
            GA_SetTheme.Run(this);
            Home h = (Home)Application.OpenForms["Home"];
            //24, 97    
            var titleHeight = h.RectangleToScreen(h.ClientRectangle).Top - h.Top;
            SetBounds(h.Location.X + 24, h.Location.Y + 97 + titleHeight, Width, Height);

            Wait_MainEnabled(false);

            Wait_text.Text = txt.RandomWorkText();
        }

        private void StopProcess_Button_Click(object sender, EventArgs e) {

            if (inf.Run(inf.lvls.Question, "Stop current process",
                          $"Be careful! This leads to unexpected results.\n" +
                          $"Are you sure you want to stop the running process?\n\n\n" +
                          $"This will also stop all adb and fastboot processes that are currently running!",
                        ("Stop Now!", "Return"))) {

                Managed.Adb.AndroidDebugBridge.Terminate();
                var p_adb_arr = Process.GetProcessesByName("adb");
                if (p_adb_arr.Count() > 0) {
                    foreach (Process p_adb in p_adb_arr) {
                        p_adb.Kill();
                    }
                }

                var p_fb_arr = Process.GetProcessesByName("fastboot");
                if (p_fb_arr.Count() > 0) {
                    foreach (Process p_fb in p_fb_arr) {
                        p_fb.Kill();
                    }
                }
            }
            Close();
        }
    }
}
