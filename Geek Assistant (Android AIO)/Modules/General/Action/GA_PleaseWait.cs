
internal static partial class GA_PleaseWait {
    public static void Run(bool Enable) {
        if (Enable) {
            c.PleaseWait().Show();
        } else {
            c.PleaseWait().UserClosing = false;
            c.PleaseWait().Close();
        }
    }
}