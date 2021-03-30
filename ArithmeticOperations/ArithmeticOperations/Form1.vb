Public Class Form1

    'Code for SUM
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Text = "Sum of " + TextBox1.Text + " and " + TextBox2.Text
        TextBox3.Text = Int(TextBox1.Text) + Int(TextBox2.Text)
    End Sub

    'Code for Difference
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label3.Text = "Difference of " + TextBox1.Text + " and " + TextBox2.Text
        TextBox3.Text = Int(TextBox1.Text) - Int(TextBox2.Text)
    End Sub

    'Code for Product
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label3.Text = "Product of " + TextBox1.Text + " and " + TextBox2.Text
        TextBox3.Text = Int(TextBox1.Text) * Int(TextBox2.Text)
    End Sub

    'Code for Quotient
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label3.Text = "Quotient of " + TextBox1.Text + " and " + TextBox2.Text
        TextBox3.Text = Int(TextBox1.Text) / Int(TextBox2.Text)
    End Sub

    'Code for Clear
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label3.Text = "Answer"
    End Sub

    'Code for Exit
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub
End Class
