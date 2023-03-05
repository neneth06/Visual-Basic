Public Class 


    '  Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '  End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "User" And TextBox2.Text = "Pass" Then

            Calculator.Show()
            Me.Hide()



            '      Else
            '         Label3.Text = "ACCESS DENIED"
            '         Label3.Visible = True
        End If

    End Sub
End Class
