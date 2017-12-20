namespace Homework8
{
    partial class TextOptionsDialog
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
            this.listButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.moveFirstButton = new System.Windows.Forms.Button();
            this.moveLastButton = new System.Windows.Forms.Button();
            this.moveBeforeButton = new System.Windows.Forms.Button();
            this.moveAfterButton = new System.Windows.Forms.Button();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.ALabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.GLabel = new System.Windows.Forms.Label();
            this.RLabel = new System.Windows.Forms.Label();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.GTextBox = new System.Windows.Forms.TextBox();
            this.RTextBox = new System.Windows.Forms.TextBox();
            this.SelectColorButton = new System.Windows.Forms.Button();
            this.enterColorLabel = new System.Windows.Forms.Label();
            this.selectColorLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.RotTextBox = new System.Windows.Forms.TextBox();
            this.RotationLabel = new System.Windows.Forms.Label();
            this.YLocTextBox = new System.Windows.Forms.TextBox();
            this.XLocTextBox = new System.Windows.Forms.TextBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.StyleChecklistBox = new System.Windows.Forms.CheckedListBox();
            this.TypefaceLabel = new System.Windows.Forms.Label();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.EnterFontLabel = new System.Windows.Forms.Label();
            this.SelectFontLabel = new System.Windows.Forms.Label();
            this.SelectFontButton = new System.Windows.Forms.Button();
            this.shapeNameLabel = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.POKButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.InputErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.InputInfoProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DialogPanel.SuspendLayout();
            this.listButtonPanel.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputInfoProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DialogPanel
            // 
            this.DialogPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.DialogPanel.Controls.Add(this.applyButton);
            this.DialogPanel.Controls.Add(this.POKButton);
            this.DialogPanel.Controls.Add(this.optionsPanel);
            this.DialogPanel.Controls.Add(this.listButtonPanel);
            this.DialogPanel.Size = new System.Drawing.Size(659, 586);
            this.DialogPanel.Controls.SetChildIndex(this.listButtonPanel, 0);
            this.DialogPanel.Controls.SetChildIndex(this.optionsPanel, 0);
            this.DialogPanel.Controls.SetChildIndex(this.POKButton, 0);
            this.DialogPanel.Controls.SetChildIndex(this.applyButton, 0);
            this.DialogPanel.Controls.SetChildIndex(this.teamDetails, 0);
            this.DialogPanel.Controls.SetChildIndex(this.teamNames, 0);
            // 
            // teamNames
            // 
            this.teamNames.Location = new System.Drawing.Point(0, 484);
            this.teamNames.Size = new System.Drawing.Size(659, 102);
            // 
            // teamDetails
            // 
            this.teamDetails.BackColor = System.Drawing.Color.MediumBlue;
            this.teamDetails.Size = new System.Drawing.Size(659, 36);
            // 
            // listButtonPanel
            // 
            this.listButtonPanel.ColumnCount = 5;
            this.listButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.listButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.listButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.listButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.listButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.listButtonPanel.Controls.Add(this.moveFirstButton, 0, 0);
            this.listButtonPanel.Controls.Add(this.moveLastButton, 4, 0);
            this.listButtonPanel.Controls.Add(this.moveBeforeButton, 2, 0);
            this.listButtonPanel.Controls.Add(this.moveAfterButton, 3, 0);
            this.listButtonPanel.Location = new System.Drawing.Point(78, 409);
            this.listButtonPanel.Name = "listButtonPanel";
            this.listButtonPanel.RowCount = 1;
            this.listButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.listButtonPanel.Size = new System.Drawing.Size(493, 32);
            this.listButtonPanel.TabIndex = 4;
            // 
            // moveFirstButton
            // 
            this.moveFirstButton.Location = new System.Drawing.Point(3, 3);
            this.moveFirstButton.Name = "moveFirstButton";
            this.moveFirstButton.Size = new System.Drawing.Size(117, 23);
            this.moveFirstButton.TabIndex = 0;
            this.moveFirstButton.Text = "|<";
            this.moveFirstButton.UseVisualStyleBackColor = true;
            this.moveFirstButton.Click += new System.EventHandler(this.moveFirstButton_Click);
            // 
            // moveLastButton
            // 
            this.moveLastButton.Location = new System.Drawing.Point(371, 3);
            this.moveLastButton.Name = "moveLastButton";
            this.moveLastButton.Size = new System.Drawing.Size(119, 23);
            this.moveLastButton.TabIndex = 3;
            this.moveLastButton.Text = ">|";
            this.moveLastButton.UseVisualStyleBackColor = true;
            this.moveLastButton.Click += new System.EventHandler(this.moveLastButton_Click);
            // 
            // moveBeforeButton
            // 
            this.moveBeforeButton.Location = new System.Drawing.Point(126, 3);
            this.moveBeforeButton.Name = "moveBeforeButton";
            this.moveBeforeButton.Size = new System.Drawing.Size(118, 23);
            this.moveBeforeButton.TabIndex = 2;
            this.moveBeforeButton.Text = "<";
            this.moveBeforeButton.UseVisualStyleBackColor = true;
            this.moveBeforeButton.Click += new System.EventHandler(this.moveBeforeButton_Click);
            // 
            // moveAfterButton
            // 
            this.moveAfterButton.Location = new System.Drawing.Point(250, 3);
            this.moveAfterButton.Name = "moveAfterButton";
            this.moveAfterButton.Size = new System.Drawing.Size(115, 23);
            this.moveAfterButton.TabIndex = 1;
            this.moveAfterButton.Text = ">";
            this.moveAfterButton.UseVisualStyleBackColor = true;
            this.moveAfterButton.Click += new System.EventHandler(this.moveAfterButton_Click);
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.ALabel);
            this.optionsPanel.Controls.Add(this.BLabel);
            this.optionsPanel.Controls.Add(this.GLabel);
            this.optionsPanel.Controls.Add(this.RLabel);
            this.optionsPanel.Controls.Add(this.ATextBox);
            this.optionsPanel.Controls.Add(this.BTextBox);
            this.optionsPanel.Controls.Add(this.GTextBox);
            this.optionsPanel.Controls.Add(this.RTextBox);
            this.optionsPanel.Controls.Add(this.SelectColorButton);
            this.optionsPanel.Controls.Add(this.enterColorLabel);
            this.optionsPanel.Controls.Add(this.selectColorLabel);
            this.optionsPanel.Controls.Add(this.YLabel);
            this.optionsPanel.Controls.Add(this.XLabel);
            this.optionsPanel.Controls.Add(this.RotTextBox);
            this.optionsPanel.Controls.Add(this.RotationLabel);
            this.optionsPanel.Controls.Add(this.YLocTextBox);
            this.optionsPanel.Controls.Add(this.XLocTextBox);
            this.optionsPanel.Controls.Add(this.LocationLabel);
            this.optionsPanel.Controls.Add(this.SizeLabel);
            this.optionsPanel.Controls.Add(this.TypeComboBox);
            this.optionsPanel.Controls.Add(this.StyleChecklistBox);
            this.optionsPanel.Controls.Add(this.TypefaceLabel);
            this.optionsPanel.Controls.Add(this.SizeTextBox);
            this.optionsPanel.Controls.Add(this.EnterFontLabel);
            this.optionsPanel.Controls.Add(this.SelectFontLabel);
            this.optionsPanel.Controls.Add(this.SelectFontButton);
            this.optionsPanel.Controls.Add(this.shapeNameLabel);
            this.optionsPanel.Controls.Add(this.displayLabel);
            this.optionsPanel.Controls.Add(this.displayPanel);
            this.optionsPanel.Location = new System.Drawing.Point(78, 42);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(493, 364);
            this.optionsPanel.TabIndex = 7;
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.ForeColor = System.Drawing.Color.Gold;
            this.ALabel.Location = new System.Drawing.Point(360, 111);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(14, 13);
            this.ALabel.TabIndex = 57;
            this.ALabel.Text = "A";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.ForeColor = System.Drawing.Color.Gold;
            this.BLabel.Location = new System.Drawing.Point(282, 111);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(14, 13);
            this.BLabel.TabIndex = 56;
            this.BLabel.Text = "B";
            // 
            // GLabel
            // 
            this.GLabel.AutoSize = true;
            this.GLabel.ForeColor = System.Drawing.Color.Gold;
            this.GLabel.Location = new System.Drawing.Point(199, 111);
            this.GLabel.Name = "GLabel";
            this.GLabel.Size = new System.Drawing.Size(15, 13);
            this.GLabel.TabIndex = 55;
            this.GLabel.Text = "G";
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.ForeColor = System.Drawing.Color.Gold;
            this.RLabel.Location = new System.Drawing.Point(114, 111);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(15, 13);
            this.RLabel.TabIndex = 54;
            this.RLabel.Text = "R";
            // 
            // ATextBox
            // 
            this.ATextBox.Location = new System.Drawing.Point(363, 127);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(51, 20);
            this.ATextBox.TabIndex = 53;
            this.ATextBox.TextChanged += new System.EventHandler(this.ATextBox_TextChanged);
            this.ATextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ATextBox_Validating);
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(285, 127);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(51, 20);
            this.BTextBox.TabIndex = 52;
            this.BTextBox.TextChanged += new System.EventHandler(this.BTextBox_TextChanged);
            this.BTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.BTextBox_Validating);
            // 
            // GTextBox
            // 
            this.GTextBox.Location = new System.Drawing.Point(202, 127);
            this.GTextBox.Name = "GTextBox";
            this.GTextBox.Size = new System.Drawing.Size(51, 20);
            this.GTextBox.TabIndex = 51;
            this.GTextBox.TextChanged += new System.EventHandler(this.GTextBox_TextChanged);
            this.GTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.GTextBox_Validating);
            // 
            // RTextBox
            // 
            this.RTextBox.Location = new System.Drawing.Point(117, 127);
            this.RTextBox.Name = "RTextBox";
            this.RTextBox.Size = new System.Drawing.Size(51, 20);
            this.RTextBox.TabIndex = 50;
            this.RTextBox.TextChanged += new System.EventHandler(this.RTextBox_TextChanged);
            this.RTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.RTextBox_Validating);
            // 
            // SelectColorButton
            // 
            this.SelectColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SelectColorButton.Location = new System.Drawing.Point(117, 85);
            this.SelectColorButton.Name = "SelectColorButton";
            this.SelectColorButton.Size = new System.Drawing.Size(75, 23);
            this.SelectColorButton.TabIndex = 49;
            this.SelectColorButton.Text = "Choose...";
            this.SelectColorButton.UseVisualStyleBackColor = true;
            this.SelectColorButton.Click += new System.EventHandler(this.SelectColorButton_Click);
            // 
            // enterColorLabel
            // 
            this.enterColorLabel.AutoSize = true;
            this.enterColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterColorLabel.ForeColor = System.Drawing.Color.Gold;
            this.enterColorLabel.Location = new System.Drawing.Point(19, 127);
            this.enterColorLabel.Name = "enterColorLabel";
            this.enterColorLabel.Size = new System.Drawing.Size(89, 20);
            this.enterColorLabel.TabIndex = 48;
            this.enterColorLabel.Text = "Enter Color";
            // 
            // selectColorLabel
            // 
            this.selectColorLabel.AutoSize = true;
            this.selectColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectColorLabel.ForeColor = System.Drawing.Color.Gold;
            this.selectColorLabel.Location = new System.Drawing.Point(19, 88);
            this.selectColorLabel.Name = "selectColorLabel";
            this.selectColorLabel.Size = new System.Drawing.Size(95, 20);
            this.selectColorLabel.TabIndex = 47;
            this.selectColorLabel.Text = "Select Color";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.ForeColor = System.Drawing.Color.Gold;
            this.YLabel.Location = new System.Drawing.Point(199, 151);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(14, 13);
            this.YLabel.TabIndex = 46;
            this.YLabel.Text = "Y";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.ForeColor = System.Drawing.Color.Gold;
            this.XLabel.Location = new System.Drawing.Point(114, 151);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(14, 13);
            this.XLabel.TabIndex = 45;
            this.XLabel.Text = "X";
            // 
            // RotTextBox
            // 
            this.RotTextBox.Location = new System.Drawing.Point(363, 167);
            this.RotTextBox.Name = "RotTextBox";
            this.RotTextBox.Size = new System.Drawing.Size(51, 20);
            this.RotTextBox.TabIndex = 44;
            this.RotTextBox.TextChanged += new System.EventHandler(this.RotTextBox_TextChanged);
            this.RotTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.RotTextBox_Validating);
            // 
            // RotationLabel
            // 
            this.RotationLabel.AutoSize = true;
            this.RotationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotationLabel.ForeColor = System.Drawing.Color.Gold;
            this.RotationLabel.Location = new System.Drawing.Point(281, 167);
            this.RotationLabel.Name = "RotationLabel";
            this.RotationLabel.Size = new System.Drawing.Size(70, 20);
            this.RotationLabel.TabIndex = 43;
            this.RotationLabel.Text = "Rotation";
            // 
            // YLocTextBox
            // 
            this.YLocTextBox.Location = new System.Drawing.Point(202, 167);
            this.YLocTextBox.Name = "YLocTextBox";
            this.YLocTextBox.Size = new System.Drawing.Size(51, 20);
            this.YLocTextBox.TabIndex = 42;
            this.YLocTextBox.TextChanged += new System.EventHandler(this.YLocTextBox_TextChanged);
            this.YLocTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.YLocTextBox_Validating);
            // 
            // XLocTextBox
            // 
            this.XLocTextBox.Location = new System.Drawing.Point(117, 167);
            this.XLocTextBox.Name = "XLocTextBox";
            this.XLocTextBox.Size = new System.Drawing.Size(51, 20);
            this.XLocTextBox.TabIndex = 41;
            this.XLocTextBox.TextChanged += new System.EventHandler(this.XLocTextBox_TextChanged);
            this.XLocTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.XLocTextBox_Validating);
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.ForeColor = System.Drawing.Color.Gold;
            this.LocationLabel.Location = new System.Drawing.Point(19, 167);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(70, 20);
            this.LocationLabel.TabIndex = 40;
            this.LocationLabel.Text = "Location";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.ForeColor = System.Drawing.Color.Gold;
            this.SizeLabel.Location = new System.Drawing.Point(282, 34);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(27, 13);
            this.SizeLabel.TabIndex = 39;
            this.SizeLabel.Text = "Size";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(117, 50);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(136, 21);
            this.TypeComboBox.TabIndex = 38;
            this.TypeComboBox.SelectedValueChanged += new System.EventHandler(this.TypeComboBox_SelectedValueChanged);
            this.TypeComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.TypeComboBox_Validating);
            // 
            // StyleChecklistBox
            // 
            this.StyleChecklistBox.CheckOnClick = true;
            this.StyleChecklistBox.FormattingEnabled = true;
            this.StyleChecklistBox.Items.AddRange(new object[] {
            "Bold",
            "Italic",
            "Underline",
            "Strikeout"});
            this.StyleChecklistBox.Location = new System.Drawing.Point(363, 7);
            this.StyleChecklistBox.Name = "StyleChecklistBox";
            this.StyleChecklistBox.Size = new System.Drawing.Size(106, 64);
            this.StyleChecklistBox.TabIndex = 37;
            this.StyleChecklistBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.StyleChecklistBox_ItemCheck);
            // 
            // TypefaceLabel
            // 
            this.TypefaceLabel.AutoSize = true;
            this.TypefaceLabel.ForeColor = System.Drawing.Color.Gold;
            this.TypefaceLabel.Location = new System.Drawing.Point(114, 34);
            this.TypefaceLabel.Name = "TypefaceLabel";
            this.TypefaceLabel.Size = new System.Drawing.Size(52, 13);
            this.TypefaceLabel.TabIndex = 36;
            this.TypefaceLabel.Text = "Typeface";
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Location = new System.Drawing.Point(285, 51);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(51, 20);
            this.SizeTextBox.TabIndex = 35;
            this.SizeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SizeTextBox_KeyDown);
            this.SizeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.SizeTextBox_Validating);
            // 
            // EnterFontLabel
            // 
            this.EnterFontLabel.AutoSize = true;
            this.EnterFontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterFontLabel.ForeColor = System.Drawing.Color.Gold;
            this.EnterFontLabel.Location = new System.Drawing.Point(19, 51);
            this.EnterFontLabel.Name = "EnterFontLabel";
            this.EnterFontLabel.Size = new System.Drawing.Size(85, 20);
            this.EnterFontLabel.TabIndex = 34;
            this.EnterFontLabel.Text = "Enter Font";
            // 
            // SelectFontLabel
            // 
            this.SelectFontLabel.AutoSize = true;
            this.SelectFontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFontLabel.ForeColor = System.Drawing.Color.Gold;
            this.SelectFontLabel.Location = new System.Drawing.Point(19, 9);
            this.SelectFontLabel.Name = "SelectFontLabel";
            this.SelectFontLabel.Size = new System.Drawing.Size(91, 20);
            this.SelectFontLabel.TabIndex = 32;
            this.SelectFontLabel.Text = "Select Font";
            // 
            // SelectFontButton
            // 
            this.SelectFontButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SelectFontButton.Location = new System.Drawing.Point(117, 6);
            this.SelectFontButton.Name = "SelectFontButton";
            this.SelectFontButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFontButton.TabIndex = 33;
            this.SelectFontButton.Text = "Choose...";
            this.SelectFontButton.UseVisualStyleBackColor = true;
            this.SelectFontButton.Click += new System.EventHandler(this.SelectFontButton_Click);
            // 
            // shapeNameLabel
            // 
            this.shapeNameLabel.AutoSize = true;
            this.shapeNameLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.shapeNameLabel.ForeColor = System.Drawing.Color.Gold;
            this.shapeNameLabel.Location = new System.Drawing.Point(87, 187);
            this.shapeNameLabel.Name = "shapeNameLabel";
            this.shapeNameLabel.Size = new System.Drawing.Size(0, 13);
            this.shapeNameLabel.TabIndex = 27;
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.ForeColor = System.Drawing.Color.Gold;
            this.displayLabel.Location = new System.Drawing.Point(20, 204);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(90, 16);
            this.displayLabel.TabIndex = 13;
            this.displayLabel.Text = "Sample View:";
            // 
            // displayPanel
            // 
            this.displayPanel.BackColor = System.Drawing.Color.White;
            this.displayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPanel.Location = new System.Drawing.Point(23, 223);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(444, 141);
            this.displayPanel.TabIndex = 12;
            this.displayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.displayPanel_Paint);
            // 
            // POKButton
            // 
            this.POKButton.Location = new System.Drawing.Point(495, 447);
            this.POKButton.Name = "POKButton";
            this.POKButton.Size = new System.Drawing.Size(73, 31);
            this.POKButton.TabIndex = 8;
            this.POKButton.Text = "OK";
            this.POKButton.UseVisualStyleBackColor = true;
            this.POKButton.Click += new System.EventHandler(this.POKButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(370, 447);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(73, 31);
            this.applyButton.TabIndex = 9;
            this.applyButton.Text = "APPLY";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
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
            // 
            // TextOptionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 586);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextOptionsDialog";
            this.Text = "Text Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShapeOptionsDialog_FormClosed);
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Preferences_HelpRequested);
            this.DialogPanel.ResumeLayout(false);
            this.listButtonPanel.ResumeLayout(false);
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputInfoProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel listButtonPanel;
        private System.Windows.Forms.Button moveFirstButton;
        private System.Windows.Forms.Button moveBeforeButton;
        private System.Windows.Forms.Button moveLastButton;
        private System.Windows.Forms.Button moveAfterButton;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button POKButton;
        private System.Windows.Forms.Label shapeNameLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.CheckedListBox StyleChecklistBox;
        private System.Windows.Forms.Label TypefaceLabel;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.Label EnterFontLabel;
        private System.Windows.Forms.Label SelectFontLabel;
        private System.Windows.Forms.Button SelectFontButton;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.ErrorProvider InputErrorProvider;
        private System.Windows.Forms.ErrorProvider InputInfoProvider;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.TextBox RotTextBox;
        private System.Windows.Forms.Label RotationLabel;
        private System.Windows.Forms.TextBox YLocTextBox;
        private System.Windows.Forms.TextBox XLocTextBox;
        private System.Windows.Forms.Label enterColorLabel;
        private System.Windows.Forms.Label selectColorLabel;
        private System.Windows.Forms.Button SelectColorButton;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.Label GLabel;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.TextBox GTextBox;
        private System.Windows.Forms.TextBox RTextBox;
    }
}