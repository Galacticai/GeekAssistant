using System;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.ExceptionServices;
using GeekAssistant.Forms;
using System.Diagnostics;
using System.Linq;

namespace GeekAssistant {
    static class RunGeekAssistant {

        public static void All_FormClosed(object sender, EventArgs e) {
            //>>>>> IF YOU STOP AT THIS then it worked
            if (Application.OpenForms.Count == 0) {
                if (Application.OpenForms.OfType<Wait>().Any()) { //Cancel if a process by GA is currently running
                    System.Media.SystemSounds.Beep.Play();
                    return;
                }
                if (HideAllForms.HiddenForms != null) return; //Stop if hiding all forms
                try {
                    Log.LogEvent("End", 3);
                    Log.CreateLog();
                } catch { }
                c.S.Save();
                Environment.Exit(Environment.ExitCode);   //Quit all threads while closing
                Process.GetCurrentProcess().Kill(); //Kill Geek Assistant completely in case any thread was locking Environment.Exit
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
