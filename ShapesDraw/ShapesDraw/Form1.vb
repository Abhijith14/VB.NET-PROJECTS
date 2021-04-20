Public Class Form1
    Dim xdown, ydown, xup, yup As Integer
    Dim c As String
    Dim w, h As Integer
    Dim g As Graphics
    Dim Col As String

    'Line
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c = "l"
    End Sub

    'Rectangle
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c = "r"
    End Sub

    'Filled Rectangle
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        c = "fr"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        g.Clear(Color.White)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (ColorDialog1.ShowDialog() <> DialogResult.Cancel) Then
            Col = ColorDialog1.Color.ToArgb.ToString
        End If

    End Sub

    'Eclipse
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        c = "e"
    End Sub

    'Filled Eclipse
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        c = "fe"
    End Sub

    'MouseDown
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        xdown = e.X
        ydown = e.Y
    End Sub

    'MouseUp
    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        xup = e.X
        yup = e.Y
        w = xup - xdown
        h = yup - ydown
        g = PictureBox1.CreateGraphics()
        If Col = "" Then
            Col = "-16777216"
        End If

        Dim customColour As Color = Color.FromArgb(CInt(Col))
        Using customBrush As New SolidBrush(customColour)
            Using customPen As New Pen(customBrush)
                Select Case c
                    Case "l"
                        g.DrawLine(customPen, xdown, ydown, xup, yup)
                    Case "r"
                        g.DrawRectangle(customPen, xdown, ydown, w, h)
                    Case "fr"
                        g.FillRectangle(customBrush, xdown, ydown, w, h)
                    Case "e"
                        g.DrawEllipse(customPen, xdown, ydown, w, h)
                    Case "fe"
                        g.FillEllipse(customBrush, xdown, ydown, w, h)
                End Select
            End Using
        End Using
    End Sub

End Class
