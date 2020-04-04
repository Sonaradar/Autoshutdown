<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.SkinButton2 = New CCWin.SkinControl.SkinButton()
        Me.SkinButton1 = New CCWin.SkinControl.SkinButton()
        Me.AnimationClock = New System.Windows.Forms.Timer(Me.components)
        Me.DemoBGM = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.StateManager = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.DemoBGM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SkinButton2
        '
        Me.SkinButton2.BackColor = System.Drawing.Color.Turquoise
        Me.SkinButton2.BaseColor = System.Drawing.Color.MediumSeaGreen
        Me.SkinButton2.BorderColor = System.Drawing.Color.Gray
        Me.SkinButton2.ControlState = CCWin.SkinClass.ControlState.Normal
        Me.SkinButton2.DownBack = Nothing
        Me.SkinButton2.DownBaseColor = System.Drawing.Color.DodgerBlue
        Me.SkinButton2.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SkinButton2.ForeColor = System.Drawing.Color.White
        Me.SkinButton2.GlowColor = System.Drawing.Color.Aqua
        Me.SkinButton2.InnerBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SkinButton2.IsDrawGlass = False
        Me.SkinButton2.Location = New System.Drawing.Point(959, 454)
        Me.SkinButton2.MouseBack = Nothing
        Me.SkinButton2.Name = "SkinButton2"
        Me.SkinButton2.NormlBack = Nothing
        Me.SkinButton2.RoundStyle = CCWin.SkinClass.RoundStyle.All
        Me.SkinButton2.Size = New System.Drawing.Size(264, 99)
        Me.SkinButton2.TabIndex = 20
        Me.SkinButton2.Text = "取消执行"
        Me.SkinButton2.UseVisualStyleBackColor = False
        '
        'SkinButton1
        '
        Me.SkinButton1.BackColor = System.Drawing.Color.Transparent
        Me.SkinButton1.BaseColor = System.Drawing.Color.MediumSeaGreen
        Me.SkinButton1.BorderColor = System.Drawing.Color.Gray
        Me.SkinButton1.ControlState = CCWin.SkinClass.ControlState.Normal
        Me.SkinButton1.DownBack = Nothing
        Me.SkinButton1.DownBaseColor = System.Drawing.Color.DodgerBlue
        Me.SkinButton1.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SkinButton1.ForeColor = System.Drawing.Color.White
        Me.SkinButton1.GlowColor = System.Drawing.Color.Aqua
        Me.SkinButton1.InnerBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SkinButton1.IsDrawGlass = False
        Me.SkinButton1.Location = New System.Drawing.Point(959, 559)
        Me.SkinButton1.MouseBack = Nothing
        Me.SkinButton1.Name = "SkinButton1"
        Me.SkinButton1.NormlBack = Nothing
        Me.SkinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All
        Me.SkinButton1.Size = New System.Drawing.Size(264, 99)
        Me.SkinButton1.TabIndex = 19
        Me.SkinButton1.Text = "立即执行"
        Me.SkinButton1.UseVisualStyleBackColor = False
        '
        'AnimationClock
        '
        Me.AnimationClock.Interval = 125
        '
        'DemoBGM
        '
        Me.DemoBGM.Enabled = True
        Me.DemoBGM.Location = New System.Drawing.Point(1179, 345)
        Me.DemoBGM.Name = "DemoBGM"
        Me.DemoBGM.OcxState = CType(resources.GetObject("DemoBGM.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DemoBGM.Size = New System.Drawing.Size(44, 33)
        Me.DemoBGM.TabIndex = 21
        Me.DemoBGM.Visible = False
        '
        'Timer4
        '
        Me.Timer4.Interval = 2500
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(10, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(219, 28)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "FPS Module Loading"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(52, 515)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(491, 104)
        Me.Panel1.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(283, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(388, 43)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "执行**任务"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(284, -4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(204, 103)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "秒 剩余"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, -17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 137)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "立即执行"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 10000
        '
        'StateManager
        '
        Me.StateManager.AutoSize = True
        Me.StateManager.Location = New System.Drawing.Point(296, 202)
        Me.StateManager.Name = "StateManager"
        Me.StateManager.Size = New System.Drawing.Size(15, 17)
        Me.StateManager.TabIndex = 26
        Me.StateManager.Text = "1"
        Me.StateManager.Visible = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(1032, 202)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(191, 102)
        Me.AxWindowsMediaPlayer1.TabIndex = 27
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1278, 718)
        Me.ControlBox = False
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.StateManager)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DemoBGM)
        Me.Controls.Add(Me.SkinButton2)
        Me.Controls.Add(Me.SkinButton1)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.DemoBGM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SkinButton2 As CCWin.SkinControl.SkinButton
    Friend WithEvents SkinButton1 As CCWin.SkinControl.SkinButton
    Friend WithEvents AnimationClock As Timer
    Friend WithEvents DemoBGM As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents StateManager As Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
End Class
