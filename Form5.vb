Public Class Form5
    Public X, Y As Integer
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            btnReg.Enabled = True
        Else
            btnReg.Enabled = False
        End If
    End Sub
    Public Sub Animation()
        'skinAnimator1.Show(Label1)
        'SkinAnimator1.Show(Label2)
        'SkinAnimator1.Show(txtRegUserName)
        'SkinAnimator1.Show(Label3)
        'SkinAnimator1.Show(txtRegPwd)
        ' SkinAnimator1.Show(Label4)
        'SkinAnimator1.Show(txtRegEmail)
        ' SkinAnimator1.Show(CheckBox1)
        'SkinAnimator1.Show(btnReg)
        SkinAnimator1.Show(Panel1)
    End Sub



    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        X = e.X : Y = e.Y
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If X = e.X And Y = e.Y Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Left = Me.Left + e.X - X
            Me.Top = Me.Top + e.Y - Y
        End If
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        ' UserRegin | 用户注册 url
        Dim url As String = "http://w.eydata.net/d432267a89c5e810" ' 这里改成自己的地址
        Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)
        Try
            '  这里改成自己的参数名称
            parameters.Add("UserName", Me.txtRegUserName.Text.Trim)
            parameters.Add("UserPwd", Me.txtRegPwd.Text)
            parameters.Add("Email", Me.txtRegEmail.Text)
            parameters.Add("Mac", "")
            Dim ret As String = WebPost.ApiPost(url, parameters)
            If (ret = "1") Then
                MsgBox(ChrW(27880) & ChrW(20876) & ChrW(25104) & ChrW(21151) & "!", vbInformation, "Successful")
                Me.Dispose()
            Else
                MessageBox.Show((ChrW(27880) & ChrW(20876) & ChrW(22833) & ChrW(36133) & "," & ChrW(38169) & ChrW(35823) & ChrW(20195) & ChrW(30721) & ": " & ret))
            End If
        Catch exception1 As Exception
            MessageBox.Show(ChrW(32593) & ChrW(32476) & ChrW(36830) & ChrW(25509) & ChrW(22833) & ChrW(36133) & "!")
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Dispose()
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked = False Then
        Else

            Dim ret As MsgBoxResult

            ret = MsgBox(Label5.Text, MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "用户服务协议")

            If ret = MsgBoxResult.Yes Then
                CheckBox1.Checked = True
            Else
                CheckBox1.Checked = False
            End If
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        X = e.X : Y = e.Y

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If X = e.X And Y = e.Y Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Left = Me.Left + e.X - X
            Me.Top = Me.Top + e.Y - Y
        End If
    End Sub
End Class