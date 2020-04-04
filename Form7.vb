Imports System.Threading
Imports System.IO
Imports System.ComponentModel
Imports System.Management
Class Form7
    Public X, Y As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        If Int(Player.Ctlcontrols.currentPosition) = Int(Player.currentMedia.duration()) Then
            Me.Dispose()
        End If
    End Sub

    Private Sub Player_Enter(sender As Object, e As EventArgs) Handles Player.Enter

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles Me.Load
        On Error Resume Next
        Player.URL = AppDomain.CurrentDomain.SetupInformation.ApplicationBase & "Resources\Demo.mp4"
        Player.Ctlcontrols.play()
        Timer1.Enabled = True
    End Sub
End Class