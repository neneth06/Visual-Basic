Public Class RadioButtonandCheckBox


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_CheckedChanged(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton1.Checked = True Then
            MessageBox.Show("Hindi ka pa pwede uminom! Belat!")
        ElseIf RadioButton2.Checked = True Then
            MessageBox.Show("Mabuhay ka hangga't gusto mo! Inom arat?")
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        MessageBox.Show("Build a NATION with those speedy eggs!")
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        MessageBox.Show("Keep your V healthy!")
    End Sub
End Class
