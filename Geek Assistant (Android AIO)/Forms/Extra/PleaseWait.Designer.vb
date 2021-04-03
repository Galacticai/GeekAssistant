<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PleaseWait
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PleaseWait))
        Me.PleaseWait_gif = New System.Windows.Forms.PictureBox()
        Me.PleaseWait_text = New System.Windows.Forms.Label()
        Me.PleaseWait_ProgressText = New System.Windows.Forms.Label()
        Me.StopProcess_Button = New System.Windows.Forms.Button()
        CType(Me.PleaseWait_gif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PleaseWait_gif
        '
        Me.PleaseWait_gif.BackColor = System.Drawing.Color.Transparent
        Me.PleaseWait_gif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PleaseWait_gif.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.PleaseWait_gif.Image = Global.GeekAssistant.My.Resources.Resources.G_noG
        Me.PleaseWait_gif.Location = New System.Drawing.Point(75, 97)
        Me.PleaseWait_gif.Name = "PleaseWait_gif"
        Me.PleaseWait_gif.Size = New System.Drawing.Size(72, 72)
        Me.PleaseWait_gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PleaseWait_gif.TabIndex = 0
        Me.PleaseWait_gif.TabStop = False
        Me.PleaseWait_gif.UseWaitCursor = True
        '
        'PleaseWait_text
        '
        Me.PleaseWait_text.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.PleaseWait_text.ForeColor = System.Drawing.Color.Green
        Me.PleaseWait_text.Location = New System.Drawing.Point(153, 97)
        Me.PleaseWait_text.Name = "PleaseWait_text"
        Me.PleaseWait_text.Size = New System.Drawing.Size(361, 72)
        Me.PleaseWait_text.TabIndex = 1
        Me.PleaseWait_text.Text = "Hold on we're doing magic!"
        Me.PleaseWait_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PleaseWait_text.UseWaitCursor = True
        '
        'PleaseWait_ProgressText
        '
        Me.PleaseWait_ProgressText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PleaseWait_ProgressText.BackColor = System.Drawing.Color.Transparent
        Me.PleaseWait_ProgressText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PleaseWait_ProgressText.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PleaseWait_ProgressText.Location = New System.Drawing.Point(75, 180)
        Me.PleaseWait_ProgressText.Name = "PleaseWait_ProgressText"
        Me.PleaseWait_ProgressText.Size = New System.Drawing.Size(439, 139)
        Me.PleaseWait_ProgressText.TabIndex = 85585
        Me.PleaseWait_ProgressText.Text = "Current process information will be written here. Click the blue log button for m" &
    "ore information."
        Me.PleaseWait_ProgressText.UseWaitCursor = True
        Me.PleaseWait_ProgressText.Visible = False
        '
        'StopProcess_Button
        '
        Me.StopProcess_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StopProcess_Button.BackColor = System.Drawing.Color.MistyRose
        Me.StopProcess_Button.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.StopProcess_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.StopProcess_Button.FlatAppearance.BorderSize = 0
        Me.StopProcess_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.StopProcess_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.StopProcess_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopProcess_Button.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopProcess_Button.ForeColor = System.Drawing.Color.DarkRed
        Me.StopProcess_Button.Location = New System.Drawing.Point(386, 322)
        Me.StopProcess_Button.Name = "StopProcess_Button"
        Me.StopProcess_Button.Size = New System.Drawing.Size(128, 30)
        Me.StopProcess_Button.TabIndex = 85586
        Me.StopProcess_Button.Text = "Stop Process!"
        Me.StopProcess_Button.UseVisualStyleBackColor = False
        Me.StopProcess_Button.UseWaitCursor = True
        Me.StopProcess_Button.Visible = False
        '
        'PleaseWait
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(626, 435)
        Me.ControlBox = False
        Me.Controls.Add(Me.StopProcess_Button)
        Me.Controls.Add(Me.PleaseWait_ProgressText)
        Me.Controls.Add(Me.PleaseWait_gif)
        Me.Controls.Add(Me.PleaseWait_text)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PleaseWait"
        Me.ShowInTaskbar = False
        Me.Text = "PleaseWait"
        Me.TopMost = True
        Me.UseWaitCursor = True
        CType(Me.PleaseWait_gif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PleaseWait_gif As PictureBox
    Friend WithEvents PleaseWait_text As Label
    Friend WithEvents PleaseWait_ProgressText As Label
    Friend WithEvents StopProcess_Button As Button
End Class
