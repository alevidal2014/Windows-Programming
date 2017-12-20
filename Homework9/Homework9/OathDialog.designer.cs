namespace Homework9
{
    partial class OathDialog
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
            this.OathControl = new ControlLibrary.OathControl();
            this.DialogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DialogPanel
            // 
            this.DialogPanel.Controls.Add(this.OathControl);
            this.DialogPanel.Size = new System.Drawing.Size(584, 311);
            this.DialogPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DialogPanel_Paint);
            this.DialogPanel.Controls.SetChildIndex(this.teamDetails, 0);
            this.DialogPanel.Controls.SetChildIndex(this.teamNames, 0);
            this.DialogPanel.Controls.SetChildIndex(this.OathControl, 0);
            // 
            // teamNames
            // 
            this.teamNames.Location = new System.Drawing.Point(0, 206);
            this.teamNames.Size = new System.Drawing.Size(584, 105);
            // 
            // teamDetails
            // 
            this.teamDetails.BackColor = System.Drawing.Color.MediumBlue;
            this.teamDetails.Size = new System.Drawing.Size(584, 36);
            // 
            // OathControl
            // 
            this.OathControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OathControl.AutoSize = true;
            this.OathControl.BackColor = System.Drawing.Color.Transparent;
            this.OathControl.Font = new System.Drawing.Font("Courier New", 14F);
            this.OathControl.ForeColor = System.Drawing.Color.Gold;
            this.OathControl.Location = new System.Drawing.Point(47, 67);
            this.OathControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.OathControl.Name = "OathControl";
            this.OathControl.Size = new System.Drawing.Size(494, 105);
            this.OathControl.TabIndex = 2;
            // 
            // OathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OathDialog";
            this.ShowIcon = false;
            this.Text = "Team 1 Oath";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OathDialog_FormClosed);
            this.Load += new System.EventHandler(this.OathDialog_Load);
            this.DialogPanel.ResumeLayout(false);
            this.DialogPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibrary.OathControl OathControl;
    }
}