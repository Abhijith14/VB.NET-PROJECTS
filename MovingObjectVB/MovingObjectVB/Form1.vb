Public Class Form1

    Dim LeftMinLimit As Integer = -155
    Dim Interval As Integer = 20
    Dim UpMinLimit As Integer = -100
    Dim UpMaxLimit As Integer = 310

    'Start Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Interval = 300
        Timer1.Enabled = True
    End Sub

    'Stop Button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Left
        If (RadioButton1.Checked) Then
            If PictureBox1.Left > LeftMinLimit Then
                PictureBox1.Left -= Interval
            Else
                PictureBox1.Left = Me.Width
            End If
        End If

        'Right
        If (RadioButton2.Checked) Then
            If PictureBox1.Left < Me.Width Then
                PictureBox1.Left += Interval
            Else
                PictureBox1.Left = LeftMinLimit
            End If
        End If

        'Up
        If (RadioButton3.Checked) Then
            If PictureBox1.Top > UpMinLimit Then
                PictureBox1.Top -= Interval
            Else
                PictureBox1.Top = UpMaxLimit
            End If
        End If

        'Down
        If (RadioButton4.Checked) Then
            If PictureBox1.Top < UpMaxLimit Then
                PictureBox1.Top += Interval
            Else
                PictureBox1.Top = UpMinLimit
            End If
        End If

    End Sub
End Class