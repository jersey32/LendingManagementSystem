Public Class Configuration
    Public config As New config
    Public ctrl As New Controller
    Private Sub TabPage2_MouseEnter(sender As Object, e As EventArgs) Handles TabPage2.MouseEnter
        config.loadForm_collector()
    End Sub

    Private Sub TabPage1_MouseEnter(sender As Object, e As EventArgs) Handles TabPage1.MouseEnter
        config.loadForm_areas()
    End Sub

    Private Sub btn_saveArea_Click(sender As Object, e As EventArgs) Handles btn_saveArea.Click
        config.addarea()
    End Sub

    Private Sub Guna2TileButton2_Click(sender As Object, e As EventArgs) Handles Guna2TileButton2.Click
        config.addCollector()
    End Sub

    Private Sub btn_saveInterest_Click(sender As Object, e As EventArgs) Handles btn_saveInterest.Click
        config.addInterestRate()
    End Sub

    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TabPage3.Enter
        config.loadForm_interest()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        ctrl.Close()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        MainMenu.Show()
        Me.Close()

    End Sub
End Class