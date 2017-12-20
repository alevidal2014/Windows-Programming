using ControlLibrary;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System;

namespace Homework3
{
    public partial class EllipticChild : BaseForm, ICustomForm
    {
        public int SideMeasure { get { return this.Width; } }
        public event EventHandler FocusIN;
        public event EventHandler FocusOUT;

        public EllipticChild(int width, float ratio)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Update(width, ratio);
            SetEllipseRegion();
        }

        private void SetEllipseRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(this.ClientRectangle);
                this.Region = new Region(path);
            }
        }

        public void Update(int newWidth, float newRatio)
        {
            this.Width = newWidth;
            this.Height = (int)(newWidth * newRatio);
            SetEllipseRegion();
        }

        private void EllipticChild_Enter(object sender, System.EventArgs e)
        {
            this.FocusIN(this, EventArgs.Empty);
        }

        private void EllipticChild_Leave(object sender, EventArgs e)
        {
            this.FocusOUT(this, EventArgs.Empty);
        }
    }
}
