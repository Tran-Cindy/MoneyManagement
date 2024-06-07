Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports Tulpep.NotificationWindow
Public Class FormHomescreen
    'makes a connection to the mysql database 
    Dim sqlconn As MySqlConnection
    Dim sqlcommand As MySqlCommand

    Public Class PictureBoxCreate
        Inherits PictureBox
    End Class

    Public Class ConnectFormTransactions
        Inherits FormTransactions
    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Code to load the title image, resizing and positioning it
        Dim TitleImage As New PictureBoxCreate
        TitleImage.BackgroundImage() = Image.FromFile("C:\Users\cindy\Downloads\titleimage3.png")
        TitleImage.Size = New Size(340, 70)
        TitleImage.Location = New System.Drawing.Point(465, 50)
        TitleImage.BackgroundImageLayout = BackgroundImageLayout.Stretch 'Allows the image to fit the size of the image box
        TitleImage.BackColor = Color.Transparent
        Me.Controls.Add(TitleImage)

        'To control the progress bar (battery) that shows how much of the income is spent 
        'The minimum of the finance tracker is always 0, it is not possible to be in debt 
        FinancesTracker.Minimum = 0

        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        'Retrieve data from the database
        Dim sqlAdapter2 As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim FinanceTrackDataSet As New DataTable
        Dim bSource2 As New BindingSource

        Dim IncomeCalc2 As Decimal = 0
        Dim ExpenseCalc2 As Decimal = 0
        Dim RoundedIncome As Integer = 0
        Dim RoundedExpense As Integer = 0
        Dim RoundedTotalFinance As Integer = 0
        Dim FinancePercentage As Integer = 0

        Try
            sqlconn.Open()
            Dim sqlQuery As String
            'Select all data from the database
            sqlQuery = "select * from moneytree.transactionsinfo"
            sqlcommand = New MySqlCommand(sqlQuery, sqlconn)
            sqlAdapter2.SelectCommand = sqlcommand

            'Fill the data from the query into the dataset
            sqlAdapter2.Fill(FinanceTrackDataSet)

            'Binding the dataset and datagridview
            bSource2.DataSource = FinanceTrackDataSet
            DGVFinanceT.DataSource = bSource2
            sqlAdapter2.Update(FinanceTrackDataSet)

            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try

        'A for loop that goes through each row in the datagridviewer
        'Cell 3 will either contain Income/Expense 
        'if it's an income value then the amount from that row is added to the income counter
        For a = 0 To DGVFinanceT.Rows.Count - 1
            If DGVFinanceT.Rows(a).Cells(3).Value = "Income" Then
                IncomeCalc2 += DGVFinanceT.Rows(a).Cells(2).Value
            End If

            If DGVFinanceT.Rows(a).Cells(3).Value = "Expense" Then
                ExpenseCalc2 += DGVFinanceT.Rows(a).Cells(2).Value
            End If
        Next

        RoundedTotalFinance = (Math.Round(IncomeCalc2 - ExpenseCalc2))

        'The income and expense is rounded as the progress bar does not take decimal values
        RoundedIncome = Math.Round(IncomeCalc2)
        RoundedExpense = Math.Round(ExpenseCalc2)

        'Calculating a percentage to be able to change the colour of the progress bar
        FinancePercentage = Math.Round((RoundedTotalFinance / IncomeCalc2) * 100)
        LblFinanceTracker.Text = (FinancePercentage & "%")

        'To change the value of the progress bar and the colour
        '0-20% red, 21-40% orange, 41-60% yellow, 61-80% lime, 81-100% green
        If RoundedIncome > RoundedExpense Then
            FinancesTracker.Maximum = RoundedIncome
            FinancesTracker.Value = RoundedTotalFinance
            Select Case FinancePercentage
                Case 0 To 20
                    FinancesTracker.ForeColor = Color.Red
                Case 21 To 40
                    FinancesTracker.ForeColor = Color.Orange
                Case 41 To 60
                    FinancesTracker.ForeColor = Color.Yellow
                Case 61 To 80
                    FinancesTracker.ForeColor = Color.GreenYellow
                Case 81 To 100
                    FinancesTracker.ForeColor = Color.LimeGreen
            End Select
        Else
            MessageBox.Show("You do not have any finances to track at the moment.")
        End If


        Dim popupinvest = New PopupNotifier
        popupinvest.TitleText = "REMINDERS"
        popupinvest.ContentText = "Don't forget to invest."
        popupinvest.Popup()

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        FormSettings.Show()
    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        FormTransactions.Show()
    End Sub

    Private Sub btnWishlist_Click(sender As Object, e As EventArgs) Handles btnWishlist.Click
        FormWishlist2.Show()
    End Sub

    Private Sub btnBudget_Click(sender As Object, e As EventArgs) Handles btnBudget.Click
        FormBudget.Show()
    End Sub

    Private Sub btnCalendar_Click(sender As Object, e As EventArgs) Handles btnCalendar.Click
        FormCalendar2.Show()
    End Sub

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnBillCalculator.Click
        FormCalculator.Show()
    End Sub

    Private Sub btnInvestments_Click(sender As Object, e As EventArgs) Handles btnInvestments.Click
        FormInvestments.Show()
    End Sub

    Private Sub btnLoadChart_Click(sender As Object, e As EventArgs) Handles btnLoadChart.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=dataBASE2112cs-onmyoji;database=moneytree"
        'Retrieve data from the database
        Dim sqlAdapter As New MySqlDataAdapter

        'Bind the data to the data grid view
        Dim TransactionsDataSet As New DataTable
        Dim bSource As New BindingSource

        Dim IncomeCalc As Decimal = 0
        Dim ExpenseCalc As Decimal = 0
        Dim TotalFinance As Decimal = 0

        'Calculating the amount spent on each category 
        Dim OtherExpenseCalc As Decimal = 0
        Dim BeautyCalc As Decimal = 0
        Dim ClothesCalc As Decimal = 0
        Dim EntertainmentCalc As Decimal = 0
        Dim FoodAndDrinkCategoryCalc As Decimal = 0
        Dim FuelCalc As Decimal = 0
        Dim GiftsCalc As Decimal = 0
        Dim HolidaysCalc As Decimal = 0
        Dim HouseholdCalc As Decimal = 0
        Dim TravelCalc As Decimal = 0
        Dim ElectricityCalc As Decimal = 0
        Dim GasCalc As Decimal = 0
        Dim WaterCalc As Decimal = 0
        Dim MobileCalc As Decimal = 0
        Dim TaxCalc As Decimal = 0
        Dim RentCalc As Decimal = 0

        If DateTimeFirstDate.Value = DateTimeSecondDate.Value Then
            MessageBox.Show("Please select 2 different dates.")
        End If

        If DateTimeFirstDate.Value <> DateTimeSecondDate.Value Then
            Try
                sqlconn.Open()
                Dim sqlQuery As String
                'Select all data from the database
                sqlQuery = "select * from moneytree.transactionsinfo where date between '" & DateTimeFirstDate.Text & "' and '" & DateTimeSecondDate.Text & "' "
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
        End If
        For a = 0 To DGVTransactions.Rows.Count - 1
            If DGVTransactions.Rows(a).Cells(3).Value = "Income" Then
                IncomeCalc += DGVTransactions.Rows(a).Cells(2).Value
            End If

            If DGVTransactions.Rows(a).Cells(3).Value = "Expense" Then
                ExpenseCalc += DGVTransactions.Rows(a).Cells(2).Value
            End If
        Next

        'Creates a total of each category, which is going to be used in the pie chart
        For columncounter = 0 To DGVTransactions.Rows.Count - 1
            If DGVTransactions.Rows(columncounter).Cells(4).Value = "Other Expense" Then
                OtherExpenseCalc += DGVTransactions.Rows(columncounter).Cells(2).Value
            End If

            If DGVTransactions.Rows(columncounter).Cells(4).Value = "Beauty" Then
                BeautyCalc += DGVTransactions.Rows(columncounter).Cells(2).Value
            End If

            If DGVTransactions.Rows(columncounter).Cells(4).Value = "Clothes" Then
                ClothesCalc += DGVTransactions.Rows(columncounter).Cells(2).Value
            End If

            If DGVTransactions.Rows(columncounter).Cells(4).Value = "Entertainment" Then
                EntertainmentCalc += DGVTransactions.Rows(columncounter).Cells(2).Value
            End If

            If DGVTransactions.Rows(columncounter).Cells(4).Value = "Food & Drink" Then
                FoodAndDrinkCategoryCalc += DGVTransactions.Rows(columncounter).Cells(2).Value
            End If

            If DGVTransactions.Rows(columncounter).Cells(4).Value = "Fuel" Then
                FuelCalc += DGVTransactions.Rows(columncounter).Cells(2).Value
            End If

            If DGVTransactions.Rows(columncounter).Cells(4).Value = "Gifts" Then
                GiftsCalc += DGVTransactions.Rows(columncounter).Cells(2).Value
            End If

            If DGVTransactions.Rows(columncounter).Cells(4).Value = "Holidays" Then
                HolidaysCalc += DGVTransactions.Rows(columncounter).Cells(2).Value
            End If

            If DGVTransactions.Rows(columncounter).Cells(4).Value = "Household" Then
                HouseholdCalc += DGVTransactions.Rows(columncounter).Cells(2).Value
            End If

            If DGVTransactions.Rows(columncounter).Cells(4).Value = "Travel" Then
                TravelCalc += DGVTransactions.Rows(columncounter).Cells(2).Value
            End If

            If DGVTransactions.Rows(columncounter).Cells(4).Value = "Electricity bill" Then
                ElectricityCalc += DGVTransactions.Rows(columncounter).Cells(2).Value
            End If

            If DGVTransactions.Rows(columncounter).Cells(4).Value = "Gas bill" Then
                GasCalc += DGVTransactions.Rows(columncounter).Cells(2).Value
            End If

            If DGVTransactions.Rows(columncounter).Cells(4).Value = "Water bill" Then
                WaterCalc += DGVTransactions.Rows(columncounter).Cells(2).Value
            End If

            If DGVTransactions.Rows(columncounter).Cells(4).Value = "Mobile bill" Then
                MobileCalc += DGVTransactions.Rows(columncounter).Cells(2).Value
            End If

            If DGVTransactions.Rows(columncounter).Cells(4).Value = "Council tax" Then
                TaxCalc += DGVTransactions.Rows(columncounter).Cells(2).Value
            End If

            If DGVTransactions.Rows(columncounter).Cells(4).Value = "Rent" Then
                RentCalc += DGVTransactions.Rows(columncounter).Cells(2).Value
            End If

        Next

        'Expenses displayed as a pie chart 
        Dim ExpenseByCategory As Series = ChartExpense.Series("MT")
        ExpenseByCategory.ChartType = SeriesChartType.Pie
        ExpenseByCategory.Palette = ChartColorPalette.SeaGreen

        'Adding the categories to be displayed on the pie chart
        ExpenseByCategory.Points.AddXY("Food & Drink", FoodAndDrinkCategoryCalc)
        ExpenseByCategory.Points.AddXY("Gifts", GiftsCalc)
        ExpenseByCategory.Points.AddXY("Clothes", ClothesCalc)
        ExpenseByCategory.Points.AddXY("Entertainment", EntertainmentCalc)
        ExpenseByCategory.Points.AddXY("Beauty", BeautyCalc)
        ExpenseByCategory.Points.AddXY("Other Expense", OtherExpenseCalc)
        ExpenseByCategory.Points.AddXY("Fuel", FuelCalc)
        ExpenseByCategory.Points.AddXY("Holidays", HolidaysCalc)
        ExpenseByCategory.Points.AddXY("Household", HouseholdCalc)
        ExpenseByCategory.Points.AddXY("Travel", TravelCalc)
        ExpenseByCategory.Points.AddXY("Electricity bill", ElectricityCalc)
        ExpenseByCategory.Points.AddXY("Gas bill", GasCalc)
        ExpenseByCategory.Points.AddXY("Water bill", WaterCalc)
        ExpenseByCategory.Points.AddXY("Mobile bill", MobileCalc)
        ExpenseByCategory.Points.AddXY("Council tax", TaxCalc)
        ExpenseByCategory.Points.AddXY("Rent", RentCalc)

        TotalFinance = IncomeCalc - ExpenseCalc

        IncomeSum.Text = IncomeCalc
        ExpenseSum.Text = ExpenseCalc
    End Sub

End Class
