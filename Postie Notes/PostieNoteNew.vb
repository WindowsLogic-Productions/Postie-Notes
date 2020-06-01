Public Class PostieNoteNew
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.NoteName = Me.TextBox1.Text
        PostieNote.Show()
        PostieNote.Label1.Text = My.Settings.NoteName
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class