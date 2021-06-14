using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GeekAssistant.Modules.General;
using GeekAssistant.Modules.General.SetTheme;
using GeekAssistant.Modules.General.Companion;
using GeekAssistant.Modules.General.Companion.Style;

namespace GeekAssistant.Forms {
    public partial class ToU : Form {
        //private void Main(object sender, EventArgs e) { Show(); }
        public ToU() {
            InitializeComponent();
        }
        private void AssignEvents() {
            ToU_Reject.MouseEnter += new(ToU_Reject_MouseEnter_MouseDown_KeyDown);
            ToU_Reject.MouseDown += new(ToU_Reject_MouseEnter_MouseDown_KeyDown);
            ToU_Reject.KeyDown += new(ToU_Reject_MouseEnter_MouseDown_KeyDown);
            ToU_Reject.MouseLeave += new(ToU_Reject_MouseLeave_KeyUp);
            ToU_Reject.KeyUp += new(ToU_Reject_MouseLeave_KeyUp);
            ToU_Reject.Click += new(ToU_Reject_Click);

            ToU_Accept.MouseEnter += new(ToU_Accept_MouseEnter_MouseDown_KeyDown);
            ToU_Accept.MouseDown += new(ToU_Accept_MouseEnter_MouseDown_KeyDown);
            ToU_Accept.KeyDown += new(ToU_Accept_MouseEnter_MouseDown_KeyDown);
            ToU_Accept.MouseLeave += new(ToU_Accept_MouseLeave_KeyUp);
            ToU_Accept.KeyUp += new(ToU_Accept_MouseLeave_KeyUp);
            ToU_Accept.Click += new(ToU_Accept_Click);

            AcceptCheck_ToU.CheckedChanged += new(AcceptCheck_ToU_CheckedChanged);

            ToURead_Timer.Tick += new(ToURead_Timer_Tick);
        }

        private Timer ToURead_Timer = new() { Interval = 1000 };

        public bool RunningAlready = false;
        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
            c.S.Save();
            RunningAlready = false;
            if (ToURead_Timer.Enabled) {
                ToURead_Timer.Stop();
            }
        }

        public int ToURead_TimeAmount = 6;
        private void ToU_Load(object sender, EventArgs e) {
            AssignEvents();

            SetTheme.Run(this);

            Copyright_Label.Text = ver.Run(ver.VerType.ToU);

            Load_ToU_rtf();

            ToU_Reject.Select();

            Home Home = c.Home;

            //Accept || xy // Size xy: 337, 405 // 173, 46
            //Reject || xy // Size xy: 204, 405 // 133, 46
            if (RunningAlready) {
                CenterToHomeBounds.Run(this);
                AcceptCheck_ToU.Visible = false;
                DontShow_ToU.Visible = false;
                ToU_Reject.Text = "✖";
                ToU_Reject.Left = 394;
                ToU_Reject.Width = 58;

                ToU_Accept.Left = 452;
                ToU_Accept.Width = 58;
                ToU_Accept.Enabled = true;
                //.BackColor = BackColor
                ToU_Accept.Text = "✔";
                ToU_Accept.Font = new Font("Segoe UI", 13f);

                ToU_Accept.Select();
                return;
            }

            if (c.version.Revision < 3) {
                ToURead_Timer.Enabled = true;
            } else { ////Skip the 6sec timer for #Dev version 
                ToU_Accept.BackColor = BackColor;
                ToURead_TimeAmount = 6;
                AcceptCheck_ToU.Checked = true;
            }

            if (c.S.ToU_dontShow) {  //ToU():[ Dont show ToU() >> Show Startup:[ Don//t show AppMode() >> Start newbie / moderate ] ]
                if (c.S.AppMode_dontshow) {
                    Home.Show();
                } else {
                    new AppMode().Show();
                }

                Close();
            }
        }


        private void Load_ToU_rtf() {
            string terms_rtf = $@"{c.GA}\terms.rtf"; //set destination

            var Current_rtf = prop.GA.TermsOfUse; //set default file
            if (c.S.DarkTheme) {
                Current_rtf = prop.GA.TermsOfUse_Dark; //set dark file if dark theme
            }

            if (!Directory.Exists(c.GA)) {
                Directory.CreateDirectory(c.GA); //create GA folder if not present
            }

            if (File.Exists(terms_rtf)) {
                File.Delete(terms_rtf); //delete old file if present
            }

            File.WriteAllText(terms_rtf, Current_rtf); //write file to GA
            TermsOfUse_Box.LoadFile(terms_rtf); //load file to the box

            TermsOfUse_Box.SelectionLength = 0; //deselect everything
        }

        private void ToU_Reject_MouseEnter_MouseDown_KeyDown(object sender, EventArgs e) {
            ToU_Reject.ForeColor = colors.UI.bg();
        }

        private void ToU_Reject_MouseLeave_KeyUp(object sender, EventArgs e) {
            ToU_Reject.ForeColor = colors.UI.fg();
        }

        private void ToU_Reject_Click(object sender, EventArgs e) {
            inf.detail.code = "ToU()-R-H"; // ToU() Rejected Hide
            HideAllForms.Run(true);
            if (inf.Run(inf.lvls.Question, "Rejected the terms of use",
                                 "Sorry for any inconvenience. You could contact the developer for further discussion.",
                               ("Exit", "Back"))) {
                Application.Exit();
            } else {
                inf.detail.code = "ToU()-R-S";
                HideAllForms.Run(false);
            }
        }

        private void ToU_Accept_MouseEnter_MouseDown_KeyDown(object sender, EventArgs e) {
            ToU_Accept.ForeColor = colors.UI.bg();
        }
        private void ToU_Accept_MouseLeave_KeyUp(object sender, EventArgs e) {
            ToU_Accept.ForeColor = colors.UI.fg();
        }
        private void ToU_Accept_Click(object sender, EventArgs e) {
            c.S.ToU_dontShow = DontShow_ToU.Checked;

            if (RunningAlready) { Close(); return; }

            if (c.S.AppMode_dontshow) { new Home().Show(); Close(); } else { new AppMode().Show(); Close(); }

        }
        private void AcceptCheck_ToU_CheckedChanged(object sender, EventArgs e) {
            if (AcceptCheck_ToU.Checked & ToURead_TimeAmount == 6) {
                ToU_Accept.Enabled = true;
                ToU_Accept.BackColor = BackColor;
            } else {
                ToU_Accept.Enabled = false;
                ToU_Accept.BackColor = ButtonsBG_UI.BackColor;
            }
        }

        private void ToURead_Timer_Tick(object sender, EventArgs e) {

            ToU_Accept.BackColor = ButtonsBG_UI.BackColor;

            //ToURead_TimeAmount += 1;
            //if (ToURead_TimeAmount == 5) {
            //    ToURead_Timer.Enabled = false;

            //}

            if (ToURead_TimeAmount == 5) {
                ToURead_Timer.Enabled = false;
                ToURead_TimeAmount += 1;
                ToU_Accept.Text = $"&ACCEPT ({(6 - ToURead_TimeAmount)})";
                if (ToURead_TimeAmount == 6) {
                    ToU_Accept.Text = "&ACCEPT";
                    if (AcceptCheck_ToU.Checked) {
                        ToU_Accept.Enabled = true;
                        ToU_Accept.BackColor = BackColor;
                    }
                }
            }
        }
    }
}
