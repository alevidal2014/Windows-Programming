using ControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework8
{
    public partial class TextOptionsDialog : BaseDialog
    {
        // Used to temporarily disable textbox event handlers
        private bool disableEvent; 

        private ToolTip toolTips;
        private BindingList<Text> textsDoc;
        Point defaultPosition;
        public event EventHandler ChangesApplied;

        // use to determine if current selections are valid
        private bool TypeValid;
        private bool SizeValid;
        private bool XValid;
        private bool YValid;
        private bool RotValid;
        private bool AValid;
        private bool RValid;
        private bool GValid;
        private bool BValid;

        private BindingManagerBase BindingManager
        {
            get { return this.BindingContext[this.textsDoc]; }
        }

        public TextOptionsDialog()
        {
            InitializeComponent();
            defaultPosition = new Point(this.displayPanel.Width / 2, this.displayPanel.Height / 2);
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            // Create tooltips and set the captions for each control
            toolTips = new ToolTip();
            toolTips.IsBalloon = true;
            toolTips.ToolTipTitle = "Tool Tip";
            toolTips.ToolTipIcon = ToolTipIcon.Info;

            toolTips.SetToolTip(this.POKButton, "Click this to close dialog");
            toolTips.SetToolTip(this.applyButton, "Click this to apply changes made in text options dialog");
            toolTips.SetToolTip(this.moveFirstButton, "Click this to go to beginning of texts list");
            toolTips.SetToolTip(this.moveAfterButton, "Click this to go to next text in list");
            toolTips.SetToolTip(this.moveBeforeButton, "Click this to go to previous text in list");
            toolTips.SetToolTip(this.moveLastButton, "Click this to go to end of texts list");
            toolTips.SetToolTip(this.SelectFontButton, "Select a Font using a FontDialog");
            toolTips.SetToolTip(this.TypeComboBox, "Enter a Font Typeface, must not be a Symbol typeface");
            toolTips.SetToolTip(this.SizeTextBox, "Enter a Font Size, must be an integer between 8 and 72, Press ENTER to change size");
            toolTips.SetToolTip(this.StyleChecklistBox, "Select Font Styles (none selected will set style to Regular)");
            toolTips.SetToolTip(this.XLocTextBox, "Enter the X-coordinate for this text, must be a positive integer");
            toolTips.SetToolTip(this.YLocTextBox, "Enter the Y-coordinate for this text, must be a positive integer");
            toolTips.SetToolTip(this.RotTextBox, "Enter the angle the text will be rotated by, must be a floating point number");
            toolTips.SetToolTip(this.SelectColorButton, "Select a Color using a ColorDialog");
            toolTips.SetToolTip(this.RTextBox, "Enter Red value for color, must be an integer between 0 and 255");
            toolTips.SetToolTip(this.GTextBox, "Enter Green value for color, must be an integer between 0 and 255");
            toolTips.SetToolTip(this.BTextBox, "Enter Blue value for color, must be an integer between 0 and 255");
            toolTips.SetToolTip(this.ATextBox, "Enter Alpha value for color, must be an integer between 0 and 255");

            // Set help icons next to controls that need to be validated
            this.InputInfoProvider.Icon = Properties.Resources.if_Info_Circle_Symbol_Information_Letter_1396823;
            this.InputInfoProvider.SetError(this.TypeComboBox, this.toolTips.GetToolTip(this.TypeComboBox));
            this.InputInfoProvider.SetError(this.SizeTextBox, this.toolTips.GetToolTip(this.SizeTextBox));
            this.InputInfoProvider.SetError(this.XLocTextBox, this.toolTips.GetToolTip(this.XLocTextBox));
            this.InputInfoProvider.SetError(this.YLocTextBox, this.toolTips.GetToolTip(this.YLocTextBox));
            this.InputInfoProvider.SetError(this.RotTextBox, this.toolTips.GetToolTip(this.RotTextBox));
            this.InputInfoProvider.SetError(this.RTextBox, this.toolTips.GetToolTip(this.RTextBox));
            this.InputInfoProvider.SetError(this.GTextBox, this.toolTips.GetToolTip(this.GTextBox));
            this.InputInfoProvider.SetError(this.BTextBox, this.toolTips.GetToolTip(this.BTextBox));
            this.InputInfoProvider.SetError(this.ATextBox, this.toolTips.GetToolTip(this.ATextBox));

            TypeValid = true;
            SizeValid = true;
            XValid = true;
            YValid = true;
            RotValid = true;
            AValid = true;
            RValid = true;
            GValid = true;
            BValid = true;
            disableEvent = false;

            MainForm parent = this.Owner as MainForm;
            textsDoc = parent.MyTextsDoc.DocTexts;
            this.BindingManager.Position = parent.index;

            // Populate Typeface Combobox with all available Fonts, and initialize selected element
            List<string> fonts = new List<string>();
            foreach (FontFamily a_font in System.Drawing.FontFamily.Families)
            {
                TypeComboBox.Items.Add(a_font.Name);
            }

            updateUI();
        }

        // Update the UI on selected options, show a sample of the Shape's current settings
        private void updateUI()
        {
            // temporarily disable event handler for inputs so that they do not recursively call back this function
            disableEvent = true;

            var currentText = this.BindingManager.Current as Text;

            int index = TypeComboBox.FindString(currentText.TextFont.Name);
            TypeComboBox.SelectedIndex = index;
            this.SizeTextBox.Text = Math.Round(currentText.TextFont.Size).ToString();

            StyleChecklistBox.SetItemChecked(0, currentText.TextFont.Bold);
            StyleChecklistBox.SetItemChecked(1, currentText.TextFont.Italic);
            StyleChecklistBox.SetItemChecked(2, currentText.TextFont.Underline);
            StyleChecklistBox.SetItemChecked(3, currentText.TextFont.Strikeout);

            this.XLocTextBox.Text = currentText.Location.X.ToString();
            this.YLocTextBox.Text = currentText.Location.Y.ToString();
            this.RotTextBox.Text = currentText.Rotation.ToString();

            this.ATextBox.Text = currentText.TextColor.A.ToString();
            this.RTextBox.Text = currentText.TextColor.R.ToString();
            this.GTextBox.Text = currentText.TextColor.G.ToString();
            this.BTextBox.Text = currentText.TextColor.B.ToString();

            disableEvent = false;

            // Invoke Paint Event for display panel
            this.displayPanel.Invalidate();
        }

        // Read and cast input from the textboxes
        private void Read_Input()
        {
            var currentText = this.BindingManager.Current as Text;
            String selectedType = this.TypeComboBox.SelectedItem.ToString();

            int size, a, r, g, b;
            int.TryParse(this.SizeTextBox.Text, out size);
            int.TryParse(this.ATextBox.Text, out a);
            int.TryParse(this.RTextBox.Text, out r);
            int.TryParse(this.GTextBox.Text, out g);
            int.TryParse(this.BTextBox.Text, out b);

            if (size == 0) size = 12;

            bool[] styles = new bool[4];
            for (int i = 0; i < this.StyleChecklistBox.Items.Count; i++)
            {
                if (StyleChecklistBox.GetItemChecked(i)) styles[i] = true;
                else styles[i] = false;
            }

            // Generate the font from the input values, if all the font inputs are currently valid
            if (TypeValid && SizeValid)
            {
                if (!styles[0] && !styles[1] && !styles[2] && !styles[3]) currentText.TextFont = new Font(selectedType, size);
                else if (styles[0] && !styles[1] && !styles[2] && !styles[3]) currentText.TextFont = new Font(selectedType, size, FontStyle.Bold);
                else if (!styles[0] && styles[1] && !styles[2] && !styles[3]) currentText.TextFont = new Font(selectedType, size, FontStyle.Italic);
                else if (!styles[0] && !styles[1] && styles[2] && !styles[3]) currentText.TextFont = new Font(selectedType, size, FontStyle.Underline);
                else if (!styles[0] && !styles[1] && !styles[2] && styles[3]) currentText.TextFont = new Font(selectedType, size, FontStyle.Strikeout);
                else if (styles[0] && styles[1] && !styles[2] && !styles[3]) currentText.TextFont = new Font(selectedType, size, FontStyle.Bold | FontStyle.Italic);
                else if (styles[0] && !styles[1] && styles[2] && !styles[3]) currentText.TextFont = new Font(selectedType, size, FontStyle.Bold | FontStyle.Underline);
                else if (styles[0] && !styles[1] && !styles[2] && styles[3]) currentText.TextFont = new Font(selectedType, size, FontStyle.Bold | FontStyle.Strikeout);
                else if (!styles[0] && styles[1] && styles[2] && !styles[3]) currentText.TextFont = new Font(selectedType, size, FontStyle.Italic | FontStyle.Underline);
                else if (!styles[0] && styles[1] && !styles[2] && styles[3]) currentText.TextFont = new Font(selectedType, size, FontStyle.Italic | FontStyle.Strikeout);
                else if (!styles[0] && !styles[1] && styles[2] && styles[3]) currentText.TextFont = new Font(selectedType, size, FontStyle.Underline | FontStyle.Strikeout);
                else if (styles[0] && styles[1] && styles[2] && !styles[3]) currentText.TextFont = new Font(selectedType, size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                else if (styles[0] && styles[1] && !styles[2] && styles[3]) currentText.TextFont = new Font(selectedType, size, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout);
                else if (styles[0] && !styles[1] && styles[2] && styles[3]) currentText.TextFont = new Font(selectedType, size, FontStyle.Bold | FontStyle.Underline | FontStyle.Strikeout);
                else if (!styles[0] && styles[1] && styles[2] && styles[3]) currentText.TextFont = new Font(selectedType, size, FontStyle.Italic | FontStyle.Underline | FontStyle.Strikeout);
                else currentText.TextFont = new Font(selectedType, size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline | FontStyle.Strikeout);
            }

            // Generate the color from the input values, if all the color inputs are currently valid
            if (RValid && GValid && BValid && AValid)
                currentText.TextColor = Color.FromArgb(a, r, g, b);

            int x, y;
            float rot;
            int.TryParse(this.XLocTextBox.Text, out x);
            int.TryParse(this.YLocTextBox.Text, out y);
            float.TryParse(this.RotTextBox.Text, out rot);

            // Update Location if X and Y coordinates are valid, update rotation angle if Rotation angle is valid
            if (XValid && YValid)
                currentText.Location = new Point(x, y);
            if (RotValid)
                currentText.Rotation = rot;
        }

        // Draw sample text using selected options
        private void displayPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var currentText = this.BindingManager.Current as Text;

            // Save the graphics state
            GraphicsState state = g.Save();
            g.ResetTransform();
            // Rotate graphics
            g.RotateTransform(currentText.Rotation);

            // Position Text to center of display Panel
            g.TranslateTransform(defaultPosition.X, defaultPosition.Y, MatrixOrder.Append);

            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            // Draw text at origin, with center alignment
            var brush = new SolidBrush(currentText.TextColor);
            g.DrawString(currentText.TextContent, currentText.TextFont, brush, 0, 0, format);
            // Restore the graphics state
            g.Restore(state);

            // Clear Memory
            brush.Dispose();
            g.Dispose();
        }

        // OK button click event handler
        private void POKButton_Click(object sender, EventArgs e)
        {
            Close();
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

        private void ShapeOptionsDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.IsOptionsDialogOpen = false;
        }

        // Button click events to move between texts

        private void moveFirstButton_Click(object sender, EventArgs e)
        {
            this.BindingManager.Position = 0;
            updateUI();
        }

        private void moveAfterButton_Click(object sender, EventArgs e)
        {
            ++this.BindingManager.Position;
            updateUI();
        }

        private void moveBeforeButton_Click(object sender, EventArgs e)
        {
            --this.BindingManager.Position;
            updateUI();
        }

        private void moveLastButton_Click(object sender, EventArgs e)
        {
            this.BindingManager.Position = this.BindingManager.Count - 1;
            updateUI();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (this.ChangesApplied != null)
                {
                    ChangesApplied(this, e);
                }
            }
        }

        // Event Handler for changed selection for typeface combobox
        private void TypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                // Prevent Symbol Text Drawing
                Font testFont = new Font(TypeComboBox.Text, 12);
                if (testFont.GdiCharSet != 2)
                {
                    Read_Input();
                    updateUI();
                    TypeValid = true;
                }
                else
                    TypeValid = false;
            }
        }

        // Event Handler for ENTER pressed for size textbox
        private void SizeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!disableEvent)
                {
                    int val;
                    int.TryParse(this.SizeTextBox.Text, out val);
                    if (val >= 8 && val <= 72)
                    {
                        Read_Input();
                        updateUI();
                        SizeValid = true;
                    }
                    else
                        SizeValid = false;
                }
            }
        }

        // Event Handler for clicking on Select Font Button, set Font of current text to FontDialog result
        private void SelectFontButton_Click(object sender, EventArgs e)
        {
            var currentText = this.BindingManager.Current as Text;
            FontDialog fdlg = new FontDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                currentText.TextFont = fdlg.Font;
                updateUI();
            }
        }

        // Ask user to select a color using a color dialog
        private void SelectColorButton_Click(object sender, EventArgs e)
        {
            var currentText = this.BindingManager.Current as Text;
            ColorDialog cdlg = new ColorDialog();
            if (cdlg.ShowDialog() == DialogResult.OK)
            {
                currentText.TextColor = cdlg.Color;
                updateUI();
            }
        }

        // Event Handler for clicking a checkbox in styles checkboxlist
        private void StyleChecklistBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!disableEvent)
            {
                CheckedListBox clb = (CheckedListBox)sender;
                // Switch off event handler
                clb.ItemCheck -= StyleChecklistBox_ItemCheck;
                clb.SetItemCheckState(e.Index, e.NewValue);
                // Switch on event handler
                clb.ItemCheck += StyleChecklistBox_ItemCheck;

                Read_Input();
                updateUI();
            }
        }

        // Event Handler for changing text for X, Y and Rotation Text Boxes

        private void XLocTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                int val;
                int.TryParse(this.XLocTextBox.Text, out val);
                if (val >= 0)
                {
                    Read_Input();
                    updateUI();
                    XValid = true;
                }
                else
                    XValid = false;
            }
        }

        private void YLocTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                int val;
                int.TryParse(this.YLocTextBox.Text, out val);
                if (val >= 0)
                {
                    Read_Input();
                    updateUI();
                    YValid = true;
                }
                else
                    YValid = false;
            }
        }

        private void RotTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                if (RotTextBox.Text.Length > 0)
                {
                    Read_Input();
                    updateUI();
                    RotValid = true;
                }
                else
                    RotValid = false;
            }
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
                    Read_Input();
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
                    Read_Input();
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
                    Read_Input();
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
                    Read_Input();
                    updateUI();
                    AValid = true;
                }
                else
                    AValid = false;
            }
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

        // Event Handler for validating Font Typeface, Must not be a symbol typeface
        private void TypeComboBox_Validating(object sender, CancelEventArgs e)
        {
            string error = string.Empty;

            Font testFont = new Font(TypeComboBox.Text, 12);

            if (testFont.GdiCharSet == 2)
            {
                error = "Typeface cannot be a Symbol type";
                e.Cancel = true;
            }
            else
                e.Cancel = false;

            setErrorProvider(sender, e, error);
        }

        // Event Handler for validating Size textbox, Must be Integer with Range: [8, 72]
        private void SizeTextBox_Validating(object sender, CancelEventArgs e)
        {
            int value;
            string error = string.Empty;

            if (SizeTextBox.Text == string.Empty)
            {
                error = "Value cant be empty";
                e.Cancel = true;
            }
            else if (!int.TryParse(this.SizeTextBox.Text, out value))
            {
                error = "Value must be a positive integer";
                e.Cancel = true;
            }
            else if (value < 8 || value > 72)
            {
                error = "Invalid Range (0 - 255)";
                e.Cancel = true;
            }
            else
                e.Cancel = false;

            setErrorProvider(sender, e, error);
        }

        // Event Handlers for validating X, Y corrdinates, Must be Positive Integers
        private void XLocTextBox_Validating(object sender, CancelEventArgs e)
        {
            int value;
            string error = string.Empty;

            if (XLocTextBox.Text == string.Empty)
            {
                error = "Value cant be empty";
                e.Cancel = true;
            }
            else if (!int.TryParse(this.XLocTextBox.Text, out value))
            {
                error = "Value must be a positive integer";
                e.Cancel = true;
            }
            else
                e.Cancel = false;

            setErrorProvider(sender, e, error);
        }

        private void YLocTextBox_Validating(object sender, CancelEventArgs e)
        {
            int value;
            string error = string.Empty;

            if (YLocTextBox.Text == string.Empty)
            {
                error = "Value cant be empty";
                e.Cancel = true;
            }
            else if (!int.TryParse(this.YLocTextBox.Text, out value))
            {
                error = "Value must be a positive integer";
                e.Cancel = true;
            }
            else
                e.Cancel = false;

            setErrorProvider(sender, e, error);
        }

        private void RotTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = string.Empty;

            if (RotTextBox.Text == string.Empty)
            {
                error = "Value cant be empty";
                e.Cancel = true;
            }
            else
                e.Cancel = false;

            setErrorProvider(sender, e, error);
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
    }
}
