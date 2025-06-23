<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PostieSettings
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
        Me.DSLLabel = New System.Windows.Forms.Label()
        Me.DSLText = New System.Windows.Forms.TextBox()
        Me.DSLBrowseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DSLLabel
        '
        Me.DSLLabel.AutoSize = True
        Me.DSLLabel.Location = New System.Drawing.Point(12, 19)
        Me.DSLLabel.Name = "DSLLabel"
        Me.DSLLabel.Size = New System.Drawing.Size(110, 13)
        Me.DSLLabel.TabIndex = 0
        Me.DSLLabel.Text = "Default save location:"
        '
        'DSLText
        '
        Me.DSLText.Location = New System.Drawing.Point(128, 16)
        Me.DSLText.Name = "DSLText"
        Me.DSLText.Size = New System.Drawing.Size(173, 20)
        Me.DSLText.TabIndex = 3
        '
        'DSLBrowseButton
        '
        Me.DSLBrowseButton.Location = New System.Drawing.Point(307, 14)
        Me.DSLBrowseButton.Name = "DSLBrowseButton"
        Me.DSLBrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.DSLBrowseButton.TabIndex = 4
        Me.DSLBrowseButton.Text = "Browse..."
        Me.DSLBrowseButton.UseVisualStyleBackColor = True
        '
        'PostieSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 86)
        Me.Controls.Add(Me.DSLBrowseButton)
        Me.Controls.Add(Me.DSLText)
        Me.Controls.Add(Me.DSLLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PostieSettings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Postie Note Settings"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DSLLabel As Label
    Friend WithEvents DSLText As TextBox
    Friend WithEvents DSLBrowseButton As Button
End Class
