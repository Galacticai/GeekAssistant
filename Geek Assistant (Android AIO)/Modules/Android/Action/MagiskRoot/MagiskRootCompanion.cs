using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

internal class MagiskRootCompanion {
    /*
        // name: "Magisk-${json.version}(${json.versionCode})"
        // SDK: >= 26
        // latest json full: https://api.github.com/repos/topjohnwu/Magisk/releases/latest
        // // latest json asset url: https://api.github.com/repos/topjohnwu/Magisk/releases/assets/36837876
        // // // url line regex: "browser_download_url": "https://github.com/topjohnwu/Magisk/releases/download/\w+\.\w+/Magisk-v\w+\.\w+\.apk"
   
    // latest stable: https://raw.githubusercontent.com/topjohnwu/magisk-files/master/stable.json
 */

    private static long _Download_MagiskAPK_Progress;
    public static long Download_MagiskAPK_Progress {
        get => _Download_MagiskAPK_Progress;
        set {
            value = (long)math.Arithmatics.ForcedInRange(value, 0, 100);
            _Download_MagiskAPK_Progress = value;
        }
    }
    /// <summary> Download latest Magisk apk and provide the <see cref="FileStream"/></summary>
    /// <param name="branch"></param>
    /// <returns></returns>
    public static async Task<FileStream> Download_MagiskAPK
                (LatestMagiskAsset.IMagiskBranch branch
                    = LatestMagiskAsset.IMagiskBranch.stable) {

        WebClient webClient = new();
        LatestMagiskAsset magisk = new LatestMagiskAsset().Instance(webClient, branch);

        string apk = @$"{c.GA_tools}\Magisk-v{magisk.version}.apk",
           apkPart = apk + ".part";

        if (File.Exists(apkPart)) {
            if (new FileInfo(apkPart).Length == magisk.apk_size) {
                File.Move(apkPart, apk, true); // set to real name  
                goto FileReady;
            } else File.Delete(apkPart);
        }
        if (File.Exists(apk)) {
            if (new FileInfo(apk).Length == magisk.apk_size)
                goto FileReady;
            else File.Delete(apk);
        }
        if (!Directory.Exists(c.GA_tools))
            GA_PrepareAppdata.Run();

        webClient.DownloadProgressChanged += (sender, args) => {
            Download_MagiskAPK_Progress = (new FileInfo(apk).Length / magisk.apk_size) * 100;
            //todo: more action (gui)
        };
        webClient.DownloadFileCompleted += (sender, args) => {
            Download_MagiskAPK_Progress = 100;
            File.Move(apkPart, apk, true); // set to real name 
        };
        // Events before task
        await Task.Run(() => webClient.DownloadFileAsync(magisk.apk_link, apkPart));

        //File is ready
        FileReady:;
        return File.OpenRead(apk);
    }
}