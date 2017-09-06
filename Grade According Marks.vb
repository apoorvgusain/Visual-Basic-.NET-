Public Class Grades

    Dim marks As Integer



    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Grade_Click(sender As System.Object, e As System.EventArgs) Handles Grade.Click

        marks = TextBox1.Text
        If (marks >= 90) And (marks <= 100) Then
            MessageBox.Show("Grade A", "Your Grade")
        ElseIf (marks >= 80) And (marks <= 89) Then
            MessageBox.Show("Grade B", "Your Grade")
        ElseIf (marks >= 70) And (marks <= 79) Then
            MessageBox.Show("Grade C", "Your Grade")
        ElseIf (marks >= 60) And (marks <= 69) Then
            MessageBox.Show("Grade D", "Your Grade")
        Else
            MessageBox.Show("Grade E", "Your Grade")
        End If



    End Sub
End Class
