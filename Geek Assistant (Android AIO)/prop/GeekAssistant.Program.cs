using System;
using System.Diagnostics; 
using System.Windows.Forms;

namespace GeekAssistant {
    static class Program { 
        private static void AssignEvents() {
            //FormClosed event for all forms
            FormClosedEventHandler ev_FormClosed = new(ev_FormClosed_Run);
            EventHandler ev_Load = new(ev_Load_Run);
            foreach (Form f in c.AllForms) {
                f.FormClosed += ev_FormClosed;
                f.Load += ev_Load;
            } 
        }
        private static void ev_FormClosed_Run(object sender, System.EventArgs e) {
            if (Application.OpenForms.Count == 0) Application.Exit();  //Ensure GA exits when all forms have closed
        }
        private static void ev_Load_Run(object sender, EventArgs e) {
            //forgot why i made this
        }

        private static void Main() {
            //Single Instance
            int instanceCount = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length;
            if (instanceCount > 1) return; 
              
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);  
            c.ToU().Show(); 
            Application.Run();
             
            AssignEvents();
        }
    }
}
