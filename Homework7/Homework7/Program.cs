using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    // Enumaration for Shapes
    public enum Shapes
    {
        Ellipse,
        Rectangle,
        Custom
    }

    // Enumaration for Pens
    public enum Pens
    {
        Solid,
        Dashed,
        Compound
    }

    // Enumaration for Brushes
    public enum Brushes
    {
        Solid,
        Hatched,
        LinearGradient
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
