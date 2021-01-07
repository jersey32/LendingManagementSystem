Imports MySql.Data.MySqlClient
Public Class Controller

    ' LOGIN NG USERNAME AT PASSWORD
    Public Sub login()
        LoginQuery = "SELECT * FROM `login_tbl` WHERE `Username` = '" & Login_Page.txtbox_username.Text & "' AND `Password` = '" & Login_Page.txtbox_password.Text & "'"
        query = New MySqlCommand(LoginQuery, Con)
        read = query.ExecuteReader
        count = 0
        While read.Read
            count = count + 1
        End While

        If count > 0 Then
            promptboxSuccess()
            MainMenu.GunaAnimateWindow1.Start()
            MainMenu.Show()
            Login_Page.Hide()
        Else
            promptboxfail()
        End If

    End Sub

    ' CODE NG BUTTON NG CLOSE
    Public Sub Close()
        Answer = MsgBox("Do you really want to close this application ?", vbQuestion + vbYesNo + vbDefaultButton2, "Warning")
        If Answer = vbYes Then
            Application.Exit()
        End If
    End Sub

    ' PROMPT CODE NG SUCCESS
    Public Sub promptboxSuccess()
        MessageBox.Show("Successful!", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' PROMPT CODE NG FAIL
    Public Sub promptboxfail()
        MessageBox.Show("Failed!", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    'Clear button ng addcustomer
    Public Sub Clear_addcustomer()
        CustomerForm.txtbox_surname.Clear()
        CustomerForm.txtbox_name.Clear()
        CustomerForm.txtbox_Middle.Clear()
        CustomerForm.txtbox_address.Clear()
        CustomerForm.txtbox_suffix.Clear()
    End Sub


    'Clear button ng Loan ledger
    Public Sub Clear_loan()
        LoanLedger.txtbox_amount.Clear()
        LoanLedger.txtbox_daily.Clear()
        LoanLedger.txtbox_monthstopay.Clear()
        LoanLedger.txtbox_total.Clear()
    End Sub

    'Date today 
    Public Sub date_today()
        Dim bckup As New Backup
        Dim day As Date
        day = Today
        bckup.Label1.Text = day
    End Sub

    'Backup and restore of database
    Public Sub backup()
        Dim sfd As New SaveFileDialog() With {
            .Filter = "Backup File | *.bak",
            .FileName = ""
        }
        If sfd.ShowDialog = DialogResult.OK Then
            Dim backup As String = $"backup datebase lgs To disk = '{sfd.FileName}'"
            Dim cmd As New MySqlCommand(backup, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Backup Complete")
        End If
    End Sub
End Class
