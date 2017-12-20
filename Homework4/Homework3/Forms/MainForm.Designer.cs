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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cmOpen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openPreferencesModalyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesModelessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.File = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipticChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangularChildToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmOpen.SuspendLayout();
            this.File.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmOpen
            // 
            this.cmOpen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPreferencesModalyToolStripMenuItem,
            this.openPreferencesModelessToolStripMenuItem});
            this.cmOpen.Name = "contextMenuStrip1";
            this.cmOpen.OwnerItem = this.preferencesMenu;
            this.cmOpen.Size = new System.Drawing.Size(261, 48);
            // 
            // openPreferencesModalyToolStripMenuItem
            // 
            this.openPreferencesModalyToolStripMenuItem.Name = "openPreferencesModalyToolStripMenuItem";
            this.openPreferencesModalyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.openPreferencesModalyToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.openPreferencesModalyToolStripMenuItem.Text = "Open Preferences Modally";
            this.openPreferencesModalyToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesModalyToolStripMenuItem_Click);
            // 
            // openPreferencesModelessToolStripMenuItem
            // 
            this.openPreferencesModelessToolStripMenuItem.Name = "openPreferencesModelessToolStripMenuItem";
            this.openPreferencesModelessToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.openPreferencesModelessToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.openPreferencesModelessToolStripMenuItem.Text = "Open Preferences Modeless";
            this.openPreferencesModelessToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesModelessToolStripMenuItem_Click);
            // 
            // preferencesMenu
            // 
            this.preferencesMenu.DropDown = this.cmOpen;
            this.preferencesMenu.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.preferencesMenu.Name = "preferencesMenu";
            this.preferencesMenu.Size = new System.Drawing.Size(80, 20);
            this.preferencesMenu.Text = "Preferences";
            // 
            // File
            // 
            this.File.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.preferencesMenu,
            this.helpToolStripMenuItem});
            this.File.Location = new System.Drawing.Point(0, 0);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(463, 24);
            this.File.TabIndex = 3;
            this.File.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ellipticChildToolStripMenuItem,
            this.rectangularChildToolStripMenuItem1,
            this.customChildToolStripMenuItem,
            this.closeToolStripMenuItem1,
            this.toolStripMenuItem});
            this.fileMenu.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            this.fileMenu.Click += new System.EventHandler(this.fileMenu_Click);
            // 
            // ellipticChildToolStripMenuItem
            // 
            this.ellipticChildToolStripMenuItem.Name = "ellipticChildToolStripMenuItem";
            this.ellipticChildToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ellipticChildToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.ellipticChildToolStripMenuItem.Text = "Elliptic Child";
            this.ellipticChildToolStripMenuItem.Click += new System.EventHandler(this.ellipticChildToolStripMenuItem_Click);
            // 
            // rectangularChildToolStripMenuItem1
            // 
            this.rectangularChildToolStripMenuItem1.Name = "rectangularChildToolStripMenuItem1";
            this.rectangularChildToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rectangularChildToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.rectangularChildToolStripMenuItem1.Text = "Rectangular Child";
            this.rectangularChildToolStripMenuItem1.Click += new System.EventHandler(this.rectangularChildToolStripMenuItem1_Click);
            // 
            // customChildToolStripMenuItem
            // 
            this.customChildToolStripMenuItem.Name = "customChildToolStripMenuItem";
            this.customChildToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.customChildToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.customChildToolStripMenuItem.Text = "Custom Child";
            this.customChildToolStripMenuItem.Click += new System.EventHandler(this.customChildToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.closeToolStripMenuItem1.Text = "Close App";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.toolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.toolStripMenuItem.Text = "Close All";
            this.toolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oathToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // oathToolStripMenuItem
            // 
            this.oathToolStripMenuItem.Name = "oathToolStripMenuItem";
            this.oathToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.oathToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.oathToolStripMenuItem.Text = "Oath";
            this.oathToolStripMenuItem.Click += new System.EventHandler(this.oathToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 300);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(463, 22);
            this.statusBar.TabIndex = 5;
            this.statusBar.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(39, 17);
            this.StatusLabel.Text = "Status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 322);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.File);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.File;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.cmOpen.ResumeLayout(false);
            this.File.ResumeLayout(false);
            this.File.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmOpen;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesModalyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesModelessToolStripMenuItem;
        private System.Windows.Forms.MenuStrip File;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem preferencesMenu;
        private System.Windows.Forms.ToolStripMenuItem ellipticChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangularChildToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}

