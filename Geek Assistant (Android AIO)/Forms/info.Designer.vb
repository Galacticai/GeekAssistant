<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class info
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(info))
        Me.No_Button = New System.Windows.Forms.Button()
        Me.ButtonsBG_UI = New System.Windows.Forms.PictureBox()
        Me.info_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Yes_Button = New System.Windows.Forms.Button()
        Me.title_Label = New System.Windows.Forms.Label()
        Me.msg_Textbox = New System.Windows.Forms.TextBox()
        Me.Copy_Button = New System.Windows.Forms.Button()
        Me.CopyToClipboard_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GeekAssistant_PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.ButtonsBG_UI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.info_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeekAssistant_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'No_Button
        '
        Me.No_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.No_Button.BackColor = System.Drawing.Color.Transparent
        Me.No_Button.DialogResult = System.Windows.Forms.DialogResult.No
        Me.No_Button.FlatAppearance.BorderSize = 0
        Me.No_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.No_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.No_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.No_Button.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_Button.Location = New System.Drawing.Point(431, 277)
        Me.No_Button.Name = "No_Button"
        Me.No_Button.Size = New System.Drawing.Size(91, 30)
        Me.No_Button.TabIndex = 85561
        Me.No_Button.Text = "Close"
        Me.No_Button.UseVisualStyleBackColor = False
        '
        'ButtonsBG_UI
        '
        Me.ButtonsBG_UI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonsBG_UI.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonsBG_UI.Enabled = False
        Me.ButtonsBG_UI.Location = New System.Drawing.Point(-4, 266)
        Me.ButtonsBG_UI.Name = "ButtonsBG_UI"
        Me.ButtonsBG_UI.Size = New System.Drawing.Size(561, 54)
        Me.ButtonsBG_UI.TabIndex = 85562
        Me.ButtonsBG_UI.TabStop = False
        '
        'info_PictureBox
        '
        Me.info_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.info_PictureBox.Image = Global.GeekAssistant.My.Resources.Resources.Warning_Red_64
        Me.info_PictureBox.Location = New System.Drawing.Point(27, 12)
        Me.info_PictureBox.Name = "info_PictureBox"
        Me.info_PictureBox.Size = New System.Drawing.Size(64, 64)
        Me.info_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.info_PictureBox.TabIndex = 85563
        Me.info_PictureBox.TabStop = False
        '
        'Yes_Button
        '
        Me.Yes_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Yes_Button.BackColor = System.Drawing.Color.Transparent
        Me.Yes_Button.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Yes_Button.FlatAppearance.BorderSize = 0
        Me.Yes_Button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.Yes_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Yes_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Yes_Button.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Yes_Button.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Yes_Button.Location = New System.Drawing.Point(260, 277)
        Me.Yes_Button.Name = "Yes_Button"
        Me.Yes_Button.Size = New System.Drawing.Size(171, 30)
        Me.Yes_Button.TabIndex = 85565
        Me.Yes_Button.Text = "Yes Button"
        Me.Yes_Button.UseVisualStyleBackColor = False
        Me.Yes_Button.Visible = False
        '
        'title_Label
        '
        Me.title_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.title_Label.BackColor = System.Drawing.Color.Transparent
        Me.title_Label.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.title_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.title_Label.Location = New System.Drawing.Point(103, 12)
        Me.title_Label.Name = "title_Label"
        Me.title_Label.Size = New System.Drawing.Size(419, 64)
        Me.title_Label.TabIndex = 85566
        Me.title_Label.Text = "❰E-Code❱ Error general title"
        Me.title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'msg_Textbox
        '
        Me.msg_Textbox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.msg_Textbox.BackColor = System.Drawing.Color.White
        Me.msg_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.msg_Textbox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msg_Textbox.Location = New System.Drawing.Point(27, 91)
        Me.msg_Textbox.MaxLength = 9999999
        Me.msg_Textbox.Multiline = True
        Me.msg_Textbox.Name = "msg_Textbox"
        Me.msg_Textbox.ReadOnly = True
        Me.msg_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.msg_Textbox.Size = New System.Drawing.Size(511, 169)
        Me.msg_Textbox.TabIndex = 85567
        Me.msg_Textbox.TabStop = False
        Me.msg_Textbox.Text = "Error details and some potential fixes to the problem will appear here"
        '
        'Copy_Button
        '
        Me.Copy_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Copy_Button.BackColor = System.Drawing.Color.Transparent
        Me.Copy_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Copy_Button.FlatAppearance.BorderSize = 0
        Me.Copy_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Copy_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Copy_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Copy_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copy_Button.Image = Global.GeekAssistant.My.Resources.Resources.Copy_B_24
        Me.Copy_Button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Copy_Button.Location = New System.Drawing.Point(27, 277)
        Me.Copy_Button.Name = "Copy_Button"
        Me.Copy_Button.Size = New System.Drawing.Size(79, 30)
        Me.Copy_Button.TabIndex = 85568
        Me.Copy_Button.Text = "Copy  "
        Me.Copy_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Copy_Button.UseVisualStyleBackColor = False
        '
        'CopyToClipboard_Timer
        '
        Me.CopyToClipboard_Timer.Interval = 2500
        '
        'GeekAssistant_PictureBox
        '
        Me.GeekAssistant_PictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GeekAssistant_PictureBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GeekAssistant_PictureBox.Image = Global.GeekAssistant.My.Resources.Resources.Geek_Assistant___50__alpha40
        Me.GeekAssistant_PictureBox.Location = New System.Drawing.Point(27, 277)
        Me.GeekAssistant_PictureBox.Name = "GeekAssistant_PictureBox"
        Me.GeekAssistant_PictureBox.Size = New System.Drawing.Size(150, 30)
        Me.GeekAssistant_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GeekAssistant_PictureBox.TabIndex = 85578
        Me.GeekAssistant_PictureBox.TabStop = False
        '
        'info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.No_Button
        Me.ClientSize = New System.Drawing.Size(550, 316)
        Me.Controls.Add(Me.msg_Textbox)
        Me.Controls.Add(Me.title_Label)
        Me.Controls.Add(Me.Yes_Button)
        Me.Controls.Add(Me.info_PictureBox)
        Me.Controls.Add(Me.No_Button)
        Me.Controls.Add(Me.GeekAssistant_PictureBox)
        Me.Controls.Add(Me.ButtonsBG_UI)
        Me.Controls.Add(Me.Copy_Button)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(900, 770)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(520, 250)
        Me.Name = "info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "(i) Level: ❰E-Code❱  — Geek Assistant"
        Me.TopMost = True
        CType(Me.ButtonsBG_UI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.info_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeekAssistant_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents No_Button As Button
    Friend WithEvents ButtonsBG_UI As PictureBox
    Friend WithEvents info_PictureBox As PictureBox
    Friend WithEvents Yes_Button As Button
    Friend WithEvents title_Label As Label
    Friend WithEvents msg_Textbox As TextBox
    Friend WithEvents Copy_Button As Button
    Friend WithEvents CopyToClipboard_Timer As Timer
    Friend WithEvents GeekAssistant_PictureBox As PictureBox
End Class
