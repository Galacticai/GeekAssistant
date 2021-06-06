using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Threading.Tasks;

/// <summary> Latest Magisk Assets Manager</summary>
internal class LatestMagiskAsset {
    /// <summary><list type="bullet">
    /// <item> 0 stable: "master/stable"</item>
    /// <item> 1 beta: "master/beta"</item>
    /// <item> 2 canary: "master/canary"</item>
    /// </list> </summary> 
    public enum IMagiskBranch { stable, beta, canary }
    private static string MagiskBranch_string(IMagiskBranch branch)
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
    public string Json_link { get; private set; }
    private string Update_Json_link(IMagiskBranch branch)
        => Json_link = $"https://raw.githubusercontent.com/topjohnwu/magisk-files/{MagiskBranch_string(branch)}.json";

    /// <summary> Magisk asset json structure as <see cref="string"/></summary>
    public string json_string { get; private set; }
    private async Task<string> Update_json_string(IMagiskBranch branch)
        => await Task.Run(() => json_string = new WebClient().DownloadString(Update_Json_link(branch)));

    /// <summary> Magisk asset json structure provided by <see cref="Newtonsoft.Json.Linq"/>.<see cref="JObject"/> </summary>
    public JObject json { get; private set; }
    private JObject Update_json(IMagiskBranch branch)
        => json = new(Update_json_string(branch));

    ///// <summary> Magisk apk version </summary>
    //public (int major, int minor) version { get; private set; }
    //private (int major, int minor) Update_version(IMagiskBranch branch, bool Update_Json = false) {
    //    // "23.0"
    //    string version_string = (string)(Update_Json ? Update_json(branch)["magisk"]["version"]
    //                                                 : json["magisk"]["version"]),
    //           // "23<<.0"
    //           major_string = version_string[..version_string.IndexOf(".")],
    //           // "23.>>0"
    //           minor_string = version_string[(version_string.IndexOf(".") + 1)..];

    //    return version = (Convert.ToInt32(major_string), Convert.ToInt32(minor_string));
    //}
    /// <summary> Magisk apk version as "XX.x" or (canary)"abc12345" </summary>
    public string version { get; private set; }
    private string Update_version(IMagiskBranch branch, bool Update_Json = false)
        // stable/beta "23.0" or canary "f822ca5b"
        => version = (string)(Update_Json ? Update_json(branch)["magisk"]["version"]
                                          : json["magisk"]["version"]);

    /// <summary> Magisk apk link as <see cref="string"/> </summary>
    public string apk_link_string { get; private set; }
    private string Update_apk_link_string(IMagiskBranch branch, bool Update_Json = false)
        => apk_link_string = (string)(Update_Json ? Update_json(branch)["magisk"]["link"]
                                                  : json["magisk"]["link"]);

    /// <summary> Magisk apk link as <see cref="Uri"/> </summary>
    public Uri apk_link { get; private set; }
    private Uri Update_apk_link(IMagiskBranch branch, bool Update_Json = false)
        => apk_link = new(Update_apk_link_string(branch, Update_Json));

    /// <summary> Magisk apk size in bytes</summary>
    public long apk_size { get; private set; }
    private long Update_apk_size(WebClient webClient, IMagiskBranch branch, bool Update_Json = false) {
        webClient.OpenRead(Update_apk_link(branch, Update_Json));
        return apk_size = Convert.ToInt64(webClient.ResponseHeaders["Content-Length"]);
    }

    ///// <summary> Magisk apk last modified as <see cref="DateTime"/></summary>
    //public DateTime apk_DateTime { get; private set; }
    //private DateTime Update_apk_DateTime(WebClient webClient, IMagiskBranch branch, bool Update_Json = false) {
    //    webClient.OpenRead(Update_apk_link(branch, Update_Json));
    //    return apk_DateTime = DateTime.Parse(webClient.ResponseHeaders["Last-Modified"]); //? Unknown format
    //}

    /// <param name="webClient"><see cref="WebClient"/> to be used | <see cref="null"/> = <see cref="new()"/></param>
    /// <param name="branch">Magisk Branch 
    /// <list type="bullet">
    /// <item> 0 stable: "master/stable"</item>
    /// <item> 1 beta: "master/beta"</item>
    /// <item> 2 canary: "master/canary"</item>
    /// </list> </param>
    /// <returns>Create and return an instance of <see cref="MagiskAsset"/></returns>
    public LatestMagiskAsset Instance(IMagiskBranch branch = IMagiskBranch.stable, WebClient webClient = null)
        => new() {
            json = Update_json(branch), //init First to Update all
            version = Update_version(branch),
            apk_link = Update_apk_link(branch),
            apk_size = Update_apk_size(webClient ?? new(), branch)
        };
}


/* Example asset-only .json
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


/*  Example full assets .json
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