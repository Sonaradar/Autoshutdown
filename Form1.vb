Imports System.Threading
Imports System.IO
Imports System.ComponentModel
Imports System.Management

Public Class Form1
    Dim Hours As String
    Dim Minutes As String
    Dim EN As String
    Dim AT As String
    Dim AppPath As String = Application.StartupPath() & "/EventManager/"
    Dim Logined As Boolean

    Public X, Y As Integer
    '窗口位置变化
    Public Sub ResetLocation()
        Me.Left = Int(Screen.PrimaryScreen.Bounds.Width.ToString) - Me.Width - 5
        Me.Top = Int(Screen.PrimaryScreen.Bounds.Height.ToString) - Me.Height - 30
    End Sub
    '初始化模块
    Public Sub StartUp()
        If Dir(Application.StartupPath() & "/EventManager/") <> "" Then

        Else
            Directory.CreateDirectory(Application.StartupPath() & "/EventManager/")
        End If

    End Sub
    Public Sub ss()

    End Sub
    Public Sub Changebackground()
        Try
            If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "MainBackGround.png") Then
                Me.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "MainBackGround.png")
            End If
        Catch ex As Exception

        End Try '
    End Sub

    '读取事件模块
    Public Sub EventLoader()

        Dim MyDir As String
        Dim TaskTypeStr As String
        Dim TimerStr As String
        Dim DeTaskTypeStr As String
        Dim DeTimerStr As String
        ListBox1.Items.Clear()
        SkinListView1.Items.Clear()

        Dim i4 As String
        MyDir = Application.StartupPath & “/EventManager/"
        i4 = Dir(MyDir, vbDirectory)  '取优先个
        Do While i4 <> ""  '不为空就循环
            If i4 <> "." And i4 <> ".." Then  '如果不是 当前目录及上一级目录 . 及 ..
                If (GetAttr(MyDir & i4) And vbDirectory) = vbDirectory Then  '是否是目录
                    Dim item As New ListViewItem
                    item = SkinListView1.Items.Add(i4) '添加第一条，第一列数据
                    On Error Resume Next

                    TaskTypeStr = My.Computer.FileSystem.ReadAllText(Application.StartupPath & “/EventManager/" & i4 & "/TaskType.json", System.Text.Encoding.Default)
                    TimerStr = My.Computer.FileSystem.ReadAllText(Application.StartupPath & “/EventManager/" & i4 & "/TaskTime.json", System.Text.Encoding.Default)
                    If Val(TaskTypeStr) = 1 Then
                        DeTaskTypeStr = "关机任务"
                    End If
                    If Val(TaskTypeStr) = 2 Then
                        DeTaskTypeStr = "重启任务"
                    End If
                    If Val(TaskTypeStr) = 3 Then
                        DeTaskTypeStr = "休眠任务"
                    End If
                    DeTimerStr = TimerFixer(Val(TimerStr))
                    item.SubItems.Add(DeTimerStr)
                    item.SubItems.Add(DeTaskTypeStr)
                    ListBox1.Items.Add(TimerStr)
                End If
            End If
            i4 = Dir()  '取下一个
        Loop
    End Sub
    '任务保存
    Public Sub EventSaver(ByVal TaskName As String, ByVal TaskType As String, ByVal TaskTime As Integer)


        If Dir(Application.StartupPath & “/EventManager/" & TaskName) <> "" Then '判断是否存在
        Else
            '创建文件夹 Application.StartupPath() 为本软件目录下
            On Error Resume Next
            System.IO.Directory.CreateDirectory(Application.StartupPath & “/EventManager/" & TaskName & "/")
        End If
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & “/EventManager/" & TaskName & "/TaskTime.json", Str(TaskTime), False, System.Text.Encoding.Default)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & “/EventManager/" & TaskName & "/TaskType.json", TaskType, False, System.Text.Encoding.Default)
    End Sub
    '时间转换
    Public Shared Function TimerFixer(ByVal Time As Integer) As String

        Dim FixedTime As String
        Dim Hour As Integer
        Dim Minute As Integer
        Dim FixedHour As String
        Dim FixedMinute As String
        Hour = Int(Time / 3600)
        Minute = Int((Time - Int(Time / 3600) * 3600) / 60)
        If Len(Str(Hour).Replace(" ", "")) <= 1 Then
            FixedHour = "0" & Str(Hour)
        Else
            FixedHour = Str(Hour)
        End If
        If Len(Str(Minute).Replace(" ", "")) <= 1 Then
            FixedMinute = "0" & Str(Minute)
        Else
            FixedMinute = Str(Minute)
        End If
        FixedTime = FixedHour & ":" & FixedMinute
        TimerFixer = FixedTime.Replace(" ", "")
    End Function
    '任务到时检查
    Public Sub TaskCkeck()
        Dim NowTime As Integer
        NowTime = TimeOfDay.Hour * 3600 + TimeOfDay.Minute * 60 + TimeOfDay.Second
        For i = 0 To ListBox1.Items.Count - 1

            If Val(ListBox1.Items.Item(i)) = NowTime Then

                If Logined = False Then
                    NoticeBoard("未登录软件！", 1, 3)
                    Exit Sub
                End If
                If RadioButton1.Checked = True Then

                    If SkinListView1.Items(i).SubItems(2).Text = "关机任务" Then
                        Form2.RType.Text = “1”
                    End If
                    If SkinListView1.Items(i).SubItems(2).Text = "重启任务" Then
                        Form2.RType.Text = “2”
                    End If
                    If SkinListView1.Items(i).SubItems(2).Text = "休眠任务" Then
                        Form2.RType.Text = “3”
                    End If
                    Form2.Show()

                End If
                If RadioButton2.Checked = True Then

                    If SkinListView1.Items(i).SubItems(2).Text = "关机任务" Then
                        Form4.StateManager.Text = “1”
                    End If
                    If SkinListView1.Items(i).SubItems(2).Text = "重启任务" Then
                        Form4.StateManager.Text = “2”
                    End If
                    If SkinListView1.Items(i).SubItems(2).Text = "休眠任务" Then
                        Form4.StateManager.Text = “3”
                    End If
                    Form4.Show()
                    If CheckBox2.Checked = True Then
                        Form4.DemoBGM.URL = Application.StartupPath & "/Resources/DualBGM.mp3"
                        Form4.DemoBGM.Ctlcontrols.play()
                        Form4.DemoBGM.settings.volume = 50
                    Else
                        Form4.DemoBGM.URL = Application.StartupPath & "/Resources/DualBGM.mp3"
                        Form4.DemoBGM.Ctlcontrols.play()
                        Form4.DemoBGM.settings.volume = 0
                    End If

                    If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "FakeDemoMode.set") Then

                        Form4.Label5.Visible = True
                        Form4.Timer3.Enabled = True
                    Else

                    End If

                End If
                If RadioButton3.Checked = True Then

                    If SkinListView1.Items(i).SubItems(2).Text = "关机任务" Then
                        Form6.StateManager.Text = “1”
                    End If
                    If SkinListView1.Items(i).SubItems(2).Text = "重启任务" Then
                        Form6.StateManager.Text = “2”
                    End If
                    If SkinListView1.Items(i).SubItems(2).Text = "休眠任务" Then
                        Form6.StateManager.Text = “3”
                    End If
                    Form6.Show()
                End If


            End If
        Next
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        On Error Resume Next
        Dim MaxDelta As Integer
        Dim LatestTask As Integer
        MaxDelta = 100000
        For i = 0 To ListBox1.Items.Count - 1
            If Val(ListBox1.Items.Item(i)) - TimeOfDay.Hour * 3600 - TimeOfDay.Minute * 60 - TimeOfDay.Second < MaxDelta And Val(ListBox1.Items.Item(i)) - TimeOfDay.Hour * 3600 - TimeOfDay.Minute * 60 - TimeOfDay.Second > 0 Then
                MaxDelta = Val(ListBox1.Items.Item(i)) - TimeOfDay.Hour * 3600 - TimeOfDay.Minute * 60 - TimeOfDay.Second
                LatestTask = i
            End If
        Next
        If MaxDelta < 0 Then
            Label3.Text = "--：--"
            Label4.Text = “今日任务执行完毕”
        Else
            If MaxDelta = 60 Then
                NoticeBoard("即将执行任务" & vbCrLf & "剩余:1min", 2, 10)
            End If
            Label3.Text = SkinListView1.Items(LatestTask).SubItems(1).Text()
            Label3.Text = Label3.Text.Replace(" ", "")

            Label4.Text = “执行” & SkinListView1.Items(LatestTask).SubItems(2).Text()
        End If


        Label7.Text = SkinListView1.Items.Count
        NotifyIcon1.Text = "AutoShutDown 软件正在后台运行" & vbCrLf & Label3.Text & " " & Label4.Text & vbCrLf & "共计" & SkinListView1.Items.Count & “任务载入到软件” & vbCrLf & "双击程序图标进入设置"
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TaskCkeck()
    End Sub



    Private Sub SkinButton3_Click(sender As Object, e As EventArgs) Handles SkinButton3.Click
        If Logined = False Then
            NoticeBoard("未登录软件！", 1, 3)
            Exit Sub
        End If
        If SkinTextBox1.Text = "" Then
            NoticeBoard("任务名称非法", 0, 3)
            Exit Sub
        End If
        If SkinComboBox1.Text = "" Then
            NoticeBoard("任务类型非法", 0, 3)
            Exit Sub
        End If
        Dim TypeTemp As String
        If SkinComboBox1.Text = "关机任务" Then
            TypeTemp = "1"
        End If
        If SkinComboBox1.Text = "重启任务" Then
            TypeTemp = "2"
        End If
        If SkinComboBox1.Text = "休眠任务" Then
            TypeTemp = "3"
        End If
        EventSaver(SkinTextBox1.Text, TypeTemp, Val(NumericUpDown1.Value * 60 * 60 + NumericUpDown2.Value * 60))
        EventLoader()

        NoticeBoard("任务添加成功" & vbCrLf & "执行时间:" & TimerFixer(Val(NumericUpDown1.Value * 60 * 60 + NumericUpDown2.Value * 60)), 3, 3)
    End Sub

    Private Sub SkinButton1_Click(sender As Object, e As EventArgs) Handles SkinButton1.Click
        SkinTabControl1.SelectedIndex = 2
        Beep()
    End Sub

    Private Sub SkinButton2_Click(sender As Object, e As EventArgs) Handles SkinButton2.Click
        If Logined = False Then
            NoticeBoard("未登录软件！", 1, 3)
            Exit Sub
        End If
        For i = 0 To SkinListView1.SelectedItems.Count - 1
            Directory.Delete(Application.StartupPath & “/EventManager/" & SkinListView1.SelectedItems(i).SubItems(0).Text, True)
        Next i
        EventLoader()
        NoticeBoard("任务删除成功！", 3, 3)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.RType.Text = "3"
        Form2.Show()

    End Sub

    Private Sub SkinButton4_Click(sender As Object, e As EventArgs) Handles SkinButton4.Click
        If Logined = False Then
            NoticeBoard("未登录软件！", 1, 3)
            Exit Sub
        End If
        On Error Resume Next
        My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("AutoShutDown", Application.ExecutablePath)
        NoticeBoard("已设置开机启动", 3, 3)
    End Sub

    Private Sub SkinButton7_Click(sender As Object, e As EventArgs) Handles SkinButton7.Click
        If Logined = False Then
            NoticeBoard("未登录软件！", 1, 3)
            Exit Sub
        End If
        On Error Resume Next
        My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue("AutoShutDown")
        NoticeBoard("已禁止开机启动", 3, 3)
    End Sub
    '程序封装函数
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Hide()
        Me.Visible = False
        ResetLocation()
        Me.Hide()
        Me.Visible = False
        If Dir(Application.StartupPath & “/Resources/") <> "" Then '判断是否存在
        Else
            '创建文件夹 Application.StartupPath() 为本软件目录下
            On Error Resume Next
            System.IO.Directory.CreateDirectory(Application.StartupPath & “/Resources/")
        End If
        StartUp()
        EventLoader()
        Dim checkstate As String
        On Error Resume Next
        checkstate = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/TaskManagerEnabled.json", System.Text.Encoding.Default)
        If checkstate = "1" Then
            CheckBox1.Checked = True
            Timer1.Enabled = True
        End If

        If My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/API.json", System.Text.Encoding.Default) = "1" Then
            CheckBox3.Checked = True
            Timer6.Enabled = True
        End If



        If My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/FormState.json", System.Text.Encoding.Default) = "1" Then
            RadioButton2.Checked = True
        End If
        If My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/FormState.json", System.Text.Encoding.Default) = "2" Then
            RadioButton3.Checked = True
        End If
        If My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/Sound.json", System.Text.Encoding.Default) = "1" Then
            CheckBox2.Checked = True
        End If


        If Dir(Application.StartupPath & “/Resources/") <> "" Then '判断是否存在
        Else
            '创建文件夹 Application.StartupPath() 为本软件目录下
            On Error Resume Next
            System.IO.Directory.CreateDirectory(Application.StartupPath & “/Resources/")
        End If

        Dim b() As Byte = My.Resources.ASDDS
        Dim s As IO.Stream = File.Create(Application.StartupPath & "/Resources/Warning.wav")   '设定文件创建位置
        s.Write(b, 0, b.Length)    '文件写入
        s.Close()     '关闭文件

        b = My.Resources.Tips
        s = File.Create(Application.StartupPath & "/Resources/NoticeTip.wav")   '设定文件创建位置
        s.Write(b, 0, b.Length)    '文件写入
        s.Close()

        If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "Resources/Notice.mp3") Then
        Else
            b = My.Resources._567
            s = File.Create(Application.StartupPath & "/Resources/Notice.mp3")   '设定文件创建位置
            s.Write(b, 0, b.Length)    '文件写入
            s.Close()     '关闭文件
        End If
        If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "Resources/DualBGM.mp3") Then
        Else
            b = My.Resources.ALTIMA
            s = File.Create(Application.StartupPath & "/Resources/DualBGM.mp3")   '设定文件创建位置
            s.Write(b, 0, b.Length)    '文件写入
            s.Close()     '关闭文件
        End If

        If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "TimeLimited.json") Then
        Else


            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/TimeLimited.json", "60", False, System.Text.Encoding.Default)

        End If

        b = My.Resources.ALTIMA
        s = File.Create(Application.StartupPath & "/Resources/DemoBGM.mp3")   '设定文件创建位置
        s.Write(b, 0, b.Length)    '文件写入
            s.Close()     '关闭文件

        If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "Resources/Demo.mp4") Then
        Else
            b = My.Resources.GO
            s = File.Create(Application.StartupPath & "/Resources/Demo.mp4")   '设定文件创建位置
            s.Write(b, 0, b.Length)    '文件写入
            s.Close()     '关闭文件
        End If
        SkinGroupBox1.ForeColor = Color.Red
        SkinGroupBox1.Text = "登录正版软件，享受正版服务"
        Dim uName As String = OperateIniFile.ReadIniData("root", "name", "", "config.ini")
        Dim uPwd As String = OperateIniFile.ReadIniData("root", "pwd", "", "config.ini")
        If (uName.Length > 0) Then
            Me.ckbRememberMe.Checked = True
            Me.txtLoginUserName.Text = uName
            Me.txtLoginUserPwd.Text = uPwd
            Login()

        End If
        SkinTabControl1.SelectedIndex = 0
        Me.Hide()
        Me.Visible = False
        Changebackground()

        If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "DesktopTime.set") Then
            Form9.Show()
        End If
        Me.Visible = False
        ContextMenuStrip1.Visible = False
    End Sub
    Public Sub Login()
        If btnLogin.Text = "登录软件" Then

            ' 用户登录(UserLogin) url
            Dim url As String = "http://w.eydata.net/85a9d710c0861e5c" ' 这里改成自己的地址
            Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)
            Try
                Dim code As String = OperateIniFile.ReadIniData("root", "code", "", "config.ini")
                Dim upName As String = OperateIniFile.ReadIniData("root", "upName", "", "config.ini")
                If ((code.Length > 0) AndAlso (upName.Length > 0)) Then
                    ' 	退出登录(LogOut) url
                    Dim logOutUrl As String = "http://w.eydata.net/3bddfaca12012578" ' 这里改成自己的地址
                    '  这里改成自己的参数名称
                    parameters.Add("StatusCode", code)
                    parameters.Add("UserName", upName)
                    WebPost.ApiPost(logOutUrl, parameters)
                    parameters.Clear()
                End If
                '  这里改成自己的参数名称
                parameters.Add("UserName", Me.txtLoginUserName.Text.Trim)
                parameters.Add("UserPwd", Me.txtLoginUserPwd.Text)
                parameters.Add("Version", "4.1")
                parameters.Add("Mac", "")
                Dim ret As String = WebPost.ApiPost(url, parameters)
                If (ret.Length = &H20) Then
                    OperateIniFile.WriteIniData("root", "code", ret, "config.ini")
                    OperateIniFile.WriteIniData("root", "upName", Me.txtLoginUserName.Text.Trim, "config.ini")
                    If Me.ckbRememberMe.Checked Then
                        OperateIniFile.WriteIniData("root", "name", Me.txtLoginUserName.Text, "config.ini")
                        OperateIniFile.WriteIniData("root", "pwd", Me.txtLoginUserPwd.Text, "config.ini")
                    Else
                        OperateIniFile.WriteIniData("root", "name", "", "config.ini")
                        OperateIniFile.WriteIniData("root", "pwd", "", "config.ini")
                    End If
                    Logined = True
                    Me.ckbRememberMe.Enabled = False
                    Me.txtLoginUserName.Enabled = False
                    Me.txtLoginUserPwd.Enabled = False
                    Label18.Text = "服务器连接正常" & vbCrLf & "登录操作成功"
                    SkinGroupBox1.ForeColor = Color.FromArgb(0, 192, 0)
                    SkinGroupBox1.Text = "已经连接至远程服务器"
                    btnLogin.Text = "退出登录"
                Else

                End If
            Catch exception1 As Exception

            End Try
        Else
            btnLogin.Text = "登录软件"
            Me.ckbRememberMe.Enabled = True
            Me.txtLoginUserName.Enabled = True
            Me.txtLoginUserPwd.Enabled = True
            SkinGroupBox1.ForeColor = Color.Red
            SkinGroupBox1.Text = "登录正版软件，享受正版服务"

            Label18.Text = "未登录软件"
            Logined = False

        End If

    End Sub
    Private Sub SkinLabel1_MouseDown(sender As Object, e As MouseEventArgs) Handles SkinLabel1.MouseDown
        X = e.X : Y = e.Y
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Visible = False
        Beep()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Visible = Not (Me.Visible)
        ResetLocation()
        Beep()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Me.Visible = False
        Me.Visible = False
        Timer4.Enabled = False
        Timer5.Enabled = True
    End Sub

    Private Sub SkinButton8_Click(sender As Object, e As EventArgs) Handles SkinButton8.Click
        If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "/AntiExit.lock") Then
            NoticeBoard("AntiExit Protection!“ & vbCrLf & ”管理员限制退出软件", 0, 3)
            Exit Sub
        Else
        End If
        End
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged


        On Error Resume Next
        If CheckBox1.Checked = True Then
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/TaskManagerEnabled.json", "1", False, System.Text.Encoding.Default)
            Timer1.Enabled = True
        Else
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/TaskManagerEnabled.json", "0", False, System.Text.Encoding.Default)
            Timer1.Enabled = False
        End If
        Beep()
    End Sub

    Public Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If btnLogin.Text = "登录软件" Then

            ' 用户登录(UserLogin) url
            Dim url As String = "http://w.eydata.net/85a9d710c0861e5c" ' 这里改成自己的地址
            Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)
            Try
                Dim code As String = OperateIniFile.ReadIniData("root", "code", "", "config.ini")
                Dim upName As String = OperateIniFile.ReadIniData("root", "upName", "", "config.ini")
                If ((code.Length > 0) AndAlso (upName.Length > 0)) Then
                    ' 	退出登录(LogOut) url
                    Dim logOutUrl As String = "http://w.eydata.net/3bddfaca12012578" ' 这里改成自己的地址
                    '  这里改成自己的参数名称
                    parameters.Add("StatusCode", code)
                    parameters.Add("UserName", upName)
                    WebPost.ApiPost(logOutUrl, parameters)
                    parameters.Clear()
                End If
                '  这里改成自己的参数名称
                parameters.Add("UserName", Me.txtLoginUserName.Text.Trim)
                parameters.Add("UserPwd", Me.txtLoginUserPwd.Text)
                parameters.Add("Version", "4.1")
                parameters.Add("Mac", "")
                Dim ret As String = WebPost.ApiPost(url, parameters)
                If (ret.Length = &H20) Then
                    OperateIniFile.WriteIniData("root", "code", ret, "config.ini")
                    OperateIniFile.WriteIniData("root", "upName", Me.txtLoginUserName.Text.Trim, "config.ini")
                    If Me.ckbRememberMe.Checked Then
                        OperateIniFile.WriteIniData("root", "name", Me.txtLoginUserName.Text, "config.ini")
                        OperateIniFile.WriteIniData("root", "pwd", Me.txtLoginUserPwd.Text, "config.ini")
                    Else
                        OperateIniFile.WriteIniData("root", "name", "", "config.ini")
                        OperateIniFile.WriteIniData("root", "pwd", "", "config.ini")
                    End If
                    NoticeBoard("登录成功！", 1, 3)
                    Logined = True
                    Me.ckbRememberMe.Enabled = False
                    Me.txtLoginUserName.Enabled = False
                    Me.txtLoginUserPwd.Enabled = False
                    Label18.Text = "服务器连接正常" & vbCrLf & "登录操作成功"
                    SkinGroupBox1.ForeColor = Color.FromArgb(0, 192, 0)
                    SkinGroupBox1.Text = "已经连接至远程服务器"
                    btnLogin.Text = "退出登录"
                Else
                    MsgBox((ChrW(30331) & ChrW(24405) & ChrW(22833) & ChrW(36133) & "," & ChrW(38169) & ChrW(35823) & ChrW(20195) & ChrW(30721) & ": " & ret), vbInformation)
                End If
            Catch exception1 As Exception
                MsgBox(ChrW(32593) & ChrW(32476) & ChrW(36830) & ChrW(25509) & ChrW(22833) & ChrW(36133) & "!", vbExclamation)
            End Try
        Else
            btnLogin.Text = "登录软件"
            Me.ckbRememberMe.Enabled = True
            Me.txtLoginUserName.Enabled = True
            Me.txtLoginUserPwd.Enabled = True
            SkinGroupBox1.ForeColor = Color.Red
            SkinGroupBox1.Text = "登录正版软件，享受正版服务"
            Label18.Text = "未登录软件"
            Logined = False
            Beep()
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Me.Visible = False
        Me.Hide()

        Timer5.Enabled = False
    End Sub


    Private Sub SkinLabel1_MouseMove(sender As Object, e As MouseEventArgs) Handles SkinLabel1.MouseMove
        If X = e.X And Y = e.Y Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Left = Me.Left + e.X - X
            Me.Top = Me.Top + e.Y - Y
        End If
    End Sub

    Private Sub SkinTabPage5_Click(sender As Object, e As EventArgs) Handles SkinTabPage5.Click

    End Sub

    Private Sub LinkLabel2_DoubleClick(sender As Object, e As EventArgs) Handles LinkLabel2.DoubleClick
        On Error Resume Next
        Dim ret As MsgBoxResult

        ret = MsgBox("Enter DEMO Mode?" & vbCrLf & "Super Form With Super Atmosphere Lamp And Dual BackGroundMusic", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "Demo Mode")

        If ret = MsgBoxResult.Yes Then
            If RadioButton1.Checked = True Then
                Form2.RType.Text = “4”

                Form2.Show()

            End If
            If RadioButton2.Checked = True Then

                Form4.StateManager.Text = “4”

                Form4.Show()
                Form4.DemoBGM.URL = Application.StartupPath & "/Resources/DemoBGM.mp3"
                Form4.DemoBGM.Ctlcontrols.play()
                Form4.DemoBGM.settings.volume = 50
                Form4.Label5.Visible = True
                Form4.Timer3.Enabled = True
            End If
            If RadioButton3.Checked = True Then

                Form6.StateManager.Text = “4”
                Form6.Label5.Visible = True
                Form6.Show()
            End If
        End If

    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        On Error Resume Next
        If RadioButton1.Checked = True Then
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/FormState.json", "0", False, System.Text.Encoding.Default)
            Beep()
        End If
    End Sub


    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        On Error Resume Next
        Form5.Show()
        Beep()
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        On Error Resume Next
        If RadioButton2.Checked = True Then
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/FormState.json", "1", False, System.Text.Encoding.Default)
            Beep()
        End If

    End Sub
    Public Sub Surprise()

        On Error Resume Next
        Dim ret As MsgBoxResult

        ret = MsgBox("?????????" & vbCrLf & "嗱偠侰靆A浑澌夓晲燣诒甤?F?椰啂j弋馆擝u訶?$什a?煸7！", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "賝麩〨詻Y1蟟$g")

        If ret = MsgBoxResult.Yes Then

            Info.Show()
        End If
    End Sub
    Private Sub Label8_DoubleClick(sender As Object, e As EventArgs) Handles Label8.DoubleClick
        Surprise()
    End Sub
    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        Surprise()
    End Sub

    Private Sub Label18_DoubleClick(sender As Object, e As EventArgs) Handles Label18.DoubleClick
        Surprise()
    End Sub

    Private Sub PictureBox4_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseDown
        X = e.X : Y = e.Y
    End Sub


    Private Sub PictureBox4_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseMove
        If X = e.X And Y = e.Y Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Left = Me.Left + e.X - X
            Me.Top = Me.Top + e.Y - Y
        End If
    End Sub



    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBox2.Click
        On Error Resume Next
        If CheckBox2.Checked = True Then
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/Sound.json", "1", False, System.Text.Encoding.Default)
        Else
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/Sound.json", "0", False, System.Text.Encoding.Default)
        End If
        Beep()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        On Error Resume Next
        System.Diagnostics.Process.Start(Application.StartupPath)
    End Sub

    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click
        On Error Resume Next
        If RadioButton3.Checked = True Then
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/FormState.json", "2", False, System.Text.Encoding.Default)
            Beep()
        End If
        Beep()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Timer6.Enabled = True
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/API.json", "1", False, System.Text.Encoding.Default)
            Beep()
        Else
            Timer6.Enabled = False
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/API.json", "0", False, System.Text.Encoding.Default)
            Beep()
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        APIRun()
    End Sub

    Private Sub 显示主窗口ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 显示主窗口ToolStripMenuItem.Click
        Me.Visible = True
        SkinTabControl1.SelectedIndex = 0
        Beep()
    End Sub

    Private Sub 加入任务ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 加入任务ToolStripMenuItem.Click
        Me.Visible = True
        SkinTabControl1.SelectedIndex = 2
        Beep()
    End Sub

    Private Sub 任务列表ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 任务列表ToolStripMenuItem.Click
        Me.Visible = True
        SkinTabControl1.SelectedIndex = 1
        Beep()
    End Sub

    Private Sub 退出软件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出软件ToolStripMenuItem.Click
        End
    End Sub

    Private Sub 访问我的主页_Click(sender As Object, e As EventArgs) Handles 访问我的主页.Click
        System.Diagnostics.Process.Start("https://space.bilibili.com/302091372")
        Beep()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Info.Show()
    End Sub

    Private Sub SkinGroupBox1_Enter(sender As Object, e As EventArgs) Handles SkinGroupBox1.Enter

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub 关机模式ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关机模式ToolStripMenuItem.Click
        On Error Resume Next
        Beep()

        If RadioButton1.Checked = True Then
            Form2.RType.Text = “1”
            Form2.Show()
        End If
        If RadioButton2.Checked = True Then
            Form4.StateManager.Text = “1”
            Form4.Show()
            If CheckBox2.Checked = True Then
                Form4.DemoBGM.URL = Application.StartupPath & "/Resources/DualBGM.mp3"
                Form4.DemoBGM.Ctlcontrols.play()
                Form4.DemoBGM.settings.volume = 50
            Else
                Form4.DemoBGM.URL = Application.StartupPath & "/Resources/DualBGM.mp3"
                Form4.DemoBGM.Ctlcontrols.play()
                Form4.DemoBGM.settings.volume = 0
            End If

            If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "FakeDemoMode.set") Then

                Form4.Label5.Visible = True
                Form4.Timer3.Enabled = True
            Else

            End If

        End If
    End Sub

    Private Sub 重启ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 重启ToolStripMenuItem.Click
        On Error Resume Next
        Beep()

        If RadioButton1.Checked = True Then
            Form2.RType.Text = “2”
            Form2.Show()
        End If
        If RadioButton2.Checked = True Then
            Form4.StateManager.Text = “2”
            Form4.Show()
            If CheckBox2.Checked = True Then
                Form4.DemoBGM.URL = Application.StartupPath & "/Resources/DualBGM.mp3"
                Form4.DemoBGM.Ctlcontrols.play()
                Form4.DemoBGM.settings.volume = 50
            Else
                Form4.DemoBGM.URL = Application.StartupPath & "/Resources/DualBGM.mp3"
                Form4.DemoBGM.Ctlcontrols.play()
                Form4.DemoBGM.settings.volume = 0
            End If

            If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "FakeDemoMode.set") Then

                Form4.Label5.Visible = True
                Form4.Timer3.Enabled = True
            Else

            End If

        End If
    End Sub

    Private Sub 休眠任务ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 休眠任务ToolStripMenuItem.Click
        On Error Resume Next
        Beep()

        If RadioButton1.Checked = True Then
            Form2.RType.Text = “3”
            Form2.Show()
        End If
        If RadioButton2.Checked = True Then
            Form4.StateManager.Text = “3”
            Form4.Show()
            If CheckBox2.Checked = True Then
                Form4.DemoBGM.URL = Application.StartupPath & "/Resources/DualBGM.mp3"
                Form4.DemoBGM.Ctlcontrols.play()
                Form4.DemoBGM.settings.volume = 50
            Else
                Form4.DemoBGM.URL = Application.StartupPath & "/Resources/DualBGM.mp3"
                Form4.DemoBGM.Ctlcontrols.play()
                Form4.DemoBGM.settings.volume = 0
            End If

            If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "FakeDemoMode.set") Then

                Form4.Label5.Visible = True
                Form4.Timer3.Enabled = True
            Else

            End If

        End If
    End Sub

    Private Sub SkinTabPage1_Click(sender As Object, e As EventArgs) Handles SkinTabPage1.Click

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub 发送关机任务延迟30sToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 发送关机任务延迟30sToolStripMenuItem.Click
        On Error Resume Next
        If Dir(Application.StartupPath & “/API/") <> "" Then '判断是否存在
        Else
            '创建文件夹 Application.StartupPath() 为本软件目录下
            On Error Resume Next
            System.IO.Directory.CreateDirectory(Application.StartupPath & “/API/")
        End If

        If Dir(Application.StartupPath & “/API/Resources/") <> "" Then '判断是否存在
        Else
            '创建文件夹 Application.StartupPath() 为本软件目录下
            On Error Resume Next
            System.IO.Directory.CreateDirectory(Application.StartupPath & “/API/Resources/")
        End If
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/API/State.info", Str(“1”), False, System.Text.Encoding.Default)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/API/Time.info", Str("30"), False, System.Text.Encoding.Default)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/API/Enabled.set", "", False, System.Text.Encoding.Default)
        Beep()
    End Sub

    Private Sub 发送重启任务延迟30sToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 发送重启任务延迟30sToolStripMenuItem.Click
        On Error Resume Next
        If Dir(Application.StartupPath & “/API/") <> "" Then '判断是否存在
        Else
            '创建文件夹 Application.StartupPath() 为本软件目录下
            On Error Resume Next
            System.IO.Directory.CreateDirectory(Application.StartupPath & “/API/")
        End If

        If Dir(Application.StartupPath & “/API/Resources/") <> "" Then '判断是否存在
        Else
            '创建文件夹 Application.StartupPath() 为本软件目录下
            On Error Resume Next
            System.IO.Directory.CreateDirectory(Application.StartupPath & “/API/Resources/")
        End If
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/API/State.info", Str(“2”), False, System.Text.Encoding.Default)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/API/Time.info", Str("30"), False, System.Text.Encoding.Default)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/API/Enabled.set", "", False, System.Text.Encoding.Default)
        Beep()
    End Sub

    Private Sub 发送休眠任务延迟30sToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 发送休眠任务延迟30sToolStripMenuItem.Click
        On Error Resume Next
        If Dir(Application.StartupPath & “/API/") <> "" Then '判断是否存在
        Else
            '创建文件夹 Application.StartupPath() 为本软件目录下
            On Error Resume Next
            System.IO.Directory.CreateDirectory(Application.StartupPath & “/API/")
        End If

        If Dir(Application.StartupPath & “/API/Resources/") <> "" Then '判断是否存在
        Else
            '创建文件夹 Application.StartupPath() 为本软件目录下
            On Error Resume Next
            System.IO.Directory.CreateDirectory(Application.StartupPath & “/API/Resources/")
        End If
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/API/State.info", Str(“3”), False, System.Text.Encoding.Default)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/API/Time.info", Str("30"), False, System.Text.Encoding.Default)
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/API/Enabled.set", "", False, System.Text.Encoding.Default)
        Beep()
    End Sub

    Public Sub APIRun() 'tick

        If Dir(Application.StartupPath & “/API/") <> "" Then '判断是否存在
        Else
            '创建文件夹 Application.StartupPath() 为本软件目录下
            On Error Resume Next
            System.IO.Directory.CreateDirectory(Application.StartupPath & “/API/")
        End If

        If Dir(Application.StartupPath & “/API/Resources/") <> "" Then '判断是否存在
        Else
            '创建文件夹 Application.StartupPath() 为本软件目录下
            On Error Resume Next
            System.IO.Directory.CreateDirectory(Application.StartupPath & “/API/Resources/")
        End If
        If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "/API/Enabled.set") Then
            File.Delete(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "/API/Enabled.set")
            Dim API_State As Integer
            Dim API_Time As Integer
            Dim API_FakeDemoMode As Boolean = False
            Dim API_AntiExit As Boolean = False

            If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "/API/State.info") Then '0-None 1-shutdown 2-reboot 3-sleep
                API_State = Val(My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/API/State.info", System.Text.Encoding.Default))
            Else
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/API/State.info", "0", False, System.Text.Encoding.Default)
            End If

            If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "/API/Time.info") Then
                API_Time = Val(My.Computer.FileSystem.ReadAllText(Application.StartupPath & "/API/Time.info", System.Text.Encoding.Default))
            Else
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/API/Time.info", "60", False, System.Text.Encoding.Default) 'limited 60s
            End If

            If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "/API/FakeDemoMode.set") Then 'fakedemomode
                API_FakeDemoMode = True
            End If

            If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "/API/AntiExit.set") Then 'antiexit
                API_AntiExit = True
            End If

            '---------------------------------------------------------------------------------------------------------------------------------------------
            'core



            Form4.ApiManager.Text = "1"
            If API_State = 1 Then
                Form4.StateManager.Text = “1”
            End If
            If API_State = 2 Then
                Form4.StateManager.Text = “2”
            End If
            If API_State = 3 Then
                Form4.StateManager.Text = “3”
            End If

            On Error Resume Next
            Form4.Show()







            Form4.DemoBGM.settings.volume = 50

            Form4.DemoBGM.URL = Application.StartupPath & "/API/Resources/Sound.mp3"
            Form4.DemoBGM.Ctlcontrols.play()



            If API_FakeDemoMode = True Then

                Form4.Label5.Visible = True
                Form4.Timer3.Enabled = True


            End If

        End If



    End Sub
End Class
