Imports System.IO

Public Class PostieMain
    Private Sub NewNoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewNoteToolStripMenuItem.Click
        Dim npost As New PostieNoteNew
        npost.Show()
    End Sub

    Private Sub PostieMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each arg As String In My.Application.CommandLineArgs
            Dim postie As New PostieNote
            postie.Show()
            postie.RichTextBox1.Text = File.ReadAllText(arg)
        Next

        Dim root As String = "C:\PostieNotes"
        If Not Directory.Exists(root) Then
            Directory.CreateDirectory(root)
        End If

        WebBrowser1.Navigate("C:\PostieNotes")

        Environment.GetCommandLineArgs()
    End Sub

    Private Sub OpenNoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenNoteToolStripMenuItem.Click
        OpenFileDialog1.Title = "Open Postie Note"
        OpenFileDialog1.Filter = "Postie Note|*.pns"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim postie As New PostieNote
            postie.Show()
            postie.RichTextBox1.Text = File.ReadAllText(OpenFileDialog1.FileName)
        End If
    End Sub
End Class
