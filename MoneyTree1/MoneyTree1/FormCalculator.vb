Imports MySql.Data.MySqlClient
Public Class FormCalculator
    'for mysql connection 
    Dim sqlconn As MySqlConnection
    Dim sqlcommand As MySqlCommand

    'For the calculator to work
    Dim Value1 As Decimal 'First Value input by the user 
    Dim Value2 As Decimal 'Second Value input by the user 
    Dim Answer As Decimal 'The answer by First operator Second
    Dim OperationsChoice As String 'Choose an operation, + - * /

    'To calculate the bill
    Const AMonth = 4 'A month has 4 weeks
    Const AYear = 52 'A year has 52 weeks 


    'If a user clicks on the number one on the calculator
    'If the text is 0 it is replaced by a one
    'If the text is not a 0 one is added next to it
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If Calc.Text = "0" Then
            Calc.Text = "1"
        Else
            Calc.Text = Calc.Text + "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If Calc.Text = "0" Then
            Calc.Text = "2"
        Else
            Calc.Text = Calc.Text + "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If Calc.Text = "0" Then
            Calc.Text = "3"
        Else
            Calc.Text = Calc.Text + "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If Calc.Text = "0" Then
            Calc.Text = "4"
        Else
            Calc.Text = Calc.Text + "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If Calc.Text = "0" Then
            Calc.Text = "5"
        Else
            Calc.Text = Calc.Text + "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If Calc.Text = "0" Then
            Calc.Text = "6"
        Else
            Calc.Text = Calc.Text + "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If Calc.Text = "0" Then
            Calc.Text = "7"
        Else
            Calc.Text = Calc.Text + "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If Calc.Text = "0" Then
            Calc.Text = "8"
        Else
            Calc.Text = Calc.Text + "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If Calc.Text = "0" Then
            Calc.Text = "9"
        Else
            Calc.Text = Calc.Text + "9"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If Calc.Text = "0" Then
            Calc.Text = "0"
        Else
            Calc.Text = Calc.Text + "0"
        End If
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        'Cannot have more than one decimal so it can only be used if there's not a decimal point already there
        If Not (Calc.Text.Contains(".")) Then
            Calc.Text += "."
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Value1 = Calc.Text
        LblShowCurrentCalc.Text = Value1 & " +" 'LblShowCurrentCalc Shows the calculation that is occurring 
        Calc.Text = ""
        OperationsChoice = "+"

    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        Value1 = Calc.Text
        LblShowCurrentCalc.Text = Value1 & " -"
        Calc.Text = ""
        OperationsChoice = "-"
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Value1 = Calc.Text
        LblShowCurrentCalc.Text = Value1 & " /"
        Calc.Text = ""
        OperationsChoice = "/"
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        Value1 = Calc.Text
        LblShowCurrentCalc.Text = Value1 & " *"
        Calc.Text = ""
        OperationsChoice = "*"
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        Value2 = Calc.Text
        If OperationsChoice = "+" Then
            Answer = Value1 + Value2
            Calc.Text = Answer
            LblShowCurrentCalc.Text = ""
        End If
        If OperationsChoice = "-" Then
            Answer = Value1 - Value2
            Calc.Text = Answer
            LblShowCurrentCalc.Text = ""
        End If
        If OperationsChoice = "/" Then
            Answer = Value1 / Value2
            Calc.Text = Answer
            LblShowCurrentCalc.Text = ""
        End If
        If OperationsChoice = "*" Then
            Answer = Value1 * Value2
            Calc.Text = Answer
            LblShowCurrentCalc.Text = ""
        End If
    End Sub
    'Used to clear the calculator 
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Calc.Text = ""
        LblShowCurrentCalc.Text = ""
        Calc.Text = "0"
    End Sub
    'Used to clear the textboxes
    Private Sub Clear()
        TBBillID.Text = ""
        TBRent.Text = ""
        TBTax.Text = ""
        TBWater.Text = ""
        TBMobile.Text = ""
        TBElectricity.Text = ""
        TBGas.Text = ""
        DateTimeBillDate.ResetText()
    End Sub

    'Puts the values from the row of the cell clicked into their specific textboxes 
    Private Sub DGVBill_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVBill.CellClick
        'Fills the textbox with a bill calculation clicked 
        If e.RowIndex >= 0 Then

            Dim Row As DataGridViewRow
            Row = Me.DGVBill.Rows(e.RowIndex)

            TBBillID.Text = Row.Cells("idbillsinfo").Value.ToString
            TBRent.Text = Row.Cells("rent").Value.ToString
            TBTax.Text = Row.Cells("counciltax").Value.ToString
            TBWater.Text = Row.Cells("water").Value.ToString
            TBMobile.Text = Row.Cells("mobile").Value.ToString
            TBElectricity.Text = Row.Cells("electricity").Value.ToString
            TBGas.Text = Row.Cells("gas").Value.ToString
            DateTimeBillDate.Text = Row.Cells("date").Value.ToString

        End If
    End Sub

    'Fills the datagridview
    Sub BillDGVViewer()
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim BillsDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            sqlconn.Open()
            Dim sqlQuery As String
            'Select all data from the database
            sqlQuery = "select * from moneytree.billsinfo"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlAdapter.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter.Fill(BillsDataSet)

            'Binding the dataset and datagridview
            bSource.DataSource = BillsDataSet
            DGVBill.DataSource = bSource
            sqlAdapter.Update(BillsDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub
    Private Sub FormCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BillDGVViewer()
    End Sub

    'To calculate the fixed costs of rent and tax, over either a week, month or year
    Sub CalcRentTax()
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"

        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim RentTaxDataSet As New DataTable
        Dim b2Source As New BindingSource

        Try
            sqlconn.Open()
            Dim sqlQuery As String

            'Search for all records where the ID is the one that is input by the user(all these attributes are integer)
            sqlQuery = "select * from moneytree.billsinfo where idbillsinfo = '" & IDBillMonthlyTB.Text & "' or idbillsinfo = '" & IDBillYearlyTB.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)

            sqlAdapter.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter.Fill(RentTaxDataSet)

            'Binding the dataset and datagridview
            b2Source.DataSource = RentTaxDataSet
            DGVBill.DataSource = b2Source
            sqlAdapter.Update(RentTaxDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try


    End Sub
    Private Sub btnCalcMonthly_Click(sender As Object, e As EventArgs) Handles btnCalcMonthly.Click
        CalcRentTax() 'Calls the subroutine that will have the amount of rent and tax displayed 

        Dim MonthlyTotalRent As Decimal
        Dim MonthlyTotalTax As Decimal

        'average 4 weeks a month
        MonthlyTotalRent = DGVBill.Rows(0).Cells(1).Value * 4
        MonthlyTotalTax = DGVBill.Rows(0).Cells(2).Value * 4
        'By default the currency is in £
        TBMonthRent.Text = "£" & MonthlyTotalRent
        TBMonthTax.Text = "£" & MonthlyTotalTax


    End Sub

    Private Sub btnCalcYearly_Click(sender As Object, e As EventArgs) Handles btnCalcYearly.Click
        CalcRentTax()

        Dim YearlyTotalRent As Decimal
        Dim YearlyTotalTax As Decimal

        '52 weeks in a year
        YearlyTotalRent = DGVBill.Rows(0).Cells(1).Value * 52
        YearlyTotalTax = DGVBill.Rows(0).Cells(2).Value * 52
        TBYearlyTax.Text = "£" & YearlyTotalRent
        TBYearlyRent.Text = "£" & YearlyTotalTax
    End Sub

    'Clears the textboxes for finding monthly tax and rent 
    Private Sub btnClearMonthTax_Click(sender As Object, e As EventArgs) Handles btnClearMonthTax.Click
        IDBillMonthlyTB.Text = ""
        TBMonthTax.Text = ""
        TBMonthRent.Text = ""
    End Sub
    'Clears the textboxes for finding yearly tax and rent 
    Private Sub btnClearYearTax_Click(sender As Object, e As EventArgs) Handles btnClearYearTax.Click
        IDBillYearlyTB.Text = ""
        TBYearlyTax.Text = ""
        TBYearlyRent.Text = ""
    End Sub
    'Bubble sorting highest to lowest 
    Sub SortingCostsHighestToLowest()

        'All for a weekly bill only.
        'Taking the text from each specific textbox to store in a local variable 

        'Storing the value within the textboxes to an array
        Dim CostsArray(6) As Decimal
        Dim iTemp As Decimal

        If TBRent.Text <> "" And TBTax.Text <> "" And TBWater.Text <> "" And TBMobile.Text <> "" And TBElectricity.Text <> "" And TBGas.Text <> "" Then
            'Assigning the textbox values to the array 
            CostsArray(0) = TBRent.Text
            CostsArray(1) = TBTax.Text
            CostsArray(2) = TBWater.Text
            CostsArray(3) = TBMobile.Text
            CostsArray(4) = TBElectricity.Text
            CostsArray(5) = TBGas.Text

            'Store textbox values in the local variables
            Dim CostRent As Decimal = TBRent.Text
            Dim CostTax As Decimal = TBTax.Text
            Dim CostWater As Decimal = TBWater.Text
            Dim CostMobile As Decimal = TBMobile.Text
            Dim CostElectricity As Decimal = TBElectricity.Text
            Dim CostGas As Decimal = TBGas.Text

            'Stores all the bills added together 
            Dim TotalCosts As Decimal

            TotalCosts = CostRent + CostTax + CostWater + CostElectricity + CostGas

            'Bubble sort 
            For iPass = 1 To 6
                For i = 0 To 5
                    If CostsArray(i) < CostsArray(i + 1) Then
                        iTemp = CostsArray(i)
                        CostsArray(i) = CostsArray(i + 1)
                        CostsArray(i + 1) = iTemp
                    End If
                Next i
            Next iPass

            Dim BubbleSortPrintOut As String
            For i = 0 To 6
                If CostsArray(i) = TBRent.Text Then
                    BubbleSortPrintOut = BubbleSortPrintOut & "Rent: £" & CostsArray(i) & vbNewLine
                End If
                If CostsArray(i) = TBTax.Text Then
                    BubbleSortPrintOut = BubbleSortPrintOut & "Tax: £" & CostsArray(i) & vbNewLine
                End If
                If CostsArray(i) = TBWater.Text Then
                    BubbleSortPrintOut = BubbleSortPrintOut & "Water: £" & CostsArray(i) & vbNewLine
                End If
                If CostsArray(i) = TBMobile.Text Then
                    BubbleSortPrintOut = BubbleSortPrintOut & "Mobile: £" & CostsArray(i) & vbNewLine
                End If
                If CostsArray(i) = TBElectricity.Text Then
                    BubbleSortPrintOut = BubbleSortPrintOut & "Electricity: £" & CostsArray(i) & vbNewLine
                End If
                If CostsArray(i) = TBGas.Text Then
                    BubbleSortPrintOut = BubbleSortPrintOut & "Gas: £" & CostsArray(i) & vbNewLine
                End If
            Next

            'Displaying the receipt for the bill
            TBTotal.AppendText(" " & vbNewLine)
            TBTotal.AppendText("------------------------------------------------" & vbNewLine)
            TBTotal.AppendText("           WEEKLY TOTAL BILL" & vbNewLine)
            TBTotal.AppendText("           " & DateTime.Now() & vbNewLine)
            TBTotal.AppendText("------------------------------------------------" & vbNewLine)
            TBTotal.AppendText(" " & vbNewLine)
            TBTotal.AppendText(BubbleSortPrintOut)
            TBTotal.AppendText(" " & vbNewLine)
            TBTotal.AppendText("Total Bill: £" & TotalCosts & vbNewLine)
            TBTotal.AppendText(" " & vbNewLine)
            TBTotal.AppendText("------------------------------------------------" & vbNewLine)

        Else
            If TBRent.Text = "" Then
                MsgBox("Please enter a value for rent. If there is none type 0.")
            End If
            If TBTax.Text = "" Then
                MsgBox("Please enter a value for tax. If there is none type 0.")
            End If
            If TBWater.Text = "" Then
                MsgBox("Please enter a value for water. If there is none type 0.")
            End If
            If TBMobile.Text = "" Then
                MsgBox("Please enter a value for mobile. If there is none type 0.")
            End If
            If TBElectricity.Text = "" Then
                MsgBox("Please enter a value for electricity. If there is none type 0.")
            End If
            If TBGas.Text = "" Then
                MsgBox("Please enter a value for gas. If there is none type 0.")
            End If
        End If
    End Sub


    Private Sub btnGenReceipt_Click(sender As Object, e As EventArgs) Handles btnGenReceipt.Click
        SortingCostsHighestToLowest()
    End Sub

    Private Sub btnSaveBill_Click_1(sender As Object, e As EventArgs) Handles btnSaveBill.Click
        'Connects to the database moneytree
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        Dim sqlReader As MySqlDataReader
        Try
            sqlconn.Open()

            Dim sqlQuery As String
            sqlQuery = "insert into moneytree.billsinfo (idbillsinfo,rent,counciltax,water,mobile,electricity,gas,date) values('" & TBBillID.Text & "', '" & TBRent.Text & "','" & TBTax.Text & "', '" & TBWater.Text & "', '" & TBMobile.Text & "', '" & TBElectricity.Text & "', '" & TBGas.Text & "', '" & DateTimeBillDate.Text & "')"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlReader = sqlcommand.ExecuteReader
            MessageBox.Show("Bill calculation saved successfully.")

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub
    'Edit a bill selected by a user when they click on a cell on the datagridviewer
    Private Sub btnEditBill_Click_1(sender As Object, e As EventArgs) Handles btnEditBill.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        Dim sqlReader As MySqlDataReader
        Try
            sqlconn.Open()

            Dim sqlQuery As String
            sqlQuery = "update moneytree.billsinfo set idbillsinfo='" & TBBillID.Text & "',rent='" & TBRent.Text & "',counciltax='" & TBTax.Text & "',water='" & TBWater.Text & "',mobile='" & TBMobile.Text & "',electricity='" & TBElectricity.Text & "',gas='" & TBGas.Text & "',date='" & DateTimeBillDate.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlReader = sqlcommand.ExecuteReader
            MessageBox.Show("Bill calculation edited.")

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub
    'Delete using the BillID input by the user 
    Private Sub btnDeleteBill_Click_1(sender As Object, e As EventArgs) Handles btnDeleteBill.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        Dim sqlReader As MySqlDataReader
        Try
            sqlconn.Open()

            Dim sqlQuery As String
            sqlQuery = "delete from moneytree.billsinfo where idbillsinfo='" & TBBillID.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlReader = sqlcommand.ExecuteReader
            MessageBox.Show("Bill calculation deleted.")

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub
    'Clear the receipt
    Private Sub btnClearBill_Click_1(sender As Object, e As EventArgs) Handles btnClearBill.Click
        Clear()
    End Sub

    'Refresh the DataGridViewer to show new budget entries 
    Private Sub btnRefreshDGVBill_Click(sender As Object, e As EventArgs) Handles btnRefreshDGVBill.Click
        BillDGVViewer()
    End Sub

    Private Sub btnBillSearch_Click(sender As Object, e As EventArgs) Handles btnBillSearch.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"

        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim BillDataSet As New DataTable
        Dim b2Source As New BindingSource

        Try
            sqlconn.Open()
            Dim sqlQuery As String

            'Search for all records with a certain string in it (all these attributes are varchar or decimal or integer)
            sqlQuery = "select * from moneytree.billsinfo where idbillsinfo = '" & TBBillSearch.Text & "' or rent = '" & TBBillSearch.Text & "' or counciltax = '" & TBBillSearch.Text & "' or water = '" & TBBillSearch.Text & "' or mobile = '" & TBBillSearch.Text & "' or electricity = '" & TBBillSearch.Text & "' or gas = '" & TBBillSearch.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)

            sqlAdapter.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter.Fill(BillDataSet)

            'Binding the dataset and datagridview
            b2Source.DataSource = BillDataSet
            DGVBill.DataSource = b2Source
            sqlAdapter.Update(BillDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub

    Private Sub btnBillDateSearch_Click(sender As Object, e As EventArgs) Handles btnBillDateSearch.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"

        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim RentTaxDataSet As New DataTable
        Dim b2Source As New BindingSource

        Try
            sqlconn.Open()
            Dim sqlQuery As String

            'Search for all records with a certain ID in it (all these attributes are integer)
            sqlQuery = "select * from moneytree.billsinfo where date = '" & TBBillDateSearch.Text & "'"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)

            sqlAdapter.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter.Fill(RentTaxDataSet)

            'Binding the dataset and datagridview
            b2Source.DataSource = RentTaxDataSet
            DGVBill.DataSource = b2Source
            sqlAdapter.Update(RentTaxDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub
End Class