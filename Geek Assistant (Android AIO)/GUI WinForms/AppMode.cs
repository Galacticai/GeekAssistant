﻿using System;
using System.Drawing;
using System.Windows.Forms;
using GeekAssistant.Modules.General;
using GeekAssistant.Modules.General.SetTheme;
using GeekAssistant.Modules.General.Companion.Style;
using GeekAssistant.Controls;

namespace GeekAssistant.Forms {
    public partial class AppMode : Form {
        private static string workCode_init => "AM";
        private static string workTitle => "App Mode";
        public AppMode() {
            InitializeComponent();
        }

        private void AssignEvents() {
            FormClosing += new(RunGeekAssistant.All_FormClosed);
            GotFocus += new(AppMode_GotFocus);
            LostFocus += new(AppMode_GotFocus);
            MouseEnter += new(AppMode_GotFocus);
            MouseLeave += new(AppMode_GotFocus);

            startup_dontShow.Click += new(startup_dontShow_Click);
            startup_dontShow.MouseEnter += new(startup_dontShow_MouseEnter);
            startup_dontShow.MouseLeave += new(startup_dontShow_MouseLeave);
            startup_dontShow.MouseDown += new(startup_dontShow_MouseDown); startup_dontShow.KeyDown += new(startup_dontShow_MouseDown);
            startup_dontShow.MouseUp += new(startup_dontShow_Mouseup); startup_dontShow.KeyUp += new(startup_dontShow_Mouseup);

            start_newbie.Click += new(start_newbie_Click);
            //start_newbie.MouseEnter += new(start_newbie_MouseEnter_MouseUp); start_newbie.MouseUp += new(start_newbie_MouseEnter_MouseUp); start_newbie.KeyUp += new(start_newbie_MouseEnter_MouseUp);
            //start_newbie.MouseDown += new(start_newbie_MouseDown); start_newbie.KeyDown += new(start_newbie_MouseDown);
            //start_newbie.MouseLeave += new(start_newbie_MouseLeave);

            start_default.Click += new(start_default_Click);
            //start_default.MouseEnter += new(start_default_MouseEnter_MouseUp); start_default.MouseUp += new(start_default_MouseEnter_MouseUp); start_default.KeyUp += new(start_default_MouseEnter_MouseUp);
            //start_default.MouseDown += new(start_default_MouseUp_KeyDown); start_default.KeyDown += new(start_default_MouseUp_KeyDown);
            //start_default.MouseLeave += new(start_default_MouseLeave);

            start_expert.Click += new(start_expert_Click);
            //start_expert.MouseEnter += new(start_expert_MouseEnter_MouseUp); start_expert.MouseUp += new(start_expert_MouseEnter_MouseUp); start_expert.KeyUp += new(start_expert_MouseEnter_MouseUp);
            //start_expert.MouseDown += new(start_expert_MouseDown_KeyDown); start_expert.KeyDown += new(start_expert_MouseDown_KeyDown);
            //start_expert.MouseLeave += new(start_expert_MouseLeave);
        }

        private void AppMode_GotFocus(object sender, EventArgs e) {
            start_newbie.ForeColor = Color.Green;
            start_default.ForeColor = SystemColors.Highlight;
            start_expert.ForeColor = Color.Firebrick;

        }

        private void AppMode_Load(object sender, EventArgs e) {
            AssignEvents();

            if (c.S.AppMode_dontshow) {
                AppMode_Do((AppModelvls)c.S.AppMode_Current);
                Close();
            }
            SetTheme.Run(this);
        }

        public enum AppModelvls { Newbie, Default, Expert }
        private void AppMode_Do(AppModelvls AppModelvl = AppModelvls.Default) {
            switch (AppModelvl) {
                case AppModelvls.Newbie:
                    //common.S.startup_newbie = true
                    //common.S.startup_moderate = false 
                    FeatureUnavailable.Run($"{workCode_init}-n", "Newbie Mode"); // (current) - newbie
                    break;
                case AppModelvls.Default:
                    c.Home.Show();
                    Close();
                    break;
                case AppModelvls.Expert:
                    System.Media.SystemSounds.Beep.Play();
                    inf.detail.code = $"{workCode_init}-e"; // (current) - expert
                    inf.Run(inf.lvls.Error, "Expert Mode",
                              "Experts don't need assitance...",
                             ("OK", null));
                    inf.detail.code = $"{workCode_init}-eGd"; // (current) - expert Go default
                    inf.Run(inf.lvls.Information, "Expert Mode",
                             "Okay... There's no \"Expert Mode\". You will be redirected to the default mode.",
                           ("Continue", null));
                    AppModelvl = AppModelvls.Default;
                    start_default.PerformClick();
                    break;
            }
            c.S.AppMode_Current = (int)AppModelvl;
        }

        private void startup_dontShow_MouseEnter(object sender, EventArgs e) {
            if (c.S.AppMode_dontshow) {
                startup_dontShow.BackColor = Color.FromArgb(0, 130, 0);
                startup_dontShow.ForeColor = Color.White;
            } else {
                startup_dontShow.BackColor = colors.Misc.Green();
                startup_dontShow.ForeColor = SystemColors.ControlText;
            }
        }
        private void startup_dontShow_MouseLeave(object sender, EventArgs e) {
            if (c.S.AppMode_dontshow) {
                startup_dontShow.BackColor = Color.Green;
                startup_dontShow.ForeColor = Color.White;
            } else {
                startup_dontShow.BackColor = Color.Transparent;
                startup_dontShow.ForeColor = colors.UI.fg();
            }
        }
        private void startup_dontShow_MouseDown(object sender, EventArgs e) {
            SwitchButton_Style.MouseDown(startup_dontShow);
        }
        private void startup_dontShow_Mouseup(object sender, EventArgs e) {
            SwitchButton_Style.MouseUp(startup_dontShow);
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
            AppMode_Do(AppModelvls.Default);
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
            AppMode_Do(AppModelvls.Expert);
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
