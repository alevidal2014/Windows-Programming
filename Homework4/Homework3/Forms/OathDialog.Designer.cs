namespace Homework3.Forms
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
            this.oathControl = new ControlLibrary.OathControl();
            this.DialogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DialogPanel
            // 
            this.DialogPanel.Controls.Add(this.oathControl);
            this.DialogPanel.Size = new System.Drawing.Size(324, 271);
            this.DialogPanel.Controls.SetChildIndex(this.teamDetails, 0);
            this.DialogPanel.Controls.SetChildIndex(this.teamNames, 0);
            this.DialogPanel.Controls.SetChildIndex(this.oathControl, 0);
            // 
            // teamNames
            // 
            this.teamNames.Location = new System.Drawing.Point(0, 166);
            this.teamNames.Size = new System.Drawing.Size(324, 105);
            // 
            // teamDetails
            // 
            this.teamDetails.Size = new System.Drawing.Size(324, 36);
            // 
            // oathControl
            // 
            this.oathControl.BackColor = System.Drawing.Color.Transparent;
            this.oathControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oathControl.Font = new System.Drawing.Font("Courier New", 14F);
            this.oathControl.ForeColor = System.Drawing.Color.Gold;
            this.oathControl.Location = new System.Drawing.Point(0, 36);
            this.oathControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.oathControl.Name = "oathControl";
            this.oathControl.Size = new System.Drawing.Size(324, 130);
            this.oathControl.TabIndex = 2;
            // 
            // OathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Homework3.Properties.Resources.black_geometric_high_definition_background_7406;
            this.ClientSize = new System.Drawing.Size(324, 271);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OathDialog";
            this.ShowIcon = false;
            this.Text = "OathDialog";
            this.DialogPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ControlLibrary.OathControl oathControl;
    }
}