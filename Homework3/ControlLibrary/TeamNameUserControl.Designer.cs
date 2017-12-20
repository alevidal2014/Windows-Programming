namespace ControlLibrary
{
    partial class TeamNameUserControl
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Alejandro Vidal Abrahantes");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Luis Miguel Fuentes Perez");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Steve Hirabayashi ");
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.TeamMemberList = new System.Windows.Forms.ListView();
            this.MainColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameLayoutPanel = new System.Windows.Forms.Panel();
            this.NameLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TeamNameLabel.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameLabel.ForeColor = System.Drawing.Color.Gold;
            this.TeamNameLabel.Location = new System.Drawing.Point(0, 0);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(300, 25);
            this.TeamNameLabel.TabIndex = 0;
            this.TeamNameLabel.Text = "COP 4226 - Team 1";
            // 
            // TeamMemberList
            // 
            this.TeamMemberList.BackColor = System.Drawing.Color.MediumBlue;
            this.TeamMemberList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeamMemberList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MainColumn});
            this.TeamMemberList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TeamMemberList.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamMemberList.ForeColor = System.Drawing.Color.Gold;
            this.TeamMemberList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.TeamMemberList.Location = new System.Drawing.Point(0, 30);
            this.TeamMemberList.Name = "TeamMemberList";
            this.TeamMemberList.Size = new System.Drawing.Size(300, 80);
            this.TeamMemberList.TabIndex = 1;
            this.TeamMemberList.UseCompatibleStateImageBehavior = false;
            this.TeamMemberList.View = System.Windows.Forms.View.List;
            // 
            // MainColumn
            // 
            this.MainColumn.Width = 300;
            // 
            // NameLayoutPanel
            // 
            this.NameLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLayoutPanel.Controls.Add(this.TeamNameLabel);
            this.NameLayoutPanel.Controls.Add(this.TeamMemberList);
            this.NameLayoutPanel.Location = new System.Drawing.Point(-2, -2);
            this.NameLayoutPanel.Name = "NameLayoutPanel";
            this.NameLayoutPanel.Size = new System.Drawing.Size(300, 110);
            this.NameLayoutPanel.TabIndex = 2;
            // 
            // TeamNameUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.NameLayoutPanel);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TeamNameUserControl";
            this.Size = new System.Drawing.Size(296, 106);
            this.NameLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.ListView TeamMemberList;
        private System.Windows.Forms.ColumnHeader MainColumn;
        private System.Windows.Forms.Panel NameLayoutPanel;
    }
}
