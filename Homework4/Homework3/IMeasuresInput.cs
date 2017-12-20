using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public interface IMeasuresInput
    {
        int EllipseWidth { get; set; }
        int RectangleHeight { get; set; }
        float Ratio { get; set; }
        float RecRatio { get; set; }
        int EllipseWidthUnapplied { get; set; }
        int RectangleHeightUnapplied { get; set; }
        float RatioUnapplied { get; set; }
        float RecRatioUnapplied { get; set; }
        event EventHandler Apply;

    }
}
