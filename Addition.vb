Public Class Addition

    Dim num1 As Integer
    Dim num2 As Integer
    Dim addition As Integer

    Private Sub Add_Click(sender As System.Object, e As System.EventArgs) Handles Add.Click

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        addition = num1 + num2
        MessageBox.Show(addition, "Addition")
    End Sub
End Class
