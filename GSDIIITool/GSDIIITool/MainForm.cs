using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GSDIIITool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                // Displays a SaveFileDialog so the user can save the Image
                // assigned to saveToolStripMenuItem.
                
                this.saveFileDialog.Filter = "Game Settings|*.gst|Player Settings|*.pst|Enemy Settings|*.est";
                this.saveFileDialog.Title = "Save a game file";
                
                this.saveFileDialog.ShowDialog();
            }
        }
    }
}
