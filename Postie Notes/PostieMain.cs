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
    }
}
