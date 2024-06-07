<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormWishlist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormWishlist))
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.btnClearWish)
        Me.Panel1.Controls.Add(Me.btnDeleteWish)
        Me.Panel1.Controls.Add(Me.btnEditWish)
        Me.Panel1.Controls.Add(Me.btnSaveWish)
        Me.Panel1.Controls.Add(Me.WishDatePicker)
        Me.Panel1.Controls.Add(Me.LblWishDate)
        Me.Panel1.Controls.Add(Me.TBWishCategory)
        Me.Panel1.Controls.Add(Me.LblWishCategory)
        Me.Panel1.Controls.Add(Me.TBWishAmount)
        Me.Panel1.Controls.Add(Me.LblWishAmount)
        Me.Panel1.Controls.Add(Me.TBWishName)
        Me.Panel1.Controls.Add(Me.LblWishName)
        Me.Panel1.Controls.Add(Me.LblWishID)
        Me.Panel1.Controls.Add(Me.TBWishlistID)
        Me.Panel1.Location = New System.Drawing.Point(60, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(545, 628)
        Me.Panel1.TabIndex = 0
        '
        'btnClearWish
        '
        Me.btnClearWish.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnClearWish.BackgroundImage = CType(resources.GetObject("btnClearWish.BackgroundImage"), System.Drawing.Image)
        Me.btnClearWish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearWish.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearWish.ForeColor = System.Drawing.Color.DimGray
        Me.btnClearWish.Location = New System.Drawing.Point(276, 505)
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
        Me.btnDeleteWish.Location = New System.Drawing.Point(30, 505)
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
        Me.btnEditWish.Location = New System.Drawing.Point(276, 402)
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
        Me.btnSaveWish.Location = New System.Drawing.Point(30, 402)
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
        Me.WishDatePicker.Location = New System.Drawing.Point(191, 321)
        Me.WishDatePicker.Name = "WishDatePicker"
        Me.WishDatePicker.Size = New System.Drawing.Size(333, 35)
        Me.WishDatePicker.TabIndex = 26
        '
        'LblWishDate
        '
        Me.LblWishDate.AutoSize = True
        Me.LblWishDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWishDate.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblWishDate.Location = New System.Drawing.Point(48, 321)
        Me.LblWishDate.Name = "LblWishDate"
        Me.LblWishDate.Size = New System.Drawing.Size(71, 30)
        Me.LblWishDate.TabIndex = 25
        Me.LblWishDate.Text = "Date"
        '
        'TBWishCategory
        '
        Me.TBWishCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBWishCategory.Location = New System.Drawing.Point(189, 255)
        Me.TBWishCategory.Name = "TBWishCategory"
        Me.TBWishCategory.Size = New System.Drawing.Size(335, 41)
        Me.TBWishCategory.TabIndex = 24
        '
        'LblWishCategory
        '
        Me.LblWishCategory.AutoSize = True
        Me.LblWishCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWishCategory.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblWishCategory.Location = New System.Drawing.Point(48, 255)
        Me.LblWishCategory.Name = "LblWishCategory"
        Me.LblWishCategory.Size = New System.Drawing.Size(125, 30)
        Me.LblWishCategory.TabIndex = 23
        Me.LblWishCategory.Text = "Category"
        '
        'TBWishAmount
        '
        Me.TBWishAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBWishAmount.Location = New System.Drawing.Point(189, 182)
        Me.TBWishAmount.Name = "TBWishAmount"
        Me.TBWishAmount.Size = New System.Drawing.Size(157, 41)
        Me.TBWishAmount.TabIndex = 22
        '
        'LblWishAmount
        '
        Me.LblWishAmount.AutoSize = True
        Me.LblWishAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWishAmount.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblWishAmount.Location = New System.Drawing.Point(48, 189)
        Me.LblWishAmount.Name = "LblWishAmount"
        Me.LblWishAmount.Size = New System.Drawing.Size(107, 30)
        Me.LblWishAmount.TabIndex = 21
        Me.LblWishAmount.Text = "Amount"
        '
        'TBWishName
        '
        Me.TBWishName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBWishName.Location = New System.Drawing.Point(189, 116)
        Me.TBWishName.Name = "TBWishName"
        Me.TBWishName.Size = New System.Drawing.Size(335, 41)
        Me.TBWishName.TabIndex = 20
        '
        'LblWishName
        '
        Me.LblWishName.AutoSize = True
        Me.LblWishName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWishName.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblWishName.Location = New System.Drawing.Point(48, 116)
        Me.LblWishName.Name = "LblWishName"
        Me.LblWishName.Size = New System.Drawing.Size(94, 30)
        Me.LblWishName.TabIndex = 2
        Me.LblWishName.Text = "Name "
        '
        'LblWishID
        '
        Me.LblWishID.AutoSize = True
        Me.LblWishID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWishID.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblWishID.Location = New System.Drawing.Point(48, 51)
        Me.LblWishID.Name = "LblWishID"
        Me.LblWishID.Size = New System.Drawing.Size(40, 30)
        Me.LblWishID.TabIndex = 19
        Me.LblWishID.Text = "ID"
        '
        'TBWishlistID
        '
        Me.TBWishlistID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBWishlistID.Location = New System.Drawing.Point(189, 51)
        Me.TBWishlistID.Name = "TBWishlistID"
        Me.TBWishlistID.Size = New System.Drawing.Size(124, 41)
        Me.TBWishlistID.TabIndex = 0
        '
        'FormWishlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1924, 1036)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormWishlist"
        Me.Text = "Wishlist"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TBWishlistID As TextBox
    Friend WithEvents LblWishID As Label
    Friend WithEvents LblWishName As Label
    Friend WithEvents TBWishName As TextBox
    Friend WithEvents TBWishAmount As TextBox
    Friend WithEvents LblWishAmount As Label
    Friend WithEvents TBWishCategory As TextBox
    Friend WithEvents LblWishCategory As Label
    Friend WithEvents LblWishDate As Label
    Friend WithEvents WishDatePicker As DateTimePicker
    Friend WithEvents btnSaveWish As Button
    Friend WithEvents btnEditWish As Button
    Friend WithEvents btnDeleteWish As Button
    Friend WithEvents btnClearWish As Button
End Class
