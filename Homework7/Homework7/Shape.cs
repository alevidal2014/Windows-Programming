using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    [Serializable]
    public class Shape
    {
        public Shapes ShapeType { get; set; }
        public Point Location { get; set; }
        public Color PenColor { get; set; }
        public Pens PenType { get; set; }
        public Color BrushColorA { get; set; }
        public Color BrushColorB { get; set; }
        public Brushes BrushType { get; set; }
        public Size SSize { get; set; }
        public Rectangle DrawingRect { get; set; }
        public PointF[] CustomDrawingPoly { get; set; }
        public string Name { get; set; }


        // Constructors
        public Shape(Shapes sType)
        {
            // Default
            ShapeType = sType;
            Location = new Point(10, 10);
            PenColor = Color.Black;
            PenType = Pens.Solid;
            BrushColorA = Color.Red;
            BrushColorB = Color.Blue;
            BrushType = Brushes.Solid;
            SSize = new Size(0, 0);
            DrawingRect = new Rectangle();
            CustomDrawingPoly = new PointF[5];
        }

        public Shape(Shapes stype, Point spoint, Color pcolor, Pens ptype, Color bcolorA, Color bcolorB, Brushes btype, Size s, Rectangle r, PointF [] customP, string name)
        {
            // Custom Shape
            ShapeType = stype;
            Location = spoint;
            PenColor = pcolor;
            PenType = ptype;
            BrushColorA = bcolorA;
            BrushColorB = bcolorB;
            BrushType = btype;
            SSize = s;
            DrawingRect = r;
            CustomDrawingPoly = customP;
            Name = name;
        }
    }
}
