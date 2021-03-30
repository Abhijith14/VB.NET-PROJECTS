Public Class Form1

    'Loading with Jaguar
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        PictureBox1.Image = My.Resources.jag
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    'Jaguar Code
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        PictureBox1.Image = My.Resources.jag
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    'Aston Martin Code
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        PictureBox1.Image = My.Resources.aston
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    'Mclaren Code
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        PictureBox1.Image = My.Resources.McLarenSenna_Gallery1
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    'Koenigsegg Code
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        PictureBox1.Image = My.Resources._2015_koenigsegg_one_1_3
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    'Bugatti Code
    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        PictureBox1.Image = My.Resources.Bugatti_Divo_Pebble_Beach_3
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class
