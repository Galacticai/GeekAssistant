<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToU
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToU))
        Me.GeekAssistant_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Icon_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.DontShow_ToU = New System.Windows.Forms.CheckBox()
        Me.AcceptCheck_ToU = New System.Windows.Forms.CheckBox()
        Me.TermsOfUse_Box = New System.Windows.Forms.RichTextBox()
        Me.ToU_Reject = New System.Windows.Forms.Button()
        Me.ToU_Accept = New System.Windows.Forms.Button()
        Me.ButtonsBG_UI = New System.Windows.Forms.PictureBox()
        Me.ToURead_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ToUTitle_Label = New System.Windows.Forms.Label()
        CType(Me.GeekAssistant_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonsBG_UI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GeekAssistant_PictureBox
        '
        Me.GeekAssistant_PictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GeekAssistant_PictureBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GeekAssistant_PictureBox.Image = Global.GeekAssistant.My.Resources.Resources.Geek_Assistant___50__alpha40
        Me.GeekAssistant_PictureBox.Location = New System.Drawing.Point(26, 450)
        Me.GeekAssistant_PictureBox.Name = "GeekAssistant_PictureBox"
        Me.GeekAssistant_PictureBox.Size = New System.Drawing.Size(150, 46)
        Me.GeekAssistant_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GeekAssistant_PictureBox.TabIndex = 85575
        Me.GeekAssistant_PictureBox.TabStop = False
        '
        'Icon_PictureBox
        '
        Me.Icon_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.Icon_PictureBox.Image = Global.GeekAssistant.My.Resources.Resources.ToU_64
        Me.Icon_PictureBox.Location = New System.Drawing.Point(24, 13)
        Me.Icon_PictureBox.Name = "Icon_PictureBox"
        Me.Icon_PictureBox.Size = New System.Drawing.Size(64, 64)
        Me.Icon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Icon_PictureBox.TabIndex = 85574
        Me.Icon_PictureBox.TabStop = False
        '
        'Copyright
        '
        Me.Copyright.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Copyright.AutoSize = True
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Copyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Copyright.Location = New System.Drawing.Point(26, 408)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(211, 19)
        Me.Copyright.TabIndex = 85571
        Me.Copyright.Text = "© Geek Assistant By NHKomaiha"
        '
        'DontShow_ToU
        '
        Me.DontShow_ToU.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DontShow_ToU.AutoSize = True
        Me.DontShow_ToU.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DontShow_ToU.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DontShow_ToU.Location = New System.Drawing.Point(24, 474)
        Me.DontShow_ToU.Margin = New System.Windows.Forms.Padding(0)
        Me.DontShow_ToU.Name = "DontShow_ToU"
        Me.DontShow_ToU.Size = New System.Drawing.Size(152, 21)
        Me.DontShow_ToU.TabIndex = 85568
        Me.DontShow_ToU.Text = "Don't show again      "
        Me.DontShow_ToU.UseVisualStyleBackColor = False
        '
        'AcceptCheck_ToU
        '
        Me.AcceptCheck_ToU.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AcceptCheck_ToU.AutoSize = True
        Me.AcceptCheck_ToU.BackColor = System.Drawing.Color.WhiteSmoke
        Me.AcceptCheck_ToU.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcceptCheck_ToU.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AcceptCheck_ToU.Location = New System.Drawing.Point(24, 453)
        Me.AcceptCheck_ToU.Margin = New System.Windows.Forms.Padding(0)
        Me.AcceptCheck_ToU.Name = "AcceptCheck_ToU"
        Me.AcceptCheck_ToU.Size = New System.Drawing.Size(168, 21)
        Me.AcceptCheck_ToU.TabIndex = 85569
        Me.AcceptCheck_ToU.Text = "I understand and accept"
        Me.AcceptCheck_ToU.UseVisualStyleBackColor = False
        '
        'TermsOfUse_Box
        '
        Me.TermsOfUse_Box.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TermsOfUse_Box.BackColor = System.Drawing.Color.White
        Me.TermsOfUse_Box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TermsOfUse_Box.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TermsOfUse_Box.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TermsOfUse_Box.Location = New System.Drawing.Point(26, 92)
        Me.TermsOfUse_Box.Name = "TermsOfUse_Box"
        Me.TermsOfUse_Box.ReadOnly = True
        Me.TermsOfUse_Box.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.TermsOfUse_Box.Size = New System.Drawing.Size(483, 312)
        Me.TermsOfUse_Box.TabIndex = 85567
        Me.TermsOfUse_Box.Text = resources.GetString("TermsOfUse_Box.Text")
        '
        'ToU_Reject
        '
        Me.ToU_Reject.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToU_Reject.BackColor = System.Drawing.Color.White
        Me.ToU_Reject.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ToU_Reject.FlatAppearance.BorderSize = 0
        Me.ToU_Reject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToU_Reject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ToU_Reject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToU_Reject.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToU_Reject.Location = New System.Drawing.Point(204, 450)
        Me.ToU_Reject.Name = "ToU_Reject"
        Me.ToU_Reject.Size = New System.Drawing.Size(133, 46)
        Me.ToU_Reject.TabIndex = 85566
        Me.ToU_Reject.Text = "&Reject"
        Me.ToU_Reject.UseVisualStyleBackColor = False
        '
        'ToU_Accept
        '
        Me.ToU_Accept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToU_Accept.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToU_Accept.Enabled = False
        Me.ToU_Accept.FlatAppearance.BorderSize = 0
        Me.ToU_Accept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToU_Accept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.ToU_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToU_Accept.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToU_Accept.Location = New System.Drawing.Point(337, 450)
        Me.ToU_Accept.Name = "ToU_Accept"
        Me.ToU_Accept.Size = New System.Drawing.Size(173, 46)
        Me.ToU_Accept.TabIndex = 85565
        Me.ToU_Accept.Text = "&ACCEPT"
        Me.ToU_Accept.UseVisualStyleBackColor = False
        '
        'ButtonsBG_UI
        '
        Me.ButtonsBG_UI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonsBG_UI.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonsBG_UI.Enabled = False
        Me.ButtonsBG_UI.Location = New System.Drawing.Point(0, 441)
        Me.ButtonsBG_UI.Name = "ButtonsBG_UI"
        Me.ButtonsBG_UI.Size = New System.Drawing.Size(536, 65)
        Me.ButtonsBG_UI.TabIndex = 85570
        Me.ButtonsBG_UI.TabStop = False
        '
        'ToURead_Timer
        '
        Me.ToURead_Timer.Interval = 1000
        '
        'ToUTitle_Label
        '
        Me.ToUTitle_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToUTitle_Label.BackColor = System.Drawing.Color.Transparent
        Me.ToUTitle_Label.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToUTitle_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ToUTitle_Label.Location = New System.Drawing.Point(105, 13)
        Me.ToUTitle_Label.Name = "ToUTitle_Label"
        Me.ToUTitle_Label.Size = New System.Drawing.Size(404, 64)
        Me.ToUTitle_Label.TabIndex = 85577
        Me.ToUTitle_Label.Text = "Terms of Use"
        Me.ToUTitle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(536, 506)
        Me.Controls.Add(Me.ToUTitle_Label)
        Me.Controls.Add(Me.Icon_PictureBox)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.DontShow_ToU)
        Me.Controls.Add(Me.AcceptCheck_ToU)
        Me.Controls.Add(Me.TermsOfUse_Box)
        Me.Controls.Add(Me.ToU_Reject)
        Me.Controls.Add(Me.ToU_Accept)
        Me.Controls.Add(Me.GeekAssistant_PictureBox)
        Me.Controls.Add(Me.ButtonsBG_UI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ToU"
        Me.Padding = New System.Windows.Forms.Padding(23, 69, 23, 23)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Terms of Use — Geek Assistance"
        CType(Me.GeekAssistant_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonsBG_UI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GeekAssistant_PictureBox As PictureBox
    Friend WithEvents Icon_PictureBox As PictureBox
    Friend WithEvents Copyright As Label
    Friend WithEvents TermsOfUse_Box As RichTextBox
    Friend WithEvents ToU_Reject As Button
    Friend WithEvents ToU_Accept As Button
    Friend WithEvents ButtonsBG_UI As PictureBox
    Friend WithEvents ToURead_Timer As Timer
    Friend WithEvents DontShow_ToU As System.Windows.Forms.CheckBox
    Friend WithEvents AcceptCheck_ToU As System.Windows.Forms.CheckBox
    Friend WithEvents ToUTitle_Label As Label
End Class
