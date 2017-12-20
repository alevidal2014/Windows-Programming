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

namespace Homework3
{
    public partial class Preferences : BaseDialog, IMeasuresInput
    {

        public event EventHandler Apply;
        public int EllipseWidth { get; set; }
        public int RectangleHeight { get; set; }
        public float Ratio { get; set; }
        public float RecRatio { get; set; }
        public int EllipseWidthUnapplied { get; set; }
        public int RectangleHeightUnapplied { get; set; }
        public float RatioUnapplied { get; set; }
        public float RecRatioUnapplied { get; set; }
        public bool Active { get; set; }

        public ToolTip toolTips;

        public Preferences()
        {
            InitializeComponent();
        }


        #region Validation

        //Validating the width (10-1000) using an error provider
        private void widthTextBox_Validating(object sender, CancelEventArgs e)
        {
            int width;
            string error = string.Empty;

            if (widthTextBox.Text == string.Empty)
            {
                error = "Data cant be empty";
                e.Cancel = true;
            }

            else if (!int.TryParse(this.widthTextBox.Text, out width))
            {
                error = "Data must be a positive integer";
                e.Cancel = true;
            }

            else if (width < 10 || width > 1000)
            {
                error = "Invalid Width Range (10 - 1000)";
                e.Cancel = true;
            }

            // Determine if error has been found to determine whether to use InfoProvider or ErrorProvider
            if (e.Cancel)
            {
                epValues.SetError((Control)sender, error);
                infoProvider.SetError((Control)sender, null);
            }
            else
            {
                epValues.SetError((Control)sender, null);
                infoProvider.SetError((Control)sender, this.toolTips.GetToolTip((Control)sender));
            }
        }

        //Validating the height (10-1000) using an error provider
        private void heightTextBox_Validating(object sender, CancelEventArgs e)
        {
            int height = 0;
            string error = string.Empty;


            if (heightTextBox.Text == string.Empty)
            {
                error = "Data cant be empty";
                e.Cancel = true;
            }

            else if (!int.TryParse(this.heightTextBox.Text, out height))
            {
                error = "Data must be a positive integer";
                e.Cancel = true;
            }

            else if (height < 10 || height > 1000)
            {
                error = "Invalid Height Range (10 - 1000)";
                e.Cancel = true;
            }

            // Determine if error has been found to determine whether to use InfoProvider or ErrorProvider
            if (e.Cancel)
            {
                epValues.SetError((Control)sender, error);
                infoProvider.SetError((Control)sender, null);
            }
            else
            {
                epValues.SetError((Control)sender, null);
                infoProvider.SetError((Control)sender, this.toolTips.GetToolTip((Control)sender));
            }
        }

        //Validating the Ellipse Ratio (0.2 - 10) using an error provider
        private void RatioTextBox_Validating(object sender, CancelEventArgs e)
        {
            float ratio;
            string error = string.Empty;

            if (RatioTextBox.Text == string.Empty)
            {
                error = "Data cant be empty";
                e.Cancel = true;
            }

            else if (!float.TryParse(this.RatioTextBox.Text, out ratio))
            {
                error = "Data must be a positive integer or floating point number";
                e.Cancel = true;
            }

            else if (ratio <0.2 || ratio >10.0)
            {
                error = "Invalid Ratio Range (0.2 - 10)";
                e.Cancel = true;
            }

            // Determine if error has been found to determine whether to use InfoProvider or ErrorProvider
            if (e.Cancel)
            {
                epValues.SetError((Control)sender, error);
                infoProvider.SetError((Control)sender, null);
            }
            else
            {
                epValues.SetError((Control)sender, null);
                infoProvider.SetError((Control)sender, this.toolTips.GetToolTip((Control)sender));
            }
        }

        //Validating the Rectangle Ratio (0.2 - 10) using an error provider
        private void RectRatioTextBox_Validating(object sender, CancelEventArgs e)
        {
            float ratio;
            string error = string.Empty;

            if (RectRatioTextBox.Text == string.Empty)
            {
                error = "Data cant be empty";
                e.Cancel = true;
            }

            else if (!float.TryParse(this.RectRatioTextBox.Text, out ratio))
            {
                error = "Data must be a positive integer or floating point number";
                e.Cancel = true;
            }

            else if (ratio < 0.2 || ratio > 10.0)
            {
                error = "Invalid Ratio Range (0.2 - 10)";
                e.Cancel = true;
            }

            // Determine if error has been found to determine whether to use InfoProvider or ErrorProvider
            if (e.Cancel)
            {
                epValues.SetError((Control)sender, error);
                infoProvider.SetError((Control)sender, null);
            }
            else
            {
                epValues.SetError((Control)sender, null);
                infoProvider.SetError((Control)sender, this.toolTips.GetToolTip((Control)sender));
            }
        }
        #endregion

        //OK button click event handler. Uses thorough validation 
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                buttonAPPLY_Click(sender, e);
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        //Cancel Button click event handler.
        private void buttonCANCEL_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();

        }

