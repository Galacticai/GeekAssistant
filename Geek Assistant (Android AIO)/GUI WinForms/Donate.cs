using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GeekAssistant.Forms {
    public partial class Donate : Form {
        public Donate() => InitializeComponent();
        private void AssignEvents() {
            FormClosing += new(Donate_FormClosing);

            Close_Button.Click += new(Close_Button_Click);

            GooglePayEmail.Click += new(GooglePay_Click); GooglePayIcon.Click += new(GooglePay_Click);
            GooglePayTitle.Click += new(GooglePay_Click); GooglePay_ClickableBG.Click += new(GooglePay_Click);


            GooglePayEmail.DoubleClick += new(GooglePay_DoubleClick); GooglePayIcon.DoubleClick += new(GooglePay_DoubleClick);
            GooglePayTitle.DoubleClick += new(GooglePay_DoubleClick); GooglePay_ClickableBG.DoubleClick += new(GooglePay_DoubleClick);

            GooglePayLink.Click += new(GooglePayLink_Click);

            GooglePayLink.MouseDown += new(GooglePayLink_MouseDown); GooglePayLink.KeyDown += new(GooglePayLink_MouseDown);

            GooglePayLink.MouseUp += new(GooglePayLink_MouseUp); GooglePayLink.KeyUp += new(GooglePayLink_MouseUp);

            BitcoinAddress.Click += new(Bitcoin_Click); BitcoinAddressQR.Click += new(Bitcoin_Click);
            BitcoinIcon.Click += new(Bitcoin_Click); BitcoinNote.Click += new(Bitcoin_Click);
            BitcoinTitle.Click += new(Bitcoin_Click); Bitcoin_ClickableBG.Click += new(Bitcoin_Click);


            BitcoinAddress.DoubleClick += new(Bitcoin_DoubleClick); BitcoinAddressQR.DoubleClick += new(Bitcoin_DoubleClick);
            BitcoinIcon.DoubleClick += new(Bitcoin_DoubleClick); BitcoinNote.DoubleClick += new(Bitcoin_DoubleClick);
            BitcoinTitle.DoubleClick += new(Bitcoin_DoubleClick); Bitcoin_ClickableBG.DoubleClick += new(Bitcoin_DoubleClick);

        }

        private void Donate_FormClosing(object sender, EventArgs ev) {
            RunGeekAssistant.All_FormClosed(sender, ev);
            c.Home.BringToFront();
        }
        private void Donate_Load(object sender, EventArgs ev) {
            AssignEvents();

            CenterToHomeBounds.Run(this);
            SetTheme.Run(this, true);
        }

        private void Close_Button_Click(object sender, EventArgs ev) => Close();

        private void GooglePay_Click(object sender, EventArgs ev) {
            Clipboard.SetText("nhkomaiha@gmail.com");
            GooglePayEmail.Text = "Copied... Double click for help.";

            Timer GooglePayClick_Timer = new() { Interval = 1500 };
            GooglePayClick_Timer.Tick += (sender, ev) => {
                GooglePayEmail.Text = "nhkomaiha@gmail.com";
                GooglePayClick_Timer.Stop();
            };
            GooglePayClick_Timer.Start();

        }
        private void GooglePay_DoubleClick(object sender, EventArgs ev) {
            Process.Start(new ProcessStartInfo("https://support.google.com/pay/answer/7643913") { UseShellExecute = true, Verb = "open" });
        }
        private void GooglePayLink_Click(object sender, EventArgs ev) {
            Process.Start(new ProcessStartInfo("https://pay.google.com") { UseShellExecute = true, Verb = "open" });
        }
        private Image current_GooglePayLink_Image;
        private void GooglePayLink_MouseDown(object sender, EventArgs ev) {
            current_GooglePayLink_Image = GooglePayLink.Image;
            GooglePayLink.Image = prop.x16.linkIcon_gray75_16;
        }
        private void GooglePayLink_MouseUp(object sender, EventArgs ev) {
            GooglePayLink.Image = current_GooglePayLink_Image;
        }
        private void Bitcoin_Click(object sender, EventArgs ev) {
            Clipboard.SetText(prop.strings.BTCaddress);
            BitcoinAddress.Text = "Copied... Double click for help.";

            Timer BitcoinClick_Timer = new() { Interval = 1500 };
            BitcoinClick_Timer.Tick += (sender, ev) => {
                BitcoinAddress.Text = prop.strings.BTCaddress;
                BitcoinClick_Timer.Stop();
            };
            BitcoinClick_Timer.Start();
        }
        private void Bitcoin_DoubleClick(object sender, EventArgs ev) {
            Process.Start(new ProcessStartInfo("https://bitcoin.org/en/how-it-works") { UseShellExecute = true, Verb = "open" });
        }
    }
}
