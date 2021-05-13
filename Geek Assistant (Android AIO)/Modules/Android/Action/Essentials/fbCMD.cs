using System.Diagnostics;
using System.Linq;

internal static partial class fbCMD {
    private readonly static Process fb_process = new Process();
    public static string fbOutput;
    /// <summary>
    /// Sends a command to $"{GA_tools}\fastboot.exe" and waits for process output
    /// Do not include "fastboot" in the arguments parameter
    /// </summary>
    /// <param name="arguments">fastboot command arguments</param>
    /// <returns>Output of a fastboot command As String + fbOutput public string (to avoid repeating command for the same output)</returns>
    public static string fbDo(string arguments) {
        // >Failsafe - Should never happen
        if (arguments.Length == 0) {
            inf.detail.code = $"{inf.detail.code}-fbDo0"; // error code (last process) - fbDo 0 (no arguments)
            inf.Run(inf.lvls.FatalError, inf.currentTitle, "Unable to run the fastboot command.");
        }

        if (!ConnectionIsCompatible.fbIsReady(txt.GA_GetErrorInitials())) {
            inf.detail.code = $"{inf.detail.code}-fbD0"; // error code (last process) - adb device 0 (no device)
            inf.Run(inf.detail.lvl, "Fastboot command", inf.detail.msg);
        }

        // kill all fastboot instances before starting a new one
        var processes = Process.GetProcessesByName("fastboot");
        if (processes.Count() > 0) {
            foreach (Process p in processes) {
                p.Kill();
            }
        }

        // <Failsafe
        var fb_p = fb_process.StartInfo;
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
        fb_process.Start();
        fb_process.WaitForExit();
        // Return output
        // //Return as global string (Use to avoid repeating command for output)
        fbOutput = fb_process.StandardOutput.ReadToEnd();
        // //Return as function (repeat command to return output)
        return fbOutput;
    }
}