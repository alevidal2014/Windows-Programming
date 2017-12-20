namespace ControlLibrary
{
    partial class OathControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oathLabel
            // 
            this.oathLabel.AutoSize = true;
            this.oathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oathLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oathLabel.Location = new System.Drawing.Point(0, 0);
            this.oathLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.oathLabel.Name = "oathLabel";
            this.oathLabel.Size = new System.Drawing.Size(494, 105);
            this.oathLabel.TabIndex = 0;
            this.oathLabel.Text = "I understand that this is a group project.\r\n\r\nIt is in my best interest to partic" +
    "ipate in \r\nwriting the homework and study code from \r\nthe homework.";
            this.oathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OathControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.oathLabel);
            this.Font = new System.Drawing.Font("Courier New", 14F);
            this.ForeColor = System.Drawing.Color.Gold;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "OathControl";
            this.Size = new System.Drawing.Size(520, 219);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label oathLabel;
    }
}
