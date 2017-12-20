namespace Homework3
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
            this.components = new System.ComponentModel.Container();
            this.cmOpen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openPreferencesModalyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesModelessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.File = new System.Windows.Forms.MenuStrip();
            this.ellictipChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipticChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangularChildToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmOpen.SuspendLayout();
            this.File.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmOpen
            // 
            this.cmOpen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPreferencesModalyToolStripMenuItem,
            this.openPreferencesModelessToolStripMenuItem});
            this.cmOpen.Name = "contextMenuStrip1";
            this.cmOpen.Size = new System.Drawing.Size(221, 48);
            // 
            // openPreferencesModalyToolStripMenuItem
            // 
            this.openPreferencesModalyToolStripMenuItem.Name = "openPreferencesModalyToolStripMenuItem";
            this.openPreferencesModalyToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.openPreferencesModalyToolStripMenuItem.Text = "Open Preferences Modally";
            this.openPreferencesModalyToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesModalyToolStripMenuItem_Click);
            // 
            // openPreferencesModelessToolStripMenuItem
            // 
            this.openPreferencesModelessToolStripMenuItem.Name = "openPreferencesModelessToolStripMenuItem";
            this.openPreferencesModelessToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.openPreferencesModelessToolStripMenuItem.Text = "Open Preferences Modeless";
            this.openPreferencesModelessToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesModelessToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDown = this.cmOpen;
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // File
            // 
            this.File.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ellictipChildToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.File.Location = new System.Drawing.Point(0, 0);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(463, 24);
            this.File.TabIndex = 3;
            this.File.Text = "menuStrip1";
            // 
            // ellictipChildToolStripMenuItem
            // 
            this.ellictipChildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ellipticChildToolStripMenuItem,
            this.rectangularChildToolStripMenuItem1,
            this.closeToolStripMenuItem1});
            this.ellictipChildToolStripMenuItem.Name = "ellictipChildToolStripMenuItem";
            this.ellictipChildToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.ellictipChildToolStripMenuItem.Text = "File";
            // 
            // ellipticChildToolStripMenuItem
            // 
            this.ellipticChildToolStripMenuItem.Name = "ellipticChildToolStripMenuItem";
            this.ellipticChildToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ellipticChildToolStripMenuItem.Text = "Elliptic Child";
            this.ellipticChildToolStripMenuItem.Click += new System.EventHandler(this.ellipticChildToolStripMenuItem_Click);
            // 
            // rectangularChildToolStripMenuItem1
            // 
            this.rectangularChildToolStripMenuItem1.Name = "rectangularChildToolStripMenuItem1";
            this.rectangularChildToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.rectangularChildToolStripMenuItem1.Text = "Rectangular Child";
            this.rectangularChildToolStripMenuItem1.Click += new System.EventHandler(this.rectangularChildToolStripMenuItem1_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 322);
            this.Controls.Add(this.File);
            this.MainMenuStrip = this.File;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.cmOpen.ResumeLayout(false);
            this.File.ResumeLayout(false);
            this.File.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmOpen;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesModalyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesModelessToolStripMenuItem;
        private System.Windows.Forms.MenuStrip File;
        private System.Windows.Forms.ToolStripMenuItem ellictipChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipticChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangularChildToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
    }
}

