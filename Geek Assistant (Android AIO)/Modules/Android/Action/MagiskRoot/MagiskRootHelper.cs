﻿using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

internal class MagiskRootHelper {
    /*
        // name: "Magisk-${json.version}(${json.versionCode})"
        // SDK: >= 26
        // latest json full: https://api.github.com/repos/topjohnwu/Magisk/releases/latest
        // // latest json asset url: https://api.github.com/repos/topjohnwu/Magisk/releases/assets/36837876
        // // // url line regex: "browser_download_url": "https://github.com/topjohnwu/Magisk/releases/download/\w+\.\w+/Magisk-v\w+\.\w+\.apk"
   
    // latest stable: https://raw.githubusercontent.com/topjohnwu/magisk-files/master/stable.json
 */
    //public static async Task<string> LatestAssets_jsonRaw()
    //    => await Task.Run(
    //            () => new WebClient().DownloadString("https://api.github.com/repos/topjohnwu/Magisk/releases/latest")
    //       );
    //public static string LatestAssets_jsonRaw_string
    //    => LatestAssets_jsonRaw().Result.ToString();

    //public static string[] LatestAssets_LineArr
    //    => convert.String.ToLineArr(LatestAssets_jsonRaw_string);

    //public static int MagiskAPK_urlLineIndex {
    //    get {
    //        string urlLineRegex = new("\"browser_download_url\": \"" +
    //                                  "https://github.com/topjohnwu/Magisk/releases/download/\\w+\\.\\w+/Magisk-v\\w+\\.\\w+\\.apk\"");
    //        int urlLineIndex = -1;
    //        string[] lines = LatestAssets_LineArr;
    //        for (int i = 0; i <= lines.Length - 1; i++)
    //            if (Regex.IsMatch(lines[i], urlLineRegex, RegexOptions.IgnoreCase)) {
    //                urlLineIndex = i;
    //                break;
    //            }
    //        return urlLineIndex;
    //    }
    //}

    //public static string MagiskAPK_url_Line
    //    => LatestAssets_LineArr[MagiskAPK_urlLineIndex];
    //public static Uri MagiskAPK_uri {
    //    get {
    //        string line = MagiskAPK_url_Line;
    //        return new Uri(line[line.IndexOf("https://") /* link start */
    //                            ..(line.Length - 1 /* before ending """ */ - 1) /* compensate for counting from 0 */
    //                           ], UriKind.Absolute);
    //    }
    //}

    //public static string MagiskAPK_size_Line
    //    => LatestAssets_LineArr[MagiskAPK_urlLineIndex - 4];
    //public static long MagiskAPK_size {
    //    get {
    //        // ""size": 6874374," 
    //        string line = MagiskAPK_size_Line;
    //        return Convert.ToInt64(line[
    //                                 (line.IndexOf(": ") + 2) /* after ": " */
    //                                 ..(line.Length - 1 /* before ending "," */ - 1) /* compensate for counting from 0 */
    //                               ]);
    //        // "6874374" 
    //    }
    //}

    //public static string MagiskAPK_version {
    //    get {
    //        // "...../download/v23.0/Magisk-....." 
    //        string line = MagiskAPK_url_Line;
    //        return line[(line.IndexOf("/download/") + 10) /* after "/download/" */
    //                     ..(line.IndexOf("/Magisk-") - 1 /* before "/Magisk" */ - 1) /* compensate for counting from 0 */
    //                   ];
    //    }
    //}
    //public static (int major, int minor) MagiskAPK_Version_inf {
    //    get {
    //        // "v23.0" 
    //        string version = MagiskAPK_version;
    //        int major = Convert.ToInt32(version[1..version.IndexOf(".")]), // "v>>23<<.0" 
    //            minor = Convert.ToInt32(version[version.IndexOf(".") + 1]); // "v23.>>0>>" 
    //        return (major, minor);
    //    }
    //}


    private static long _Download_MagiskAPK_Progress;
    public static long Download_MagiskAPK_Progress {
        get => _Download_MagiskAPK_Progress;
        set {
            value = (long)math.Arithmatics.ForcedInRange(value, 0, 100);
            _Download_MagiskAPK_Progress = value;
        }
    }

