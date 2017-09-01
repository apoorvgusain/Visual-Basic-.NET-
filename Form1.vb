Public Class Form1

    Dim num1 As Integer
    Dim num2 As Integer
    Dim input As Integer
    Dim sum As Integer
    Dim diff As Integer
    Dim product As Integer
    Dim ratio As Integer
    Dim power As Integer



    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Calculate_Click(sender As System.Object, e As System.EventArgs) Handles Calculate.Click

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        input = TextBox3.Text

        Select Case input
            Case 1
                sum = num1 + num2
                TextBox4.Text = sum
                MessageBox.Show("Numbers Added", "Addition")
            Case 2
                diff = num1 - num2
                TextBox4.Text = diff
                MessageBox.Show("Numbers Subtracted", "Subtraction")
            Case 3
                product = num1 * num2
                TextBox4.Text = product
                MessageBox.Show("Numbers Multiplied", "Multiplication")
            Case 4
                ratio = num1 / num2
                TextBox4.Text = ratio
                MessageBox.Show("Numbers Divided", "Division")
            Case 5
                power = num1 ^ num2
                TextBox4.Text = power
                MessageBox.Show("Number Raised", "Power")
        End Select
    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class
