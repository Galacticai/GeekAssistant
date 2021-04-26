using System.Collections.Generic;
using System.Windows.Forms;

internal static partial class GA_HideAllForms {

    public static FormCollection HiddenForms;
    private static Form currentForm;
    /// <summary>
    /// Hides/Shows All forms currently opened by Geek Assistant
    /// </summary>
    /// <param name="Hide">Set if it should hide or not (show)</param>
    /// <param name="FormToFront">Bring this form to front when done</param>
    public static void Run(bool Hide) { 
        // SET ERROR CODE WHEN CALLING, DO NOT SET HERE //

        currentForm = Form.ActiveForm; // Set before hiding to save
        if (Hide) {
            HiddenForms = Application.OpenForms;
            foreach (Form formname in Application.OpenForms) // Save all forms to HiddenFormsList then hide
               formname.Hide(); 
        } else {
            if (HiddenForms.Count == 0) { // failsafe
                common.ErrorInfo.code += "-HF0";
                GA_Msg.DoMsg(10, "Something went wrong.\nWe failed to revive hidden windows.", 2);
                if (GA_infoAsk.Run("Refresh Geek Assistant?",
                                     "Refreshing will relaunch Geek Assistant to get back to working order. This will terminate any ongoing progress!",
                                   "Refresh","No"))
                    Application.Restart();
                return;
            } 
            foreach (Form formname in HiddenForms) // Show all forms saved in list
                formname.Show();

            currentForm.BringToFront();
        }
    }
}