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
    }
}
