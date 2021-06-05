using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GeekAssistant.Forms {
    public partial class Donate : Form {
        public Donate() {
            InitializeComponent();
        }
        private void AssignEvents() {
            FormClosing += new(Donate_FormClosing);

            Close_Button.Click += new(Close_Button_Click);

            GooglePayEmail.Click += new(GooglePay_Click); GooglePayIcon.Click += new(GooglePay_Click);
            GooglePayTitle.Click += new(GooglePay_Click); GooglePay_ClickableBG.Click += new(GooglePay_Click);

            GooglePayClick_Timer.Tick += new(GooglePayClick_Timer_Tick);

            GooglePayEmail.DoubleClick += new(GooglePay_DoubleClick); GooglePayIcon.DoubleClick += new(GooglePay_DoubleClick);
            GooglePayTitle.DoubleClick += new(GooglePay_DoubleClick); GooglePay_ClickableBG.DoubleClick += new(GooglePay_DoubleClick);

            GooglePayLink.Click += new(GooglePayLink_Click);

            GooglePayLink.MouseDown += new(GooglePayLink_MouseDown); GooglePayLink.KeyDown += new(GooglePayLink_MouseDown);

            GooglePayLink.MouseUp += new(GooglePayLink_MouseUp); GooglePayLink.KeyUp += new(GooglePayLink_MouseUp);

            BitcoinAddress.Click += new(Bitcoin_Click); BitcoinAddressQR.Click += new(Bitcoin_Click);
            BitcoinIcon.Click += new(Bitcoin_Click); BitcoinNote.Click += new(Bitcoin_Click);
            BitcoinTitle.Click += new(Bitcoin_Click); Bitcoin_ClickableBG.Click += new(Bitcoin_Click);

            BitcoinClick_Timer.Tick += new(BitcoinClick_Timer_Tick);

            BitcoinAddress.DoubleClick += new(Bitcoin_DoubleClick); BitcoinAddressQR.DoubleClick += new(Bitcoin_DoubleClick);
            BitcoinIcon.DoubleClick += new(Bitcoin_DoubleClick); BitcoinNote.DoubleClick += new(Bitcoin_DoubleClick);
            BitcoinTitle.DoubleClick += new(Bitcoin_DoubleClick); Bitcoin_ClickableBG.DoubleClick += new(Bitcoin_DoubleClick);

        }

        private static Home Home = null;
        private static void RefresHome() {
            foreach (Form h in Application.OpenForms) {
                if (h.GetType() == typeof(Home)) {
                    Home = (Home)h;
                }
            }
        }

        private void Donate_FormClosing(object sender, EventArgs e) {
            RefresHome();
            Home.BringToFront();
        }
        private void Donate_Load(object sender, EventArgs e) {
            AssignEvents();

            CenterToHomeBounds.Run(this);
            SetTheme.Run(this, true);
        }

        private void Close_Button_Click(object sender, EventArgs e) {
            Close();
        }

        private Timer GooglePayClick_Timer = new() { Interval = 1500 };
        private void GooglePay_Click(object sender, EventArgs e) {
            Clipboard.SetText("nhkomaiha@gmail.com");
            GooglePayEmail.Text = "Copied... Double click for help.";
            GooglePayClick_Timer.Enabled = true;
        }
        private void GooglePayClick_Timer_Tick(object sender, EventArgs e) {
            GooglePayEmail.Text = "nhkomaiha@gmail.com";
            GooglePayClick_Timer.Enabled = false;
        }
        private void GooglePay_DoubleClick(object sender, EventArgs e) {
            Process.Start(new ProcessStartInfo("https://support.google.com/pay/answer/7643913") { UseShellExecute = true, Verb = "open" });
        }
        private void GooglePayLink_Click(object sender, EventArgs e) {
            Process.Start(new ProcessStartInfo("https://pay.google.com") { UseShellExecute = true, Verb = "open" });
        }
        private Image current_GooglePayLink_Image;
        private void GooglePayLink_MouseDown(object sender, EventArgs e) {
            current_GooglePayLink_Image = GooglePayLink.Image;
            GooglePayLink.Image = prop.x16.linkIcon_gray75_16;
        }
        private void GooglePayLink_MouseUp(object sender, EventArgs e) {
            GooglePayLink.Image = current_GooglePayLink_Image;
        }

        private Timer BitcoinClick_Timer = new Timer { Interval = 1500 };
        private void Bitcoin_Click(object sender, EventArgs e) {
            Clipboard.SetText(prop.strings.BTCaddress);
            BitcoinAddress.Text = "Copied... Double click for help.";
            BitcoinClick_Timer.Enabled = true;
        }

        private void BitcoinClick_Timer_Tick(object sender, EventArgs e) {
            BitcoinAddress.Text = prop.strings.BTCaddress;
            BitcoinClick_Timer.Enabled = false;
        }

        private void Bitcoin_DoubleClick(object sender, EventArgs e) {
            Process.Start(new ProcessStartInfo("https://bitcoin.org/en/how-it-works") { UseShellExecute = true, Verb = "open" });
        }
    }
}
