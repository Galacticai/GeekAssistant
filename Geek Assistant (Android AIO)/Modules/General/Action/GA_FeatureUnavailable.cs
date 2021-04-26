
internal static partial class GA_FeatureUnavailable {
    public static void Run(string title) {
        string state = "cooking progress";
        switch (c.V.Revision) {
        case 1: {
            state = "beta phase";
            break;
        }

        case 2: {
            state = "testing phase";
            break;
        }

        case 3: {
            state = "development phase";
            break;
        }
        }

        GA_Msg.DoMsg(0, $"{title}\nGeek Assistant is still in {state}... {title} might be added in future updates. Stay tuned!");
    }
}