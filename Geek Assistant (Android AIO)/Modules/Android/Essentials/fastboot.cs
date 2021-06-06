using System;
using System.Diagnostics;
using System.Linq;

internal static partial class fastboot {
    public static string fbOutput;
    /// <summary>
    /// Sends a command to $"{GA_tools}\fastboot.exe" and waits for process output
    /// Do not include "fastboot" in the arguments parameter
    /// </summary>
    /// <param name="arguments">fastboot command arguments</param>
    /// <returns>Output of a fastboot command As String + fbOutput public string (to avoid repeating command for the same output)</returns>
    public static string Run(string arguments, Process fbProcess = null) {
        fbProcess ??= new();

        // >Failsafe - Should never happen
        if (string.IsNullOrEmpty(arguments)) {
            inf.detail.workCode = $"{inf.detail.workCode}-fbDo0"; // error code (last process) - fbDo 0 (no arguments)
            inf.Run(inf.lvls.FatalError, inf.workTitle, "Unable to run the fastboot command.");
        }

        if (!devConnection.fbIsReady()) {
            inf.detail.workCode = $"{inf.detail.workCode}-fbD0"; // error code (last process) - adb device 0 (no device)
            inf.Run(inf.detail.lvl, "Fastboot command", inf.detail.msg);
        }

        // kill all fastboot instances before starting a new one
        var processes = Process.GetProcessesByName("fastboot");
        if (processes.Length > 0)
            foreach (Process p in processes) p.Kill();

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
        fbProcess.Start();
        fbProcess.WaitForExit();
        // Return as global string (avoid repeating command for output) 
        return fbOutput = fbProcess.StandardOutput.ReadToEnd();
    }
}