using System.Collections.Generic;
using System.Windows.Forms;

internal static partial class GA_HideAllForms {
    public static List<Form> HiddenFormsList = new();
    private static Form currentForm;
    /// <summary>
    /// Hides/Shows All forms currently opened by Geek Assistant
    /// </summary>
    /// <param name="Hide">Set if it should hide or not (show)</param>
    /// <param name="FormToFront">Bring this form to front when done</param>
    public static void Run(bool Hide){//, Form FormToFront) {
        // SET ERROR CODE WHEN CALLING, DO NOT SET HERE
        currentForm = Form.ActiveForm; //Set before hiding to save
        if (Hide) {
            HiddenFormsList.Clear(); // Clear forms list
            foreach (Form formname in Application.OpenForms) // Save all forms to HiddenFormsList then hide
            {
                HiddenFormsList.Add(formname);
                formname.Hide();
            }
        } else {
            if (HiddenFormsList.Count == 0) // failsafe
            {
                GA_Msg.DoMsg(10, "Error while reviving hidden windows.", 2);
                return;
            }

            foreach (Form formname in HiddenFormsList) // Show all forms saved in list
                formname.Show();
            //if (currentForm != null)  // Failsafe // will never be null (Form.ActiveForm)
            currentForm.BringToFront();
        }
    }
}