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

namespace Homework3.Forms
{
    public partial class LoginDialog : Form
    {
        public LoginDialog()
        {
            InitializeComponent();
        }

        // Change user's settings for skipping login dialog
        private void SkipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SkipCheckBox.Checked == true)
            {
                Properties.Settings.Default.LoginShowSetting = false;
                Properties.Settings.Default.Save();
            }
            else if (SkipCheckBox.Checked == false)
            {
                Properties.Settings.Default.LoginShowSetting = true;
                Properties.Settings.Default.Save();
            }
        }
    }
}
