using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Postie_Notes
{
    public partial class PostieNote : Form
    {

        private System.Text.UTF8Encoding enc;
        private ICryptoTransform encryptor;
        private ICryptoTransform decryptor;

        private static readonly byte[] KEY_128 = { 42, 1, 52, 67, 231, 13, 94, 101, 123, 6, 0, 12, 32, 91, 4, 111, 31, 70, 21, 141, 123, 142, 234, 82, 95, 129, 187, 162, 12, 55, 98, 23 };
        private static readonly byte[] IV_128 = { 234, 12, 52, 44, 214, 222, 200, 109, 2, 98, 45, 76, 88, 53, 23, 78 };

        public PostieNote()
        {
            InitializeComponent();
        }

        #region "Form Movability"
        public bool MoveForm;
        public Point MoveForm_MousePosition;

        private void PostieNote_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MoveForm = true;
                MoveForm_MousePosition = e.Location;
            }
        }

        private void PostieNote_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveForm)
            {
                this.Location = new Point(this.Location.X + (e.Location.X - MoveForm_MousePosition.X),
                                           this.Location.Y + (e.Location.Y - MoveForm_MousePosition.Y));
            }
        }

        private void PostieNote_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MoveForm = false;
                this.Cursor = Cursors.Default;
            }
        }
        #endregion


        private void NewButton_Click(object sender, EventArgs e)
        {
            PostieNote postie = new PostieNote();
            postie.MdiParent = this.MdiParent as PostieMain;
            postie.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.Combine(Properties.Settings.Default.DefaultSaveDirectory, TextBox1.Text + ".pns");

            if (System.IO.File.Exists(filePath))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this note?", "Delete Note", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    System.IO.File.Delete(filePath);
                    Properties.Settings.Default.DiscardNote = "1";
                    this.Close();
                }
            }
            else
            {
                Properties.Settings.Default.DiscardNote = "1";
                this.Close();
            }
        }

        private void PostieNote_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.DiscardNote = "0";

            using (RijndaelManaged symmetricKey = new RijndaelManaged())
            {
                symmetricKey.Mode = CipherMode.CBC;

                enc = new UTF8Encoding();
                encryptor = symmetricKey.CreateEncryptor(KEY_128, IV_128);
                decryptor = symmetricKey.CreateDecryptor(KEY_128, IV_128);
            }
        }

        // Encrypt note text.
        private void EncryptNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sPlainText = this.RichTextBox1.Text;
       
            if (!string.IsNullOrEmpty(sPlainText))
            {
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, this.encryptor, CryptoStreamMode.Write);
                cryptoStream.Write(this.enc.GetBytes(sPlainText), 0, sPlainText.Length);
                cryptoStream.FlushFinalBlock();
                this.RichTextBox1.Text = Convert.ToBase64String(memoryStream.ToArray());
                memoryStream.Close();
                cryptoStream.Close();
            }
        }

        // Decrypt note text.
        private void DecryptNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] cypherTextBytes = Convert.FromBase64String(this.RichTextBox1.Text);
                MemoryStream memoryStream = new MemoryStream(cypherTextBytes);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, this.decryptor, CryptoStreamMode.Read);
                byte[] plainTextBytes = new byte[cypherTextBytes.Length];
                int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                memoryStream.Close();
                cryptoStream.Close();
                this.RichTextBox1.Text = this.enc.GetString(plainTextBytes, 0, decryptedByteCount);
            }
            catch (Exception)
            {
                MessageBox.Show("Text is already decrypted.");
            }
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RichTextBox1.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RichTextBox1.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RichTextBox1.Paste();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RichTextBox1.Text.Trim();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RichTextBox1.SelectAll();
        }
    }
}
