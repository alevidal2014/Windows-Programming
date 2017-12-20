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

namespace Homework9
{
    public partial class AboutDialog : BaseDialog
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        private void AboutDialog_Load(object sender, EventArgs e)
        {
            // Call Paint event
            this.AboutLabel.Invalidate(false);
        }

        private void AboutDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            TopForm.IsAboutDialogOpen = false;
        }

        // Creates a border around the about label with a linear gradient pen
        private void AboutLabel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Empty, Color.Empty, 30))
            {
                ColorBlend blend = new ColorBlend();
                blend.Colors = new Color[] { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Purple };
                blend.Positions = new float[] { 0f, 1/6f, 2/6f, 3/6f, 4/6f, 5/6f, 1f };
                brush.InterpolationColors = blend;
                using (Pen pen = new Pen(brush))
                {
                    pen.EndCap = LineCap.Flat;
                    Point lowerRight = new Point(this.AboutLabel.Size.Width-1, this.AboutLabel.Size.Height-1);

                    // Draw the border around about label
                    g.DrawLine(pen, 0, 0, lowerRight.X, 0);
                    g.DrawLine(pen, 0, 0, 0, lowerRight.Y);
                    g.DrawLine(pen, lowerRight.X, 0, lowerRight.X, lowerRight.Y);
                    g.DrawLine(pen, 0, lowerRight.Y, lowerRight.X, lowerRight.Y);
                }
            }
        }
    }
}