    public static async Task Download_MagiskAPK() {
        string apk = @$"{c.GA_tools}\Magisk-{MagiskAPK_version}.apk",
               apkPart = $"{apk}.part";

        if (File.Exists(apkPart)) {
            if (new FileInfo(apkPart).Length == MagiskAPK_size) {
                File.Move(apkPart, apk, true); // set to real name  
                return;
            } else File.Delete(apkPart);
        }
        if (File.Exists(apk)) {
            if (new FileInfo(apk).Length == MagiskAPK_size)
                return;
            else File.Delete(apk);
        }
        if (!Directory.Exists(c.GA_tools))
            GA_PrepareAppdata.Run();


        WebClient web = new();

        web.DownloadProgressChanged += (sender, args) => {
            Download_MagiskAPK_Progress = (new FileInfo(apk).Length / MagiskAPK_size) * 100;
            //todo: more action
        };

        web.DownloadFileCompleted += (sender, args) => {
            Download_MagiskAPK_Progress = 100;
            File.Move(apkPart, apk, true); // set to real name 
        };

        //set events before awaiting task
        await Task.Run(() => web.DownloadFileAsync(MagiskAPK_uri, apkPart));
    }
}

/* Example 2
{
  "magisk": {
    "version": "23.0",
    "versionCode": "23000",
    "link": "https://cdn.jsdelivr.net/gh/topjohnwu/magisk-files@23.0/app-release.apk",
    "note": "https://topjohnwu.github.io/Magisk/releases/23000.md"
  },
  "stub": {
    "versionCode": "21",
    "link": "https://cdn.jsdelivr.net/gh/topjohnwu/magisk-files@23.0/stub-release.apk"
  }
}
 
 */

/// <summary> Latest Magisk Assets Manager</summary>
internal class MagiskAsset {
    /// <summary><list type="bullet">
    /// <item> 0 stable: "master/stable"</item>
    /// <item> 1 beta: "master/beta"</item>
    /// <item> 2 canary: "master/canary"</item>
    /// </list> </summary> 
    public enum IMagiskBranch { stable, beta, canary }
    private string MagiskBranch_string(IMagiskBranch branch)
        => branch switch {
            IMagiskBranch.beta => "master/beta",
            IMagiskBranch.canary => "master/canary",
            _ => "master/stable",
        };
    /// <returns> Latest magisk asset .json link according to <paramref name="branch"/></returns> 
    /// <param name="branch"><list type="bullet">
    /// <item> 0 stable: "master/stable"</item>
    /// <item> 1 beta: "master/beta"</item>
    /// <item> 2 canary: "master/canary"</item>
    /// </list> </param>
    public string Magisk_Asset_link(IMagiskBranch branch)
        => "https://raw.githubusercontent.com/topjohnwu/magisk-files/" + MagiskBranch_string(branch) + ".json";

    public async Task<string> Download_Magisk_Asset_jsonRaw(IMagiskBranch branch)
        => await Task.Run(() => new WebClient().DownloadString(Magisk_Asset_link(branch)));

    public static string LatestAssets_jsonRaw_string
        => LatestAssets_jsonRaw().Result.ToString();

    public JObject json;
    public MagiskAsset Instance() {

        return new MagiskAsset {

        };
    }
}

//Example raw json

