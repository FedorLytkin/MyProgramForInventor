Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = Fix(Val(TextBox1.Text) * 228 + 1488)
    End Sub
End Class
