<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransactionsAccess
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
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.DGVTransactionsAccess = New System.Windows.Forms.DataGridView()
        Me.TBTotalExpense = New System.Windows.Forms.TextBox()
        CType(Me.DGVTransactionsAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartDate
        '
        Me.StartDate.CustomFormat = "yyyy-MM-dd"
        Me.StartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDate.Location = New System.Drawing.Point(41, 22)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(229, 35)
        Me.StartDate.TabIndex = 60
        '
        'EndDate
        '
        Me.EndDate.CustomFormat = "yyyy-MM-dd"
        Me.EndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDate.Location = New System.Drawing.Point(322, 22)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(229, 35)
        Me.EndDate.TabIndex = 61
        '
        'DGVTransactionsAccess
        '
        Me.DGVTransactionsAccess.BackgroundColor = System.Drawing.Color.Azure
        Me.DGVTransactionsAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTransactionsAccess.Location = New System.Drawing.Point(41, 100)
        Me.DGVTransactionsAccess.Name = "DGVTransactionsAccess"
        Me.DGVTransactionsAccess.RowHeadersWidth = 62
        Me.DGVTransactionsAccess.RowTemplate.Height = 28
        Me.DGVTransactionsAccess.Size = New System.Drawing.Size(782, 395)
        Me.DGVTransactionsAccess.TabIndex = 62
        '
        'TBTotalExpense
        '
        Me.TBTotalExpense.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBTotalExpense.Location = New System.Drawing.Point(611, 22)
        Me.TBTotalExpense.Name = "TBTotalExpense"
        Me.TBTotalExpense.Size = New System.Drawing.Size(212, 35)
        Me.TBTotalExpense.TabIndex = 75
        '
        'FormTransactionsAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 534)
        Me.Controls.Add(Me.TBTotalExpense)
        Me.Controls.Add(Me.DGVTransactionsAccess)
        Me.Controls.Add(Me.EndDate)
        Me.Controls.Add(Me.StartDate)
        Me.Name = "FormTransactionsAccess"
        Me.Text = "FormTransactionsAccess"
        CType(Me.DGVTransactionsAccess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartDate As DateTimePicker
    Friend WithEvents EndDate As DateTimePicker
    Friend WithEvents DGVTransactionsAccess As DataGridView
    Friend WithEvents TBTotalExpense As TextBox
End Class
