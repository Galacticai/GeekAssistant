using System.Diagnostics; 
using System.Windows.Forms;

namespace GeekAssistant {
    static class Program { 
        private static void AssignEvents() {
            //FormClosed event for all forms
            FormClosedEventHandler ev_FormClosed = new(ev_FormClosed_Run);
            common.Preparing.FormClosed += ev_FormClosed;
            common.AppMode.FormClosed += ev_FormClosed;
            common.Home.FormClosed += ev_FormClosed;
            common.Donate.FormClosed += ev_FormClosed;
            common.Home.FormClosed += ev_FormClosed;
            common.Info.FormClosed += ev_FormClosed;
            common.Settings.FormClosed += ev_FormClosed;
            common.ToU.FormClosed += ev_FormClosed;
        }
        private static void ev_FormClosed_Run(object sender, System.EventArgs e) {
            if (Application.OpenForms.Count == 0) Application.Exit();  //Ensure GA exits when all forms have closed
        }
        private static void Main() {
            //Single Instance
            int instanceCount = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length;
            if (instanceCount > 1) return; 
              
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);  
            common.ToU.Show(); 
            Application.Run();
             
            AssignEvents();
        }
    }
}
