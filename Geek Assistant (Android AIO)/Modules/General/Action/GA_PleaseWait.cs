
internal static partial class GA_PleaseWait {
    public static void Run(bool Enable) {
        if (Enable) {
            common.PleaseWait.Show();
        } else {
            common.PleaseWait.UserClosing = false;
            common.PleaseWait.Close();
        }
    }
}