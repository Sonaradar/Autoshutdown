Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = Int(Screen.PrimaryScreen.Bounds.Width.ToString) - Me.Width
        Me.Top = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        Threading.Thread.Sleep(500)
        Me.Opacity = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity < 0.75 Then
            Me.Opacity = Me.Opacity + 0.01
        Else
            Form1.Show()
            Form1.Visible = False
            Timer1.Enabled = False
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label3.Hide()
        Label3.Text = "Loaded Successfully"
        SkinAnimator1.Show(Label3)
        Timer3.Enabled = True
        Timer2.Enabled = False
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label3.Hide()
        Label3.Text = "Powered By Thunder Software"
        SkinAnimator1.Show(Label3)
        Timer4.Enabled = True
        Timer3.Enabled = False
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Me.Hide()
        Timer4.Enabled = False
    End Sub
End Class
