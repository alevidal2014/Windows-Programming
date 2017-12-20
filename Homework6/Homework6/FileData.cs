using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Homework6
{
    [Serializable]
    class FileData
    {
        public string FileText { get; set; }
        public string SavedName { get; set; }
        public Color TextColor { get; set; }
        public Font TextFont { get; set; }
        public bool TextModified { get; set; }
        public bool IsSaved { get; set; }

        // Constructor: Pass default Font and Color
        public FileData(Color color, Font font)
        {
            this.FileText = "";
            this.SavedName = "";
            this.TextColor = color;
            this.TextFont = font;
            this.TextModified = false;
            this.IsSaved = false;
        }
    }
}
