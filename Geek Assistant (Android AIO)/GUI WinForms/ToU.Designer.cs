
using System.Windows.Forms;

namespace GeekAssistant.Forms {
    partial class ToU : Form {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToU));
            this.Icon_PictureBox = new System.Windows.Forms.PictureBox();
            this.ToUTitle_Label = new System.Windows.Forms.Label();
            this.ToUTitle_Description_Label = new System.Windows.Forms.Label();
            this.TermsOfUse_Box = new System.Windows.Forms.RichTextBox();
            this.Copyright_Label = new System.Windows.Forms.Label();
            this.ButtonsBG_UI = new System.Windows.Forms.PictureBox();
            this.ToU_Reject = new System.Windows.Forms.Button();
            this.ToU_Accept = new System.Windows.Forms.Button();
            this.GeekAssistant_PictureBox = new System.Windows.Forms.PictureBox();
            this.AcceptCheck_ToU = new System.Windows.Forms.CheckBox();
            this.DontShow_ToU = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonsBG_UI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeekAssistant_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Icon_PictureBox
            // 
            this.Icon_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Icon_PictureBox.Image = global::prop.x64.ToU_64;
            this.Icon_PictureBox.Location = new System.Drawing.Point(24, 13);
            this.Icon_PictureBox.Name = "Icon_PictureBox";
            this.Icon_PictureBox.Size = new System.Drawing.Size(64, 64);
            this.Icon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon_PictureBox.TabIndex = 0;
            this.Icon_PictureBox.TabStop = false;
            // 
            // ToUTitle_Label
            // 
            this.ToUTitle_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToUTitle_Label.BackColor = System.Drawing.Color.Transparent;
            this.ToUTitle_Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToUTitle_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(71)))));
            this.ToUTitle_Label.Location = new System.Drawing.Point(102, 13);
            this.ToUTitle_Label.Name = "ToUTitle_Label";
            this.ToUTitle_Label.Size = new System.Drawing.Size(408, 45);
            this.ToUTitle_Label.TabIndex = 1;
            this.ToUTitle_Label.Text = "Terms of Use";
            this.ToUTitle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToUTitle_Description_Label
            // 
            this.ToUTitle_Description_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToUTitle_Description_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToUTitle_Description_Label.Location = new System.Drawing.Point(109, 51);
            this.ToUTitle_Description_Label.Name = "ToUTitle_Description_Label";
            this.ToUTitle_Description_Label.Size = new System.Drawing.Size(401, 18);
            this.ToUTitle_Description_Label.TabIndex = 2;
            this.ToUTitle_Description_Label.Text = "Let\'s be on the same page.";
            this.ToUTitle_Description_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TermsOfUse_Box
            // 
            this.TermsOfUse_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TermsOfUse_Box.BackColor = System.Drawing.Color.White;
            this.TermsOfUse_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TermsOfUse_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TermsOfUse_Box.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TermsOfUse_Box.Location = new System.Drawing.Point(25, 92);
            this.TermsOfUse_Box.Name = "TermsOfUse_Box";
            this.TermsOfUse_Box.ReadOnly = true;
            this.TermsOfUse_Box.RightMargin = 480;
            this.TermsOfUse_Box.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TermsOfUse_Box.Size = new System.Drawing.Size(528, 345);
            this.TermsOfUse_Box.TabIndex = 85567;
            this.TermsOfUse_Box.Text = resources.GetString("TermsOfUse_Box.Text");
            // 
            // Copyright_Label
            // 
            this.Copyright_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Copyright_Label.AutoSize = true;
            this.Copyright_Label.BackColor = System.Drawing.Color.Transparent;
            this.Copyright_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Copyright_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(71)))));
            this.Copyright_Label.Location = new System.Drawing.Point(26, 446);
            this.Copyright_Label.Name = "Copyright_Label";
            this.Copyright_Label.Size = new System.Drawing.Size(211, 19);
            this.Copyright_Label.TabIndex = 4;
            this.Copyright_Label.Text = "© Geek Assistant By NHKomaiha";
            // 
            // ButtonsBG_UI
            // 
            this.ButtonsBG_UI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsBG_UI.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonsBG_UI.Enabled = false;
            this.ButtonsBG_UI.Location = new System.Drawing.Point(0, 476);
            this.ButtonsBG_UI.Name = "ButtonsBG_UI";
            this.ButtonsBG_UI.Size = new System.Drawing.Size(536, 65);
            this.ButtonsBG_UI.TabIndex = 5;
            this.ButtonsBG_UI.TabStop = false;
            // 
            // ToU_Reject
            // 
            this.ToU_Reject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ToU_Reject.BackColor = System.Drawing.Color.White;
            this.ToU_Reject.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ToU_Reject.FlatAppearance.BorderSize = 0;
            this.ToU_Reject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToU_Reject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ToU_Reject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToU_Reject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToU_Reject.Location = new System.Drawing.Point(204, 485);
            this.ToU_Reject.Name = "ToU_Reject";
            this.ToU_Reject.Size = new System.Drawing.Size(133, 46);
            this.ToU_Reject.TabIndex = 6;
            this.ToU_Reject.Text = "&Reject";
            this.ToU_Reject.UseVisualStyleBackColor = false;
            // 
            // ToU_Accept
            // 
            this.ToU_Accept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ToU_Accept.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ToU_Accept.Enabled = false;
            this.ToU_Accept.FlatAppearance.BorderSize = 0;
            this.ToU_Accept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToU_Accept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.ToU_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToU_Accept.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToU_Accept.Location = new System.Drawing.Point(337, 485);
            this.ToU_Accept.Name = "ToU_Accept";
            this.ToU_Accept.Size = new System.Drawing.Size(173, 46);
            this.ToU_Accept.TabIndex = 7;
            this.ToU_Accept.Text = "&ACCEPT";
            this.ToU_Accept.UseVisualStyleBackColor = false;
            // 
            // GeekAssistant_PictureBox
            // 
            this.GeekAssistant_PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GeekAssistant_PictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GeekAssistant_PictureBox.Image = global::prop.GA.Geek_Assistant___50__alpha40;
            this.GeekAssistant_PictureBox.Location = new System.Drawing.Point(26, 485);
            this.GeekAssistant_PictureBox.Name = "GeekAssistant_PictureBox";
            this.GeekAssistant_PictureBox.Size = new System.Drawing.Size(150, 46);
            this.GeekAssistant_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GeekAssistant_PictureBox.TabIndex = 8;
            this.GeekAssistant_PictureBox.TabStop = false;
            // 
            // AcceptCheck_ToU
            // 
            this.AcceptCheck_ToU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AcceptCheck_ToU.AutoSize = true;
            this.AcceptCheck_ToU.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AcceptCheck_ToU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AcceptCheck_ToU.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AcceptCheck_ToU.Location = new System.Drawing.Point(24, 488);
            this.AcceptCheck_ToU.Margin = new System.Windows.Forms.Padding(0);
            this.AcceptCheck_ToU.Name = "AcceptCheck_ToU";
            this.AcceptCheck_ToU.Size = new System.Drawing.Size(168, 21);
            this.AcceptCheck_ToU.TabIndex = 9;
            this.AcceptCheck_ToU.Text = "I understand and accept";
            this.AcceptCheck_ToU.UseVisualStyleBackColor = true;
            // 
            // DontShow_ToU
            // 
            this.DontShow_ToU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DontShow_ToU.AutoSize = true;
            this.DontShow_ToU.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DontShow_ToU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DontShow_ToU.Location = new System.Drawing.Point(24, 509);
            this.DontShow_ToU.Name = "DontShow_ToU";
            this.DontShow_ToU.Size = new System.Drawing.Size(152, 21);
            this.DontShow_ToU.TabIndex = 10;
            this.DontShow_ToU.Text = "Don\'t show again      ";
            this.DontShow_ToU.UseVisualStyleBackColor = false;
            // 
            // ToU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 541);
            this.Controls.Add(this.DontShow_ToU);
            this.Controls.Add(this.AcceptCheck_ToU);
            this.Controls.Add(this.GeekAssistant_PictureBox);
            this.Controls.Add(this.ToU_Accept);
            this.Controls.Add(this.ToU_Reject);
            this.Controls.Add(this.ButtonsBG_UI);
            this.Controls.Add(this.Copyright_Label);
            this.Controls.Add(this.TermsOfUse_Box);
            this.Controls.Add(this.ToUTitle_Description_Label);
            this.Controls.Add(this.ToUTitle_Label);
            this.Controls.Add(this.Icon_PictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(552, 720);
            this.MinimumSize = new System.Drawing.Size(552, 400);
            this.Name = "ToU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terms of Use — Geek Assistance";
            this.Load += new System.EventHandler(this.ToU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Icon_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonsBG_UI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeekAssistant_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        public PictureBox Icon_PictureBox;
        public Label ToUTitle_Label;
        public Label ToUTitle_Description_Label;
        public RichTextBox TermsOfUse_Box;
        public Label Copyright_Label;
        public PictureBox ButtonsBG_UI;
        public Button ToU_Reject;
        public Button ToU_Accept;
        public PictureBox GeekAssistant_PictureBox;
        public CheckBox AcceptCheck_ToU;
        public CheckBox DontShow_ToU;

        #endregion
    }
}