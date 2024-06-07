Imports MySql.Data.MySqlClient
Public Class FormBudget


    Dim sqlconn As MySqlConnection
    Dim sqlcommand As MySqlCommand

    'Type of budget: weekly, monthly or yearly
    Dim TypeWeekly As String = "Weekly"
    Dim TypeMonthly As String = "Monthly"
    Dim TypeYearly As String = "Yearly"
    Dim BudgetType As String
    'The start date is given by the user and the system will calculate a week, month or year after that date
    Dim BudgetEndDate As String

    Dim DayOfTheWeek As DateTime

    'Public so that the boolean value can be accessed from the form FormTransactionsAccess which is used to help calculate total expenses within a period of the budget
    'Set as false at the beginning because so far there hasn't been a budget selected 
    Public BudgetClickedForCalc As Boolean = False

    Dim TextToBeDisplayed As Decimal 'Contains the amount spent out of the budget they've selected, is displayed in a textbox
    Private Sub btnSaveBudget_Click(sender As Object, e As EventArgs) Handles btnSaveBudget.Click
        'The user is only able to select one type of budget 
        If CBWeekly.Checked = True And CBMonthly.Checked = True And CBYearly.Checked = False Then
            Console.WriteLine("You can only choose one type at a time.")
        End If

        If CBWeekly.Checked = True And CBMonthly.Checked = True And CBYearly.Checked = True Then
            Console.WriteLine("You can only choose one type at a time.")
        End If

        If CBWeekly.Checked = False And CBMonthly.Checked = True And CBYearly.Checked = True Then
            Console.WriteLine("You can only choose one type at a time.")
        End If

        If CBWeekly.Checked = True And CBMonthly.Checked = False And CBYearly.Checked = True Then
            Console.WriteLine("You can only choose one type at a time.")
        End If

        'They have to select one type
        If CBWeekly.Checked = False And CBMonthly.Checked = False And CBYearly.Checked = False Then
            Console.WriteLine("Please select a type of budget.")
        End If

        'Setting the budget type depending on which check box is checked 

        'Weekly budget
        'Lasts for 7 days from the current day
        If CBWeekly.Checked = True And CBMonthly.Checked = False And CBYearly.Checked = False Then
            BudgetType = TypeWeekly
            BudgetEndDate = Date.Now.Year & "-" & Date.Now.Month & "-" & (Date.Now.Day + 7)
        End If

        'Monthly Budget
        'Lasts until the next month from the current day
        If CBWeekly.Checked = False And CBMonthly.Checked = True And CBYearly.Checked = False Then
            BudgetType = TypeMonthly
            BudgetEndDate = Date.Now.Year & "-" & (Date.Now.Month + 1) & "-" & Date.Now.Day
        End If

        'Yearly Budget
        'Lasts until the end of the current year
        If CBWeekly.Checked = False And CBMonthly.Checked = False And CBYearly.Checked = True Then
            BudgetType = TypeYearly
            BudgetEndDate = Date.Now.Year & "-12-31"
        End If

        'Connects to the database moneytree
        'Storing the budget into the database table budgetinfo
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        Dim sqlReader As MySqlDataReader
        Try
            sqlconn.Open()

            Dim sqlQuery As String
            sqlQuery = "insert into moneytree.budgetinfo (idbudgetinfo,datetodays,titlebudget,amountbudget,typeofbudget,enddatebudget) values('" & TBBudgetID.Text & "', '" & DateTimeTodaysDate.Text & "','" & TBBudgetTitle.Text & "', '" & TBBudgetAmount.Text & "', '" & BudgetType & "', '" & BudgetEndDate & "')"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlReader = sqlcommand.ExecuteReader
            MessageBox.Show("Budget saved successfully.")

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub

    'Edit the budget, by updating the values in the database table budgetinfo
    Private Sub btnEditBudget_Click(sender As Object, e As EventArgs) Handles btnEditBudget.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        Dim sqlReader As MySqlDataReader
        Try
            sqlconn.Open()

            Dim sqlQuery As String
            sqlQuery = "update moneytree.budgetinfo set idbudgetinfo='" & TBBudgetID.Text & "',datetodays='" & DateTimeTodaysDate.Text & "',titlebudget='" & TBBudgetTitle.Text & "',amountbudget='" & TBBudgetAmount.Text & "',typeofbudget='" & BudgetType & "',enddatebudget='" & BudgetEndDate & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlReader = sqlcommand.ExecuteReader
            MessageBox.Show("Budget edited.")

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub

    'Deleting a budget, to delete a budget the user has to input a budgetID (unique primary key)
    Private Sub btnDeleteBudget_Click(sender As Object, e As EventArgs) Handles btnDeleteBudget.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        Dim sqlReader As MySqlDataReader
        Try
            sqlconn.Open()

            Dim sqlQuery As String
            sqlQuery = "delete from moneytree.budgetinfo where idbudgetinfo='" & TBBudgetID.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlReader = sqlcommand.ExecuteReader
            MessageBox.Show("Budget deleted.")

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub

    'To fill the DataGridViewer DGVBudget, with data from the database table budget info
    Sub ViewDGVBudget()
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim BudgetDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            sqlconn.Open()
            Dim sqlQuery As String
            'Select all data from the database
            sqlQuery = "select * from moneytree.budgetinfo"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlAdapter.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter.Fill(BudgetDataSet)

            'Binding the dataset and datagridview
            bSource.DataSource = BudgetDataSet
            DGVBudgets.DataSource = bSource
            sqlAdapter.Update(BudgetDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try

    End Sub
    'To clear all textboxes 
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TBBudgetID.Text = ""
        DateTimeTodaysDate.ResetText()
        TBBudgetTitle.Text = ""
        TBBudgetAmount.Text = ""
        CBWeekly.Checked = False
        CBMonthly.Checked = False
        CBYearly.Checked = False
    End Sub
    'calls ViewDGVBudget to refresh
    'This is useful if the user inputs a new budget and it can then be shown on the datagridviewer
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ViewDGVBudget()
    End Sub
    'Search for a certain ID, title, amount or type of budget
    Private Sub btnBudgetSearch_Click(sender As Object, e As EventArgs) Handles btnBudgetSearch.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"

        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim BudgetSearchDataSet As New DataTable
        Dim b2Source As New BindingSource

        Try
            sqlconn.Open()
            Dim sqlQuery As String

            'Search for all records with a certain string in it (all these attributes are varchar)
            sqlQuery = "select * from moneytree.budgetinfo where idbudgetinfo = '" & TBBudgetSearch.Text & "' or titlebudget = '" & TBBudgetSearch.Text & "' or amountbudget = '" & TBBudgetSearch.Text & "' or typeofbudget = '" & TBBudgetSearch.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)

            sqlAdapter.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter.Fill(BudgetSearchDataSet)

            'Binding the dataset and datagridview
            b2Source.DataSource = BudgetSearchDataSet
            DGVBudgets.DataSource = b2Source
            sqlAdapter.Update(BudgetSearchDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub
    'Search for a date from the DataGridView, for example, the budget's start and end date 
    Private Sub btnBudgetDateSearch_Click(sender As Object, e As EventArgs) Handles btnBudgetDateSearch.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"

        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim BudgetDateSearchDataSet As New DataTable
        Dim b2Source As New BindingSource

        Try
            sqlconn.Open()
            Dim sqlQuery As String

            'Search for all records with a certain string in it (all these attributes are varchar)
            sqlQuery = "select * from moneytree.budgetinfo where datetodays = '" & TBBudgetDateSearch.Text & "' or enddatebudget = '" & TBBudgetDateSearch.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)

            sqlAdapter.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter.Fill(BudgetDateSearchDataSet)

            'Binding the dataset and datagridview
            b2Source.DataSource = BudgetDateSearchDataSet
            DGVBudgets.DataSource = b2Source
            sqlAdapter.Update(BudgetDateSearchDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub

    Private Sub btnCalcBudget_Click(sender As Object, e As EventArgs) Handles btnCalcBudget.Click
        BudgetClickedForCalc = True 'True as there is a budget selected to calculate how much the user has spent out of it

        Dim BudgetAmountFromID As Decimal
        Dim DisplayBudgetStartDate As DateTime
        Dim DisplayBudgetEndDate As DateTime

        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"

        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim BudgetSpentDataSet As New DataTable
        Dim b2Source As New BindingSource

        Try
            sqlconn.Open()
            Dim sqlQuery As String

            'Search for all records with a certain string in it (all these attributes are varchar)
            sqlQuery = "select * from moneytree.budgetinfo where idbudgetinfo = '" & IDBudgetTB.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)

            sqlAdapter.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter.Fill(BudgetSpentDataSet)

            'Binding the dataset and datagridview
            b2Source.DataSource = BudgetSpentDataSet
            DGVBudgets.DataSource = b2Source
            sqlAdapter.Update(BudgetSpentDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try

        BudgetAmountFromID = DGVBudgets.Rows(0).Cells(3).Value
        TBDisplayAmount.Text = "£" & BudgetAmountFromID
        DisplayBudgetStartDate = DGVBudgets.Rows(0).Cells(1).Value
        DateTimeStartPick.Value = DisplayBudgetStartDate
        DisplayBudgetEndDate = DGVBudgets.Rows(0).Cells(5).Value
        DateTimeEndPick.Value = DisplayBudgetEndDate


    End Sub

    Private Sub DGVBudgets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVBudgets.CellClick
        'Fills the textbox with a budget clicked 
        If e.RowIndex >= 0 Then

            Dim Row As DataGridViewRow
            Row = Me.DGVBudgets.Rows(e.RowIndex)

            TBBudgetID.Text = Row.Cells("idbudgetinfo").Value.ToString
            DateTimeTodaysDate.Text = Row.Cells("datetodays").Value.ToString
            TBBudgetTitle.Text = Row.Cells("titlebudget").Value.ToString
            TBBudgetAmount.Text = Row.Cells("amountbudget").Value.ToString

        End If
    End Sub

    Private Sub btnCalcBudget2_Click(sender As Object, e As EventArgs) Handles btnCalcBudget2.Click
        If FormTransactionsAccess.FinishedCalculatingExpense = True Then
            TextToBeDisplayed = TBDisplayAmount.Text - FormTransactionsAccess.TBTotalExpense.Text
            '£ is the default currency
            TBAmountSpent.Text = "£" & TextToBeDisplayed
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormTransactionsAccess.Show()
    End Sub
End Class