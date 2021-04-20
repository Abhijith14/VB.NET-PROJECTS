Public Class AboutForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "About Simple Text Editor"
    End Sub
End Class
