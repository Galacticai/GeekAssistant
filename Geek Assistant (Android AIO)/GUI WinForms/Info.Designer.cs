
using System.Windows.Forms;

namespace GeekAssistant.Forms {
    class Info : System.Windows.Forms.Form {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.No_Button = new System.Windows.Forms.Button();
            this.ButtonsBG_UI = new System.Windows.Forms.PictureBox();
            this.info_PictureBox = new System.Windows.Forms.PictureBox();
            this.Yes_Button = new System.Windows.Forms.Button();
            this.title_Label = new System.Windows.Forms.Label();
            this.msg_Textbox = new System.Windows.Forms.TextBox();
            this.Copy_Button = new System.Windows.Forms.Button();
            this.CopyToClipboard_Timer = new System.Windows.Forms.Timer(this.components);
            this.GeekAssistant_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonsBG_UI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeekAssistant_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // No_Button
            // 
            this.No_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.No_Button.BackColor = System.Drawing.Color.Transparent;
            this.No_Button.DialogResult = System.Windows.Forms.DialogResult.No;
            this.No_Button.FlatAppearance.BorderSize = 0;
            this.No_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.No_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.No_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.No_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.No_Button.Location = new System.Drawing.Point(390, 276);
            this.No_Button.Name = "No_Button";
            this.No_Button.Size = new System.Drawing.Size(132, 30);
            this.No_Button.TabIndex = 85561;
            this.No_Button.Text = "Close";
            this.No_Button.UseVisualStyleBackColor = false;
            // 
            // ButtonsBG_UI
            // 
            this.ButtonsBG_UI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsBG_UI.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonsBG_UI.Enabled = false;
            this.ButtonsBG_UI.Location = new System.Drawing.Point(-4, 265);
            this.ButtonsBG_UI.Name = "ButtonsBG_UI";
            this.ButtonsBG_UI.Size = new System.Drawing.Size(561, 54);
            this.ButtonsBG_UI.TabIndex = 85562;
            this.ButtonsBG_UI.TabStop = false;
            // 
            // info_PictureBox
            // 
            this.info_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.info_PictureBox.Image = global::prop.x64.Warning_Red_64;
            this.info_PictureBox.Location = new System.Drawing.Point(27, 12);
            this.info_PictureBox.Name = "info_PictureBox";
            this.info_PictureBox.Size = new System.Drawing.Size(64, 64);
            this.info_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.info_PictureBox.TabIndex = 85563;
            this.info_PictureBox.TabStop = false;
            // 
            // Yes_Button
            // 
            this.Yes_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Yes_Button.BackColor = System.Drawing.Color.Transparent;
            this.Yes_Button.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Yes_Button.FlatAppearance.BorderSize = 0;
            this.Yes_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(32)))));
            this.Yes_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Yes_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yes_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Yes_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Yes_Button.Location = new System.Drawing.Point(235, 276);
            this.Yes_Button.Name = "Yes_Button";
            this.Yes_Button.Size = new System.Drawing.Size(155, 30);
            this.Yes_Button.TabIndex = 85565;
            this.Yes_Button.Text = "Yes Button";
            this.Yes_Button.UseVisualStyleBackColor = false;
            this.Yes_Button.Visible = false;
            // 
            // title_Label
            // 
            this.title_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_Label.BackColor = System.Drawing.Color.Transparent;
            this.title_Label.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.title_Label.Location = new System.Drawing.Point(103, 12);
            this.title_Label.Name = "title_Label";
            this.title_Label.Size = new System.Drawing.Size(419, 64);
            this.title_Label.TabIndex = 85566;
            this.title_Label.Text = "❰E-Code❱ Error general title";
            this.title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // msg_Textbox
            // 
            this.msg_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msg_Textbox.BackColor = System.Drawing.Color.White;
            this.msg_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msg_Textbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msg_Textbox.Location = new System.Drawing.Point(30, 91);
            this.msg_Textbox.MaxLength = 99999;
            this.msg_Textbox.Multiline = true;
            this.msg_Textbox.Name = "msg_Textbox";
            this.msg_Textbox.PlaceholderText = "Error details and some potential fixes to the problem will appear here Error deta" +
    "ils and some potential fixes to the problem will appear here";
            this.msg_Textbox.ReadOnly = true;
            this.msg_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.msg_Textbox.Size = new System.Drawing.Size(537, 168);
            this.msg_Textbox.TabIndex = 85567;
            this.msg_Textbox.TabStop = false;
            this.msg_Textbox.Text = "Error details and some potential fixes to the problem will appear here Error deta" +
    "ils and some potential fixes to the problem will appear here";
            // 
            // Copy_Button
            // 
            this.Copy_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Copy_Button.BackColor = System.Drawing.Color.Transparent;
            this.Copy_Button.FlatAppearance.BorderSize = 0;
            this.Copy_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Copy_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Copy_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copy_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Copy_Button.Image = global::prop.x24.Copy_B_24;
            this.Copy_Button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Copy_Button.Location = new System.Drawing.Point(27, 276);
            this.Copy_Button.Name = "Copy_Button";
            this.Copy_Button.Size = new System.Drawing.Size(79, 30);
            this.Copy_Button.TabIndex = 85568;
            this.Copy_Button.Text = "Copy  ";
            this.Copy_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Copy_Button.UseVisualStyleBackColor = false;
            this.Copy_Button.Visible = false;
            // 
            // CopyToClipboard_Timer
            // 
            this.CopyToClipboard_Timer.Interval = 2500;
            // 
            // GeekAssistant_PictureBox
            // 
            this.GeekAssistant_PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GeekAssistant_PictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GeekAssistant_PictureBox.Image = global::prop.GA.Geek_Assistant___50__alpha40;
            this.GeekAssistant_PictureBox.Location = new System.Drawing.Point(27, 276);
            this.GeekAssistant_PictureBox.Name = "GeekAssistant_PictureBox";
            this.GeekAssistant_PictureBox.Size = new System.Drawing.Size(150, 30);
            this.GeekAssistant_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GeekAssistant_PictureBox.TabIndex = 85578;
            this.GeekAssistant_PictureBox.TabStop = false;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.No_Button;
            this.ClientSize = new System.Drawing.Size(550, 316);
            this.Controls.Add(this.msg_Textbox);
            this.Controls.Add(this.title_Label);
            this.Controls.Add(this.Yes_Button);
            this.Controls.Add(this.info_PictureBox);
            this.Controls.Add(this.No_Button);
            this.Controls.Add(this.GeekAssistant_PictureBox);
            this.Controls.Add(this.ButtonsBG_UI);
            this.Controls.Add(this.Copy_Button);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 770);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 250);
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "(i) Level: ❰E-Code❱  — Geek Assistant";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonsBG_UI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeekAssistant_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public Button No_Button;
        public PictureBox ButtonsBG_UI;
        public PictureBox info_PictureBox;
        public Button Yes_Button;
        public Label title_Label;
        public TextBox msg_Textbox;
        public Button Copy_Button;
        public Timer CopyToClipboard_Timer;
        public PictureBox GeekAssistant_PictureBox;
        #endregion
    }
}