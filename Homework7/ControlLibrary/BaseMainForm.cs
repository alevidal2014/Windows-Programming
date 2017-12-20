using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class BaseMainForm : Form
    {
        public BaseMainForm()
        {
            InitializeComponent();
        }

        // Both Oath and About menu item click events must be implemented in inherited classes
        public virtual void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotSupportedException("Error: Oath menu item click event is not supported in BaseMainForm");
        }

        public virtual void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotSupportedException("Error: About menu item click event is not supported in BaseMainForm");
        }
    }
}
