
internal static partial class GA_SetTooltipInfo {
    public static void SetToolTipInfo(ref ToolTip ToolTipName, ref object obj, string ToolTipTitle, string ToolTipText) {
        if (S.ShowToolTips) {
            if (!(ToolTipTitle == ToolTipName.ToolTipTitle))
                ToolTipName.ToolTipTitle = ToolTipTitle;
            if (!(ToolTipText == ToolTipName.GetToolTip(obj)))
                ToolTipName.SetToolTip(obj, ToolTipText);
        } else {
            ToolTipName.SetToolTip(obj, default);
        }
    }
}