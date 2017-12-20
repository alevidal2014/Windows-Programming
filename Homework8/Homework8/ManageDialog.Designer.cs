namespace Homework8
{
    partial class ManageDialog
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
            this.manageDataGridView = new System.Windows.Forms.DataGridView();
            this.listButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.moveFirstButton = new System.Windows.Forms.Button();
            this.moveLastButton = new System.Windows.Forms.Button();
            this.moveBeforeButton = new System.Windows.Forms.Button();
            this.moveAfterButton = new System.Windows.Forms.Button();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.DialogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageDataGridView)).BeginInit();
            this.listButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DialogPanel
            // 
            this.DialogPanel.Controls.Add(this.OKButton);
            this.DialogPanel.Controls.Add(this.ApplyButton);
            this.DialogPanel.Controls.Add(this.RemoveButton);
            this.DialogPanel.Controls.Add(this.AddButton);
            this.DialogPanel.Controls.Add(this.listButtonPanel);
            this.DialogPanel.Controls.Add(this.manageDataGridView);
            this.DialogPanel.Size = new System.Drawing.Size(604, 461);
            this.DialogPanel.Controls.SetChildIndex(this.manageDataGridView, 0);
            this.DialogPanel.Controls.SetChildIndex(this.listButtonPanel, 0);
            this.DialogPanel.Controls.SetChildIndex(this.AddButton, 0);
            this.DialogPanel.Controls.SetChildIndex(this.RemoveButton, 0);
            this.DialogPanel.Controls.SetChildIndex(this.ApplyButton, 0);
            this.DialogPanel.Controls.SetChildIndex(this.OKButton, 0);
            this.DialogPanel.Controls.SetChildIndex(this.teamDetails, 0);
            this.DialogPanel.Controls.SetChildIndex(this.teamNames, 0);
            // 
            // teamNames
            // 
            this.teamNames.Location = new System.Drawing.Point(0, 356);
            this.teamNames.Size = new System.Drawing.Size(604, 105);
            // 
            // teamDetails
            // 
            this.teamDetails.Size = new System.Drawing.Size(604, 36);
            // 
            // manageDataGridView
            // 
            this.manageDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manageDataGridView.Location = new System.Drawing.Point(28, 45);
            this.manageDataGridView.Name = "manageDataGridView";
            this.manageDataGridView.Size = new System.Drawing.Size(548, 236);
            this.manageDataGridView.TabIndex = 2;
            // 
            // listButtonPanel
            // 
            this.listButtonPanel.ColumnCount = 6;
            this.listButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.listButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.listButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.listButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.listButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.listButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.listButtonPanel.Controls.Add(this.moveFirstButton, 0, 0);
            this.listButtonPanel.Controls.Add(this.moveBeforeButton, 2, 0);
            this.listButtonPanel.Controls.Add(this.moveLastButton, 5, 0);
            this.listButtonPanel.Controls.Add(this.moveAfterButton, 4, 0);
            this.listButtonPanel.Controls.Add(this.PositionLabel, 3, 0);
            this.listButtonPanel.Location = new System.Drawing.Point(55, 284);
            this.listButtonPanel.Name = "listButtonPanel";
            this.listButtonPanel.RowCount = 1;
            this.listButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.listButtonPanel.Size = new System.Drawing.Size(493, 32);
            this.listButtonPanel.TabIndex = 5;
            // 
            // moveFirstButton
            // 
            this.moveFirstButton.Location = new System.Drawing.Point(3, 3);
            this.moveFirstButton.Name = "moveFirstButton";
            this.moveFirstButton.Size = new System.Drawing.Size(82, 23);
            this.moveFirstButton.TabIndex = 0;
            this.moveFirstButton.Text = "|<";
            this.moveFirstButton.UseVisualStyleBackColor = true;
            this.moveFirstButton.Click += new System.EventHandler(this.moveFirstButton_Click);
            // 
            // moveLastButton
            // 
            this.moveLastButton.Location = new System.Drawing.Point(410, 3);
            this.moveLastButton.Name = "moveLastButton";
            this.moveLastButton.Size = new System.Drawing.Size(80, 23);
            this.moveLastButton.TabIndex = 3;
            this.moveLastButton.Text = ">|";
            this.moveLastButton.UseVisualStyleBackColor = true;
            this.moveLastButton.Click += new System.EventHandler(this.moveLastButton_Click);
            // 
            // moveBeforeButton
            // 
            this.moveBeforeButton.Location = new System.Drawing.Point(91, 3);
            this.moveBeforeButton.Name = "moveBeforeButton";
            this.moveBeforeButton.Size = new System.Drawing.Size(84, 23);
            this.moveBeforeButton.TabIndex = 2;
            this.moveBeforeButton.Text = "<";
            this.moveBeforeButton.UseVisualStyleBackColor = true;
            this.moveBeforeButton.Click += new System.EventHandler(this.moveBeforeButton_Click);
            // 
            // moveAfterButton
            // 
            this.moveAfterButton.Location = new System.Drawing.Point(320, 3);
            this.moveAfterButton.Name = "moveAfterButton";
            this.moveAfterButton.Size = new System.Drawing.Size(84, 23);
            this.moveAfterButton.TabIndex = 1;
            this.moveAfterButton.Text = ">";
            this.moveAfterButton.UseVisualStyleBackColor = true;
            this.moveAfterButton.Click += new System.EventHandler(this.moveAfterButton_Click);
            // 
            // PositionLabel
            // 
            this.PositionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PositionLabel.Location = new System.Drawing.Point(181, 0);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(133, 32);
            this.PositionLabel.TabIndex = 4;
            this.PositionLabel.Text = "X   of  X";
            this.PositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(58, 327);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(82, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(146, 327);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(84, 23);
            this.RemoveButton.TabIndex = 7;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(466, 327);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(79, 23);
            this.OKButton.TabIndex = 9;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(376, 327);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(83, 23);
            this.ApplyButton.TabIndex = 8;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // ManageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 461);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageDialog";
            this.ShowIcon = false;
            this.Text = "ManageDialog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageDialog_FormClosed);
            this.Load += new System.EventHandler(this.ManageDialog_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ManageDialog_HelpRequested);
            this.DialogPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manageDataGridView)).EndInit();
            this.listButtonPanel.ResumeLayout(false);
            this.listButtonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView manageDataGridView;
        private System.Windows.Forms.TableLayoutPanel listButtonPanel;
        private System.Windows.Forms.Button moveFirstButton;
        private System.Windows.Forms.Button moveBeforeButton;
        private System.Windows.Forms.Button moveLastButton;
        private System.Windows.Forms.Button moveAfterButton;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ApplyButton;
    }
}