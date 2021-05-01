using System;
using System.Diagnostics;
using System.Windows.Forms;
using GeekAssistant.Forms;

namespace GeekAssistant {
    static class RunGeekAssistant {
        private static void AssignEvents() {
            //FormClosed event for all forms
            FormClosedEventHandler ev_FormClosed = new(ev_FormClosed_Run);
            EventHandler ev_Load = new(ev_Load_Run);
            //c.PleaseWait.FormClosed += new(ev_FormClosed_Run);
            //c.Preparing.FormClosed += new(ev_FormClosed_Run);
            //c.AppMode.FormClosed += new(ev_FormClosed_Run);
            //c.Donate.FormClosed += new(ev_FormClosed_Run);
            //c.Home.FormClosed += new(ev_FormClosed_Run);
            //c.Info.FormClosed += new(ev_FormClosed_Run);
            //c.Settings.FormClosed += new(ev_FormClosed_Run);
            //c.ToU.FormClosed += new(ev_FormClosed_Run);
            foreach (var f in c.AllForms) {
                f.FormClosed += ev_FormClosed;
                f.Load += ev_Load;
            }
        }
        private static void ev_FormClosed_Run(object sender, EventArgs e) {
            //>>>>> IF YOU STOP AT THIS then it worked
            if (Application.OpenForms.Count == 0) Environment.Exit(0);  //Ensure GA exits when all forms have closed
        }
        private static void ev_Load_Run(object sender, EventArgs e) {
            //forgot why i made this
        }

        [STAThread]
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
        private static void Main() {
            //Single Instance 
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1) return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ToU ToU = new ToU();
            ToU.Show();
            Application.Run();

            //AssignEvents();
        }
    }
}
