Public Class Form9
    Dim TempString As String
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Public Sub Position()
        Me.Left = Screen.PrimaryScreen.Bounds.Width.ToString - Me.Width
        Me.Top = 0
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Position()

        If (TempString <> Format(DateTime.Now, "hh:mm")) Then
            Label1.Hide()
            Label1.Text = Format(DateTime.Now, "hh:mm")
            SkinAnimator1.Show(Label1)
        Else
            If (Int(Int(Format(DateTime.Now, "ss")) / 2) = Int(Format(DateTime.Now, "ss")) / 2) Then
                Label1.Text = Format(DateTime.Now, "hh:mm")
            Else
                Label1.Text = Format(DateTime.Now, "hh mm")
            End If
        End If
            TempString = Format(DateTime.Now, "hh:mm")
    End Sub


    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles Me.Load
        Position()
        Label1.Text = Format(DateTime.Now, "hh:mm")
        TempString = Format(DateTime.Now, "hh:mm")
    End Sub
End Class