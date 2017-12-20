namespace Homework7
{
    partial class AboutDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
            this.AboutLabel = new System.Windows.Forms.Label();
            this.DialogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DialogPanel
            // 
            this.DialogPanel.Controls.Add(this.AboutLabel);
            this.DialogPanel.Size = new System.Drawing.Size(664, 341);
            this.DialogPanel.Controls.SetChildIndex(this.teamDetails, 0);
            this.DialogPanel.Controls.SetChildIndex(this.teamNames, 0);
            this.DialogPanel.Controls.SetChildIndex(this.AboutLabel, 0);
            // 
            // teamNames
            // 
            this.teamNames.Location = new System.Drawing.Point(0, 236);
            this.teamNames.Size = new System.Drawing.Size(664, 105);
            // 
            // teamDetails
            // 
            this.teamDetails.BackColor = System.Drawing.Color.MediumBlue;
            this.teamDetails.Size = new System.Drawing.Size(664, 36);
            // 
            // AboutLabel
            // 
            this.AboutLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutLabel.ForeColor = System.Drawing.Color.Gold;
            this.AboutLabel.Location = new System.Drawing.Point(42, 48);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(593, 168);
            this.AboutLabel.TabIndex = 3;
            this.AboutLabel.Text = resources.GetString("AboutLabel.Text");
            this.AboutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AboutLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.AboutLabel_Paint);
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 341);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.ShowIcon = false;
            this.Text = "About This App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AboutDialog_FormClosed);
            this.Load += new System.EventHandler(this.AboutDialog_Load);
            this.DialogPanel.ResumeLayout(false);
            this.DialogPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AboutLabel;
    }
}