<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInvestments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInvestments))
        Me.DGVInvestments = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnInvCalculator = New System.Windows.Forms.Button()
        Me.TBProfitLoss = New System.Windows.Forms.TextBox()
        Me.LblPL = New System.Windows.Forms.Label()
        Me.TBPercentageReturn = New System.Windows.Forms.TextBox()
        Me.LblPercentageReturn = New System.Windows.Forms.Label()
        Me.TBDifference = New System.Windows.Forms.TextBox()
        Me.TBCurrentPrice = New System.Windows.Forms.TextBox()
        Me.TBShares = New System.Windows.Forms.TextBox()
        Me.TBInvID = New System.Windows.Forms.TextBox()
        Me.LblInvID = New System.Windows.Forms.Label()
        Me.DateTimeEntryDate = New System.Windows.Forms.DateTimePicker()
        Me.LblDifference = New System.Windows.Forms.Label()
        Me.LblEntryDate = New System.Windows.Forms.Label()
        Me.btnClearInv = New System.Windows.Forms.Button()
        Me.btnDeleteInv = New System.Windows.Forms.Button()
        Me.btnEditInv = New System.Windows.Forms.Button()
        Me.btnSaveInv = New System.Windows.Forms.Button()
        Me.LblCurrentPrice = New System.Windows.Forms.Label()
        Me.LblEntryPrice = New System.Windows.Forms.Label()
        Me.TBEntryPrice = New System.Windows.Forms.TextBox()
        Me.LblShares = New System.Windows.Forms.Label()
        Me.TBSymbol = New System.Windows.Forms.TextBox()
        Me.LblSymbol = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnInvDateSearch = New System.Windows.Forms.Button()
        Me.LblInvDateSearch = New System.Windows.Forms.Label()
        Me.TBInvDateSearch = New System.Windows.Forms.TextBox()
        Me.btnInvSearch = New System.Windows.Forms.Button()
        Me.LblInvSearch = New System.Windows.Forms.Label()
        Me.TBInvSearch = New System.Windows.Forms.TextBox()
        CType(Me.DGVInvestments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVInvestments
        '
        Me.DGVInvestments.BackgroundColor = System.Drawing.Color.Azure
        Me.DGVInvestments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVInvestments.Location = New System.Drawing.Point(819, 179)
        Me.DGVInvestments.Name = "DGVInvestments"
        Me.DGVInvestments.RowHeadersWidth = 62
        Me.DGVInvestments.RowTemplate.Height = 28
        Me.DGVInvestments.Size = New System.Drawing.Size(1064, 814)
        Me.DGVInvestments.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.btnInvCalculator)
        Me.Panel1.Controls.Add(Me.TBProfitLoss)
        Me.Panel1.Controls.Add(Me.LblPL)
        Me.Panel1.Controls.Add(Me.TBPercentageReturn)
        Me.Panel1.Controls.Add(Me.LblPercentageReturn)
        Me.Panel1.Controls.Add(Me.TBDifference)
        Me.Panel1.Controls.Add(Me.TBCurrentPrice)
        Me.Panel1.Controls.Add(Me.TBShares)
        Me.Panel1.Controls.Add(Me.TBInvID)
        Me.Panel1.Controls.Add(Me.LblInvID)
        Me.Panel1.Controls.Add(Me.DateTimeEntryDate)
        Me.Panel1.Controls.Add(Me.LblDifference)
        Me.Panel1.Controls.Add(Me.LblEntryDate)
        Me.Panel1.Controls.Add(Me.btnClearInv)
        Me.Panel1.Controls.Add(Me.btnDeleteInv)
        Me.Panel1.Controls.Add(Me.btnEditInv)
        Me.Panel1.Controls.Add(Me.btnSaveInv)
        Me.Panel1.Controls.Add(Me.LblCurrentPrice)
        Me.Panel1.Controls.Add(Me.LblEntryPrice)
        Me.Panel1.Controls.Add(Me.TBEntryPrice)
        Me.Panel1.Controls.Add(Me.LblShares)
        Me.Panel1.Controls.Add(Me.TBSymbol)
        Me.Panel1.Controls.Add(Me.LblSymbol)
        Me.Panel1.Location = New System.Drawing.Point(49, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(674, 981)
        Me.Panel1.TabIndex = 3
        '
        'btnInvCalculator
        '
        Me.btnInvCalculator.BackColor = System.Drawing.Color.Azure
        Me.btnInvCalculator.BackgroundImage = CType(resources.GetObject("btnInvCalculator.BackgroundImage"), System.Drawing.Image)
        Me.btnInvCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInvCalculator.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvCalculator.ForeColor = System.Drawing.Color.DimGray
        Me.btnInvCalculator.Location = New System.Drawing.Point(418, 379)
        Me.btnInvCalculator.Name = "btnInvCalculator"
        Me.btnInvCalculator.Size = New System.Drawing.Size(220, 66)
        Me.btnInvCalculator.TabIndex = 27
        Me.btnInvCalculator.Text = "Calculator"
        Me.btnInvCalculator.UseVisualStyleBackColor = False
        '
        'TBProfitLoss
        '
        Me.TBProfitLoss.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBProfitLoss.Location = New System.Drawing.Point(27, 913)
        Me.TBProfitLoss.Name = "TBProfitLoss"
        Me.TBProfitLoss.Size = New System.Drawing.Size(333, 35)
        Me.TBProfitLoss.TabIndex = 26
        '
        'LblPL
        '
        Me.LblPL.AutoSize = True
        Me.LblPL.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPL.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblPL.Location = New System.Drawing.Point(22, 862)
        Me.LblPL.Name = "LblPL"
        Me.LblPL.Size = New System.Drawing.Size(137, 30)
        Me.LblPL.TabIndex = 25
        Me.LblPL.Text = "ProfitLoss"
        '
        'TBPercentageReturn
        '
        Me.TBPercentageReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPercentageReturn.Location = New System.Drawing.Point(29, 805)
        Me.TBPercentageReturn.Name = "TBPercentageReturn"
        Me.TBPercentageReturn.Size = New System.Drawing.Size(333, 35)
        Me.TBPercentageReturn.TabIndex = 24
        '
        'LblPercentageReturn
        '
        Me.LblPercentageReturn.AutoSize = True
        Me.LblPercentageReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPercentageReturn.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblPercentageReturn.Location = New System.Drawing.Point(23, 760)
        Me.LblPercentageReturn.Name = "LblPercentageReturn"
        Me.LblPercentageReturn.Size = New System.Drawing.Size(244, 30)
        Me.LblPercentageReturn.TabIndex = 23
        Me.LblPercentageReturn.Text = "Percentage Return"
        '
        'TBDifference
        '
        Me.TBDifference.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDifference.Location = New System.Drawing.Point(27, 705)
        Me.TBDifference.Name = "TBDifference"
        Me.TBDifference.Size = New System.Drawing.Size(333, 35)
        Me.TBDifference.TabIndex = 22
        '
        'TBCurrentPrice
        '
        Me.TBCurrentPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCurrentPrice.Location = New System.Drawing.Point(27, 602)
        Me.TBCurrentPrice.Name = "TBCurrentPrice"
        Me.TBCurrentPrice.Size = New System.Drawing.Size(333, 35)
        Me.TBCurrentPrice.TabIndex = 21
        '
        'TBShares
        '
        Me.TBShares.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBShares.Location = New System.Drawing.Point(29, 497)
        Me.TBShares.Name = "TBShares"
        Me.TBShares.Size = New System.Drawing.Size(333, 35)
        Me.TBShares.TabIndex = 20
        '
        'TBInvID
        '
        Me.TBInvID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBInvID.Location = New System.Drawing.Point(27, 72)
        Me.TBInvID.Name = "TBInvID"
        Me.TBInvID.Size = New System.Drawing.Size(333, 35)
        Me.TBInvID.TabIndex = 19
        '
        'LblInvID
        '
        Me.LblInvID.AutoSize = True
        Me.LblInvID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvID.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblInvID.Location = New System.Drawing.Point(24, 22)
        Me.LblInvID.Name = "LblInvID"
        Me.LblInvID.Size = New System.Drawing.Size(40, 30)
        Me.LblInvID.TabIndex = 18
        Me.LblInvID.Text = "ID"
        '
        'DateTimeEntryDate
        '
        Me.DateTimeEntryDate.CustomFormat = "yyyy-MM-dd"
        Me.DateTimeEntryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeEntryDate.Location = New System.Drawing.Point(29, 287)
        Me.DateTimeEntryDate.Name = "DateTimeEntryDate"
        Me.DateTimeEntryDate.Size = New System.Drawing.Size(333, 35)
        Me.DateTimeEntryDate.TabIndex = 17
        '
        'LblDifference
        '
        Me.LblDifference.AutoSize = True
        Me.LblDifference.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDifference.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblDifference.Location = New System.Drawing.Point(24, 660)
        Me.LblDifference.Name = "LblDifference"
        Me.LblDifference.Size = New System.Drawing.Size(140, 30)
        Me.LblDifference.TabIndex = 15
        Me.LblDifference.Text = "Difference"
        '
        'LblEntryDate
        '
        Me.LblEntryDate.AutoSize = True
        Me.LblEntryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEntryDate.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblEntryDate.Location = New System.Drawing.Point(24, 238)
        Me.LblEntryDate.Name = "LblEntryDate"
        Me.LblEntryDate.Size = New System.Drawing.Size(144, 30)
        Me.LblEntryDate.TabIndex = 13
        Me.LblEntryDate.Text = "Entry Date"
        '
        'btnClearInv
        '
        Me.btnClearInv.BackColor = System.Drawing.Color.Azure
        Me.btnClearInv.BackgroundImage = CType(resources.GetObject("btnClearInv.BackgroundImage"), System.Drawing.Image)
        Me.btnClearInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearInv.ForeColor = System.Drawing.Color.DimGray
        Me.btnClearInv.Location = New System.Drawing.Point(418, 287)
        Me.btnClearInv.Name = "btnClearInv"
        Me.btnClearInv.Size = New System.Drawing.Size(220, 66)
        Me.btnClearInv.TabIndex = 12
        Me.btnClearInv.Text = "Clear"
        Me.btnClearInv.UseVisualStyleBackColor = False
        '
        'btnDeleteInv
        '
        Me.btnDeleteInv.BackColor = System.Drawing.Color.Azure
        Me.btnDeleteInv.BackgroundImage = CType(resources.GetObject("btnDeleteInv.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteInv.ForeColor = System.Drawing.Color.DimGray
        Me.btnDeleteInv.Location = New System.Drawing.Point(418, 202)
        Me.btnDeleteInv.Name = "btnDeleteInv"
        Me.btnDeleteInv.Size = New System.Drawing.Size(220, 66)
        Me.btnDeleteInv.TabIndex = 11
        Me.btnDeleteInv.Text = "Delete"
        Me.btnDeleteInv.UseVisualStyleBackColor = False
        '
        'btnEditInv
        '
        Me.btnEditInv.BackColor = System.Drawing.Color.Azure
        Me.btnEditInv.BackgroundImage = CType(resources.GetObject("btnEditInv.BackgroundImage"), System.Drawing.Image)
        Me.btnEditInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditInv.ForeColor = System.Drawing.Color.DimGray
        Me.btnEditInv.Location = New System.Drawing.Point(418, 118)
        Me.btnEditInv.Name = "btnEditInv"
        Me.btnEditInv.Size = New System.Drawing.Size(220, 66)
        Me.btnEditInv.TabIndex = 10
        Me.btnEditInv.Text = "Edit"
        Me.btnEditInv.UseVisualStyleBackColor = False
        '
        'btnSaveInv
        '
        Me.btnSaveInv.BackColor = System.Drawing.Color.Azure
        Me.btnSaveInv.BackgroundImage = CType(resources.GetObject("btnSaveInv.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveInv.ForeColor = System.Drawing.Color.DimGray
        Me.btnSaveInv.Location = New System.Drawing.Point(418, 41)
        Me.btnSaveInv.Name = "btnSaveInv"
        Me.btnSaveInv.Size = New System.Drawing.Size(220, 66)
        Me.btnSaveInv.TabIndex = 9
        Me.btnSaveInv.Text = "Save"
        Me.btnSaveInv.UseVisualStyleBackColor = False
        '
        'LblCurrentPrice
        '
        Me.LblCurrentPrice.AutoSize = True
        Me.LblCurrentPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurrentPrice.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblCurrentPrice.Location = New System.Drawing.Point(24, 553)
        Me.LblCurrentPrice.Name = "LblCurrentPrice"
        Me.LblCurrentPrice.Size = New System.Drawing.Size(178, 30)
        Me.LblCurrentPrice.TabIndex = 7
        Me.LblCurrentPrice.Text = "Current Price"
        '
        'LblEntryPrice
        '
        Me.LblEntryPrice.AutoSize = True
        Me.LblEntryPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEntryPrice.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblEntryPrice.Location = New System.Drawing.Point(24, 344)
        Me.LblEntryPrice.Name = "LblEntryPrice"
        Me.LblEntryPrice.Size = New System.Drawing.Size(150, 30)
        Me.LblEntryPrice.TabIndex = 5
        Me.LblEntryPrice.Text = "Entry Price"
        '
        'TBEntryPrice
        '
        Me.TBEntryPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBEntryPrice.Location = New System.Drawing.Point(27, 394)
        Me.TBEntryPrice.Name = "TBEntryPrice"
        Me.TBEntryPrice.Size = New System.Drawing.Size(333, 35)
        Me.TBEntryPrice.TabIndex = 4
        '
        'LblShares
        '
        Me.LblShares.AutoSize = True
        Me.LblShares.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShares.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblShares.Location = New System.Drawing.Point(22, 452)
        Me.LblShares.Name = "LblShares"
        Me.LblShares.Size = New System.Drawing.Size(100, 30)
        Me.LblShares.TabIndex = 3
        Me.LblShares.Text = "Shares"
        '
        'TBSymbol
        '
        Me.TBSymbol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBSymbol.Location = New System.Drawing.Point(28, 177)
        Me.TBSymbol.Name = "TBSymbol"
        Me.TBSymbol.Size = New System.Drawing.Size(333, 35)
        Me.TBSymbol.TabIndex = 2
        '
        'LblSymbol
        '
        Me.LblSymbol.AutoSize = True
        Me.LblSymbol.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSymbol.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblSymbol.Location = New System.Drawing.Point(24, 134)
        Me.LblSymbol.Name = "LblSymbol"
        Me.LblSymbol.Size = New System.Drawing.Size(105, 30)
        Me.LblSymbol.TabIndex = 1
        Me.LblSymbol.Text = "Symbol"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnRefresh.BackgroundImage = CType(resources.GetObject("btnRefresh.BackgroundImage"), System.Drawing.Image)
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.DimGray
        Me.btnRefresh.Location = New System.Drawing.Point(1663, 97)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(220, 66)
        Me.btnRefresh.TabIndex = 28
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnInvDateSearch
        '
        Me.btnInvDateSearch.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnInvDateSearch.BackgroundImage = CType(resources.GetObject("btnInvDateSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnInvDateSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInvDateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvDateSearch.ForeColor = System.Drawing.Color.DimGray
        Me.btnInvDateSearch.Location = New System.Drawing.Point(1395, 114)
        Me.btnInvDateSearch.Name = "btnInvDateSearch"
        Me.btnInvDateSearch.Size = New System.Drawing.Size(181, 44)
        Me.btnInvDateSearch.TabIndex = 32
        Me.btnInvDateSearch.Text = "Enter"
        Me.btnInvDateSearch.UseVisualStyleBackColor = False
        '
        'LblInvDateSearch
        '
        Me.LblInvDateSearch.AutoSize = True
        Me.LblInvDateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvDateSearch.ForeColor = System.Drawing.Color.Azure
        Me.LblInvDateSearch.Location = New System.Drawing.Point(819, 119)
        Me.LblInvDateSearch.Name = "LblInvDateSearch"
        Me.LblInvDateSearch.Size = New System.Drawing.Size(239, 30)
        Me.LblInvDateSearch.TabIndex = 33
        Me.LblInvDateSearch.Text = "Entry Date Search"
        '
        'TBInvDateSearch
        '
        Me.TBInvDateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBInvDateSearch.Location = New System.Drawing.Point(1085, 118)
        Me.TBInvDateSearch.Name = "TBInvDateSearch"
        Me.TBInvDateSearch.Size = New System.Drawing.Size(304, 35)
        Me.TBInvDateSearch.TabIndex = 34
        '
        'btnInvSearch
        '
        Me.btnInvSearch.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnInvSearch.BackgroundImage = CType(resources.GetObject("btnInvSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnInvSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInvSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvSearch.ForeColor = System.Drawing.Color.DimGray
        Me.btnInvSearch.Location = New System.Drawing.Point(1395, 64)
        Me.btnInvSearch.Name = "btnInvSearch"
        Me.btnInvSearch.Size = New System.Drawing.Size(181, 44)
        Me.btnInvSearch.TabIndex = 29
        Me.btnInvSearch.Text = "Enter"
        Me.btnInvSearch.UseVisualStyleBackColor = False
        '
        'LblInvSearch
        '
        Me.LblInvSearch.AutoSize = True
        Me.LblInvSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvSearch.ForeColor = System.Drawing.Color.Azure
        Me.LblInvSearch.Location = New System.Drawing.Point(819, 68)
        Me.LblInvSearch.Name = "LblInvSearch"
        Me.LblInvSearch.Size = New System.Drawing.Size(100, 30)
        Me.LblInvSearch.TabIndex = 30
        Me.LblInvSearch.Text = "Search"
        '
        'TBInvSearch
        '
        Me.TBInvSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBInvSearch.Location = New System.Drawing.Point(940, 68)
        Me.TBInvSearch.Name = "TBInvSearch"
        Me.TBInvSearch.Size = New System.Drawing.Size(449, 35)
        Me.TBInvSearch.TabIndex = 31
        '
        'FormInvestments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1924, 1036)
        Me.Controls.Add(Me.btnInvDateSearch)
        Me.Controls.Add(Me.LblInvDateSearch)
        Me.Controls.Add(Me.TBInvDateSearch)
        Me.Controls.Add(Me.btnInvSearch)
        Me.Controls.Add(Me.LblInvSearch)
        Me.Controls.Add(Me.TBInvSearch)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGVInvestments)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormInvestments"
        Me.Text = "Investments"
        CType(Me.DGVInvestments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVInvestments As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TBInvID As TextBox
    Friend WithEvents LblInvID As Label
    Friend WithEvents DateTimeEntryDate As DateTimePicker
    Friend WithEvents LblDifference As Label
    Friend WithEvents LblEntryDate As Label
    Friend WithEvents btnClearInv As Button
    Friend WithEvents btnDeleteInv As Button
    Friend WithEvents btnEditInv As Button
    Friend WithEvents btnSaveInv As Button
    Friend WithEvents LblCurrentPrice As Label
    Friend WithEvents LblEntryPrice As Label
    Friend WithEvents TBEntryPrice As TextBox
    Friend WithEvents LblShares As Label
    Friend WithEvents TBSymbol As TextBox
    Friend WithEvents LblSymbol As Label
    Friend WithEvents TBShares As TextBox
    Friend WithEvents TBCurrentPrice As TextBox
    Friend WithEvents TBProfitLoss As TextBox
    Friend WithEvents LblPL As Label
    Friend WithEvents TBPercentageReturn As TextBox
    Friend WithEvents LblPercentageReturn As Label
    Friend WithEvents TBDifference As TextBox
    Friend WithEvents btnInvCalculator As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnInvDateSearch As Button
    Friend WithEvents LblInvDateSearch As Label
    Friend WithEvents TBInvDateSearch As TextBox
    Friend WithEvents btnInvSearch As Button
    Friend WithEvents LblInvSearch As Label
    Friend WithEvents TBInvSearch As TextBox
End Class
