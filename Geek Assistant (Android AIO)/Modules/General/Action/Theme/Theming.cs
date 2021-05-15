using System.Windows.Forms;

//namespace GeekAssistant.Theme {
internal partial class Theming {

    public static void SetControlsArrTheme(Control[] ControlsObj) {
        foreach (var ctrl in ControlsObj) {
            SetControlTheme(ctrl);
        }
    }
    public static void SetControlTheme(Control ControlObj) {
        Animate.Run(ControlObj, nameof(ControlObj.ForeColor), colors.UI.fg());

        string BackColor = nameof(ControlObj.BackColor);
        if (ControlObj.GetType() == typeof(MaterialButton)) BackColor = nameof(MaterialButton.realBackColor);
        Animate.Run(ControlObj, BackColor, colors.UI.bg());
    }


    public static void SetControlsArrTheme_Metro(MetroFramework.Interfaces.IMetroControl[] ControlsObj) {
        foreach (var ctrl in ControlsObj) {
            SetControlTheme_Metro(ctrl);
        }
    }
    public static void SetControlTheme_Metro(MetroFramework.Interfaces.IMetroControl ControlObj) {
        ControlObj.Theme = colors.UI.Metro();  //Note: Cannot animate "Theme"   
    }

}
//}