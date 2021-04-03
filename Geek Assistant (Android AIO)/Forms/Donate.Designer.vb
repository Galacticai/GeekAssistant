<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Donate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Donate))
        Me.BitcoinAddress = New System.Windows.Forms.Label()
        Me.title = New System.Windows.Forms.Label()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.ButtonsBG_UI = New System.Windows.Forms.PictureBox()
        Me.BitcoinAddressQR = New System.Windows.Forms.PictureBox()
        Me.BitcoinNote = New System.Windows.Forms.Label()
        Me.GeekAssistant_PictureBox = New System.Windows.Forms.PictureBox()
        Me.BitcoinIcon = New System.Windows.Forms.PictureBox()
        Me.BitcoinTitle = New System.Windows.Forms.Label()
        Me.GooglePayTitle = New System.Windows.Forms.Label()
        Me.GooglePayIcon = New System.Windows.Forms.PictureBox()
        Me.GooglePayEmail = New System.Windows.Forms.Label()
        Me.Thanks_Label = New System.Windows.Forms.Label()
        Me.GooglePay_ClickableBG = New System.Windows.Forms.PictureBox()
        Me.Bitcoin_ClickableBG = New System.Windows.Forms.PictureBox()
        Me.GooglePayLink = New System.Windows.Forms.PictureBox()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonsBG_UI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BitcoinAddressQR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeekAssistant_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BitcoinIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GooglePayIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GooglePay_ClickableBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bitcoin_ClickableBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GooglePayLink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BitcoinAddress
        '
        Me.BitcoinAddress.BackColor = System.Drawing.Color.Transparent
        Me.BitcoinAddress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BitcoinAddress.Location = New System.Drawing.Point(71, 211)
        Me.BitcoinAddress.Name = "BitcoinAddress"
        Me.BitcoinAddress.Size = New System.Drawing.Size(315, 18)
        Me.BitcoinAddress.TabIndex = 85581
        Me.BitcoinAddress.Text = "3MiXsFtm3qVasYa1Zfpu3TCsQiZym2cWmY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BitcoinAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'title
        '
        Me.title.BackColor = System.Drawing.Color.Transparent
        Me.title.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.title.Location = New System.Drawing.Point(105, 13)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(281, 45)
        Me.title.TabIndex = 85580
        Me.title.Text = "Support The Developer"
        Me.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pic
        '
        Me.pic.BackColor = System.Drawing.Color.Transparent
        Me.pic.Image = Global.GeekAssistant.My.Resources.Resources.DonateHeart_64
        Me.pic.Location = New System.Drawing.Point(24, 13)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(64, 64)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic.TabIndex = 85578
        Me.pic.TabStop = False
        '
        'Close_Button
        '
        Me.Close_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_Button.BackColor = System.Drawing.Color.Transparent
        Me.Close_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close_Button.FlatAppearance.BorderSize = 0
        Me.Close_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Close_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close_Button.Location = New System.Drawing.Point(295, 443)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(91, 30)
        Me.Close_Button.TabIndex = 85576
        Me.Close_Button.Text = "Close"
        Me.Close_Button.UseVisualStyleBackColor = False
        '
        'ButtonsBG_UI
        '
        Me.ButtonsBG_UI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonsBG_UI.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonsBG_UI.Enabled = False
        Me.ButtonsBG_UI.Location = New System.Drawing.Point(-2, 433)
        Me.ButtonsBG_UI.Name = "ButtonsBG_UI"
        Me.ButtonsBG_UI.Size = New System.Drawing.Size(415, 53)
        Me.ButtonsBG_UI.TabIndex = 85577
        Me.ButtonsBG_UI.TabStop = False
        '
        'BitcoinAddressQR
        '
        Me.BitcoinAddressQR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BitcoinAddressQR.BackColor = System.Drawing.Color.Transparent
        Me.BitcoinAddressQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BitcoinAddressQR.Image = Global.GeekAssistant.My.Resources.Resources.BTCAddressQR
        Me.BitcoinAddressQR.Location = New System.Drawing.Point(24, 232)
        Me.BitcoinAddressQR.Name = "BitcoinAddressQR"
        Me.BitcoinAddressQR.Size = New System.Drawing.Size(362, 162)
        Me.BitcoinAddressQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BitcoinAddressQR.TabIndex = 85582
        Me.BitcoinAddressQR.TabStop = False
        '
        'BitcoinNote
        '
        Me.BitcoinNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BitcoinNote.BackColor = System.Drawing.Color.Transparent
        Me.BitcoinNote.Location = New System.Drawing.Point(24, 397)
        Me.BitcoinNote.Name = "BitcoinNote"
        Me.BitcoinNote.Size = New System.Drawing.Size(362, 18)
        Me.BitcoinNote.TabIndex = 85583
        Me.BitcoinNote.Text = "Note: This address only supports BTC !"
        Me.BitcoinNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GeekAssistant_PictureBox
        '
        Me.GeekAssistant_PictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GeekAssistant_PictureBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GeekAssistant_PictureBox.Image = Global.GeekAssistant.My.Resources.Resources.Geek_Assistant___50__alpha40
        Me.GeekAssistant_PictureBox.Location = New System.Drawing.Point(24, 443)
        Me.GeekAssistant_PictureBox.Name = "GeekAssistant_PictureBox"
        Me.GeekAssistant_PictureBox.Size = New System.Drawing.Size(150, 30)
        Me.GeekAssistant_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GeekAssistant_PictureBox.TabIndex = 85584
        Me.GeekAssistant_PictureBox.TabStop = False
        '
        'BitcoinIcon
        '
        Me.BitcoinIcon.BackColor = System.Drawing.Color.Transparent
        Me.BitcoinIcon.Image = Global.GeekAssistant.My.Resources.Resources.Bitcoin_logo
        Me.BitcoinIcon.Location = New System.Drawing.Point(30, 173)
        Me.BitcoinIcon.Name = "BitcoinIcon"
        Me.BitcoinIcon.Size = New System.Drawing.Size(32, 32)
        Me.BitcoinIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BitcoinIcon.TabIndex = 85585
        Me.BitcoinIcon.TabStop = False
        '
        'BitcoinTitle
        '
        Me.BitcoinTitle.BackColor = System.Drawing.Color.Transparent
        Me.BitcoinTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BitcoinTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BitcoinTitle.Location = New System.Drawing.Point(68, 171)
        Me.BitcoinTitle.Name = "BitcoinTitle"
        Me.BitcoinTitle.Size = New System.Drawing.Size(318, 34)
        Me.BitcoinTitle.TabIndex = 85586
        Me.BitcoinTitle.Text = "Bitcoin (BTC)"
        Me.BitcoinTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GooglePayTitle
        '
        Me.GooglePayTitle.BackColor = System.Drawing.Color.Transparent
        Me.GooglePayTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GooglePayTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GooglePayTitle.Location = New System.Drawing.Point(68, 99)
        Me.GooglePayTitle.Name = "GooglePayTitle"
        Me.GooglePayTitle.Size = New System.Drawing.Size(318, 34)
        Me.GooglePayTitle.TabIndex = 85588
        Me.GooglePayTitle.Text = "Google Pay"
        Me.GooglePayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GooglePayIcon
        '
        Me.GooglePayIcon.BackColor = System.Drawing.Color.Transparent
        Me.GooglePayIcon.Image = Global.GeekAssistant.My.Resources.Resources.GooglePay_logo
        Me.GooglePayIcon.Location = New System.Drawing.Point(30, 101)
        Me.GooglePayIcon.Name = "GooglePayIcon"
        Me.GooglePayIcon.Size = New System.Drawing.Size(32, 32)
        Me.GooglePayIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GooglePayIcon.TabIndex = 85587
        Me.GooglePayIcon.TabStop = False
        '
        'GooglePayEmail
        '
        Me.GooglePayEmail.BackColor = System.Drawing.Color.Transparent
        Me.GooglePayEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GooglePayEmail.Location = New System.Drawing.Point(71, 133)
        Me.GooglePayEmail.Name = "GooglePayEmail"
        Me.GooglePayEmail.Size = New System.Drawing.Size(315, 18)
        Me.GooglePayEmail.TabIndex = 85589
        Me.GooglePayEmail.Text = "nhkomaiha@gmail.com"
        Me.GooglePayEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Thanks_Label
        '
        Me.Thanks_Label.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thanks_Label.Location = New System.Drawing.Point(107, 55)
        Me.Thanks_Label.Name = "Thanks_Label"
        Me.Thanks_Label.Size = New System.Drawing.Size(279, 20)
        Me.Thanks_Label.TabIndex = 85590
        Me.Thanks_Label.Text = "Thank you for your support!"
        Me.Thanks_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GooglePay_ClickableBG
        '
        Me.GooglePay_ClickableBG.BackColor = System.Drawing.Color.Transparent
        Me.GooglePay_ClickableBG.Location = New System.Drawing.Point(-2, 91)
        Me.GooglePay_ClickableBG.Name = "GooglePay_ClickableBG"
        Me.GooglePay_ClickableBG.Size = New System.Drawing.Size(415, 76)
        Me.GooglePay_ClickableBG.TabIndex = 85591
        Me.GooglePay_ClickableBG.TabStop = False
        '
        'Bitcoin_ClickableBG
        '
        Me.Bitcoin_ClickableBG.BackColor = System.Drawing.Color.Transparent
        Me.Bitcoin_ClickableBG.Location = New System.Drawing.Point(-2, 167)
        Me.Bitcoin_ClickableBG.Name = "Bitcoin_ClickableBG"
        Me.Bitcoin_ClickableBG.Size = New System.Drawing.Size(415, 266)
        Me.Bitcoin_ClickableBG.TabIndex = 85591
        Me.Bitcoin_ClickableBG.TabStop = False
        '
        'GooglePayLink
        '
        Me.GooglePayLink.BackColor = System.Drawing.Color.Transparent
        Me.GooglePayLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GooglePayLink.Image = CType(resources.GetObject("GooglePayLink.Image"), System.Drawing.Image)
        Me.GooglePayLink.Location = New System.Drawing.Point(334, 99)
        Me.GooglePayLink.Name = "GooglePayLink"
        Me.GooglePayLink.Size = New System.Drawing.Size(52, 52)
        Me.GooglePayLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.GooglePayLink.TabIndex = 85593
        Me.GooglePayLink.TabStop = False
        '
        'Donate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(411, 483)
        Me.Controls.Add(Me.GooglePayLink)
        Me.Controls.Add(Me.Thanks_Label)
        Me.Controls.Add(Me.GooglePayEmail)
        Me.Controls.Add(Me.GooglePayTitle)
        Me.Controls.Add(Me.GooglePayIcon)
        Me.Controls.Add(Me.BitcoinTitle)
        Me.Controls.Add(Me.BitcoinIcon)
        Me.Controls.Add(Me.GeekAssistant_PictureBox)
        Me.Controls.Add(Me.BitcoinNote)
        Me.Controls.Add(Me.BitcoinAddressQR)
        Me.Controls.Add(Me.BitcoinAddress)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.pic)
        Me.Controls.Add(Me.Close_Button)
        Me.Controls.Add(Me.ButtonsBG_UI)
        Me.Controls.Add(Me.Bitcoin_ClickableBG)
        Me.Controls.Add(Me.GooglePay_ClickableBG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(427, 522)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(427, 522)
        Me.Name = "Donate"
        Me.Text = "Support The Developer — Geek Assistant"
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonsBG_UI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BitcoinAddressQR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeekAssistant_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BitcoinIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GooglePayIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GooglePay_ClickableBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bitcoin_ClickableBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GooglePayLink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BitcoinAddress As Label
    Friend WithEvents title As Label
    Friend WithEvents pic As PictureBox
    Friend WithEvents Close_Button As Button
    Friend WithEvents ButtonsBG_UI As PictureBox
    Friend WithEvents BitcoinAddressQR As PictureBox
    Friend WithEvents BitcoinNote As Label
    Friend WithEvents GeekAssistant_PictureBox As PictureBox
    Friend WithEvents BitcoinIcon As PictureBox
    Friend WithEvents BitcoinTitle As Label
    Friend WithEvents GooglePayTitle As Label
    Friend WithEvents GooglePayIcon As PictureBox
    Friend WithEvents GooglePayEmail As Label
    Friend WithEvents Thanks_Label As Label
    Friend WithEvents GooglePay_ClickableBG As PictureBox
    Friend WithEvents Bitcoin_ClickableBG As PictureBox
    Friend WithEvents GooglePayLink As PictureBox
End Class
