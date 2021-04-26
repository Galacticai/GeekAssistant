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
            c.ErrorInfo.code = $"{c.ErrorInfo.code}-fbDo0"; // error code (last process) - fbDo 0 (no arguments)
            GA_Msg.DoMsg(10, "Unable to run the fastboot command.", 2);
        }

        if (!CheckConnectionIsCompatible.fbIsReady(txt.GA_GetErrorInitials())) {
            c.ErrorInfo.code = $"{c.ErrorInfo.code}-fbD0"; // error code (last process) - adb device 0 (no device)
            GA_Msg.DoMsg(c.ErrorInfo.lvl, c.ErrorInfo.msg, 2);
        }

        // kill all fastboot instances before starting a new one
        var processes = Process.GetProcessesByName("fastboot");
        if (processes.Count() > 0) {
            foreach (Process p in processes)
                p.Kill();
        }

        // <Failsafe
        {
            var withBlock = fb_process.StartInfo;
            withBlock.FileName = $@"{c.GA_tools}\fastboot.exe";
            withBlock.Arguments = arguments;
            withBlock.UseShellExecute = false;
            withBlock.CreateNoWindow = true;
            withBlock.RedirectStandardOutput = true;
            withBlock.RedirectStandardInput = true;
            withBlock.RedirectStandardError = true;
        }
        // Start
        fb_process.Start();
        fb_process.WaitForExit();
        // Return output
        // '''Return as global string (Use to avoid repeating command for output)
        fbOutput = fb_process.StandardOutput.ReadToEnd();
        // '''Return as function (repeat command to return output)
        return fbOutput;
    }
}