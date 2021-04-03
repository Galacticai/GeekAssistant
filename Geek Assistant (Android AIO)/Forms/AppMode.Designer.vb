<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AppMode
    Inherits System.Windows.Forms.Form 'MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppMode))
        Me.start_expert = New System.Windows.Forms.Button()
        Me.start_default = New System.Windows.Forms.Button()
        Me.start_newbie = New System.Windows.Forms.Button()
        Me.startup_info = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Unavalable_Tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.startup_dontShow = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'start_expert
        '
        Me.start_expert.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.start_expert.BackColor = System.Drawing.Color.Transparent
        Me.start_expert.FlatAppearance.BorderSize = 0
        Me.start_expert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.start_expert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.start_expert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.start_expert.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.start_expert.ForeColor = System.Drawing.Color.Firebrick
        Me.start_expert.Location = New System.Drawing.Point(292, 132)
        Me.start_expert.Name = "start_expert"
        Me.start_expert.Size = New System.Drawing.Size(132, 35)
        Me.start_expert.TabIndex = 8
        Me.start_expert.Text = "&Expert"
        Me.start_expert.UseVisualStyleBackColor = False
        '
        'start_default
        '
        Me.start_default.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.start_default.BackColor = System.Drawing.Color.Transparent
        Me.start_default.FlatAppearance.BorderSize = 0
        Me.start_default.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.start_default.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.start_default.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.start_default.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.start_default.ForeColor = System.Drawing.SystemColors.Highlight
        Me.start_default.Location = New System.Drawing.Point(159, 132)
        Me.start_default.Name = "start_default"
        Me.start_default.Size = New System.Drawing.Size(133, 35)
        Me.start_default.TabIndex = 7
        Me.start_default.Text = "&Default"
        Me.start_default.UseVisualStyleBackColor = False
        '
        'start_newbie
        '
        Me.start_newbie.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.start_newbie.BackColor = System.Drawing.Color.Transparent
        Me.start_newbie.FlatAppearance.BorderSize = 0
        Me.start_newbie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.start_newbie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.start_newbie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.start_newbie.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.start_newbie.ForeColor = System.Drawing.Color.Green
        Me.start_newbie.Location = New System.Drawing.Point(27, 132)
        Me.start_newbie.Name = "start_newbie"
        Me.start_newbie.Size = New System.Drawing.Size(132, 35)
        Me.start_newbie.TabIndex = 6
        Me.start_newbie.Text = "&Newbie"
        Me.Unavalable_Tooltip.SetToolTip(Me.start_newbie, "Still in development...")
        Me.start_newbie.UseVisualStyleBackColor = False
        '
        'startup_info
        '
        Me.startup_info.BackColor = System.Drawing.Color.Transparent
        Me.startup_info.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startup_info.Location = New System.Drawing.Point(24, 70)
        Me.startup_info.Name = "startup_info"
        Me.startup_info.Size = New System.Drawing.Size(403, 56)
        Me.startup_info.TabIndex = 5
        Me.startup_info.Text = "Thanks for downloading Geek Assistance for Android." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please select the mode to st" &
    "art with:"
        Me.startup_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(24, 129)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(403, 41)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Unavalable_Tooltip
        '
        Me.Unavalable_Tooltip.AutomaticDelay = 0
        Me.Unavalable_Tooltip.AutoPopDelay = 10000
        Me.Unavalable_Tooltip.InitialDelay = 0
        Me.Unavalable_Tooltip.ReshowDelay = 0
        Me.Unavalable_Tooltip.ShowAlways = True
        Me.Unavalable_Tooltip.StripAmpersands = True
        Me.Unavalable_Tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        Me.Unavalable_Tooltip.ToolTipTitle = "Unavailable"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(24, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 53)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Application Mode"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.GeekAssistant.My.Resources.Layout_3DLine_toDown
        Me.PictureBox2.Location = New System.Drawing.Point(24, 60)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(403, 7)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'startup_dontShow
        '
        Me.startup_dontShow.BackColor = System.Drawing.Color.Transparent
        Me.startup_dontShow.FlatAppearance.BorderSize = 0
        Me.startup_dontShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.startup_dontShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.startup_dontShow.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startup_dontShow.Location = New System.Drawing.Point(24, 176)
        Me.startup_dontShow.Name = "startup_dontShow"
        Me.startup_dontShow.Size = New System.Drawing.Size(403, 26)
        Me.startup_dontShow.TabIndex = 14
        Me.startup_dontShow.Text = "&Remember && Don't Ask Again"
        Me.startup_dontShow.UseVisualStyleBackColor = False
        '
        'AppMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.GeekAssistant.My.Resources.LightBlue_Up_Gradient
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(453, 218)
        Me.Controls.Add(Me.startup_dontShow)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.start_expert)
        Me.Controls.Add(Me.start_default)
        Me.Controls.Add(Me.start_newbie)
        Me.Controls.Add(Me.startup_info)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AppMode"
        Me.Padding = New System.Windows.Forms.Padding(23)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Application Mode — Geek Assistant"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents start_expert As Button
    Private WithEvents start_default As Button
    Private WithEvents start_newbie As Button
    Private WithEvents startup_info As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Unavalable_Tooltip As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents startup_dontShow As Button
End Class
