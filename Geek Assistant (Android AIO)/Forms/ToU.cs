 
using System; 
using System.Drawing;
using System.IO; 
using System.Windows.Forms;

namespace GeekAssistant {
    public partial class ToU : Form {

        public ToU() {
            InitializeComponent();
        }

        public bool RunningAlready = false;
        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
            common.S.Save();
            RunningAlready = false;
            if (ToURead_Timer.Enabled) ToURead_Timer.Stop();
        }

        public int ToURead_TimeAmount = 0;
        private void ToU_Load(object sender, EventArgs e) {
            GA_SetTheme.Run(Name);

            Copyright_Label.Text = GA_Ver.Run("ToU");

            Load_ToU_rtf();

            ToU_Reject.Select();

            //Accept || xy // Size xy: 337, 405 // 173, 46
            //Reject || xy // Size xy: 204, 405 // 133, 46
            if (RunningAlready) {
                SetBounds((common.Home.Width / 2) - (Width / 2) + common.Home.Location.X, common.Home.Top, Width, Height);
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
                ToU_Accept.Font = new Font("Segoe UI", 13);

                ToU_Accept.Select();
                return;
            }

            if (common.V.Revision < 3) {
                ToURead_Timer.Start();
            } else { ////Skip the 6sec timer for #Dev version 
                ToU_Accept.BackColor = BackColor;
                ToURead_TimeAmount = 6;
                AcceptCheck_ToU.Checked = true;
            }

            if (common.S.ToU_dontShow) {  //ToU:[ Dont show ToU >> Show Startup:[ Don//t show AppMode >> Start newbie / moderate ] ]
                if (common.S.AppMode_dontshow) common.Home.Show(); else common.AppMode.Show();
                Close();
            }
        }


        private void Load_ToU_rtf() {
            string terms_rtf = $"{common.GA}\terms.rtf"; //set destination
            var Current_rtf = prop.GA.TermsOfUse; //set default file
            if (common.S.DarkTheme) Current_rtf = prop.GA.TermsOfUse_Dark; //set dark file if dark theme
            if (!Directory.Exists(common.GA)) Directory.CreateDirectory(common.GA); //create GA folder if not present
            if (File.Exists(terms_rtf)) File.Delete(terms_rtf); //delete old file if present
            File.WriteAllText(terms_rtf, Current_rtf); //write file to GA
            TermsOfUse_Box.LoadFile(terms_rtf); //load file to the box
            TermsOfUse_Box.SelectionLength = 0; //deselect everything
        }

        private void ToU_Reject_MouseEnter_MouseDown_KeyDown(Object sender, EventArgs e) {
            ToU_Reject.ForeColor = GA_SetTheme.Current_bgColor();
        }

        private void ToU_Reject_MouseLeave_KeyUp(Object sender, EventArgs e) {
            ToU_Reject.ForeColor = GA_SetTheme.Current_fgColor();
        }

        private void ToU_Reject_Click(Object sender, EventArgs e) { 
            common.ErrorInfo.code = "ToU-R-H"; // ToU Rejected Hide
            GA_HideAllForms.Run(true);
            if (GA_infoAsk.Run("Rejected the terms of use",
                                 "Sorry for any inconvenience. You could contact the developer for further discussion.",
                               "Exit", "Back")) { 
                Application.Exit();
            } else {
                common.ErrorInfo.code = "ToU-R-S";
                GA_HideAllForms.Run(false);
            }
        }

        private void ToU_Accept_MouseEnter_MouseDown_KeyDown(Object sender, EventArgs e) {
            ToU_Accept.ForeColor = GA_SetTheme.Current_bgColor();
        }
        private void ToU_Accept_MouseLeave_KeyUp(Object sender, EventArgs e) {
            ToU_Accept.ForeColor = GA_SetTheme.Current_fgColor();
        }
        private void ToU_Accept_Click(Object sender, EventArgs e) {
            if (DontShow_ToU.Checked) {
                common.S.ToU_dontShow = true;
                if (RunningAlready) {
                    Close();
                    return;
                }
                if (common.S.AppMode_dontshow) { common.Home.Show(); } else {
                    common.AppMode.Show();
                    Close();
                }
            }
        }
        private void AcceptCheck_ToU_CheckedChanged(Object sender, EventArgs e) {
            if (AcceptCheck_ToU.Checked & ToURead_TimeAmount == 6) {

                ToU_Accept.Enabled = true;
                ToU_Accept.BackColor = BackColor;
            } else {
                ToU_Accept.Enabled = false;
                ToU_Accept.BackColor = ButtonsBG_UI.BackColor;
            }
        }

        private void ToURead_Timer_Tick(Object sender, EventArgs e) {

            ToU_Accept.BackColor = ButtonsBG_UI.BackColor;
            if (ToURead_TimeAmount == 5) {
                ToURead_Timer.Stop();
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
