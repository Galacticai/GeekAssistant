using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Threading.Tasks;


/// <summary> Latest Magisk Assets Manager</summary>
internal class MagiskAsset {
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
        => Json_link = "https://raw.githubusercontent.com/topjohnwu/magisk-files/" + MagiskBranch_string(branch) + ".json";

    /// <summary> Magisk asset json structure as string</summary>
    public string json_string { get; private set; }
    private async Task<string> Update_json_string(IMagiskBranch branch)
        => await Task.Run(() => json_string = new WebClient().DownloadString(Update_Json_link(branch)));

    /// <summary> Magisk asset json structure provided by <see cref=" JObject"/></summary>
    public JObject json { get; private set; }
    public JObject Update_json(IMagiskBranch branch)
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
    /// <summary> Magisk apk version as "XX.x"</summary>
    public string version { get; private set; }
    private string Update_version(IMagiskBranch branch, bool Update_Json = false)
        // "f822ca5b"
        => (string)(Update_Json ? Update_json(branch)["magisk"]["version"]
                                : json["magisk"]["version"]);

    public string apk_link_string { get; private set; }
    private string Update_apk_link_string(IMagiskBranch branch, bool Update_Json = false)
        => apk_link_string = (string)(Update_Json ? Update_json(branch)["magisk"]["link"]
                                       : json["magisk"]["link"]);
    public Uri apk_link { get; private set; }
    private Uri Update_apk_link(IMagiskBranch branch, bool Update_Json = false)
        => apk_link = new(Update_apk_link_string(branch, Update_Json));

    /// <summary> Magisk apk size in bytes</summary>
    public long apk_size { get; private set; }
    private long Update_apk_size(WebClient webClient, IMagiskBranch branch, bool Update_Json = false) {
        webClient.OpenRead(Update_apk_link(branch, Update_Json));
        return apk_size = Convert.ToInt64(webClient.ResponseHeaders["Content-Length"]);
    }

    /// <param name="webClient"><see cref="WebClient"/> to be used | <see cref="null"/> = <see cref="new()"/></param>
    /// <param name="branch">Magisk Branch 
    /// <list type="bullet">
    /// <item> 0 stable: "master/stable"</item>
    /// <item> 1 beta: "master/beta"</item>
    /// <item> 2 canary: "master/canary"</item>
    /// </list> </param>
    /// <returns>Create and return an instance of <see cref="MagiskAsset"/></returns>
    public MagiskAsset Instance(WebClient webClient = null, IMagiskBranch branch = IMagiskBranch.stable)
        => new MagiskAsset() {
            json = Update_json(branch), //init First to Update all
            version = Update_version(branch),
            apk_link = Update_apk_link(branch),
            apk_size = Update_apk_size(webClient ?? new(), branch)
        };
}

