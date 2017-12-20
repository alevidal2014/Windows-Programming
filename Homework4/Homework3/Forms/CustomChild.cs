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

namespace Homework3.Forms
{
    public partial class CustomChild : BaseForm, ICustomForm
    {

        public int SideMeasure { get { return this.Width; } }
        public event EventHandler FocusIN;
        public event EventHandler FocusOUT;

        public CustomChild(int width, float ratio)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Update(width, ratio);
            SetCustomRegion();
        }

        private void SetCustomRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(this.ClientRectangle);
                Point intersectionPoint = new Point(this.Location.X - this.Width / 2, this.Location.Y - this.Height / 2);
                Rectangle rect = new Rectangle(intersectionPoint, new Size(this.Width, this.Height));
                path.AddRectangle(rect);
                path.FillMode = FillMode.Winding;
                this.Region = new Region(path);

            }
        }

        public void Update(int newWidth, float newRatio)
        {
            this.Width = newWidth;
            this.Height = (int)(newWidth * newRatio);
            SetCustomRegion();
        }

        private void CustomChild_Enter(object sender, EventArgs e)
        {
            this.FocusIN(this, EventArgs.Empty);
        }

        private void CustomChild_Leave(object sender, EventArgs e)
        {
            this.FocusOUT(this, EventArgs.Empty);
        }
    }
}