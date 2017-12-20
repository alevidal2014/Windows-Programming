namespace Homework9
{
    partial class SearchDialog
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
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.extensionDropDownBox = new System.Windows.Forms.ComboBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.actionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.searchResultBox = new System.Windows.Forms.ListView();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startButton.Location = new System.Drawing.Point(12, 311);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Search";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Location = new System.Drawing.Point(174, 311);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop Search";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pauseButton.Location = new System.Drawing.Point(93, 311);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 2;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // extensionDropDownBox
            // 
            this.extensionDropDownBox.FormattingEnabled = true;
            this.extensionDropDownBox.Location = new System.Drawing.Point(563, 312);
            this.extensionDropDownBox.Name = "extensionDropDownBox";
            this.extensionDropDownBox.Size = new System.Drawing.Size(100, 21);
            this.extensionDropDownBox.TabIndex = 4;
            this.extensionDropDownBox.SelectedIndexChanged += new System.EventHandler(this.extensionDropDownBox_SelectedIndexChanged);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "File Extension";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 351);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(675, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // actionLabel
            // 
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // searchResultBox
            // 
            this.searchResultBox.LargeImageList = this.imageList1;
            this.searchResultBox.Location = new System.Drawing.Point(12, 12);
            this.searchResultBox.Name = "searchResultBox";
            this.searchResultBox.Size = new System.Drawing.Size(651, 293);
            this.searchResultBox.TabIndex = 7;
            this.searchResultBox.UseCompatibleStateImageBehavior = false;
            this.searchResultBox.ItemActivate += new System.EventHandler(this.searchResultBox_ItemActivate);
            // 
            // SearchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 373);
            this.Controls.Add(this.searchResultBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.extensionDropDownBox);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Name = "SearchDialog";
            this.Text = "SearchDialog";
            this.Load += new System.EventHandler(this.SearchDialog_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.ComboBox extensionDropDownBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel actionLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView searchResultBox;
    }
}