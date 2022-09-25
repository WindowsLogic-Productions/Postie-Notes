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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.RichTextBox1.Location = New System.Drawing.Point(-1, 26)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(202, 175)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'TextBoxOptions
        '
        Me.TextBoxOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator1, Me.SelectAllToolStripMenuItem, Me.ToolStripSeparator2, Me.BlueToolStripMenuItem, Me.GreenToolStripMenuItem, Me.PinkToolStripMenuItem, Me.PurpleToolStripMenuItem, Me.WhiteToolStripMenuItem, Me.YellowToolStripMenuItem, Me.YellowToolStripMenuItem1, Me.ToolStripSeparator3, Me.HideToolStripMenuItem})
        Me.TextBoxOptions.Name = "TextBoxOptions"
        Me.TextBoxOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TextBoxOptions.Size = New System.Drawing.Size(142, 308)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'PinkToolStripMenuItem
        '
        Me.PinkToolStripMenuItem.Name = "PinkToolStripMenuItem"
        Me.PinkToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PinkToolStripMenuItem.Text = "Pink"
        '
        'PurpleToolStripMenuItem
        '
        Me.PurpleToolStripMenuItem.Name = "PurpleToolStripMenuItem"
        Me.PurpleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PurpleToolStripMenuItem.Text = "Purple"
        '
        'WhiteToolStripMenuItem
        '
        Me.WhiteToolStripMenuItem.Name = "WhiteToolStripMenuItem"
        Me.WhiteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.WhiteToolStripMenuItem.Text = "White"
        '
        'YellowToolStripMenuItem
        '
        Me.YellowToolStripMenuItem.Name = "YellowToolStripMenuItem"
        Me.YellowToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.YellowToolStripMenuItem.Text = "Black"
        '
        'YellowToolStripMenuItem1
        '
        Me.YellowToolStripMenuItem1.Name = "YellowToolStripMenuItem1"
        Me.YellowToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.YellowToolStripMenuItem1.Text = "Yellow"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ContextMenuStrip = Me.TextBoxOptions
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "00000000"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.ContextMenuStrip = Me.TextBoxOptions
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = Global.Postie_Notes.My.Resources.Resources.WinMore
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 28)
        Me.Button2.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Button2, "New Note...")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.ContextMenuStrip = Me.TextBoxOptions
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = Global.Postie_Notes.My.Resources.Resources.WinBin
        Me.Button1.Location = New System.Drawing.Point(169, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 28)
        Me.Button1.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Button1, "Delete Note")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PostieNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(200, 200)
        Me.ContextMenuStrip = Me.TextBoxOptions
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(176, 174)
        Me.Name = "PostieNote"
        Me.ShowInTaskbar = False
        Me.Text = "Postie_Note"
        Me.TextBoxOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
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
End Class
