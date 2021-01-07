Imports MySql.Data.MySqlClient
Public Class Computation
    'COMPUTATION NG TOTAL RECIEVABLES AT COLLECTIBLES
    Public Sub computation_dues()
        If LoanLedger.txtbox_amount.Text = "" Or LoanLedger.combo_interest.Text = "" Or LoanLedger.txtbox_monthstopay.Text = "" Then

            MessageBox.Show("Please complete forms before to compute !", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            borrow_money = LoanLedger.txtbox_amount.Text
            interest_rate = LoanLedger.combo_interest.Text
            Months_pay = LoanLedger.txtbox_monthstopay.Text

            total_recieve = Convert.ToString(borrow_money) * (1 + (Convert.ToString(interest_rate) / 100))
            daily_pay = total_recieve / (24 * Convert.ToString(Months_pay))
            LoanLedger.txtbox_total.Text = total_recieve
            LoanLedger.txtbox_daily.Text = Convert.ToDouble(Math.Round(CDbl(daily_pay)))
        End If
    End Sub


    'COMBO BOX NG INTEREST FROM DATA
    Public Sub combobox_interest()
        Dim query1 As String
        query1 = "SELECT * FROM `interest_tbl`"
        query = New MySqlCommand(query1, Con)
        read = query.ExecuteReader()

        While read.Read
            Dim intrst = read.GetString("interest_rate")
            LoanLedger.combo_interest.Items.Add(intrst)
        End While
    End Sub


    'COMBO BOX NG COLLECTOR FROM DATA
    Public Sub combobox_collector()
        Dim query1 As String
        query1 = "SELECT * FROM `collector_tbl`"
        query = New MySqlCommand(query1, Con)
        read = query.ExecuteReader()

        While read.Read
            Dim collect = read.GetString("Collectors_name")
            LoanLedger.combo_collectors.Items.Add(collect)
        End While
    End Sub


    'COMBO BOX NG AREA FROM DATA
    Public Sub combobox_area()
        Dim query1 As String
        query1 = "SELECT * FROM `area_tbl`"
        query = New MySqlCommand(query1, Con)
        read = query.ExecuteReader()

        While read.Read
            Dim area = read.GetString("Area_name")
            CustomerForm.combo_area.Items.Add(area)
        End While
    End Sub


    'SAVING NG ADDING NG CUSTOMER 
    Public Sub save()
        Dim saveQueryCustomer As String
        If CustomerForm.combo_area.Text = "" Or CustomerForm.txtbox_surname.Text = "" Or CustomerForm.txtbox_name.Text = "" Or CustomerForm.txtbox_Middle.Text = "" Or CustomerForm.txtbox_address.Text = "" Then

            MessageBox.Show("Please fillout all forms !", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            saveQueryCustomer = "INSERT INTO `borrower_tbl`(`Area_code`, `Surname`, `Name`, `Middlename`, `Suffix`, `Address`) VALUES ('" & CustomerForm.combo_area.Text & "','" & CustomerForm.txtbox_surname.Text & "','" & CustomerForm.txtbox_name.Text & "','" & CustomerForm.txtbox_Middle.Text & "','" & CustomerForm.txtbox_suffix.Text & "','" & CustomerForm.txtbox_address.Text & "')"
            query = New MySqlCommand(saveQueryCustomer, Con)
            query.ExecuteNonQuery()
            ctrl.promptboxSuccess()
            CustomerForm.txtbox_surname.Clear()
            CustomerForm.txtbox_name.Clear()
            CustomerForm.txtbox_Middle.Clear()
            CustomerForm.txtbox_address.Clear()
        End If
    End Sub

    'SAVE LOAN
    Public Sub save_loan()

        If LoanLedger.txtbox_borrowerID.Text = "" Or LoanLedger.txtbox_monthstopay.Text = "" Or LoanLedger.txtbox_amount.Text = "" Then
            MessageBox.Show("Please complete forms before to save!", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf LoanLedger.txtbox_daily.Text = "" Or LoanLedger.txtbox_total.Text = "" Then
            MessageBox.Show("Please compute the total and daily collectibles before to save!", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim saveLoan As String
            saveLoan = "INSERT INTO `loanledger_tbl`(`Loan_borrower_ID`, `Loan_Type`, `Months_to_pay`, `Amount`, `Interest`, `Date_applied`, `Date_release`, `Due_date`, `Total_recievables`, `Total_daily_collectibles`, `Balance`) VALUES ('" & LoanLedger.txtbox_borrowerID.Text & "','" & LoanLedger.combo_loan.Text & "',
                    '" & LoanLedger.txtbox_monthstopay.Text & "','" & LoanLedger.txtbox_amount.Text & "','" & LoanLedger.combo_interest.Text & "','" & LoanLedger.Date_applied.Value & "','" & LoanLedger.Date_released.Value & "','" & LoanLedger.Due_date.Value & "',
                    '" & LoanLedger.txtbox_total.Text & "','" & LoanLedger.txtbox_daily.Text & "','')"
            query = New MySqlCommand(saveLoan, Con)
            query.ExecuteNonQuery()
            ctrl.promptboxSuccess()
        End If




    End Sub

    'SAVING NG DATE TO DUE DATE
    Public Sub savedatepayments()
        Dim dayCtr As Date
        Dim savedateloan As String
        Dim date_range As String
        startDay = LoanLedger.Date_applied.Value.ToLongDateString
        endDay = LoanLedger.Due_date.Value.ToLongDateString
        dayCtr = startDay
        Do While (dayCtr <= endDay)
            'MessageBox.Show(dayCtr.Date.Day & "-" & dayCtr.Date.DayOfWeek.ToString() & "-" & dayCtr.Date.Year)
            dayCtr = dayCtr.AddDays(1)
            date_range += dayCtr.Date.Day & "-" & dayCtr.Date.DayOfWeek.ToString() & "-" & dayCtr.Date.Year
            savedateloan = "INSERT INTO `loanledger_date_tbl`(`Loan_ID`, `Dates_applied`, `Paid_dates`) VALUES ('" & Payment.txtbox_borrowerID.Text & "','" & date_range & "','" & date_range & "')"
            query = New MySqlCommand(savedateloan, Con)
            query.ExecuteNonQuery()
        Loop
    End Sub
End Class
