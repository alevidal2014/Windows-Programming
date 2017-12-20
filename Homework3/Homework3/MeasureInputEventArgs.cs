using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class MeasureInputEventArgs : EventArgs
    {

        public MeasureInputEventArgs(int width, int height, float ratio)
        {
            EllipseWidth = width;
            RectangleHeight = height;
            Ratio = ratio;
        }

        int EllipseWidth { get; set; }
        int RectangleHeight { get; set; }
        float Ratio { get; set; }
    }
}
