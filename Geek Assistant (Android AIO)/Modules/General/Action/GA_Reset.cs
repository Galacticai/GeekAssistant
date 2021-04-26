using GeekAssistant.Forms;
using System;
using System.IO;
using System.Windows.Forms;

internal static partial class GA_Reset {
    public static void Run(bool Data, bool logs) {
        c.ErrorInfo.code = "GAr-00";
        GA_Log.LogEvent("Reset Geek Assistant", 2);
        if (!GA_infoAsk.Run("Reset Geek Assistant", 
                              $"Are you sure you want to {Settings.willClear}?", 
                            "Continue", "Cancel")) {
            GA_Log.LogAppendText("Reset Geek Assistant Cancelled.", 1);
            return;
        }

        GA_Log.LogAppendText($"Resetting Geek Assistant... \n({Settings.willClear})", 1);
        try {
            string notify = "Process Complete. ";
            if (Data) {
                c.ErrorInfo.code = "GAr-S"; // GA reset - Settings
                c.S.Reset();
                c.S.Save();
                notify += $"\nDo you want to relaunch Geek Assistant?\n\n\n" + "⚠ Warning: Relaunching will recreate some files needed to run Geek Assistant.";
            }

            if (logs) {
                c.ErrorInfo.code = "GAr-L"; // GA reset - Logs
                if (Directory.Exists(c.GA_logs)) {
                    foreach (string foundName in Microsoft.VisualBasic.FileIO.FileSystem.GetFiles(c.GA_logs, Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.*")) {
                        if (File.Exists($@"{foundName}\*.*")) {
                            Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(foundName, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently);
                        }
                    }

                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(c.GA_logs, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently);
                }
            }

            GA_Log.LogAppendText(notify, 1);
            if (Data) {
                c.S.VerboseLoggingPrompt = false; // disable to avoid asking on exit
                if (GA_infoAsk.Run("Reset Geek Assistant", notify, "Relaunch", "Exit")) {
                    c.S.VerboseLoggingPrompt = true; // enable again (true is default)
                    Application.Restart();
                } else {
                    c.S.VerboseLoggingPrompt = true; // enable again (true is default)
                    Application.Exit();
                }
            } else MessageBox.Show(notify, "Reset Geek Assistant", MessageBoxButtons.OK, MessageBoxIcon.Information);

        } catch (Exception e) { GA_Msg.DoMsg(10, "Error while resetting.", 3, e.ToString()); }
         
    }
}