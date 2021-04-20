Public Class Form1

    'Load Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Simple Text Editor"
        RichTextBox1.SelectionFont = New Font("Tahoma", 20, FontStyle.Regular)
    End Sub

    'New
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        RichTextBox1.Clear()
        Me.Text = "Untitled"
    End Sub

    'Save
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Text Files|*.txt|All Files|*.*"
        If (SaveFileDialog1.ShowDialog() <> DialogResult.Cancel) Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
            Me.Text = SaveFileDialog1.FileName
        End If

    End Sub

    'Open
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Text Files|*.txt|All Files|*.*"
        If (OpenFileDialog1.ShowDialog() <> DialogResult.Cancel) Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText)
            Me.Text = OpenFileDialog1.FileName
        End If

    End Sub

    'Exit
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    'Cut
    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    'Copy
    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    'Paste
    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    'Select All
    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    'Undo
    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        If (RichTextBox1.CanUndo()) Then
            RichTextBox1.Undo()
        End If

    End Sub

    'Font
    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If (FontDialog1.ShowDialog() <> DialogResult.Cancel) Then
            RichTextBox1.SelectionFont = FontDialog1.Font
        End If

    End Sub

    'Text Color
    Private Sub TextColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextColorToolStripMenuItem.Click
        If (ColorDialog1.ShowDialog() <> DialogResult.Cancel) Then
            RichTextBox1.SelectionColor = ColorDialog1.Color
        End If

    End Sub

    'About Form
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim f As New AboutForm()
        f.Show()

    End Sub
End Class
