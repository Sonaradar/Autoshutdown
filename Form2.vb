

Class Form2
    Dim nowtime As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nowtime = 60
        If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "TimeLimited.json") Then
            If Val(My.Computer.FileSystem.ReadAllText(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "TimeLimited.json", System.Text.Encoding.Default)) > 60 Then
                nowtime = Val(My.Computer.FileSystem.ReadAllText(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "TimeLimited.json", System.Text.Encoding.Default))
            End If
        Else


            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/TimeLimited.json", "60", False, System.Text.Encoding.Default)

        End If

        Timer2.Enabled = True
        If RType.Text = "1" Then
            Label3.Text = "执行关机任务"
        End If
        If RType.Text = "2" Then
            Label3.Text = "执行重启任务"
        End If
        If RType.Text = "3" Then
            Label3.Text = "执行休眠任务"
        End If
        If RType.Text = "4" Then
            Label3.Text = "演示模式"
            Label7.Visible = True
            Timer3.Enabled = True
        End If
        Timer1.Enabled = True
        If RType.Text <> "4" Then
            Try
                If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "BackGround.png") Then
                    Me.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "BackGround.png")
                End If
            Catch ex As Exception

            End Try '
        End If
    End Sub
    Public Sub loadEvent()



    End Sub
    Public Sub RunProcess()
        If RType.Text = "1" Then
            Shell("shutdown -s -t 1")
        End If
        If RType.Text = "2" Then
            Shell("shutdown -r -t 1")
        End If
        If RType.Text = "3" Then
            Shell("shutdown -h")
        End If
        If RType.Text = "4" Then
            Shell("shutdown -h")
            Me.Dispose()
        End If
    End Sub
    Private Sub SkinButton1_Click(sender As Object, e As EventArgs) Handles SkinButton1.Click

    End Sub

    Private Sub SkinButton2_Click(sender As Object, e As EventArgs) Handles SkinButton2.Click
        If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "Locker.lock") Then
            NoticeBoard("已设置禁止取消“ & vbCrLf & ”取消无效", 0, 3)
            Exit Sub
        Else
            NoticeBoard("定时任务取消“, 3, 3)
        End If
        Me.Dispose()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


        If nowtime < 1 And nowtime > -1 Then
            Label4.Text = "立即执行"
            RunProcess()
        Else

            If Int(nowtime) < 10 Then
                Label4.Text = Replace("0" + Str(nowtime), " ", "")

            Else
                Label4.Text = nowtime
            End If
            If nowtime < -1 Then
                Label4.Text = "执行错误"
                Label3.Text = 10 + nowtime & "秒后退出"
            End If
            If nowtime = -10 Then
                Me.Dispose()
            End If

        End If
        nowtime = nowtime - 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        AxWindowsMediaPlayer1.URL = Application.StartupPath & "/Resources/Notice.mp3"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        Timer1.Enabled = False
    End Sub

    Private Sub SkinButton2_DoubleClick(sender As Object, e As EventArgs) Handles SkinButton2.DoubleClick
        Me.Dispose()
    End Sub

    Private Sub SkinButton1_DockChanged(sender As Object, e As EventArgs) Handles SkinButton1.DockChanged

    End Sub

    Private Sub SkinButton1_DoubleClick(sender As Object, e As EventArgs) Handles SkinButton1.DoubleClick
        nowtime = 0
        RunProcess()

        Label4.Text = "立即执行"
        Beep()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        DemoBGM.URL = Application.StartupPath & "/Resources/DemoBGM.mp3"
        DemoBGM.Ctlcontrols.play()
        Timer3.Enabled = False
    End Sub
End Class