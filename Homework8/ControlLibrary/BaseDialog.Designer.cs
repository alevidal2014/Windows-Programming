namespace ControlLibrary
{
    partial class BaseDialog
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
            this.DialogPanel = new System.Windows.Forms.Panel();
            this.teamNames = new ControlLibrary.TeamNameUserControl();
            this.teamDetails = new ControlLibrary.TeamDetailUserControl();
            this.DialogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DialogPanel
            // 
            this.DialogPanel.BackColor = System.Drawing.Color.Transparent;
            this.DialogPanel.Controls.Add(this.teamNames);
            this.DialogPanel.Controls.Add(this.teamDetails);
            this.DialogPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DialogPanel.Location = new System.Drawing.Point(0, 0);
            this.DialogPanel.Name = "DialogPanel";
            this.DialogPanel.Size = new System.Drawing.Size(832, 481);
            this.DialogPanel.TabIndex = 2;
            // 
            // teamNames
            // 
            this.teamNames.BackColor = System.Drawing.Color.MediumBlue;
            this.teamNames.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.teamNames.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.teamNames.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNames.Location = new System.Drawing.Point(0, 376);
            this.teamNames.Name = "teamNames";
            this.teamNames.Size = new System.Drawing.Size(832, 105);
            this.teamNames.TabIndex = 1;
            this.teamNames.Load += new System.EventHandler(this.teamNames_Load);
            // 
            // teamDetails
            // 
            this.teamDetails.BackColor = System.Drawing.Color.Transparent;
            this.teamDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.teamDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.teamDetails.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamDetails.Location = new System.Drawing.Point(0, 0);
            this.teamDetails.Name = "teamDetails";
            this.teamDetails.Size = new System.Drawing.Size(832, 36);
            this.teamDetails.TabIndex = 0;
            // 
            // BaseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(832, 481);
            this.Controls.Add(this.DialogPanel);
            this.Name = "BaseDialog";
            this.Text = "BaseDialog";
            this.DialogPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Panel DialogPanel;
        protected TeamNameUserControl teamNames;
        protected TeamDetailUserControl teamDetails;
    }
}