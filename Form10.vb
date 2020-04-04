Imports System.IO

Public Class Info
    Private Sub Info_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Opacity = 0
        Dim b() As Byte = My.Resources.Believe
        Dim s As IO.Stream = File.Create(Application.StartupPath & "/Resources/Info.mp3")   '设定文件创建位置
        s.Write(b, 0, b.Length)    '文件写入
        s.Close()     '关闭文件
        Timer2.Enabled = True
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        AxWindowsMediaPlayer1.URL = Application.StartupPath & "/Resources/Info.mp3"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Opacity < 1 Then
            Me.Opacity = Me.Opacity + 0.01
        Else
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub SkinButton1_Click(sender As Object, e As EventArgs) Handles SkinButton1.Click
        Beep()
        Me.Dispose()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        System.Diagnostics.Process.Start("https://github.com/Sonaradar")
        Beep()
    End Sub
End Class