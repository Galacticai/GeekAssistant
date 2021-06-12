using Managed.Adb;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using GeekAssistant.Modules.Global;
using GeekAssistant.Modules.Global.Companion;
using GeekAssistant.Modules.Android.Companion;
using GeekAssistant.Modules.Android.Companion.Essentials;

namespace GeekAssistant.Modules.Android {
    internal static class cmd {
        public static async Task<string> madbShell(Device dev, string cmd, bool sudo = false) {
            if (devConnection.adbIsReady()) inf.Run();

            await madb.madbBridge(); // failsafe
            CommandResultReceiver crr = new();
            if (sudo) dev.ExecuteRootShellCommand(cmd, crr);
            else dev.ExecuteShellCommand(cmd, crr);

            return crr.Result;
        }
        public static void Run(string command) {
            // If command has no arguments: cancel (invalidCMD)
            if (command.IndexOf(" ") != -1) { invalidCMD(command); return; }

            // Matching example: "adb devices"
            Regex adbRegex = new("adb (help|devices|shell|push|pull|logcat|install|install-multiple|uninstall|sync|emu"
                                 + "|forward|reverse|jdwp|bugreport|backup|backup|restore|disable-verity|enable-verity|keygen|help|version"
                                 + "|wait-for-device|start-server|kill-server|get-state|get-serialno|get-devpath|remount|reboot|reboot-bootloader|root|unroot|usb|tcpip|ppp)"),
                   // Matching example: "fastboot devices" 
                   fbRegex = new("fastboot (help|devices|update|flashall|flash|flashing lock|flashing unlock|flashing lock_critical"
                                 + "|flashing get_unlock_ability|erase|format|getvar|boot)");


            if (adbRegex.Match(command).Success) { // If command matching adbRegex 
                string adbOut = adbDo_WithTrack(command[(command.IndexOf(" ") + 1)..]); // run command without "adb " 
                GeekAssistant.Modules.Global.log.AppendText($"⮜⮜ \"{command}\"{c.n}" +
                                  $"{(string.IsNullOrEmpty(adbOut) ? "  Process finished with no response." : $"⮞⮞{c.n}{adbOut}")}", 2);

            } else if (fbRegex.Match(command).Success) { // If command matching fbRegex

                string fbOut = fbDo_WithTrack(command[(command.IndexOf(" ") + 1)..]); // run command without "fastboot "

                GeekAssistant.Modules.Global.log.AppendText($"⮜⮜ \"{command}\"{c.n}" +
                                  $"{(string.IsNullOrEmpty(fbOut) ? "  Process finished with no response." : $"⮞⮞{c.n}{fbOut}")}", 2);
            } else invalidCMD(command);

        }
        private static void invalidCMD(string command) {
            System.Media.SystemSounds.Beep.Play();
            string invalid_text = $"⮜⮜ {command}{c.n}⮞⮞ ⚠  Invalid Command.{c.n}Please use a valid adb or fastboot command";
            if (command.Contains("adb") && command.Contains("fastboot")) {
                invalid_text = $"⮜⮜ {command}{c.n}⮞⮞ ⚠  Invalid adb Or fastboot command.{c.n}";
                goto Skip_commandContains;
            }

            if (command.Contains("adb"))
                invalid_text = $"⮜⮜ {command}{c.n}⮞⮞ ⚠  Invalid adb command.{c.n}" + $"Allowed adb arguments:{c.n}" + "help | devices | shell | push | pull | logcat | install | install-multiple | uninstall | sync | emu | forward | reverse | jdwp | bugreport | backup | backup | restore | disable-verity | enable-verity | keygen | help | version | wait-for-device | start-server | kill-server | get-state | get-serialno | get-devpath | remount | reboot | reboot-bootloader | root | unroot | usb | tcpip | ppp";
            else if (command.Contains("fastboot"))
                invalid_text = $"⮜⮜ {command}{c.n}⮞⮞ ⚠  Invalid fastboot command.{c.n}" + $"Allowed fastboot arguments:{c.n}" + "help | update | flashall | flash | flashing lock | flashing unlock | flashing lock_critical | flashing get_unlock_ability | erase | format | getvar | boot";

            Skip_commandContains:;

            GeekAssistant.Modules.Global.log.AppendText(invalid_text, 2);
        }
        private static string adbDo_WithTrack(string command) {
            inf.detail.code = $"{txt.GA_current_workCode}-adb-cmd"; // (workCode) - adb - cmd
            return adb.Run(command);
        }

        private static string fbDo_WithTrack(string command) {
            inf.detail.code = $"{txt.GA_current_workCode}-fb-cmd"; // (workCode) - fastboot - cmd
            return fastboot.Run(command);
        }
    }
}
