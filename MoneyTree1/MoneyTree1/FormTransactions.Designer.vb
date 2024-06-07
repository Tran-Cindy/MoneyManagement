<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransactions))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TBTransactionsID = New System.Windows.Forms.TextBox()
        Me.LblTransactionsID = New System.Windows.Forms.Label()
        Me.DateTimePickerTDate = New System.Windows.Forms.DateTimePicker()
        Me.CBCurrency = New System.Windows.Forms.ComboBox()
        Me.LblCurrency = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.CBCategory = New System.Windows.Forms.ComboBox()
        Me.LblCategory = New System.Windows.Forms.Label()
        Me.CBIncomeOrExpense = New System.Windows.Forms.ComboBox()
        Me.LblAmount = New System.Windows.Forms.Label()
        Me.TBAmount = New System.Windows.Forms.TextBox()
        Me.LblIncomeOrExpense = New System.Windows.Forms.Label()
        Me.TBName = New System.Windows.Forms.TextBox()
        Me.LblName = New System.Windows.Forms.Label()
        Me.DGVTransactions = New System.Windows.Forms.DataGridView()
        Me.TTDesc = New System.Windows.Forms.ToolTip(Me.components)
        Me.TBSearch = New System.Windows.Forms.TextBox()
        Me.LblSearch = New System.Windows.Forms.Label()
        Me.LblDateSearch = New System.Windows.Forms.Label()
        Me.TBDateSearch = New System.Windows.Forms.TextBox()
        Me.TTSearch = New System.Windows.Forms.ToolTip(Me.components)
        Me.IncomeSum = New System.Windows.Forms.TextBox()
        Me.ExpenseSum = New System.Windows.Forms.TextBox()
        Me.Lbl_TotalIncome = New System.Windows.Forms.Label()
        Me.Lbl_TotalExpense = New System.Windows.Forms.Label()
        Me.PBTreeWithMoney = New System.Windows.Forms.PictureBox()
        Me.PBWateringmoney = New System.Windows.Forms.PictureBox()
        Me.btn_CalculateEI = New System.Windows.Forms.Button()
        Me.btn_DateSearch = New System.Windows.Forms.Button()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.btnShowTable = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClearT = New System.Windows.Forms.Button()
        Me.btnDeleteT = New System.Windows.Forms.Button()
        Me.btnEditT = New System.Windows.Forms.Button()
        Me.btnSaveT = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBTreeWithMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBWateringmoney, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.TBTransactionsID)
        Me.Panel1.Controls.Add(Me.LblTransactionsID)
        Me.Panel1.Controls.Add(Me.DateTimePickerTDate)
        Me.Panel1.Controls.Add(Me.CBCurrency)
        Me.Panel1.Controls.Add(Me.LblCurrency)
        Me.Panel1.Controls.Add(Me.LblDate)
        Me.Panel1.Controls.Add(Me.btnClearT)
        Me.Panel1.Controls.Add(Me.btnDeleteT)
        Me.Panel1.Controls.Add(Me.btnEditT)
        Me.Panel1.Controls.Add(Me.btnSaveT)
        Me.Panel1.Controls.Add(Me.CBCategory)
        Me.Panel1.Controls.Add(Me.LblCategory)
        Me.Panel1.Controls.Add(Me.CBIncomeOrExpense)
        Me.Panel1.Controls.Add(Me.LblAmount)
        Me.Panel1.Controls.Add(Me.TBAmount)
        Me.Panel1.Controls.Add(Me.LblIncomeOrExpense)
        Me.Panel1.Controls.Add(Me.TBName)
        Me.Panel1.Controls.Add(Me.LblName)
        Me.Panel1.Location = New System.Drawing.Point(37, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(674, 865)
        Me.Panel1.TabIndex = 0
        '
        'TBTransactionsID
        '
        Me.TBTransactionsID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBTransactionsID.Location = New System.Drawing.Point(29, 97)
        Me.TBTransactionsID.Name = "TBTransactionsID"
        Me.TBTransactionsID.Size = New System.Drawing.Size(333, 35)
        Me.TBTransactionsID.TabIndex = 19
        '
        'LblTransactionsID
        '
        Me.LblTransactionsID.AutoSize = True
        Me.LblTransactionsID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTransactionsID.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblTransactionsID.Location = New System.Drawing.Point(24, 41)
        Me.LblTransactionsID.Name = "LblTransactionsID"
        Me.LblTransactionsID.Size = New System.Drawing.Size(40, 30)
        Me.LblTransactionsID.TabIndex = 18
        Me.LblTransactionsID.Text = "ID"
        '
        'DateTimePickerTDate
        '
        Me.DateTimePickerTDate.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerTDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerTDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerTDate.Location = New System.Drawing.Point(29, 773)
        Me.DateTimePickerTDate.Name = "DateTimePickerTDate"
        Me.DateTimePickerTDate.Size = New System.Drawing.Size(333, 35)
        Me.DateTimePickerTDate.TabIndex = 17
        '
        'CBCurrency
        '
        Me.CBCurrency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCurrency.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CBCurrency.FormattingEnabled = True
        Me.CBCurrency.Items.AddRange(New Object() {"£", "$"})
        Me.CBCurrency.Location = New System.Drawing.Point(29, 665)
        Me.CBCurrency.Name = "CBCurrency"
        Me.CBCurrency.Size = New System.Drawing.Size(333, 37)
        Me.CBCurrency.TabIndex = 16
        '
        'LblCurrency
        '
        Me.LblCurrency.AutoSize = True
        Me.LblCurrency.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurrency.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblCurrency.Location = New System.Drawing.Point(23, 621)
        Me.LblCurrency.Name = "LblCurrency"
        Me.LblCurrency.Size = New System.Drawing.Size(126, 30)
        Me.LblCurrency.TabIndex = 15
        Me.LblCurrency.Text = "Currency"
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblDate.Location = New System.Drawing.Point(24, 726)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(71, 30)
        Me.LblDate.TabIndex = 13
        Me.LblDate.Text = "Date"
        '
        'CBCategory
        '
        Me.CBCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCategory.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CBCategory.FormattingEnabled = True
        Me.CBCategory.Items.AddRange(New Object() {"Other Income", "Other Expense ", "Beauty", "Clothes", "Entertainment ", "Food & Drink", "Fuel", "Gifts", "Holidays", "Household", "Salary", "Travel", "Electricity bill", "Gas bill", "Water bill", "Mobile bill", "Council tax ", "Rent"})
        Me.CBCategory.Location = New System.Drawing.Point(28, 550)
        Me.CBCategory.Name = "CBCategory"
        Me.CBCategory.Size = New System.Drawing.Size(333, 37)
        Me.CBCategory.TabIndex = 8
        '
        'LblCategory
        '
        Me.LblCategory.AutoSize = True
        Me.LblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCategory.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblCategory.Location = New System.Drawing.Point(24, 502)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(125, 30)
        Me.LblCategory.TabIndex = 7
        Me.LblCategory.Text = "Category"
        '
        'CBIncomeOrExpense
        '
        Me.CBIncomeOrExpense.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBIncomeOrExpense.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CBIncomeOrExpense.FormattingEnabled = True
        Me.CBIncomeOrExpense.Items.AddRange(New Object() {"Income", "Expense"})
        Me.CBIncomeOrExpense.Location = New System.Drawing.Point(28, 438)
        Me.CBIncomeOrExpense.Name = "CBIncomeOrExpense"
        Me.CBIncomeOrExpense.Size = New System.Drawing.Size(333, 37)
        Me.CBIncomeOrExpense.TabIndex = 6
        '
        'LblAmount
        '
        Me.LblAmount.AutoSize = True
        Me.LblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmount.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblAmount.Location = New System.Drawing.Point(23, 285)
        Me.LblAmount.Name = "LblAmount"
        Me.LblAmount.Size = New System.Drawing.Size(107, 30)
        Me.LblAmount.TabIndex = 5
        Me.LblAmount.Text = "Amount"
        '
        'TBAmount
        '
        Me.TBAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBAmount.Location = New System.Drawing.Point(28, 335)
        Me.TBAmount.Name = "TBAmount"
        Me.TBAmount.Size = New System.Drawing.Size(333, 35)
        Me.TBAmount.TabIndex = 4
        '
        'LblIncomeOrExpense
        '
        Me.LblIncomeOrExpense.AutoSize = True
        Me.LblIncomeOrExpense.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIncomeOrExpense.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblIncomeOrExpense.Location = New System.Drawing.Point(22, 389)
        Me.LblIncomeOrExpense.Name = "LblIncomeOrExpense"
        Me.LblIncomeOrExpense.Size = New System.Drawing.Size(215, 30)
        Me.LblIncomeOrExpense.TabIndex = 3
        Me.LblIncomeOrExpense.Text = "Income/Expense"
        '
        'TBName
        '
        Me.TBName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBName.Location = New System.Drawing.Point(28, 223)
        Me.TBName.Name = "TBName"
        Me.TBName.Size = New System.Drawing.Size(333, 35)
        Me.TBName.TabIndex = 2
        Me.TTDesc.SetToolTip(Me.TBName, "Enter a brief description about your income/expense. e.g lunch")
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblName.Location = New System.Drawing.Point(22, 175)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(94, 30)
        Me.LblName.TabIndex = 1
        Me.LblName.Text = "Name "
        '
        'DGVTransactions
        '
        Me.DGVTransactions.BackgroundColor = System.Drawing.Color.Azure
        Me.DGVTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTransactions.Location = New System.Drawing.Point(770, 227)
        Me.DGVTransactions.Name = "DGVTransactions"
        Me.DGVTransactions.RowHeadersWidth = 62
        Me.DGVTransactions.RowTemplate.Height = 28
        Me.DGVTransactions.Size = New System.Drawing.Size(1084, 731)
        Me.DGVTransactions.TabIndex = 1
        '
        'TBSearch
        '
        Me.TBSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBSearch.Location = New System.Drawing.Point(886, 43)
        Me.TBSearch.Name = "TBSearch"
        Me.TBSearch.Size = New System.Drawing.Size(449, 35)
        Me.TBSearch.TabIndex = 20
        Me.TTSearch.SetToolTip(Me.TBSearch, "Find an id, name, category, amount or currency of a transaction" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'LblSearch
        '
        Me.LblSearch.AutoSize = True
        Me.LblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSearch.ForeColor = System.Drawing.Color.Azure
        Me.LblSearch.Location = New System.Drawing.Point(765, 43)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Size = New System.Drawing.Size(100, 30)
        Me.LblSearch.TabIndex = 20
        Me.LblSearch.Text = "Search"
        '
        'LblDateSearch
        '
        Me.LblDateSearch.AutoSize = True
        Me.LblDateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDateSearch.ForeColor = System.Drawing.Color.Azure
        Me.LblDateSearch.Location = New System.Drawing.Point(765, 94)
        Me.LblDateSearch.Name = "LblDateSearch"
        Me.LblDateSearch.Size = New System.Drawing.Size(166, 30)
        Me.LblDateSearch.TabIndex = 22
        Me.LblDateSearch.Text = "Date Search"
        '
        'TBDateSearch
        '
        Me.TBDateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDateSearch.Location = New System.Drawing.Point(958, 93)
        Me.TBDateSearch.Name = "TBDateSearch"
        Me.TBDateSearch.Size = New System.Drawing.Size(377, 35)
        Me.TBDateSearch.TabIndex = 23
        Me.TTSearch.SetToolTip(Me.TBDateSearch, "Find a date of a transaction.")
        '
        'TTSearch
        '
        Me.TTSearch.Tag = ""
        Me.TTSearch.ToolTipTitle = "Search"
        '
        'IncomeSum
        '
        Me.IncomeSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncomeSum.Location = New System.Drawing.Point(988, 145)
        Me.IncomeSum.Name = "IncomeSum"
        Me.IncomeSum.Size = New System.Drawing.Size(103, 35)
        Me.IncomeSum.TabIndex = 24
        Me.TTSearch.SetToolTip(Me.IncomeSum, "Find an id, name, category, amount or currency of a transaction" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'ExpenseSum
        '
        Me.ExpenseSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpenseSum.Location = New System.Drawing.Point(988, 185)
        Me.ExpenseSum.Name = "ExpenseSum"
        Me.ExpenseSum.Size = New System.Drawing.Size(103, 35)
        Me.ExpenseSum.TabIndex = 25
        Me.TTSearch.SetToolTip(Me.ExpenseSum, "Find an id, name, category, amount or currency of a transaction" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Lbl_TotalIncome
        '
        Me.Lbl_TotalIncome.AutoSize = True
        Me.Lbl_TotalIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TotalIncome.ForeColor = System.Drawing.Color.Azure
        Me.Lbl_TotalIncome.Location = New System.Drawing.Point(765, 145)
        Me.Lbl_TotalIncome.Name = "Lbl_TotalIncome"
        Me.Lbl_TotalIncome.Size = New System.Drawing.Size(172, 30)
        Me.Lbl_TotalIncome.TabIndex = 27
        Me.Lbl_TotalIncome.Text = "Total Income"
        '
        'Lbl_TotalExpense
        '
        Me.Lbl_TotalExpense.AutoSize = True
        Me.Lbl_TotalExpense.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TotalExpense.ForeColor = System.Drawing.Color.Azure
        Me.Lbl_TotalExpense.Location = New System.Drawing.Point(765, 186)
        Me.Lbl_TotalExpense.Name = "Lbl_TotalExpense"
        Me.Lbl_TotalExpense.Size = New System.Drawing.Size(188, 30)
        Me.Lbl_TotalExpense.TabIndex = 28
        Me.Lbl_TotalExpense.Text = "Total Expense"
        '
        'PBTreeWithMoney
        '
        Me.PBTreeWithMoney.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.treetransactions
        Me.PBTreeWithMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBTreeWithMoney.Location = New System.Drawing.Point(1710, 93)
        Me.PBTreeWithMoney.Name = "PBTreeWithMoney"
        Me.PBTreeWithMoney.Size = New System.Drawing.Size(144, 131)
        Me.PBTreeWithMoney.TabIndex = 30
        Me.PBTreeWithMoney.TabStop = False
        '
        'PBWateringmoney
        '
        Me.PBWateringmoney.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.wateringmoneytree
        Me.PBWateringmoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBWateringmoney.Location = New System.Drawing.Point(1560, 94)
        Me.PBWateringmoney.Name = "PBWateringmoney"
        Me.PBWateringmoney.Size = New System.Drawing.Size(144, 131)
        Me.PBWateringmoney.TabIndex = 29
        Me.PBWateringmoney.TabStop = False
        '
        'btn_CalculateEI
        '
        Me.btn_CalculateEI.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_CalculateEI.BackgroundImage = CType(resources.GetObject("btn_CalculateEI.BackgroundImage"), System.Drawing.Image)
        Me.btn_CalculateEI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_CalculateEI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CalculateEI.ForeColor = System.Drawing.Color.DimGray
        Me.btn_CalculateEI.Location = New System.Drawing.Point(1127, 156)
        Me.btn_CalculateEI.Name = "btn_CalculateEI"
        Me.btn_CalculateEI.Size = New System.Drawing.Size(154, 44)
        Me.btn_CalculateEI.TabIndex = 26
        Me.btn_CalculateEI.Text = "Calculate"
        Me.btn_CalculateEI.UseVisualStyleBackColor = False
        '
        'btn_DateSearch
        '
        Me.btn_DateSearch.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_DateSearch.BackgroundImage = CType(resources.GetObject("btn_DateSearch.BackgroundImage"), System.Drawing.Image)
        Me.btn_DateSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_DateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DateSearch.ForeColor = System.Drawing.Color.DimGray
        Me.btn_DateSearch.Location = New System.Drawing.Point(1341, 89)
        Me.btn_DateSearch.Name = "btn_DateSearch"
        Me.btn_DateSearch.Size = New System.Drawing.Size(181, 44)
        Me.btn_DateSearch.TabIndex = 21
        Me.btn_DateSearch.Text = "Enter"
        Me.btn_DateSearch.UseVisualStyleBackColor = False
        '
        'btn_Search
        '
        Me.btn_Search.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_Search.BackgroundImage = CType(resources.GetObject("btn_Search.BackgroundImage"), System.Drawing.Image)
        Me.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.ForeColor = System.Drawing.Color.DimGray
        Me.btn_Search.Location = New System.Drawing.Point(1341, 39)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(181, 44)
        Me.btn_Search.TabIndex = 20
        Me.btn_Search.Text = "Enter"
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'btnShowTable
        '
        Me.btnShowTable.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnShowTable.BackgroundImage = CType(resources.GetObject("btnShowTable.BackgroundImage"), System.Drawing.Image)
        Me.btnShowTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShowTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowTable.ForeColor = System.Drawing.Color.DimGray
        Me.btnShowTable.Location = New System.Drawing.Point(1634, 21)
        Me.btnShowTable.Name = "btnShowTable"
        Me.btnShowTable.Size = New System.Drawing.Size(220, 66)
        Me.btnShowTable.TabIndex = 20
        Me.btnShowTable.Text = "Show Table"
        Me.btnShowTable.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DimGray
        Me.Button4.Location = New System.Drawing.Point(37, 26)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(191, 47)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Check connection"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.piggy_bank
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(544, 752)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 100)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'btnClearT
        '
        Me.btnClearT.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnClearT.BackgroundImage = CType(resources.GetObject("btnClearT.BackgroundImage"), System.Drawing.Image)
        Me.btnClearT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearT.ForeColor = System.Drawing.Color.DimGray
        Me.btnClearT.Location = New System.Drawing.Point(418, 287)
        Me.btnClearT.Name = "btnClearT"
        Me.btnClearT.Size = New System.Drawing.Size(220, 66)
        Me.btnClearT.TabIndex = 12
        Me.btnClearT.Text = "Clear"
        Me.btnClearT.UseVisualStyleBackColor = False
        '
        'btnDeleteT
        '
        Me.btnDeleteT.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnDeleteT.BackgroundImage = CType(resources.GetObject("btnDeleteT.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteT.ForeColor = System.Drawing.Color.DimGray
        Me.btnDeleteT.Location = New System.Drawing.Point(418, 202)
        Me.btnDeleteT.Name = "btnDeleteT"
        Me.btnDeleteT.Size = New System.Drawing.Size(220, 66)
        Me.btnDeleteT.TabIndex = 11
        Me.btnDeleteT.Text = "Delete"
        Me.btnDeleteT.UseVisualStyleBackColor = False
        '
        'btnEditT
        '
        Me.btnEditT.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnEditT.BackgroundImage = CType(resources.GetObject("btnEditT.BackgroundImage"), System.Drawing.Image)
        Me.btnEditT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditT.ForeColor = System.Drawing.Color.DimGray
        Me.btnEditT.Location = New System.Drawing.Point(418, 118)
        Me.btnEditT.Name = "btnEditT"
        Me.btnEditT.Size = New System.Drawing.Size(220, 66)
        Me.btnEditT.TabIndex = 10
        Me.btnEditT.Text = "Edit"
        Me.btnEditT.UseVisualStyleBackColor = False
        '
        'btnSaveT
        '
        Me.btnSaveT.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSaveT.BackgroundImage = CType(resources.GetObject("btnSaveT.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveT.ForeColor = System.Drawing.Color.DimGray
        Me.btnSaveT.Location = New System.Drawing.Point(418, 41)
        Me.btnSaveT.Name = "btnSaveT"
        Me.btnSaveT.Size = New System.Drawing.Size(220, 66)
        Me.btnSaveT.TabIndex = 9
        Me.btnSaveT.Text = "Save"
        Me.btnSaveT.UseVisualStyleBackColor = False
        '
        'FormTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1924, 1036)
        Me.Controls.Add(Me.PBTreeWithMoney)
        Me.Controls.Add(Me.PBWateringmoney)
        Me.Controls.Add(Me.Lbl_TotalExpense)
        Me.Controls.Add(Me.Lbl_TotalIncome)
        Me.Controls.Add(Me.btn_CalculateEI)
        Me.Controls.Add(Me.ExpenseSum)
        Me.Controls.Add(Me.IncomeSum)
        Me.Controls.Add(Me.btn_DateSearch)
        Me.Controls.Add(Me.LblDateSearch)
        Me.Controls.Add(Me.TBDateSearch)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.LblSearch)
        Me.Controls.Add(Me.TBSearch)
        Me.Controls.Add(Me.btnShowTable)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DGVTransactions)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTransactions"
        Me.Text = "Transactions"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBTreeWithMoney, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBWateringmoney, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblName As Label
    Friend WithEvents TBName As TextBox
    Friend WithEvents TBAmount As TextBox
    Friend WithEvents LblIncomeOrExpense As Label
    Friend WithEvents LblAmount As Label
    Friend WithEvents CBIncomeOrExpense As ComboBox
    Friend WithEvents CBCategory As ComboBox
    Friend WithEvents LblCategory As Label
    Friend WithEvents btnClearT As Button
    Friend WithEvents btnDeleteT As Button
    Friend WithEvents btnEditT As Button
    Friend WithEvents btnSaveT As Button
    Friend WithEvents DGVTransactions As DataGridView
    Friend WithEvents CBCurrency As ComboBox
    Friend WithEvents LblCurrency As Label
    Friend WithEvents LblDate As Label
    Friend WithEvents TTDesc As ToolTip
    Friend WithEvents DateTimePickerTDate As DateTimePicker
    Friend WithEvents Button4 As Button
    Friend WithEvents LblTransactionsID As Label
    Friend WithEvents TBTransactionsID As TextBox
    Friend WithEvents btnShowTable As Button
    Friend WithEvents TBSearch As TextBox
    Friend WithEvents LblSearch As Label
    Friend WithEvents btn_Search As Button
    Friend WithEvents btn_DateSearch As Button
    Friend WithEvents LblDateSearch As Label
    Friend WithEvents TBDateSearch As TextBox
    Friend WithEvents TTSearch As ToolTip
    Friend WithEvents IncomeSum As TextBox
    Friend WithEvents ExpenseSum As TextBox
    Friend WithEvents btn_CalculateEI As Button
    Friend WithEvents Lbl_TotalIncome As Label
    Friend WithEvents Lbl_TotalExpense As Label
    Friend WithEvents PBWateringmoney As PictureBox
    Friend WithEvents PBTreeWithMoney As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
