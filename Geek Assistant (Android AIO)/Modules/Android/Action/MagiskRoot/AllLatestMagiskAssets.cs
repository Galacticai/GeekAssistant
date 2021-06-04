using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Threading.Tasks;

/// <summary> Collect all latest Magisk assets. Provided by <see cref="LatestMagiskAsset"/></summary>
internal class AllMagiskAssets : LatestMagiskAsset {
    public LatestMagiskAsset stable { get; private set; }
    public LatestMagiskAsset beta { get; private set; }
    public LatestMagiskAsset canary { get; private set; }
    public static AllMagiskAssets GetAllBranches(WebClient webClient = null)
        => new() {
            stable = new LatestMagiskAsset().Instance(webClient ?? new(), IMagiskBranch.stable),
            beta = new LatestMagiskAsset().Instance(webClient ?? new(), IMagiskBranch.beta),
            canary = new LatestMagiskAsset().Instance(webClient ?? new(), IMagiskBranch.canary)
        };
}