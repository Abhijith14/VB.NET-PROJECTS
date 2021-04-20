Imports System.Drawing.Drawing2D
Imports System.Drawing.Brush
Public Class Form1

    Dim bmpPic As Bitmap
    Dim G As Drawing.Graphics
    Dim shape As String
    Dim mp, totpoints As Integer
    Dim p1, p2 As Point
    Dim pts() As Point
    Dim mypen As Pen
    Dim pencolor As Color
    Dim pensize As Integer
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Panel1.BackColor = Color.White
        bmpPic = New Bitmap(Panel1.Width, Panel1.Height)
        'Panel1.Image = bmpPic
        G = Graphics.FromImage(bmpPic)
        Panel1.DrawToBitmap(bmpPic, Panel1.ClientRectangle)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        shape = "Draw"
        Panel1.Cursor = New Cursor("C:\Users\ABHIJITH UDAYAKUMAR\source\repos\Paint\Paint\Large Pencil White.cur")

        Dim c As Control

        For Each c In GroupBox4.Controls
            If TypeOf c Is Button Then
                If c.Text = "Draw" Then
                    c.ForeColor = Color.Red
                Else
                    c.ForeColor = Color.White
                End If
            End If
        Next
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        mp = 1
        p1 = New Point(e.X, e.Y)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        G = Panel1.CreateGraphics

        'Initialize
        mp = 0
        totpoints = 0
        pencolor = Color.Black
        pensize = 5
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove

        Label16.Text = "X= " + Str(e.X) + ", Y= " + Str(e.Y)

        If mp = 1 And shape = "Draw" Then
            ReDim Preserve pts(totpoints)
            pts(totpoints) = New Point(e.X, e.Y)
            If (totpoints > 1) Then
                mypen = New Pen(pencolor, pensize)
                G.DrawLines(mypen, pts)
            End If
            Console.WriteLine(pts(totpoints))
        End If
    End Sub
End Class
