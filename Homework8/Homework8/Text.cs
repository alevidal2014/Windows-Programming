using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    [Serializable]
    public class Text
    {
        public String TextContent { get; set; }
        public Font TextFont { get; set; }
        public Color TextColor { get; set; }
        public float Rotation { get; set; }
        public Point Location { get; set; }
        public Size SSize { get; set; }
        public Rectangle DrawingRect { get; set; }
       

        // Constructor
        public Text()
        {
            TextContent = "Your Text";
            TextFont = new Font("Arial", 12);
            Location = new Point(100, 50);
            Rotation = 0f;
            TextColor = new Color();
            TextColor = Color.Black;
            SSize = new Size(120, 80);
            DrawingRect = new Rectangle(Location, SSize);
        }

        public Text(String tContent, Font tFont , Point tLoc, float tRot, Color tcolor, Size s, Rectangle r)
        {
            TextContent = tContent;
            TextFont = tFont;
            Location = tLoc;
            Rotation = tRot;
            TextColor = new Color();
            TextColor = tcolor;
            SSize = s;
            DrawingRect = r;
        }

        //[NonSerializedAttribute()]
        public bool Isin(Point p)
        {
            if (DrawingRect.Location.X < p.X && DrawingRect.Location.Y < p.Y && (DrawingRect.X+DrawingRect.Width)>p.X  && (DrawingRect.Y + DrawingRect.Height) > p.Y)
            {
                return true;
            }
            return false;
        }
    }
}
