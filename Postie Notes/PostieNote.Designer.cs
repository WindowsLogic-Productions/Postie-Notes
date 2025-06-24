namespace Postie_Notes
{
    partial class PostieNote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TextBoxOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EncryptNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DecryptNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YellowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TextBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.TextBox1.Location = new System.Drawing.Point(37, 8);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(126, 20);
            this.TextBox1.TabIndex = 6;
            this.TextBox1.Text = "New Note";
            // 
            // NewButton
            // 
            this.NewButton.BackColor = System.Drawing.Color.Transparent;
            this.NewButton.FlatAppearance.BorderSize = 0;
            this.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewButton.Image = global::Postie_Notes.Properties.Resources.WinMore;
            this.NewButton.Location = new System.Drawing.Point(3, 3);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(28, 28);
            this.NewButton.TabIndex = 5;
            this.NewButton.UseVisualStyleBackColor = false;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Image = global::Postie_Notes.Properties.Resources.WinBin;
            this.DeleteButton.Location = new System.Drawing.Point(169, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(28, 28);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TextBoxOptions
            // 
            this.TextBoxOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EncryptNoteToolStripMenuItem,
            this.DecryptNoteToolStripMenuItem,
            this.ToolStripSeparator4,
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.ToolStripSeparator1,
            this.SelectAllToolStripMenuItem,
            this.ToolStripSeparator2,
            this.BlueToolStripMenuItem,
            this.GreenToolStripMenuItem,
            this.PinkToolStripMenuItem,
            this.PurpleToolStripMenuItem,
            this.WhiteToolStripMenuItem,
            this.YellowToolStripMenuItem,
            this.YellowToolStripMenuItem1,
            this.ToolStripSeparator3,
            this.DeleteNoteToolStripMenuItem,
            this.HideToolStripMenuItem});
            this.TextBoxOptions.Name = "TextBoxOptions";
            this.TextBoxOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TextBoxOptions.Size = new System.Drawing.Size(218, 402);
            // 
            // EncryptNoteToolStripMenuItem
            // 
            this.EncryptNoteToolStripMenuItem.Name = "EncryptNoteToolStripMenuItem";
            this.EncryptNoteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.EncryptNoteToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.EncryptNoteToolStripMenuItem.Text = "Encrypt note";
            this.EncryptNoteToolStripMenuItem.Click += new System.EventHandler(this.EncryptNoteToolStripMenuItem_Click);
            // 
            // DecryptNoteToolStripMenuItem
            // 
            this.DecryptNoteToolStripMenuItem.Name = "DecryptNoteToolStripMenuItem";
            this.DecryptNoteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.DecryptNoteToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.DecryptNoteToolStripMenuItem.Text = "Decrypt note";
            this.DecryptNoteToolStripMenuItem.Click += new System.EventHandler(this.DecryptNoteToolStripMenuItem_Click);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(214, 6);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.CutToolStripMenuItem.Text = "Cut";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.CopyToolStripMenuItem.Text = "Copy";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.PasteToolStripMenuItem.Text = "Paste";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.SelectAllToolStripMenuItem.Text = "Select All";
            this.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(214, 6);
            // 
            // BlueToolStripMenuItem
            // 
            this.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem";
            this.BlueToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.BlueToolStripMenuItem.Text = "Blue";
            // 
            // GreenToolStripMenuItem
            // 
            this.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem";
            this.GreenToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.GreenToolStripMenuItem.Text = "Green";
            // 
            // PinkToolStripMenuItem
            // 
            this.PinkToolStripMenuItem.Name = "PinkToolStripMenuItem";
            this.PinkToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.PinkToolStripMenuItem.Text = "Pink";
            // 
            // PurpleToolStripMenuItem
            // 
            this.PurpleToolStripMenuItem.Name = "PurpleToolStripMenuItem";
            this.PurpleToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.PurpleToolStripMenuItem.Text = "Purple";
            // 
            // WhiteToolStripMenuItem
            // 
            this.WhiteToolStripMenuItem.Name = "WhiteToolStripMenuItem";
            this.WhiteToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.WhiteToolStripMenuItem.Text = "White";
            // 
            // YellowToolStripMenuItem
            // 
            this.YellowToolStripMenuItem.Name = "YellowToolStripMenuItem";
            this.YellowToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.YellowToolStripMenuItem.Text = "Black";
            // 
            // YellowToolStripMenuItem1
            // 
            this.YellowToolStripMenuItem1.Name = "YellowToolStripMenuItem1";
            this.YellowToolStripMenuItem1.Size = new System.Drawing.Size(217, 22);
            this.YellowToolStripMenuItem1.Text = "Yellow";
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(214, 6);
            // 
            // DeleteNoteToolStripMenuItem
            // 
            this.DeleteNoteToolStripMenuItem.Name = "DeleteNoteToolStripMenuItem";
            this.DeleteNoteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Delete)));
            this.DeleteNoteToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.DeleteNoteToolStripMenuItem.Text = "Delete note";
            // 
            // HideToolStripMenuItem
            // 
            this.HideToolStripMenuItem.Name = "HideToolStripMenuItem";
            this.HideToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.HideToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.HideToolStripMenuItem.Text = "Save and close";
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox1.ContextMenuStrip = this.TextBoxOptions;
            this.RichTextBox1.Location = new System.Drawing.Point(3, 37);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(194, 160);
            this.RichTextBox1.TabIndex = 7;
            this.RichTextBox1.Text = "";
            // 
            // PostieNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.ControlBox = false;
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.DeleteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(216, 216);
            this.Name = "PostieNote";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.PostieNote_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PostieNote_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PostieNote_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PostieNote_MouseUp);
            this.TextBoxOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Button NewButton;
        internal System.Windows.Forms.Button DeleteButton;
        internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal System.Windows.Forms.ContextMenuStrip TextBoxOptions;
        internal System.Windows.Forms.ToolStripMenuItem EncryptNoteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DecryptNoteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        internal System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripMenuItem BlueToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem GreenToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PinkToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PurpleToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem WhiteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem YellowToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem YellowToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripMenuItem DeleteNoteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem HideToolStripMenuItem;
        internal System.Windows.Forms.RichTextBox RichTextBox1;
    }
}