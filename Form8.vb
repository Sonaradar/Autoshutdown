Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartShow()
    End Sub
    Public Sub StartShow()
        EnableDoubleBuffering()
        Me.Top = Screen.PrimaryScreen.Bounds.Height.ToString / 4 * 3
        Me.Left = Screen.PrimaryScreen.Bounds.Width.ToString
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Screen.PrimaryScreen.Bounds.Width.ToString - Me.Left > Me.Width Then
            Timer1.Enabled = True
            Timer2.Enabled = False


            Me.Opacity = 100
        Else
            Me.Left = Me.Left - 10
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer3.Enabled = True
        Timer1.Enabled = False
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Me.Left > Screen.PrimaryScreen.Bounds.Width.ToString Then
            Timer3.Enabled = False
            Me.Opacity = 100
            Me.Dispose()
        Else
            Me.Left = Me.Left + 10
        End If
    End Sub
End Class