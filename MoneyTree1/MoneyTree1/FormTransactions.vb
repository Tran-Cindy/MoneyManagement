Imports MySql.Data.MySqlClient
Public Class FormTransactions
    Dim sqlconn As MySqlConnection
    Dim sqlcommand As MySqlCommand


    'Used to check whether or not a successful connection has been made to the database
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Connects visual basic to the database

        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"

        Try
            sqlconn.Open()
            MessageBox.Show("Connection successful.")
            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            'Dispose of the query now that the operation is done
            sqlconn.Dispose()
        End Try
    End Sub
    'Save a new record to the table, 2 records cannot have the same id, id are unique
    'insert values that the user inputs into textboxes into the table transactionsinfo within the database moneytree
    Private Sub btnSaveT_Click(sender As Object, e As EventArgs) Handles btnSaveT.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        Dim sqlReader As MySqlDataReader
        Try
            sqlconn.Open()

            Dim sqlQuery As String
            sqlQuery = "insert into moneytree.transactionsinfo (idtransactionsinfo,name,amount,incomeorexpense,category,currency,date) values('" & TBTransactionsID.Text & "', '" & TBName.Text & "','" & TBAmount.Text & "', '" & CBIncomeOrExpense.Text & "', '" & CBCategory.Text & "','" & CBCurrency.Text & "', '" & DateTimePickerTDate.Text & "')"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlReader = sqlcommand.ExecuteReader
            MessageBox.Show("Transaction saved successfully.")

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub
    'Edit/update a record from a table
    Private Sub btnEditT_Click(sender As Object, e As EventArgs) Handles btnEditT.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        Dim sqlReader As MySqlDataReader
        Try
            sqlconn.Open()

            Dim sqlQuery As String
            sqlQuery = "update moneytree.transactionsinfo set idtransactionsinfo='" & TBTransactionsID.Text & "',name='" & TBName.Text & "',amount='" & TBAmount.Text & "',incomeorexpense='" & CBIncomeOrExpense.Text & "',category='" & CBCategory.Text & "',currency='" & CBCurrency.Text & "',date='" & DateTimePickerTDate.Text & "' where idtransactionsinfo='" & TBTransactionsID.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlReader = sqlcommand.ExecuteReader
            MessageBox.Show("Transaction data edited.")

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub
    'Delete a record from the table transactionsinfo, by the user inputting the id of the record they want to delete
    Private Sub btnDeleteT_Click(sender As Object, e As EventArgs) Handles btnDeleteT.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        Dim sqlReader As MySqlDataReader
        Try
            sqlconn.Open()

            Dim sqlQuery As String
            sqlQuery = "delete from moneytree.transactionsinfo where idtransactionsinfo='" & TBTransactionsID.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlReader = sqlcommand.ExecuteReader
            MessageBox.Show("Transaction data deleted.")

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try

    End Sub
    'Clear all boxes to input text
    Private Sub Clear()
        TBTransactionsID.Text = ""
        TBName.Text = ""
        TBAmount.Text = ""
        CBIncomeOrExpense.Text = ""
        CBCategory.Text = ""
        CBCurrency.Text = ""
        DateTimePickerTDate.ResetText()
    End Sub
    'When the button ClearT is clicked it calls the private subroutine Clear() to clear the textboxes
    Private Sub btnClearT_Click(sender As Object, e As EventArgs) Handles btnClearT.Click
        Clear()
    End Sub

    Private Sub btnShowTable_Click(sender As Object, e As EventArgs) Handles btnShowTable.Click
        sqlconn = New MySqlConnection 'Opens a new mysqlconnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim TransactionsDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            sqlconn.Open()
            Dim sqlQuery As String
            'Select all data from the database
            sqlQuery = "select * from moneytree.transactionsinfo"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlAdapter.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter.Fill(TransactionsDataSet)

            'Binding the dataset and datagridview
            bSource.DataSource = TransactionsDataSet
            DGVTransactions.DataSource = bSource
            sqlAdapter.Update(TransactionsDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try

    End Sub

    'Selecting data from the datagridview (DGVTransactions) to fill in the textboxes, this will make a previous transaction easier to edit
    Private Sub DGVTransactions_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTransactions.CellContentClick
        If e.RowIndex >= 0 Then

            Dim Row As DataGridViewRow
            Row = Me.DGVTransactions.Rows(e.RowIndex)

            TBTransactionsID.Text = Row.Cells("idtransactionsinfo").Value.ToString
            TBName.Text = Row.Cells("name").Value.ToString
            TBAmount.Text = Row.Cells("amount").Value.ToString
            CBIncomeOrExpense.Text = Row.Cells("incomeorexpense").Value.ToString
            CBCategory.Text = Row.Cells("category").Value.ToString
            CBCurrency.Text = Row.Cells("currency").Value.ToString
            DateTimePickerTDate.Text = Row.Cells("date").Value.ToString

        End If
    End Sub

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"

        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim TCategoryDataSet As New DataTable
        Dim b2Source As New BindingSource

        Try
            sqlconn.Open()
            Dim sqlQuery As String

            'Search for all records with a certain string in it (all these attributes are varchar or decimal)
            sqlQuery = "select * from moneytree.transactionsinfo where category = '" & TBSearch.Text & "' or name = '" & TBSearch.Text & "' or incomeorexpense = '" & TBSearch.Text & "' or currency = '" & TBSearch.Text & "'or idtransactionsinfo = '" & TBSearch.Text & "'or amount = '" & TBSearch.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)

            sqlAdapter.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter.Fill(TCategoryDataSet)

            'Binding the dataset and datagridview
            b2Source.DataSource = TCategoryDataSet
            DGVTransactions.DataSource = b2Source
            sqlAdapter.Update(TCategoryDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try

    End Sub

    Private Sub btn_DateSearch_Click(sender As Object, e As EventArgs) Handles btn_DateSearch.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"

        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim TCategoryDataSet As New DataTable
        Dim b2Source As New BindingSource

        Try
            sqlconn.Open()
            Dim sqlQuery As String

            'Search for all records with a certain string in it (all these attributes are date, in the format yyyy/mm/dd which is the format used in MySqlDatabase)
            sqlQuery = "select * from moneytree.transactionsinfo where date = '" & TBDateSearch.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)

            sqlAdapter.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter.Fill(TCategoryDataSet)

            'Binding the dataset and datagridview
            b2Source.DataSource = TCategoryDataSet
            DGVTransactions.DataSource = b2Source
            sqlAdapter.Update(TCategoryDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub

    'Calculate total income and expense of the values in the datagridviewer, this can be before or after a search filter
    Private Sub btn_CalculateEI_Click(sender As Object, e As EventArgs) Handles btn_CalculateEI.Click
        Dim IncomeCalc As Decimal = 0
        Dim ExpenseCalc As Decimal = 0

        For a = 0 To DGVTransactions.Rows.Count - 1
            If DGVTransactions.Rows(a).Cells(3).Value = "Income" Then
                IncomeCalc += DGVTransactions.Rows(a).Cells(2).Value
            End If

            If DGVTransactions.Rows(a).Cells(3).Value = "Expense" Then
                ExpenseCalc += DGVTransactions.Rows(a).Cells(2).Value
            End If
        Next

        'Display the income & expense calculation to the user
        IncomeSum.Text = IncomeCalc
        ExpenseSum.Text = ExpenseCalc

    End Sub

End Class