namespace ControlLibrary
{
    partial class TeamDetailUserControl
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
            this.CourseLabel = new System.Windows.Forms.Label();
            this.SemesterLabel = new System.Windows.Forms.Label();
            this.DetailLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DetailLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CourseLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseLabel.ForeColor = System.Drawing.Color.Gold;
            this.CourseLabel.Location = new System.Drawing.Point(3, 0);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(288, 18);
            this.CourseLabel.TabIndex = 0;
            this.CourseLabel.Text = "Advanced Windows Programming";
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SemesterLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterLabel.ForeColor = System.Drawing.Color.Gold;
            this.SemesterLabel.Location = new System.Drawing.Point(3, 18);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(192, 17);
            this.SemesterLabel.TabIndex = 1;
            this.SemesterLabel.Text = "Fall 2017 - Section UHA";
            // 
            // DetailLayoutPanel
            // 
            this.DetailLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DetailLayoutPanel.Controls.Add(this.CourseLabel);
            this.DetailLayoutPanel.Controls.Add(this.SemesterLabel);
            this.DetailLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.DetailLayoutPanel.Name = "DetailLayoutPanel";
            this.DetailLayoutPanel.Size = new System.Drawing.Size(300, 40);
            this.DetailLayoutPanel.TabIndex = 2;
            // 
            // TeamDetailUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.DetailLayoutPanel);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TeamDetailUserControl";
            this.Size = new System.Drawing.Size(300, 40);
            this.DetailLayoutPanel.ResumeLayout(false);
            this.DetailLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.Label SemesterLabel;
        private System.Windows.Forms.FlowLayoutPanel DetailLayoutPanel;
    }
}
