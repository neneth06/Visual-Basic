Public Class SplashScreen
    '  Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '  End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        RectangleShape2.Width += 40
        If RectangleShape2.Width >= 550 Then

            ' Login.Show()
            Me.Hide()

        End If
    End Sub

End Class
