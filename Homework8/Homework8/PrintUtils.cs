using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Utilities
{
    class PrintUtils
    {
        public static Rectangle GetRealMarginBounds(PrintPageEventArgs e, bool preview)
        {
            if (preview) return e.MarginBounds;

            Rectangle marginBounds = e.MarginBounds;

            marginBounds.Offset((int)(-e.PageSettings.HardMarginX),(int)(-e.PageSettings.HardMarginY));

            return marginBounds;
        }

        public static Rectangle GetRealPageBounds(PrintPageEventArgs e, bool preview)
        {
            if (preview) return e.PageBounds;

            RectangleF vpb = e.Graphics.VisibleClipBounds;
            PointF[] bottomRight = { new PointF(vpb.Size.Width, vpb.Size.Height)};
            e.Graphics.TransformPoints(CoordinateSpace.Device, CoordinateSpace.Page, bottomRight);

            return new Rectangle(0, 0, (int)(bottomRight[0].X * 100 / e.Graphics.DpiX),
                                       (int)(bottomRight[0].Y * 100 / e.Graphics.DpiY));

        }

    }
}