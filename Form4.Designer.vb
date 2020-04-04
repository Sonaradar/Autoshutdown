<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As CCWin.SkinControl.Animation = New CCWin.SkinControl.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim Animation2 As CCWin.SkinControl.Animation = New CCWin.SkinControl.Animation()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StateManager = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SkinAnimator1 = New CCWin.SkinControl.SkinAnimator(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SkinButton2 = New CCWin.SkinControl.SkinButton()
        Me.SkinButton1 = New CCWin.SkinControl.SkinButton()
        Me.DemoBGM = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.SkinAnimator2 = New CCWin.SkinControl.SkinAnimator(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.ApiManager = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DemoBGM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.SkinAnimator1.SetDecoration(Me.Button1, CCWin.SkinControl.DecorationType.None)
        Me.SkinAnimator2.SetDecoration(Me.Button1, CCWin.SkinControl.DecorationType.None)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(-4, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 55)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "立即执行"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'StateManager
        '
        Me.StateManager.AutoSize = True
        Me.SkinAnimator1.SetDecoration(Me.StateManager, CCWin.SkinControl.DecorationType.None)
        Me.SkinAnimator2.SetDecoration(Me.StateManager, CCWin.SkinControl.DecorationType.None)
        Me.StateManager.Location = New System.Drawing.Point(559, 27)
        Me.StateManager.Name = "StateManager"
        Me.StateManager.Size = New System.Drawing.Size(46, 17)
        Me.StateManager.TabIndex = 10
        Me.StateManager.Text = "Label5"
        Me.StateManager.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 10000
        '
        'SkinAnimator1
        '
        Me.SkinAnimator1.AnimationType = CCWin.SkinControl.AnimationType.HorizSlide
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
        Animation1.TransparencyCoeff = 0!
        Me.SkinAnimator1.DefaultAnimation = Animation1
        Me.SkinAnimator1.MaxAnimationTime = 1000
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.ApiManager)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.SkinButton2)
        Me.Panel2.Controls.Add(Me.SkinButton1)
        Me.Panel2.Controls.Add(Me.DemoBGM)
        Me.SkinAnimator2.SetDecoration(Me.Panel2, CCWin.SkinControl.DecorationType.None)
        Me.SkinAnimator1.SetDecoration(Me.Panel2, CCWin.SkinControl.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1280, 720)
        Me.Panel2.TabIndex = 16
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.SkinAnimator1.SetDecoration(Me.PictureBox5, CCWin.SkinControl.DecorationType.None)
        Me.SkinAnimator2.SetDecoration(Me.PictureBox5, CCWin.SkinControl.DecorationType.None)
        Me.PictureBox5.Location = New System.Drawing.Point(121, 175)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(211, 68)
        Me.PictureBox5.TabIndex = 26
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.SkinAnimator1.SetDecoration(Me.Label7, CCWin.SkinControl.DecorationType.None)
        Me.SkinAnimator2.SetDecoration(Me.Label7, CCWin.SkinControl.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 614)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 105)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Version：4.2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mode：ShutDown"
        Me.Label7.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.SkinAnimator2.SetDecoration(Me.Panel1, CCWin.SkinControl.DecorationType.None)
        Me.SkinAnimator1.SetDecoration(Me.Panel1, CCWin.SkinControl.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(150, 243)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 392)
        Me.Panel1.TabIndex = 24
        Me.Panel1.Visible = False
        '
        'Label3
        '
        Me.SkinAnimator1.SetDecoration(Me.Label3, CCWin.SkinControl.DecorationType.None)
        Me.SkinAnimator2.SetDecoration(Me.Label3, CCWin.SkinControl.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(604, 200)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "需要立即执行/执行任务，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "请点击立即执行或等待软件自动执行。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "需要禁止任务执行请点击取消执行。"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.SkinAnimator1.SetDecoration(Me.Label2, CCWin.SkinControl.DecorationType.None)
        Me.SkinAnimator2.SetDecoration(Me.Label2, CCWin.SkinControl.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(606, 43)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "执行**任务"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.SkinAnimator1.SetDecoration(Me.Label6, CCWin.SkinControl.DecorationType.None)
        Me.SkinAnimator2.SetDecoration(Me.Label6, CCWin.SkinControl.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(378, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 103)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "秒 剩余"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label1
        '
        Me.SkinAnimator1.SetDecoration(Me.Label1, CCWin.SkinControl.DecorationType.None)
        Me.SkinAnimator2.SetDecoration(Me.Label1, CCWin.SkinControl.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 137)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "立即执行"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.SkinAnimator1.SetDecoration(Me.Label5, CCWin.SkinControl.DecorationType.None)
        Me.SkinAnimator2.SetDecoration(Me.Label5, CCWin.SkinControl.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1256, 43)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "ON DEMO MODE   Now Playing - FINE!!(ShirakamiFubuki)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.SkinAnimator1.SetDecoration(Me.Label4, CCWin.SkinControl.DecorationType.None)
        Me.SkinAnimator2.SetDecoration(Me.Label4, CCWin.SkinControl.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(1029, 411)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 50)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "剩余执行时间充足"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.SkinAnimator1.SetDecoration(Me.PictureBox4, CCWin.SkinControl.DecorationType.None)
        Me.SkinAnimator2.SetDecoration(Me.PictureBox4, CCWin.SkinControl.DecorationType.None)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(973, 411)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 22
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.SkinAnimator1.SetDecoration(Me.PictureBox3, CCWin.SkinControl.DecorationType.None)
        Me.SkinAnimator2.SetDecoration(Me.PictureBox3, CCWin.SkinControl.DecorationType.None)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(973, 299)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.SkinAnimator1.SetDecoration(Me.PictureBox2, CCWin.SkinControl.DecorationType.None)
        Me.SkinAnimator2.SetDecoration(Me.PictureBox2, CCWin.SkinControl.DecorationType.None)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(973, 355)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.SkinAnimator1.SetDecoration(Me.PictureBox1, CCWin.SkinControl.DecorationType.None)
        Me.SkinAnimator2.SetDecoration(Me.PictureBox1, CCWin.SkinControl.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(973, 243)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'SkinButton2
        '
        Me.SkinButton2.BackColor = System.Drawing.Color.Transparent
        Me.SkinButton2.BaseColor = System.Drawing.Color.Transparent
        Me.SkinButton2.BorderColor = System.Drawing.Color.White
        Me.SkinButton2.ControlState = CCWin.SkinClass.ControlState.Normal
        Me.SkinAnimator2.SetDecoration(Me.SkinButton2, CCWin.SkinControl.DecorationType.None)
        Me.SkinAnimator1.SetDecoration(Me.SkinButton2, CCWin.SkinControl.DecorationType.None)
        Me.SkinButton2.DownBack = Nothing
        Me.SkinButton2.DownBaseColor = System.Drawing.Color.DodgerBlue
        Me.SkinButton2.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SkinButton2.GlowColor = System.Drawing.Color.Aqua
        Me.SkinButton2.InnerBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SkinButton2.IsDrawGlass = False
        Me.SkinButton2.Location = New System.Drawing.Point(973, 467)
        Me.SkinButton2.MouseBack = Nothing
        Me.SkinButton2.Name = "SkinButton2"
        Me.SkinButton2.NormlBack = Nothing
        Me.SkinButton2.Size = New System.Drawing.Size(264, 99)
        Me.SkinButton2.TabIndex = 18
        Me.SkinButton2.Text = "取消执行"
        Me.SkinButton2.UseVisualStyleBackColor = False
        Me.SkinButton2.Visible = False
        '
        'SkinButton1
        '
        Me.SkinButton1.BackColor = System.Drawing.Color.Transparent
        Me.SkinButton1.BaseColor = System.Drawing.Color.Transparent
        Me.SkinButton1.BorderColor = System.Drawing.Color.White
        Me.SkinButton1.ControlState = CCWin.SkinClass.ControlState.Normal
        Me.SkinAnimator2.SetDecoration(Me.SkinButton1, CCWin.SkinControl.DecorationType.None)
        Me.SkinAnimator1.SetDecoration(Me.SkinButton1, CCWin.SkinControl.DecorationType.None)
        Me.SkinButton1.DownBack = Nothing
        Me.SkinButton1.DownBaseColor = System.Drawing.Color.DodgerBlue
        Me.SkinButton1.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SkinButton1.GlowColor = System.Drawing.Color.Aqua
        Me.SkinButton1.InnerBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SkinButton1.IsDrawGlass = False
        Me.SkinButton1.Location = New System.Drawing.Point(973, 572)
        Me.SkinButton1.MouseBack = Nothing
        Me.SkinButton1.Name = "SkinButton1"
        Me.SkinButton1.NormlBack = Nothing
        Me.SkinButton1.Size = New System.Drawing.Size(264, 99)
        Me.SkinButton1.TabIndex = 17
        Me.SkinButton1.Text = "立即执行"
        Me.SkinButton1.UseVisualStyleBackColor = False
        Me.SkinButton1.Visible = False
        '
        'DemoBGM
        '
        Me.SkinAnimator1.SetDecoration(Me.DemoBGM, CCWin.SkinControl.DecorationType.None)
        Me.DemoBGM.Enabled = True
        Me.DemoBGM.Location = New System.Drawing.Point(530, 203)
        Me.DemoBGM.Name = "DemoBGM"
        Me.DemoBGM.OcxState = CType(resources.GetObject("DemoBGM.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DemoBGM.Size = New System.Drawing.Size(44, 33)
        Me.DemoBGM.TabIndex = 12
        Me.DemoBGM.Visible = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.SkinAnimator1.SetDecoration(Me.AxWindowsMediaPlayer1, CCWin.SkinControl.DecorationType.None)
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(738, 434)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(74, 33)
        Me.AxWindowsMediaPlayer1.TabIndex = 11
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'SkinAnimator2
        '
        Me.SkinAnimator2.AnimationType = CCWin.SkinControl.AnimationType.Transparent
        Me.SkinAnimator2.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 1.0!
        Me.SkinAnimator2.DefaultAnimation = Animation2
        Me.SkinAnimator2.MaxAnimationTime = 500
        '
        'Timer3
        '
        Me.Timer3.Interval = 500
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 1000
        '
        'Timer5
        '
        Me.Timer5.Enabled = True
        Me.Timer5.Interval = 5
        '
        'ApiManager
        '
        Me.ApiManager.AutoSize = True
        Me.SkinAnimator1.SetDecoration(Me.ApiManager, CCWin.SkinControl.DecorationType.None)
        Me.SkinAnimator2.SetDecoration(Me.ApiManager, CCWin.SkinControl.DecorationType.None)
        Me.ApiManager.Location = New System.Drawing.Point(171, 107)
        Me.ApiManager.Name = "ApiManager"
        Me.ApiManager.Size = New System.Drawing.Size(15, 17)
        Me.ApiManager.TabIndex = 27
        Me.ApiManager.Text = "0"
        Me.ApiManager.Visible = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.StateManager)
        Me.Controls.Add(Me.Button1)
        Me.SkinAnimator1.SetDecoration(Me, CCWin.SkinControl.DecorationType.None)
        Me.SkinAnimator2.SetDecoration(Me, CCWin.SkinControl.DecorationType.None)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form4"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoShutDown"
        Me.TopMost = True
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DemoBGM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents StateManager As Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents SkinAnimator1 As CCWin.SkinControl.SkinAnimator
    Friend WithEvents SkinAnimator2 As CCWin.SkinControl.SkinAnimator
    Friend WithEvents DemoBGM As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SkinButton2 As CCWin.SkinControl.SkinButton
    Friend WithEvents SkinButton1 As CCWin.SkinControl.SkinButton
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Timer5 As Timer
    Friend WithEvents ApiManager As Label
End Class
