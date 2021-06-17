
using System.Diagnostics;
using System.Threading.Tasks;
using GeekAssistant.Modules.General;

namespace GeekAssistant.Modules.Android.Companion.Essentials {
    internal static class fastboot {
        /// <summary>
        /// Sends a command to $"{GA_tools}\fastboot.exe" and waits for process output
        /// Do not include "fastboot" in the arguments parameter
        /// </summary>
        /// <param name="arguments">fastboot command arguments</param>
        /// <returns>Output of a fastboot command As String + fbOutput public string (to avoid repeating command for the same output)</returns>
        public static async Task<string> Run(string arguments, Process fbProcess = null) {
            fbProcess ??= new();

            // >Failsafe - Should never happen
            if (string.IsNullOrEmpty(arguments)) {
                inf.detail.code += "-fbA0"; // (current workCode) - fastboot Arguments 0 (no arguments)
                inf.Run(inf.lvls.FatalError, inf.detail.title, "Unable to run the fastboot command.");
            }

            if (!(await devConnection.fbIsReady())) {
                inf.detail.code += "-fbD0"; // error code (last process) - adb device 0 (no device)
                inf.Run(inf.detail.lvl, "Fastboot command", inf.detail.msg);
            }

            // kill all fastboot instances before starting a new one
            {
                Process[] processes = Process.GetProcessesByName("fastboot");
                if (processes.Length > 0)
                    foreach (Process p in processes) p.Kill();
            }
            // <Failsafe
            var fb_p = fbProcess.StartInfo;
            {
                fb_p.FileName = $@"{c.GA_tools}\fastboot.exe";
                fb_p.Arguments = arguments;
                fb_p.UseShellExecute = false;
                fb_p.CreateNoWindow = true;
                fb_p.RedirectStandardOutput = true;
                fb_p.RedirectStandardInput = true;
                fb_p.RedirectStandardError = true;
            }
            // Start 
            await Task.Run(() => {
                fbProcess.Start();
                fbProcess.WaitForExit();
            });
            // Return as global string (avoid repeating command for output) 
            return fbProcess.StandardOutput.ReadToEnd();
        }
    }
}
