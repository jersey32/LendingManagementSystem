Imports MySql.Data.MySqlClient

Module Module1
    Public query As MySqlCommand
    Public read As MySqlDataReader
    Public count As Integer
    Public LoginQuery As String
    Public Answer As String
    Public total_collectibles As Integer
    Public total_monthstopay As Integer
    Public Months_pay As Integer
    Public daily_pay As String
    Public borrow_money As Double
    Public interest_rate As Double
    Public total_recieve As String
    Public ctrl As New Controller
    Public search As String
    Public searchcount As Integer
    Public startDay As Date
    Public endDay As Date
    Public compute As New Computation

    Public Function Con() As MySqlConnection

        Con = New MySqlConnection()
        Con.ConnectionString = "server=localhost;" _
            & "user id=root;" _
            & "password=;" _
            & "database=lgs_db"

        Con.Open()
        Return Con

    End Function
End Module
