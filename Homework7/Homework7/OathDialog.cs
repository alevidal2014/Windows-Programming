using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlLibrary;
using System.Drawing.Drawing2D;

namespace Homework7
{
    public partial class OathDialog : BaseDialog
    {

        public OathDialog()
        {
            InitializeComponent();
        }

        private void OathDialog_Load(object sender, EventArgs e)
        {
            // Call Paint event
            this.Invalidate(false);
        }

        private void OathDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.IsOathDialogOpen = false;
        }

        // Fills the oath dialog with a path gradient brush
        private void DialogPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using (GraphicsPath rectangle = new GraphicsPath())
            {
                rectangle.AddRectangle(new Rectangle(0, 0, this.Size.Width/4, this.Size.Height/4));
                using (PathGradientBrush brush = new PathGradientBrush(rectangle))
                {
                    brush.WrapMode = WrapMode.Tile;
                    brush.CenterPoint = new Point(0, this.Size.Height/2);
                    brush.SurroundColors = new Color[] { Color.Black };
                    g.FillRectangle(brush, 0, 0, this.Size.Width, this.Size.Height);
                }
            }
        }
    }
}
