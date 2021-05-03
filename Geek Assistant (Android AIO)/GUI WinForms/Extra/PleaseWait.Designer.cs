
using System.Windows.Forms;

namespace GeekAssistant.Forms {
    partial class PleaseWait : System.Windows.Forms.Form {
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
            this.PleaseWait_gif = new System.Windows.Forms.PictureBox();
            this.PleaseWait_text = new System.Windows.Forms.Label();
            this.PleaseWait_ProgressText = new System.Windows.Forms.Label();
            this.StopProcess_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PleaseWait_gif)).BeginInit();
            this.SuspendLayout();
            // 
            // PleaseWait_gif
            // 
            this.PleaseWait_gif.BackColor = System.Drawing.Color.Transparent;
            this.PleaseWait_gif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PleaseWait_gif.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.PleaseWait_gif.Image = global::prop.GA.G_noG;
            this.PleaseWait_gif.Location = new System.Drawing.Point(75, 97);
            this.PleaseWait_gif.Name = "PleaseWait_gif";
            this.PleaseWait_gif.Size = new System.Drawing.Size(72, 72);
            this.PleaseWait_gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PleaseWait_gif.TabIndex = 0;
            this.PleaseWait_gif.TabStop = false;
            this.PleaseWait_gif.UseWaitCursor = true;
            // 
            // PleaseWait_text
            // 
            this.PleaseWait_text.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PleaseWait_text.ForeColor = System.Drawing.Color.Green;
            this.PleaseWait_text.Location = new System.Drawing.Point(153, 97);
            this.PleaseWait_text.Name = "PleaseWait_text";
            this.PleaseWait_text.Size = new System.Drawing.Size(361, 72);
            this.PleaseWait_text.TabIndex = 1;
            this.PleaseWait_text.Text = "Hold on we\'re doing magic!";
            this.PleaseWait_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PleaseWait_text.UseWaitCursor = true;
            // 
            // PleaseWait_ProgressText
            // 
            this.PleaseWait_ProgressText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PleaseWait_ProgressText.BackColor = System.Drawing.Color.Transparent;
            this.PleaseWait_ProgressText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PleaseWait_ProgressText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PleaseWait_ProgressText.Location = new System.Drawing.Point(75, 180);
            this.PleaseWait_ProgressText.Name = "PleaseWait_ProgressText";
            this.PleaseWait_ProgressText.Size = new System.Drawing.Size(439, 139);
            this.PleaseWait_ProgressText.TabIndex = 85585;
            this.PleaseWait_ProgressText.Text = "Current process information will be written here. Click the blue log button for m" +
    "ore information.";
            this.PleaseWait_ProgressText.UseWaitCursor = true;
            this.PleaseWait_ProgressText.Visible = false;
            // 
            // StopProcess_Button
            // 
            this.StopProcess_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StopProcess_Button.BackColor = System.Drawing.Color.MistyRose;
            this.StopProcess_Button.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.StopProcess_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.StopProcess_Button.FlatAppearance.BorderSize = 0;
            this.StopProcess_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.StopProcess_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.StopProcess_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopProcess_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StopProcess_Button.ForeColor = System.Drawing.Color.DarkRed;
            this.StopProcess_Button.Location = new System.Drawing.Point(386, 322);
            this.StopProcess_Button.Name = "StopProcess_Button";
            this.StopProcess_Button.Size = new System.Drawing.Size(128, 30);
            this.StopProcess_Button.TabIndex = 85586;
            this.StopProcess_Button.Text = "Stop Process!";
            this.StopProcess_Button.UseVisualStyleBackColor = false;
            this.StopProcess_Button.UseWaitCursor = true;
            this.StopProcess_Button.Visible = false;
            // 
            // PleaseWait()
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 435);
            this.ControlBox = false;
            this.Controls.Add(this.StopProcess_Button);
            this.Controls.Add(this.PleaseWait_ProgressText);
            this.Controls.Add(this.PleaseWait_gif);
            this.Controls.Add(this.PleaseWait_text);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PleaseWait()";
            this.ShowInTaskbar = false;
            this.Text = "PleaseWait()";
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.PleaseWait_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PleaseWait_gif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        public PictureBox PleaseWait_gif;
        public Label PleaseWait_text;
        public Label PleaseWait_ProgressText;
        public Button StopProcess_Button;
    }
}