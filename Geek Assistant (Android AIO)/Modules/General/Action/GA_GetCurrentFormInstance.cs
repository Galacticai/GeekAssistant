

using System.Windows.Forms;
 
internal static class GA_GetCurrentFormInstance {
    public static Form Run(Form form) { 
        foreach (Form h in Application.OpenForms)
            if (h == form)
                return h;
        return null;
    }
} 
