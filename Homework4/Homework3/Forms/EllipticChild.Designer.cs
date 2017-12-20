namespace Homework3
{
    partial class EllipticChild
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
            this.SuspendLayout();
            // 
            // EllipticChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "EllipticChild";
            this.Text = "EllipticChild";
            this.BackColorChanged += new System.EventHandler(this.EllipticChild_Enter);
            this.Enter += new System.EventHandler(this.EllipticChild_Enter);
            this.Leave += new System.EventHandler(this.EllipticChild_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}