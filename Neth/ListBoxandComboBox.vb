Public Class ListBoxandComboBox

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub


    Private Sub ListBoxandComboBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

    End Sub

    
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RadioButtonandCheckBox.Show()
        Me.Hide()

    End Sub
End Class