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
    public partial class IOForm : Form
    {
        //Attributes
        private TextBox _fileName;
        private TextBox _filePath;

        //Propeties
        public TextBox FileName { get { return _fileName; } }
        public TextBox FilePath { get { return _filePath; } }

        public IOForm()
        {
            InitializeComponent();
            _fileName = this.FileNameBox;
            _filePath = this.SetPathBox;
        }

        private void IOForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                f.Dispose();
            }
        }
    }
}
