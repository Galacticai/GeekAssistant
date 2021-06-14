using System;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.ExceptionServices;
using GeekAssistant.Forms;
using GeekAssistant.Modules.General;

namespace GeekAssistant {
    class RunGeekAssistant {
        public enum GA_ExitCode {
            Neutral = -1,
            Warn = 0,
            Error = 1,
            FatalError = 10
        }

        public static void All_FormClosed(object sender, EventArgs e) {
            Environment.ExitCode = (int)GA_ExitCode.Neutral;

            if (Application.OpenForms.Count <= 1) { // 1 form closing or none remaining
                if (c.FormisRunning<Wait>()) { // Cancel if a process by GA is currently running
                    System.Media.SystemSounds.Beep.Play();
                    //todo: gui action in Wait.cs ?
                    return;
                }

                if (HideAllForms.HiddenForms != null) return; //Cancel if hiding all forms

                try { // try to prevent crash when closed before starting Home
                    log.Event("End", 3);
                    log.Create();
                } catch { Environment.ExitCode = (int)GA_ExitCode.Warn; }

                c.S.Save();
                Environment.Exit(Environment.ExitCode); // Quit all threads  
                //Process.GetCurrentProcess().Kill(); // Double hit... (is this really needed?...)
            }
        }

        [STAThread]
        [HandleProcessCorruptedStateExceptions]
        private static void Main() {
            //Single Instance  
            if (!OneInstance.Start($"{Application.ProductName}-{Application.ProductVersion}-{Application.CompanyName}"))
                return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ToU ToU = new();
            ToU.Show();
            Application.Run();
        }
    }
    public static class OneInstance {
        static Mutex mutex;
        public static void Stop() => mutex.ReleaseMutex();
        public static bool Start(string applicationIdentifier) {
            mutex = new(true, applicationIdentifier, out bool isSingleInstance);
            return isSingleInstance;
        }
    }
}
