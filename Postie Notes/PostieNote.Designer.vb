<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PostieNote
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBoxOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EncryptNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecryptNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YellowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YellowToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBoxOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.ContextMenuStrip = Me.TextBoxOptions
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 37)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(194, 160)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'TextBoxOptions
        '
        Me.TextBoxOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncryptNoteToolStripMenuItem, Me.DecryptNoteToolStripMenuItem, Me.ToolStripSeparator4, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator1, Me.SelectAllToolStripMenuItem, Me.ToolStripSeparator2, Me.BlueToolStripMenuItem, Me.GreenToolStripMenuItem, Me.PinkToolStripMenuItem, Me.PurpleToolStripMenuItem, Me.WhiteToolStripMenuItem, Me.YellowToolStripMenuItem, Me.YellowToolStripMenuItem1, Me.ToolStripSeparator3, Me.DeleteNoteToolStripMenuItem, Me.HideToolStripMenuItem})
        Me.TextBoxOptions.Name = "TextBoxOptions"
        Me.TextBoxOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TextBoxOptions.Size = New System.Drawing.Size(218, 402)
        '
        'EncryptNoteToolStripMenuItem
        '
        Me.EncryptNoteToolStripMenuItem.Name = "EncryptNoteToolStripMenuItem"
        Me.EncryptNoteToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EncryptNoteToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.EncryptNoteToolStripMenuItem.Text = "Encrypt note"
        '
        'DecryptNoteToolStripMenuItem
        '
        Me.DecryptNoteToolStripMenuItem.Name = "DecryptNoteToolStripMenuItem"
        Me.DecryptNoteToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DecryptNoteToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.DecryptNoteToolStripMenuItem.Text = "Decrypt note"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(190, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(190, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(190, 6)
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'PinkToolStripMenuItem
        '
        Me.PinkToolStripMenuItem.Name = "PinkToolStripMenuItem"
        Me.PinkToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.PinkToolStripMenuItem.Text = "Pink"
        '
        'PurpleToolStripMenuItem
        '
        Me.PurpleToolStripMenuItem.Name = "PurpleToolStripMenuItem"
        Me.PurpleToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.PurpleToolStripMenuItem.Text = "Purple"
        '
        'WhiteToolStripMenuItem
        '
        Me.WhiteToolStripMenuItem.Name = "WhiteToolStripMenuItem"
        Me.WhiteToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.WhiteToolStripMenuItem.Text = "White"
        '
        'YellowToolStripMenuItem
        '
        Me.YellowToolStripMenuItem.Name = "YellowToolStripMenuItem"
        Me.YellowToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.YellowToolStripMenuItem.Text = "Black"
        '
        'YellowToolStripMenuItem1
        '
        Me.YellowToolStripMenuItem1.Name = "YellowToolStripMenuItem1"
        Me.YellowToolStripMenuItem1.Size = New System.Drawing.Size(193, 22)
        Me.YellowToolStripMenuItem1.Text = "Yellow"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(190, 6)
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.HideToolStripMenuItem.Text = "Save and close"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextBox1.Location = New System.Drawing.Point(37, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(126, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "New Note"
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Note name.")
        '
        'NewButton
        '
        Me.NewButton.BackColor = System.Drawing.Color.Transparent
        Me.NewButton.ContextMenuStrip = Me.TextBoxOptions
        Me.NewButton.FlatAppearance.BorderSize = 0
        Me.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton.Image = Global.Postie_Notes.My.Resources.Resources.WinMore
        Me.NewButton.Location = New System.Drawing.Point(3, 3)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(28, 28)
        Me.NewButton.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.NewButton, "New note.")
        Me.NewButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteButton.BackColor = System.Drawing.Color.Transparent
        Me.DeleteButton.ContextMenuStrip = Me.TextBoxOptions
        Me.DeleteButton.FlatAppearance.BorderSize = 0
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteButton.Image = Global.Postie_Notes.My.Resources.Resources.WinBin
        Me.DeleteButton.Location = New System.Drawing.Point(169, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(28, 28)
        Me.DeleteButton.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.DeleteButton, "Delete note.")
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'DeleteNoteToolStripMenuItem
        '
        Me.DeleteNoteToolStripMenuItem.Name = "DeleteNoteToolStripMenuItem"
        Me.DeleteNoteToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.DeleteNoteToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.DeleteNoteToolStripMenuItem.Text = "Delete note"
        '
        'PostieNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(200, 200)
        Me.ContextMenuStrip = Me.TextBoxOptions
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.NewButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.RichTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MinimumSize = New System.Drawing.Size(176, 174)
        Me.Name = "PostieNote"
        Me.ShowInTaskbar = False
        Me.TextBoxOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents DeleteButton As Button
    Friend WithEvents NewButton As Button
    Friend WithEvents TextBoxOptions As ContextMenuStrip
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PinkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurpleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YellowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YellowToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents HideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents EncryptNoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents DecryptNoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteNoteToolStripMenuItem As ToolStripMenuItem
End Class
