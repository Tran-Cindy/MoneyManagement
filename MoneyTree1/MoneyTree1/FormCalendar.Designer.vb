<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCalendar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCalendar))
        Me.btnAddToCalendar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblMonth = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LblSaturday = New System.Windows.Forms.Label()
        Me.LblFriday = New System.Windows.Forms.Label()
        Me.LblThur = New System.Windows.Forms.Label()
        Me.LblWednesday = New System.Windows.Forms.Label()
        Me.LblThursday = New System.Windows.Forms.Label()
        Me.LblTuesday = New System.Windows.Forms.Label()
        Me.LblMonday = New System.Windows.Forms.Label()
        Me.LblSunday = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel8 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddToCalendar
        '
        Me.btnAddToCalendar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAddToCalendar.BackgroundImage = CType(resources.GetObject("btnAddToCalendar.BackgroundImage"), System.Drawing.Image)
        Me.btnAddToCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddToCalendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToCalendar.ForeColor = System.Drawing.Color.DimGray
        Me.btnAddToCalendar.Location = New System.Drawing.Point(22, 22)
        Me.btnAddToCalendar.Name = "btnAddToCalendar"
        Me.btnAddToCalendar.Size = New System.Drawing.Size(220, 91)
        Me.btnAddToCalendar.TabIndex = 10
        Me.btnAddToCalendar.Text = "Add an entry to the calendar"
        Me.btnAddToCalendar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.btnAddToCalendar)
        Me.Panel1.Location = New System.Drawing.Point(22, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(263, 135)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Azure
        Me.Panel2.Controls.Add(Me.LblMonth)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(306, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1587, 135)
        Me.Panel2.TabIndex = 12
        '
        'LblMonth
        '
        Me.LblMonth.AutoSize = True
        Me.LblMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMonth.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblMonth.Location = New System.Drawing.Point(23, 55)
        Me.LblMonth.Name = "LblMonth"
        Me.LblMonth.Size = New System.Drawing.Size(356, 58)
        Me.LblMonth.TabIndex = 20
        Me.LblMonth.Text = "January, 2022"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnForward)
        Me.Panel3.Controls.Add(Me.btnBack)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1320, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(267, 135)
        Me.Panel3.TabIndex = 0
        '
        'btnForward
        '
        Me.btnForward.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnForward.BackgroundImage = CType(resources.GetObject("btnForward.BackgroundImage"), System.Drawing.Image)
        Me.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnForward.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForward.ForeColor = System.Drawing.Color.DimGray
        Me.btnForward.Location = New System.Drawing.Point(138, 47)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(107, 66)
        Me.btnForward.TabIndex = 28
        Me.btnForward.Text = ">"
        Me.btnForward.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.DimGray
        Me.btnBack.Location = New System.Drawing.Point(14, 47)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 66)
        Me.btnBack.TabIndex = 27
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Azure
        Me.Panel4.Controls.Add(Me.LblSaturday)
        Me.Panel4.Controls.Add(Me.LblFriday)
        Me.Panel4.Controls.Add(Me.LblThur)
        Me.Panel4.Controls.Add(Me.LblWednesday)
        Me.Panel4.Controls.Add(Me.LblThursday)
        Me.Panel4.Controls.Add(Me.LblTuesday)
        Me.Panel4.Controls.Add(Me.LblMonday)
        Me.Panel4.Controls.Add(Me.LblSunday)
        Me.Panel4.Location = New System.Drawing.Point(306, 164)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1587, 56)
        Me.Panel4.TabIndex = 21
        '
        'LblSaturday
        '
        Me.LblSaturday.BackColor = System.Drawing.Color.Plum
        Me.LblSaturday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSaturday.ForeColor = System.Drawing.Color.Black
        Me.LblSaturday.Location = New System.Drawing.Point(1309, 11)
        Me.LblSaturday.Name = "LblSaturday"
        Me.LblSaturday.Size = New System.Drawing.Size(200, 36)
        Me.LblSaturday.TabIndex = 28
        Me.LblSaturday.Text = "Saturday"
        '
        'LblFriday
        '
        Me.LblFriday.BackColor = System.Drawing.Color.PaleTurquoise
        Me.LblFriday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFriday.ForeColor = System.Drawing.Color.Black
        Me.LblFriday.Location = New System.Drawing.Point(1093, 11)
        Me.LblFriday.Name = "LblFriday"
        Me.LblFriday.Size = New System.Drawing.Size(200, 36)
        Me.LblFriday.TabIndex = 27
        Me.LblFriday.Text = "Friday"
        '
        'LblThur
        '
        Me.LblThur.BackColor = System.Drawing.Color.Aquamarine
        Me.LblThur.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblThur.ForeColor = System.Drawing.Color.Black
        Me.LblThur.Location = New System.Drawing.Point(877, 11)
        Me.LblThur.Name = "LblThur"
        Me.LblThur.Size = New System.Drawing.Size(200, 36)
        Me.LblThur.TabIndex = 26
        Me.LblThur.Text = "Thursday"
        '
        'LblWednesday
        '
        Me.LblWednesday.BackColor = System.Drawing.Color.PaleGreen
        Me.LblWednesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWednesday.ForeColor = System.Drawing.Color.Black
        Me.LblWednesday.Location = New System.Drawing.Point(661, 11)
        Me.LblWednesday.Name = "LblWednesday"
        Me.LblWednesday.Size = New System.Drawing.Size(200, 36)
        Me.LblWednesday.TabIndex = 25
        Me.LblWednesday.Text = "Wednesday"
        '
        'LblThursday
        '
        Me.LblThursday.AutoSize = True
        Me.LblThursday.BackColor = System.Drawing.Color.LawnGreen
        Me.LblThursday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblThursday.ForeColor = System.Drawing.Color.Black
        Me.LblThursday.Location = New System.Drawing.Point(590, 0)
        Me.LblThursday.Name = "LblThursday"
        Me.LblThursday.Size = New System.Drawing.Size(0, 36)
        Me.LblThursday.TabIndex = 24
        '
        'LblTuesday
        '
        Me.LblTuesday.BackColor = System.Drawing.Color.Gold
        Me.LblTuesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTuesday.ForeColor = System.Drawing.Color.Black
        Me.LblTuesday.Location = New System.Drawing.Point(445, 11)
        Me.LblTuesday.Name = "LblTuesday"
        Me.LblTuesday.Size = New System.Drawing.Size(200, 36)
        Me.LblTuesday.TabIndex = 23
        Me.LblTuesday.Text = "Tuesday"
        '
        'LblMonday
        '
        Me.LblMonday.BackColor = System.Drawing.Color.Orange
        Me.LblMonday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMonday.ForeColor = System.Drawing.Color.Black
        Me.LblMonday.Location = New System.Drawing.Point(229, 11)
        Me.LblMonday.Name = "LblMonday"
        Me.LblMonday.Size = New System.Drawing.Size(200, 36)
        Me.LblMonday.TabIndex = 22
        Me.LblMonday.Text = "Monday"
        '
        'LblSunday
        '
        Me.LblSunday.BackColor = System.Drawing.Color.LightSalmon
        Me.LblSunday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSunday.ForeColor = System.Drawing.Color.Black
        Me.LblSunday.Location = New System.Drawing.Point(13, 11)
        Me.LblSunday.Name = "LblSunday"
        Me.LblSunday.Size = New System.Drawing.Size(200, 36)
        Me.LblSunday.TabIndex = 21
        Me.LblSunday.Text = "Sunday"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Azure
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel5)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel6)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel7)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel8)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(306, 226)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1587, 782)
        Me.FlowLayoutPanel1.TabIndex = 22
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(210, 182)
        Me.FlowLayoutPanel3.TabIndex = 1
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(219, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(210, 182)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(435, 3)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(210, 182)
        Me.FlowLayoutPanel4.TabIndex = 1
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(651, 3)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(210, 182)
        Me.FlowLayoutPanel5.TabIndex = 1
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(867, 3)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(210, 182)
        Me.FlowLayoutPanel6.TabIndex = 1
        '
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(1083, 3)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(210, 182)
        Me.FlowLayoutPanel7.TabIndex = 1
        '
        'FlowLayoutPanel8
        '
        Me.FlowLayoutPanel8.Location = New System.Drawing.Point(1299, 3)
        Me.FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        Me.FlowLayoutPanel8.Size = New System.Drawing.Size(210, 182)
        Me.FlowLayoutPanel8.TabIndex = 1
        '
        'FormCalendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1924, 1036)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCalendar"
        Me.Text = "Calendar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddToCalendar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblMonth As Label
    Friend WithEvents btnForward As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LblSaturday As Label
    Friend WithEvents LblFriday As Label
    Friend WithEvents LblThur As Label
    Friend WithEvents LblWednesday As Label
    Friend WithEvents LblThursday As Label
    Friend WithEvents LblTuesday As Label
    Friend WithEvents LblMonday As Label
    Friend WithEvents LblSunday As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel8 As FlowLayoutPanel
End Class
