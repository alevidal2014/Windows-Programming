using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class BaseForm : Form
    {
        // Used to track cursor origin point
        private Point startPoint;

        public BaseForm()
        {
            InitializeComponent();
        }

        // Close the form when the user clicks the Close item
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Ask the user to select a background color using ColorDialog
        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cDlg = new ColorDialog();
            // Show the ColorDialog Modally, only change the color when the user presses the Ok button 
            if(cDlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = cDlg.Color;
            }
        }

        // These three event handlers allow the user to move the form using the mouse in the client area
        private void BaseForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                return;
            // Create the start point object using the current cursor position
            startPoint = new Point(e.X, e.Y);
        }

        private void BaseForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPoint == Point.Empty)
                return;
            // Calculate and set the new position relative to the top-left corner of the form & cursor's original location
            Point newPosition = new Point(this.Left + e.X - startPoint.X, this.Top + e.Y - startPoint.Y);
            this.Location = newPosition;
        }

        private void BaseForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                return;
            // Clear out the startPoint object
            startPoint = Point.Empty;
        }
    }
}
