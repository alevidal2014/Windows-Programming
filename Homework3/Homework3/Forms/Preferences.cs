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

            if (!int.TryParse(this.widthTextBox.Text, out width))
            {
                error = "Data must be a positive integer";
                e.Cancel = true;
            }

            if(widthTextBox.Text == string.Empty)
            {
                error = "Data cant be empty";
                e.Cancel = true;
            }

            if (width < 10 || width > 1000)
            {
                error = "Invalid Width Range (10 - 1000)";
                e.Cancel = true;
            }

            epValues.SetError(widthTextBox, error);

        }

        //Validating the height (10-1000) using an error provider
        private void heightTextBox_Validating(object sender, CancelEventArgs e)
        {
            int height = 0;
            string error = string.Empty;


            if (!int.TryParse(this.heightTextBox.Text, out height))
            {
                error = "Data must be a positive integer";
                e.Cancel = true;
            }

            if (heightTextBox.Text == string.Empty)
            {
                error = "Data cant be empty";
                e.Cancel = true;
            }

            if (height < 10 || height > 1000)
            {
                error = "Invalid Height Range (10 - 1000)";
                e.Cancel = true;
            }

            epValues.SetError(heightTextBox, error);

        }

        //Validating the Ellipse Ratio (10-1000) using an error provider
        private void RatioTextBox_Validating(object sender, CancelEventArgs e)
        {
            float ratio;
            string error = string.Empty;

            if (!float.TryParse(this.RatioTextBox.Text, out ratio))
            {
                error = "Data must be a positive integer or floating point number";
                e.Cancel = true;
            }


            if (RatioTextBox.Text == string.Empty)
            {
                error = "Data cant be empty";
                e.Cancel = true;
            }

            if (ratio <0.2 || ratio >10.0)
            {
                error = "Invalid Ratio Range (0.2 - 10)";
                e.Cancel = true;
            }
            epValues.SetError((Control)sender, error);


        }

        //Validating the Rectangle Ratio (10-1000) using an error provider
        private void RectRatioTextBox_Validating(object sender, CancelEventArgs e)
        {
            float ratio;
            string error = string.Empty;

            if (!float.TryParse(this.RectRatioTextBox.Text, out ratio))
            {
                error = "Data must be a positive integer or floating point number";
                e.Cancel = true;
            }


            if (RectRatioTextBox.Text == string.Empty)
            {
                error = "Data cant be empty";
                e.Cancel = true;
            }

            if (ratio < 0.2 || ratio > 10.0)
            {
                error = "Invalid Ratio Range (0.2 - 10)";
                e.Cancel = true;
            }
            epValues.SetError((Control)sender, error);
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
            this.Active = false;
            if (!(this.DialogResult == DialogResult.OK)) {
                Revert_Changes();
                
            }
            Apply(this, EventArgs.Empty);

        }

        
    }
}
