//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Postie_Notes
{
    public partial class PostieMain : Form
    {
        public PostieMain()
        {
            InitializeComponent();
        }

        private void NewNoteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            PostieNote postie = new PostieNote();
            postie.MdiParent = this;
            postie.Show();
        }

        private void PostieMain_Load(object sender, System.EventArgs e)
        {
            //string[] args = ;

            //foreach (string arg in args) 
            //{
            //    PostieNote postie = new PostieNote();
            //    postie.Show();
            //    postie.richTextBoxNote.Text = File.ReadAllText(arg);
            //}

            string root = "C:\\PostieNotes";
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }

            //System.Environment.GetCommandLineArgs();
        }

        private void OpenMenuItem_Click(object sender, System.EventArgs e)
        {
            openFileDialog1.InitialDirectory = Properties.Settings.Default.DefaultSaveDirectory;
            openFileDialog1.Title = "Open Postie Note";
            openFileDialog1.Filter = "Postie Note|*.pns";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PostieNote postie = new PostieNote();
                postie.MdiParent = this;
                postie.Show();
                postie.richTextBoxNote.LoadFile(openFileDialog1.FileName);
                postie.textBoxNoteTitle.Text = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
            }
        }

        private void OpenNoteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            openFileDialog1.InitialDirectory = Properties.Settings.Default.DefaultSaveDirectory;
            openFileDialog1.Title = "Open Postie Note";
            openFileDialog1.Filter = "Postie Note|*.pns";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PostieNote postie = new PostieNote();
                postie.Show();
                postie.richTextBoxNote.LoadFile(openFileDialog1.FileName);
                postie.textBoxNoteTitle.Text = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
            }
        }

        private void BackupNotesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog FolderDialogue = new FolderBrowserDialog();
            FolderDialogue.ShowNewFolderButton = true;
            string SourcePath = "C:\\PostieNotes";
            string DestinationPath;
            if (FolderDialogue.ShowDialog() == DialogResult.OK)
            {
                DestinationPath = FolderDialogue.SelectedPath;
                System.Environment.SpecialFolder root = FolderDialogue.RootFolder;
                string newDirectory = System.IO.Path.Combine(DestinationPath, Path.GetFileName(Path.GetDirectoryName(SourcePath)));
                if (!Directory.Exists(newDirectory))
                {
                    Directory.CreateDirectory(newDirectory);
                }
                Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(SourcePath, newDirectory);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void ClearMemoboardToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            bool formNotOpen = true;
            if (MdiChildren.Length > 0)
            {
                if (MessageBox.Show("Are you sure you want to clear the memoboard? Doing so will close all Postie Notes without saving their contents. Please select 'No' if you want to save your notes.", "Clear Memoboard", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (Form frm in this.MdiChildren)
                    {
                        frm.Close();
                    }
                }
                else
                {
                    // Nothing.
                }
            }
        }

        private void SettingsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            PostieSettings postieSettings = new PostieSettings();
            postieSettings.ShowDialog();
        }
    }
}
