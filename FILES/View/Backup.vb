Public Class Backup
    Private Sub Backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctrl.date_today()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        ctrl.Close()
    End Sub

    Private Sub btn_backup_Click(sender As Object, e As EventArgs) Handles btn_backup.Click
        ctrl.backup()
        SaveFileDialog1.OpenFile()
    End Sub
End Class