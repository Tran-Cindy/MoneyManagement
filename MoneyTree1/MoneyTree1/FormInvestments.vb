Imports MySql.Data.MySqlClient
Public Class FormInvestments
    Dim sqlconn As MySqlConnection
    Dim sqlcommand As MySqlCommand

    Private Sub btnSaveInv_Click(sender As Object, e As EventArgs) Handles btnSaveInv.Click

        'Connects to the database moneytree
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        Dim sqlReader As MySqlDataReader
        Try
            sqlconn.Open()

            Dim sqlQuery As String
            sqlQuery = "insert into moneytree.investmentsinfo (idinvestmentsinfo,symbol,entrydate,entryprice,shares,currentprice,pricedifference,percentagereturn,profitloss) values('" & TBInvID.Text & "', '" & TBSymbol.Text & "','" & DateTimeEntryDate.Text & "', '" & TBEntryPrice.Text & "', '" & TBShares.Text & "','" & TBCurrentPrice.Text & "', '" & TBDifference.Text & "','" & TBPercentageReturn.Text & "','" & TBProfitLoss.Text & "')"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlReader = sqlcommand.ExecuteReader
            MessageBox.Show("Investment saved successfully.")

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub

    Private Sub btnEditInv_Click(sender As Object, e As EventArgs) Handles btnEditInv.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        Dim sqlReader As MySqlDataReader
        Try
            sqlconn.Open()

            Dim sqlQuery As String
            sqlQuery = "update moneytree.investmentsinfo set idinvestmentsinfo='" & TBInvID.Text & "',symbol='" & TBSymbol.Text & "',entrydate='" & DateTimeEntryDate.Text & "',shares='" & TBShares.Text & "',currentprice='" & TBCurrentPrice.Text & "',pricedifference='" & TBDifference.Text & "',percentagereturn='" & TBPercentageReturn.Text & "',profitloss='" & TBProfitLoss.Text & "',entryprice='" & TBEntryPrice.Text & "' where idinvestmentsinfo='" & TBInvID.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlReader = sqlcommand.ExecuteReader
            MessageBox.Show("Investment data edited.")

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub

    Private Sub btnDeleteInv_Click(sender As Object, e As EventArgs) Handles btnDeleteInv.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        Dim sqlReader As MySqlDataReader
        Try
            sqlconn.Open()

            Dim sqlQuery As String
            sqlQuery = "delete from moneytree.investmentsinfo where idinvestmentsinfo='" & TBInvID.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlReader = sqlcommand.ExecuteReader
            MessageBox.Show("Investment data deleted.")

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub


    'Clear all boxes to input text
    Private Sub Clear()
        TBInvID.Text = ""
        TBSymbol.Text = ""
        TBEntryPrice.Text = ""
        TBShares.Text = ""
        TBCurrentPrice.Text = ""
        TBDifference.Text = ""
        TBPercentageReturn.Text = ""
        TBProfitLoss.Text = ""
        DateTimeEntryDate.ResetText()
    End Sub
    Private Sub btnClearInv_Click(sender As Object, e As EventArgs) Handles btnClearInv.Click
        Clear()
    End Sub

    Private Sub FormInvestments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'As the form loads the datagridview also loads whatever data is contained within it 
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim InvestmentsDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            sqlconn.Open()
            Dim sqlQuery As String
            'Select all data from the database
            sqlQuery = "select * from moneytree.investmentsinfo"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlAdapter.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter.Fill(InvestmentsDataSet)

            'Binding the dataset and datagridview
            bSource.DataSource = InvestmentsDataSet
            DGVInvestments.DataSource = bSource
            sqlAdapter.Update(InvestmentsDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try

    End Sub

    'This is so that the datagridview showing all investments can be refreshed after the user enters a new entry into the database 
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim InvestmentsDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            sqlconn.Open()
            Dim sqlQuery As String
            'Select all data from the database
            sqlQuery = "select * from moneytree.investmentsinfo"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlAdapter.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter.Fill(InvestmentsDataSet)

            'Binding the dataset and datagridview
            bSource.DataSource = InvestmentsDataSet
            DGVInvestments.DataSource = bSource
            sqlAdapter.Update(InvestmentsDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try

    End Sub

    Private Sub DGVInvestments_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVInvestments.CellClick
        'Fills the textbox with an investment clicked 
        If e.RowIndex >= 0 Then

            Dim Row As DataGridViewRow
            Row = Me.DGVInvestments.Rows(e.RowIndex)

            TBInvID.Text = Row.Cells("idinvestmentsinfo").Value.ToString
            TBSymbol.Text = Row.Cells("symbol").Value.ToString
            DateTimeEntryDate.Text = Row.Cells("entrydate").Value.ToString
            TBEntryPrice.Text = Row.Cells("entryprice").Value.ToString
            TBShares.Text = Row.Cells("shares").Value.ToString
            TBCurrentPrice.Text = Row.Cells("currentprice").Value.ToString
            TBDifference.Text = Row.Cells("pricedifference").Value.ToString
            TBPercentageReturn.Text = Row.Cells("percentagereturn").Value.ToString
            TBProfitLoss.Text = Row.Cells("profitloss").Value.ToString

        End If
    End Sub

    Private Sub btnInvSearch_Click(sender As Object, e As EventArgs) Handles btnInvSearch.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"

        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim InvSearchDataSet As New DataTable
        Dim b2Source As New BindingSource

        Try
            sqlconn.Open()
            Dim sqlQuery As String

            'Search for all records with what is typed into the textbox by the user 
            sqlQuery = "select * from moneytree.investmentsinfo where symbol = '" & TBInvSearch.Text & "' or entryprice = '" & TBInvSearch.Text & "' or shares = '" & TBInvSearch.Text & "' or currentprice = '" & TBInvSearch.Text & "'or pricedifference = '" & TBInvSearch.Text & "'or percentagereturn = '" & TBInvSearch.Text & "'or idinvestmentsinfo ='" & TBInvSearch.Text & "'or profitloss = '" & TBInvSearch.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)

            sqlAdapter.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter.Fill(InvSearchDataSet)

            'Binding the dataset and datagridview
            b2Source.DataSource = InvSearchDataSet
            DGVInvestments.DataSource = b2Source
            sqlAdapter.Update(InvSearchDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub

    Private Sub btnInvDateSearch_Click(sender As Object, e As EventArgs) Handles btnInvDateSearch.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"

        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim InvSearchDataSet As New DataTable
        Dim b2Source As New BindingSource

        Try
            sqlconn.Open()
            Dim sqlQuery As String


            sqlQuery = "select * from moneytree.investmentsinfo where entrydate = '" & TBInvDateSearch.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)

            sqlAdapter.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter.Fill(InvSearchDataSet)

            'Binding the dataset and datagridview
            b2Source.DataSource = InvSearchDataSet
            DGVInvestments.DataSource = b2Source
            sqlAdapter.Update(InvSearchDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub

    'Shows the external calculator for the user to make calculations 
    Private Sub btnInvCalculator_Click(sender As Object, e As EventArgs) Handles btnInvCalculator.Click
        FormCalculator3.Show()
    End Sub
End Class