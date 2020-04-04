<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim Animation8 As CCWin.SkinControl.Animation = New CCWin.SkinControl.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SkinAnimator1 = New CCWin.SkinControl.SkinAnimator(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GifBox1 = New CCWin.SkinControl.GifBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SkinAnimator1.SetDecoration(Me.Label1, CCWin.SkinControl.DecorationType.None)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-4, 500)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Loading.. Please Wait"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Visible = False
        '
        'SkinAnimator1
        '
        Me.SkinAnimator1.AnimationType = CCWin.SkinControl.AnimationType.Transparent
        Me.SkinAnimator1.Cursor = Nothing
        Animation8.AnimateOnlyDifferences = True
        Animation8.BlindCoeff = CType(resources.GetObject("Animation8.BlindCoeff"), System.Drawing.PointF)
        Animation8.LeafCoeff = 0!
        Animation8.MaxTime = 1.0!
        Animation8.MinTime = 0!
        Animation8.MosaicCoeff = CType(resources.GetObject("Animation8.MosaicCoeff"), System.Drawing.PointF)
        Animation8.MosaicShift = CType(resources.GetObject("Animation8.MosaicShift"), System.Drawing.PointF)
        Animation8.MosaicSize = 0
        Animation8.Padding = New System.Windows.Forms.Padding(0)
        Animation8.RotateCoeff = 0!
        Animation8.RotateLimit = 0!
        Animation8.ScaleCoeff = CType(resources.GetObject("Animation8.ScaleCoeff"), System.Drawing.PointF)
        Animation8.SlideCoeff = CType(resources.GetObject("Animation8.SlideCoeff"), System.Drawing.PointF)
        Animation8.TimeCoeff = 0!
        Animation8.TransparencyCoeff = 1.0!
        Me.SkinAnimator1.DefaultAnimation = Animation8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.SkinAnimator1.SetDecoration(Me.Panel1, CCWin.SkinControl.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 58)
        Me.Panel1.TabIndex = 1
        '
        'GifBox1
        '
        Me.GifBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GifBox1.BorderColor = System.Drawing.Color.Transparent
        Me.GifBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.SkinAnimator1.SetDecoration(Me.GifBox1, CCWin.SkinControl.DecorationType.None)
        Me.GifBox1.Image = CType(resources.GetObject("GifBox1.Image"), System.Drawing.Image)
        Me.GifBox1.Location = New System.Drawing.Point(26, 11)
        Me.GifBox1.Name = "GifBox1"
        Me.GifBox1.Size = New System.Drawing.Size(36, 36)
        Me.GifBox1.TabIndex = 2
        '
        'Label2
        '
        Me.SkinAnimator1.SetDecoration(Me.Label2, CCWin.SkinControl.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(74, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "AutoShutdown"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.SkinAnimator1.SetDecoration(Me.Label3, CCWin.SkinControl.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(76, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Loading Software..."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 25
        '
        'Timer2
        '
        Me.Timer2.Interval = 1250
        '
        'Timer3
        '
        Me.Timer3.Interval = 2000
        '
        'Timer4
        '
        Me.Timer4.Interval = 1250
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(297, 58)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GifBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.SkinAnimator1.SetDecoration(Me, CCWin.SkinControl.DecorationType.None)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Highlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form3"
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SkinAnimator1 As CCWin.SkinControl.SkinAnimator
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GifBox1 As CCWin.SkinControl.GifBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer4 As Timer
End Class
