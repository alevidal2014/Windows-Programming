namespace Homework7
{
    partial class ShapeOptionsDialog
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
            this.listButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.moveFirstButton = new System.Windows.Forms.Button();
            this.moveLastButton = new System.Windows.Forms.Button();
            this.moveBeforeButton = new System.Windows.Forms.Button();
            this.moveAfterButton = new System.Windows.Forms.Button();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.shapeNameLabel = new System.Windows.Forms.Label();
            this.brushColorBButton = new System.Windows.Forms.Button();
            this.penTypePanel = new System.Windows.Forms.Panel();
            this.compoundButton = new System.Windows.Forms.RadioButton();
            this.dashedButton = new System.Windows.Forms.RadioButton();
            this.solidPButton = new System.Windows.Forms.RadioButton();
            this.brushTypePanel = new System.Windows.Forms.Panel();
            this.linearGradientButton = new System.Windows.Forms.RadioButton();
            this.hatchedButton = new System.Windows.Forms.RadioButton();
            this.solidBButton = new System.Windows.Forms.RadioButton();
            this.shapeTypePanel = new System.Windows.Forms.Panel();
            this.customButton = new System.Windows.Forms.RadioButton();
            this.rectangleButton = new System.Windows.Forms.RadioButton();
            this.ellipseButton = new System.Windows.Forms.RadioButton();
            this.displayLabel = new System.Windows.Forms.Label();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.penColorButton = new System.Windows.Forms.Button();
            this.penTypeLabel = new System.Windows.Forms.Label();
            this.brushColorAButton = new System.Windows.Forms.Button();
            this.brushTypeLabel = new System.Windows.Forms.Label();
            this.shapeTypeLabel = new System.Windows.Forms.Label();
            this.POKButton = new System.Windows.Forms.Button();

            this.applyButton = new System.Windows.Forms.Button();

            this.DialogPanel.SuspendLayout();
            this.listButtonPanel.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            this.penTypePanel.SuspendLayout();
            this.brushTypePanel.SuspendLayout();
            this.shapeTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DialogPanel
            // 
            this.DialogPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.DialogPanel.Controls.Add(this.applyButton);
            this.DialogPanel.Controls.Add(this.POKButton);
            this.DialogPanel.Controls.Add(this.optionsPanel);
            this.DialogPanel.Controls.Add(this.listButtonPanel);
            this.DialogPanel.Size = new System.Drawing.Size(659, 561);
            this.DialogPanel.Controls.SetChildIndex(this.listButtonPanel, 0);
            this.DialogPanel.Controls.SetChildIndex(this.optionsPanel, 0);
            this.DialogPanel.Controls.SetChildIndex(this.teamDetails, 0);
            this.DialogPanel.Controls.SetChildIndex(this.teamNames, 0);
            this.DialogPanel.Controls.SetChildIndex(this.POKButton, 0);
            this.DialogPanel.Controls.SetChildIndex(this.applyButton, 0);
            // 
            // teamNames
            // 
            this.teamNames.Location = new System.Drawing.Point(0, 459);
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
            this.listButtonPanel.Location = new System.Drawing.Point(80, 395);
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
            this.optionsPanel.Controls.Add(this.shapeNameLabel);
            this.optionsPanel.Controls.Add(this.brushColorBButton);
            this.optionsPanel.Controls.Add(this.penTypePanel);
            this.optionsPanel.Controls.Add(this.brushTypePanel);
            this.optionsPanel.Controls.Add(this.shapeTypePanel);
            this.optionsPanel.Controls.Add(this.displayLabel);
            this.optionsPanel.Controls.Add(this.displayPanel);
            this.optionsPanel.Controls.Add(this.penColorButton);
            this.optionsPanel.Controls.Add(this.penTypeLabel);
            this.optionsPanel.Controls.Add(this.brushColorAButton);
            this.optionsPanel.Controls.Add(this.brushTypeLabel);
            this.optionsPanel.Controls.Add(this.shapeTypeLabel);
            this.optionsPanel.Location = new System.Drawing.Point(78, 42);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(493, 350);
            this.optionsPanel.TabIndex = 7;
            // 
            // shapeNameLabel
            // 
            this.shapeNameLabel.AutoSize = true;
            this.shapeNameLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.shapeNameLabel.ForeColor = System.Drawing.Color.Gold;
            this.shapeNameLabel.Location = new System.Drawing.Point(87, 121);
            this.shapeNameLabel.Name = "shapeNameLabel";
            this.shapeNameLabel.Size = new System.Drawing.Size(0, 13);
            this.shapeNameLabel.TabIndex = 27;
            // 
            // brushColorBButton
            // 
            this.brushColorBButton.Location = new System.Drawing.Point(253, 116);
            this.brushColorBButton.Name = "brushColorBButton";
            this.brushColorBButton.Size = new System.Drawing.Size(58, 23);
            this.brushColorBButton.TabIndex = 26;
            this.brushColorBButton.Text = "Color B";
            this.brushColorBButton.UseVisualStyleBackColor = true;
            this.brushColorBButton.Click += new System.EventHandler(this.brushColorButtonB_Click);
            // 
            // penTypePanel
            // 
            this.penTypePanel.Controls.Add(this.compoundButton);
            this.penTypePanel.Controls.Add(this.dashedButton);
            this.penTypePanel.Controls.Add(this.solidPButton);
            this.penTypePanel.ForeColor = System.Drawing.Color.Gold;
            this.penTypePanel.Location = new System.Drawing.Point(352, 40);
            this.penTypePanel.Name = "penTypePanel";
            this.penTypePanel.Size = new System.Drawing.Size(115, 70);
            this.penTypePanel.TabIndex = 25;
            // 
            // compoundButton
            // 
            this.compoundButton.AutoSize = true;
            this.compoundButton.ForeColor = System.Drawing.Color.Gold;
            this.compoundButton.Location = new System.Drawing.Point(3, 49);
            this.compoundButton.Name = "compoundButton";
            this.compoundButton.Size = new System.Drawing.Size(76, 17);
            this.compoundButton.TabIndex = 23;
            this.compoundButton.TabStop = true;
            this.compoundButton.Text = "Compound";
            this.compoundButton.UseVisualStyleBackColor = true;
            this.compoundButton.CheckedChanged += new System.EventHandler(this.compoundButton_CheckedChanged);
            // 
            // dashedButton
            // 
            this.dashedButton.AutoSize = true;
            this.dashedButton.ForeColor = System.Drawing.Color.Gold;
            this.dashedButton.Location = new System.Drawing.Point(3, 26);
            this.dashedButton.Name = "dashedButton";
            this.dashedButton.Size = new System.Drawing.Size(62, 17);
            this.dashedButton.TabIndex = 22;
            this.dashedButton.TabStop = true;
            this.dashedButton.Text = "Dashed";
            this.dashedButton.UseVisualStyleBackColor = true;
            this.dashedButton.CheckedChanged += new System.EventHandler(this.dashedButton_CheckedChanged);
            // 
            // solidPButton
            // 
            this.solidPButton.AutoSize = true;
            this.solidPButton.ForeColor = System.Drawing.Color.Gold;
            this.solidPButton.Location = new System.Drawing.Point(3, 3);
            this.solidPButton.Name = "solidPButton";
            this.solidPButton.Size = new System.Drawing.Size(48, 17);
            this.solidPButton.TabIndex = 21;
            this.solidPButton.TabStop = true;
            this.solidPButton.Text = "Solid";
            this.solidPButton.UseVisualStyleBackColor = true;
            this.solidPButton.CheckedChanged += new System.EventHandler(this.solidPButton_CheckedChanged);
            // 
            // brushTypePanel
            // 
            this.brushTypePanel.Controls.Add(this.linearGradientButton);
            this.brushTypePanel.Controls.Add(this.hatchedButton);
            this.brushTypePanel.Controls.Add(this.solidBButton);
            this.brushTypePanel.ForeColor = System.Drawing.Color.Gold;
            this.brushTypePanel.Location = new System.Drawing.Point(189, 40);
            this.brushTypePanel.Name = "brushTypePanel";
            this.brushTypePanel.Size = new System.Drawing.Size(120, 70);
            this.brushTypePanel.TabIndex = 24;
            // 
            // linearGradientButton
            // 
            this.linearGradientButton.AutoSize = true;
            this.linearGradientButton.ForeColor = System.Drawing.Color.Gold;
            this.linearGradientButton.Location = new System.Drawing.Point(10, 49);
            this.linearGradientButton.Name = "linearGradientButton";
            this.linearGradientButton.Size = new System.Drawing.Size(97, 17);
            this.linearGradientButton.TabIndex = 20;
            this.linearGradientButton.TabStop = true;
            this.linearGradientButton.Text = "Linear Gradient";
            this.linearGradientButton.UseVisualStyleBackColor = true;
            this.linearGradientButton.CheckedChanged += new System.EventHandler(this.linearGradientButton_CheckedChanged);
            // 
            // hatchedButton
            // 
            this.hatchedButton.AutoSize = true;
            this.hatchedButton.ForeColor = System.Drawing.Color.Gold;
            this.hatchedButton.Location = new System.Drawing.Point(10, 26);
            this.hatchedButton.Name = "hatchedButton";
            this.hatchedButton.Size = new System.Drawing.Size(66, 17);
            this.hatchedButton.TabIndex = 19;
            this.hatchedButton.TabStop = true;
            this.hatchedButton.Text = "Hatched";
            this.hatchedButton.UseVisualStyleBackColor = true;
            this.hatchedButton.CheckedChanged += new System.EventHandler(this.hatchedButton_CheckedChanged);
            // 
            // solidBButton
            // 
            this.solidBButton.AutoSize = true;
            this.solidBButton.ForeColor = System.Drawing.Color.Gold;
            this.solidBButton.Location = new System.Drawing.Point(10, 3);
            this.solidBButton.Name = "solidBButton";
            this.solidBButton.Size = new System.Drawing.Size(48, 17);
            this.solidBButton.TabIndex = 18;
            this.solidBButton.TabStop = true;
            this.solidBButton.Text = "Solid";
            this.solidBButton.UseVisualStyleBackColor = true;
            this.solidBButton.CheckedChanged += new System.EventHandler(this.solidBButton_CheckedChanged);
            // 
            // shapeTypePanel
            // 
            this.shapeTypePanel.Controls.Add(this.customButton);
            this.shapeTypePanel.Controls.Add(this.rectangleButton);
            this.shapeTypePanel.Controls.Add(this.ellipseButton);
            this.shapeTypePanel.ForeColor = System.Drawing.Color.Gold;
            this.shapeTypePanel.Location = new System.Drawing.Point(23, 37);
            this.shapeTypePanel.Name = "shapeTypePanel";
            this.shapeTypePanel.Size = new System.Drawing.Size(116, 73);
            this.shapeTypePanel.TabIndex = 23;
            // 
            // customButton
            // 
            this.customButton.AutoSize = true;
            this.customButton.ForeColor = System.Drawing.Color.Gold;
            this.customButton.Location = new System.Drawing.Point(8, 52);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(60, 17);
            this.customButton.TabIndex = 17;
            this.customButton.TabStop = true;
            this.customButton.Text = "Custom";
            this.customButton.UseVisualStyleBackColor = true;
            this.customButton.CheckedChanged += new System.EventHandler(this.customButton_CheckedChanged);
            // 
            // rectangleButton
            // 
            this.rectangleButton.AutoSize = true;
            this.rectangleButton.ForeColor = System.Drawing.Color.Gold;
            this.rectangleButton.Location = new System.Drawing.Point(7, 29);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(74, 17);
            this.rectangleButton.TabIndex = 16;
            this.rectangleButton.TabStop = true;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.CheckedChanged += new System.EventHandler(this.rectangleButton_CheckedChanged);
            // 
            // ellipseButton
            // 
            this.ellipseButton.AutoSize = true;
            this.ellipseButton.ForeColor = System.Drawing.Color.Gold;
            this.ellipseButton.Location = new System.Drawing.Point(7, 6);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(55, 17);
            this.ellipseButton.TabIndex = 15;
            this.ellipseButton.TabStop = true;
            this.ellipseButton.Text = "Ellipse";
            this.ellipseButton.UseVisualStyleBackColor = true;
            this.ellipseButton.CheckedChanged += new System.EventHandler(this.ellipseButton_CheckedChanged);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.ForeColor = System.Drawing.Color.Gold;
            this.displayLabel.Location = new System.Drawing.Point(20, 121);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(71, 13);
            this.displayLabel.TabIndex = 13;
            this.displayLabel.Text = "Sample View:";
            // 
            // displayPanel
            // 
            this.displayPanel.BackColor = System.Drawing.Color.White;
            this.displayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPanel.Location = new System.Drawing.Point(3, 148);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(487, 202);
            this.displayPanel.TabIndex = 12;
            this.displayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.displayPanel_Paint);
            // 
            // penColorButton
            // 
            this.penColorButton.Location = new System.Drawing.Point(352, 116);
            this.penColorButton.Name = "penColorButton";
            this.penColorButton.Size = new System.Drawing.Size(115, 23);
            this.penColorButton.TabIndex = 8;
            this.penColorButton.Text = "Pen Color";
            this.penColorButton.UseVisualStyleBackColor = true;
            this.penColorButton.Click += new System.EventHandler(this.penColorButton_Click);
            // 
            // penTypeLabel
            // 
            this.penTypeLabel.AutoSize = true;
            this.penTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penTypeLabel.ForeColor = System.Drawing.Color.Gold;
            this.penTypeLabel.Location = new System.Drawing.Point(349, 11);
            this.penTypeLabel.Name = "penTypeLabel";
            this.penTypeLabel.Size = new System.Drawing.Size(67, 16);
            this.penTypeLabel.TabIndex = 6;
            this.penTypeLabel.Text = "Pen Type";
            // 
            // brushColorAButton
            // 
            this.brushColorAButton.Location = new System.Drawing.Point(189, 116);
            this.brushColorAButton.Name = "brushColorAButton";
            this.brushColorAButton.Size = new System.Drawing.Size(58, 23);
            this.brushColorAButton.TabIndex = 5;
            this.brushColorAButton.Text = "Color A";
            this.brushColorAButton.UseVisualStyleBackColor = true;
            this.brushColorAButton.Click += new System.EventHandler(this.brushColorButtonA_Click);
            // 
            // brushTypeLabel
            // 
            this.brushTypeLabel.AutoSize = true;
            this.brushTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brushTypeLabel.ForeColor = System.Drawing.Color.Gold;
            this.brushTypeLabel.Location = new System.Drawing.Point(186, 11);
            this.brushTypeLabel.Name = "brushTypeLabel";
            this.brushTypeLabel.Size = new System.Drawing.Size(77, 16);
            this.brushTypeLabel.TabIndex = 2;
            this.brushTypeLabel.Text = "Brush Type";
            // 
            // shapeTypeLabel
            // 
            this.shapeTypeLabel.AutoSize = true;
            this.shapeTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeTypeLabel.ForeColor = System.Drawing.Color.Gold;
            this.shapeTypeLabel.Location = new System.Drawing.Point(20, 11);
            this.shapeTypeLabel.Name = "shapeTypeLabel";
            this.shapeTypeLabel.Size = new System.Drawing.Size(83, 16);
            this.shapeTypeLabel.TabIndex = 0;
            this.shapeTypeLabel.Text = "Shape Type";
            // 
            // POKButton
            // 

            this.POKButton.Location = new System.Drawing.Point(420, 422);

            this.POKButton.Name = "POKButton";
            this.POKButton.Size = new System.Drawing.Size(70, 26);
            this.POKButton.TabIndex = 8;
            this.POKButton.Text = "OK";
            this.POKButton.UseVisualStyleBackColor = true;
            this.POKButton.Click += new System.EventHandler(this.POKButton_Click);
            // 

            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(497, 422);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(73, 31);
            this.applyButton.TabIndex = 9;
            this.applyButton.Text = "APPLY";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 

            // ShapeOptionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 561);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShapeOptionsDialog";
            this.Text = "Shape Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShapeOptionsDialog_FormClosed);
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Preferences_HelpRequested);
            this.DialogPanel.ResumeLayout(false);
            this.listButtonPanel.ResumeLayout(false);
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            this.penTypePanel.ResumeLayout(false);
            this.penTypePanel.PerformLayout();
            this.brushTypePanel.ResumeLayout(false);
            this.brushTypePanel.PerformLayout();
            this.shapeTypePanel.ResumeLayout(false);
            this.shapeTypePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel listButtonPanel;
        private System.Windows.Forms.Button moveFirstButton;
        private System.Windows.Forms.Button moveBeforeButton;
        private System.Windows.Forms.Button moveLastButton;
        private System.Windows.Forms.Button moveAfterButton;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Label shapeTypeLabel;
        private System.Windows.Forms.Label brushTypeLabel;
        private System.Windows.Forms.Button brushColorAButton;
        private System.Windows.Forms.Button penColorButton;
        private System.Windows.Forms.Label penTypeLabel;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Panel penTypePanel;
        private System.Windows.Forms.RadioButton compoundButton;
        private System.Windows.Forms.RadioButton dashedButton;
        private System.Windows.Forms.RadioButton solidPButton;
        private System.Windows.Forms.Panel brushTypePanel;
        private System.Windows.Forms.RadioButton linearGradientButton;
        private System.Windows.Forms.RadioButton hatchedButton;
        private System.Windows.Forms.RadioButton solidBButton;
        private System.Windows.Forms.Panel shapeTypePanel;
        private System.Windows.Forms.RadioButton customButton;
        private System.Windows.Forms.RadioButton rectangleButton;
        private System.Windows.Forms.RadioButton ellipseButton;
        private System.Windows.Forms.Button POKButton;
        private System.Windows.Forms.Button brushColorBButton;
        private System.Windows.Forms.Label shapeNameLabel;
        private System.Windows.Forms.Button applyButton;
    }
}