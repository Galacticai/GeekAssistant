Public Class Donate
    Private Sub Donate_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Main.BringToFront()
    End Sub
    Private Sub Donate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GA_SetTheme.Run(Name, True)
        SetBounds((Main.Width / 2) - (Width / 2) + Main.Location.X, Main.Top, Width, Height)
    End Sub

    Private Sub Close_Button_Click(sender As Object, ev As EventArgs) Handles Close_Button.Click
        Close()
    End Sub

    Private WithEvents GooglePayClick_Timer As New Timer With {.Interval = 1500}
    Private Sub GooglePay_Click(sender As Object, e As EventArgs) Handles GooglePayEmail.Click, GooglePayIcon.Click, GooglePayTitle.Click, GooglePay_ClickableBG.Click
        Clipboard.SetText("nhkomaiha@gmail.com")
        GooglePayEmail.Text = "Copied... Double click for help."
        GooglePayClick_Timer.Enabled = True
    End Sub
    Private Sub GooglePayClick_Timer_Tick() Handles GooglePayClick_Timer.Tick
        GooglePayEmail.Text = "nhkomaiha@gmail.com"
        GooglePayClick_Timer.Enabled = False
    End Sub
    Private Sub GooglePay_DoubleClick(sender As Object, e As EventArgs) Handles GooglePayEmail.DoubleClick, GooglePayIcon.DoubleClick, GooglePayTitle.DoubleClick, GooglePay_ClickableBG.DoubleClick
        Process.Start("https://support.google.com/pay/answer/7643913")
    End Sub
    Private Sub GooglePayLink_Click(sender As Object, e As EventArgs) Handles GooglePayLink.Click
        Process.Start("https://pay.google.com")
    End Sub
    Private current_GooglePayLink_Image As Image
    Private Sub GooglePayLink_MouseDown_KeyDown(sender As Object, e As EventArgs) Handles GooglePayLink.MouseDown, GooglePayLink.KeyDown
        current_GooglePayLink_Image = GooglePayLink.Image
        GooglePayLink.Image = My.Resources.linkIcon_gray75_16
    End Sub
    Private Sub GooglePayLink_MouseUp_KeyUp(sender As Object, e As EventArgs) Handles GooglePayLink.MouseUp, GooglePayLink.KeyUp
        GooglePayLink.Image = current_GooglePayLink_Image
    End Sub

    'Private saved_GooglePayTitle_Forecolor As Color
    'Private Sub GooglePayTitle_MouseEnter(sender As Object, e As EventArgs) Handles GooglePayTitle.MouseEnter
    '    saved_GooglePayTitle_Forecolor = GooglePayTitle.ForeColor
    '    GooglePayTitle.ForeColor = Current_fgColor()
    'End Sub
    'Private Sub GooglePayTitle_MouseLeave(sender As Object, e As EventArgs) Handles GooglePayTitle.MouseLeave
    '    GooglePayTitle.ForeColor = saved_GooglePayTitle_Forecolor
    'End Sub

    Private WithEvents BitcoinClick_Timer As New Timer With {.Interval = 1500}
    Private Sub BitcoinAddress_Click(sender As Object, ev As EventArgs) Handles BitcoinAddress.Click, BitcoinAddressQR.Click, BitcoinIcon.Click, BitcoinNote.Click, BitcoinTitle.Click, Bitcoin_ClickableBG.Click
        Clipboard.SetText(My.Resources.BTCaddress)
        BitcoinAddress.Text = "Copied... Double click for help."
        BitcoinClick_Timer.Enabled = True
    End Sub
    Private Sub BitcoinAddressClick_Timer_Tick(sender As Object, ev As EventArgs) Handles BitcoinClick_Timer.Tick
        BitcoinAddress.Text = My.Resources.BTCaddress
        BitcoinClick_Timer.Enabled = False
    End Sub
    Private Sub Bitcoin_DoubleClick(sender As Object, e As EventArgs) Handles BitcoinAddress.DoubleClick, BitcoinAddressQR.DoubleClick, BitcoinIcon.DoubleClick, BitcoinNote.DoubleClick, BitcoinTitle.DoubleClick, Bitcoin_ClickableBG.DoubleClick
        Process.Start("https://bitcoin.org/en/how-it-works")
    End Sub
End Class