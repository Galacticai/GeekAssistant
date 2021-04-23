using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeekAssistant.Forms {
    public partial class Donate : Form {
        public Donate() {
            InitializeComponent();
        }
        private void AssignEvents() {
            FormClosing += Donate_FormClosing;
            Load += Donate_Load;

            Close_Button.Click += Close_Button_Click;

            GooglePayEmail.Click += GooglePay_Click; GooglePayIcon.Click += GooglePay_Click;
            GooglePayTitle.Click += GooglePay_Click; GooglePay_ClickableBG.Click += GooglePay_Click;

            GooglePayClick_Timer.Tick += GooglePayClick_Timer_Tick;

            GooglePayEmail.DoubleClick += GooglePay_DoubleClick; GooglePayIcon.DoubleClick += GooglePay_DoubleClick;
            GooglePayTitle.DoubleClick += GooglePay_DoubleClick; GooglePay_ClickableBG.DoubleClick += GooglePay_DoubleClick;

            GooglePayLink.Click += GooglePayLink_Click;

            GooglePayLink.MouseDown += GooglePayLink_MouseDown; GooglePayLink.KeyDown += GooglePayLink_MouseDown;

            GooglePayLink.MouseUp += GooglePayLink_MouseUp; GooglePayLink.KeyUp += GooglePayLink_MouseUp;

            BitcoinAddress.Click += Bitcoin_Click; BitcoinAddressQR.Click += Bitcoin_Click;
            BitcoinIcon.Click += Bitcoin_Click; BitcoinNote.Click += Bitcoin_Click;
            BitcoinTitle.Click += Bitcoin_Click; Bitcoin_ClickableBG.Click += Bitcoin_Click;

            BitcoinClick_Timer.Tick += BitcoinClick_Timer_Tick;

            BitcoinAddress.DoubleClick += Bitcoin_DoubleClick; BitcoinAddressQR.DoubleClick += Bitcoin_DoubleClick;
            BitcoinIcon.DoubleClick += Bitcoin_DoubleClick; BitcoinNote.DoubleClick += Bitcoin_DoubleClick;
            BitcoinTitle.DoubleClick += Bitcoin_DoubleClick; Bitcoin_ClickableBG.DoubleClick += Bitcoin_DoubleClick;

        }
        private void Donate_FormClosing(object sender, EventArgs e) {
            common.Home.BringToFront();
        }
        private void Donate_Load(object sender, EventArgs e) {
            AssignEvents();

            GA_SetTheme.Run(Name, true);
            SetBounds((common.Home.Width / 2) - (Width / 2) + common.Home.Location.X, common.Home.Top, Width, Height);
        }

        private void Close_Button_Click(object sender, EventArgs e) {
            Close();
        }

        private Timer GooglePayClick_Timer = new Timer { Interval = 1500 };
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
            Process.Start("https://support.google.com/pay/answer/7643913");
        }
        private void GooglePayLink_Click(object sender, EventArgs e) {
            Process.Start("https://pay.google.com");
        }
        private Image current_GooglePayLink_Image;
        private void GooglePayLink_MouseDown(object sender, EventArgs e) {
            current_GooglePayLink_Image = GooglePayLink.Image;
            GooglePayLink.Image = prop.x16.linkIcon_gray75_16;
        }
        private void GooglePayLink_MouseUp(object sender, EventArgs e) {
            GooglePayLink.Image = current_GooglePayLink_Image;
        }

        //private saved_GooglePayTitle_Forecolor As Color
        //private void GooglePayTitle_MouseEnter(object sender, EventArgs e) { GooglePayTitle.MouseEnter
        //    saved_GooglePayTitle_Forecolor = GooglePayTitle.ForeColor
        //    GooglePayTitle.ForeColor = Current_fgColor()
        //}
        //private void GooglePayTitle_MouseLeave(object sender, EventArgs e) { GooglePayTitle.MouseLeave
        //    GooglePayTitle.ForeColor = saved_GooglePayTitle_Forecolor
        //}

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
            Process.Start("https://bitcoin.org/en/how-it-works");
        }
    }
}
