Public Class Form6
    Dim TotalTime As Integer = 60
    Dim NowTime As Integer
    Dim Fps As Integer = 1
    Dim DisposeState As Boolean = False
    Public Function FileName（ByVal CodeName As String） As String
        Dim ProcessName As String
        ProcessName = CodeName
        If Len(ProcessName) < 10 Then
            Do Until Len(ProcessName) = 10
                ProcessName = "0" & ProcessName
            Loop
        End If
        FileName = ProcessName
    End Function
    Public Sub VideoManager()
        Dim File As String
        File = FileName(Str(Fps).Replace(" ", "")) & ".jpg"

        If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "Resources/Animation/" & File) Then
            Me.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "Resources/Animation/" & File)
        Else
            'AnimationClock.Enabled = False

            Beep()
        End If
        Fps = Fps + 1
        Label5.Text = "FPS Total：" & Fps & “   ” & Int(1000 / AnimationClock.Interval) & "Fps/S"
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
            Label2.Text = "演示模式"
            Label6.Text = "秒 执行关机"
        End If
        NowTime = TotalTime

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Me.Height = Screen.PrimaryScreen.Bounds.Height.ToString
        Me.Width = Screen.PrimaryScreen.Bounds.Width.ToString
        If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "TimeLimited.json") Then
            If Val(My.Computer.FileSystem.ReadAllText(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "TimeLimited.json", System.Text.Encoding.Default)) > 60 Then
                TotalTime = Val(My.Computer.FileSystem.ReadAllText(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "TimeLimited.json", System.Text.Encoding.Default))
            End If
        Else


            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/TimeLimited.json", "60", False, System.Text.Encoding.Default)

        End If

        'Me.Top = 200
        'Me.Left = 200
        'Me.Height = 720
        'Me.Width = 1280


        SkinButton1.Left = Me.Width - 60 - SkinButton1.Width
        SkinButton2.Left = Me.Width - 60 - SkinButton2.Width
        SkinButton1.Top = Me.Height - 60 - SkinButton1.Height
        SkinButton2.Top = Me.Height - 60 - SkinButton1.Height - SkinButton2.Height - 6
        Label5.Width = Me.Width - 12
        Panel1.Top = Me.Height - 60 - Panel1.Height
        Panel1.Left = 60
        EnableDoubleBuffering()
        StartUp()

        If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "Resources/Animation/FPS.json") Then
            If Int(My.Computer.FileSystem.ReadAllText(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "Resources/Animation/FPS.json", System.Text.Encoding.Default)) > 0 Then
                AnimationClock.Interval = Int(1000 / Int(My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/Resources/Animation/FPS.json", System.Text.Encoding.Default)))
            End If
        Else
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/Resources/Animation/FPS.json", "8", False, System.Text.Encoding.Default)
        End If
        Timer4.Enabled = True

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

        AnimationClock.Enabled = True
        Timer4.Enabled = False

        AxWindowsMediaPlayer1.URL = Application.StartupPath & "/Resources/Notice.mp3"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        Timer1.Enabled = True
        Form4.DemoBGM.URL = Application.StartupPath & "/Resources/Animation/DemoBGM.mp3"
        Form4.DemoBGM.Ctlcontrols.play()
    End Sub

    Private Sub AnimationClock_Tick_1(sender As Object, e As EventArgs) Handles AnimationClock.Tick





        VideoManager()


    End Sub

    Private Sub SkinButton2_Click(sender As Object, e As EventArgs) Handles SkinButton2.Click
        Try
            Me.Dispose()
        Catch ex As Exception
            End
        End Try

    End Sub
    Public Sub EnableDoubleBuffering()
        ' Set the value of the double-buffering style bits to true.
        Me.SetStyle(ControlStyles.DoubleBuffer _
     Or ControlStyles.UserPaint _
     Or ControlStyles.AllPaintingInWmPaint,
     True)
        Me.UpdateStyles()
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
        End If
        If StateManager.Text = "4" Then
            Shell("shutdown -s -t 1")
        End If
    End Sub
    Public Sub MainCountDown()

        If NowTime = 0 Then
            Label1.Text = “立即执行”
            AxWindowsMediaPlayer1.URL = Application.StartupPath & "/Resources/Warning.wav"
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            RunProcess()
        Else
            If NowTime = 20 Then

                Label1.Text = NowTime
                AxWindowsMediaPlayer1.URL = Application.StartupPath & "/Resources/Warning.wav"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            End If
            If NowTime = 10 Then
                AxWindowsMediaPlayer1.URL = Application.StartupPath & "/Resources/Warning.wav"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            End If
            If NowTime = 15 Then
                AxWindowsMediaPlayer1.URL = Application.StartupPath & "/Resources/Warning.wav"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            End If
            If NowTime = 5 Then
                AxWindowsMediaPlayer1.URL = Application.StartupPath & "/Resources/Warning.wav"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            End If
            If NowTime = 3 Then
                AxWindowsMediaPlayer1.URL = Application.StartupPath & "/Resources/Warning.wav"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            End If
            If NowTime = 7 Then
                AxWindowsMediaPlayer1.URL = Application.StartupPath & "/Resources/Warning.wav"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            End If
            If NowTime > 20 Then

                Label1.Text = NowTime
            End If
            If NowTime <= 20 And NowTime > 0 Then
                Label1.Text = NowTime
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

    Private Sub SkinButton1_Click(sender As Object, e As EventArgs) Handles SkinButton1.Click
        Label1.Text = “立即执行”
        AxWindowsMediaPlayer1.URL = Application.StartupPath & "/Resources/Warning.wav"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        RunProcess()
        NowTime = -1
    End Sub
    Public Sub CountDownError()

        Label1.Text = “任务超时”
        Label2.Text = "即将终止本次任务"
        AxWindowsMediaPlayer1.URL = Application.StartupPath & "/Resources/Warning.wav"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        Timer2.Enabled = True
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MainCountDown()
    End Sub

    Private Sub DemoBGM_Enter(sender As Object, e As EventArgs) Handles DemoBGM.Enter

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Dispose()
    End Sub
End Class