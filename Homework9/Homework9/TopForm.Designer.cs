namespace Homework9
{
    partial class TopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couterclockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.clockwiseRotButton = new System.Windows.Forms.ToolStripButton();
            this.counterClockwiseRotButton = new System.Windows.Forms.ToolStripButton();
            this.flipXButton = new System.Windows.Forms.ToolStripButton();
            this.flipYButton = new System.Windows.Forms.ToolStripButton();
            this.grayscaleButton = new System.Windows.Forms.ToolStripButton();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.FnametoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FilenametoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.savetoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 24);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(723, 24);
            this.mainMenuStrip.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.ToolTipText = "Main options of the app";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.ToolTipText = "Opens a new window";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.ToolTipText = "Opens a dialog to upload an image";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.ToolTipText = "Save the document";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.ToolTipText = "Save the document to specific location";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.ToolTipText = "Close this window";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.ToolTipText = "Print the document";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            this.windowToolStripMenuItem.ToolTipText = "Show all the open windows";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clockwiseToolStripMenuItem,
            this.couterclockwiseToolStripMenuItem,
            this.flipXToolStripMenuItem,
            this.flipYToolStripMenuItem,
            this.grayScaleToolStripMenuItem});
            this.imageToolStripMenuItem.Enabled = false;
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // clockwiseToolStripMenuItem
            // 
            this.clockwiseToolStripMenuItem.Name = "clockwiseToolStripMenuItem";
            this.clockwiseToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.clockwiseToolStripMenuItem.Text = "90 clockwise";
            this.clockwiseToolStripMenuItem.Click += new System.EventHandler(this.clockwiseToolStripMenuItem_Click);
            // 
            // couterclockwiseToolStripMenuItem
            // 
            this.couterclockwiseToolStripMenuItem.Name = "couterclockwiseToolStripMenuItem";
            this.couterclockwiseToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.couterclockwiseToolStripMenuItem.Text = "90 couter-clockwise";
            this.couterclockwiseToolStripMenuItem.Click += new System.EventHandler(this.couterclockwiseToolStripMenuItem_Click);
            // 
            // flipXToolStripMenuItem
            // 
            this.flipXToolStripMenuItem.Name = "flipXToolStripMenuItem";
            this.flipXToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.flipXToolStripMenuItem.Text = "Flip X";
            this.flipXToolStripMenuItem.Click += new System.EventHandler(this.flipXToolStripMenuItem_Click);
            // 
            // flipYToolStripMenuItem
            // 
            this.flipYToolStripMenuItem.Name = "flipYToolStripMenuItem";
            this.flipYToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.flipYToolStripMenuItem.Text = "Flip Y";
            this.flipYToolStripMenuItem.Click += new System.EventHandler(this.flipYToolStripMenuItem_Click);
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.grayScaleToolStripMenuItem.Text = "Gray Scale";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.ToolTipText = "Search for all the images in your HD";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox.ContextMenuStrip = this.contextMenu;
            this.pictureBox.Location = new System.Drawing.Point(27, 77);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(673, 579);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            this.pictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragEnter);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(145, 48);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clockwiseRotButton,
            this.counterClockwiseRotButton,
            this.flipXButton,
            this.flipYButton,
            this.grayscaleButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 48);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(723, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // clockwiseRotButton
            // 
            this.clockwiseRotButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clockwiseRotButton.Image = ((System.Drawing.Image)(resources.GetObject("clockwiseRotButton.Image")));
            this.clockwiseRotButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clockwiseRotButton.Name = "clockwiseRotButton";
            this.clockwiseRotButton.Size = new System.Drawing.Size(23, 22);
            this.clockwiseRotButton.Text = "Rotate Clockwise";
            this.clockwiseRotButton.Click += new System.EventHandler(this.clockwiseToolStripMenuItem_Click);
            // 
            // counterClockwiseRotButton
            // 
            this.counterClockwiseRotButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.counterClockwiseRotButton.Image = ((System.Drawing.Image)(resources.GetObject("counterClockwiseRotButton.Image")));
            this.counterClockwiseRotButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.counterClockwiseRotButton.Name = "counterClockwiseRotButton";
            this.counterClockwiseRotButton.Size = new System.Drawing.Size(23, 22);
            this.counterClockwiseRotButton.Text = "Rotate Counter-Clockwise";
            this.counterClockwiseRotButton.Click += new System.EventHandler(this.couterclockwiseToolStripMenuItem_Click);
            // 
            // flipXButton
            // 
            this.flipXButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.flipXButton.Image = ((System.Drawing.Image)(resources.GetObject("flipXButton.Image")));
            this.flipXButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.flipXButton.Name = "flipXButton";
            this.flipXButton.Size = new System.Drawing.Size(23, 22);
            this.flipXButton.Text = "Flip X";
            this.flipXButton.Click += new System.EventHandler(this.flipXToolStripMenuItem_Click);
            // 
            // flipYButton
            // 
            this.flipYButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.flipYButton.Image = ((System.Drawing.Image)(resources.GetObject("flipYButton.Image")));
            this.flipYButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.flipYButton.Name = "flipYButton";
            this.flipYButton.Size = new System.Drawing.Size(23, 22);
            this.flipYButton.Text = "Flip Y";
            this.flipYButton.Click += new System.EventHandler(this.flipYToolStripMenuItem_Click);
            // 
            // grayscaleButton
            // 
            this.grayscaleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.grayscaleButton.Image = ((System.Drawing.Image)(resources.GetObject("grayscaleButton.Image")));
            this.grayscaleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.grayscaleButton.Name = "grayscaleButton";
            this.grayscaleButton.Size = new System.Drawing.Size(23, 22);
            this.grayscaleButton.Text = "Grayscale";
            this.grayscaleButton.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_EndPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FnametoolStripStatusLabel,
            this.FilenametoolStripStatusLabel,
            this.savetoolStripStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 678);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(723, 22);
            this.statusBar.TabIndex = 4;
            this.statusBar.Text = "statusStrip1";
            // 
            // FnametoolStripStatusLabel
            // 
            this.FnametoolStripStatusLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FnametoolStripStatusLabel.Name = "FnametoolStripStatusLabel";
            this.FnametoolStripStatusLabel.Size = new System.Drawing.Size(66, 17);
            this.FnametoolStripStatusLabel.Text = "File Name: ";
            // 
            // FilenametoolStripStatusLabel
            // 
            this.FilenametoolStripStatusLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FilenametoolStripStatusLabel.Name = "FilenametoolStripStatusLabel";
            this.FilenametoolStripStatusLabel.Size = new System.Drawing.Size(49, 17);
            this.FilenametoolStripStatusLabel.Text = "Untitled";
            // 
            // savetoolStripStatusLabel
            // 
            this.savetoolStripStatusLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savetoolStripStatusLabel.Name = "savetoolStripStatusLabel";
            this.savetoolStripStatusLabel.Size = new System.Drawing.Size(111, 17);
            this.savetoolStripStatusLabel.Text = "Document Unsaved";
            // 
            // TopForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(723, 700);
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "TopForm";
            this.Text = "Image Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.TopForm_Resize);
            this.Controls.SetChildIndex(this.mainMenuStrip, 0);
            this.Controls.SetChildIndex(this.pictureBox, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.statusBar, 0);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couterclockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton clockwiseRotButton;
        private System.Windows.Forms.ToolStripButton counterClockwiseRotButton;
        private System.Windows.Forms.ToolStripButton flipXButton;
        private System.Windows.Forms.ToolStripButton flipYButton;
        private System.Windows.Forms.ToolStripButton grayscaleButton;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel FnametoolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel FilenametoolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel savetoolStripStatusLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    }
}

