using System;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.ExceptionServices;
using GeekAssistant.Forms;
using System.Diagnostics;
using System.Linq;

namespace GeekAssistant {
    static class RunGeekAssistant {
        public enum GA_ExitCode { Neutral = -1, Warn = 0, Error = 1, FatalError = 10 }

        public static void All_FormClosed(object sender, EventArgs e) {
            Environment.ExitCode = (int)GA_ExitCode.Neutral;

            if (Application.OpenForms.Count == 0) {
                if (Application.OpenForms.OfType<Wait>().Any()) { //Cancel if a process by GA is currently running
                    System.Media.SystemSounds.Beep.Play();
                    return;
                }

                if (HideAllForms.HiddenForms != null) return; //Cancel if hiding all forms

                try { // try to prevent crash when closed before starting Home
                    Log.LogEvent("End", 3);
                    Log.CreateLog();
                } catch { Environment.ExitCode = (int)GA_ExitCode.Warn; }

                c.S.Save();
                Environment.Exit(Environment.ExitCode); // Quit all threads  
                Process.GetCurrentProcess().Kill(); // Double hit...
            }
        }

        [STAThread]
        [HandleProcessCorruptedStateExceptions]
        private static void Main() {
            //Single Instance  
            if (!SingleInstance.Start($"{Application.ProductName}-{Application.ProductVersion}-{Application.CompanyName}"))
                return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new ToU().Show();
            Application.Run();
        }
    }
    public static class SingleInstance {
        static Mutex mutex;
        public static bool Start(string applicationIdentifier) {
            mutex = new(true, applicationIdentifier, out bool isSingleInstance);
            return isSingleInstance;
        }
        public static void Stop() => mutex.ReleaseMutex();

    }
}
