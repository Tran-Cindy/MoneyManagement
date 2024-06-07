<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormWishlist2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormWishlist2))
        Me.btnClearWish = New System.Windows.Forms.Button()
        Me.btnDeleteWish = New System.Windows.Forms.Button()
        Me.btnEditWish = New System.Windows.Forms.Button()
        Me.btnSaveWish = New System.Windows.Forms.Button()
        Me.WishDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.LblWishDate = New System.Windows.Forms.Label()
        Me.TBWishCategory = New System.Windows.Forms.TextBox()
        Me.LblWishCategory = New System.Windows.Forms.Label()
        Me.TBWishAmount = New System.Windows.Forms.TextBox()
        Me.LblWishAmount = New System.Windows.Forms.Label()
        Me.TBWishName = New System.Windows.Forms.TextBox()
        Me.LblWishName = New System.Windows.Forms.Label()
        Me.LblWishID = New System.Windows.Forms.Label()
        Me.TBWishlistID = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.LblList = New System.Windows.Forms.Label()
        Me.TBList = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblAddToList = New System.Windows.Forms.Label()
        Me.InputItem = New System.Windows.Forms.TextBox()
        Me.btnWishDateSearch = New System.Windows.Forms.Button()
        Me.LblWishDateSearch = New System.Windows.Forms.Label()
        Me.TBWishDateSearch = New System.Windows.Forms.TextBox()
        Me.btnWishSearch = New System.Windows.Forms.Button()
        Me.LblWishSearch = New System.Windows.Forms.Label()
        Me.TBWishSearch = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.DGVWishlist = New System.Windows.Forms.DataGridView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGVWishlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClearWish
        '
        Me.btnClearWish.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnClearWish.BackgroundImage = CType(resources.GetObject("btnClearWish.BackgroundImage"), System.Drawing.Image)
        Me.btnClearWish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearWish.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearWish.ForeColor = System.Drawing.Color.DimGray
        Me.btnClearWish.Location = New System.Drawing.Point(325, 598)
        Me.btnClearWish.Name = "btnClearWish"
        Me.btnClearWish.Size = New System.Drawing.Size(220, 66)
        Me.btnClearWish.TabIndex = 30
        Me.btnClearWish.Text = "Clear"
        Me.btnClearWish.UseVisualStyleBackColor = False
        '
        'btnDeleteWish
        '
        Me.btnDeleteWish.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnDeleteWish.BackgroundImage = CType(resources.GetObject("btnDeleteWish.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteWish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteWish.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteWish.ForeColor = System.Drawing.Color.DimGray
        Me.btnDeleteWish.Location = New System.Drawing.Point(79, 598)
        Me.btnDeleteWish.Name = "btnDeleteWish"
        Me.btnDeleteWish.Size = New System.Drawing.Size(220, 66)
        Me.btnDeleteWish.TabIndex = 29
        Me.btnDeleteWish.Text = "Delete"
        Me.btnDeleteWish.UseVisualStyleBackColor = False
        '
        'btnEditWish
        '
        Me.btnEditWish.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnEditWish.BackgroundImage = CType(resources.GetObject("btnEditWish.BackgroundImage"), System.Drawing.Image)
        Me.btnEditWish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditWish.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditWish.ForeColor = System.Drawing.Color.DimGray
        Me.btnEditWish.Location = New System.Drawing.Point(325, 495)
        Me.btnEditWish.Name = "btnEditWish"
        Me.btnEditWish.Size = New System.Drawing.Size(220, 66)
        Me.btnEditWish.TabIndex = 28
        Me.btnEditWish.Text = "Edit"
        Me.btnEditWish.UseVisualStyleBackColor = False
        '
        'btnSaveWish
        '
        Me.btnSaveWish.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSaveWish.BackgroundImage = CType(resources.GetObject("btnSaveWish.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveWish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveWish.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveWish.ForeColor = System.Drawing.Color.DimGray
        Me.btnSaveWish.Location = New System.Drawing.Point(79, 495)
        Me.btnSaveWish.Name = "btnSaveWish"
        Me.btnSaveWish.Size = New System.Drawing.Size(220, 66)
        Me.btnSaveWish.TabIndex = 27
        Me.btnSaveWish.Text = "Save"
        Me.btnSaveWish.UseVisualStyleBackColor = False
        '
        'WishDatePicker
        '
        Me.WishDatePicker.CustomFormat = "yyyy-MM-dd"
        Me.WishDatePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WishDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.WishDatePicker.Location = New System.Drawing.Point(212, 406)
        Me.WishDatePicker.Name = "WishDatePicker"
        Me.WishDatePicker.Size = New System.Drawing.Size(333, 35)
        Me.WishDatePicker.TabIndex = 26
        '
        'LblWishDate
        '
        Me.LblWishDate.AutoSize = True
        Me.LblWishDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWishDate.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblWishDate.Location = New System.Drawing.Point(69, 406)
        Me.LblWishDate.Name = "LblWishDate"
        Me.LblWishDate.Size = New System.Drawing.Size(71, 30)
        Me.LblWishDate.TabIndex = 25
        Me.LblWishDate.Text = "Date"
        '
        'TBWishCategory
        '
        Me.TBWishCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBWishCategory.Location = New System.Drawing.Point(210, 340)
        Me.TBWishCategory.Name = "TBWishCategory"
        Me.TBWishCategory.Size = New System.Drawing.Size(335, 41)
        Me.TBWishCategory.TabIndex = 24
        '
        'LblWishCategory
        '
        Me.LblWishCategory.AutoSize = True
        Me.LblWishCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWishCategory.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblWishCategory.Location = New System.Drawing.Point(69, 340)
        Me.LblWishCategory.Name = "LblWishCategory"
        Me.LblWishCategory.Size = New System.Drawing.Size(125, 30)
        Me.LblWishCategory.TabIndex = 23
        Me.LblWishCategory.Text = "Category"
        '
        'TBWishAmount
        '
        Me.TBWishAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBWishAmount.Location = New System.Drawing.Point(210, 267)
        Me.TBWishAmount.Name = "TBWishAmount"
        Me.TBWishAmount.Size = New System.Drawing.Size(157, 41)
        Me.TBWishAmount.TabIndex = 22
        '
        'LblWishAmount
        '
        Me.LblWishAmount.AutoSize = True
        Me.LblWishAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWishAmount.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblWishAmount.Location = New System.Drawing.Point(69, 274)
        Me.LblWishAmount.Name = "LblWishAmount"
        Me.LblWishAmount.Size = New System.Drawing.Size(107, 30)
        Me.LblWishAmount.TabIndex = 21
        Me.LblWishAmount.Text = "Amount"
        '
        'TBWishName
        '
        Me.TBWishName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBWishName.Location = New System.Drawing.Point(210, 118)
        Me.TBWishName.Multiline = True
        Me.TBWishName.Name = "TBWishName"
        Me.TBWishName.Size = New System.Drawing.Size(335, 125)
        Me.TBWishName.TabIndex = 20
        '
        'LblWishName
        '
        Me.LblWishName.AutoSize = True
        Me.LblWishName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWishName.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblWishName.Location = New System.Drawing.Point(69, 118)
        Me.LblWishName.Name = "LblWishName"
        Me.LblWishName.Size = New System.Drawing.Size(66, 30)
        Me.LblWishName.TabIndex = 2
        Me.LblWishName.Text = "Item"
        '
        'LblWishID
        '
        Me.LblWishID.AutoSize = True
        Me.LblWishID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWishID.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblWishID.Location = New System.Drawing.Point(69, 53)
        Me.LblWishID.Name = "LblWishID"
        Me.LblWishID.Size = New System.Drawing.Size(40, 30)
        Me.LblWishID.TabIndex = 19
        Me.LblWishID.Text = "ID"
        '
        'TBWishlistID
        '
        Me.TBWishlistID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBWishlistID.Location = New System.Drawing.Point(210, 53)
        Me.TBWishlistID.Name = "TBWishlistID"
        Me.TBWishlistID.Size = New System.Drawing.Size(124, 41)
        Me.TBWishlistID.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(45, 46)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(659, 931)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Azure
        Me.TabPage1.Controls.Add(Me.LblWishID)
        Me.TabPage1.Controls.Add(Me.btnEditWish)
        Me.TabPage1.Controls.Add(Me.btnClearWish)
        Me.TabPage1.Controls.Add(Me.TBWishlistID)
        Me.TabPage1.Controls.Add(Me.btnDeleteWish)
        Me.TabPage1.Controls.Add(Me.LblWishName)
        Me.TabPage1.Controls.Add(Me.TBWishName)
        Me.TabPage1.Controls.Add(Me.btnSaveWish)
        Me.TabPage1.Controls.Add(Me.LblWishAmount)
        Me.TabPage1.Controls.Add(Me.WishDatePicker)
        Me.TabPage1.Controls.Add(Me.TBWishAmount)
        Me.TabPage1.Controls.Add(Me.LblWishDate)
        Me.TabPage1.Controls.Add(Me.LblWishCategory)
        Me.TabPage1.Controls.Add(Me.TBWishCategory)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(651, 898)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Input Data"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Azure
        Me.TabPage2.Controls.Add(Me.btnClear)
        Me.TabPage2.Controls.Add(Me.btnAddItem)
        Me.TabPage2.Controls.Add(Me.btnPrint)
        Me.TabPage2.Controls.Add(Me.LblList)
        Me.TabPage2.Controls.Add(Me.TBList)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.LblAddToList)
        Me.TabPage2.Controls.Add(Me.InputItem)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(651, 898)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Print"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BackgroundImage = CType(resources.GetObject("btnClear.BackgroundImage"), System.Drawing.Image)
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.DimGray
        Me.btnClear.Location = New System.Drawing.Point(147, 776)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(470, 66)
        Me.btnClear.TabIndex = 47
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAddItem.BackgroundImage = CType(resources.GetObject("btnAddItem.BackgroundImage"), System.Drawing.Image)
        Me.btnAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.ForeColor = System.Drawing.Color.DimGray
        Me.btnAddItem.Location = New System.Drawing.Point(397, 675)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(220, 66)
        Me.btnAddItem.TabIndex = 46
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.BackgroundImage = CType(resources.GetObject("btnPrint.BackgroundImage"), System.Drawing.Image)
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.DimGray
        Me.btnPrint.Location = New System.Drawing.Point(147, 675)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(220, 66)
        Me.btnPrint.TabIndex = 43
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'LblList
        '
        Me.LblList.AutoSize = True
        Me.LblList.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblList.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblList.Location = New System.Drawing.Point(30, 211)
        Me.LblList.Name = "LblList"
        Me.LblList.Size = New System.Drawing.Size(65, 30)
        Me.LblList.TabIndex = 43
        Me.LblList.Text = "List:"
        '
        'TBList
        '
        Me.TBList.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBList.Location = New System.Drawing.Point(147, 217)
        Me.TBList.Multiline = True
        Me.TBList.Name = "TBList"
        Me.TBList.Size = New System.Drawing.Size(470, 422)
        Me.TBList.TabIndex = 45
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Location = New System.Drawing.Point(23, 150)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 10)
        Me.Panel1.TabIndex = 44
        '
        'LblAddToList
        '
        Me.LblAddToList.AutoSize = True
        Me.LblAddToList.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAddToList.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblAddToList.Location = New System.Drawing.Point(6, 35)
        Me.LblAddToList.Name = "LblAddToList"
        Me.LblAddToList.Size = New System.Drawing.Size(599, 30)
        Me.LblAddToList.TabIndex = 43
        Me.LblAddToList.Text = "Type in an item you would like to add to the list:"
        '
        'InputItem
        '
        Me.InputItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputItem.Location = New System.Drawing.Point(23, 88)
        Me.InputItem.Name = "InputItem"
        Me.InputItem.Size = New System.Drawing.Size(594, 35)
        Me.InputItem.TabIndex = 43
        '
        'btnWishDateSearch
        '
        Me.btnWishDateSearch.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnWishDateSearch.BackgroundImage = CType(resources.GetObject("btnWishDateSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnWishDateSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnWishDateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWishDateSearch.ForeColor = System.Drawing.Color.DimGray
        Me.btnWishDateSearch.Location = New System.Drawing.Point(1376, 96)
        Me.btnWishDateSearch.Name = "btnWishDateSearch"
        Me.btnWishDateSearch.Size = New System.Drawing.Size(181, 44)
        Me.btnWishDateSearch.TabIndex = 40
        Me.btnWishDateSearch.Text = "Enter"
        Me.btnWishDateSearch.UseVisualStyleBackColor = False
        '
        'LblWishDateSearch
        '
        Me.LblWishDateSearch.AutoSize = True
        Me.LblWishDateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWishDateSearch.ForeColor = System.Drawing.Color.Azure
        Me.LblWishDateSearch.Location = New System.Drawing.Point(800, 101)
        Me.LblWishDateSearch.Name = "LblWishDateSearch"
        Me.LblWishDateSearch.Size = New System.Drawing.Size(166, 30)
        Me.LblWishDateSearch.TabIndex = 41
        Me.LblWishDateSearch.Text = "Date Search"
        '
        'TBWishDateSearch
        '
        Me.TBWishDateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBWishDateSearch.Location = New System.Drawing.Point(997, 100)
        Me.TBWishDateSearch.Name = "TBWishDateSearch"
        Me.TBWishDateSearch.Size = New System.Drawing.Size(373, 35)
        Me.TBWishDateSearch.TabIndex = 42
        '
        'btnWishSearch
        '
        Me.btnWishSearch.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnWishSearch.BackgroundImage = CType(resources.GetObject("btnWishSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnWishSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnWishSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWishSearch.ForeColor = System.Drawing.Color.DimGray
        Me.btnWishSearch.Location = New System.Drawing.Point(1376, 46)
        Me.btnWishSearch.Name = "btnWishSearch"
        Me.btnWishSearch.Size = New System.Drawing.Size(181, 44)
        Me.btnWishSearch.TabIndex = 37
        Me.btnWishSearch.Text = "Enter"
        Me.btnWishSearch.UseVisualStyleBackColor = False
        '
        'LblWishSearch
        '
        Me.LblWishSearch.AutoSize = True
        Me.LblWishSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWishSearch.ForeColor = System.Drawing.Color.Azure
        Me.LblWishSearch.Location = New System.Drawing.Point(800, 50)
        Me.LblWishSearch.Name = "LblWishSearch"
        Me.LblWishSearch.Size = New System.Drawing.Size(100, 30)
        Me.LblWishSearch.TabIndex = 38
        Me.LblWishSearch.Text = "Search"
        '
        'TBWishSearch
        '
        Me.TBWishSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBWishSearch.Location = New System.Drawing.Point(921, 50)
        Me.TBWishSearch.Name = "TBWishSearch"
        Me.TBWishSearch.Size = New System.Drawing.Size(449, 35)
        Me.TBWishSearch.TabIndex = 39
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnRefresh.BackgroundImage = CType(resources.GetObject("btnRefresh.BackgroundImage"), System.Drawing.Image)
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.DimGray
        Me.btnRefresh.Location = New System.Drawing.Point(1645, 81)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(220, 66)
        Me.btnRefresh.TabIndex = 36
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'DGVWishlist
        '
        Me.DGVWishlist.BackgroundColor = System.Drawing.Color.Azure
        Me.DGVWishlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVWishlist.Location = New System.Drawing.Point(801, 163)
        Me.DGVWishlist.Name = "DGVWishlist"
        Me.DGVWishlist.RowHeadersWidth = 62
        Me.DGVWishlist.RowTemplate.Height = 28
        Me.DGVWishlist.Size = New System.Drawing.Size(1064, 814)
        Me.DGVWishlist.TabIndex = 35
        '
        'PrintDocument1
        '
        '
        'FormWishlist2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1924, 1036)
        Me.Controls.Add(Me.btnWishDateSearch)
        Me.Controls.Add(Me.LblWishDateSearch)
        Me.Controls.Add(Me.TBWishDateSearch)
        Me.Controls.Add(Me.btnWishSearch)
        Me.Controls.Add(Me.LblWishSearch)
        Me.Controls.Add(Me.TBWishSearch)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DGVWishlist)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormWishlist2"
        Me.Text = "Wishlist"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DGVWishlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClearWish As Button
    Friend WithEvents btnDeleteWish As Button
    Friend WithEvents btnEditWish As Button
    Friend WithEvents btnSaveWish As Button
    Friend WithEvents WishDatePicker As DateTimePicker
    Friend WithEvents LblWishDate As Label
    Friend WithEvents TBWishCategory As TextBox
    Friend WithEvents LblWishCategory As Label
    Friend WithEvents TBWishAmount As TextBox
    Friend WithEvents LblWishAmount As Label
    Friend WithEvents TBWishName As TextBox
    Friend WithEvents LblWishName As Label
    Friend WithEvents LblWishID As Label
    Friend WithEvents TBWishlistID As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnWishDateSearch As Button
    Friend WithEvents LblWishDateSearch As Label
    Friend WithEvents TBWishDateSearch As TextBox
    Friend WithEvents btnWishSearch As Button
    Friend WithEvents LblWishSearch As Label
    Friend WithEvents TBWishSearch As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents DGVWishlist As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblAddToList As Label
    Friend WithEvents InputItem As TextBox
    Friend WithEvents LblList As Label
    Friend WithEvents TBList As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
