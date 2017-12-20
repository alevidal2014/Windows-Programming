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

namespace Homework5
{
    public partial class Preferences : BaseDialog
    {
        public event EventHandler Apply;
        public Color color { get; set; }
        public Font font { get; set; }

        private bool AValid;
        private bool RValid;
        private bool GValid;
        private bool BValid;
        // Used to temporarily disable textbox event handlers
        private bool disableEvent; 

        private ToolTip toolTips;

        public Preferences()
        {
            InitializeComponent();
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            updateUI();
            AValid = true;
            RValid = true;
            GValid = true;
            BValid = true;
            disableEvent = false;

            // Create tooltips and set the captions for each control
            toolTips = new ToolTip();
            toolTips.IsBalloon = true;
            toolTips.ToolTipTitle = "Tool Tip";
            toolTips.ToolTipIcon = ToolTipIcon.Info;

            toolTips.SetToolTip(this.POKButton, "Click this to accept changes to preferences and close dialog");
            toolTips.SetToolTip(this.PCancelButton, "Click this to ignore changes to preferences and close dialog");
            toolTips.SetToolTip(this.PApplyButton, "Click this to accept changes to preferences");
            toolTips.SetToolTip(this.PResetButton, "Click this to reset preferences to default settings");
            toolTips.SetToolTip(this.RTextBox, "Enter Red value for color, must be an integer between 0 and 255");
            toolTips.SetToolTip(this.GTextBox, "Enter Green value for color, must be an integer between 0 and 255");
            toolTips.SetToolTip(this.BTextBox, "Enter Blue value for color, must be an integer between 0 and 255");
            toolTips.SetToolTip(this.ATextBox, "Enter Alpha value for color, must be an integer between 0 and 255");
            toolTips.SetToolTip(this.SelectColorButton, "Select a Color using a ColorDialog");
            toolTips.SetToolTip(this.SelectFontButton, "Select a Font using a FontDialog");

            // Set infoProviders for the text boxes
            this.InputInfoProvider.Icon = Properties.Resources.if_Info_Circle_Symbol_Information_Letter_1396823;
            this.Icon = Properties.Resources.PreferenceIcon;
            this.InputInfoProvider.SetError(this.RTextBox, this.toolTips.GetToolTip(this.RTextBox));
            this.InputInfoProvider.SetError(this.GTextBox, this.toolTips.GetToolTip(this.GTextBox));
            this.InputInfoProvider.SetError(this.BTextBox, this.toolTips.GetToolTip(this.BTextBox));
            this.InputInfoProvider.SetError(this.ATextBox, this.toolTips.GetToolTip(this.ATextBox));
        }

