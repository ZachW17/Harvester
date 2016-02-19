namespace GSDIIITool
{
    partial class IOForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IOForm));
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.SetPathBox = new System.Windows.Forms.TextBox();
            this.SetFilePath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FileNameBox
            // 
            this.FileNameBox.Location = new System.Drawing.Point(12, 29);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(100, 22);
            this.FileNameBox.TabIndex = 50;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(12, 9);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(232, 17);
            this.FileNameLabel.TabIndex = 49;
            this.FileNameLabel.Text = "File Name (don\'t include .frm or .txt)";
            // 
            // SetPathBox
            // 
            this.SetPathBox.Location = new System.Drawing.Point(12, 74);
            this.SetPathBox.Name = "SetPathBox";
            this.SetPathBox.Size = new System.Drawing.Size(748, 22);
            this.SetPathBox.TabIndex = 48;
            this.SetPathBox.Text = "C:\\Users\\Ted\\Documents\\Visual Studio 2010\\Projects\\Q3\\BigProject\\GSD III Project\\" +
    "Harvester\\Harvester\\Mods\\Formations";
            // 
            // SetFilePath
            // 
            this.SetFilePath.AutoSize = true;
            this.SetFilePath.Location = new System.Drawing.Point(9, 54);
            this.SetFilePath.Name = "SetFilePath";
            this.SetFilePath.Size = new System.Drawing.Size(88, 17);
            this.SetFilePath.TabIndex = 47;
            this.SetFilePath.Text = "Set File Path";
            // 
            // IOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 130);
            this.Controls.Add(this.FileNameBox);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.SetPathBox);
            this.Controls.Add(this.SetFilePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IOForm";
            this.Text = "IOForm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IOForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox SetPathBox;
        private System.Windows.Forms.Label SetFilePath;
    }
}