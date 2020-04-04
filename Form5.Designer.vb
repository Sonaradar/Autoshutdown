<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Dim Animation1 As CCWin.SkinControl.Animation = New CCWin.SkinControl.Animation()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnReg = New CCWin.SkinControl.SkinButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRegEmail = New CCWin.SkinControl.SkinTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRegPwd = New CCWin.SkinControl.SkinTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRegUserName = New CCWin.SkinControl.SkinTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SkinAnimator1 = New CCWin.SkinControl.SkinAnimator(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.LinkLabel2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnReg)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtRegEmail)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtRegPwd)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtRegUserName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.SkinAnimator1.SetDecoration(Me.Panel1, CCWin.SkinControl.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 579)
        Me.Panel1.TabIndex = 0
        '
        'LinkLabel2
        '
        Me.SkinAnimator1.SetDecoration(Me.LinkLabel2, CCWin.SkinControl.DecorationType.None)
        Me.LinkLabel2.LinkColor = System.Drawing.Color.White
        Me.LinkLabel2.Location = New System.Drawing.Point(218, 438)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(582, 42)
        Me.LinkLabel2.TabIndex = 37
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "我先想想，下次注册"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.SkinAnimator1.SetDecoration(Me.Label5, CCWin.SkinControl.DecorationType.None)
        Me.Label5.Location = New System.Drawing.Point(12, 461)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(629, 85)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Thunder Software 用户服务协议" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1.因本软件产生的任何后果请用户自行负责，我方不负责任何责任的承担。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2.Thunder Software 将" &
    "被允许收集用户信息，我们将使用用户信息改进我们的软件，并将对您的用户信息妥善保管。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3.本软件仅供学习交流使用，免费提供给用户使用，仅限个人级用户。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "我们将" &
    "不断为各位用户提供更加完善的定时服务。"
        Me.Label5.Visible = False
        '
        'btnReg
        '
        Me.btnReg.BackColor = System.Drawing.Color.Transparent
        Me.btnReg.BaseColor = System.Drawing.Color.Transparent
        Me.btnReg.BorderColor = System.Drawing.Color.White
        Me.btnReg.ControlState = CCWin.SkinClass.ControlState.Normal
        Me.SkinAnimator1.SetDecoration(Me.btnReg, CCWin.SkinControl.DecorationType.None)
        Me.btnReg.DownBack = Nothing
        Me.btnReg.DownBaseColor = System.Drawing.Color.DodgerBlue
        Me.btnReg.Enabled = False
        Me.btnReg.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnReg.GlowColor = System.Drawing.Color.Aqua
        Me.btnReg.InnerBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnReg.IsDrawGlass = False
        Me.btnReg.Location = New System.Drawing.Point(221, 380)
        Me.btnReg.MouseBack = Nothing
        Me.btnReg.Name = "btnReg"
        Me.btnReg.NormlBack = Nothing
        Me.btnReg.Size = New System.Drawing.Size(579, 55)
        Me.btnReg.TabIndex = 19
        Me.btnReg.Text = "注册账号"
        Me.btnReg.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.SkinAnimator1.SetDecoration(Me.CheckBox1, CCWin.SkinControl.DecorationType.None)
        Me.CheckBox1.Location = New System.Drawing.Point(221, 328)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(579, 46)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "我已阅读用户协议并遵守用户协议" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "勾选后即可注册"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.SkinAnimator1.SetDecoration(Me.Label4, CCWin.SkinControl.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(217, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "E-Mall 邮箱地址"
        '
        'txtRegEmail
        '
        Me.txtRegEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRegEmail.BackColor = System.Drawing.Color.Transparent
        Me.SkinAnimator1.SetDecoration(Me.txtRegEmail, CCWin.SkinControl.DecorationType.None)
        Me.txtRegEmail.DownBack = Nothing
        Me.txtRegEmail.Icon = Nothing
        Me.txtRegEmail.IconIsButton = False
        Me.txtRegEmail.IconMouseState = CCWin.SkinClass.ControlState.Normal
        Me.txtRegEmail.IsPasswordChat = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegEmail.IsSystemPasswordChar = False
        Me.txtRegEmail.Lines = New String(-1) {}
        Me.txtRegEmail.Location = New System.Drawing.Point(221, 282)
        Me.txtRegEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.txtRegEmail.MaxLength = 32767
        Me.txtRegEmail.MinimumSize = New System.Drawing.Size(28, 28)
        Me.txtRegEmail.MouseBack = Nothing
        Me.txtRegEmail.MouseState = CCWin.SkinClass.ControlState.Normal
        Me.txtRegEmail.Multiline = False
        Me.txtRegEmail.Name = "txtRegEmail"
        Me.txtRegEmail.NormlBack = Nothing
        Me.txtRegEmail.Padding = New System.Windows.Forms.Padding(5)
        Me.txtRegEmail.ReadOnly = False
        Me.txtRegEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRegEmail.Size = New System.Drawing.Size(579, 28)
        '
        '
        '
        Me.txtRegEmail.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRegEmail.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRegEmail.SkinTxt.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.txtRegEmail.SkinTxt.Location = New System.Drawing.Point(5, 5)
        Me.txtRegEmail.SkinTxt.Name = "BaseText"
        Me.txtRegEmail.SkinTxt.Size = New System.Drawing.Size(569, 18)
        Me.txtRegEmail.SkinTxt.TabIndex = 0
        Me.txtRegEmail.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.txtRegEmail.SkinTxt.WaterText = "请务必输入一个能够联系您的有效邮箱"
        Me.txtRegEmail.TabIndex = 5
        Me.txtRegEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtRegEmail.WaterColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.txtRegEmail.WaterText = "请务必输入一个能够联系您的有效邮箱"
        Me.txtRegEmail.WordWrap = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.SkinAnimator1.SetDecoration(Me.Label3, CCWin.SkinControl.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(217, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password 密码"
        '
        'txtRegPwd
        '
        Me.txtRegPwd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRegPwd.BackColor = System.Drawing.Color.Transparent
        Me.SkinAnimator1.SetDecoration(Me.txtRegPwd, CCWin.SkinControl.DecorationType.None)
        Me.txtRegPwd.DownBack = Nothing
        Me.txtRegPwd.Icon = Nothing
        Me.txtRegPwd.IconIsButton = False
        Me.txtRegPwd.IconMouseState = CCWin.SkinClass.ControlState.Normal
        Me.txtRegPwd.IsPasswordChat = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtRegPwd.IsSystemPasswordChar = True
        Me.txtRegPwd.Lines = New String(-1) {}
        Me.txtRegPwd.Location = New System.Drawing.Point(221, 213)
        Me.txtRegPwd.Margin = New System.Windows.Forms.Padding(0)
        Me.txtRegPwd.MaxLength = 32767
        Me.txtRegPwd.MinimumSize = New System.Drawing.Size(28, 28)
        Me.txtRegPwd.MouseBack = Nothing
        Me.txtRegPwd.MouseState = CCWin.SkinClass.ControlState.Normal
        Me.txtRegPwd.Multiline = False
        Me.txtRegPwd.Name = "txtRegPwd"
        Me.txtRegPwd.NormlBack = Nothing
        Me.txtRegPwd.Padding = New System.Windows.Forms.Padding(5)
        Me.txtRegPwd.ReadOnly = False
        Me.txtRegPwd.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRegPwd.Size = New System.Drawing.Size(579, 28)
        '
        '
        '
        Me.txtRegPwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRegPwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRegPwd.SkinTxt.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.txtRegPwd.SkinTxt.Location = New System.Drawing.Point(5, 5)
        Me.txtRegPwd.SkinTxt.Name = "BaseText"
        Me.txtRegPwd.SkinTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtRegPwd.SkinTxt.Size = New System.Drawing.Size(569, 18)
        Me.txtRegPwd.SkinTxt.TabIndex = 0
        Me.txtRegPwd.SkinTxt.UseSystemPasswordChar = True
        Me.txtRegPwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.txtRegPwd.SkinTxt.WaterText = "请输入密码"
        Me.txtRegPwd.TabIndex = 3
        Me.txtRegPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtRegPwd.WaterColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.txtRegPwd.WaterText = "请输入密码"
        Me.txtRegPwd.WordWrap = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.SkinAnimator1.SetDecoration(Me.Label2, CCWin.SkinControl.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(217, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Account 用户名"
        '
        'txtRegUserName
        '
        Me.txtRegUserName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRegUserName.BackColor = System.Drawing.Color.Transparent
        Me.SkinAnimator1.SetDecoration(Me.txtRegUserName, CCWin.SkinControl.DecorationType.None)
        Me.txtRegUserName.DownBack = Nothing
        Me.txtRegUserName.Icon = Nothing
        Me.txtRegUserName.IconIsButton = False
        Me.txtRegUserName.IconMouseState = CCWin.SkinClass.ControlState.Normal
        Me.txtRegUserName.IsPasswordChat = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegUserName.IsSystemPasswordChar = False
        Me.txtRegUserName.Lines = New String(-1) {}
        Me.txtRegUserName.Location = New System.Drawing.Point(221, 148)
        Me.txtRegUserName.Margin = New System.Windows.Forms.Padding(0)
        Me.txtRegUserName.MaxLength = 32767
        Me.txtRegUserName.MinimumSize = New System.Drawing.Size(28, 28)
        Me.txtRegUserName.MouseBack = Nothing
        Me.txtRegUserName.MouseState = CCWin.SkinClass.ControlState.Normal
        Me.txtRegUserName.Multiline = False
        Me.txtRegUserName.Name = "txtRegUserName"
        Me.txtRegUserName.NormlBack = Nothing
        Me.txtRegUserName.Padding = New System.Windows.Forms.Padding(5)
        Me.txtRegUserName.ReadOnly = False
        Me.txtRegUserName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRegUserName.Size = New System.Drawing.Size(579, 28)
        '
        '
        '
        Me.txtRegUserName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRegUserName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRegUserName.SkinTxt.Font = New System.Drawing.Font("微软雅黑", 9.75!)
        Me.txtRegUserName.SkinTxt.Location = New System.Drawing.Point(5, 5)
        Me.txtRegUserName.SkinTxt.Name = "BaseText"
        Me.txtRegUserName.SkinTxt.Size = New System.Drawing.Size(569, 18)
        Me.txtRegUserName.SkinTxt.TabIndex = 0
        Me.txtRegUserName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.txtRegUserName.SkinTxt.WaterText = "请创建一个用户名"
        Me.txtRegUserName.TabIndex = 1
        Me.txtRegUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtRegUserName.WaterColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.txtRegUserName.WaterText = "请创建一个用户名"
        Me.txtRegUserName.WordWrap = True
        '
        'Label1
        '
        Me.SkinAnimator1.SetDecoration(Me.Label1, CCWin.SkinControl.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(998, 93)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome To Thunder Software"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SkinAnimator1
        '
        Me.SkinAnimator1.AnimationType = CCWin.SkinControl.AnimationType.Transparent
        Me.SkinAnimator1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 1.0!
        Me.SkinAnimator1.DefaultAnimation = Animation1
        Me.SkinAnimator1.MaxAnimationTime = 1000
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1022, 574)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.SkinAnimator1.SetDecoration(Me, CCWin.SkinControl.DecorationType.None)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRegEmail As CCWin.SkinControl.SkinTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRegPwd As CCWin.SkinControl.SkinTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRegUserName As CCWin.SkinControl.SkinTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReg As CCWin.SkinControl.SkinButton
    Friend WithEvents Label5 As Label
    Friend WithEvents SkinAnimator1 As CCWin.SkinControl.SkinAnimator
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
