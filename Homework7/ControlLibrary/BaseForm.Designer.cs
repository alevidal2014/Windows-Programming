namespace ControlLibrary
{
    partial class BaseForm
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
            this.BaseContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeChildSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsSubMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseContextMenuStrip.SuspendLayout();
            this.baseMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseContextMenuStrip
            // 
            this.BaseContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.BaseContextMenuStrip.Name = "BaseContextMenuStrip";
            this.BaseContextMenuStrip.Size = new System.Drawing.Size(136, 48);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorsToolStripMenuItem.Text = "Colors";
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.colorsToolStripMenuItem_Click);
            // 
            // baseMenuStrip
            // 
            this.baseMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.preferencesMenu});
            this.baseMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.baseMenuStrip.Name = "baseMenuStrip";
            this.baseMenuStrip.Size = new System.Drawing.Size(284, 24);
            this.baseMenuStrip.TabIndex = 1;
            this.baseMenuStrip.Text = "menuStrip1";
            this.baseMenuStrip.Visible = false;
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeChildSubMenu});
            this.fileMenu.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // closeChildSubMenu
            // 
            this.closeChildSubMenu.Name = "closeChildSubMenu";
            this.closeChildSubMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.End)));
            this.closeChildSubMenu.Size = new System.Drawing.Size(188, 22);
            this.closeChildSubMenu.Text = "Close Child";
            this.closeChildSubMenu.Click += new System.EventHandler(this.closeChildToolStripMenuItem_Click);
            // 
            // preferencesMenu
            // 
            this.preferencesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsSubMenu});
            this.preferencesMenu.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.preferencesMenu.Name = "preferencesMenu";
            this.preferencesMenu.Size = new System.Drawing.Size(80, 20);
            this.preferencesMenu.Text = "Preferences";
            // 
            // colorsSubMenu
            // 
            this.colorsSubMenu.Name = "colorsSubMenu";
            this.colorsSubMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.colorsSubMenu.Size = new System.Drawing.Size(152, 22);
            this.colorsSubMenu.Text = "Colors";
            this.colorsSubMenu.Click += new System.EventHandler(this.colorsToolStripMenuItem1_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ContextMenuStrip = this.BaseContextMenuStrip;
            this.Controls.Add(this.baseMenuStrip);
            this.MainMenuStrip = this.baseMenuStrip;
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseUp);
            this.BaseContextMenuStrip.ResumeLayout(false);
            this.baseMenuStrip.ResumeLayout(false);
            this.baseMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip BaseContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip baseMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem closeChildSubMenu;
        private System.Windows.Forms.ToolStripMenuItem preferencesMenu;
        private System.Windows.Forms.ToolStripMenuItem colorsSubMenu;
    }
}