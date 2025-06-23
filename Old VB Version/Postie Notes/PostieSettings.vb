Public Class PostieSettings
    Private Sub PostieSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DSLText.Text = My.Settings.DefaultSaveDirectory
    End Sub

    Private Sub PostieSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.DefaultSaveDirectory = DSLText.Text
        My.Settings.Save()
    End Sub

    Private Sub DSLBrowseButton_Click(sender As Object, e As EventArgs) Handles DSLBrowseButton.Click
        Dim FolderDialogue As New FolderBrowserDialog
        FolderDialogue.ShowNewFolderButton = True
        If (FolderDialogue.ShowDialog() = DialogResult.OK) Then
            DSLText.Text = FolderDialogue.SelectedPath
        End If
    End Sub
End Class