namespace GSDIIITool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameSettingsEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerSettingsEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enemyCreationToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weaponCreationToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerUpCreationToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formationEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkValidityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liberaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressLabel = new System.Windows.Forms.Label();
            this.percentLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameSettingsEditorToolStripMenuItem,
            this.playerSettingsEditorToolStripMenuItem,
            this.enemyCreationToolToolStripMenuItem,
            this.weaponCreationToolToolStripMenuItem,
            this.powerUpCreationToolToolStripMenuItem,
            this.formationEditorToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.newToolStripMenuItem.Text = "New";
            // 
            // gameSettingsEditorToolStripMenuItem
            // 
            this.gameSettingsEditorToolStripMenuItem.Name = "gameSettingsEditorToolStripMenuItem";
            this.gameSettingsEditorToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.gameSettingsEditorToolStripMenuItem.Text = "Game Settings Editor";
            this.gameSettingsEditorToolStripMenuItem.Click += new System.EventHandler(this.gameSettingsEditorToolStripMenuItem_Click);
            // 
            // playerSettingsEditorToolStripMenuItem
            // 
            this.playerSettingsEditorToolStripMenuItem.Name = "playerSettingsEditorToolStripMenuItem";
            this.playerSettingsEditorToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.playerSettingsEditorToolStripMenuItem.Text = "Player Settings Editor";
            this.playerSettingsEditorToolStripMenuItem.Click += new System.EventHandler(this.playerSettingsEditorToolStripMenuItem_Click);
            // 
            // enemyCreationToolToolStripMenuItem
            // 
            this.enemyCreationToolToolStripMenuItem.Name = "enemyCreationToolToolStripMenuItem";
            this.enemyCreationToolToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.enemyCreationToolToolStripMenuItem.Text = "Enemy Creation Tool";
            this.enemyCreationToolToolStripMenuItem.Click += new System.EventHandler(this.enemyCreationToolToolStripMenuItem_Click);
            // 
            // weaponCreationToolToolStripMenuItem
            // 
            this.weaponCreationToolToolStripMenuItem.Name = "weaponCreationToolToolStripMenuItem";
            this.weaponCreationToolToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.weaponCreationToolToolStripMenuItem.Text = "Weapon Creation Tool";
            // 
            // powerUpCreationToolToolStripMenuItem
            // 
            this.powerUpCreationToolToolStripMenuItem.Name = "powerUpCreationToolToolStripMenuItem";
            this.powerUpCreationToolToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.powerUpCreationToolToolStripMenuItem.Text = "Power Up Creation Tool";
            // 
            // formationEditorToolStripMenuItem
            // 
            this.formationEditorToolStripMenuItem.Name = "formationEditorToolStripMenuItem";
            this.formationEditorToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.formationEditorToolStripMenuItem.Text = "Formation Creation Tool";
            this.formationEditorToolStripMenuItem.Click += new System.EventHandler(this.formationEditorToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolSettingsToolStripMenuItem,
            this.checkValidityToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolSettingsToolStripMenuItem
            // 
            this.toolSettingsToolStripMenuItem.Name = "toolSettingsToolStripMenuItem";
            this.toolSettingsToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.toolSettingsToolStripMenuItem.Text = "Tool Settings";
            // 
            // checkValidityToolStripMenuItem
            // 
            this.checkValidityToolStripMenuItem.Name = "checkValidityToolStripMenuItem";
            this.checkValidityToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.checkValidityToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.checkValidityToolStripMenuItem.Text = "Check Validity";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liberaryToolStripMenuItem,
            this.toolBarsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // liberaryToolStripMenuItem
            // 
            this.liberaryToolStripMenuItem.Name = "liberaryToolStripMenuItem";
            this.liberaryToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.liberaryToolStripMenuItem.Text = "Library";
            // 
            // toolBarsToolStripMenuItem
            // 
            this.toolBarsToolStripMenuItem.Name = "toolBarsToolStripMenuItem";
            this.toolBarsToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.toolBarsToolStripMenuItem.Text = "Tool Bars";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(134, 24);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(83, 520);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(602, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(12, 520);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(65, 17);
            this.progressLabel.TabIndex = 2;
            this.progressLabel.Text = "Progress";
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Location = new System.Drawing.Point(692, 520);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(16, 17);
            this.percentLabel.TabIndex = 3;
            this.percentLabel.Text = "0";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "test";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(755, 482);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Harvester Developer Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameSettingsEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerSettingsEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enemyCreationToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weaponCreationToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerUpCreationToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formationEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liberaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolBarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkValidityToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

