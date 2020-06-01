<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PostieMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.NewNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAllNotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewNoteToolStripMenuItem, Me.OpenNoteToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteNoteToolStripMenuItem, Me.DeleteAllNotesToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 24)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(284, 238)
        Me.ListBox1.TabIndex = 1
        '
        'NewNoteToolStripMenuItem
        '
        Me.NewNoteToolStripMenuItem.Name = "NewNoteToolStripMenuItem"
        Me.NewNoteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewNoteToolStripMenuItem.Text = "New note..."
        '
        'OpenNoteToolStripMenuItem
        '
        Me.OpenNoteToolStripMenuItem.Name = "OpenNoteToolStripMenuItem"
        Me.OpenNoteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenNoteToolStripMenuItem.Text = "Open note..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'DeleteNoteToolStripMenuItem
        '
        Me.DeleteNoteToolStripMenuItem.Name = "DeleteNoteToolStripMenuItem"
        Me.DeleteNoteToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.DeleteNoteToolStripMenuItem.Text = "Delete note..."
        '
        'DeleteAllNotesToolStripMenuItem
        '
        Me.DeleteAllNotesToolStripMenuItem.Name = "DeleteAllNotesToolStripMenuItem"
        Me.DeleteAllNotesToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.DeleteAllNotesToolStripMenuItem.Text = "Delete all notes..."
        '
        'PostieMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "PostieMain"
        Me.Text = "Postie Memoboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents NewNoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenNoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DeleteNoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAllNotesToolStripMenuItem As ToolStripMenuItem
End Class
