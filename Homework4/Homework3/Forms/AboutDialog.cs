using ControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3.Forms
{
    public partial class AboutDialog : BaseDialog
    {
        public bool isOpen;
        public event EventHandler IsClosed;

        public AboutDialog()
        {
            InitializeComponent();
        }

        private void AboutOKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutDialog_Load(object sender, EventArgs e)
        {
            this.isOpen = true;
            IsClosed(this, EventArgs.Empty);
        }

        private void AboutDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.isOpen = false;
            IsClosed(this, EventArgs.Empty);
        }
    }
}