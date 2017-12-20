using Homework3.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3
{
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

            // Use this to reset user settings to re-test Login Dialog -- comment out in production
            Properties.Settings.Default.Reset();

            // Open the Login Dialog before running Main Form (if setting is default)
            if (Properties.Settings.Default.LoginShowSetting)
            {
                // Create and show the login dialog, prompting user to proceed or not to Main Form
                LoginDialog lDlg = new LoginDialog();
                if (lDlg.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainForm());
                }
            }
            else
                Application.Run(new MainForm());
        }
    }
}
