Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography

Public Class PostieNote
    Private enc As System.Text.UTF8Encoding
    Private encryptor As ICryptoTransform
    Private decryptor As ICryptoTransform
#Region "Form Moveability"
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub
#End Region

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        RichTextBox1.SelectedText.Trim()
    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        Dim postie As New PostieNote
        postie.MdiParent = PostieMain
        postie.Show()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If File.Exists(My.Settings.DefaultSaveDirectory + "\" + TextBox1.Text + ".pns") = True Then
            If MsgBox("Are you sure you want to delete this note?", MsgBoxStyle.YesNo, "Delete Note") = MsgBoxResult.Yes Then
                My.Computer.FileSystem.DeleteFile(My.Settings.DefaultSaveDirectory + "\" + TextBox1.Text + ".pns")
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        Me.RichTextBox1.BackColor = Color.PowderBlue
        Me.TextBox1.BackColor = Color.PowderBlue
        Me.BackColor = Color.PowderBlue
    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        RichTextBox1.SaveFile(My.Settings.DefaultSaveDirectory + "\" + TextBox1.Text + ".pns")
        Me.Close()
    End Sub

    Private Sub EncryptNoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncryptNoteToolStripMenuItem.Click
        Dim sPlainText As String = Me.RichTextBox1.Text
        If Not String.IsNullOrEmpty(sPlainText) Then
            Dim memoryStream As MemoryStream = New MemoryStream()
            Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, Me.encryptor, CryptoStreamMode.Write)
            cryptoStream.Write(Me.enc.GetBytes(sPlainText), 0, sPlainText.Length)
            cryptoStream.FlushFinalBlock()
            Me.RichTextBox1.Text = Convert.ToBase64String(memoryStream.ToArray())
            memoryStream.Close()
            cryptoStream.Close()
        End If
    End Sub

    Private Sub PostieNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim KEY_128 As Byte() = {42, 1, 52, 67, 231, 13, 94, 101, 123, 6, 0, 12, 32, 91, 4, 111, 31, 70, 21, 141, 123, 142, 234, 82, 95, 129, 187, 162, 12, 55, 98, 23}
        Dim IV_128 As Byte() = {234, 12, 52, 44, 214, 222, 200, 109, 2, 98, 45, 76, 88, 53, 23, 78}
        Dim symmetricKey As RijndaelManaged = New RijndaelManaged()
        symmetricKey.Mode = CipherMode.CBC

        Me.enc = New System.Text.UTF8Encoding
        Me.encryptor = symmetricKey.CreateEncryptor(KEY_128, IV_128)
        Me.decryptor = symmetricKey.CreateDecryptor(KEY_128, IV_128)
    End Sub

    Private Sub DecryptNoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecryptNoteToolStripMenuItem.Click
        Try
            Dim cypherTextBytes As Byte() = Convert.FromBase64String(Me.RichTextBox1.Text)
            Dim memoryStream As MemoryStream = New MemoryStream(cypherTextBytes)
            Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, Me.decryptor, CryptoStreamMode.Read)
            Dim plainTextBytes(cypherTextBytes.Length) As Byte
            Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)
            memoryStream.Close()
            cryptoStream.Close()
            Me.RichTextBox1.Text = Me.enc.GetString(plainTextBytes, 0, decryptedByteCount)
        Catch
            MsgBox("Text is already decrypted.")
        End Try
    End Sub

    Private Sub DeleteNoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteNoteToolStripMenuItem.Click
        If File.Exists(My.Settings.DefaultSaveDirectory + "\" + TextBox1.Text + ".pns") = True Then
            If MsgBox("Are you sure you want to delete this note?", MsgBoxStyle.YesNo, "Delete Note") = MsgBoxResult.Yes Then
                My.Computer.FileSystem.DeleteFile(My.Settings.DefaultSaveDirectory + "\" + TextBox1.Text + ".pns")
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub
End Class