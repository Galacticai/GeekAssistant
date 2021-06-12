using System.Threading.Tasks;
using System.Windows.Forms;
using GeekAssistant.Controls.Material;

internal class SetTheme_PresetAnimation : SetTheme {
    private static bool dark => c.S.DarkTheme;

    public static void Swoosh_Full() {
        SetTheme.h.SwitchTheme_UI.Width = h.Width;
        h.SwitchTheme_UI.Left = (h.Width - h.SwitchTheme_UI.Width) / 2;
        h.SwitchTheme_UI.Top = dark ? -h.SwitchTheme_UI.Height : h.Height;
        Animate.Run(h.SwitchTheme_UI, nameof(h.SwitchTheme_UI.Top), dark ? h.Height : -h.SwitchTheme_UI.Height, 1000);
    }
    private static float _Icons_Opacity = 0;
    private static float Icons_Opacity {
        get => _Icons_Opacity;
        set {
            _Icons_Opacity = value;
            h.SwitchTheme_Light_UI_Icon.Image = math.Vision.ChangeOpacity(prop.x64.Theme_light_64, _Icons_Opacity);
            h.SwitchTheme_Dark_UI_Icon.Image = math.Vision.ChangeOpacity(prop.x64.Theme_dark_64, _Icons_Opacity);
        }
    }
    public static void LightDark_Icon_Center() {
        h.SwitchTheme_Dark_UI_Icon.Visible =
            h.SwitchTheme_Light_UI_Icon.Visible = true;
        h.SwitchTheme_Dark_UI_Icon.Left =
           h.SwitchTheme_Light_UI_Icon.Left = (h.Width - 64) / 2;
        h.SwitchTheme_Dark_UI_Icon.Top =
            h.SwitchTheme_Light_UI_Icon.Top = (h.Height - 64) / 2;
        h.SwitchTheme_Light_UI_Icon.Height = dark ? 0 : 64;
        Animate.Run(h.SwitchTheme_Light_UI_Icon, nameof(h.SwitchTheme_Light_UI_Icon.Height), dark ? 64 : 0);

        bool Rewind = false;
        float animFactor = .1f;
        Timer Icons_Opacity_Timer = new() { Interval = 1 };
        Icons_Opacity_Timer.Tick += (sender, ev) => {

            Icons_Opacity += Rewind ? -animFactor : animFactor;
            if (Icons_Opacity != math.Arithmatics.ForcedInRange(Icons_Opacity, 0, 1)) {
                Icons_Opacity = (float)math.Arithmatics.ForcedInRange(Icons_Opacity, 0, 1);
                if (Rewind) {
                    h.SwitchTheme_Dark_UI_Icon.Visible =
                        h.SwitchTheme_Light_UI_Icon.Visible = false;
                    Icons_Opacity_Timer.Stop();
                }
                Rewind = true;
            }
        };
        Icons_Opacity_Timer.Start();


    }


}