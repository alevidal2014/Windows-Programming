namespace Homework3
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.RectRatioTextBox = new System.Windows.Forms.TextBox();
            this.labelRratio = new System.Windows.Forms.Label();
            this.RatioTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.labelEratio = new System.Windows.Forms.Label();
            this.labelRheight = new System.Windows.Forms.Label();
            this.labelEwidth = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAPPLY = new System.Windows.Forms.Button();
            this.buttonCANCEL = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.epValues = new System.Windows.Forms.ErrorProvider(this.components);
            this.infoProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DialogPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DialogPanel
            // 
            this.DialogPanel.Controls.Add(this.panel1);
            this.DialogPanel.Controls.Add(this.panel2);
            this.DialogPanel.Size = new System.Drawing.Size(567, 411);
            this.DialogPanel.Controls.SetChildIndex(this.teamDetails, 0);
            this.DialogPanel.Controls.SetChildIndex(this.teamNames, 0);
            this.DialogPanel.Controls.SetChildIndex(this.panel2, 0);
            this.DialogPanel.Controls.SetChildIndex(this.panel1, 0);
            // 
            // teamNames
            // 
            this.teamNames.Location = new System.Drawing.Point(0, 294);
            this.teamNames.Size = new System.Drawing.Size(567, 117);
            // 
            // teamDetails
            // 
            this.teamDetails.Size = new System.Drawing.Size(567, 36);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.RectRatioTextBox);
            this.panel2.Controls.Add(this.labelRratio);
            this.panel2.Controls.Add(this.RatioTextBox);
            this.panel2.Controls.Add(this.heightTextBox);
            this.panel2.Controls.Add(this.widthTextBox);
            this.panel2.Controls.Add(this.labelEratio);
            this.panel2.Controls.Add(this.labelRheight);
            this.panel2.Controls.Add(this.labelEwidth);
            this.panel2.Location = new System.Drawing.Point(88, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 165);
            this.panel2.TabIndex = 10;
            // 
            // RectRatioTextBox
            // 
            this.RectRatioTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RectRatioTextBox.Location = new System.Drawing.Point(113, 114);
            this.RectRatioTextBox.Name = "RectRatioTextBox";
            this.RectRatioTextBox.Size = new System.Drawing.Size(191, 20);
            this.RectRatioTextBox.TabIndex = 13;
            this.RectRatioTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.RectRatioTextBox_Validating);
            // 
            // labelRratio
            // 
            this.labelRratio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRratio.AutoSize = true;
            this.labelRratio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRratio.Location = new System.Drawing.Point(17, 121);
            this.labelRratio.Name = "labelRratio";
            this.labelRratio.Size = new System.Drawing.Size(84, 13);
            this.labelRratio.TabIndex = 12;
            this.labelRratio.Text = "Rectangle Ratio";
            // 
            // RatioTextBox
            // 
            this.RatioTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RatioTextBox.Location = new System.Drawing.Point(113, 42);
            this.RatioTextBox.Name = "RatioTextBox";
            this.RatioTextBox.Size = new System.Drawing.Size(191, 20);
            this.RatioTextBox.TabIndex = 11;
            this.RatioTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.RatioTextBox_Validating);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heightTextBox.Location = new System.Drawing.Point(113, 84);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(191, 20);
            this.heightTextBox.TabIndex = 10;
            this.heightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.heightTextBox_Validating);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.widthTextBox.Location = new System.Drawing.Point(113, 13);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(191, 20);
            this.widthTextBox.TabIndex = 9;
            this.widthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.widthTextBox_Validating);
            // 
            // labelEratio
            // 
            this.labelEratio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEratio.AutoSize = true;
            this.labelEratio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEratio.Location = new System.Drawing.Point(39, 49);
            this.labelEratio.Name = "labelEratio";
            this.labelEratio.Size = new System.Drawing.Size(65, 13);
            this.labelEratio.TabIndex = 8;
            this.labelEratio.Text = "Ellipse Ratio";
            this.labelEratio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelRheight
            // 
            this.labelRheight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRheight.AutoSize = true;
            this.labelRheight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRheight.Location = new System.Drawing.Point(17, 91);
            this.labelRheight.Name = "labelRheight";
            this.labelRheight.Size = new System.Drawing.Size(90, 13);
            this.labelRheight.TabIndex = 7;
            this.labelRheight.Text = "Rectangle Height";
            // 
            // labelEwidth
            // 
            this.labelEwidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEwidth.AutoSize = true;
            this.labelEwidth.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEwidth.Location = new System.Drawing.Point(36, 20);
            this.labelEwidth.Name = "labelEwidth";
            this.labelEwidth.Size = new System.Drawing.Size(68, 13);
            this.labelEwidth.TabIndex = 6;
            this.labelEwidth.Text = "Ellipse Width";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonAPPLY);
            this.panel1.Controls.Add(this.buttonCANCEL);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Location = new System.Drawing.Point(88, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 47);
            this.panel1.TabIndex = 11;
            // 
            // buttonAPPLY
            // 
            this.buttonAPPLY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAPPLY.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonAPPLY.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAPPLY.Location = new System.Drawing.Point(290, 3);
            this.buttonAPPLY.Name = "buttonAPPLY";
            this.buttonAPPLY.Size = new System.Drawing.Size(75, 33);
            this.buttonAPPLY.TabIndex = 16;
            this.buttonAPPLY.Text = "APPLY";
            this.buttonAPPLY.UseVisualStyleBackColor = false;
            this.buttonAPPLY.Click += new System.EventHandler(this.buttonAPPLY_Click);
            // 
            // buttonCANCEL
            // 
            this.buttonCANCEL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCANCEL.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonCANCEL.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCANCEL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCANCEL.Location = new System.Drawing.Point(209, 3);
            this.buttonCANCEL.Name = "buttonCANCEL";
            this.buttonCANCEL.Size = new System.Drawing.Size(75, 33);
            this.buttonCANCEL.TabIndex = 15;
            this.buttonCANCEL.Text = "CANCEL";
            this.buttonCANCEL.UseVisualStyleBackColor = false;
            this.buttonCANCEL.Click += new System.EventHandler(this.buttonCANCEL_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonOK.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonOK.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.buttonOK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOK.Location = new System.Drawing.Point(128, 3);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 33);
            this.buttonOK.TabIndex = 14;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // epValues
            // 
            this.epValues.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epValues.ContainerControl = this;
            // 
            // infoProvider
            // 
            this.infoProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.infoProvider.ContainerControl = this;
            // 
            // Preferences
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.buttonCANCEL;
            this.ClientSize = new System.Drawing.Size(567, 411);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 420);
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Preferences_FormClosing);
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Preferences_HelpRequested);
            this.DialogPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAPPLY;
        private System.Windows.Forms.Button buttonCANCEL;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox RatioTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label labelEratio;
        private System.Windows.Forms.Label labelRheight;
        private System.Windows.Forms.Label labelEwidth;
        private System.Windows.Forms.ErrorProvider epValues;
        private System.Windows.Forms.TextBox RectRatioTextBox;
        private System.Windows.Forms.Label labelRratio;
        private System.Windows.Forms.ErrorProvider infoProvider;
    }
}