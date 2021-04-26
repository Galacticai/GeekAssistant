using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeekAssistant.Forms {
    public partial class PleaseWait : Form {
        public PleaseWait() {
            InitializeComponent();
        }

        private void AssignEvents() {
            FormClosing += new(PleaseWait_FormClosing);
            Closed += new(PleaseWait_Closed);
            StopProcess_Button.Click += new(StopProcess_Button_Click);
        }

        private void PleaseWait_MainEnabled(bool b) {
            c.Home.AutoDetectDeviceInfo_Button.Enabled = b;
            c.Home.SwitchTheme_Button.Enabled = b;
            c.Home.Settings_Button.Enabled = b;
            c.Home.About_Button.Enabled = b;
            c.Home.Feedback_Button.Enabled = b;
            c.Home.Donate_Button.Enabled = b;
        }

        public bool UserClosing = true; //lock to true by default
        private void PleaseWait_FormClosing(object sender, FormClosingEventArgs ev) {
            if (UserClosing | ev.CloseReason == CloseReason.WindowsShutDown) { //Prevent shutdown while working //Block user closing the form
                ev.Cancel = true;
                return;
            } else {
                UserClosing = true; //reset for next use
                Close();
            }
        }
        private void PleaseWait_Closed(object sender, EventArgs e) {
            PleaseWait_MainEnabled(true);
        }

        private void PleaseWait_Load(object sender, EventArgs e) {
            AssignEvents();
            GA_SetTheme.Run(Name);
            //24, 97 
            var titleHeight = c.Home.RectangleToScreen(c.Home.ClientRectangle).Top - c.Home.Top;
            SetBounds(c.Home.Location.X + 24, c.Home.Location.Y + 97 + titleHeight, Width, Height);

            PleaseWait_MainEnabled(false);

            PleaseWait_text.Text = txt.RandomWorkText();
        }

        private void StopProcess_Button_Click(object sender, EventArgs e) {

            if (GA_infoAsk.Run("Stop current process",
                              $"Be careful! This leads to unexpected results.\n" +
                                $"Are you sure you want to stop the running process?\n\n\n" +
                                $"This will also stop all adb and fastboot processes that are currently running!",
                              "Stop Now!", "Return")) {

                Managed.Adb.AndroidDebugBridge.Terminate();
                var p_adb_arr = Process.GetProcessesByName("adb");
                if (p_adb_arr.Count() > 0) {
                    foreach (Process p_adb in p_adb_arr)
                        p_adb.Kill();
                }

                var p_fb_arr = Process.GetProcessesByName("fastboot");
                if (p_fb_arr.Count() > 0) {
                    foreach (Process p_fb in p_fb_arr)
                        p_fb.Kill();
                }
            }
            Close();
        }
    }
}
