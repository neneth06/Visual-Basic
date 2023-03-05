Public Class Calculator

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        Label1.Text = "*"
        Label1.Visible = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
        Label1.Text = "/"
        Label1.Visible = True
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
        Label1.Text = "+"
        Label1.Visible = True
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
        Label1.Text = "-"
        Label1.Visible = True
    End Sub

    Private Sub Button3_MouseMove(sender As Object, e As MouseEventArgs) Handles Button3.MouseMove
        ' TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "="
        Label1.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        ListBoxandComboBox.Show()

    End Sub

   
End Class