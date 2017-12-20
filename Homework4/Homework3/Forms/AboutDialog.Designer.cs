namespace Homework3.Forms
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
            this.AboutPanel = new System.Windows.Forms.Label();
            this.AboutOKButton = new System.Windows.Forms.Button();
            this.DialogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DialogPanel
            // 
            this.DialogPanel.Controls.Add(this.AboutOKButton);
            this.DialogPanel.Controls.Add(this.AboutPanel);
            this.DialogPanel.Controls.SetChildIndex(this.AboutPanel, 0);
            this.DialogPanel.Controls.SetChildIndex(this.teamDetails, 0);
            this.DialogPanel.Controls.SetChildIndex(this.teamNames, 0);
            this.DialogPanel.Controls.SetChildIndex(this.AboutOKButton, 0);
            // 
            // AboutPanel
            // 
            this.AboutPanel.AutoSize = true;
            this.AboutPanel.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutPanel.ForeColor = System.Drawing.Color.Goldenrod;
            this.AboutPanel.Location = new System.Drawing.Point(46, 100);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.Size = new System.Drawing.Size(743, 186);
            this.AboutPanel.TabIndex = 2;
            this.AboutPanel.Text = resources.GetString("AboutPanel.Text");
            this.AboutPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutOKButton
            // 
            this.AboutOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AboutOKButton.Location = new System.Drawing.Point(372, 321);
            this.AboutOKButton.Name = "AboutOKButton";
            this.AboutOKButton.Size = new System.Drawing.Size(75, 23);
            this.AboutOKButton.TabIndex = 3;
            this.AboutOKButton.Text = "OK";
            this.AboutOKButton.UseVisualStyleBackColor = true;
            this.AboutOKButton.Click += new System.EventHandler(this.AboutOKButton_Click);
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Homework3.Properties.Resources.black_geometric_high_definition_background_7406;
            this.ClientSize = new System.Drawing.Size(832, 481);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.ShowIcon = false;
            this.Text = "AboutForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutDialog_FormClosing);
            this.Load += new System.EventHandler(this.AboutDialog_Load);
            this.DialogPanel.ResumeLayout(false);
            this.DialogPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AboutPanel;
        private System.Windows.Forms.Button AboutOKButton;
    }
}