﻿namespace GSDIIITool
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.helpTabs = new System.Windows.Forms.TabControl();
            this.mainTool = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gameSettings = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.playerSettings = new System.Windows.Forms.TabPage();
            this.enemySettings = new System.Windows.Forms.TabPage();
            this.weaponCreation = new System.Windows.Forms.TabPage();
            this.powerUpCreation = new System.Windows.Forms.TabPage();
            this.formationCreator = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.helpTabs.SuspendLayout();
            this.mainTool.SuspendLayout();
            this.gameSettings.SuspendLayout();
            this.formationCreator.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpTabs
            // 
            this.helpTabs.Controls.Add(this.formationCreator);
            this.helpTabs.Controls.Add(this.mainTool);
            this.helpTabs.Controls.Add(this.gameSettings);
            this.helpTabs.Controls.Add(this.playerSettings);
            this.helpTabs.Controls.Add(this.enemySettings);
            this.helpTabs.Controls.Add(this.weaponCreation);
            this.helpTabs.Controls.Add(this.powerUpCreation);
            this.helpTabs.Location = new System.Drawing.Point(12, 12);
            this.helpTabs.Name = "helpTabs";
            this.helpTabs.SelectedIndex = 0;
            this.helpTabs.Size = new System.Drawing.Size(668, 627);
            this.helpTabs.TabIndex = 0;
            // 
            // mainTool
            // 
            this.mainTool.Controls.Add(this.textBox1);
            this.mainTool.Location = new System.Drawing.Point(4, 25);
            this.mainTool.Name = "mainTool";
            this.mainTool.Size = new System.Drawing.Size(660, 598);
            this.mainTool.TabIndex = 0;
            this.mainTool.Text = "Main Tool";
            this.mainTool.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(661, 592);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // gameSettings
            // 
            this.gameSettings.Controls.Add(this.textBox2);
            this.gameSettings.Location = new System.Drawing.Point(4, 25);
            this.gameSettings.Name = "gameSettings";
            this.gameSettings.Size = new System.Drawing.Size(660, 598);
            this.gameSettings.TabIndex = 1;
            this.gameSettings.Text = "Game Settings";
            this.gameSettings.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(654, 592);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "SOUND_TOGGLE(Boolean) True: Sound is on, False: Sound is off\r\nRESOLUTION(int x,in" +
    "t) int x: x resolution, y resolution\r\nINVERT_MOUSE_BUTTONS(Boolean) True: Invert" +
    " Buttons, False: Don\'t invert buttons";
            // 
            // playerSettings
            // 
            this.playerSettings.Location = new System.Drawing.Point(4, 25);
            this.playerSettings.Name = "playerSettings";
            this.playerSettings.Size = new System.Drawing.Size(660, 598);
            this.playerSettings.TabIndex = 2;
            this.playerSettings.Text = "Player Settings";
            this.playerSettings.UseVisualStyleBackColor = true;
            // 
            // enemySettings
            // 
            this.enemySettings.Location = new System.Drawing.Point(4, 25);
            this.enemySettings.Name = "enemySettings";
            this.enemySettings.Size = new System.Drawing.Size(660, 598);
            this.enemySettings.TabIndex = 3;
            this.enemySettings.Text = "Enemy Settings";
            this.enemySettings.UseVisualStyleBackColor = true;
            // 
            // weaponCreation
            // 
            this.weaponCreation.Location = new System.Drawing.Point(4, 25);
            this.weaponCreation.Name = "weaponCreation";
            this.weaponCreation.Size = new System.Drawing.Size(660, 598);
            this.weaponCreation.TabIndex = 4;
            this.weaponCreation.Text = "Weapon Creation";
            this.weaponCreation.UseVisualStyleBackColor = true;
            // 
            // powerUpCreation
            // 
            this.powerUpCreation.Location = new System.Drawing.Point(4, 25);
            this.powerUpCreation.Name = "powerUpCreation";
            this.powerUpCreation.Size = new System.Drawing.Size(660, 598);
            this.powerUpCreation.TabIndex = 5;
            this.powerUpCreation.Text = "Power Up Creation";
            this.powerUpCreation.UseVisualStyleBackColor = true;
            // 
            // formationCreator
            // 
            this.formationCreator.Controls.Add(this.textBox3);
            this.formationCreator.Location = new System.Drawing.Point(4, 25);
            this.formationCreator.Name = "formationCreator";
            this.formationCreator.Size = new System.Drawing.Size(660, 598);
            this.formationCreator.TabIndex = 6;
            this.formationCreator.Text = "Formation Creation";
            this.formationCreator.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(661, 592);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 651);
            this.Controls.Add(this.helpTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.helpTabs.ResumeLayout(false);
            this.mainTool.ResumeLayout(false);
            this.mainTool.PerformLayout();
            this.gameSettings.ResumeLayout(false);
            this.gameSettings.PerformLayout();
            this.formationCreator.ResumeLayout(false);
            this.formationCreator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl helpTabs;
        private System.Windows.Forms.TabPage mainTool;
        private System.Windows.Forms.TabPage gameSettings;
        private System.Windows.Forms.TabPage playerSettings;
        private System.Windows.Forms.TabPage enemySettings;
        private System.Windows.Forms.TabPage weaponCreation;
        private System.Windows.Forms.TabPage powerUpCreation;
        private System.Windows.Forms.TabPage formationCreator;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}