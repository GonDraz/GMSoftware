Imports System.Data.SqlClient
Imports System.Data.SQLite

Class DataModel
    Private dbcommand As String = ""
    Private bindingSrc As BindingSource

    Private dbName As String = "database.db"
    Private dbPath As String = Application.StartupPath & "\" & dbName
    Private connString As String = "Data Source=" & dbPath & ";Version=3"

    Private connection As New SQLiteConnection(connString)
    Private command As New SQLiteCommand("", connection)

    Public Sub loadData()
        connection.Open()

    End Sub
    Public Function getData(selectTabel As String) As DataTable
        Dim dt As New DataTable
        command.Connection = connection
        command.CommandText = "select * from " & selectTabel

        Dim rdr As SQLiteDataReader = command.ExecuteReader

        dt.Load(rdr)
        Return dt
    End Function

End Class