/*  
{
    "url": "https://api.github.com/repos/topjohnwu/Magisk/releases/42815075",
  "assets_url": "https://api.github.com/repos/topjohnwu/Magisk/releases/42815075/assets",
  "upload_url": "https://uploads.github.com/repos/topjohnwu/Magisk/releases/42815075/assets{?name,label}",
  "html_url": "https://github.com/topjohnwu/Magisk/releases/tag/v23.0",
  "id": 42815075,
  "author": {
        "login": "topjohnwu",
    "id": 7337301,
    "node_id": "MDQ6VXNlcjczMzczMDE=",
    "avatar_url": "https://avatars.githubusercontent.com/u/7337301?v=4",
    "gravatar_id": "",
    "url": "https://api.github.com/users/topjohnwu",
    "html_url": "https://github.com/topjohnwu",
    "followers_url": "https://api.github.com/users/topjohnwu/followers",
    "following_url": "https://api.github.com/users/topjohnwu/following{/other_user}",
    "gists_url": "https://api.github.com/users/topjohnwu/gists{/gist_id}",
    "starred_url": "https://api.github.com/users/topjohnwu/starred{/owner}{/repo}",
    "subscriptions_url": "https://api.github.com/users/topjohnwu/subscriptions",
    "organizations_url": "https://api.github.com/users/topjohnwu/orgs",
    "repos_url": "https://api.github.com/users/topjohnwu/repos",
    "events_url": "https://api.github.com/users/topjohnwu/events{/privacy}",
    "received_events_url": "https://api.github.com/users/topjohnwu/received_events",
    "type": "User",
    "site_admin": false
  },
  "node_id": "MDc6UmVsZWFzZTQyODE1MDc1",
  "tag_name": "v23.0",
  "target_commitish": "97c1e181c5a96217021d96bcdc4d4e31fbfce2ac",
  "name": "Magisk v23.0",
  "draft": false,
  "prerelease": false,
  "created_at": "2021-05-12T04:47:46Z",
  "published_at": "2021-05-12T05:29:46Z",
  "assets": [
    {
        "url": "https://api.github.com/repos/topjohnwu/Magisk/releases/assets/36837876",
      "id": 36837876,
      "node_id": "MDEyOlJlbGVhc2VBc3NldDM2ODM3ODc2",
      "name": "Magisk-v23.0.apk",
      "label": null,
      "uploader": {
            "login": "topjohnwu",
        "id": 7337301,
        "node_id": "MDQ6VXNlcjczMzczMDE=",
        "avatar_url": "https://avatars.githubusercontent.com/u/7337301?v=4",
        "gravatar_id": "",
        "url": "https://api.github.com/users/topjohnwu",
        "html_url": "https://github.com/topjohnwu",
        "followers_url": "https://api.github.com/users/topjohnwu/followers",
        "following_url": "https://api.github.com/users/topjohnwu/following{/other_user}",
        "gists_url": "https://api.github.com/users/topjohnwu/gists{/gist_id}",
        "starred_url": "https://api.github.com/users/topjohnwu/starred{/owner}{/repo}",
        "subscriptions_url": "https://api.github.com/users/topjohnwu/subscriptions",
        "organizations_url": "https://api.github.com/users/topjohnwu/orgs",
        "repos_url": "https://api.github.com/users/topjohnwu/repos",
        "events_url": "https://api.github.com/users/topjohnwu/events{/privacy}",
        "received_events_url": "https://api.github.com/users/topjohnwu/received_events",
        "type": "User",
        "site_admin": false
      },
      "content_type": "application/vnd.android.package-archive",
      "state": "uploaded",
      "size": 6874374,
      "download_count": 272793,
      "created_at": "2021-05-12T05:29:19Z",
      "updated_at": "2021-05-12T05:29:46Z",
      "browser_download_url": "https://github.com/topjohnwu/Magisk/releases/download/v23.0/Magisk-v23.0.apk"
    },
    {
        "url": "https://api.github.com/repos/topjohnwu/Magisk/releases/assets/36837881",
      "id": 36837881,
      "node_id": "MDEyOlJlbGVhc2VBc3NldDM2ODM3ODgx",
      "name": "snet.jar",
      "label": null,
      "uploader": {
            "login": "topjohnwu",
        "id": 7337301,
        "node_id": "MDQ6VXNlcjczMzczMDE=",
        "avatar_url": "https://avatars.githubusercontent.com/u/7337301?v=4",
        "gravatar_id": "",
        "url": "https://api.github.com/users/topjohnwu",
        "html_url": "https://github.com/topjohnwu",
        "followers_url": "https://api.github.com/users/topjohnwu/followers",
        "following_url": "https://api.github.com/users/topjohnwu/following{/other_user}",
        "gists_url": "https://api.github.com/users/topjohnwu/gists{/gist_id}",
        "starred_url": "https://api.github.com/users/topjohnwu/starred{/owner}{/repo}",
        "subscriptions_url": "https://api.github.com/users/topjohnwu/subscriptions",
        "organizations_url": "https://api.github.com/users/topjohnwu/orgs",
        "repos_url": "https://api.github.com/users/topjohnwu/repos",
        "events_url": "https://api.github.com/users/topjohnwu/events{/privacy}",
        "received_events_url": "https://api.github.com/users/topjohnwu/received_events",
        "type": "User",
        "site_admin": false
      },
      "content_type": "application/java-archive",
      "state": "uploaded",
      "size": 57732,
      "download_count": 6476,
      "created_at": "2021-05-12T05:29:32Z",
      "updated_at": "2021-05-12T05:29:32Z",
      "browser_download_url": "https://github.com/topjohnwu/Magisk/releases/download/v23.0/snet.jar"
    },
    {
        "url": "https://api.github.com/repos/topjohnwu/Magisk/releases/assets/36837880",
      "id": 36837880,
      "node_id": "MDEyOlJlbGVhc2VBc3NldDM2ODM3ODgw",
      "name": "stub-release.apk",
      "label": null,
      "uploader": {
            "login": "topjohnwu",
        "id": 7337301,
        "node_id": "MDQ6VXNlcjczMzczMDE=",
        "avatar_url": "https://avatars.githubusercontent.com/u/7337301?v=4",
        "gravatar_id": "",
        "url": "https://api.github.com/users/topjohnwu",
        "html_url": "https://github.com/topjohnwu",
        "followers_url": "https://api.github.com/users/topjohnwu/followers",
        "following_url": "https://api.github.com/users/topjohnwu/following{/other_user}",
        "gists_url": "https://api.github.com/users/topjohnwu/gists{/gist_id}",
        "starred_url": "https://api.github.com/users/topjohnwu/starred{/owner}{/repo}",
        "subscriptions_url": "https://api.github.com/users/topjohnwu/subscriptions",
        "organizations_url": "https://api.github.com/users/topjohnwu/orgs",
        "repos_url": "https://api.github.com/users/topjohnwu/repos",
        "events_url": "https://api.github.com/users/topjohnwu/events{/privacy}",
        "received_events_url": "https://api.github.com/users/topjohnwu/received_events",
        "type": "User",
        "site_admin": false
      },
      "content_type": "application/vnd.android.package-archive",
      "state": "uploaded",
      "size": 29110,
      "download_count": 7786,
      "created_at": "2021-05-12T05:29:32Z",
      "updated_at": "2021-05-12T05:29:46Z",
      "browser_download_url": "https://github.com/topjohnwu/Magisk/releases/download/v23.0/stub-release.apk"
    }
  ],
  "tarball_url": "https://api.github.com/repos/topjohnwu/Magisk/tarball/v23.0",
  "zipball_url": "https://api.github.com/repos/topjohnwu/Magisk/zipball/v23.0",
  "body": "This release is focused on fixing regressions and bugs.\r\n\r\nNote: Magisk v22 is the last major version to support Jellybean and Kitkat. Magisk v23 only supports Android 5.0 and higher.\r\n\r\n### Bug Fixes\r\n\r\n- [App] Update snet extension. This fixes SafetyNet API errors.\r\n- [App] Fix a bug in the stub app that causes APK installation to fail\r\n- [App] Hide annoying errors in logs when hidden as stub\r\n- [App] Fix issues when patching ODIN tar files when the app is hidden\r\n- [General] Remove all pre Android 5.0 support\r\n- [General] Update BusyBox to use proper libc\r\n- [General] Fix C++ undefined behaviors\r\n- [General] Several `sepolicy.rule` copy/installation fixes\r\n- [MagiskPolicy] Remove unnecessary sepolicy rules\r\n- [MagiskHide] Update package and process name validation logic\r\n- [MagiskHide] Some changes that prevents zygote deadlock\r\n\r\n### Full Changelog: [here](https://topjohnwu.github.io/Magisk/changes.html)",
  "reactions": {
        "url": "https://api.github.com/repos/topjohnwu/Magisk/releases/42815075/reactions",
    "total_count": 7,
    "+1": 7,
    "-1": 0,
    "laugh": 0,
    "hooray": 0,
    "confused": 0,
    "heart": 0,
    "rocket": 0,
    "eyes": 0
  }
}
*/