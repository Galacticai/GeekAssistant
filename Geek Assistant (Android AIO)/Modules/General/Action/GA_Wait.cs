using GeekAssistant.Forms;
using System;
using System.Windows.Forms;

internal static partial class GA_Wait {
    public static Wait Wait = null;
    public static void Run(bool Enable) {
        if (Enable) {
            if (Wait != null) //dispose if exists and is not disposed
                if (!Wait.IsDisposed) Wait.Dispose();
            Wait = new(); //! create new ( Always create new() : Don't merge with null check above )
            //Home.Wait = Wait;
            Wait.Show();
        } else {
            if (Wait == null) return; // cancel if no instance saved 

            Wait.UserClosing = false; //unflag or it won't close
            Wait.Close();
        }
    }
}