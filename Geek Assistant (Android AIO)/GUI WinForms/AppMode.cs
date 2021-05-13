using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeekAssistant.Forms {
    public partial class AppMode : Form {
        public AppMode() {
            InitializeComponent();
        }

        private void AssignEvents() {
            FormClosed += new(AppMode_Closed);
            GotFocus += new(AppMode_GotFocus);
            GotFocus += new(AppMode_GotFocus);
            LostFocus += new(AppMode_GotFocus);
            MouseEnter += new(AppMode_GotFocus);
            MouseLeave += new(AppMode_GotFocus);

            startup_dontShow.MouseEnter += new(startup_dontShow_MouseEnter);
            startup_dontShow.MouseLeave += new(startup_dontShow_MouseLeave);
            startup_dontShow.MouseDown += new(startup_dontShow_MouseDown); startup_dontShow.KeyDown += new(startup_dontShow_MouseDown);
            startup_dontShow.MouseUp += new(startup_dontShow_Mouseup); startup_dontShow.KeyUp += new(startup_dontShow_Mouseup);
            startup_dontShow.Click += new(startup_dontShow_Click);

            start_newbie.Click += new(start_newbie_Click);
            start_newbie.MouseEnter += new(start_newbie_MouseEnter_MouseUp); start_newbie.MouseUp += new(start_newbie_MouseEnter_MouseUp); start_newbie.KeyUp += new(start_newbie_MouseEnter_MouseUp);
            start_newbie.MouseDown += new(start_newbie_MouseDown); start_newbie.KeyDown += new(start_newbie_MouseDown);
            start_newbie.MouseLeave += new(start_newbie_MouseLeave);

            start_default.Click += new(start_default_Click);
            start_default.MouseEnter += new(start_default_MouseEnter_MouseUp); start_default.MouseUp += new(start_default_MouseEnter_MouseUp); start_default.KeyUp += new(start_default_MouseEnter_MouseUp);
            start_default.MouseDown += new(start_default_MouseUp_KeyDown); start_default.KeyDown += new(start_default_MouseUp_KeyDown);
            start_default.MouseLeave += new(start_default_MouseLeave);

            start_expert.Click += new(start_expert_Click);
            start_expert.MouseEnter += new(start_expert_MouseEnter_MouseUp); start_expert.MouseUp += new(start_expert_MouseEnter_MouseUp); start_expert.KeyUp += new(start_expert_MouseEnter_MouseUp);
            start_expert.MouseDown += new(start_expert_MouseDown_KeyDown); start_expert.KeyDown += new(start_expert_MouseDown_KeyDown);
            start_expert.MouseLeave += new(start_expert_MouseLeave);
        }

        private void AppMode_Closed(object sender, EventArgs e) {
            c.S.Save();
        }
        private void AppMode_GotFocus(object sender, EventArgs e) {
            start_newbie.ForeColor = Color.Green;
            start_default.ForeColor = SystemColors.Highlight;
            start_expert.ForeColor = Color.Firebrick;

        }

        private void AppMode_Load(object sender, EventArgs e) {
            AssignEvents();

            if (c.S.AppMode_dontshow) {
                if (c.S.AppMode_newbie) {
                    AppMode_Do(0);
                } else if (c.S.AppMode_moderate) {
                    AppMode_Do(1);
                }

                Close();
            }
            GA_SetTheme.Run(this);
        }

        private void AppMode_Do(int StartupLevel) {
            switch (StartupLevel) {
                case 0:
                    //common.S.startup_newbie = true
                    //common.S.startup_moderate = false
                    inf.detail.code = "NM-00";
                    GA_FeatureUnavailable.Run("Newbie Mode");
                    break;
                case 1:
                    c.S.AppMode_newbie = false;
                    c.S.AppMode_moderate = true;
                    Home Home = new Home();
                    Home.Show();
                    Close();
                    break;
                case 2:
                    System.Media.SystemSounds.Beep.Play();
                    inf.Run(inf.lvls.Error, "Expert Mode",
                              "Come on.. Experts don't need assitance.",
                             ("OK", null));
                    inf.Run(inf.lvls.Information, "Expert Mode",
                             "Okay... There's no \"Expert Mode\". You will be redirected to the default mode.",
                           ("Continue", null));
                    start_default.PerformClick();
                    break;
            }
        }

        private void startup_dontShow_MouseEnter(object sender, EventArgs e) {
            if (c.S.AppMode_dontshow) {
                startup_dontShow.BackColor = Color.FromArgb(0, 130, 0);
                startup_dontShow.ForeColor = Color.White;
            } else {
                if (c.S.DarkTheme) {
                    startup_dontShow.BackColor = Color.FromArgb(0, 120, 0);
                } else {
                    startup_dontShow.BackColor = Color.Honeydew;
                }

                startup_dontShow.ForeColor = SystemColors.ControlText;
            }
        }
        private void startup_dontShow_MouseLeave(object sender, EventArgs e) {
            if (c.S.AppMode_dontshow) {
                startup_dontShow.BackColor = Color.Green;
                startup_dontShow.ForeColor = Color.White;
            } else {
                startup_dontShow.BackColor = Color.Transparent;
                startup_dontShow.ForeColor = colors.fg;
            }
        }
        private void startup_dontShow_MouseDown(object sender, EventArgs e) {
            GA_SwitchButton_Style.MouseDown(startup_dontShow);
        }
        private void startup_dontShow_Mouseup(object sender, EventArgs e) {
            GA_SwitchButton_Style.MouseUp(startup_dontShow);
        }
        private void startup_dontShow_Click(object sender, EventArgs e) {
            if (c.S.AppMode_dontshow) {
                startup_dontShow.BackColor = Color.Transparent;
                c.S.AppMode_dontshow = false;
            } else {
                startup_dontShow.BackColor = Color.Green;
                c.S.AppMode_dontshow = true;
                c.S.Save();
            }
            c.S.Save();
        }

        #region "start_newbie"
        private void start_newbie_Click(object sender, EventArgs e) {
            AppMode_Do(0);
        }
        private void start_newbie_MouseEnter_MouseUp(object sender, EventArgs e) {
            start_newbie.ForeColor = Color.White;
            start_default.ForeColor = SystemColors.Highlight;
            start_expert.ForeColor = Color.Firebrick;
        }
        private void start_newbie_MouseDown(object sender, EventArgs e) {
            start_newbie.ForeColor = Color.White;
            start_default.ForeColor = SystemColors.Highlight;
            start_expert.ForeColor = Color.Firebrick;
        }
        private void start_newbie_MouseLeave(object sender, EventArgs e) {
            start_newbie.ForeColor = Color.Green;
            start_default.ForeColor = SystemColors.Highlight;
            start_expert.ForeColor = Color.Firebrick;
        }
        #endregion

        #region "start_default"
        private void start_default_Click(object sender, EventArgs e) {
            AppMode_Do(1);
        }
        private void start_default_MouseEnter_MouseUp(object sender, EventArgs e) {
            start_newbie.ForeColor = Color.Green;
            start_default.ForeColor = Color.White;
            start_expert.ForeColor = Color.Firebrick;
        }
        private void start_default_MouseUp_KeyDown(object sender, EventArgs e) {
            start_newbie.ForeColor = Color.Green;
            start_default.ForeColor = Color.White;
            start_expert.ForeColor = Color.Firebrick;
        }
        private void start_default_MouseLeave(object sender, EventArgs e) {
            start_newbie.ForeColor = Color.Green;
            start_default.ForeColor = SystemColors.Highlight;
            start_expert.ForeColor = Color.Firebrick;
        }
        #endregion

        #region "start_expert"
        private void start_expert_Click(object sender, EventArgs e) {
            AppMode_Do(2);
        }
        private void start_expert_MouseEnter_MouseUp(object sender, EventArgs e) {
            start_newbie.ForeColor = Color.Green;
            start_default.ForeColor = SystemColors.Highlight;
            start_expert.ForeColor = Color.White;
        }
        private void start_expert_MouseDown_KeyDown(object sender, EventArgs e) {
            start_newbie.ForeColor = Color.Green;
            start_default.ForeColor = SystemColors.Highlight;
            start_expert.ForeColor = Color.White;
        }
        private void start_expert_MouseLeave(object sender, EventArgs e) {
            start_newbie.ForeColor = Color.Green;
            start_default.ForeColor = SystemColors.Highlight;
            start_expert.ForeColor = Color.Firebrick;
        }

        #endregion

    }
}
