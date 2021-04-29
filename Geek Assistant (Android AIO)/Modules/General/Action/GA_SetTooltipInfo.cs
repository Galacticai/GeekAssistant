
using System.Windows.Forms;

internal static partial class GA_SetTooltipInfo {
    public static void Run(ref ToolTip ToolTipName, Control control, string ToolTipTitle, string ToolTipText) {
        if (c.S.ShowToolTips) {
            if (ToolTipTitle != ToolTipName.ToolTipTitle)
                ToolTipName.ToolTipTitle = ToolTipTitle;
            if (ToolTipText != ToolTipName.GetToolTip((Control)control))
                ToolTipName.SetToolTip((Control)control, ToolTipText);
        } else ToolTipName.SetToolTip((Control)control, "");
    }
}