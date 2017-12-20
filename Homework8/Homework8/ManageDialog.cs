using ControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework8
{
    public partial class ManageDialog : BaseDialog
    {
        private BindingList<Text> textsDoc;
        private BindingSource textsBindingSource;
        public event EventHandler ChangesApplied;
        private ToolTip toolTips;

        private BindingManagerBase BindingManager
        {
            get { return this.BindingContext[this.textsDoc]; }
        }

        public ManageDialog()
        {
            InitializeComponent();
        }

        private void ManageDialog_Load(object sender, EventArgs e)
        {
            // Create tooltips and set the captions for each control
            toolTips = new ToolTip();
            toolTips.IsBalloon = true;
            toolTips.ToolTipTitle = "Tool Tip";
            toolTips.ToolTipIcon = ToolTipIcon.Info;

            toolTips.SetToolTip(this.manageDataGridView, "View the Texts present in the Document\nDouble Click on a cell to Edit it");
            toolTips.SetToolTip(this.moveFirstButton, "Click this to go to beginning of texts list");
            toolTips.SetToolTip(this.moveAfterButton, "Click this to go to next text in list");
            toolTips.SetToolTip(this.moveBeforeButton, "Click this to go to previous text in list");
            toolTips.SetToolTip(this.moveLastButton, "Click this to go to end of texts list");
            toolTips.SetToolTip(this.AddButton, "Click this to add a default text object to end of list");
            toolTips.SetToolTip(this.RemoveButton, "Click this to remove the currently selected text object in list");
            toolTips.SetToolTip(this.OKButton, "Click this to close dialog");
            toolTips.SetToolTip(this.ApplyButton, "Click this to apply changes made in text options dialog");

            MainForm parent = this.Owner as MainForm;
            textsDoc = parent.MyTextsDoc.DocTexts;
            this.BindingManager.Position = parent.index;

            // Create a BindingSource for the BindingList
            this.textsBindingSource = new BindingSource(textsDoc, null);

            // Complex-Bind to DataGridView
            this.manageDataGridView.DataSource = this.textsBindingSource;
            // Update View
            updateUI();
        }

        private void ManageDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.IsOptionsDialogOpen = false;
        }

        // Update View of List Count
        private void updateUI()
        {
            this.PositionLabel.Text = (this.BindingManager.Position + 1) + "  of  " + this.BindingManager.Count;
        }

        // Button click events to move between texts and Update View

        private void moveFirstButton_Click(object sender, EventArgs e)
        {
            this.BindingManager.Position = 0;
            updateUI();
        }

        private void moveBeforeButton_Click(object sender, EventArgs e)
        {
            --this.BindingManager.Position;
            updateUI();
        }

        private void moveAfterButton_Click(object sender, EventArgs e)
        {
            ++this.BindingManager.Position;
            updateUI();
        }

        private void moveLastButton_Click(object sender, EventArgs e)
        {
            this.BindingManager.Position = this.BindingManager.Count - 1;
            updateUI();
        }

        // Add/Remove Texts from the Document shown in DataGridView

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Add to the BindingSource
            this.textsBindingSource.Add(new Text());
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // Remove from the BindingSource
            this.textsBindingSource.RemoveCurrent();
        }

        // Apply Edits Made in DataGridView
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (this.ChangesApplied != null)
            {
                ChangesApplied(this, e);
            }
        }

        // Close Dialog
        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Used to provide help info using Help button
        private void ManageDialog_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            // Convert screen coordinates to client coordinates
            Point pt = this.PointToClient(hlpevent.MousePos);

            // Look for control user clicked on
            Control control = FindChildAtPoint(this, pt);
            if (control == null)
                return;

            // Show help
            string help = this.toolTips.GetToolTip(control);
            if (string.IsNullOrEmpty(help))
                return;
            MessageBox.Show(help, "Help");
            hlpevent.Handled = true;
        }

        // Finds the control at the given point
        Control FindChildAtPoint(Control parent, Point pt)
        {
            // Find a child
            Control child = parent.GetChildAtPoint(pt);
            // If no child, this is the control at the mouse cursor
            if (child == null) return parent;
            // If a child, offset our current position to be relative to the child
            Point childPoint = new Point(pt.X - child.Location.X, pt.Y - child.Location.Y);
            // Find child of child control at offset position
            return FindChildAtPoint(child, childPoint);
        }
    }
}
