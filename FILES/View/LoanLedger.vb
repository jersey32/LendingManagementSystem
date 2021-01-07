Imports MySql.Data.MySqlClient
Public Class LoanLedger
    Public compute As New Computation
    Public ctrl As New Controller
    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles Guna2TileButton1.Click
        CustomerForm.Show()
        Me.Close()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        ctrl.Close()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_compute_Click(sender As Object, e As EventArgs) Handles btn_compute.Click
        compute.computation_dues()
    End Sub

    Private Sub Datagrid_loans_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datagrid_loans.CellContentClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRows As DataGridViewRow

        selectedRows = Datagrid_loans.Rows(Index)
        txtbox_borrowerID.Text = selectedRows.Cells(0).Value.ToString()

    End Sub

    Private Sub txtbox_borrowerID_TextChanged(sender As Object, e As EventArgs) Handles txtbox_borrowerID.TextChanged
        If txtbox_borrowerID.Text = "" Then
            Dim data As String = "SELECT `Borrower_ID`, `Area_code`, `Surname`, `Name`, `Middlename`, `Suffix` FROM `borrower_tbl`"
            Dim dataAdapter As New MySqlDataAdapter(data, Con)
            Dim ds As New DataSet()

            dataAdapter.Fill(ds, "Authors_table")
            Datagrid_loans.DataSource = ds
            Datagrid_loans.DataMember = "Authors_table"
        Else
            Dim data As String = "SELECT * FROM `borrower_tbl` WHERE `Borrower_ID` = '" & txtbox_borrowerID.Text & "'"
            Dim dataAdapter As New MySqlDataAdapter(data, Con)
            Dim ds As New DataSet()

            dataAdapter.Fill(ds, "Authors_table")
            Datagrid_loans.DataSource = ds
            Datagrid_loans.DataMember = "Authors_table"
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        compute.save_loan()
    End Sub

    Private Sub LoanLedger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        compute.combobox_interest()
        compute.combobox_collector()
        compute.combobox_area()
    End Sub

    Private Sub btn_payment_Click(sender As Object, e As EventArgs) Handles btn_payment.Click
        Payment.Show()
        Me.Close()
    End Sub

    Private Sub Guna2TileButton11_Click(sender As Object, e As EventArgs) Handles Guna2TileButton11.Click
        ctrl.Clear_loan()
    End Sub

    Private Sub Guna2TileButton7_Click(sender As Object, e As EventArgs) Handles Guna2TileButton7.Click
        Backup.Close()
        Me.Close()
    End Sub
End Class