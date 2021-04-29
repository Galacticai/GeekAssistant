
using System.Windows.Forms;

namespace GeekAssistant.Forms {
    partial class Preparing : System.Windows.Forms.Form {
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
            this.Preparing_Label = new System.Windows.Forms.Label();
            this.Preparing_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Preparing_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Preparing_Label
            // 
            this.Preparing_Label.BackColor = System.Drawing.Color.Transparent;
            this.Preparing_Label.Location = new System.Drawing.Point(77, 9);
            this.Preparing_Label.Name = "Preparing_Label";
            this.Preparing_Label.Size = new System.Drawing.Size(255, 59);
            this.Preparing_Label.TabIndex = 0;
            this.Preparing_Label.Text = "Hold on for a moment... Preparing...";
            this.Preparing_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Preparing_PictureBox
            // 
            this.Preparing_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Preparing_PictureBox.Image = global::prop.GA.G_noG;
            this.Preparing_PictureBox.Location = new System.Drawing.Point(7, 8);
            this.Preparing_PictureBox.Name = "Preparing_PictureBox";
            this.Preparing_PictureBox.Size = new System.Drawing.Size(59, 60);
            this.Preparing_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Preparing_PictureBox.TabIndex = 1;
            this.Preparing_PictureBox.TabStop = false;
            // 
            // Preparing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(339, 76);
            this.ControlBox = false;
            this.Controls.Add(this.Preparing_PictureBox);
            this.Controls.Add(this.Preparing_Label);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preparing";
            this.Opacity = 0.92D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Load += new System.EventHandler(this.Preparing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Preparing_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Label Preparing_Label;
        public PictureBox Preparing_PictureBox;
    }
}