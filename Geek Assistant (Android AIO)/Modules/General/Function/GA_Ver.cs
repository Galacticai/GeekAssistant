
internal static partial class GA_Ver {
    /// <summary>
    /// Create a customized version string accordingly or vX.x if not specified
    /// </summary>
    /// <param name="level">Place where this is being called at</param>
    /// <returns>
    /// <list type="bullet">
    /// <item>log = Geek Assistant vX.x #Phase ©20XX By NHKomaiha.</item>
    /// <item>Main = vX.x #Phase ©20XX By NHKomaiha.</item>
    /// <item>MainTitle = Geek Assistant — vX.x #Phase</item>
    /// <item>ToU = ©2021 Geek Assistant By NHKomaiha. vX.x #Phase"</item>
    /// <item>(Other) = vX.x</item>
    /// </list>
    /// </returns>
    public static string Run(string level = "") {
        string cDateByNHKomaiha = "©2021 By NHKomaiha";
        string result = $"v{V.Major}.{V.Minor}";
        switch (V.Revision) {
        // Case 0
        // GAver &= Nothing '(Normal)
        case 1: {
            result += " #Beta";
            break;
        }

        case 2: {
            result += " #Test";
            break;
        }

        case 3: {
            result += " #Dev";
            break;
        }
        }

        switch (level ?? "") {
        case "log": {
            result = $"Geek Assistant {result} {cDateByNHKomaiha}.";
            break;
        }

        case "Main": {
            result += $" {cDateByNHKomaiha}.";
            break;
        }

        case "MainTitle": {
            result = $"Geek Assistant — {result}";
            break;
        }

        case "ToU": {
            result = $"{My.Application.Info.Copyright}. {result}";
            break;
        }
        }

        return result;
    }
}