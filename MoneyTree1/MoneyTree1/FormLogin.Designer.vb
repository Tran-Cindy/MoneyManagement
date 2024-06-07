<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PBpadlock = New System.Windows.Forms.PictureBox()
        Me.PBmoneybag = New System.Windows.Forms.PictureBox()
        Me.TBID = New System.Windows.Forms.TextBox()
        Me.Lbl_ID = New System.Windows.Forms.Label()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.TB_Password = New System.Windows.Forms.TextBox()
        Me.TB_Username = New System.Windows.Forms.TextBox()
        Me.Lbl_Password = New System.Windows.Forms.Label()
        Me.Lbl_Username = New System.Windows.Forms.Label()
        Me.PBcherryblossom = New System.Windows.Forms.PictureBox()
        Me.PBcherryblossom2 = New System.Windows.Forms.PictureBox()
        Me.PBCoin8 = New System.Windows.Forms.PictureBox()
        Me.PBCoin7 = New System.Windows.Forms.PictureBox()
        Me.PBCoin4 = New System.Windows.Forms.PictureBox()
        Me.PBCoin3 = New System.Windows.Forms.PictureBox()
        Me.PBCoin2 = New System.Windows.Forms.PictureBox()
        Me.PB_Logo = New System.Windows.Forms.PictureBox()
        Me.PBCoin1 = New System.Windows.Forms.PictureBox()
        Me.PBCoin6 = New System.Windows.Forms.PictureBox()
        Me.PBCoin10 = New System.Windows.Forms.PictureBox()
        Me.PBCoin9 = New System.Windows.Forms.PictureBox()
        Me.CoinMover1 = New System.Windows.Forms.Timer(Me.components)
        Me.CoinMover3 = New System.Windows.Forms.Timer(Me.components)
        Me.CoinMover2 = New System.Windows.Forms.Timer(Me.components)
        Me.CoinMover4 = New System.Windows.Forms.Timer(Me.components)
        Me.PBCoin5 = New System.Windows.Forms.PictureBox()
        Me.CoinMover5 = New System.Windows.Forms.Timer(Me.components)
        Me.CoinMover6 = New System.Windows.Forms.Timer(Me.components)
        Me.CoinMover7 = New System.Windows.Forms.Timer(Me.components)
        Me.CoinMover8 = New System.Windows.Forms.Timer(Me.components)
        Me.CoinMover9 = New System.Windows.Forms.Timer(Me.components)
        Me.CoinMover10 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PBpadlock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBmoneybag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBcherryblossom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBcherryblossom2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCoin8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCoin7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCoin4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCoin3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCoin2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCoin1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCoin6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCoin10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCoin9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCoin5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.PBpadlock)
        Me.Panel1.Controls.Add(Me.PBmoneybag)
        Me.Panel1.Controls.Add(Me.TBID)
        Me.Panel1.Controls.Add(Me.Lbl_ID)
        Me.Panel1.Controls.Add(Me.btnLogIn)
        Me.Panel1.Controls.Add(Me.TB_Password)
        Me.Panel1.Controls.Add(Me.TB_Username)
        Me.Panel1.Controls.Add(Me.Lbl_Password)
        Me.Panel1.Controls.Add(Me.Lbl_Username)
        Me.Panel1.Location = New System.Drawing.Point(568, 252)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(877, 474)
        Me.Panel1.TabIndex = 1
        '
        'PBpadlock
        '
        Me.PBpadlock.BackColor = System.Drawing.Color.Transparent
        Me.PBpadlock.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.padlock
        Me.PBpadlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBpadlock.Location = New System.Drawing.Point(631, 249)
        Me.PBpadlock.Name = "PBpadlock"
        Me.PBpadlock.Size = New System.Drawing.Size(35, 35)
        Me.PBpadlock.TabIndex = 28
        Me.PBpadlock.TabStop = False
        '
        'PBmoneybag
        '
        Me.PBmoneybag.BackColor = System.Drawing.Color.Transparent
        Me.PBmoneybag.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.money_bag
        Me.PBmoneybag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBmoneybag.Location = New System.Drawing.Point(540, 312)
        Me.PBmoneybag.Name = "PBmoneybag"
        Me.PBmoneybag.Size = New System.Drawing.Size(69, 69)
        Me.PBmoneybag.TabIndex = 11
        Me.PBmoneybag.TabStop = False
        '
        'TBID
        '
        Me.TBID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBID.Location = New System.Drawing.Point(324, 108)
        Me.TBID.Name = "TBID"
        Me.TBID.Size = New System.Drawing.Size(297, 35)
        Me.TBID.TabIndex = 27
        '
        'Lbl_ID
        '
        Me.Lbl_ID.AutoSize = True
        Me.Lbl_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ID.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Lbl_ID.Location = New System.Drawing.Point(156, 113)
        Me.Lbl_ID.Name = "Lbl_ID"
        Me.Lbl_ID.Size = New System.Drawing.Size(48, 30)
        Me.Lbl_ID.TabIndex = 26
        Me.Lbl_ID.Text = "ID:"
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnLogIn.BackgroundImage = CType(resources.GetObject("btnLogIn.BackgroundImage"), System.Drawing.Image)
        Me.btnLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.Color.DimGray
        Me.btnLogIn.Location = New System.Drawing.Point(324, 312)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(210, 69)
        Me.btnLogIn.TabIndex = 25
        Me.btnLogIn.Text = "Log in"
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'TB_Password
        '
        Me.TB_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Password.Location = New System.Drawing.Point(324, 249)
        Me.TB_Password.Name = "TB_Password"
        Me.TB_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_Password.Size = New System.Drawing.Size(297, 35)
        Me.TB_Password.TabIndex = 24
        '
        'TB_Username
        '
        Me.TB_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Username.Location = New System.Drawing.Point(324, 172)
        Me.TB_Username.Name = "TB_Username"
        Me.TB_Username.Size = New System.Drawing.Size(297, 35)
        Me.TB_Username.TabIndex = 23
        '
        'Lbl_Password
        '
        Me.Lbl_Password.AutoSize = True
        Me.Lbl_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Password.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Lbl_Password.Location = New System.Drawing.Point(156, 250)
        Me.Lbl_Password.Name = "Lbl_Password"
        Me.Lbl_Password.Size = New System.Drawing.Size(142, 30)
        Me.Lbl_Password.TabIndex = 22
        Me.Lbl_Password.Text = "Password:"
        '
        'Lbl_Username
        '
        Me.Lbl_Username.AutoSize = True
        Me.Lbl_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Username.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Lbl_Username.Location = New System.Drawing.Point(156, 172)
        Me.Lbl_Username.Name = "Lbl_Username"
        Me.Lbl_Username.Size = New System.Drawing.Size(156, 30)
        Me.Lbl_Username.TabIndex = 21
        Me.Lbl_Username.Text = "Username: "
        '
        'PBcherryblossom
        '
        Me.PBcherryblossom.BackColor = System.Drawing.Color.Transparent
        Me.PBcherryblossom.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.sakura
        Me.PBcherryblossom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBcherryblossom.Location = New System.Drawing.Point(590, 76)
        Me.PBcherryblossom.Name = "PBcherryblossom"
        Me.PBcherryblossom.Size = New System.Drawing.Size(117, 117)
        Me.PBcherryblossom.TabIndex = 12
        Me.PBcherryblossom.TabStop = False
        '
        'PBcherryblossom2
        '
        Me.PBcherryblossom2.BackColor = System.Drawing.Color.Transparent
        Me.PBcherryblossom2.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.sakura
        Me.PBcherryblossom2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBcherryblossom2.Location = New System.Drawing.Point(1294, 76)
        Me.PBcherryblossom2.Name = "PBcherryblossom2"
        Me.PBcherryblossom2.Size = New System.Drawing.Size(117, 117)
        Me.PBcherryblossom2.TabIndex = 11
        Me.PBcherryblossom2.TabStop = False
        '
        'PBCoin8
        '
        Me.PBCoin8.BackColor = System.Drawing.Color.Transparent
        Me.PBCoin8.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.PBCoin8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBCoin8.Location = New System.Drawing.Point(1597, 406)
        Me.PBCoin8.Name = "PBCoin8"
        Me.PBCoin8.Size = New System.Drawing.Size(100, 100)
        Me.PBCoin8.TabIndex = 7
        Me.PBCoin8.TabStop = False
        '
        'PBCoin7
        '
        Me.PBCoin7.BackColor = System.Drawing.Color.Transparent
        Me.PBCoin7.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.PBCoin7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBCoin7.Location = New System.Drawing.Point(1755, 133)
        Me.PBCoin7.Name = "PBCoin7"
        Me.PBCoin7.Size = New System.Drawing.Size(100, 100)
        Me.PBCoin7.TabIndex = 6
        Me.PBCoin7.TabStop = False
        '
        'PBCoin4
        '
        Me.PBCoin4.BackColor = System.Drawing.Color.Transparent
        Me.PBCoin4.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.PBCoin4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBCoin4.Location = New System.Drawing.Point(168, 533)
        Me.PBCoin4.Name = "PBCoin4"
        Me.PBCoin4.Size = New System.Drawing.Size(100, 100)
        Me.PBCoin4.TabIndex = 5
        Me.PBCoin4.TabStop = False
        '
        'PBCoin3
        '
        Me.PBCoin3.BackColor = System.Drawing.Color.Transparent
        Me.PBCoin3.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.PBCoin3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBCoin3.Location = New System.Drawing.Point(462, 406)
        Me.PBCoin3.Name = "PBCoin3"
        Me.PBCoin3.Size = New System.Drawing.Size(100, 100)
        Me.PBCoin3.TabIndex = 3
        Me.PBCoin3.TabStop = False
        '
        'PBCoin2
        '
        Me.PBCoin2.BackColor = System.Drawing.Color.Transparent
        Me.PBCoin2.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.PBCoin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBCoin2.Location = New System.Drawing.Point(12, 230)
        Me.PBCoin2.Name = "PBCoin2"
        Me.PBCoin2.Size = New System.Drawing.Size(100, 100)
        Me.PBCoin2.TabIndex = 2
        Me.PBCoin2.TabStop = False
        '
        'PB_Logo
        '
        Me.PB_Logo.BackgroundImage = CType(resources.GetObject("PB_Logo.BackgroundImage"), System.Drawing.Image)
        Me.PB_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_Logo.Location = New System.Drawing.Point(729, 76)
        Me.PB_Logo.Name = "PB_Logo"
        Me.PB_Logo.Size = New System.Drawing.Size(539, 117)
        Me.PB_Logo.TabIndex = 0
        Me.PB_Logo.TabStop = False
        '
        'PBCoin1
        '
        Me.PBCoin1.BackColor = System.Drawing.Color.Transparent
        Me.PBCoin1.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.PBCoin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBCoin1.Location = New System.Drawing.Point(322, -54)
        Me.PBCoin1.Name = "PBCoin1"
        Me.PBCoin1.Size = New System.Drawing.Size(100, 100)
        Me.PBCoin1.TabIndex = 13
        Me.PBCoin1.TabStop = False
        '
        'PBCoin6
        '
        Me.PBCoin6.BackColor = System.Drawing.Color.Transparent
        Me.PBCoin6.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.PBCoin6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBCoin6.Location = New System.Drawing.Point(1451, -31)
        Me.PBCoin6.Name = "PBCoin6"
        Me.PBCoin6.Size = New System.Drawing.Size(100, 100)
        Me.PBCoin6.TabIndex = 14
        Me.PBCoin6.TabStop = False
        '
        'PBCoin10
        '
        Me.PBCoin10.BackColor = System.Drawing.Color.Transparent
        Me.PBCoin10.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.PBCoin10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBCoin10.Location = New System.Drawing.Point(1624, 976)
        Me.PBCoin10.Name = "PBCoin10"
        Me.PBCoin10.Size = New System.Drawing.Size(100, 100)
        Me.PBCoin10.TabIndex = 15
        Me.PBCoin10.TabStop = False
        '
        'PBCoin9
        '
        Me.PBCoin9.BackColor = System.Drawing.Color.Transparent
        Me.PBCoin9.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.PBCoin9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBCoin9.Location = New System.Drawing.Point(1871, 533)
        Me.PBCoin9.Name = "PBCoin9"
        Me.PBCoin9.Size = New System.Drawing.Size(100, 100)
        Me.PBCoin9.TabIndex = 19
        Me.PBCoin9.TabStop = False
        '
        'CoinMover1
        '
        Me.CoinMover1.Enabled = True
        Me.CoinMover1.Interval = 10
        '
        'CoinMover3
        '
        Me.CoinMover3.Enabled = True
        Me.CoinMover3.Interval = 10
        '
        'CoinMover2
        '
        Me.CoinMover2.Enabled = True
        Me.CoinMover2.Interval = 10
        '
        'CoinMover4
        '
        Me.CoinMover4.Enabled = True
        Me.CoinMover4.Interval = 10
        '
        'PBCoin5
        '
        Me.PBCoin5.BackColor = System.Drawing.Color.Transparent
        Me.PBCoin5.BackgroundImage = Global.MoneyTree1.My.Resources.Resources.dollar
        Me.PBCoin5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBCoin5.Location = New System.Drawing.Point(33, 976)
        Me.PBCoin5.Name = "PBCoin5"
        Me.PBCoin5.Size = New System.Drawing.Size(100, 100)
        Me.PBCoin5.TabIndex = 20
        Me.PBCoin5.TabStop = False
        '
        'CoinMover5
        '
        Me.CoinMover5.Enabled = True
        Me.CoinMover5.Interval = 10
        '
        'CoinMover6
        '
        Me.CoinMover6.Enabled = True
        Me.CoinMover6.Interval = 10
        '
        'CoinMover7
        '
        Me.CoinMover7.Enabled = True
        Me.CoinMover7.Interval = 10
        '
        'CoinMover8
        '
        Me.CoinMover8.Enabled = True
        Me.CoinMover8.Interval = 10
        '
        'CoinMover9
        '
        Me.CoinMover9.Enabled = True
        Me.CoinMover9.Interval = 10
        '
        'CoinMover10
        '
        Me.CoinMover10.Enabled = True
        Me.CoinMover10.Interval = 10
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1924, 1036)
        Me.Controls.Add(Me.PBCoin5)
        Me.Controls.Add(Me.PBCoin9)
        Me.Controls.Add(Me.PBCoin10)
        Me.Controls.Add(Me.PBCoin6)
        Me.Controls.Add(Me.PBCoin1)
        Me.Controls.Add(Me.PBcherryblossom)
        Me.Controls.Add(Me.PBcherryblossom2)
        Me.Controls.Add(Me.PBCoin8)
        Me.Controls.Add(Me.PBCoin7)
        Me.Controls.Add(Me.PBCoin4)
        Me.Controls.Add(Me.PBCoin3)
        Me.Controls.Add(Me.PBCoin2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PB_Logo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLogin"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBpadlock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBmoneybag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBcherryblossom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBcherryblossom2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCoin8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCoin7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCoin4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCoin3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCoin2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCoin1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCoin6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCoin10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCoin9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCoin5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PB_Logo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lbl_Password As Label
    Friend WithEvents Lbl_Username As Label
    Friend WithEvents TB_Username As TextBox
    Friend WithEvents TB_Password As TextBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents TBID As TextBox
    Friend WithEvents Lbl_ID As Label
    Friend WithEvents PBmoneybag As PictureBox
    Friend WithEvents PBCoin2 As PictureBox
    Friend WithEvents PBCoin3 As PictureBox
    Friend WithEvents PBCoin4 As PictureBox
    Friend WithEvents PBCoin7 As PictureBox
    Friend WithEvents PBCoin8 As PictureBox
    Friend WithEvents PBcherryblossom2 As PictureBox
    Friend WithEvents PBcherryblossom As PictureBox
    Friend WithEvents PBCoin1 As PictureBox
    Friend WithEvents PBCoin6 As PictureBox
    Friend WithEvents PBCoin10 As PictureBox
    Friend WithEvents PBCoin9 As PictureBox
    Friend WithEvents PBpadlock As PictureBox
    Friend WithEvents CoinMover1 As Timer
    Friend WithEvents CoinMover3 As Timer
    Friend WithEvents CoinMover2 As Timer
    Friend WithEvents CoinMover4 As Timer
    Friend WithEvents PBCoin5 As PictureBox
    Friend WithEvents CoinMover5 As Timer
    Friend WithEvents CoinMover6 As Timer
    Friend WithEvents CoinMover7 As Timer
    Friend WithEvents CoinMover8 As Timer
    Friend WithEvents CoinMover9 As Timer
    Friend WithEvents CoinMover10 As Timer
End Class
