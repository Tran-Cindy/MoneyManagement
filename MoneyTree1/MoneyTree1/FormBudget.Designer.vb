<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBudget
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBudget))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDeleteBudget = New System.Windows.Forms.Button()
        Me.btnEditBudget = New System.Windows.Forms.Button()
        Me.btnSaveBudget = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBYearly = New System.Windows.Forms.CheckBox()
        Me.CBMonthly = New System.Windows.Forms.CheckBox()
        Me.CBWeekly = New System.Windows.Forms.CheckBox()
        Me.TBBudgetAmount = New System.Windows.Forms.TextBox()
        Me.LblBudgetAmount = New System.Windows.Forms.Label()
        Me.TBBudgetID = New System.Windows.Forms.TextBox()
        Me.LblBudgetID = New System.Windows.Forms.Label()
        Me.DateTimeTodaysDate = New System.Windows.Forms.DateTimePicker()
        Me.TBBudgetTitle = New System.Windows.Forms.TextBox()
        Me.LblBudgetTitle = New System.Windows.Forms.Label()
        Me.LblTodaysDate = New System.Windows.Forms.Label()
        Me.btnBudgetDateSearch = New System.Windows.Forms.Button()
        Me.LblBudgetDateSearch = New System.Windows.Forms.Label()
        Me.TBBudgetDateSearch = New System.Windows.Forms.TextBox()
        Me.btnBudgetSearch = New System.Windows.Forms.Button()
        Me.LblBudgetSearch = New System.Windows.Forms.Label()
        Me.TBBudgetSearch = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DGVBudgets = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnCalcBudget2 = New System.Windows.Forms.Button()
        Me.DateTimeEndPick = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeStartPick = New System.Windows.Forms.DateTimePicker()
        Me.LblEndDate = New System.Windows.Forms.Label()
        Me.LblBudgetStart = New System.Windows.Forms.Label()
        Me.TBAmountSpent = New System.Windows.Forms.TextBox()
        Me.LblAmountSpentFBudget = New System.Windows.Forms.Label()
        Me.TBDisplayAmount = New System.Windows.Forms.TextBox()
        Me.LblBAmount = New System.Windows.Forms.Label()
        Me.btnCalcBudget = New System.Windows.Forms.Button()
        Me.LblBudgetCalc = New System.Windows.Forms.Label()
        Me.IDBudgetTB = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGVBudgets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnDeleteBudget)
        Me.Panel1.Controls.Add(Me.btnEditBudget)
        Me.Panel1.Controls.Add(Me.btnSaveBudget)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.TBBudgetAmount)
        Me.Panel1.Controls.Add(Me.LblBudgetAmount)
        Me.Panel1.Controls.Add(Me.TBBudgetID)
        Me.Panel1.Controls.Add(Me.LblBudgetID)
        Me.Panel1.Controls.Add(Me.DateTimeTodaysDate)
        Me.Panel1.Controls.Add(Me.TBBudgetTitle)
        Me.Panel1.Controls.Add(Me.LblBudgetTitle)
        Me.Panel1.Controls.Add(Me.LblTodaysDate)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(695, 907)
        Me.Panel1.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnClear.BackgroundImage = CType(resources.GetObject("btnClear.BackgroundImage"), System.Drawing.Image)
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.DimGray
        Me.btnClear.Location = New System.Drawing.Point(340, 617)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(255, 66)
        Me.btnClear.TabIndex = 58
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDeleteBudget
        '
        Me.btnDeleteBudget.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnDeleteBudget.BackgroundImage = CType(resources.GetObject("btnDeleteBudget.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteBudget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteBudget.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteBudget.ForeColor = System.Drawing.Color.DimGray
        Me.btnDeleteBudget.Location = New System.Drawing.Point(37, 617)
        Me.btnDeleteBudget.Name = "btnDeleteBudget"
        Me.btnDeleteBudget.Size = New System.Drawing.Size(255, 66)
        Me.btnDeleteBudget.TabIndex = 57
        Me.btnDeleteBudget.Text = "Delete"
        Me.btnDeleteBudget.UseVisualStyleBackColor = False
        '
        'btnEditBudget
        '
        Me.btnEditBudget.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnEditBudget.BackgroundImage = CType(resources.GetObject("btnEditBudget.BackgroundImage"), System.Drawing.Image)
        Me.btnEditBudget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditBudget.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditBudget.ForeColor = System.Drawing.Color.DimGray
        Me.btnEditBudget.Location = New System.Drawing.Point(340, 523)
        Me.btnEditBudget.Name = "btnEditBudget"
        Me.btnEditBudget.Size = New System.Drawing.Size(255, 66)
        Me.btnEditBudget.TabIndex = 56
        Me.btnEditBudget.Text = "Edit"
        Me.btnEditBudget.UseVisualStyleBackColor = False
        '
        'btnSaveBudget
        '
        Me.btnSaveBudget.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSaveBudget.BackgroundImage = CType(resources.GetObject("btnSaveBudget.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveBudget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveBudget.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveBudget.ForeColor = System.Drawing.Color.DimGray
        Me.btnSaveBudget.Location = New System.Drawing.Point(37, 523)
        Me.btnSaveBudget.Name = "btnSaveBudget"
        Me.btnSaveBudget.Size = New System.Drawing.Size(255, 66)
        Me.btnSaveBudget.TabIndex = 55
        Me.btnSaveBudget.Text = "Save"
        Me.btnSaveBudget.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.CBYearly)
        Me.GroupBox1.Controls.Add(Me.CBMonthly)
        Me.GroupBox1.Controls.Add(Me.CBWeekly)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox1.Location = New System.Drawing.Point(37, 367)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(597, 122)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type of budget"
        '
        'CBYearly
        '
        Me.CBYearly.AutoSize = True
        Me.CBYearly.Location = New System.Drawing.Point(392, 49)
        Me.CBYearly.Name = "CBYearly"
        Me.CBYearly.Size = New System.Drawing.Size(107, 30)
        Me.CBYearly.TabIndex = 2
        Me.CBYearly.Text = "Yearly"
        Me.CBYearly.UseVisualStyleBackColor = True
        '
        'CBMonthly
        '
        Me.CBMonthly.AutoSize = True
        Me.CBMonthly.Location = New System.Drawing.Point(203, 49)
        Me.CBMonthly.Name = "CBMonthly"
        Me.CBMonthly.Size = New System.Drawing.Size(121, 30)
        Me.CBMonthly.TabIndex = 1
        Me.CBMonthly.Text = "Monthly"
        Me.CBMonthly.UseVisualStyleBackColor = True
        '
        'CBWeekly
        '
        Me.CBWeekly.AutoSize = True
        Me.CBWeekly.Location = New System.Drawing.Point(14, 49)
        Me.CBWeekly.Name = "CBWeekly"
        Me.CBWeekly.Size = New System.Drawing.Size(116, 30)
        Me.CBWeekly.TabIndex = 0
        Me.CBWeekly.Text = "Weekly"
        Me.CBWeekly.UseVisualStyleBackColor = True
        '
        'TBBudgetAmount
        '
        Me.TBBudgetAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBBudgetAmount.Location = New System.Drawing.Point(240, 282)
        Me.TBBudgetAmount.Name = "TBBudgetAmount"
        Me.TBBudgetAmount.Size = New System.Drawing.Size(394, 35)
        Me.TBBudgetAmount.TabIndex = 30
        '
        'LblBudgetAmount
        '
        Me.LblBudgetAmount.AutoSize = True
        Me.LblBudgetAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBudgetAmount.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblBudgetAmount.Location = New System.Drawing.Point(32, 282)
        Me.LblBudgetAmount.Name = "LblBudgetAmount"
        Me.LblBudgetAmount.Size = New System.Drawing.Size(115, 30)
        Me.LblBudgetAmount.TabIndex = 29
        Me.LblBudgetAmount.Text = "Amount:"
        '
        'TBBudgetID
        '
        Me.TBBudgetID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBBudgetID.Location = New System.Drawing.Point(240, 81)
        Me.TBBudgetID.Name = "TBBudgetID"
        Me.TBBudgetID.Size = New System.Drawing.Size(394, 35)
        Me.TBBudgetID.TabIndex = 28
        '
        'LblBudgetID
        '
        Me.LblBudgetID.AutoSize = True
        Me.LblBudgetID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBudgetID.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblBudgetID.Location = New System.Drawing.Point(32, 81)
        Me.LblBudgetID.Name = "LblBudgetID"
        Me.LblBudgetID.Size = New System.Drawing.Size(142, 30)
        Me.LblBudgetID.TabIndex = 27
        Me.LblBudgetID.Text = "Budget ID:"
        '
        'DateTimeTodaysDate
        '
        Me.DateTimeTodaysDate.CustomFormat = "yyyy-MM-dd"
        Me.DateTimeTodaysDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeTodaysDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeTodaysDate.Location = New System.Drawing.Point(240, 147)
        Me.DateTimeTodaysDate.Name = "DateTimeTodaysDate"
        Me.DateTimeTodaysDate.Size = New System.Drawing.Size(333, 35)
        Me.DateTimeTodaysDate.TabIndex = 26
        '
        'TBBudgetTitle
        '
        Me.TBBudgetTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBBudgetTitle.Location = New System.Drawing.Point(240, 210)
        Me.TBBudgetTitle.Name = "TBBudgetTitle"
        Me.TBBudgetTitle.Size = New System.Drawing.Size(394, 35)
        Me.TBBudgetTitle.TabIndex = 25
        '
        'LblBudgetTitle
        '
        Me.LblBudgetTitle.AutoSize = True
        Me.LblBudgetTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBudgetTitle.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblBudgetTitle.Location = New System.Drawing.Point(32, 210)
        Me.LblBudgetTitle.Name = "LblBudgetTitle"
        Me.LblBudgetTitle.Size = New System.Drawing.Size(75, 30)
        Me.LblBudgetTitle.TabIndex = 20
        Me.LblBudgetTitle.Text = "Title:"
        '
        'LblTodaysDate
        '
        Me.LblTodaysDate.AutoSize = True
        Me.LblTodaysDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTodaysDate.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblTodaysDate.Location = New System.Drawing.Point(32, 147)
        Me.LblTodaysDate.Name = "LblTodaysDate"
        Me.LblTodaysDate.Size = New System.Drawing.Size(178, 30)
        Me.LblTodaysDate.TabIndex = 19
        Me.LblTodaysDate.Text = "Today's date:"
        '
        'btnBudgetDateSearch
        '
        Me.btnBudgetDateSearch.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnBudgetDateSearch.BackgroundImage = CType(resources.GetObject("btnBudgetDateSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnBudgetDateSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBudgetDateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBudgetDateSearch.ForeColor = System.Drawing.Color.DimGray
        Me.btnBudgetDateSearch.Location = New System.Drawing.Point(1402, 80)
        Me.btnBudgetDateSearch.Name = "btnBudgetDateSearch"
        Me.btnBudgetDateSearch.Size = New System.Drawing.Size(181, 44)
        Me.btnBudgetDateSearch.TabIndex = 40
        Me.btnBudgetDateSearch.Text = "Enter"
        Me.btnBudgetDateSearch.UseVisualStyleBackColor = False
        '
        'LblBudgetDateSearch
        '
        Me.LblBudgetDateSearch.AutoSize = True
        Me.LblBudgetDateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBudgetDateSearch.ForeColor = System.Drawing.Color.Azure
        Me.LblBudgetDateSearch.Location = New System.Drawing.Point(826, 85)
        Me.LblBudgetDateSearch.Name = "LblBudgetDateSearch"
        Me.LblBudgetDateSearch.Size = New System.Drawing.Size(166, 30)
        Me.LblBudgetDateSearch.TabIndex = 41
        Me.LblBudgetDateSearch.Text = "Date Search"
        '
        'TBBudgetDateSearch
        '
        Me.TBBudgetDateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBBudgetDateSearch.Location = New System.Drawing.Point(1048, 84)
        Me.TBBudgetDateSearch.Name = "TBBudgetDateSearch"
        Me.TBBudgetDateSearch.Size = New System.Drawing.Size(348, 35)
        Me.TBBudgetDateSearch.TabIndex = 42
        '
        'btnBudgetSearch
        '
        Me.btnBudgetSearch.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnBudgetSearch.BackgroundImage = CType(resources.GetObject("btnBudgetSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnBudgetSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBudgetSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBudgetSearch.ForeColor = System.Drawing.Color.DimGray
        Me.btnBudgetSearch.Location = New System.Drawing.Point(1402, 30)
        Me.btnBudgetSearch.Name = "btnBudgetSearch"
        Me.btnBudgetSearch.Size = New System.Drawing.Size(181, 44)
        Me.btnBudgetSearch.TabIndex = 37
        Me.btnBudgetSearch.Text = "Enter"
        Me.btnBudgetSearch.UseVisualStyleBackColor = False
        '
        'LblBudgetSearch
        '
        Me.LblBudgetSearch.AutoSize = True
        Me.LblBudgetSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBudgetSearch.ForeColor = System.Drawing.Color.Azure
        Me.LblBudgetSearch.Location = New System.Drawing.Point(826, 34)
        Me.LblBudgetSearch.Name = "LblBudgetSearch"
        Me.LblBudgetSearch.Size = New System.Drawing.Size(100, 30)
        Me.LblBudgetSearch.TabIndex = 38
        Me.LblBudgetSearch.Text = "Search"
        '
        'TBBudgetSearch
        '
        Me.TBBudgetSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBBudgetSearch.Location = New System.Drawing.Point(947, 34)
        Me.TBBudgetSearch.Name = "TBBudgetSearch"
        Me.TBBudgetSearch.Size = New System.Drawing.Size(449, 35)
        Me.TBBudgetSearch.TabIndex = 39
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnRefresh.BackgroundImage = CType(resources.GetObject("btnRefresh.BackgroundImage"), System.Drawing.Image)
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.DimGray
        Me.btnRefresh.Location = New System.Drawing.Point(1608, 57)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(220, 66)
        Me.btnRefresh.TabIndex = 36
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(831, 159)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1059, 760)
        Me.TabControl1.TabIndex = 43
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DGVBudgets)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1051, 727)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View Budgets"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DGVBudgets
        '
        Me.DGVBudgets.BackgroundColor = System.Drawing.Color.Azure
        Me.DGVBudgets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBudgets.Location = New System.Drawing.Point(6, 6)
        Me.DGVBudgets.Name = "DGVBudgets"
        Me.DGVBudgets.RowHeadersWidth = 62
        Me.DGVBudgets.RowTemplate.Height = 28
        Me.DGVBudgets.Size = New System.Drawing.Size(1039, 715)
        Me.DGVBudgets.TabIndex = 44
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Azure
        Me.TabPage2.Controls.Add(Me.btnCalcBudget2)
        Me.TabPage2.Controls.Add(Me.DateTimeEndPick)
        Me.TabPage2.Controls.Add(Me.DateTimeStartPick)
        Me.TabPage2.Controls.Add(Me.LblEndDate)
        Me.TabPage2.Controls.Add(Me.LblBudgetStart)
        Me.TabPage2.Controls.Add(Me.TBAmountSpent)
        Me.TabPage2.Controls.Add(Me.LblAmountSpentFBudget)
        Me.TabPage2.Controls.Add(Me.TBDisplayAmount)
        Me.TabPage2.Controls.Add(Me.LblBAmount)
        Me.TabPage2.Controls.Add(Me.btnCalcBudget)
        Me.TabPage2.Controls.Add(Me.LblBudgetCalc)
        Me.TabPage2.Controls.Add(Me.IDBudgetTB)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1051, 727)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "How much spent from budget"
        '
        'btnCalcBudget2
        '
        Me.btnCalcBudget2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnCalcBudget2.BackgroundImage = CType(resources.GetObject("btnCalcBudget2.BackgroundImage"), System.Drawing.Image)
        Me.btnCalcBudget2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalcBudget2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcBudget2.ForeColor = System.Drawing.Color.DimGray
        Me.btnCalcBudget2.Location = New System.Drawing.Point(781, 347)
        Me.btnCalcBudget2.Name = "btnCalcBudget2"
        Me.btnCalcBudget2.Size = New System.Drawing.Size(220, 66)
        Me.btnCalcBudget2.TabIndex = 81
        Me.btnCalcBudget2.Text = "Calculate"
        Me.btnCalcBudget2.UseVisualStyleBackColor = False
        '
        'DateTimeEndPick
        '
        Me.DateTimeEndPick.CustomFormat = "yyyy-MM-dd"
        Me.DateTimeEndPick.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeEndPick.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeEndPick.Location = New System.Drawing.Point(781, 263)
        Me.DateTimeEndPick.Name = "DateTimeEndPick"
        Me.DateTimeEndPick.Size = New System.Drawing.Size(229, 35)
        Me.DateTimeEndPick.TabIndex = 80
        '
        'DateTimeStartPick
        '
        Me.DateTimeStartPick.CustomFormat = "yyyy-MM-dd"
        Me.DateTimeStartPick.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeStartPick.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeStartPick.Location = New System.Drawing.Point(300, 263)
        Me.DateTimeStartPick.Name = "DateTimeStartPick"
        Me.DateTimeStartPick.Size = New System.Drawing.Size(229, 35)
        Me.DateTimeStartPick.TabIndex = 59
        '
        'LblEndDate
        '
        Me.LblEndDate.AutoSize = True
        Me.LblEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEndDate.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblEndDate.Location = New System.Drawing.Point(547, 263)
        Me.LblEndDate.Name = "LblEndDate"
        Me.LblEndDate.Size = New System.Drawing.Size(213, 30)
        Me.LblEndDate.TabIndex = 79
        Me.LblEndDate.Text = "Budget end date"
        '
        'LblBudgetStart
        '
        Me.LblBudgetStart.AutoSize = True
        Me.LblBudgetStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBudgetStart.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblBudgetStart.Location = New System.Drawing.Point(50, 263)
        Me.LblBudgetStart.Name = "LblBudgetStart"
        Me.LblBudgetStart.Size = New System.Drawing.Size(223, 30)
        Me.LblBudgetStart.TabIndex = 77
        Me.LblBudgetStart.Text = "Budget start date"
        '
        'TBAmountSpent
        '
        Me.TBAmountSpent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBAmountSpent.Location = New System.Drawing.Point(415, 362)
        Me.TBAmountSpent.Name = "TBAmountSpent"
        Me.TBAmountSpent.Size = New System.Drawing.Size(333, 35)
        Me.TBAmountSpent.TabIndex = 76
        '
        'LblAmountSpentFBudget
        '
        Me.LblAmountSpentFBudget.AutoSize = True
        Me.LblAmountSpentFBudget.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmountSpentFBudget.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblAmountSpentFBudget.Location = New System.Drawing.Point(50, 362)
        Me.LblAmountSpentFBudget.Name = "LblAmountSpentFBudget"
        Me.LblAmountSpentFBudget.Size = New System.Drawing.Size(337, 30)
        Me.LblAmountSpentFBudget.TabIndex = 75
        Me.LblAmountSpentFBudget.Text = "Amount spent from budget"
        '
        'TBDisplayAmount
        '
        Me.TBDisplayAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDisplayAmount.Location = New System.Drawing.Point(284, 165)
        Me.TBDisplayAmount.Name = "TBDisplayAmount"
        Me.TBDisplayAmount.Size = New System.Drawing.Size(333, 35)
        Me.TBDisplayAmount.TabIndex = 74
        '
        'LblBAmount
        '
        Me.LblBAmount.AutoSize = True
        Me.LblBAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBAmount.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblBAmount.Location = New System.Drawing.Point(50, 170)
        Me.LblBAmount.Name = "LblBAmount"
        Me.LblBAmount.Size = New System.Drawing.Size(201, 30)
        Me.LblBAmount.TabIndex = 73
        Me.LblBAmount.Text = "Budget Amount"
        '
        'btnCalcBudget
        '
        Me.btnCalcBudget.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnCalcBudget.BackgroundImage = CType(resources.GetObject("btnCalcBudget.BackgroundImage"), System.Drawing.Image)
        Me.btnCalcBudget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalcBudget.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcBudget.ForeColor = System.Drawing.Color.DimGray
        Me.btnCalcBudget.Location = New System.Drawing.Point(753, 70)
        Me.btnCalcBudget.Name = "btnCalcBudget"
        Me.btnCalcBudget.Size = New System.Drawing.Size(220, 66)
        Me.btnCalcBudget.TabIndex = 70
        Me.btnCalcBudget.Text = "Find"
        Me.btnCalcBudget.UseVisualStyleBackColor = False
        '
        'LblBudgetCalc
        '
        Me.LblBudgetCalc.AutoSize = True
        Me.LblBudgetCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBudgetCalc.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblBudgetCalc.Location = New System.Drawing.Point(50, 95)
        Me.LblBudgetCalc.Name = "LblBudgetCalc"
        Me.LblBudgetCalc.Size = New System.Drawing.Size(134, 30)
        Me.LblBudgetCalc.TabIndex = 71
        Me.LblBudgetCalc.Text = "Budget ID"
        '
        'IDBudgetTB
        '
        Me.IDBudgetTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDBudgetTB.Location = New System.Drawing.Point(284, 94)
        Me.IDBudgetTB.Name = "IDBudgetTB"
        Me.IDBudgetTB.Size = New System.Drawing.Size(432, 35)
        Me.IDBudgetTB.TabIndex = 72
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DimGray
        Me.Button1.Location = New System.Drawing.Point(1624, 943)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(266, 69)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Access Transactions"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormBudget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1924, 1036)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnBudgetDateSearch)
        Me.Controls.Add(Me.LblBudgetDateSearch)
        Me.Controls.Add(Me.TBBudgetDateSearch)
        Me.Controls.Add(Me.btnBudgetSearch)
        Me.Controls.Add(Me.LblBudgetSearch)
        Me.Controls.Add(Me.TBBudgetSearch)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormBudget"
        Me.Text = "Budgets"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DGVBudgets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTimeTodaysDate As DateTimePicker
    Friend WithEvents TBBudgetTitle As TextBox
    Friend WithEvents LblBudgetTitle As Label
    Friend WithEvents LblTodaysDate As Label
    Friend WithEvents TBBudgetID As TextBox
    Friend WithEvents LblBudgetID As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBYearly As CheckBox
    Friend WithEvents CBMonthly As CheckBox
    Friend WithEvents CBWeekly As CheckBox
    Friend WithEvents TBBudgetAmount As TextBox
    Friend WithEvents LblBudgetAmount As Label
    Friend WithEvents btnBudgetDateSearch As Button
    Friend WithEvents LblBudgetDateSearch As Label
    Friend WithEvents TBBudgetDateSearch As TextBox
    Friend WithEvents btnBudgetSearch As Button
    Friend WithEvents LblBudgetSearch As Label
    Friend WithEvents TBBudgetSearch As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDeleteBudget As Button
    Friend WithEvents btnEditBudget As Button
    Friend WithEvents btnSaveBudget As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DGVBudgets As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnCalcBudget As Button
    Friend WithEvents LblBudgetCalc As Label
    Friend WithEvents IDBudgetTB As TextBox
    Friend WithEvents TBDisplayAmount As TextBox
    Friend WithEvents LblBAmount As Label
    Friend WithEvents LblAmountSpentFBudget As Label
    Friend WithEvents TBAmountSpent As TextBox
    Friend WithEvents DateTimeEndPick As DateTimePicker
    Friend WithEvents DateTimeStartPick As DateTimePicker
    Friend WithEvents LblEndDate As Label
    Friend WithEvents LblBudgetStart As Label
    Friend WithEvents btnCalcBudget2 As Button
    Friend WithEvents Button1 As Button
End Class
