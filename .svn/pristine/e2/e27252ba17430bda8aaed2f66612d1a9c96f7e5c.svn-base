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

        //When you click help on the tool strip
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //it brings up help form
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }

        //When you click on tool strip menu
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bring up help form
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

        //Open the open file dialog
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Game Settings|*.gst|Player Settings|*.pst|Enemy Settings|*.est";
            this.openFileDialog1.Title = "Open a game file";
            this.openFileDialog1.ShowDialog();
        }

        //brings up the formation editor
        private void formationEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormationPallete formationPallete = new FormationPallete();
            formationPallete.Show();
        }

        //Fills in template for game settings
        private void gameSettingsEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "@HEADER\nSOUND_TOGGLE=\nRESOLUTION=\nINVERT_MOUSE_BUTTONS=\nMOVE_UP=\nMOVE_LEFT=\nMOVE_" +
            "DOWN=\nMOVE_RIGHT=\n@END";
        }

        //Fills in template for player settings
        private void playerSettingsEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "@Header\nHEALTH=\nARMOR=\nSPEED=\nDAMAGE=\n@End";
        }

        //Fills in template for player settings
        private void enemyCreationToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "@Header\nHEALTH=\nARMOR=\nSPEED=\nDAMAGE=\n@End";
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to saveToolStripMenuItem.

            this.saveFileDialog.Filter = "Text|*.txt";
            this.saveFileDialog.Title = "Export a game file";

            this.saveFileDialog.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
