Public Class Concatenate
    Dim string1 As String
    Dim string2 As String
    Dim Concat As String
    Dim A As Integer
    Dim string3 As String



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles oncatenate.Click
        string1 = TextBox1.Text
        string2 = TextBox2.Text
        Concat = string1 & string2
        MessageBox.Show(Concat)


    End Sub

    Private Sub Length_Click(sender As System.Object, e As System.EventArgs) Handles Length.Click

        MessageBox.Show(Concat.Length)

    End Sub

    Private Sub Replace_Click(sender As System.Object, e As System.EventArgs) Handles Replace.Click

        string3 = TextBox3.Text
        A = string2.Replace(string2, string3)
        MessageBox.Show(A)
    End Sub
End Class
