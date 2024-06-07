<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCalculator))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblShowCurrentCalc = New System.Windows.Forms.Label()
        Me.Calc = New System.Windows.Forms.Label()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDecimal = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TBTotal = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnRefreshDGVBill = New System.Windows.Forms.Button()
        Me.btnBillDateSearch = New System.Windows.Forms.Button()
        Me.DGVBill = New System.Windows.Forms.DataGridView()
        Me.LblBDateSearch = New System.Windows.Forms.Label()
        Me.TBBillSearch = New System.Windows.Forms.TextBox()
        Me.TBBillDateSearch = New System.Windows.Forms.TextBox()
        Me.LblBSearch = New System.Windows.Forms.Label()
        Me.btnBillSearch = New System.Windows.Forms.Button()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnGenReceipt = New System.Windows.Forms.Button()
        Me.btnClearBill = New System.Windows.Forms.Button()
        Me.LblBillID = New System.Windows.Forms.Label()
        Me.DateTimeBillDate = New System.Windows.Forms.DateTimePicker()
        Me.LblCouncilTax = New System.Windows.Forms.Label()
        Me.btnDeleteBill = New System.Windows.Forms.Button()
        Me.LblElectricity = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.LblGas = New System.Windows.Forms.Label()
        Me.btnEditBill = New System.Windows.Forms.Button()
        Me.LblWater = New System.Windows.Forms.Label()
        Me.TBGas = New System.Windows.Forms.TextBox()
        Me.TBTax = New System.Windows.Forms.TextBox()
        Me.btnSaveBill = New System.Windows.Forms.Button()
        Me.LblMobile = New System.Windows.Forms.Label()
        Me.TBElectricity = New System.Windows.Forms.TextBox()
        Me.TBBillID = New System.Windows.Forms.TextBox()
        Me.TBRent = New System.Windows.Forms.TextBox()
        Me.TBMobile = New System.Windows.Forms.TextBox()
        Me.TBWater = New System.Windows.Forms.TextBox()
        Me.LblRent = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.btnClearMonthTax = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBMonthRent = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBMonthTax = New System.Windows.Forms.TextBox()
        Me.btnCalcMonthly = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDBillMonthlyTB = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.btnClearYearTax = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCalcYearly = New System.Windows.Forms.Button()
        Me.TBYearlyRent = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IDBillYearlyTB = New System.Windows.Forms.TextBox()
        Me.TBYearlyTax = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DGVBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(1160, 44)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(732, 943)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Azure
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.btnEquals)
        Me.TabPage1.Controls.Add(Me.btnMultiply)
        Me.TabPage1.Controls.Add(Me.btnClear)
        Me.TabPage1.Controls.Add(Me.btnDecimal)
        Me.TabPage1.Controls.Add(Me.btn0)
        Me.TabPage1.Controls.Add(Me.btnDivide)
        Me.TabPage1.Controls.Add(Me.btn9)
        Me.TabPage1.Controls.Add(Me.btn8)
        Me.TabPage1.Controls.Add(Me.btn7)
        Me.TabPage1.Controls.Add(Me.btnSubtract)
        Me.TabPage1.Controls.Add(Me.btn6)
        Me.TabPage1.Controls.Add(Me.btn5)
        Me.TabPage1.Controls.Add(Me.btn4)
        Me.TabPage1.Controls.Add(Me.btnAdd)
        Me.TabPage1.Controls.Add(Me.btn3)
        Me.TabPage1.Controls.Add(Me.btn2)
        Me.TabPage1.Controls.Add(Me.btn1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(724, 910)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Calculator"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LblShowCurrentCalc)
        Me.Panel1.Controls.Add(Me.Calc)
        Me.Panel1.Location = New System.Drawing.Point(97, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 142)
        Me.Panel1.TabIndex = 17
        '
        'LblShowCurrentCalc
        '
        Me.LblShowCurrentCalc.AutoSize = True
        Me.LblShowCurrentCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowCurrentCalc.Location = New System.Drawing.Point(424, 18)
        Me.LblShowCurrentCalc.Name = "LblShowCurrentCalc"
        Me.LblShowCurrentCalc.Size = New System.Drawing.Size(0, 25)
        Me.LblShowCurrentCalc.TabIndex = 17
        '
        'Calc
        '
        Me.Calc.AutoSize = True
        Me.Calc.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calc.Location = New System.Drawing.Point(22, 88)
        Me.Calc.Name = "Calc"
        Me.Calc.Size = New System.Drawing.Size(37, 40)
        Me.Calc.TabIndex = 16
        Me.Calc.Text = "0"
        Me.Calc.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'btnEquals
        '
        Me.btnEquals.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEquals.Location = New System.Drawing.Point(97, 715)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(549, 104)
        Me.btnEquals.TabIndex = 15
        Me.btnEquals.Text = "="
        Me.btnEquals.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiply.Location = New System.Drawing.Point(526, 586)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(120, 104)
        Me.btnMultiply.TabIndex = 14
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(349, 586)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 104)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDecimal
        '
        Me.btnDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecimal.Location = New System.Drawing.Point(223, 586)
        Me.btnDecimal.Name = "btnDecimal"
        Me.btnDecimal.Size = New System.Drawing.Size(120, 104)
        Me.btnDecimal.TabIndex = 12
        Me.btnDecimal.Text = "."
        Me.btnDecimal.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(97, 586)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(120, 104)
        Me.btn0.TabIndex = 11
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.Location = New System.Drawing.Point(526, 460)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(120, 104)
        Me.btnDivide.TabIndex = 10
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(349, 460)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(120, 104)
        Me.btn9.TabIndex = 9
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(223, 460)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(120, 104)
        Me.btn8.TabIndex = 8
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(97, 460)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(120, 104)
        Me.btn7.TabIndex = 1
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtract.Location = New System.Drawing.Point(526, 336)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(120, 104)
        Me.btnSubtract.TabIndex = 7
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(349, 336)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(120, 104)
        Me.btn6.TabIndex = 6
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(223, 336)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(120, 104)
        Me.btn5.TabIndex = 5
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(97, 336)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(120, 104)
        Me.btn4.TabIndex = 4
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(526, 212)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 104)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(349, 212)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(120, 104)
        Me.btn3.TabIndex = 2
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(223, 212)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(120, 104)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(97, 212)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(120, 104)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Azure
        Me.TabPage2.Controls.Add(Me.TBTotal)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(724, 910)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Weekly Total Bill"
        '
        'TBTotal
        '
        Me.TBTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBTotal.Location = New System.Drawing.Point(52, 52)
        Me.TBTotal.Multiline = True
        Me.TBTotal.Name = "TBTotal"
        Me.TBTotal.Size = New System.Drawing.Size(628, 802)
        Me.TBTotal.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Azure
        Me.TabPage3.Controls.Add(Me.btnRefreshDGVBill)
        Me.TabPage3.Controls.Add(Me.btnBillDateSearch)
        Me.TabPage3.Controls.Add(Me.DGVBill)
        Me.TabPage3.Controls.Add(Me.LblBDateSearch)
        Me.TabPage3.Controls.Add(Me.TBBillSearch)
        Me.TabPage3.Controls.Add(Me.TBBillDateSearch)
        Me.TabPage3.Controls.Add(Me.LblBSearch)
        Me.TabPage3.Controls.Add(Me.btnBillSearch)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(724, 910)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "View previous bill calculations"
        '
        'btnRefreshDGVBill
        '
        Me.btnRefreshDGVBill.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnRefreshDGVBill.BackgroundImage = CType(resources.GetObject("btnRefreshDGVBill.BackgroundImage"), System.Drawing.Image)
        Me.btnRefreshDGVBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefreshDGVBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshDGVBill.ForeColor = System.Drawing.Color.DimGray
        Me.btnRefreshDGVBill.Location = New System.Drawing.Point(526, 203)
        Me.btnRefreshDGVBill.Name = "btnRefreshDGVBill"
        Me.btnRefreshDGVBill.Size = New System.Drawing.Size(160, 44)
        Me.btnRefreshDGVBill.TabIndex = 41
        Me.btnRefreshDGVBill.Text = "Refresh"
        Me.btnRefreshDGVBill.UseVisualStyleBackColor = False
        '
        'btnBillDateSearch
        '
        Me.btnBillDateSearch.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnBillDateSearch.BackgroundImage = CType(resources.GetObject("btnBillDateSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnBillDateSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBillDateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillDateSearch.ForeColor = System.Drawing.Color.DimGray
        Me.btnBillDateSearch.Location = New System.Drawing.Point(526, 101)
        Me.btnBillDateSearch.Name = "btnBillDateSearch"
        Me.btnBillDateSearch.Size = New System.Drawing.Size(160, 44)
        Me.btnBillDateSearch.TabIndex = 38
        Me.btnBillDateSearch.Text = "Enter"
        Me.btnBillDateSearch.UseVisualStyleBackColor = False
        '
        'DGVBill
        '
        Me.DGVBill.BackgroundColor = System.Drawing.Color.White
        Me.DGVBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBill.Location = New System.Drawing.Point(69, 256)
        Me.DGVBill.Name = "DGVBill"
        Me.DGVBill.RowHeadersWidth = 62
        Me.DGVBill.RowTemplate.Height = 28
        Me.DGVBill.Size = New System.Drawing.Size(617, 600)
        Me.DGVBill.TabIndex = 36
        '
        'LblBDateSearch
        '
        Me.LblBDateSearch.AutoSize = True
        Me.LblBDateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBDateSearch.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblBDateSearch.Location = New System.Drawing.Point(64, 106)
        Me.LblBDateSearch.Name = "LblBDateSearch"
        Me.LblBDateSearch.Size = New System.Drawing.Size(166, 30)
        Me.LblBDateSearch.TabIndex = 39
        Me.LblBDateSearch.Text = "Date Search"
        '
        'TBBillSearch
        '
        Me.TBBillSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBBillSearch.Location = New System.Drawing.Point(187, 55)
        Me.TBBillSearch.Name = "TBBillSearch"
        Me.TBBillSearch.Size = New System.Drawing.Size(333, 35)
        Me.TBBillSearch.TabIndex = 37
        '
        'TBBillDateSearch
        '
        Me.TBBillDateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBBillDateSearch.Location = New System.Drawing.Point(250, 105)
        Me.TBBillDateSearch.Name = "TBBillDateSearch"
        Me.TBBillDateSearch.Size = New System.Drawing.Size(270, 35)
        Me.TBBillDateSearch.TabIndex = 40
        '
        'LblBSearch
        '
        Me.LblBSearch.AutoSize = True
        Me.LblBSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBSearch.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblBSearch.Location = New System.Drawing.Point(64, 55)
        Me.LblBSearch.Name = "LblBSearch"
        Me.LblBSearch.Size = New System.Drawing.Size(100, 30)
        Me.LblBSearch.TabIndex = 36
        Me.LblBSearch.Text = "Search"
        '
        'btnBillSearch
        '
        Me.btnBillSearch.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnBillSearch.BackgroundImage = CType(resources.GetObject("btnBillSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnBillSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBillSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillSearch.ForeColor = System.Drawing.Color.DimGray
        Me.btnBillSearch.Location = New System.Drawing.Point(526, 51)
        Me.btnBillSearch.Name = "btnBillSearch"
        Me.btnBillSearch.Size = New System.Drawing.Size(160, 44)
        Me.btnBillSearch.TabIndex = 35
        Me.btnBillSearch.Text = "Enter"
        Me.btnBillSearch.UseVisualStyleBackColor = False
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Location = New System.Drawing.Point(60, 44)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(890, 943)
        Me.TabControl2.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Azure
        Me.TabPage4.Controls.Add(Me.btnGenReceipt)
        Me.TabPage4.Controls.Add(Me.btnClearBill)
        Me.TabPage4.Controls.Add(Me.LblBillID)
        Me.TabPage4.Controls.Add(Me.DateTimeBillDate)
        Me.TabPage4.Controls.Add(Me.LblCouncilTax)
        Me.TabPage4.Controls.Add(Me.btnDeleteBill)
        Me.TabPage4.Controls.Add(Me.LblElectricity)
        Me.TabPage4.Controls.Add(Me.LblDate)
        Me.TabPage4.Controls.Add(Me.LblGas)
        Me.TabPage4.Controls.Add(Me.btnEditBill)
        Me.TabPage4.Controls.Add(Me.LblWater)
        Me.TabPage4.Controls.Add(Me.TBGas)
        Me.TabPage4.Controls.Add(Me.TBTax)
        Me.TabPage4.Controls.Add(Me.btnSaveBill)
        Me.TabPage4.Controls.Add(Me.LblMobile)
        Me.TabPage4.Controls.Add(Me.TBElectricity)
        Me.TabPage4.Controls.Add(Me.TBBillID)
        Me.TabPage4.Controls.Add(Me.TBRent)
        Me.TabPage4.Controls.Add(Me.TBMobile)
        Me.TabPage4.Controls.Add(Me.TBWater)
        Me.TabPage4.Controls.Add(Me.LblRent)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(882, 910)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Weekly Bill"
        '
        'btnGenReceipt
        '
        Me.btnGenReceipt.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnGenReceipt.BackgroundImage = CType(resources.GetObject("btnGenReceipt.BackgroundImage"), System.Drawing.Image)
        Me.btnGenReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGenReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenReceipt.ForeColor = System.Drawing.Color.DimGray
        Me.btnGenReceipt.Location = New System.Drawing.Point(598, 361)
        Me.btnGenReceipt.Name = "btnGenReceipt"
        Me.btnGenReceipt.Size = New System.Drawing.Size(255, 66)
        Me.btnGenReceipt.TabIndex = 74
        Me.btnGenReceipt.Text = "Generate total costs"
        Me.btnGenReceipt.UseVisualStyleBackColor = False
        '
        'btnClearBill
        '
        Me.btnClearBill.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnClearBill.BackgroundImage = CType(resources.GetObject("btnClearBill.BackgroundImage"), System.Drawing.Image)
        Me.btnClearBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearBill.ForeColor = System.Drawing.Color.DimGray
        Me.btnClearBill.Location = New System.Drawing.Point(598, 277)
        Me.btnClearBill.Name = "btnClearBill"
        Me.btnClearBill.Size = New System.Drawing.Size(255, 66)
        Me.btnClearBill.TabIndex = 57
        Me.btnClearBill.Text = "Clear"
        Me.btnClearBill.UseVisualStyleBackColor = False
        '
        'LblBillID
        '
        Me.LblBillID.AutoSize = True
        Me.LblBillID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBillID.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblBillID.Location = New System.Drawing.Point(31, 31)
        Me.LblBillID.Name = "LblBillID"
        Me.LblBillID.Size = New System.Drawing.Size(40, 30)
        Me.LblBillID.TabIndex = 66
        Me.LblBillID.Text = "ID"
        '
        'DateTimeBillDate
        '
        Me.DateTimeBillDate.CustomFormat = "yyyy-MM-dd"
        Me.DateTimeBillDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeBillDate.Location = New System.Drawing.Point(34, 797)
        Me.DateTimeBillDate.Name = "DateTimeBillDate"
        Me.DateTimeBillDate.Size = New System.Drawing.Size(333, 35)
        Me.DateTimeBillDate.TabIndex = 73
        '
        'LblCouncilTax
        '
        Me.LblCouncilTax.AutoSize = True
        Me.LblCouncilTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCouncilTax.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblCouncilTax.Location = New System.Drawing.Point(31, 247)
        Me.LblCouncilTax.Name = "LblCouncilTax"
        Me.LblCouncilTax.Size = New System.Drawing.Size(258, 30)
        Me.LblCouncilTax.TabIndex = 64
        Me.LblCouncilTax.Text = "Weekly Council Tax"
        '
        'btnDeleteBill
        '
        Me.btnDeleteBill.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnDeleteBill.BackgroundImage = CType(resources.GetObject("btnDeleteBill.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteBill.ForeColor = System.Drawing.Color.DimGray
        Me.btnDeleteBill.Location = New System.Drawing.Point(598, 192)
        Me.btnDeleteBill.Name = "btnDeleteBill"
        Me.btnDeleteBill.Size = New System.Drawing.Size(255, 66)
        Me.btnDeleteBill.TabIndex = 56
        Me.btnDeleteBill.Text = "Delete"
        Me.btnDeleteBill.UseVisualStyleBackColor = False
        '
        'LblElectricity
        '
        Me.LblElectricity.AutoSize = True
        Me.LblElectricity.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblElectricity.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblElectricity.Location = New System.Drawing.Point(31, 562)
        Me.LblElectricity.Name = "LblElectricity"
        Me.LblElectricity.Size = New System.Drawing.Size(281, 30)
        Me.LblElectricity.TabIndex = 63
        Me.LblElectricity.Text = "Weekly Electricity Bill"
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblDate.Location = New System.Drawing.Point(29, 754)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(71, 30)
        Me.LblDate.TabIndex = 72
        Me.LblDate.Text = "Date"
        '
        'LblGas
        '
        Me.LblGas.AutoSize = True
        Me.LblGas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGas.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblGas.Location = New System.Drawing.Point(31, 657)
        Me.LblGas.Name = "LblGas"
        Me.LblGas.Size = New System.Drawing.Size(209, 30)
        Me.LblGas.TabIndex = 65
        Me.LblGas.Text = "Weekly Gas Bill"
        '
        'btnEditBill
        '
        Me.btnEditBill.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnEditBill.BackgroundImage = CType(resources.GetObject("btnEditBill.BackgroundImage"), System.Drawing.Image)
        Me.btnEditBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditBill.ForeColor = System.Drawing.Color.DimGray
        Me.btnEditBill.Location = New System.Drawing.Point(598, 108)
        Me.btnEditBill.Name = "btnEditBill"
        Me.btnEditBill.Size = New System.Drawing.Size(255, 66)
        Me.btnEditBill.TabIndex = 55
        Me.btnEditBill.Text = "Edit"
        Me.btnEditBill.UseVisualStyleBackColor = False
        '
        'LblWater
        '
        Me.LblWater.AutoSize = True
        Me.LblWater.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWater.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblWater.Location = New System.Drawing.Point(31, 353)
        Me.LblWater.Name = "LblWater"
        Me.LblWater.Size = New System.Drawing.Size(233, 30)
        Me.LblWater.TabIndex = 62
        Me.LblWater.Text = "Weekly Water Bill"
        '
        'TBGas
        '
        Me.TBGas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBGas.Location = New System.Drawing.Point(34, 703)
        Me.TBGas.Name = "TBGas"
        Me.TBGas.Size = New System.Drawing.Size(333, 35)
        Me.TBGas.TabIndex = 71
        '
        'TBTax
        '
        Me.TBTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBTax.Location = New System.Drawing.Point(35, 291)
        Me.TBTax.Name = "TBTax"
        Me.TBTax.Size = New System.Drawing.Size(333, 35)
        Me.TBTax.TabIndex = 61
        '
        'btnSaveBill
        '
        Me.btnSaveBill.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSaveBill.BackgroundImage = CType(resources.GetObject("btnSaveBill.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveBill.ForeColor = System.Drawing.Color.DimGray
        Me.btnSaveBill.Location = New System.Drawing.Point(598, 31)
        Me.btnSaveBill.Name = "btnSaveBill"
        Me.btnSaveBill.Size = New System.Drawing.Size(255, 66)
        Me.btnSaveBill.TabIndex = 54
        Me.btnSaveBill.Text = "Save"
        Me.btnSaveBill.UseVisualStyleBackColor = False
        '
        'LblMobile
        '
        Me.LblMobile.AutoSize = True
        Me.LblMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMobile.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblMobile.Location = New System.Drawing.Point(29, 461)
        Me.LblMobile.Name = "LblMobile"
        Me.LblMobile.Size = New System.Drawing.Size(241, 30)
        Me.LblMobile.TabIndex = 60
        Me.LblMobile.Text = "Weekly Mobile Bill"
        '
        'TBElectricity
        '
        Me.TBElectricity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBElectricity.Location = New System.Drawing.Point(34, 609)
        Me.TBElectricity.Name = "TBElectricity"
        Me.TBElectricity.Size = New System.Drawing.Size(333, 35)
        Me.TBElectricity.TabIndex = 70
        '
        'TBBillID
        '
        Me.TBBillID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBBillID.Location = New System.Drawing.Point(34, 81)
        Me.TBBillID.Name = "TBBillID"
        Me.TBBillID.Size = New System.Drawing.Size(333, 35)
        Me.TBBillID.TabIndex = 67
        '
        'TBRent
        '
        Me.TBRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBRent.Location = New System.Drawing.Point(35, 186)
        Me.TBRent.Name = "TBRent"
        Me.TBRent.Size = New System.Drawing.Size(333, 35)
        Me.TBRent.TabIndex = 59
        '
        'TBMobile
        '
        Me.TBMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBMobile.Location = New System.Drawing.Point(34, 511)
        Me.TBMobile.Name = "TBMobile"
        Me.TBMobile.Size = New System.Drawing.Size(333, 35)
        Me.TBMobile.TabIndex = 69
        '
        'TBWater
        '
        Me.TBWater.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBWater.Location = New System.Drawing.Point(34, 404)
        Me.TBWater.Name = "TBWater"
        Me.TBWater.Size = New System.Drawing.Size(333, 35)
        Me.TBWater.TabIndex = 68
        '
        'LblRent
        '
        Me.LblRent.AutoSize = True
        Me.LblRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRent.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LblRent.Location = New System.Drawing.Point(31, 143)
        Me.LblRent.Name = "LblRent"
        Me.LblRent.Size = New System.Drawing.Size(170, 30)
        Me.LblRent.TabIndex = 58
        Me.LblRent.Text = "Weekly Rent"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.Azure
        Me.TabPage5.Controls.Add(Me.btnClearMonthTax)
        Me.TabPage5.Controls.Add(Me.Label5)
        Me.TabPage5.Controls.Add(Me.TBMonthRent)
        Me.TabPage5.Controls.Add(Me.Label4)
        Me.TabPage5.Controls.Add(Me.TBMonthTax)
        Me.TabPage5.Controls.Add(Me.btnCalcMonthly)
        Me.TabPage5.Controls.Add(Me.Label1)
        Me.TabPage5.Controls.Add(Me.IDBillMonthlyTB)
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(882, 910)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Calculate monthly tax/rent"
        '
        'btnClearMonthTax
        '
        Me.btnClearMonthTax.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnClearMonthTax.BackgroundImage = CType(resources.GetObject("btnClearMonthTax.BackgroundImage"), System.Drawing.Image)
        Me.btnClearMonthTax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearMonthTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearMonthTax.ForeColor = System.Drawing.Color.DimGray
        Me.btnClearMonthTax.Location = New System.Drawing.Point(63, 361)
        Me.btnClearMonthTax.Name = "btnClearMonthTax"
        Me.btnClearMonthTax.Size = New System.Drawing.Size(220, 66)
        Me.btnClearMonthTax.TabIndex = 74
        Me.btnClearMonthTax.Text = "Clear"
        Me.btnClearMonthTax.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label5.Location = New System.Drawing.Point(58, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 30)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Monthly Rent"
        '
        'TBMonthRent
        '
        Me.TBMonthRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBMonthRent.Location = New System.Drawing.Point(252, 281)
        Me.TBMonthRent.Name = "TBMonthRent"
        Me.TBMonthRent.Size = New System.Drawing.Size(333, 35)
        Me.TBMonthRent.TabIndex = 73
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label4.Location = New System.Drawing.Point(58, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 30)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Monthly Tax"
        '
        'TBMonthTax
        '
        Me.TBMonthTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBMonthTax.Location = New System.Drawing.Point(252, 211)
        Me.TBMonthTax.Name = "TBMonthTax"
        Me.TBMonthTax.Size = New System.Drawing.Size(333, 35)
        Me.TBMonthTax.TabIndex = 71
        '
        'btnCalcMonthly
        '
        Me.btnCalcMonthly.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnCalcMonthly.BackgroundImage = CType(resources.GetObject("btnCalcMonthly.BackgroundImage"), System.Drawing.Image)
        Me.btnCalcMonthly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalcMonthly.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcMonthly.ForeColor = System.Drawing.Color.DimGray
        Me.btnCalcMonthly.Location = New System.Drawing.Point(414, 80)
        Me.btnCalcMonthly.Name = "btnCalcMonthly"
        Me.btnCalcMonthly.Size = New System.Drawing.Size(220, 66)
        Me.btnCalcMonthly.TabIndex = 55
        Me.btnCalcMonthly.Text = "Calculate"
        Me.btnCalcMonthly.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.Location = New System.Drawing.Point(58, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 30)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Bill ID"
        '
        'IDBillMonthlyTB
        '
        Me.IDBillMonthlyTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDBillMonthlyTB.Location = New System.Drawing.Point(63, 111)
        Me.IDBillMonthlyTB.Name = "IDBillMonthlyTB"
        Me.IDBillMonthlyTB.Size = New System.Drawing.Size(333, 35)
        Me.IDBillMonthlyTB.TabIndex = 69
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.Azure
        Me.TabPage6.Controls.Add(Me.btnClearYearTax)
        Me.TabPage6.Controls.Add(Me.Label6)
        Me.TabPage6.Controls.Add(Me.btnCalcYearly)
        Me.TabPage6.Controls.Add(Me.TBYearlyRent)
        Me.TabPage6.Controls.Add(Me.Label3)
        Me.TabPage6.Controls.Add(Me.Label7)
        Me.TabPage6.Controls.Add(Me.IDBillYearlyTB)
        Me.TabPage6.Controls.Add(Me.TBYearlyTax)
        Me.TabPage6.Location = New System.Drawing.Point(4, 29)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(882, 910)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "Calculate yearly tax/rent"
        '
        'btnClearYearTax
        '
        Me.btnClearYearTax.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnClearYearTax.BackgroundImage = CType(resources.GetObject("btnClearYearTax.BackgroundImage"), System.Drawing.Image)
        Me.btnClearYearTax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearYearTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearYearTax.ForeColor = System.Drawing.Color.DimGray
        Me.btnClearYearTax.Location = New System.Drawing.Point(66, 346)
        Me.btnClearYearTax.Name = "btnClearYearTax"
        Me.btnClearYearTax.Size = New System.Drawing.Size(220, 66)
        Me.btnClearYearTax.TabIndex = 56
        Me.btnClearYearTax.Text = "Clear"
        Me.btnClearYearTax.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label6.Location = New System.Drawing.Point(63, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 30)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Yearly Rent"
        '
        'btnCalcYearly
        '
        Me.btnCalcYearly.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnCalcYearly.BackgroundImage = CType(resources.GetObject("btnCalcYearly.BackgroundImage"), System.Drawing.Image)
        Me.btnCalcYearly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalcYearly.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcYearly.ForeColor = System.Drawing.Color.DimGray
        Me.btnCalcYearly.Location = New System.Drawing.Point(417, 80)
        Me.btnCalcYearly.Name = "btnCalcYearly"
        Me.btnCalcYearly.Size = New System.Drawing.Size(220, 66)
        Me.btnCalcYearly.TabIndex = 70
        Me.btnCalcYearly.Text = "Calculate"
        Me.btnCalcYearly.UseVisualStyleBackColor = False
        '
        'TBYearlyRent
        '
        Me.TBYearlyRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBYearlyRent.Location = New System.Drawing.Point(257, 268)
        Me.TBYearlyRent.Name = "TBYearlyRent"
        Me.TBYearlyRent.Size = New System.Drawing.Size(333, 35)
        Me.TBYearlyRent.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label3.Location = New System.Drawing.Point(61, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 30)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Bill ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label7.Location = New System.Drawing.Point(63, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 30)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Yearly Tax"
        '
        'IDBillYearlyTB
        '
        Me.IDBillYearlyTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDBillYearlyTB.Location = New System.Drawing.Point(66, 111)
        Me.IDBillYearlyTB.Name = "IDBillYearlyTB"
        Me.IDBillYearlyTB.Size = New System.Drawing.Size(333, 35)
        Me.IDBillYearlyTB.TabIndex = 72
        '
        'TBYearlyTax
        '
        Me.TBYearlyTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBYearlyTax.Location = New System.Drawing.Point(257, 198)
        Me.TBYearlyTax.Name = "TBYearlyTax"
        Me.TBYearlyTax.Size = New System.Drawing.Size(333, 35)
        Me.TBYearlyTax.TabIndex = 75
        '
        'FormCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1924, 1036)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCalculator"
        Me.Text = "Bill Calculator "
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DGVBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Calc As Label
    Friend WithEvents btnEquals As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDecimal As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents LblShowCurrentCalc As Label
    Friend WithEvents TBTotal As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DGVBill As DataGridView
    Friend WithEvents btnBillDateSearch As Button
    Friend WithEvents LblBDateSearch As Label
    Friend WithEvents TBBillSearch As TextBox
    Friend WithEvents TBBillDateSearch As TextBox
    Friend WithEvents LblBSearch As Label
    Friend WithEvents btnBillSearch As Button
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btnClearBill As Button
    Friend WithEvents LblBillID As Label
    Friend WithEvents DateTimeBillDate As DateTimePicker
    Friend WithEvents LblCouncilTax As Label
    Friend WithEvents btnDeleteBill As Button
    Friend WithEvents LblElectricity As Label
    Friend WithEvents LblDate As Label
    Friend WithEvents LblGas As Label
    Friend WithEvents btnEditBill As Button
    Friend WithEvents LblWater As Label
    Friend WithEvents TBGas As TextBox
    Friend WithEvents TBTax As TextBox
    Friend WithEvents btnSaveBill As Button
    Friend WithEvents LblMobile As Label
    Friend WithEvents TBElectricity As TextBox
    Friend WithEvents TBBillID As TextBox
    Friend WithEvents TBRent As TextBox
    Friend WithEvents TBMobile As TextBox
    Friend WithEvents TBWater As TextBox
    Friend WithEvents LblRent As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents btnCalcMonthly As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents IDBillMonthlyTB As TextBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents btnCalcYearly As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents IDBillYearlyTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBMonthRent As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBMonthTax As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBYearlyRent As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBYearlyTax As TextBox
    Friend WithEvents btnClearMonthTax As Button
    Friend WithEvents btnClearYearTax As Button
    Friend WithEvents btnGenReceipt As Button
    Friend WithEvents btnRefreshDGVBill As Button
End Class
