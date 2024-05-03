Public Class StansSplashForm
    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        StansGrocery.Show()
        SplashTimer.Enabled = False
        Me.Close()
    End Sub
End Class