using GeekAssistant.Forms;
using System;
using System.Windows.Forms;

internal static partial class GA_PleaseWait {
    private static PleaseWait PleaseWait = null;
    public static void Run(bool Enable) {
        if (Enable) {
            if (PleaseWait != null) //dispose if exists and is not disposed
                if (!PleaseWait.IsDisposed) PleaseWait.Dispose();
            PleaseWait = new(); //! create new ( Always create new() : Don't merge with null check above )
            Home.PleaseWait = PleaseWait;
            PleaseWait.Show();
        } else {
            if (PleaseWait == null) //Check if instance saved
                if ((PleaseWait)Application.OpenForms["PleaseWait"] == null) //Check if any instance exists
                    return;
            /* inf.Run(($"{inf.detail.code}-pw-null", // (current code) - PleaseWait - null
                      inf.lvls.FatalError,
                      "We have encountered a problem",
                        "Error while hiding waiting screen",
                     $"{typeof(GA_PleaseWait).Name}: NullReferenceException"));
            */

            PleaseWait.UserClosing = false;
            PleaseWait.Close();
        }
    }
}