Imports System.IO

Public Class PostieNoteNew
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fileName As String = "C:\PostieNotes\" & TextBox1.Text & ".pns"
        Dim fi As New FileInfo(fileName)
        fi.Create()
        My.Settings.NoteName = TextBox1.Text
        PostieNote.Show()
        PostieNote.RichTextBox1.LoadFile(fileName, RichTextBoxStreamType.PlainText)
        PostieNote.Label1.Text = My.Settings.NoteName
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class