Public Class MainMenu
    Private Sub btn_addborrow_Click(sender As Object, e As EventArgs) Handles btn_addborrow.Click
        CustomerForm.Show()
        Me.Close()
    End Sub

    Private Sub btn_loadledger_Click(sender As Object, e As EventArgs) Handles btn_loadledger.Click
        LoanLedger.Show()
        Me.Close()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2TileButton6_Click(sender As Object, e As EventArgs) Handles Guna2TileButton6.Click
        Payment.Show()
        Me.Close()
    End Sub

    Private Sub Guna2TileButton7_Click(sender As Object, e As EventArgs) Handles Guna2TileButton7.Click
        Backup.Show()
        Me.Close()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class