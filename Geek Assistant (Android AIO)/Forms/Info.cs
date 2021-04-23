using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeekAssistant.Forms {
    public partial class Info : Form {
        public Info() {
            InitializeComponent();
        }
        private void AssignEvents() {
            Yes_Button.MouseDown += Yes_Button_Mousedown;
            Yes_Button.MouseUp += Yes_Button_MouseUp;
            Yes_Button.Click += Yes_Button_Click;

            No_Button.Click += No_Button_Click;

            Copy_Button.MouseDown += Copy_Button_MouseDown;
            Copy_Button.MouseUp += Copy_Button_MouseUp;
            Copy_Button.Click += Copy_Button_Click;

            CopyToClipboard_Timer.Tick += CopyToClipboard_Timer_Tick;

            title_Label.TextChanged += title_Label_TextChanged;
            title_Label.Click += title_Label_Click;
            title_Label_Click_Timer.Tick += title_Label_Click_Timer_Tick;
        }

        public Image info_IconLight;
        public Image info_IconDark;
        public Color info_TextColorLight;
        public Color info_TextColorDark;

        private void Info_Load(object sender, EventArgs e) {
            AssignEvents();

            //Reset info answer
            GA_infoAsk.infoAnswer = false;
            No_Button.Select();

            if (common.S.info_MsgTitle == null || common.S.info_Msg == null || common.S.info_MsgLevel < -1) {
                Dispose(); //dispose before starting again
                GA_Msg.DoMsg(10, $"Where//s the error message??\n" +
                          "if ( you see this please contact the developer to fix this bug.\nPlease provide the log when reporting.", 2);
            }

            //Reset to default
            No_Button.Text = "Close";
            Yes_Button.Text = "Yes";
            //GeekAssistant_PictureBox.Visible = false;
            Yes_Button.Visible = false;
            Copy_Button.Visible = true;

            string msglevelText = "Warning";
            if (common.S.info_MsgLevel == 1 | common.S.info_MsgLevel == 10) {
                msglevelText = "Error";
                if (common.S.DarkTheme) {
                    info_PictureBox.Image = prop.x64.Warning_Red_dark_64;
                    title_Label.ForeColor = Color.FromArgb(255, 191, 191);
                } else {
                    info_PictureBox.Image = prop.x64.Warning_Red_64;
                    title_Label.ForeColor = Color.FromArgb(154, 0, 0);
                }
            } else if (common.S.info_MsgLevel == 2) {
                //msglevelText = "Question"
                No_Button.Text = GA_infoAsk.infoButtonText.RightButton;
                Yes_Button.Text = GA_infoAsk.infoButtonText.LeftButton;
                Yes_Button.Visible = true;
                Text = $"{common.S.info_MsgTitle} — Geek Assistant";
                title_Label.Text = common.S.info_MsgTitle;
                //GeekAssistant_PictureBox.Visible = true;
                Copy_Button.Visible = false;
                if (common.S.DarkTheme) {
                    info_PictureBox.Image = prop.x64.Question_Blue_Dark_64;
                    title_Label.ForeColor = Color.FromArgb(186, 221, 253);
                } else {
                    info_PictureBox.Image = prop.x64.Question_Blue_64;
                    title_Label.ForeColor = Color.FromArgb(64, 109, 128);
                }
            } else {
                if (common.S.DarkTheme) {
                    info_PictureBox.Image = prop.x64.Info_Yellow_dark_64;
                    title_Label.ForeColor = Color.FromArgb(255, 238, 191);
                } else {
                    info_PictureBox.Image = prop.x64.Info_Yellow_64;
                    title_Label.ForeColor = Color.FromArgb(115, 84, 0);
                }
            }


            if (common.S.info_MsgLevel != 2) {   //Avoid when it is a question
                Text = $"{GA_Msg.msgIcon}{msglevelText}: ❰{common.ErrorInfo.code}❱ — Geek Assistant";
                title_Label.Text = $"❰{common.ErrorInfo.code}❱ {common.S.info_MsgTitle}";
            }
            msg_Textbox.Text = common.S.info_Msg;

            ////////Special Cases
            if (title_Label.Text == "Send Feedback") {
                if (common.S.DarkTheme) {
                    info_PictureBox.Image = prop.x64.Smile_dark_64;
                    title_Label.ForeColor = Color.FromArgb(191, 255, 191);
                } else {
                    info_PictureBox.Image = prop.x64.Smile_64;
                    title_Label.ForeColor = Color.FromArgb(0, 102, 71);
                }
            }

            //// Set size
            Width = 566;
            Height = 355;
            switch (msg_Textbox.Text.Length) {
            case < 150:
                Width = 520;
                Height -= 50;
                break;
            case > 400:
                Width += 60;
                Height += 75;
                break;
            }
            SetBounds((common.Home.Width / 2) - (Width / 2) + common.Home.Location.X, common.Home.Top, Width, Height);


            GA_SetTheme.Run(Name);
        }

        private void Yes_Button_Mousedown(object sender, EventArgs e) {
            if (Yes_Button.ForeColor.GetBrightness() >= .5)
                Yes_Button.ForeColor = Color.Black;
            else Yes_Button.ForeColor = Color.White;

        }
        private void Yes_Button_MouseUp(object sender, EventArgs e) {
            Yes_Button.ForeColor = title_Label.ForeColor;
        }
        private void Yes_Button_Click(object sender, EventArgs e) {
            if (common.S.info_MsgLevel == 2) {
                GA_infoAsk.infoAnswer = true;
                Close();
            }
        }

        //private void Close_Button_MouseDown(object sender, EventArgs e) { Close_Button.MouseDown
        //    Close_Button.ForeColor = Color.White
        //}
        //private void Close_Button_MouseUp(object sender, EventArgs e) { Close_Button.MouseUp
        //    Close_Button.ForeColor = SystemColors.ControlText
        //}
        private void No_Button_Click(object sender, EventArgs e) {
            if (!common.S.VerboseLogging && common.S.VerboseLoggingPrompt
            && common.S.info_MsgLevel != 2) { //&& ! title_Label.Text = "Enable Verbose Logging?" && ! title_Label.Text = "Send Feedback" ) {
                                              //Close();
                Dispose();
                if (GA_infoAsk.Run("Enable Verbose Logging?",
                                   $"For better troubleshooting, enable verbose logging in Settings and try again.",
                                  "Enable", "Close"))
                    common.Settings.ShowDialog();

                common.S.VerboseLoggingPrompt = false;
            }
            if (common.S.info_MsgLevel == 2) GA_infoAsk.infoAnswer = false;
            Close();
            common.Home.BringToFront();
            //Dispose();
        }

        private void Copy_Button_MouseDown(object sender, EventArgs e) {
            Copy_Button.Image = prop.x24.Copy_W_24;
            Copy_Button.ForeColor = Color.White;
        }
        private void Copy_Button_MouseUp(object sender, EventArgs e) {
            Copy_Button.Image = prop.x24.Copy_B_24;
            if (CopyToClipboard_Timer.Enabled)
                Copy_Button.ForeColor = Color.DarkGreen;
            else Copy_Button.ForeColor = SystemColors.ControlText;

        }
        private void Copy_Button_Click(object sender, EventArgs e) {
            CopyToClipboard_Timer.Enabled = false;
            Clipboard.SetText($"{title_Label.Text}\n\n{msg_Textbox.Text}");
            Copy_Button.ForeColor = Color.DarkGreen;
            Copy_Button.Text = "Copied ";
            CopyToClipboard_Timer.Enabled = true;
        }

        private void CopyToClipboard_Timer_Tick(object sender, EventArgs e) {
            CopyToClipboard_Timer.Enabled = false;
            Copy_Button.Text = "Copy  ";
            Copy_Button.ForeColor = SystemColors.ControlText;
        }

        private void title_Label_TextChanged(object sender, EventArgs e) {
            if (title_Label.Text.Length < 25)
                title_Label.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            else title_Label.Font = new Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0);

        }

        private Timer title_Label_Click_Timer = new Timer { Interval = 1500 };
        private string savedTitle;
        private string CopiedText = "Copied information...";
        private void title_Label_Click(object sender, EventArgs e) {
            if (title_Label.Text == CopiedText) return;
            if (common.S.info_MsgLevel != 2) {
                savedTitle = title_Label.Text;
                title_Label.Text = CopiedText;
                Clipboard.SetText(savedTitle);
                title_Label_Click_Timer.Start();
            }
        }
        private void title_Label_Click_Timer_Tick(object sender, EventArgs e) {
            title_Label.Text = savedTitle;
            title_Label_Click_Timer.Stop();
        }

    }
}
