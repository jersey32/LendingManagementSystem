Imports MySql.Data.MySqlClient
Public Class Payment
    Private Sub txtbox_borrowerID_TextChanged(sender As Object, e As EventArgs) Handles txtbox_borrowerID.TextChanged
        If txtbox_borrowerID.Text = "" Then
            Dim data As String = "SELECT * FROM `loanledger_tbl"
            Dim dataAdapter As New MySqlDataAdapter(data, Con)
            Dim ds As New DataSet()

            dataAdapter.Fill(ds, "Authors_table")
            Datagrid_loandate.DataSource = ds
            Datagrid_loandate.DataMember = "Authors_table"
        Else
            Dim data As String = "SELECT * FROM `loanledger_tbl` WHERE `Loan_borrower_ID` = '" & txtbox_borrowerID.Text & "'"
            Dim dataAdapter As New MySqlDataAdapter(data, Con)
            Dim ds As New DataSet()

            dataAdapter.Fill(ds, "Authors_table")
            Datagrid_loandate.DataSource = ds
            Datagrid_loandate.DataMember = "Authors_table"
        End If
    End Sub

    Private Sub Datagrid_loans_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datagrid_loandate.CellContentClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRows As DataGridViewRow

        selectedRows = Datagrid_loandate.Rows(index)
        txtbox_borrowerID.Text = selectedRows.Cells(0).Value.ToString()
    End Sub

    Private Sub btn_compute_Click(sender As Object, e As EventArgs) Handles btn_compute.Click
        compute.savedatepayments()
    End Sub

    Private Sub btn_loadledger_Click(sender As Object, e As EventArgs) Handles btn_loadledger.Click
        LoanLedger.Show()
        Me.Close()
    End Sub

    Private Sub btn_addborrow_Click(sender As Object, e As EventArgs) Handles btn_addborrow.Click
        CustomerForm.Show()
        Me.Close()
    End Sub
End Class