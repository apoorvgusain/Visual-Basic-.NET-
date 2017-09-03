Public Class Form1

    Dim rad As Double
    Dim ar As Double

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Area.Click

        rad = TextBox.Text
        ar = 3.14 * 3.14 * rad
        MessageBox.Show(ar, "Area of Circle")


    End Sub
End Class
