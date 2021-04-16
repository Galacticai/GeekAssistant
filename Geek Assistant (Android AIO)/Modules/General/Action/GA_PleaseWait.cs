
internal static partial class GA_PleaseWait {
    public static void Run(bool Enable) {
        if (Enable) {
            PleaseWait.Show();
        } else {
            PleaseWait.UserClosing = false;
            PleaseWait.Close();
        }
    }
}