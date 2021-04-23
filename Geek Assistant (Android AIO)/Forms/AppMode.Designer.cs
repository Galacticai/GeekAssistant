
using System.Windows.Forms;

namespace GeekAssistant.Forms {
    partial class AppMode : System.Windows.Forms.Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.start_expert = new System.Windows.Forms.Button();
            this.start_default = new System.Windows.Forms.Button();
            this.start_newbie = new System.Windows.Forms.Button();
            this.startup_info = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Unavalable_Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.startup_dontShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // start_expert
            // 
            this.start_expert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.start_expert.BackColor = System.Drawing.Color.Transparent;
            this.start_expert.FlatAppearance.BorderSize = 0;
            this.start_expert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start_expert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.start_expert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_expert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start_expert.ForeColor = System.Drawing.Color.Firebrick;
            this.start_expert.Location = new System.Drawing.Point(292, 132);
            this.start_expert.Name = "start_expert";
            this.start_expert.Size = new System.Drawing.Size(132, 35);
            this.start_expert.TabIndex = 8;
            this.start_expert.Text = "&Expert";
            this.start_expert.UseVisualStyleBackColor = false;
            // 
            // start_default
            // 
            this.start_default.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.start_default.BackColor = System.Drawing.Color.Transparent;
            this.start_default.FlatAppearance.BorderSize = 0;
            this.start_default.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start_default.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.start_default.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_default.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start_default.ForeColor = System.Drawing.SystemColors.Highlight;
            this.start_default.Location = new System.Drawing.Point(159, 132);
            this.start_default.Name = "start_default";
            this.start_default.Size = new System.Drawing.Size(133, 35);
            this.start_default.TabIndex = 7;
            this.start_default.Text = "&Default";
            this.start_default.UseVisualStyleBackColor = false;
            // 
            // start_newbie
            // 
            this.start_newbie.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.start_newbie.BackColor = System.Drawing.Color.Transparent;
            this.start_newbie.FlatAppearance.BorderSize = 0;
            this.start_newbie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start_newbie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.start_newbie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_newbie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start_newbie.ForeColor = System.Drawing.Color.Green;
            this.start_newbie.Location = new System.Drawing.Point(27, 132);
            this.start_newbie.Name = "start_newbie";
            this.start_newbie.Size = new System.Drawing.Size(132, 35);
            this.start_newbie.TabIndex = 6;
            this.start_newbie.Text = "&Newbie";
            this.Unavalable_Tooltip.SetToolTip(this.start_newbie, "Still in development...");
            this.start_newbie.UseVisualStyleBackColor = false;
            // 
            // startup_info
            // 
            this.startup_info.BackColor = System.Drawing.Color.Transparent;
            this.startup_info.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startup_info.Location = new System.Drawing.Point(24, 70);
            this.startup_info.Name = "startup_info";
            this.startup_info.Size = new System.Drawing.Size(403, 56);
            this.startup_info.TabIndex = 5;
            this.startup_info.Text = "Thanks for downloading Geek Assistance for Android.\nPlease select the mode to sta" +
    "rt with:";
            this.startup_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Location = new System.Drawing.Point(24, 129);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(403, 41);
            this.PictureBox1.TabIndex = 10;
            this.PictureBox1.TabStop = false;
            // 
            // Unavalable_Tooltip
            // 
            this.Unavalable_Tooltip.AutomaticDelay = 0;
            this.Unavalable_Tooltip.AutoPopDelay = 10000;
            this.Unavalable_Tooltip.InitialDelay = 0;
            this.Unavalable_Tooltip.ReshowDelay = 0;
            this.Unavalable_Tooltip.ShowAlways = true;
            this.Unavalable_Tooltip.StripAmpersands = true;
            this.Unavalable_Tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.Unavalable_Tooltip.ToolTipTitle = "Unavailable";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.Location = new System.Drawing.Point(24, 4);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(403, 53);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Application Mode";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox2.Image = global::prop.layout.Layout_3DLine_toDown;
            this.PictureBox2.Location = new System.Drawing.Point(24, 60);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(403, 7);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 13;
            this.PictureBox2.TabStop = false;
            // 
            // startup_dontShow
            // 
            this.startup_dontShow.BackColor = System.Drawing.Color.Transparent;
            this.startup_dontShow.FlatAppearance.BorderSize = 0;
            this.startup_dontShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startup_dontShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startup_dontShow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startup_dontShow.Location = new System.Drawing.Point(24, 176);
            this.startup_dontShow.Name = "startup_dontShow";
            this.startup_dontShow.Size = new System.Drawing.Size(403, 26);
            this.startup_dontShow.TabIndex = 14;
            this.startup_dontShow.Text = "&Remember && Don//t Ask Again";
            this.startup_dontShow.UseVisualStyleBackColor = false;
            // 
            // AppMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::prop.layout.LightBlue_Up_Gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(453, 218);
            this.Controls.Add(this.startup_dontShow);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.start_expert);
            this.Controls.Add(this.start_default);
            this.Controls.Add(this.start_newbie);
            this.Controls.Add(this.startup_info);
            this.Controls.Add(this.PictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AppMode";
            this.Padding = new System.Windows.Forms.Padding(23);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Mode — Geek Assistant";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AppMode_Load);
            this.FormClosed += AppMode_Closed;
            this.GotFocus += AppMode_GotFocus;
            this.GotFocus += AppMode_GotFocus;
            this.LostFocus += AppMode_GotFocus;
            this.MouseEnter += AppMode_GotFocus;
            this.MouseLeave += AppMode_GotFocus;

            startup_dontShow.MouseEnter += startup_dontShow_MouseEnter;
            startup_dontShow.MouseLeave += startup_dontShow_MouseLeave;
            startup_dontShow.MouseDown += startup_dontShow_MouseDown; startup_dontShow.KeyDown += startup_dontShow_MouseDown;
            startup_dontShow.MouseUp += startup_dontShow_Mouseup; startup_dontShow.KeyUp += startup_dontShow_Mouseup;
            startup_dontShow.Click += startup_dontShow_Click;

            start_newbie.Click += start_newbie_Click;
            start_newbie.MouseEnter += start_newbie_MouseEnter_MouseUp; start_newbie.MouseUp += start_newbie_MouseEnter_MouseUp; start_newbie.KeyUp += start_newbie_MouseEnter_MouseUp;
            start_newbie.MouseDown += start_newbie_MouseDown; start_newbie.KeyDown += start_newbie_MouseDown;
            start_newbie.MouseLeave += start_newbie_MouseLeave;

            start_default.Click += start_default_Click;
            start_default.MouseEnter += start_default_MouseEnter_MouseUp; start_default.MouseUp += start_default_MouseEnter_MouseUp; start_default.KeyUp += start_default_MouseEnter_MouseUp;
            start_default.MouseDown += start_default_MouseUp_KeyDown; start_default.KeyDown += start_default_MouseUp_KeyDown;
            start_default.MouseLeave += start_default_MouseLeave;
NOOOOOOOOOOOOOOOOOOOOOOOOOOO
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }
        private Button start_expert;
        private Button start_default;
        private Button start_newbie;
        private Label startup_info;
        private PictureBox PictureBox1;
        private ToolTip Unavalable_Tooltip;
        private Label Label1;
        private PictureBox PictureBox2;
        private Button startup_dontShow;

        #endregion
    }
}