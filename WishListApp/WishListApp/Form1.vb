Public Class Form1

    'Form Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Learn ML")
        ComboBox1.Items.Add("Learn Data Analytics")
        ComboBox1.Items.Add("Learn Ruby")
        ComboBox1.Items.Add("Become an ML Expert")
    End Sub

    'Add A Wish
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text <> "" Then
            If (ListBox1.Items.IndexOf(ComboBox1.Text) = -1) Then
                ListBox1.Items.Add(ComboBox1.Text)
                TextBox1.Text = ListBox1.Items.Count
            End If
        Else
            MsgBox("No Items Added !")
        End If

    End Sub

    'Delete A Wish
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (ListBox1.SelectedIndex = -1) Then
            MsgBox("Select Item to be deleted...")
        Else
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            TextBox1.Text = ListBox1.Items.Count
        End If

    End Sub

    'Clear Wishlist
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub

    'Sort Wishlist
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Sorted = True
    End Sub

    'Exit
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    'Add All
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For Each item As Object In ComboBox1.Items
            ListBox1.Items.Add(item)
        Next
    End Sub
End Class
