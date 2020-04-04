Public Class Form4
    Dim TotalTime As Integer
    Dim NowTime As Integer
    Dim Fps As Integer = 1

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EnableDoubleBuffering()
        TotalTime = 60
        If ApiManager.Text = "0" Then
            If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "TimeLimited.json") Then
                If Val(My.Computer.FileSystem.ReadAllText(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "TimeLimited.json", System.Text.Encoding.Default)) > 60 Then

                    TotalTime = Val(My.Computer.FileSystem.ReadAllText(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "TimeLimited.json", System.Text.Encoding.Default))
                End If
            Else


                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/TimeLimited.json", "60", False, System.Text.Encoding.Default)

            End If
        End If
        If ApiManager.Text = "1" Then
            TotalTime = Val(My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/API/Time.info", System.Text.Encoding.Default))
        End If
        If ApiManager.Text = "0" Then
            If StateManager.Text <> "4" Then
                Try
                    If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "BackGround.png") Then
                        Me.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "BackGround.png")
                    End If
                Catch ex As Exception

                End Try '
            End If
        Else
            Try
                If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "/API/Resources/BackGround.png") Then
                    Me.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "/API/Resources/BackGround.png")
                End If
            Catch ex As Exception

            End Try '
        End If
        Form_Reposition()
        StartUp()
        StartNotice()



    End Sub
    Public Sub Form_Reposition()
        'Me.Top = 150
        'Me.Left = 150
        'Me.Height = 720
        'Me.Width = 1280


        Me.Top = 0
        Me.Left = 0
        Me.Height = Screen.PrimaryScreen.Bounds.Height.ToString
        Me.Width = Screen.PrimaryScreen.Bounds.Width.ToString
        Panel2.Width = Me.Width
        Panel2.Height = Me.Height
        'GroupBox1.Height = Me.Height - 120
        'GroupBox1.Width = (Me.Width - 120) / 3
        'Label1.Width = GroupBox1.Width - 12
        'Label2.Width = GroupBox1.Width - 12
        'Label3.Width = GroupBox1.Width - 12
        'Label3.Height = GroupBox1.Height - (43 + 287 + 6)
        Panel1.Top = (Me.Height - Panel1.Height) / 2
        Panel1.Left = (Me.Width - 60 - SkinButton1.Width - Panel1.Width) / 2
        SkinButton1.Left = Me.Width - 60 - SkinButton1.Width
        SkinButton2.Left = Me.Width - 60 - SkinButton2.Width
        SkinButton1.Top = Me.Height - 60 - SkinButton1.Height
        SkinButton2.Top = Me.Height - 60 - SkinButton1.Height - SkinButton2.Height - 6
        PictureBox4.Left = SkinButton2.Left
        PictureBox4.Top = SkinButton2.Top - 6 - PictureBox4.Height
        Label4.Left = SkinButton2.Left + PictureBox4.Width + 6
        Label4.Top = SkinButton2.Top - 6 - PictureBox4.Height
        Label5.Width = Me.Width - 12
        Label7.Top = Me.Height - 60 - Label7.Height
        RunStateHud(2)
    End Sub
    Public Sub RunStateHud(ByVal State As Integer)
        If State = 1 Then
            PictureBox4.Image = PictureBox1.Image
            Label4.Text = "执行时间充足"
        End If
        If State = 2 Then
            PictureBox4.Image = PictureBox2.Image
            Label4.Text = "执行时间不充足" & vbCrLf & "需要继续使用请尽快取消"
        End If
        If State = 3 Then
            PictureBox4.Image = PictureBox3.Image
            Label4.Text = "任务超时" & vbCrLf & "将在10s后退出执行"
        End If
    End Sub
    Public Sub MainCountDown()


        If NowTime = 0 Then
            Label1.Text = “立即执行”

            RunProcess()
        Else

            If NowTime > 20 Then
                RunStateHud(1)
                Label1.Text = NowTime
            End If
            If NowTime <= 20 And NowTime > 0 Then
                If Int(NowTime) < 10 Then
                    Label1.Text = Replace("0" + Str(NowTime), " ", "")

                Else
                    Label1.Text = NowTime
                End If
            End If
            If NowTime = 20 Then
                RunStateHud(2)
            End If
            If NowTime < 0 And NowTime >= -10 Then
                Label1.Text = “立即执行”
            End If
            If NowTime < -10 Then
                CountDownError()
                Timer1.Enabled = False
            End If
        End If
        NowTime = NowTime - 1

    End Sub
    Public Sub CountDownError()
        RunStateHud(3)
        Label1.Text = “任务超时”
        Label2.Text = "即将终止本次任务"
        AxWindowsMediaPlayer1.URL = Application.StartupPath & "/Resources/Warning.wav"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        Timer2.Enabled = True
    End Sub
    Public Sub StartUp()
        If StateManager.Text = "1" Then
            Label2.Text = "执行关机任务"
        End If
        If StateManager.Text = "2" Then
            Label2.Text = "执行重启任务"
        End If
        If StateManager.Text = "3" Then
            Label2.Text = "执行休眠任务"
        End If
        If StateManager.Text = "4" Then
            Label2.Text = "执行关机任务[演示模式]"
        End If
        NowTime = TotalTime
        Timer1.Enabled = True
    End Sub
    Public Sub StartNotice()
        AxWindowsMediaPlayer1.URL = Application.StartupPath & "/Resources/Notice.mp3"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MainCountDown()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Dispose()

    End Sub
    Public Sub RunProcess()
        If StateManager.Text = "1" Then
            Shell("shutdown -s -t 1")
        End If
        If StateManager.Text = "2" Then
            Shell("shutdown -r -t 1")
        End If
        If StateManager.Text = "3" Then
            Shell("shutdown -h")
            Me.Dispose()
        End If
        If StateManager.Text = "4" Then
            Shell("shutdown -s -t 1")
        End If
    End Sub



    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim c As Color '新生成的颜色
        Dim r As Byte 'RED
        Dim g As Byte 'Green
        Dim b As Byte 'Blue
        Dim a As Byte 'Alpha 分量值
        a = Button1.BackColor.A
        r = Button1.BackColor.R
        g = Button1.BackColor.G
        b = Button1.BackColor.B
        Dim rnd As New Random '生成随机数
        Dim i As Integer
        i = rnd.Next(-255, 0)
        r = r + IIf(r + i > 255, -i, i)
        i = rnd.Next(-255, 0)
        g = g + IIf(g + i > 255, -i, i)
        i = rnd.Next(-255, 0)
        b = b + IIf(b + i > 255, -i, i)
        Label5.ForeColor = Color.FromArgb(a, r, g, b)

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Label7.Top = Me.Height - 60 - Label7.Height
        Dim StateText As String
        StateText = “Demo / Unkown Mode”
        If StateManager.Text = "1" Then
            StateText = "Shutdown"
        End If
        If StateManager.Text = "2" Then
            StateText = "Reboot"
        End If
        If StateManager.Text = "3" Then
            StateText = "Sleep"
        End If
        If StateManager.Text = "4" Then
            StateText = "Demo"
        End If
        Try
            Label7.Text = "AutoShutDown Info Hud" & vbCrLf & "Time：" & TimeOfDay & vbCrLf & "Version：" & Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString() & vbCrLf & "Mode：" & StateText & vbCrLf & "Music：" & DemoBGM.currentMedia.getItemInfo("Title") & " - " & DemoBGM.currentMedia.getItemInfo("Author") & vbCrLf & "Powered By Thunder Software"
        Catch ex As Exception
            Label7.Text = "AutoShutDown Info Hud" & vbCrLf & "Time：" & TimeOfDay & vbCrLf & "Version：" & “Unknow Version [” & ex.Message.ToString & “]” & vbCrLf & "Mode：" & StateText & vbCrLf & "Music：" & DemoBGM.currentMedia.getItemInfo("Title") & " - " & DemoBGM.currentMedia.getItemInfo("Author") & vbCrLf & "Powered By Thunder Software"
        End Try

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub SkinButton2_Click_1(sender As Object, e As EventArgs) Handles SkinButton2.Click
        If ApiManager.Text = "0" Then

            If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "Locker.lock") Then
                NoticeBoard("已设置禁止取消“ & vbCrLf & ”取消无效", 0, 3)
                Exit Sub
            Else
                NoticeBoard("定时任务取消“, 3, 3)
            End If
        End If

        If ApiManager.Text = "1" Then
            If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "/API/AntiExit.set") Then 'antiexit
                NoticeBoard("已设置禁止取消“ & vbCrLf & ”取消无效", 0, 3)
                Exit Sub
            Else
                NoticeBoard("定时任务取消“, 3, 3)
            End If
        End If



        Me.Dispose()
    End Sub

    Private Sub SkinButton1_Click(sender As Object, e As EventArgs) Handles SkinButton1.Click

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If Me.Opacity < 0.95 Then
            Me.Opacity = Me.Opacity + 0.01
        Else
            Me.Opacity = 1

            Timer5.Enabled = False
            SkinAnimator1.Show(Panel1)
            SkinAnimator1.Show(SkinButton1)
            SkinAnimator1.Show(SkinButton2)
            SkinAnimator1.Show(PictureBox4)
            SkinAnimator1.Show(Label4)
            SkinAnimator1.Show(Label7)

        End If
    End Sub



    Public Sub EnableDoubleBuffering()
        ' Set the value of the double-buffering style bits to true.
        Me.SetStyle(ControlStyles.DoubleBuffer _
     Or ControlStyles.UserPaint _
     Or ControlStyles.AllPaintingInWmPaint,
     True)
        Me.UpdateStyles()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub SkinButton1_DoubleClick(sender As Object, e As EventArgs) Handles SkinButton1.DoubleClick
        Label1.Text = “立即执行”
        AxWindowsMediaPlayer1.URL = Application.StartupPath & "/Resources/Warning.wav"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        RunProcess()
        NowTime = -1
        RunStateHud(2)
    End Sub
End Class