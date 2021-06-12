using System.Diagnostics;
using GeekAssistant.Modules.Global;
using GeekAssistant.Modules.Global.Companion;

namespace GeekAssistant.Modules.Android.Companion.Essentials {
    internal static class adb {
        /// <summary> 
        /// Sends a command to $"{GA_tools}\adb.exe" and waits for process output
        /// Do not include "adb" in the arguments parameter
        /// </summary>
        /// <param name="arguments">adb command arguments</param>
        /// <returns>Output of a adb command As String + adbOutput public string (to avoid repeating command for the same output)</returns>
        public static string Run(string arguments, Process adbProcess = null) {
            adbProcess ??= new();
            // >Failsafe - Should never happen
            if (string.IsNullOrEmpty(arguments)) {
                inf.detail.code += "-adbA0"; // (current workCode) - adb Arguments 0 (no arguments)
                inf.Run(inf.lvls.FatalError, inf.detail.title, "Unable to run the adb command.");
            }

            // If Not adbIsReady(txt.GA_GetErrorInitials) Then
            // ErrorCodeTrack($"{S.ErrorCode}-adbD0") ' error code (last process) - adb device 0 (no device)
            // DoMsg(ErrorInfo.lvl, ErrorInfo.msg, 2)
            // End If
            // Inform if not running  
            if (Process.GetProcessesByName("adb").Length == 0)
                SetProgressText.Run(txt.RandomWorkText, inf.lvls.Information);

            // <Failsafe
            {
                var adbPstartInfo = adbProcess.StartInfo;
                adbPstartInfo.FileName = $@"{c.GA_tools}\adb.exe";
                adbPstartInfo.Arguments = arguments;
                adbPstartInfo.UseShellExecute = false;
                adbPstartInfo.CreateNoWindow = true;
                adbPstartInfo.RedirectStandardOutput = true;
                adbPstartInfo.RedirectStandardInput = true;
                adbPstartInfo.RedirectStandardError = true;
            }
            // Start
            adbProcess.Start();
            adbProcess.WaitForExit();
            // Return as global string (avoid repeating command for output) 
            return adbProcess.StandardOutput.ReadToEnd();
        }
    }
}
