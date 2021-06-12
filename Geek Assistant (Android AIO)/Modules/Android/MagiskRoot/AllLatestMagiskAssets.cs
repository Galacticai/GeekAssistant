
using System.Net;

namespace GeekAssistant.Modules.Android.MagiskRoot {
    /// <summary> Collect all latest Magisk assets. Provided by <see cref="LatestMagiskAsset"/></summary>
    internal class AllMagiskAssets : LatestMagiskAsset {
        public LatestMagiskAsset stable { get; private set; }
        public LatestMagiskAsset beta { get; private set; }
        public LatestMagiskAsset canary { get; private set; }
        public static AllMagiskAssets GetAllBranches(WebClient webClient = null)
            => new() {
                stable = new LatestMagiskAsset().Instance(IMagiskBranch.stable, webClient ?? new()),
                beta = new LatestMagiskAsset().Instance(IMagiskBranch.beta, webClient ?? new()),
                canary = new LatestMagiskAsset().Instance(IMagiskBranch.canary, webClient ?? new())
            };
    }
}