        //Apply button click handler. Uses thorough validation 
        private void buttonAPPLY_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (Apply != null)
                {
                    Read_input();
                    Apply(this, EventArgs.Empty);
                    
                }
            }
        }

        //Load the values of the child dialogs into the preference dialog
        private void Preferences_Load(object sender, EventArgs e)
        {
            // Subscribe to parent's activate and deactivate events
            MainForm parent = this.Owner as MainForm;
            parent.ActivateParent += new EventHandler(parent_Activated);
            parent.DeactivateParent += new EventHandler(parent_Deactivated);

            // Create tooltips and set the captions for each control
            toolTips = new ToolTip();
            toolTips.IsBalloon = true;
            toolTips.ToolTipTitle = "Tool Tip";
            toolTips.ToolTipIcon = ToolTipIcon.Info;

            toolTips.SetToolTip(this.buttonOK, "Click this to accept changes to preferences and close dialog");
            toolTips.SetToolTip(this.buttonCANCEL, "Click this to ignore changes to preferences and close dialog");
            toolTips.SetToolTip(this.buttonAPPLY, "Click this to accept changes to preferences");
            toolTips.SetToolTip(this.widthTextBox, "Enter Width of Ellipse, must be between 10 and 1000");
            toolTips.SetToolTip(this.RatioTextBox, "Enter Ratio of Ellipse (relative to Width), must be between 0.2 and 10");
            toolTips.SetToolTip(this.heightTextBox, "Enter Height of Rectangle, must be between 10 and 1000");
            toolTips.SetToolTip(this.RectRatioTextBox, "Enter Ratio of Rectangle (relative to Height), must be between 0.2 and 10");

            // Set infoProviders for the text boxes
            this.infoProvider.Icon = Properties.Resources.if_Info_Circle_Symbol_Information_Letter_1396823;
            this.infoProvider.SetError(this.widthTextBox, this.toolTips.GetToolTip(this.widthTextBox));
            this.infoProvider.SetError(this.RatioTextBox, this.toolTips.GetToolTip(this.RatioTextBox));
            this.infoProvider.SetError(this.heightTextBox, this.toolTips.GetToolTip(this.heightTextBox));
            this.infoProvider.SetError(this.RectRatioTextBox, this.toolTips.GetToolTip(this.RectRatioTextBox));

            this.Active = true;
            this.widthTextBox.Text = this.EllipseWidthUnapplied.ToString();
            this.heightTextBox.Text = this.RectangleHeightUnapplied.ToString();
            this.RatioTextBox.Text = this.RatioUnapplied.ToString();
            this.RectRatioTextBox.Text = this.RecRatioUnapplied.ToString();
            //Hide the Apply button if it is in Modal Form
            if (this.Modal) 
            {
                this.buttonAPPLY.Hide();
            }
        }

        //Function used when the cancel, ESC or X buttons are clicked to revert the changes to the values
        //when the form was open
        private void Revert_Changes()
        {
            this.EllipseWidth = this.EllipseWidthUnapplied;
            this.RectangleHeight = this.RectangleHeightUnapplied;
            this.Ratio = this.RatioUnapplied;
            this.RecRatio = this.RecRatioUnapplied;
        }

        // Read and cast input from the textboxes
        private void Read_input()
        {
            int wi;
            int he;
            float era;
            float rra;

            int.TryParse(this.widthTextBox.Text, out wi);
            int.TryParse(this.heightTextBox.Text, out he);
            float.TryParse(this.RatioTextBox.Text, out era);
            float.TryParse(this.RectRatioTextBox.Text, out rra);

            this.EllipseWidth = wi;
            this.RectangleHeight = he;
            this.Ratio = era;
            this.RecRatio = rra;
        }

        // Closing event handler that revert all the changes only if the form is not closed by the 
        // OK button
        private void Preferences_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Unsubscribe to parent's activate and deactivate events
            MainForm parent = this.Owner as MainForm;
            parent.ActivateParent -= new EventHandler(parent_Activated);
            parent.DeactivateParent -= new EventHandler(parent_Deactivated);

            this.Active = false;
            if (!(this.DialogResult == DialogResult.OK)) {
                Revert_Changes();
                
            }
            Apply(this, EventArgs.Empty);

        }

        // Change opacity of preferences dialog when parent events fire
        private void parent_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void parent_Deactivated(object sender, EventArgs e)
        {
            this.Opacity = 0.85;
        }

        // Event to handle clicking a control using the help cursor
        private void Preferences_HelpRequested(object sender, HelpEventArgs e)
        {

            // Convert screen coordinates to client coordinates
            Point pt = this.PointToClient(e.MousePos);

            // Look for control user clicked on
            Control control = FindChildAtPoint(this, pt);
            if (control == null)
                return;

            // Show help
            string help = this.toolTips.GetToolTip(control);
            if (string.IsNullOrEmpty(help))
                return;
            MessageBox.Show(help, "Help");
            e.Handled = true;
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
