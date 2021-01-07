Public Class CustomerForm
    Dim ctrl As New Controller
    Dim compute As New Computation

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        ctrl.Close()
    End Sub

    Private Sub btn_compute_Click(sender As Object, e As EventArgs)
        compute.computation_dues()
    End Sub

    Private Sub Guna2TileButton8_Click(sender As Object, e As EventArgs) Handles Guna2TileButton8.Click
        Configuration.Show()
        Me.Close()
    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        compute.save()

    End Sub

    Private Sub btn_loanLedger_Click(sender As Object, e As EventArgs) Handles btn_loanLedger.Click
        LoanLedger.Show()
        Me.Close()
    End Sub

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        compute.combobox_area()
    End Sub

    Private Sub Guna2TileButton6_Click(sender As Object, e As EventArgs) Handles Guna2TileButton6.Click
        Payment.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2TileButton11_Click(sender As Object, e As EventArgs) Handles Guna2TileButton11.Click
        ctrl.Clear_addcustomer()
    End Sub

    Private Sub Guna2TileButton7_Click(sender As Object, e As EventArgs) Handles Guna2TileButton7.Click
        Backup.Show()
        Me.Close()
    End Sub
End Class