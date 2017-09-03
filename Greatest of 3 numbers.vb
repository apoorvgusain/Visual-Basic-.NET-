Public Class Form1
    Dim a As Integer
    Dim b As Integer
    Dim c As Integer
    Dim largest As Integer

   Private Sub Find_Click(sender As System.Object, e As System.EventArgs) Handles Find.Click

        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text

        If a > b And a > c Then
            largest = c
        ElseIf b > a And b > c Then
            largest = b
        ElseIf c > a And c > b Then
            largest = c
        End If

        MessageBox.Show(largest, "Greatest of Three Numbers")

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