        //OK button click event handler. Uses thorough validation 
        private void POKButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                PApplyButton_Click(sender, e);
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        // Cancel Button click event handler.
        private void PCancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        // Apply button click handler. Uses thorough validation 
        private void PApplyButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (Apply != null)
                {
                    Apply(this, EventArgs.Empty);
                }
            }
        }

        // Reset button click handler. Reverts to original user settings for font and color
        private void PResetButton_Click(object sender, EventArgs e)
        {
            this.color = Properties.Settings.Default.ColorSetting;
            this.font = Properties.Settings.Default.FontSetting;
            updateUI();
        }

        // Ask user to select a color using a color dialog
        private void SelectColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            if (cdlg.ShowDialog() == DialogResult.OK)
            {
                this.color = cdlg.Color;
                updateUI();
            }
        }

        private void SelectFontButton_Click(object sender, EventArgs e)
        {
            FontDialog fdlg = new FontDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                this.font = fdlg.Font;
                updateUI();
            }
        }

        // Read and cast input from the textboxes
        private void Read_input()
        {
            int a, r, g, b;

            int.TryParse(this.ATextBox.Text, out a);
            int.TryParse(this.RTextBox.Text, out r);
            int.TryParse(this.GTextBox.Text, out g);
            int.TryParse(this.BTextBox.Text, out b);

            // Generate the color from the input values, if all the inputs are currently valid
            if (RValid && GValid && BValid && AValid)
                this.color = Color.FromArgb(a, r, g, b);
        }

        // Update the Ui on selected font and color
        private void updateUI()
        {
            this.DisplayColorLabel.Text = this.color.ToString();
            this.DisplayColorLabel.ForeColor = this.color;

            // temporarily disable event handler for textboxes so that they do not recursively call back this function
            disableEvent = true;

            this.ATextBox.Text = this.color.A.ToString();
            this.RTextBox.Text = this.color.R.ToString();
            this.GTextBox.Text = this.color.G.ToString();
            this.BTextBox.Text = this.color.B.ToString();

            disableEvent = false;

            this.DisplayFontLabel.Text = "Font: " + this.font.Name + ", Style: " + this.font.Style + ", Size: " + this.font.Size;
            this.DisplayFontLabel.Font = this.font;
        }

        // Event Handlers for text changed for color textboxes

        private void RTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                int val;
                int.TryParse(this.RTextBox.Text, out val);
                if (val >= 0 && val <= 255)
                {
                    Read_input();
                    updateUI();
                    RValid = true;
                }
                else
                    RValid = false;
            }
            
        }

        private void GTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                int val;
                int.TryParse(this.GTextBox.Text, out val);
                if (val >= 0 && val <= 255)
                {
                    Read_input();
                    updateUI();
                    GValid = true;
                }
                else
                    GValid = false;
            }
        }

        private void BTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                int val;
                int.TryParse(this.BTextBox.Text, out val);
                if (val >= 0 && val <= 255)
                {
                    Read_input();
                    updateUI();
                    BValid = true;
                }
                else
                    BValid = false;
            }
        }

        private void ATextBox_TextChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                int val;
                int.TryParse(this.ATextBox.Text, out val);
                if (val >= 0 && val <= 255)
                {
                    Read_input();
                    updateUI();
                    AValid = true;
                }
                else
                    AValid = false;
            }
        }


        // Event Handlers for validating Color textboxes, Must be Integers with Range: [0, 255]

        private void RTextBox_Validating(object sender, CancelEventArgs e)
        {
            int value;
            string error = string.Empty;

            if (RTextBox.Text == string.Empty)
            {
                error = "Value cant be empty";
                e.Cancel = true;
            }
            else if (!int.TryParse(this.RTextBox.Text, out value))
            {
                error = "Value must be a positive integer";
                e.Cancel = true;
            }
            else if (value < 0 || value > 255)
            {
                error = "Invalid Range (0 - 255)";
                e.Cancel = true;
            }
            else
                e.Cancel = false;

            setErrorProvider(sender, e, error);
        }

        private void GTextBox_Validating(object sender, CancelEventArgs e)
        {
            int value;
            string error = string.Empty;

            if (GTextBox.Text == string.Empty)
            {
                error = "Value cant be empty";
                e.Cancel = true;
            }
            else if (!int.TryParse(this.GTextBox.Text, out value))
            {
                error = "Value must be a positive integer";
                e.Cancel = true;
            }
            else if (value < 0 || value > 255)
            {
                error = "Invalid Range (0 - 255)";
                e.Cancel = true;
            }
            else
                e.Cancel = false;

            setErrorProvider(sender, e, error);
        }

        private void BTextBox_Validating(object sender, CancelEventArgs e)
        {
            int value;
            string error = string.Empty;

            if (BTextBox.Text == string.Empty)
            {
                error = "Value cant be empty";
                e.Cancel = true;
            }
            else if (!int.TryParse(this.BTextBox.Text, out value))
            {
                error = "Value must be a positive integer";
                e.Cancel = true;
            }
            else if (value < 0 || value > 255)
            {
                error = "Invalid Range (0 - 255)";
                e.Cancel = true;
            }
            else
                e.Cancel = false;

            setErrorProvider(sender, e, error);
        }

        private void ATextBox_Validating(object sender, CancelEventArgs e)
        {
            int value;
            string error = string.Empty;

            if (ATextBox.Text == string.Empty)
            {
                error = "Value cant be empty";
                e.Cancel = true;
            }
            else if (!int.TryParse(this.ATextBox.Text, out value))
            {
                error = "Value must be a positive integer";
                e.Cancel = true;
            }
            else if (value < 0 || value > 255)
            {
                error = "Invalid Range (0 - 255)";
                e.Cancel = true;
            }
            else
                e.Cancel = false;

            setErrorProvider(sender, e, error);
        }

        // Determine if error has been found to determine whether to use InfoProvider or ErrorProvider
        private void setErrorProvider(object sender, CancelEventArgs e, string error)
        {
            if (e.Cancel)
            {
                InputErrorProvider.SetError((Control)sender, error);
                InputInfoProvider.SetError((Control)sender, null);
            }
            else
            {
                InputErrorProvider.SetError((Control)sender, null);
                InputInfoProvider.SetError((Control)sender, this.toolTips.GetToolTip((Control)sender));
            }
        }

        // Event handler for clicking a control using the help cursor
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
