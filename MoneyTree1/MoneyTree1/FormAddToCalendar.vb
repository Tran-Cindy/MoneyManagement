Imports MySql.Data.MySqlClient
Public Class FormAddToCalendar

    Dim sqlconn As MySqlConnection
    Dim sqlcommand As MySqlCommand
    Private Sub btnSaveEntry_Click(sender As Object, e As EventArgs) Handles btnSaveEntry.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        Dim sqlReader As MySqlDataReader
        Try
            sqlconn.Open()

            Dim sqlQuery As String
            sqlQuery = "insert into moneytree.calendarinfo (calendardate,title,description) values('" & DateTimePickerCalendar.Text & "','" & TBTitle.Text & "', '" & TBDesc.Text & "')"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlReader = sqlcommand.ExecuteReader
            MessageBox.Show("Entry saved successfully.")

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub
End Class