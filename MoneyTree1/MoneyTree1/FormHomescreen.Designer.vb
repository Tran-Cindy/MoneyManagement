<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHomescreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHomescreen))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.TTSettings = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.FinancesTracker = New System.Windows.Forms.ProgressBar()
        Me.ChartExpense = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TTTransactions = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnTransactions = New System.Windows.Forms.Button()
        Me.LblFinanceTracker = New System.Windows.Forms.Label()
        Me.DateTimeFirstDate = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimeSecondDate = New System.Windows.Forms.DateTimePicker()
        Me.LblFromDate = New System.Windows.Forms.Label()
        Me.Lbl_TotalExpense = New System.Windows.Forms.Label()
        Me.Lbl_TotalIncome = New System.Windows.Forms.Label()
        Me.ExpenseSum = New System.Windows.Forms.TextBox()
        Me.IncomeSum = New System.Windows.Forms.TextBox()
        Me.DGVTransactions = New System.Windows.Forms.DataGridView()
        Me.FoodAndDrinkSum = New System.Windows.Forms.TextBox()
        Me.DGVFinanceT = New System.Windows.Forms.DataGridView()
        Me.PBShopping = New System.Windows.Forms.PictureBox()
        Me.PBWallet = New System.Windows.Forms.PictureBox()
        Me.PBCalculator = New System.Windows.Forms.PictureBox()
        Me.PBChecklist = New System.Windows.Forms.PictureBox()
        Me.PBCalendar = New System.Windows.Forms.PictureBox()
        Me.PBCalcTotal = New System.Windows.Forms.PictureBox()
        Me.PBTree = New System.Windows.Forms.PictureBox()
        Me.PBTree2 = New System.Windows.Forms.PictureBox()
        Me.btnLoadChart = New System.Windows.Forms.Button()
        Me.btnBillCalculator = New System.Windows.Forms.Button()
        Me.btnWishlist = New System.Windows.Forms.Button()
        Me.btnCalendar = New System.Windows.Forms.Button()
        Me.btnInvestments = New System.Windows.Forms.Button()
        Me.btnBudget = New System.Windows.Forms.Button()
        Me.PBStocks = New System.Windows.Forms.PictureBox()
        Me.TTCalendar = New System.Windows.Forms.ToolTip(Me.components)
        Me.TTWishlist = New System.Windows.Forms.ToolTip(Me.components)
        Me.TTBillCalculator = New System.Windows.Forms.ToolTip(Me.components)
        Me.TTBudgets = New System.Windows.Forms.ToolTip(Me.components)
        Me.TTInvestments = New System.Windows.Forms.ToolTip(Me.components)
        Me.TTLoadChart = New System.Windows.Forms.ToolTip(Me.components)
        Me.LblTip = New System.Windows.Forms.Label()
        CType(Me.ChartExpense, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVFinanceT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBShopping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBWallet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCalculator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBChecklist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCalcTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBTree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBTree2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TTSettings
        '
        Me.TTSettings.ToolTipTitle = "Settings"
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSettings.BackgroundImage = CType(resources.GetObject("btnSettings.BackgroundImage"), System.Drawing.Image)
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSettings.Location = New System.Drawing.Point(1678, 37)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(150, 150)
        Me.btnSettings.TabIndex = 0
        Me.TTSettings.SetToolTip(Me.btnSettings, "Change theme, Notifications")
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'FinancesTracker
        '
        Me.FinancesTracker.BackColor = System.Drawing.Color.White
        Me.FinancesTracker.ForeColor = System.Drawing.Color.Aqua
        Me.FinancesTracker.Location = New System.Drawing.Point(1328, 37)
        Me.FinancesTracker.Maximum = 200
        Me.FinancesTracker.Name = "FinancesTracker"
        Me.FinancesTracker.Size = New System.Drawing.Size(344, 69)
        Me.FinancesTracker.TabIndex = 9
        Me.FinancesTracker.Value = 35
        '
        'ChartExpense
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartExpense.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartExpense.Legends.Add(Legend1)
        Me.ChartExpense.Location = New System.Drawing.Point(640, 400)
        Me.ChartExpense.Name = "ChartExpense"
        Me.ChartExpense.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "MT"
        Me.ChartExpense.Series.Add(Series1)
        Me.ChartExpense.Size = New System.Drawing.Size(636, 375)
        Me.ChartExpense.TabIndex = 10
        '
        'TTTransactions
        '
        Me.TTTransactions.ToolTipTitle = "Transactions"
        '
        'btnTransactions
        '
        Me.btnTransactions.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnTransactions.BackgroundImage = CType(resources.GetObject("btnTransactions.BackgroundImage"), System.Drawing.Image)
        Me.btnTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTransactions.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransactions.ForeColor = System.Drawing.Color.DimGray
        Me.btnTransactions.Location = New System.Drawing.Point(1328, 232)
        Me.btnTransactions.Name = "btnTransactions"
        Me.btnTransactions.Size = New System.Drawing.Size(500, 100)
        Me.btnTransactions.TabIndex = 3
        Me.btnTransactions.Text = "Transactions"
        Me.TTTransactions.SetToolTip(Me.btnTransactions, "Add, edit, view and delete, income or expenses" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Search & view previous transactio" &
        "ns" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnTransactions.UseVisualStyleBackColor = False
        '
        'LblFinanceTracker
        '
        Me.LblFinanceTracker.AutoSize = True
        Me.LblFinanceTracker.BackColor = System.Drawing.Color.Transparent
        Me.LblFinanceTracker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFinanceTracker.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblFinanceTracker.Location = New System.Drawing.Point(1604, 55)
        Me.LblFinanceTracker.Name = "LblFinanceTracker"
        Me.LblFinanceTracker.Size = New System.Drawing.Size(32, 26)
        Me.LblFinanceTracker.TabIndex = 11
        Me.LblFinanceTracker.Text = "%"
        '
        'DateTimeFirstDate
        '
        Me.DateTimeFirstDate.CustomFormat = "yyyy-MM-dd"
        Me.DateTimeFirstDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeFirstDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeFirstDate.Location = New System.Drawing.Point(198, 17)
        Me.DateTimeFirstDate.Name = "DateTimeFirstDate"
        Me.DateTimeFirstDate.Size = New System.Drawing.Size(181, 35)
        Me.DateTimeFirstDate.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DateTimeSecondDate)
        Me.Panel1.Controls.Add(Me.LblFromDate)
        Me.Panel1.Controls.Add(Me.DateTimeFirstDate)
        Me.Panel1.Location = New System.Drawing.Point(640, 232)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 69)
        Me.Panel1.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.Location = New System.Drawing.Point(394, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 30)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "to"
        '
        'DateTimeSecondDate
        '
        Me.DateTimeSecondDate.CustomFormat = "yyyy-MM-dd"
        Me.DateTimeSecondDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeSecondDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeSecondDate.Location = New System.Drawing.Point(445, 17)
        Me.DateTimeSecondDate.Name = "DateTimeSecondDate"
        Me.DateTimeSecondDate.Size = New System.Drawing.Size(181, 35)
        Me.DateTimeSecondDate.TabIndex = 21
        '
        'LblFromDate
        '
        Me.LblFromDate.AutoSize = True
        Me.LblFromDate.BackColor = System.Drawing.Color.Transparent
        Me.LblFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFromDate.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblFromDate.Location = New System.Drawing.Point(23, 17)
        Me.LblFromDate.Name = "LblFromDate"
        Me.LblFromDate.Size = New System.Drawing.Size(152, 30)
        Me.LblFromDate.TabIndex = 20
        Me.LblFromDate.Text = "From Date:"
        '
        'Lbl_TotalExpense
        '
        Me.Lbl_TotalExpense.AutoSize = True
        Me.Lbl_TotalExpense.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TotalExpense.ForeColor = System.Drawing.Color.Azure
        Me.Lbl_TotalExpense.Location = New System.Drawing.Point(635, 355)
        Me.Lbl_TotalExpense.Name = "Lbl_TotalExpense"
        Me.Lbl_TotalExpense.Size = New System.Drawing.Size(188, 30)
        Me.Lbl_TotalExpense.TabIndex = 32
        Me.Lbl_TotalExpense.Text = "Total Expense"
        '
        'Lbl_TotalIncome
        '
        Me.Lbl_TotalIncome.AutoSize = True
        Me.Lbl_TotalIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TotalIncome.ForeColor = System.Drawing.Color.Azure
        Me.Lbl_TotalIncome.Location = New System.Drawing.Point(635, 314)
        Me.Lbl_TotalIncome.Name = "Lbl_TotalIncome"
        Me.Lbl_TotalIncome.Size = New System.Drawing.Size(213, 30)
        Me.Lbl_TotalIncome.TabIndex = 31
        Me.Lbl_TotalIncome.Text = "Current Balance"
        '
        'ExpenseSum
        '
        Me.ExpenseSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpenseSum.Location = New System.Drawing.Point(870, 354)
        Me.ExpenseSum.Name = "ExpenseSum"
        Me.ExpenseSum.Size = New System.Drawing.Size(128, 35)
        Me.ExpenseSum.TabIndex = 30
        '
        'IncomeSum
        '
        Me.IncomeSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncomeSum.Location = New System.Drawing.Point(870, 314)
        Me.IncomeSum.Name = "IncomeSum"
        Me.IncomeSum.Size = New System.Drawing.Size(128, 35)
        Me.IncomeSum.TabIndex = 29
        '
        'DGVTransactions
        '
        Me.DGVTransactions.BackgroundColor = System.Drawing.Color.Azure
        Me.DGVTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTransactions.Location = New System.Drawing.Point(89, 87)
        Me.DGVTransactions.Name = "DGVTransactions"
        Me.DGVTransactions.RowHeadersWidth = 62
        Me.DGVTransactions.RowTemplate.Height = 28
        Me.DGVTransactions.Size = New System.Drawing.Size(71, 71)
        Me.DGVTransactions.TabIndex = 33
        Me.DGVTransactions.Visible = False
        '
        'FoodAndDrinkSum
        '
        Me.FoodAndDrinkSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoodAndDrinkSum.Location = New System.Drawing.Point(12, 164)
        Me.FoodAndDrinkSum.Name = "FoodAndDrinkSum"
        Me.FoodAndDrinkSum.Size = New System.Drawing.Size(103, 35)
        Me.FoodAndDrinkSum.TabIndex = 34
        Me.FoodAndDrinkSum.Visible = False
        '
        'DGVFinanceT
        '
        Me.DGVFinanceT.BackgroundColor = System.Drawing.Color.Azure
        Me.DGVFinanceT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVFinanceT.Location = New System.Drawing.Point(12, 87)
        Me.DGVFinanceT.Name = "DGVFinanceT"
        Me.DGVFinanceT.RowHeadersWidth = 62
        Me.DGVFinanceT.RowTemplate.Height = 28
        Me.DGVFinanceT.Size = New System.Drawing.Size(71, 71)
        Me.DGVFinanceT.TabIndex = 36
        Me.DGVFinanceT.Visible = False
        '
        'PBShopping
        '
        Me.PBShopping.BackColor = System.Drawing.Color.White
        Me.PBShopping.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.shoppingbags
        Me.PBShopping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBShopping.Location = New System.Drawing.Point(1740, 253)
        Me.PBShopping.Name = "PBShopping"
        Me.PBShopping.Size = New System.Drawing.Size(56, 56)
        Me.PBShopping.TabIndex = 45
        Me.PBShopping.TabStop = False
        '
        'PBWallet
        '
        Me.PBWallet.BackColor = System.Drawing.Color.White
        Me.PBWallet.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.wallet
        Me.PBWallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBWallet.Location = New System.Drawing.Point(1740, 461)
        Me.PBWallet.Name = "PBWallet"
        Me.PBWallet.Size = New System.Drawing.Size(56, 56)
        Me.PBWallet.TabIndex = 44
        Me.PBWallet.TabStop = False
        '
        'PBCalculator
        '
        Me.PBCalculator.BackColor = System.Drawing.Color.White
        Me.PBCalculator.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.calculator2
        Me.PBCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBCalculator.Location = New System.Drawing.Point(453, 697)
        Me.PBCalculator.Name = "PBCalculator"
        Me.PBCalculator.Size = New System.Drawing.Size(56, 56)
        Me.PBCalculator.TabIndex = 43
        Me.PBCalculator.TabStop = False
        '
        'PBChecklist
        '
        Me.PBChecklist.BackColor = System.Drawing.Color.White
        Me.PBChecklist.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.listingwishlist
        Me.PBChecklist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBChecklist.Location = New System.Drawing.Point(453, 461)
        Me.PBChecklist.Name = "PBChecklist"
        Me.PBChecklist.Size = New System.Drawing.Size(56, 56)
        Me.PBChecklist.TabIndex = 42
        Me.PBChecklist.TabStop = False
        '
        'PBCalendar
        '
        Me.PBCalendar.BackColor = System.Drawing.Color.White
        Me.PBCalendar.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.calendarblue
        Me.PBCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBCalendar.Location = New System.Drawing.Point(453, 253)
        Me.PBCalendar.Name = "PBCalendar"
        Me.PBCalendar.Size = New System.Drawing.Size(56, 56)
        Me.PBCalendar.TabIndex = 41
        Me.PBCalendar.TabStop = False
        '
        'PBCalcTotal
        '
        Me.PBCalcTotal.BackColor = System.Drawing.Color.White
        Me.PBCalcTotal.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.finance__1_
        Me.PBCalcTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBCalcTotal.Location = New System.Drawing.Point(1221, 333)
        Me.PBCalcTotal.Name = "PBCalcTotal"
        Me.PBCalcTotal.Size = New System.Drawing.Size(36, 36)
        Me.PBCalcTotal.TabIndex = 40
        Me.PBCalcTotal.TabStop = False
        '
        'PBTree
        '
        Me.PBTree.BackColor = System.Drawing.Color.Transparent
        Me.PBTree.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.treehomescreen
        Me.PBTree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBTree.Location = New System.Drawing.Point(562, -1)
        Me.PBTree.Name = "PBTree"
        Me.PBTree.Size = New System.Drawing.Size(130, 130)
        Me.PBTree.TabIndex = 39
        Me.PBTree.TabStop = False
        '
        'PBTree2
        '
        Me.PBTree2.BackColor = System.Drawing.Color.Transparent
        Me.PBTree2.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.treehomescreen
        Me.PBTree2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBTree2.Location = New System.Drawing.Point(1203, -1)
        Me.PBTree2.Name = "PBTree2"
        Me.PBTree2.Size = New System.Drawing.Size(130, 130)
        Me.PBTree2.TabIndex = 38
        Me.PBTree2.TabStop = False
        '
        'btnLoadChart
        '
        Me.btnLoadChart.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnLoadChart.BackgroundImage = CType(resources.GetObject("btnLoadChart.BackgroundImage"), System.Drawing.Image)
        Me.btnLoadChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLoadChart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadChart.ForeColor = System.Drawing.Color.DimGray
        Me.btnLoadChart.Location = New System.Drawing.Point(1015, 316)
        Me.btnLoadChart.Name = "btnLoadChart"
        Me.btnLoadChart.Size = New System.Drawing.Size(261, 69)
        Me.btnLoadChart.TabIndex = 12
        Me.btnLoadChart.Text = "   Load Chart"
        Me.btnLoadChart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TTLoadChart.SetToolTip(Me.btnLoadChart, "Select an interval of dates above " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This will output the total expenses in a form" &
        " of a pie chart" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnLoadChart.UseVisualStyleBackColor = False
        '
        'btnBillCalculator
        '
        Me.btnBillCalculator.BackColor = System.Drawing.Color.Transparent
        Me.btnBillCalculator.BackgroundImage = CType(resources.GetObject("btnBillCalculator.BackgroundImage"), System.Drawing.Image)
        Me.btnBillCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBillCalculator.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillCalculator.ForeColor = System.Drawing.Color.DimGray
        Me.btnBillCalculator.Location = New System.Drawing.Point(42, 675)
        Me.btnBillCalculator.Name = "btnBillCalculator"
        Me.btnBillCalculator.Size = New System.Drawing.Size(500, 100)
        Me.btnBillCalculator.TabIndex = 8
        Me.btnBillCalculator.Text = "Bill Calculator"
        Me.TTBillCalculator.SetToolTip(Me.btnBillCalculator, "Calculate weekly, monthly and yearly bills" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calculate monthly and yearly rent/tax" &
        ", using weekly rent/tax" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "View previous bills" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnBillCalculator.UseVisualStyleBackColor = False
        '
        'btnWishlist
        '
        Me.btnWishlist.BackColor = System.Drawing.Color.Transparent
        Me.btnWishlist.BackgroundImage = CType(resources.GetObject("btnWishlist.BackgroundImage"), System.Drawing.Image)
        Me.btnWishlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnWishlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWishlist.ForeColor = System.Drawing.Color.DimGray
        Me.btnWishlist.Location = New System.Drawing.Point(42, 440)
        Me.btnWishlist.Name = "btnWishlist"
        Me.btnWishlist.Size = New System.Drawing.Size(500, 100)
        Me.btnWishlist.TabIndex = 7
        Me.btnWishlist.Text = "Wishlist"
        Me.TTWishlist.SetToolTip(Me.btnWishlist, "Add items to your wishlist " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Print a wishlist" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "View items previously added to you" &
        "r wishlist" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnWishlist.UseVisualStyleBackColor = False
        '
        'btnCalendar
        '
        Me.btnCalendar.BackColor = System.Drawing.Color.Transparent
        Me.btnCalendar.BackgroundImage = CType(resources.GetObject("btnCalendar.BackgroundImage"), System.Drawing.Image)
        Me.btnCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalendar.ForeColor = System.Drawing.Color.DimGray
        Me.btnCalendar.Location = New System.Drawing.Point(42, 232)
        Me.btnCalendar.Name = "btnCalendar"
        Me.btnCalendar.Size = New System.Drawing.Size(500, 100)
        Me.btnCalendar.TabIndex = 6
        Me.btnCalendar.Text = "Calendar"
        Me.TTCalendar.SetToolTip(Me.btnCalendar, "Add a new entry to the calendar. e.g date of when a payment is due")
        Me.btnCalendar.UseVisualStyleBackColor = False
        '
        'btnInvestments
        '
        Me.btnInvestments.BackColor = System.Drawing.Color.Transparent
        Me.btnInvestments.BackgroundImage = CType(resources.GetObject("btnInvestments.BackgroundImage"), System.Drawing.Image)
        Me.btnInvestments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInvestments.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvestments.ForeColor = System.Drawing.Color.DimGray
        Me.btnInvestments.Location = New System.Drawing.Point(1328, 675)
        Me.btnInvestments.Name = "btnInvestments"
        Me.btnInvestments.Size = New System.Drawing.Size(500, 100)
        Me.btnInvestments.TabIndex = 5
        Me.btnInvestments.Text = "Investments"
        Me.TTInvestments.SetToolTip(Me.btnInvestments, "Add, edit, delete investments" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "View investments" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Search for previous investments " &
        "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnInvestments.UseVisualStyleBackColor = False
        '
        'btnBudget
        '
        Me.btnBudget.BackColor = System.Drawing.Color.Transparent
        Me.btnBudget.BackgroundImage = CType(resources.GetObject("btnBudget.BackgroundImage"), System.Drawing.Image)
        Me.btnBudget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBudget.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBudget.ForeColor = System.Drawing.Color.DimGray
        Me.btnBudget.Location = New System.Drawing.Point(1328, 440)
        Me.btnBudget.Name = "btnBudget"
        Me.btnBudget.Size = New System.Drawing.Size(500, 100)
        Me.btnBudget.TabIndex = 4
        Me.btnBudget.Text = "Budgets"
        Me.TTBudgets.SetToolTip(Me.btnBudget, "View previous budgets" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Set a new budget " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Search for a previous budget" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnBudget.UseVisualStyleBackColor = False
        '
        'PBStocks
        '
        Me.PBStocks.BackColor = System.Drawing.Color.White
        Me.PBStocks.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.stocks
        Me.PBStocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBStocks.Location = New System.Drawing.Point(1740, 697)
        Me.PBStocks.Name = "PBStocks"
        Me.PBStocks.Size = New System.Drawing.Size(56, 56)
        Me.PBStocks.TabIndex = 46
        Me.PBStocks.TabStop = False
        '
        'TTCalendar
        '
        Me.TTCalendar.ToolTipTitle = "Calendar"
        '
        'TTWishlist
        '
        Me.TTWishlist.ToolTipTitle = "Wishlist"
        '
        'TTBillCalculator
        '
        Me.TTBillCalculator.ToolTipTitle = "Bill Calculator"
        '
        'TTBudgets
        '
        Me.TTBudgets.ToolTipTitle = "Budgets"
        '
        'TTInvestments
        '
        Me.TTInvestments.ToolTipTitle = "Investments"
        '
        'TTLoadChart
        '
        Me.TTLoadChart.ToolTipTitle = "Load Chart"
        '
        'LblTip
        '
        Me.LblTip.AutoSize = True
        Me.LblTip.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTip.ForeColor = System.Drawing.Color.Azure
        Me.LblTip.Location = New System.Drawing.Point(37, 912)
        Me.LblTip.Name = "LblTip"
        Me.LblTip.Size = New System.Drawing.Size(605, 26)
        Me.LblTip.TabIndex = 47
        Me.LblTip.Text = "Tip: Hover your mouse over a button to see what it does"
        '
        'FormHomescreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1867, 947)
        Me.Controls.Add(Me.LblTip)
        Me.Controls.Add(Me.PBStocks)
        Me.Controls.Add(Me.PBShopping)
        Me.Controls.Add(Me.PBWallet)
        Me.Controls.Add(Me.PBCalculator)
        Me.Controls.Add(Me.PBChecklist)
        Me.Controls.Add(Me.PBCalendar)
        Me.Controls.Add(Me.PBCalcTotal)
        Me.Controls.Add(Me.PBTree)
        Me.Controls.Add(Me.PBTree2)
        Me.Controls.Add(Me.DGVFinanceT)
        Me.Controls.Add(Me.FoodAndDrinkSum)
        Me.Controls.Add(Me.DGVTransactions)
        Me.Controls.Add(Me.Lbl_TotalExpense)
        Me.Controls.Add(Me.Lbl_TotalIncome)
        Me.Controls.Add(Me.ExpenseSum)
        Me.Controls.Add(Me.IncomeSum)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnLoadChart)
        Me.Controls.Add(Me.LblFinanceTracker)
        Me.Controls.Add(Me.ChartExpense)
        Me.Controls.Add(Me.FinancesTracker)
        Me.Controls.Add(Me.btnBillCalculator)
        Me.Controls.Add(Me.btnWishlist)
        Me.Controls.Add(Me.btnCalendar)
        Me.Controls.Add(Me.btnInvestments)
        Me.Controls.Add(Me.btnBudget)
        Me.Controls.Add(Me.btnTransactions)
        Me.Controls.Add(Me.btnSettings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormHomescreen"
        Me.Text = "MoneyTree - Dashboard"
        CType(Me.ChartExpense, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVFinanceT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBShopping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBWallet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCalculator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBChecklist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCalcTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBTree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBTree2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBStocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSettings As Button
    Friend WithEvents TTSettings As ToolTip
    Friend WithEvents btnTransactions As Button
    Friend WithEvents btnBudget As Button
    Friend WithEvents btnInvestments As Button
    Friend WithEvents btnCalendar As Button
    Friend WithEvents btnWishlist As Button
    Friend WithEvents btnBillCalculator As Button
    Friend WithEvents FinancesTracker As ProgressBar
    Friend WithEvents ChartExpense As DataVisualization.Charting.Chart
    Friend WithEvents TTTransactions As ToolTip
    Friend WithEvents LblFinanceTracker As Label
    Friend WithEvents btnLoadChart As Button
    Friend WithEvents DateTimeFirstDate As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblFromDate As Label
    Friend WithEvents Lbl_TotalExpense As Label
    Friend WithEvents Lbl_TotalIncome As Label
    Friend WithEvents ExpenseSum As TextBox
    Friend WithEvents IncomeSum As TextBox
    Friend WithEvents DGVTransactions As DataGridView
    Friend WithEvents FoodAndDrinkSum As TextBox
    Friend WithEvents DateTimeSecondDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVFinanceT As DataGridView
    Friend WithEvents PBTree2 As PictureBox
    Friend WithEvents PBTree As PictureBox
    Friend WithEvents PBCalcTotal As PictureBox
    Friend WithEvents PBCalendar As PictureBox
    Friend WithEvents PBChecklist As PictureBox
    Friend WithEvents PBCalculator As PictureBox
    Friend WithEvents PBWallet As PictureBox
    Friend WithEvents PBShopping As PictureBox
    Friend WithEvents PBStocks As PictureBox
    Friend WithEvents TTBillCalculator As ToolTip
    Friend WithEvents TTWishlist As ToolTip
    Friend WithEvents TTCalendar As ToolTip
    Friend WithEvents TTBudgets As ToolTip
    Friend WithEvents TTLoadChart As ToolTip
    Friend WithEvents TTInvestments As ToolTip
    Friend WithEvents LblTip As Label
End Class
