Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
        TextBox2.Select()
    End Sub

    'For Rounded Corners
    Private Sub roundCorners(obj As Form)

        obj.FormBorderStyle = FormBorderStyle.None

        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)

    End Sub

    'Close Button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    'Minimize Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'One
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox2.Text += "1"
        autoResult()
    End Sub

    'Two
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox2.Text += "2"
        autoResult()
    End Sub

    'Three
    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox2.Text += "3"
        autoResult()
    End Sub

    'Four
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox2.Text += "4"
        autoResult()
    End Sub

    'Five
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox2.Text += "5"
        autoResult()
    End Sub

    'Six
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox2.Text += "6"
        autoResult()
    End Sub

    'Seven
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox2.Text += "7"
        autoResult()
    End Sub

    'Eight
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox2.Text += "8"
        autoResult()
    End Sub

    'Nine
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox2.Text += "9"
        autoResult()
    End Sub

    'Zero
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox2.Text += "0"
        autoResult()
    End Sub

    'Decimal Point
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox2.Text += "."
    End Sub

    'Modulus
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox2.Text += " % "
    End Sub

    'Division
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox2.Text += " / "
    End Sub

    'Multiplication
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox2.Text += " * "
    End Sub

    'Addition
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox2.Text += " + "
    End Sub

    'Subtraction
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox2.Text += " - "
    End Sub

    'Equals
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox2.Text = TextBox1.Text
        TextBox1.Clear()
    End Sub

    'Result Update
    Private Sub autoResult()
        Try
            Dim query As String = TextBox2.Text
            Dim result = New DataTable().Compute(query, Nothing)
            TextBox1.Text = result
        Catch e As EvaluateException
            TextBox2.Clear()
            TextBox1.Text = "Evaluate Exception !!"
        Catch e As Exception
            TextBox2.Clear()
            TextBox1.Text = "Exception Found !!"
        End Try
    End Sub

    'Clear
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    'Delete
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim text2 As String = TextBox2.Text

            Dim text3 As String = ""

            For index As Integer = 0 To text2.Length - 2
                text3 += text2(index)
            Next
            TextBox2.Text = text3

            If text3 = "" Then
                TextBox1.Clear()
            End If


        Catch Exc As Exception
            TextBox1.Clear()
            TextBox2.Text = "Null"
        End Try


        'If TextBox1.Text.Length > 0 Then
        'TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
        'End If

    End Sub

End Class
