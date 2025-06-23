Imports System.IO

Public Class PostieMain
    Private Sub NewNoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewNoteToolStripMenuItem.Click
        Dim postie As New PostieNote
        postie.MdiParent = Me
        postie.Show()
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

        Environment.GetCommandLineArgs()
    End Sub

    Private Sub OpenNoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenNoteToolStripMenuItem.Click
        OpenFileDialog1.InitialDirectory = My.Settings.DefaultSaveDirectory
        OpenFileDialog1.Title = "Open Postie Note"
        OpenFileDialog1.Filter = "Postie Note|*.pns"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim postie As New PostieNote
            postie.Show()
            postie.RichTextBox1.LoadFile(OpenFileDialog1.FileName)
            postie.TextBox1.Text = System.IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub BackupNotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupNotesToolStripMenuItem.Click
        Dim FolderDialogue As New FolderBrowserDialog
        FolderDialogue.ShowNewFolderButton = True
        Dim SourcePath As String = "C:\PostieNotes"
        Dim DestinationPath As String
        If (FolderDialogue.ShowDialog() = DialogResult.OK) Then
            DestinationPath = FolderDialogue.SelectedPath
            Dim root As Environment.SpecialFolder = FolderDialogue.RootFolder
            Dim newDirectory As String = System.IO.Path.Combine(DestinationPath, Path.GetFileName(Path.GetDirectoryName(SourcePath)))
            If Not (Directory.Exists(newDirectory)) Then
                Directory.CreateDirectory(newDirectory)
            End If
            Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(SourcePath, newDirectory)
        End If
    End Sub

    Private Sub OpenMenuItem_Click(sender As Object, e As EventArgs) Handles OpenMenuItem.Click
        OpenFileDialog1.InitialDirectory = My.Settings.DefaultSaveDirectory
        OpenFileDialog1.Title = "Open Postie Note"
        OpenFileDialog1.Filter = "Postie Note|*.pns"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim postie As New PostieNote
            postie.MdiParent = Me
            postie.Show()
            postie.RichTextBox1.LoadFile(OpenFileDialog1.FileName)
            postie.TextBox1.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
            postie.TextBox1.Text = System.IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub ClearMemoboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearMemoboardToolStripMenuItem.Click
        Dim FormNotOpen As Boolean = True
        If MdiChildren.Length > 0 Then
            If MsgBox("Are you sure you want to clear the memoboard? Doing so will close all Postie Notes without saving their contents. Please select 'No' if you want to save your notes.", MsgBoxStyle.YesNo, "Clear Memoboard") = MsgBoxResult.Yes Then
                For Each frm As System.Windows.Forms.Form In Me.MdiChildren
                    frm.Close()
                Next frm
            Else

            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        PostieSettings.ShowDialog()
    End Sub

    Private Sub PostieMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
End Class
