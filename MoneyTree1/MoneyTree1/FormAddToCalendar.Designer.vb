<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddToCalendar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddToCalendar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePickerCalendar = New System.Windows.Forms.DateTimePicker()
        Me.TBTitle = New System.Windows.Forms.TextBox()
        Me.TBDesc = New System.Windows.Forms.TextBox()
        Me.LblEntryDesc = New System.Windows.Forms.Label()
        Me.LblEntryTitle = New System.Windows.Forms.Label()
        Me.LblEntryDate = New System.Windows.Forms.Label()
        Me.btnSaveEntry = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.DateTimePickerCalendar)
        Me.Panel1.Controls.Add(Me.TBTitle)
        Me.Panel1.Controls.Add(Me.TBDesc)
        Me.Panel1.Controls.Add(Me.LblEntryDesc)
        Me.Panel1.Controls.Add(Me.LblEntryTitle)
        Me.Panel1.Controls.Add(Me.LblEntryDate)
        Me.Panel1.Location = New System.Drawing.Point(55, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(719, 356)
        Me.Panel1.TabIndex = 0
        '
        'DateTimePickerCalendar
        '
        Me.DateTimePickerCalendar.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerCalendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerCalendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerCalendar.Location = New System.Drawing.Point(202, 48)
        Me.DateTimePickerCalendar.Name = "DateTimePickerCalendar"
        Me.DateTimePickerCalendar.Size = New System.Drawing.Size(333, 35)
        Me.DateTimePickerCalendar.TabIndex = 26
        '
        'TBTitle
        '
        Me.TBTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBTitle.Location = New System.Drawing.Point(202, 106)
        Me.TBTitle.Name = "TBTitle"
        Me.TBTitle.Size = New System.Drawing.Size(461, 35)
        Me.TBTitle.TabIndex = 25
        '
        'TBDesc
        '
        Me.TBDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDesc.Location = New System.Drawing.Point(202, 190)
        Me.TBDesc.Multiline = True
        Me.TBDesc.Name = "TBDesc"
        Me.TBDesc.Size = New System.Drawing.Size(461, 129)
        Me.TBDesc.TabIndex = 22
        '
        'LblEntryDesc
        '
        Me.LblEntryDesc.AutoSize = True
        Me.LblEntryDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEntryDesc.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblEntryDesc.Location = New System.Drawing.Point(23, 191)
        Me.LblEntryDesc.Name = "LblEntryDesc"
        Me.LblEntryDesc.Size = New System.Drawing.Size(161, 30)
        Me.LblEntryDesc.TabIndex = 21
        Me.LblEntryDesc.Text = "Description:"
        '
        'LblEntryTitle
        '
        Me.LblEntryTitle.AutoSize = True
        Me.LblEntryTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEntryTitle.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblEntryTitle.Location = New System.Drawing.Point(23, 111)
        Me.LblEntryTitle.Name = "LblEntryTitle"
        Me.LblEntryTitle.Size = New System.Drawing.Size(75, 30)
        Me.LblEntryTitle.TabIndex = 20
        Me.LblEntryTitle.Text = "Title:"
        '
        'LblEntryDate
        '
        Me.LblEntryDate.AutoSize = True
        Me.LblEntryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEntryDate.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblEntryDate.Location = New System.Drawing.Point(23, 48)
        Me.LblEntryDate.Name = "LblEntryDate"
        Me.LblEntryDate.Size = New System.Drawing.Size(79, 30)
        Me.LblEntryDate.TabIndex = 19
        Me.LblEntryDate.Text = "Date:"
        '
        'btnSaveEntry
        '
        Me.btnSaveEntry.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSaveEntry.BackgroundImage = CType(resources.GetObject("btnSaveEntry.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveEntry.ForeColor = System.Drawing.Color.DimGray
        Me.btnSaveEntry.Location = New System.Drawing.Point(169, 462)
        Me.btnSaveEntry.Name = "btnSaveEntry"
        Me.btnSaveEntry.Size = New System.Drawing.Size(220, 66)
        Me.btnSaveEntry.TabIndex = 26
        Me.btnSaveEntry.Text = "Save"
        Me.btnSaveEntry.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.DimGray
        Me.btnClose.Location = New System.Drawing.Point(449, 462)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(220, 66)
        Me.btnClose.TabIndex = 27
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'FormAddToCalendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(851, 587)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSaveEntry)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormAddToCalendar"
        Me.Text = "FormAddToCalendar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblEntryDesc As Label
    Friend WithEvents LblEntryTitle As Label
    Friend WithEvents LblEntryDate As Label
    Friend WithEvents TBDesc As TextBox
    Friend WithEvents TBTitle As TextBox
    Friend WithEvents btnSaveEntry As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents DateTimePickerCalendar As DateTimePicker
End Class
