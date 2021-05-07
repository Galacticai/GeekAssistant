using GeekAssistant.Forms;
using System;
using System.Windows.Forms;

internal static partial class GA_Wait {
    private static Wait Wait = null;
    public static void Run(bool Enable) {
        if (Enable) {
            if (Wait != null) //dispose if exists and is not disposed
                if (!Wait.IsDisposed) Wait.Dispose();
            Wait = new(); //! create new ( Always create new() : Don't merge with null check above )
            Home.Wait = Wait;
            Wait.Show();
        } else {
            if (Wait == null) //Check if instance saved
                if ((Wait)Application.OpenForms["Wait"] == null) //Check if any instance exists
                    return;
            /* inf.Run(($"{inf.detail.code}-pw-null", // (current code) - Wait - null
                      inf.lvls.FatalError,
                      "We have encountered a problem",
                        "Error while hiding waiting screen",
                     $"{typeof(GA_Wait).Name}: NullReferenceException"));
            */

            Wait.UserClosing = false; //unflag or it won't close
            Wait.Close();
        }
    }
}