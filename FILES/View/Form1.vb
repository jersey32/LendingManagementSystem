Imports MySql.Data.MySqlClient

Public Class Login_Page
    Dim Ctrl As New Controller

    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        Ctrl.Close()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Login_Page_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter

    End Sub
    Private Sub Login_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.LimeGreen
        Me.TransparencyKey = Color.LimeGreen
    End Sub
    Private Sub Panel_login1_MouseEnter(sender As Object, e As EventArgs) Handles Panel_login1.MouseEnter
        GunaJersey.Start()
        GunaBaron.Start()
        GunaAnimateWindow1.Start()

        Label1.Visible = True
        txtbox_username.Visible = True
        txtbox_password.Visible = True
        Label5.Visible = True
        btn_login.Visible = True
        Panel2.Visible = True
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Ctrl.login()
    End Sub
End Class
