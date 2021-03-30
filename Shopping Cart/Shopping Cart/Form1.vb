Public Class Form1

    'Total Code
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim total = 0
        If CheckBox1.Checked Then
            total += 50000
        End If
        If CheckBox2.Checked Then
            total += 10000
        End If
        If CheckBox3.Checked Then
            total += 8000
        End If

        TextBox1.Text = "Total is : ₹ " + Str(total)
    End Sub

    'Clear Code
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        TextBox1.Text = "Total is :"
    End Sub
End Class
