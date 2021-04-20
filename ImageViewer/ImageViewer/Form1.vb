Public Class Form1

    Dim index As Integer
    Dim first, last As Integer
    Dim PicName(10) As Image

    'Form Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PicName(0) = My.Resources._1
        PicName(1) = My.Resources._2
        PicName(2) = My.Resources._3
        PicName(3) = My.Resources._4
        PicName(4) = My.Resources._5
        PicName(5) = My.Resources._6
        PicName(6) = My.Resources._7
        PicName(7) = My.Resources._8
        PicName(8) = My.Resources._9
        PicName(9) = My.Resources._10

        index = 0
        PictureBox1.Image = PicName(index)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Label1.Text = "Image" + (index + 1).ToString() + ".png"

        For i = 1 To 10
            ListBox1.Items.Add("Image" + i.ToString() + ".png")
        Next

    End Sub

    'Previous
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If index <> 0 Then
            index -= 1
            PictureBox1.Image = PicName(index)
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            Label1.Text = "Image" + (index + 1).ToString() + ".png"
        End If
    End Sub

    'ListBox Selection
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        index = ListBox1.SelectedIndex
        PictureBox1.Image = PicName(index)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Label1.Text = "Image" + (index + 1).ToString() + ".png"
    End Sub

    'Slideshow
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            Timer1.Interval = 500
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If

    End Sub

    'Timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If index < 9 Then
            Call Button2_Click(sender, e)
        Else
            Call Button2_Click(sender, e)
            index = -1
        End If
    End Sub

    'Next
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If index <> 9 Then
            index += 1
            PictureBox1.Image = PicName(index)
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            Label1.Text = "Image" + (index + 1).ToString() + ".png"
        End If

    End Sub



End Class
