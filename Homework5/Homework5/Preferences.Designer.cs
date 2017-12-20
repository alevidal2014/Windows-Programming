namespace Homework5
{
    partial class Preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.PApplyButton = new System.Windows.Forms.Button();
            this.PCancelButton = new System.Windows.Forms.Button();
            this.POKButton = new System.Windows.Forms.Button();
            this.PResetButton = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PreferencesContainer = new System.Windows.Forms.SplitContainer();
            this.SelectedColorLabel = new System.Windows.Forms.Label();
            this.ALabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.GLabel = new System.Windows.Forms.Label();
            this.RLabel = new System.Windows.Forms.Label();
            this.EnterColorLabel = new System.Windows.Forms.Label();
            this.ColorTitleLabel = new System.Windows.Forms.Label();
            this.SelectColorButton = new System.Windows.Forms.Button();
            this.RTextBox = new System.Windows.Forms.TextBox();
            this.GTextBox = new System.Windows.Forms.TextBox();
            this.DisplayColorLabel = new System.Windows.Forms.Label();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.SelectedFontLabel = new System.Windows.Forms.Label();
            this.DisplayFontLabel = new System.Windows.Forms.Label();
            this.FontTitleLabel = new System.Windows.Forms.Label();
            this.SelectFontButton = new System.Windows.Forms.Button();
            this.InputErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.InputInfoProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DialogPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreferencesContainer)).BeginInit();
            this.PreferencesContainer.Panel1.SuspendLayout();
            this.PreferencesContainer.Panel2.SuspendLayout();
            this.PreferencesContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputInfoProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DialogPanel
            // 
            this.DialogPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.DialogPanel.Controls.Add(this.PreferencesContainer);
            this.DialogPanel.Controls.Add(this.ButtonPanel);
            this.DialogPanel.Size = new System.Drawing.Size(634, 461);
            this.DialogPanel.Controls.SetChildIndex(this.ButtonPanel, 0);
            this.DialogPanel.Controls.SetChildIndex(this.PreferencesContainer, 0);
            this.DialogPanel.Controls.SetChildIndex(this.teamDetails, 0);
            this.DialogPanel.Controls.SetChildIndex(this.teamNames, 0);
            // 
            // teamNames
            // 
            this.teamNames.Location = new System.Drawing.Point(0, 356);
            this.teamNames.Size = new System.Drawing.Size(634, 105);
            // 
            // teamDetails
            // 
            this.teamDetails.Size = new System.Drawing.Size(634, 36);
            // 
            // PApplyButton
            // 
            this.PApplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PApplyButton.Location = new System.Drawing.Point(250, 3);
            this.PApplyButton.Name = "PApplyButton";
            this.PApplyButton.Size = new System.Drawing.Size(115, 49);
            this.PApplyButton.TabIndex = 0;
            this.PApplyButton.Text = "Apply";
            this.PApplyButton.UseVisualStyleBackColor = true;
            this.PApplyButton.Click += new System.EventHandler(this.PApplyButton_Click);
            // 
            // PCancelButton
            // 
            this.PCancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCancelButton.Location = new System.Drawing.Point(126, 3);
            this.PCancelButton.Name = "PCancelButton";
            this.PCancelButton.Size = new System.Drawing.Size(118, 49);
            this.PCancelButton.TabIndex = 1;
            this.PCancelButton.Text = "Cancel";
            this.PCancelButton.UseVisualStyleBackColor = true;
            this.PCancelButton.Click += new System.EventHandler(this.PCancelButton_Click);
            // 
            // POKButton
            // 
            this.POKButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.POKButton.Location = new System.Drawing.Point(3, 3);
            this.POKButton.Name = "POKButton";
            this.POKButton.Size = new System.Drawing.Size(117, 49);
            this.POKButton.TabIndex = 2;
            this.POKButton.Text = "OK";
            this.POKButton.UseVisualStyleBackColor = true;
            this.POKButton.Click += new System.EventHandler(this.POKButton_Click);
            // 
            // PResetButton
            // 
            this.PResetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PResetButton.Location = new System.Drawing.Point(371, 3);
            this.PResetButton.Name = "PResetButton";
            this.PResetButton.Size = new System.Drawing.Size(119, 49);
            this.PResetButton.TabIndex = 3;
            this.PResetButton.Text = "Reset";
            this.PResetButton.UseVisualStyleBackColor = true;
            this.PResetButton.Click += new System.EventHandler(this.PResetButton_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonPanel.ColumnCount = 4;
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.ButtonPanel.Controls.Add(this.PResetButton, 3, 0);
            this.ButtonPanel.Controls.Add(this.PApplyButton, 2, 0);
            this.ButtonPanel.Controls.Add(this.POKButton, 0, 0);
            this.ButtonPanel.Controls.Add(this.PCancelButton, 1, 0);
            this.ButtonPanel.Location = new System.Drawing.Point(75, 295);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.RowCount = 1;
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonPanel.Size = new System.Drawing.Size(493, 55);
            this.ButtonPanel.TabIndex = 3;
            // 
            // PreferencesContainer
            // 
            this.PreferencesContainer.Location = new System.Drawing.Point(75, 46);
            this.PreferencesContainer.Name = "PreferencesContainer";
            this.PreferencesContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // PreferencesContainer.Panel1
            // 
            this.PreferencesContainer.Panel1.Controls.Add(this.SelectedColorLabel);
            this.PreferencesContainer.Panel1.Controls.Add(this.ALabel);
            this.PreferencesContainer.Panel1.Controls.Add(this.BLabel);
            this.PreferencesContainer.Panel1.Controls.Add(this.GLabel);
            this.PreferencesContainer.Panel1.Controls.Add(this.RLabel);
            this.PreferencesContainer.Panel1.Controls.Add(this.EnterColorLabel);
            this.PreferencesContainer.Panel1.Controls.Add(this.ColorTitleLabel);
            this.PreferencesContainer.Panel1.Controls.Add(this.SelectColorButton);
            this.PreferencesContainer.Panel1.Controls.Add(this.RTextBox);
            this.PreferencesContainer.Panel1.Controls.Add(this.GTextBox);
            this.PreferencesContainer.Panel1.Controls.Add(this.DisplayColorLabel);
            this.PreferencesContainer.Panel1.Controls.Add(this.BTextBox);
            this.PreferencesContainer.Panel1.Controls.Add(this.ATextBox);
            this.PreferencesContainer.Panel1.ForeColor = System.Drawing.Color.Gold;
            // 
            // PreferencesContainer.Panel2
            // 
            this.PreferencesContainer.Panel2.Controls.Add(this.SelectedFontLabel);
            this.PreferencesContainer.Panel2.Controls.Add(this.DisplayFontLabel);
            this.PreferencesContainer.Panel2.Controls.Add(this.FontTitleLabel);
            this.PreferencesContainer.Panel2.Controls.Add(this.SelectFontButton);
            this.PreferencesContainer.Panel2.ForeColor = System.Drawing.Color.Gold;
            this.PreferencesContainer.Size = new System.Drawing.Size(493, 246);
            this.PreferencesContainer.SplitterDistance = 125;
            this.PreferencesContainer.TabIndex = 4;
            // 
            // SelectedColorLabel
            // 
            this.SelectedColorLabel.AutoSize = true;
            this.SelectedColorLabel.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.SelectedColorLabel.Location = new System.Drawing.Point(15, 99);
            this.SelectedColorLabel.Name = "SelectedColorLabel";
            this.SelectedColorLabel.Size = new System.Drawing.Size(76, 13);
            this.SelectedColorLabel.TabIndex = 23;
            this.SelectedColorLabel.Text = "Selected Color";
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.ForeColor = System.Drawing.Color.FloralWhite;
            this.ALabel.Location = new System.Drawing.Point(368, 40);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(14, 13);
            this.ALabel.TabIndex = 22;
            this.ALabel.Text = "A";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.ForeColor = System.Drawing.Color.FloralWhite;
            this.BLabel.Location = new System.Drawing.Point(287, 40);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(14, 13);
            this.BLabel.TabIndex = 21;
            this.BLabel.Text = "B";
            // 
            // GLabel
            // 
            this.GLabel.AutoSize = true;
            this.GLabel.ForeColor = System.Drawing.Color.FloralWhite;
            this.GLabel.Location = new System.Drawing.Point(204, 40);
            this.GLabel.Name = "GLabel";
            this.GLabel.Size = new System.Drawing.Size(15, 13);
            this.GLabel.TabIndex = 20;
            this.GLabel.Text = "G";
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.ForeColor = System.Drawing.Color.FloralWhite;
            this.RLabel.Location = new System.Drawing.Point(122, 40);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(15, 13);
            this.RLabel.TabIndex = 19;
            this.RLabel.Text = "R";
            // 
            // EnterColorLabel
            // 
            this.EnterColorLabel.AutoSize = true;
            this.EnterColorLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.EnterColorLabel.Location = new System.Drawing.Point(15, 59);
            this.EnterColorLabel.Name = "EnterColorLabel";
            this.EnterColorLabel.Size = new System.Drawing.Size(59, 13);
            this.EnterColorLabel.TabIndex = 18;
            this.EnterColorLabel.Text = "Enter Color";
            // 
            // ColorTitleLabel
            // 
            this.ColorTitleLabel.AutoSize = true;
            this.ColorTitleLabel.ForeColor = System.Drawing.Color.FloralWhite;
            this.ColorTitleLabel.Location = new System.Drawing.Point(15, 7);
            this.ColorTitleLabel.Name = "ColorTitleLabel";
            this.ColorTitleLabel.Size = new System.Drawing.Size(64, 13);
            this.ColorTitleLabel.TabIndex = 10;
            this.ColorTitleLabel.Text = "Select Color";
            // 
            // SelectColorButton
            // 
            this.SelectColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SelectColorButton.Location = new System.Drawing.Point(122, 3);
            this.SelectColorButton.Name = "SelectColorButton";
            this.SelectColorButton.Size = new System.Drawing.Size(75, 23);
            this.SelectColorButton.TabIndex = 11;
            this.SelectColorButton.Text = "Choose...";
            this.SelectColorButton.UseVisualStyleBackColor = true;
            this.SelectColorButton.Click += new System.EventHandler(this.SelectColorButton_Click);
            // 
            // RTextBox
            // 
            this.RTextBox.Location = new System.Drawing.Point(125, 56);
            this.RTextBox.Name = "RTextBox";
            this.RTextBox.Size = new System.Drawing.Size(46, 20);
            this.RTextBox.TabIndex = 12;
            this.RTextBox.TextChanged += new System.EventHandler(this.RTextBox_TextChanged);
            this.RTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.RTextBox_Validating);
            // 
            // GTextBox
            // 
            this.GTextBox.Location = new System.Drawing.Point(207, 56);
            this.GTextBox.Name = "GTextBox";
            this.GTextBox.Size = new System.Drawing.Size(46, 20);
            this.GTextBox.TabIndex = 13;
            this.GTextBox.TextChanged += new System.EventHandler(this.GTextBox_TextChanged);
            this.GTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.GTextBox_Validating);
            // 
            // DisplayColorLabel
            // 
            this.DisplayColorLabel.AutoSize = true;
            this.DisplayColorLabel.BackColor = System.Drawing.Color.White;
            this.DisplayColorLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DisplayColorLabel.Location = new System.Drawing.Point(123, 99);
            this.DisplayColorLabel.Name = "DisplayColorLabel";
            this.DisplayColorLabel.Size = new System.Drawing.Size(52, 13);
            this.DisplayColorLabel.TabIndex = 17;
            this.DisplayColorLabel.Text = "ColorText";
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(290, 56);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(46, 20);
            this.BTextBox.TabIndex = 14;
            this.BTextBox.TextChanged += new System.EventHandler(this.BTextBox_TextChanged);
            this.BTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.BTextBox_Validating);
            // 
            // ATextBox
            // 
            this.ATextBox.Location = new System.Drawing.Point(371, 56);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(46, 20);
            this.ATextBox.TabIndex = 15;
            this.ATextBox.TextChanged += new System.EventHandler(this.ATextBox_TextChanged);
            this.ATextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ATextBox_Validating);
            // 
            // SelectedFontLabel
            // 
            this.SelectedFontLabel.AutoSize = true;
            this.SelectedFontLabel.ForeColor = System.Drawing.Color.FloralWhite;
            this.SelectedFontLabel.Location = new System.Drawing.Point(15, 49);
            this.SelectedFontLabel.Name = "SelectedFontLabel";
            this.SelectedFontLabel.Size = new System.Drawing.Size(73, 13);
            this.SelectedFontLabel.TabIndex = 24;
            this.SelectedFontLabel.Text = "Selected Font";
            // 
            // DisplayFontLabel
            // 
            this.DisplayFontLabel.AutoSize = true;
            this.DisplayFontLabel.BackColor = System.Drawing.Color.White;
            this.DisplayFontLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DisplayFontLabel.Location = new System.Drawing.Point(123, 49);
            this.DisplayFontLabel.Name = "DisplayFontLabel";
            this.DisplayFontLabel.Size = new System.Drawing.Size(49, 13);
            this.DisplayFontLabel.TabIndex = 21;
            this.DisplayFontLabel.Text = "FontText";
            // 
            // FontTitleLabel
            // 
            this.FontTitleLabel.AutoSize = true;
            this.FontTitleLabel.ForeColor = System.Drawing.Color.FloralWhite;
            this.FontTitleLabel.Location = new System.Drawing.Point(15, 13);
            this.FontTitleLabel.Name = "FontTitleLabel";
            this.FontTitleLabel.Size = new System.Drawing.Size(61, 13);
            this.FontTitleLabel.TabIndex = 18;
            this.FontTitleLabel.Text = "Select Font";
            // 
            // SelectFontButton
            // 
            this.SelectFontButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SelectFontButton.Location = new System.Drawing.Point(122, 8);
            this.SelectFontButton.Name = "SelectFontButton";
            this.SelectFontButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFontButton.TabIndex = 19;
            this.SelectFontButton.Text = "Choose...";
            this.SelectFontButton.UseVisualStyleBackColor = true;
            this.SelectFontButton.Click += new System.EventHandler(this.SelectFontButton_Click);
            // 
            // InputErrorProvider
            // 
            this.InputErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.InputErrorProvider.ContainerControl = this;
            // 
            // InputInfoProvider
            // 
            this.InputInfoProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.InputInfoProvider.ContainerControl = this;
            this.InputInfoProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("InputInfoProvider.Icon")));
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Preferences_HelpRequested);
            this.DialogPanel.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.PreferencesContainer.Panel1.ResumeLayout(false);
            this.PreferencesContainer.Panel1.PerformLayout();
            this.PreferencesContainer.Panel2.ResumeLayout(false);
            this.PreferencesContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreferencesContainer)).EndInit();
            this.PreferencesContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InputErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputInfoProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PApplyButton;
        private System.Windows.Forms.Button PCancelButton;
        private System.Windows.Forms.Button POKButton;
        private System.Windows.Forms.Button PResetButton;
        private System.Windows.Forms.TableLayoutPanel ButtonPanel;
        private System.Windows.Forms.SplitContainer PreferencesContainer;
        private System.Windows.Forms.Label ColorTitleLabel;
        private System.Windows.Forms.Button SelectColorButton;
        private System.Windows.Forms.TextBox RTextBox;
        private System.Windows.Forms.TextBox GTextBox;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.Label DisplayFontLabel;
        private System.Windows.Forms.Label FontTitleLabel;
        private System.Windows.Forms.Button SelectFontButton;
        private System.Windows.Forms.Label GLabel;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.Label EnterColorLabel;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.Label DisplayColorLabel;
        private System.Windows.Forms.Label SelectedColorLabel;
        private System.Windows.Forms.Label SelectedFontLabel;
        private System.Windows.Forms.ErrorProvider InputErrorProvider;
        private System.Windows.Forms.ErrorProvider InputInfoProvider;
    }
}