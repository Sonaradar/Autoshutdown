<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim Animation1 As CCWin.SkinControl.Animation = New CCWin.SkinControl.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SkinButton1 = New CCWin.SkinControl.SkinButton()
        Me.SkinButton2 = New CCWin.SkinControl.SkinButton()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SkinAnimator1 = New CCWin.SkinControl.SkinAnimator(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RType = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DemoBGM = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DemoBGM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.SkinAnimator1.SetDecoration(Me.Label1, CCWin.SkinControl.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(1500, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "60秒内即将关机！"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.SkinAnimator1.SetDecoration(Me.Label2, CCWin.SkinControl.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(998, 63)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "即将执行以下任务"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SkinButton1
        '
        Me.SkinButton1.BackColor = System.Drawing.Color.Transparent
        Me.SkinButton1.BaseColor = System.Drawing.Color.Transparent
        Me.SkinButton1.BorderColor = System.Drawing.Color.White
        Me.SkinButton1.ControlState = CCWin.SkinClass.ControlState.Normal
        Me.SkinAnimator1.SetDecoration(Me.SkinButton1, CCWin.SkinControl.DecorationType.None)
        Me.SkinButton1.DownBack = Nothing
        Me.SkinButton1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SkinButton1.IsDrawGlass = False
        Me.SkinButton1.Location = New System.Drawing.Point(320, 426)
        Me.SkinButton1.MouseBack = Nothing
        Me.SkinButton1.MouseBaseColor = System.Drawing.Color.DodgerBlue
        Me.SkinButton1.Name = "SkinButton1"
        Me.SkinButton1.NormlBack = Nothing
        Me.SkinButton1.Size = New System.Drawing.Size(384, 41)
        Me.SkinButton1.TabIndex = 2
        Me.SkinButton1.Text = "立即执行"
        Me.SkinButton1.UseVisualStyleBackColor = False
        '
        'SkinButton2
        '
        Me.SkinButton2.BackColor = System.Drawing.Color.Transparent
        Me.SkinButton2.BaseColor = System.Drawing.Color.Transparent
        Me.SkinButton2.BorderColor = System.Drawing.Color.White
        Me.SkinButton2.ControlState = CCWin.SkinClass.ControlState.Normal
        Me.SkinAnimator1.SetDecoration(Me.SkinButton2, CCWin.SkinControl.DecorationType.None)
        Me.SkinButton2.DownBack = Nothing
        Me.SkinButton2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SkinButton2.IsDrawGlass = False
        Me.SkinButton2.Location = New System.Drawing.Point(320, 473)
        Me.SkinButton2.MouseBack = Nothing
        Me.SkinButton2.MouseBaseColor = System.Drawing.Color.DodgerBlue
        Me.SkinButton2.Name = "SkinButton2"
        Me.SkinButton2.NormlBack = Nothing
        Me.SkinButton2.Size = New System.Drawing.Size(384, 41)
        Me.SkinButton2.TabIndex = 3
        Me.SkinButton2.Text = "取消执行"
        Me.SkinButton2.UseVisualStyleBackColor = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.SkinAnimator1.SetDecoration(Me.AxWindowsMediaPlayer1, CCWin.SkinControl.DecorationType.None)
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(20, 60)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(75, 23)
        Me.AxWindowsMediaPlayer1.TabIndex = 4
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Label3
        '
        Me.SkinAnimator1.SetDecoration(Me.Label3, CCWin.SkinControl.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(317, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(387, 43)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "执行++任务"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
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
        '
        'Label4
        '
        Me.SkinAnimator1.SetDecoration(Me.Label4, CCWin.SkinControl.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(317, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(303, 72)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "0"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.SkinAnimator1.SetDecoration(Me.Label5, CCWin.SkinControl.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(626, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 72)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "秒 剩余"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RType
        '
        Me.RType.AutoSize = True
        Me.SkinAnimator1.SetDecoration(Me.RType, CCWin.SkinControl.DecorationType.None)
        Me.RType.Location = New System.Drawing.Point(23, 17)
        Me.RType.Name = "RType"
        Me.RType.Size = New System.Drawing.Size(0, 20)
        Me.RType.TabIndex = 8
        Me.RType.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.DemoBGM)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.SkinButton1)
        Me.Panel1.Controls.Add(Me.SkinButton2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.SkinAnimator1.SetDecoration(Me.Panel1, CCWin.SkinControl.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 576)
        Me.Panel1.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.SkinAnimator1.SetDecoration(Me.Label7, CCWin.SkinControl.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 28)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "DEMO MODE"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Visible = False
        '
        'DemoBGM
        '
        Me.SkinAnimator1.SetDecoration(Me.DemoBGM, CCWin.SkinControl.DecorationType.None)
        Me.DemoBGM.Enabled = True
        Me.DemoBGM.Location = New System.Drawing.Point(490, 272)
        Me.DemoBGM.Name = "DemoBGM"
        Me.DemoBGM.OcxState = CType(resources.GetObject("DemoBGM.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DemoBGM.Size = New System.Drawing.Size(44, 33)
        Me.DemoBGM.TabIndex = 13
        Me.DemoBGM.Visible = False
        '
        'Label6
        '
        Me.SkinAnimator1.SetDecoration(Me.Label6, CCWin.SkinControl.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(317, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(387, 159)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "如需要继续执行" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "请等待程序自动运行或手动点击立即执行" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "如需要继续使用请点击取消执行"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer3
        '
        Me.Timer3.Interval = 2500
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1022, 574)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RType)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.Label1)
        Me.SkinAnimator1.SetDecoration(Me, CCWin.SkinControl.DecorationType.None)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DemoBGM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SkinButton1 As CCWin.SkinControl.SkinButton
    Friend WithEvents SkinButton2 As CCWin.SkinControl.SkinButton
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents SkinAnimator1 As CCWin.SkinControl.SkinAnimator
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RType As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents DemoBGM As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer3 As Timer
End Class
