namespace Homework2
{
    partial class MainForm
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
            this.group_button = new System.Windows.Forms.GroupBox();
            this.reset_button = new System.Windows.Forms.Button();
            this.saveLoc_button = new System.Windows.Forms.Button();
            this.saveSize_button = new System.Windows.Forms.Button();
            this.name_button = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.group_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // group_button
            // 
            this.group_button.CausesValidation = false;
            this.group_button.Controls.Add(this.reset_button);
            this.group_button.Controls.Add(this.saveLoc_button);
            this.group_button.Controls.Add(this.saveSize_button);
            this.group_button.Controls.Add(this.name_button);
            this.group_button.Controls.Add(this.inputBox);
            this.group_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.group_button.Location = new System.Drawing.Point(0, 0);
            this.group_button.Name = "group_button";
            this.group_button.Size = new System.Drawing.Size(434, 115);
            this.group_button.TabIndex = 0;
            this.group_button.TabStop = false;
            this.group_button.Text = "Enter:";
            // 
            // reset_button
            // 
            this.reset_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.reset_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.reset_button.CausesValidation = false;
            this.reset_button.Location = new System.Drawing.Point(174, 83);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(88, 25);
            this.reset_button.TabIndex = 4;
            this.reset_button.Text = "Reset Settings";
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.Reset_Click);
            // 
            // saveLoc_button
            // 
            this.saveLoc_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveLoc_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.saveLoc_button.CausesValidation = false;
            this.saveLoc_button.Location = new System.Drawing.Point(301, 83);
            this.saveLoc_button.Name = "saveLoc_button";
            this.saveLoc_button.Size = new System.Drawing.Size(88, 25);
            this.saveLoc_button.TabIndex = 3;
            this.saveLoc_button.Text = "Save Location";
            this.saveLoc_button.UseVisualStyleBackColor = false;
            this.saveLoc_button.Click += new System.EventHandler(this.Save_Location_Click);
            // 
            // saveSize_button
            // 
            this.saveSize_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveSize_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.saveSize_button.CausesValidation = false;
            this.saveSize_button.Location = new System.Drawing.Point(44, 83);
            this.saveSize_button.Name = "saveSize_button";
            this.saveSize_button.Size = new System.Drawing.Size(88, 25);
            this.saveSize_button.TabIndex = 2;
            this.saveSize_button.Text = "Save Size";
            this.saveSize_button.UseVisualStyleBackColor = false;
            this.saveSize_button.Click += new System.EventHandler(this.Save_Size_Click);
            // 
            // name_button
            // 
            this.name_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.name_button.Location = new System.Drawing.Point(174, 45);
            this.name_button.Name = "name_button";
            this.name_button.Size = new System.Drawing.Size(88, 25);
            this.name_button.TabIndex = 1;
            this.name_button.Text = "Name";
            this.name_button.UseVisualStyleBackColor = false;
            this.name_button.Click += new System.EventHandler(this.Name_Click);
            this.name_button.Validating += new System.ComponentModel.CancelEventHandler(this.Name_Validating);
            // 
            // inputBox
            // 
            this.inputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBox.Location = new System.Drawing.Point(44, 19);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(345, 20);
            this.inputBox.TabIndex = 0;
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listView.CausesValidation = false;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Location = new System.Drawing.Point(0, 115);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(434, 346);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.group_button);
            this.MinimumSize = new System.Drawing.Size(370, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.group_button.ResumeLayout(false);
            this.group_button.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button saveLoc_button;
        private System.Windows.Forms.Button saveSize_button;
        private System.Windows.Forms.Button name_button;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

