Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Font = CustomFont.GetInstance(40, FontStyle.Bold)
        Label2.Font = CustomFont.GetInstance(40, FontStyle.Bold)
        Label3.Font = CustomFont.GetInstance(10, FontStyle.Bold)
        Label4.Font = CustomFont.GetInstance(10, FontStyle.Bold)

        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim Date_o = DateTime.Now.ToString("MMM dd yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim Time_o = DateTime.Now.ToString("HH:mm")

        Dim Time_mod = Time_o.Split(":")

        Label1.Text = Time_mod(0)
        Label2.Text = Time_mod(1)
        Label3.Text = Day_o.ToUpper()
        Label4.Text = Date_o
    End Sub
End Class
