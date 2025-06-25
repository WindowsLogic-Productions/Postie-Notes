using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
using System.Windows.Forms;

namespace Postie_Notes
{
    public partial class PostieSettings : Form
    {
        public PostieSettings()
        {
            InitializeComponent();
        }

        private void DSLBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderDialogue = new FolderBrowserDialog();
            FolderDialogue.ShowNewFolderButton = true;
            if (FolderDialogue.ShowDialog() == DialogResult.OK)
            {
                DSLText.Text = FolderDialogue.SelectedPath;
            }
        }

        private void PostieSettings_Load(object sender, EventArgs e)
        {
            DSLText.Text = Properties.Settings.Default.DefaultSaveDirectory;
        }

        private void PostieSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.DefaultSaveDirectory = DSLText.Text;
            Properties.Settings.Default.Save();
        }
    }
}
