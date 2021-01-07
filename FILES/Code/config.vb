Imports MySql.Data.MySqlClient
Public Class config

    ' ADDING NG AREA CODE
    Public Sub addarea()
        Dim ctrl As New Controller
        Dim addareas As String
        If Configuration.txtbox_areacode.Text = "" Then
            ctrl.promptboxfail()
        Else
            addareas = "INSERT INTO `area_tbl`(`Area_name`) VALUES ('" & Configuration.txtbox_areacode.Text & "')"
            query = New MySqlCommand(addareas, Con)
            query.ExecuteNonQuery()
            ctrl.promptboxSuccess()
            Con.Close()
            loadForm_areas()
        End If
    End Sub

    ' DATAGRID LOAD NG AREA
    Public Sub loadForm_areas()
        Dim data As String = "SELECT `Area_name` FROM `area_tbl`"
        Dim dataAdapter As New MySqlDataAdapter(data, Con)
        Dim ds As New DataSet()

        dataAdapter.Fill(ds, "Authors_table")
        Configuration.Guna2DataGridView1.DataSource = ds
        Configuration.Guna2DataGridView1.DataMember = "Authors_table"
    End Sub

    ' ADDING NG COLLECTOR
    Public Sub addCollector()
        Dim ctrl As New Controller
        Dim addCollect As String
        If Configuration.txtbox_collector.Text = "" Then
            ctrl.promptboxfail()
        Else
            addCollect = "INSERT INTO `collector_tbl`(`Collectors_name`) VALUES ('" & Configuration.txtbox_collector.Text & "')"
            query = New MySqlCommand(addCollect, Con)
            query.ExecuteNonQuery()
            ctrl.promptboxSuccess()
            Con.Close()
            loadForm_collector()
        End If
    End Sub

    'DATAGRID LOAD NG COLLECTOR
    Public Sub loadForm_collector()
        Dim data As String = "SELECT `Collectors_name` FROM `collector_tbl`"
        Dim dataAdapter As New MySqlDataAdapter(data, Con)
        Dim ds As New DataSet()

        dataAdapter.Fill(ds, "Authors_table")
        Configuration.Guna2DataGridView2.DataSource = ds
        Configuration.Guna2DataGridView2.DataMember = "Authors_table"
    End Sub

    ' ADDING NG INTEREST RATE
    Public Sub addInterestRate()
        Dim addInterest As String
        Dim ctrl As New Controller
        If Configuration.txtbox_interest.Text = "" Then
            ctrl.promptboxfail()
        Else
            addInterest = "INSERT INTO `interest_tbl`(`interest_rate`) VALUES ('" & Configuration.txtbox_interest.Text & "')"
            query = New MySqlCommand(addInterest, Con)
            query.ExecuteNonQuery()
            ctrl.promptboxSuccess()
            loadForm_interest()
        End If


    End Sub

    ' DATAGRID LOAD NG INTEREST RATE
    Public Sub loadForm_interest()
        Dim data As String = "SELECT `interest_rate` FROM `interest_tbl`"
        Dim dataAdapter As New MySqlDataAdapter(data, Con)
        Dim ds As New DataSet()

        dataAdapter.Fill(ds, "Authors_table")
        Configuration.Guna2DataGridView3.DataSource = ds
        Configuration.Guna2DataGridView3.DataMember = "Authors_table"
    End Sub
End Class
