


Imports System.Threading

Public Class StansSplashForm
    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        StansGrocery.Show()
        SplashTimer.Enabled = False
        Thread.Sleep(100)
        Me.Close()
    End Sub


End Class