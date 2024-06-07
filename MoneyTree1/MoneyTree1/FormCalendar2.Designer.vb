<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCalendar2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCalendar2))
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnSaveEntry = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.EntryText = New System.Windows.Forms.TextBox()
        Me.PBCalendar = New System.Windows.Forms.PictureBox()
        Me.c2 = New System.Windows.Forms.PictureBox()
        Me.c3 = New System.Windows.Forms.PictureBox()
        Me.c11 = New System.Windows.Forms.PictureBox()
        Me.c10 = New System.Windows.Forms.PictureBox()
        Me.c12 = New System.Windows.Forms.PictureBox()
        Me.c13 = New System.Windows.Forms.PictureBox()
        Me.c14 = New System.Windows.Forms.PictureBox()
        Me.c4 = New System.Windows.Forms.PictureBox()
        Me.c5 = New System.Windows.Forms.PictureBox()
        Me.c6 = New System.Windows.Forms.PictureBox()
        Me.c7 = New System.Windows.Forms.PictureBox()
        Me.c8 = New System.Windows.Forms.PictureBox()
        Me.c15 = New System.Windows.Forms.PictureBox()
        Me.c1 = New System.Windows.Forms.PictureBox()
        Me.c9 = New System.Windows.Forms.PictureBox()
        CType(Me.PBCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(95, 105)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        Me.MonthCalendar1.TitleBackColor = System.Drawing.Color.LightSeaGreen
        Me.MonthCalendar1.TitleForeColor = System.Drawing.Color.Azure
        '
        'btnSaveEntry
        '
        Me.btnSaveEntry.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSaveEntry.BackgroundImage = CType(resources.GetObject("btnSaveEntry.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveEntry.ForeColor = System.Drawing.Color.DimGray
        Me.btnSaveEntry.Location = New System.Drawing.Point(95, 370)
        Me.btnSaveEntry.Name = "btnSaveEntry"
        Me.btnSaveEntry.Size = New System.Drawing.Size(136, 52)
        Me.btnSaveEntry.TabIndex = 36
        Me.btnSaveEntry.Text = "Save"
        Me.btnSaveEntry.UseVisualStyleBackColor = False
        Me.btnSaveEntry.Visible = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.DimGray
        Me.btnBack.Location = New System.Drawing.Point(271, 370)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(136, 52)
        Me.btnBack.TabIndex = 37
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        Me.btnBack.Visible = False
        '
        'EntryText
        '
        Me.EntryText.Location = New System.Drawing.Point(95, 105)
        Me.EntryText.Multiline = True
        Me.EntryText.Name = "EntryText"
        Me.EntryText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.EntryText.Size = New System.Drawing.Size(312, 253)
        Me.EntryText.TabIndex = 38
        Me.EntryText.Visible = False
        '
        'PBCalendar
        '
        Me.PBCalendar.BackColor = System.Drawing.Color.Transparent
        Me.PBCalendar.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.calendarblue
        Me.PBCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBCalendar.Location = New System.Drawing.Point(212, 12)
        Me.PBCalendar.Name = "PBCalendar"
        Me.PBCalendar.Size = New System.Drawing.Size(78, 70)
        Me.PBCalendar.TabIndex = 42
        Me.PBCalendar.TabStop = False
        '
        'c2
        '
        Me.c2.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.c2.Location = New System.Drawing.Point(475, -2)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(34, 34)
        Me.c2.TabIndex = 43
        Me.c2.TabStop = False
        '
        'c3
        '
        Me.c3.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.c3.Location = New System.Drawing.Point(423, 69)
        Me.c3.Name = "c3"
        Me.c3.Size = New System.Drawing.Size(34, 34)
        Me.c3.TabIndex = 44
        Me.c3.TabStop = False
        '
        'c11
        '
        Me.c11.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.c11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.c11.Location = New System.Drawing.Point(55, 249)
        Me.c11.Name = "c11"
        Me.c11.Size = New System.Drawing.Size(34, 34)
        Me.c11.TabIndex = 45
        Me.c11.TabStop = False
        '
        'c10
        '
        Me.c10.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.c10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.c10.Location = New System.Drawing.Point(-7, 351)
        Me.c10.Name = "c10"
        Me.c10.Size = New System.Drawing.Size(34, 34)
        Me.c10.TabIndex = 46
        Me.c10.TabStop = False
        '
        'c12
        '
        Me.c12.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.c12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.c12.Location = New System.Drawing.Point(-7, 178)
        Me.c12.Name = "c12"
        Me.c12.Size = New System.Drawing.Size(34, 34)
        Me.c12.TabIndex = 47
        Me.c12.TabStop = False
        '
        'c13
        '
        Me.c13.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.c13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.c13.Location = New System.Drawing.Point(55, 105)
        Me.c13.Name = "c13"
        Me.c13.Size = New System.Drawing.Size(34, 34)
        Me.c13.TabIndex = 48
        Me.c13.TabStop = False
        '
        'c14
        '
        Me.c14.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.c14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.c14.Location = New System.Drawing.Point(-7, -2)
        Me.c14.Name = "c14"
        Me.c14.Size = New System.Drawing.Size(34, 34)
        Me.c14.TabIndex = 49
        Me.c14.TabStop = False
        '
        'c4
        '
        Me.c4.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.c4.Location = New System.Drawing.Point(475, 167)
        Me.c4.Name = "c4"
        Me.c4.Size = New System.Drawing.Size(34, 34)
        Me.c4.TabIndex = 50
        Me.c4.TabStop = False
        '
        'c5
        '
        Me.c5.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.c5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.c5.Location = New System.Drawing.Point(413, 298)
        Me.c5.Name = "c5"
        Me.c5.Size = New System.Drawing.Size(34, 34)
        Me.c5.TabIndex = 51
        Me.c5.TabStop = False
        '
        'c6
        '
        Me.c6.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.c6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.c6.Location = New System.Drawing.Point(475, 370)
        Me.c6.Name = "c6"
        Me.c6.Size = New System.Drawing.Size(34, 34)
        Me.c6.TabIndex = 52
        Me.c6.TabStop = False
        '
        'c7
        '
        Me.c7.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.c7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.c7.Location = New System.Drawing.Point(353, 441)
        Me.c7.Name = "c7"
        Me.c7.Size = New System.Drawing.Size(34, 34)
        Me.c7.TabIndex = 53
        Me.c7.TabStop = False
        '
        'c8
        '
        Me.c8.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.c8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.c8.Location = New System.Drawing.Point(183, 428)
        Me.c8.Name = "c8"
        Me.c8.Size = New System.Drawing.Size(34, 34)
        Me.c8.TabIndex = 54
        Me.c8.TabStop = False
        '
        'c15
        '
        Me.c15.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.c15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.c15.Location = New System.Drawing.Point(122, -13)
        Me.c15.Name = "c15"
        Me.c15.Size = New System.Drawing.Size(34, 34)
        Me.c15.TabIndex = 55
        Me.c15.TabStop = False
        '
        'c1
        '
        Me.c1.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.c1.Location = New System.Drawing.Point(353, -13)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(34, 34)
        Me.c1.TabIndex = 56
        Me.c1.TabStop = False
        '
        'c9
        '
        Me.c9.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.c9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.c9.Location = New System.Drawing.Point(36, 441)
        Me.c9.Name = "c9"
        Me.c9.Size = New System.Drawing.Size(34, 34)
        Me.c9.TabIndex = 57
        Me.c9.TabStop = False
        '
        'FormCalendar2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(507, 467)
        Me.Controls.Add(Me.c9)
        Me.Controls.Add(Me.c1)
        Me.Controls.Add(Me.c15)
        Me.Controls.Add(Me.c8)
        Me.Controls.Add(Me.c7)
        Me.Controls.Add(Me.c6)
        Me.Controls.Add(Me.c5)
        Me.Controls.Add(Me.c4)
        Me.Controls.Add(Me.c14)
        Me.Controls.Add(Me.c13)
        Me.Controls.Add(Me.c12)
        Me.Controls.Add(Me.c10)
        Me.Controls.Add(Me.c11)
        Me.Controls.Add(Me.c3)
        Me.Controls.Add(Me.c2)
        Me.Controls.Add(Me.PBCalendar)
        Me.Controls.Add(Me.EntryText)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSaveEntry)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCalendar2"
        Me.Text = "Calendar"
        CType(Me.PBCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents btnSaveEntry As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents EntryText As TextBox
    Friend WithEvents PBCalendar As PictureBox
    Friend WithEvents c2 As PictureBox
    Friend WithEvents c3 As PictureBox
    Friend WithEvents c11 As PictureBox
    Friend WithEvents c10 As PictureBox
    Friend WithEvents c12 As PictureBox
    Friend WithEvents c13 As PictureBox
    Friend WithEvents c14 As PictureBox
    Friend WithEvents c4 As PictureBox
    Friend WithEvents c5 As PictureBox
    Friend WithEvents c6 As PictureBox
    Friend WithEvents c7 As PictureBox
    Friend WithEvents c8 As PictureBox
    Friend WithEvents c15 As PictureBox
    Friend WithEvents c1 As PictureBox
    Friend WithEvents c9 As PictureBox
End Class
