<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Preparing
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
        Me.Preparing_Label = New System.Windows.Forms.Label()
        Me.Preparing_PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.Preparing_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Preparing_Label
        '
        Me.Preparing_Label.BackColor = System.Drawing.Color.Transparent
        Me.Preparing_Label.Location = New System.Drawing.Point(82, 12)
        Me.Preparing_Label.Name = "Preparing_Label"
        Me.Preparing_Label.Size = New System.Drawing.Size(255, 60)
        Me.Preparing_Label.TabIndex = 0
        Me.Preparing_Label.Text = "Hold on for a moment... Preparing..."
        Me.Preparing_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Preparing_PictureBox
        '
        Me.Preparing_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.Preparing_PictureBox.Image = Global.GeekAssistant.My.Resources.Resources.G_noG
        Me.Preparing_PictureBox.Location = New System.Drawing.Point(12, 12)
        Me.Preparing_PictureBox.Name = "Preparing_PictureBox"
        Me.Preparing_PictureBox.Size = New System.Drawing.Size(59, 60)
        Me.Preparing_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Preparing_PictureBox.TabIndex = 1
        Me.Preparing_PictureBox.TabStop = False
        '
        'Preparing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(345, 80)
        Me.ControlBox = False
        Me.Controls.Add(Me.Preparing_PictureBox)
        Me.Controls.Add(Me.Preparing_Label)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Preparing"
        Me.Opacity = 0.94R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Magenta
        CType(Me.Preparing_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Preparing_Label As Label
    Friend WithEvents Preparing_PictureBox As PictureBox
End Class
