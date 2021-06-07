
internal static class FeatureUnavailable {
    public static void Run(string title) {
        string state = "cooking progress";
        switch (c.V.Revision) {
            case 1:
                state = "beta phase"; break;
            case 2:
                state = "testing phase"; break;
            case 3:
                state = "development phase"; break;
        }

        inf.Run(inf.lvls.Information, title,
                $"Geek Assistant is still in {state}... {title} might be added in future updates. Stay tuned!");
    }
}