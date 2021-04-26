
using System.Windows.Forms;

internal static partial class GA_SetTooltipInfo {
    public static void Run(ref ToolTip ToolTipName, object obj, string ToolTipTitle, string ToolTipText) {
        if (c.S.ShowToolTips) {
            if (ToolTipTitle != ToolTipName.ToolTipTitle)
                ToolTipName.ToolTipTitle = ToolTipTitle;
            if (ToolTipText != ToolTipName.GetToolTip((Control)obj))
                ToolTipName.SetToolTip((Control)obj, ToolTipText);
        } else {
            ToolTipName.SetToolTip((Control)obj, "");
        }
    }
}