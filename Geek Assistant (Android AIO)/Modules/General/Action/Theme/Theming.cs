using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentTransitions;
using GeekAssistant.Forms;

internal partial class Theming {

    public static void SetControlsArrTheme(Control[] ControlsObj) {
        foreach (var ctrl in ControlsObj)
            SetControlTheme(ctrl);
    }
    public static void SetControlTheme(Control ControlObj) {
        Animate.Run(ControlObj, "ForeColor", colors.fg);
        Animate.Run(ControlObj, "BackColor", colors.bg);
    }

    public static void SetControlsArrTheme_Metro(MetroFramework.Interfaces.IMetroControl[] ControlsObj) {
        foreach (var ctrl in ControlsObj)
            SetControlTheme_Metro(ctrl);
    }
    public static void SetControlTheme_Metro(MetroFramework.Interfaces.IMetroControl ControlObj) {
        ControlObj.Theme = colors.Metro;  //Note: Cannot animate "Theme"   
    }

}