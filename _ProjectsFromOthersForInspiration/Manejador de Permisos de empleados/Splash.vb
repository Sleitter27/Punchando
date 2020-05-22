Public Class Splash

    Private Sub Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value = ProgressBar1.Value + 1
        Else
            Timer1.Enabled = False
            Me.Hide()
            MDIMain.Show()
        End If
    End Sub
End Class