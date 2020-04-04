
Module Module1
    Public Declare Function PlaySound Lib "winmm.dll" (ByVal lpszSoundName As String, ByVal hModule As Integer, ByVal dwFlags As Integer) As Integer
    Const SND_FILENAME As Integer = &H20000 ' 文件模式
    Const SND_ALIAS As Integer = &H10000    '自己查查
    Const SND_SYNC As Integer = &H0  '同步
    Const SND_ASYNC As Integer = &H1  '异步
    Const SND_LOOP As Integer = &H8  '循环

    Public Function NoticeBoard(ByVal Message As String, ByVal MessageType As Integer, ByVal ShowTime As Integer) As String
        Try
            Form8.Show()
        Catch
        End Try
        Form8.Label1.Text = Message
        If MessageType = 0 Then 'warning icon
            Form8.PictureBox1.Image = Form8.PictureBox2.Image
        End If
        If MessageType = 1 Then 'UnLogin icon
            Form8.PictureBox1.Image = Form8.PictureBox4.Image
        End If
        If MessageType = 2 Then 'OutTime Icon
            Form8.PictureBox1.Image = Form8.PictureBox3.Image
        End If
        If MessageType = 3 Then 'Information Icon
            Form8.PictureBox1.Image = Form8.PictureBox5.Image
        End If
        Form8.Timer3.Enabled = False
        Form8.Timer2.Enabled = True
        Form8.Timer1.Enabled = False
        Form8.Timer1.Interval = ShowTime * 1000
        Form8.TopMost = False
        Form8.TopMost = True
        NoticeSound(Application.StartupPath & "/Resources/NoticeTip.wav")
    End Function
    Public Function NoticeSound(ByVal WavPath As String) As String
        Dim nologin As String = WavPath


        PlaySound(nologin, 0, SND_ASYNC)

    End Function
End Module
