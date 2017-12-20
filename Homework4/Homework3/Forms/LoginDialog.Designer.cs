namespace Homework3.Forms
{
    partial class LoginDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginDialog));
            this.OKButton = new System.Windows.Forms.Button();
            this.CANCELButton = new System.Windows.Forms.Button();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.SkipCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(12, 126);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(86, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // CANCELButton
            // 
            this.CANCELButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CANCELButton.Location = new System.Drawing.Point(185, 126);
            this.CANCELButton.Name = "CANCELButton";
            this.CANCELButton.Size = new System.Drawing.Size(87, 23);
            this.CANCELButton.TabIndex = 1;
            this.CANCELButton.Text = "Cancel";
            this.CANCELButton.UseVisualStyleBackColor = true;
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.Location = new System.Drawing.Point(12, 22);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(247, 48);
            this.WarningLabel.TabIndex = 2;
            this.WarningLabel.Text = "Warning: You are about to open\r\nCOP 4226 Team 1\'s HW4 Program,\r\nDo you wish to pr" +
    "oceed?";
            // 
            // SkipCheckBox
            // 
            this.SkipCheckBox.AutoSize = true;
            this.SkipCheckBox.Location = new System.Drawing.Point(15, 91);
            this.SkipCheckBox.Name = "SkipCheckBox";
            this.SkipCheckBox.Size = new System.Drawing.Size(165, 17);
            this.SkipCheckBox.TabIndex = 3;
            this.SkipCheckBox.Text = "Do not show this dialog again";
            this.SkipCheckBox.UseVisualStyleBackColor = true;
            this.SkipCheckBox.CheckedChanged += new System.EventHandler(this.SkipCheckBox_CheckedChanged);
            // 
            // LoginDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.SkipCheckBox);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.CANCELButton);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginDialog";
            this.Text = "Warning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CANCELButton;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.CheckBox SkipCheckBox;
    }
}