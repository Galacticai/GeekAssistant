using System.Diagnostics;
using System.Linq;

internal static partial class adbCMD {
    private readonly static Process adb_process = new Process();
    public static string adbOutput;
    /// <summary>
    /// >>>>>>>>>>>>>>>>> UPDATE THIS TO UTILIZE Managed.Managed.Adb.Device.ExecuteShellCommand
    /// 
    /// Sends a command to $"{GA_tools}\adb.exe" and waits for process output
    /// Do not include "adb" in the arguments parameter
    /// </summary>
    /// <param name="arguments">adb command arguments</param>
    /// <returns>Output of a adb command As String + adbOutput public string (to avoid repeating command for the same output)</returns>
    public static string adbDo(string arguments) {
        // >Failsafe - Should never happen
        if (arguments.Length == 0) {
            inf.detail.code = $"{inf.detail.code}-adbDo0"; // error code (last process) - adbDo 0 (no arguments)
            inf.Run(inf.lvls.FatalError, inf.currentTitle, "Unable to run the adb command.");
        }

        // If Not adbIsReady(txt.GA_GetErrorInitials) Then
        // ErrorCodeTrack($"{S.ErrorCode}-adbD0") ' error code (last process) - adb device 0 (no device)
        // DoMsg(ErrorInfo.lvl, ErrorInfo.msg, 2)
        // End If
        // Inform if not running  
        if (Process.GetProcessesByName("adb").Count() == 0) {
            GA_SetProgressText.Run(txt.RandomWorkText(), -1);
        }

        // <Failsafe
        {
            var adbPstartInfo = adb_process.StartInfo;
            adbPstartInfo.FileName = $@"{c.GA_tools}\adb.exe";
            adbPstartInfo.Arguments = arguments;
            adbPstartInfo.UseShellExecute = false;
            adbPstartInfo.CreateNoWindow = true;
            adbPstartInfo.RedirectStandardOutput = true;
            adbPstartInfo.RedirectStandardInput = true;
            adbPstartInfo.RedirectStandardError = true;
        }
        // Start
        adb_process.Start();
        adb_process.WaitForExit();

        // Return output
        // '''Return as global string (Use to avoid repeating command for output)
        adbOutput = adb_process.StandardOutput.ReadToEnd();
        // '''Return as function (repeat command to return output)
        return adbOutput;
    }
}