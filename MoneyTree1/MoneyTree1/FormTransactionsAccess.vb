Imports MySql.Data.MySqlClient
Public Class FormTransactionsAccess 'Used to get the total amount spent between the startdate and enddate of a budget, the budget is selected by the user by them inputting the budget ID

    Dim sqlconn As MySqlConnection
    Dim sqlcommand As MySqlCommand
    'Public variable so that it can be accessed in FormBudget
    Public FinishedCalculatingExpense As Boolean = False
    Private Sub FormTransactionsAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim TransactionsAccessDataSet As New DataTable
        Dim bSource As New BindingSource

        Dim BudgetStarting As DateTime
        Dim BudgetEnding As DateTime
        Dim ExpensesCalculation As Decimal = 0

        'If the user has chosen a budget from the form FormBudget to view how much they've spent out of it = True
        If FormBudget.BudgetClickedForCalc = True Then
            'The start date from the datetimepicker from FormBudget is stored in the local variable BudgetStarting
            BudgetStarting = FormBudget.DateTimeStartPick.Value
            StartDate.Value = BudgetStarting 'The start datetimepicker from FormTransactionsAccess now displays the same value as the datetimepicker from FormBudget
            'The end date from the datetimepicker from FormBudget is stored in the local variable BudgetEnding
            BudgetEnding = FormBudget.DateTimeEndPick.Value
            EndDate.Value = BudgetEnding 'The end datetimepicker from FormTransactionsAccess now displays the same value as the datetimepicker from FormBudget
        End If

        Try
            sqlconn.Open()
            Dim sqlQuery As String
            'Select all data from the database
            sqlQuery = "select * from moneytree.transactionsinfo where date between '" & StartDate.Text & "' and '" & EndDate.Text & "' "
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlAdapter.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter.Fill(TransactionsAccessDataSet)

            'Binding the dataset and datagridview
            bSource.DataSource = TransactionsAccessDataSet
            DGVTransactionsAccess.DataSource = bSource
            sqlAdapter.Update(TransactionsAccessDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try

        'For the first row until the last row, if it is an expense add the amounts together 
        'Cell 2 has the amount of each expense 
        For a = 0 To DGVTransactionsAccess.Rows.Count - 1
            If DGVTransactionsAccess.Rows(a).Cells(3).Value = "Expense" Then
                ExpensesCalculation += DGVTransactionsAccess.Rows(a).Cells(2).Value 'The total expense is stored in the local variable ExpensesCalculation
            End If
        Next

        'Display the total expense in the textbox TBTotalExpense
        TBTotalExpense.Text = ExpensesCalculation

        'The FormTransactionAccess has now finished calculating the total expense which can be used in the form FormBudget to be taken away from the budget amount 
        FinishedCalculatingExpense = True


    End Sub
End Class