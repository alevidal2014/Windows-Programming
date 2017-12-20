using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
    public partial class MainForm : Form
    {
        private NotifyIcon minimizedIcon;

        public MainForm()
        {
            InitializeComponent();

            // Add Notification Icon for when form is minimized
            this.minimizedIcon = new NotifyIcon();

            // Initialize the minimized icon proerties
            minimizedIcon.Icon = Properties.Resources.notification_icon;
            minimizedIcon.Text = "Click me to go to " + this.Text;
            minimizedIcon.Visible = false;

            // Handle the Click event that activates the form
            minimizedIcon.Click += new System.EventHandler(this.minimizedIcon_Click);

        }

        // Executes as the MainForm loads
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set the Title, Size, and Desktop Location of the MainForm using User Settings
            this.Text = Properties.Settings.Default.MainFormTitle;
            this.Size = Properties.Settings.Default.MainFormSize;
            this.Location = Properties.Settings.Default.MainFormLocation;
        }

       

        // Activates the form if minimized icon is clicked
        private void minimizedIcon_Click(object sender, EventArgs e)
        {
            // Hide the Icon & activate the form
            this.minimizedIcon.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.TopMost = true;
        }

        // Make visible the minimized icon when the form is minimized
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            this.minimizedIcon.Visible = true; 

            // make sure that if the window was maximized from the taskbar
            // to hide the notification icon as well
            else
            {
                if (this.minimizedIcon.Visible == true)
                    this.minimizedIcon.Visible = false;
            }
        }

        // Name button Click handler which runs validation 
        private void Name_Click(object sender, EventArgs e)
        {
            bool isValid = this.Validate();
            if (isValid)
            {
                this.listView.Items.Add(this.inputBox.Text);
                this.inputBox.Text = "";
                this.inputBox.Focus();
            }
        }

        // Save the size of the window in the user settings
        private void Save_Size_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MainFormSize = this.Size;
            Properties.Settings.Default.Save();
        }

        // Save the location of the window in the user settings
        private void Save_Location_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MainFormLocation = this.Location;
            Properties.Settings.Default.Save();
        }

        // Restore default user setting values
        private void Reset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();

            // after the reset settings is used reset all settings to default
            // and apply them to the window
            this.Size = Properties.Settings.Default.MainFormSize;
            this.Location = Properties.Settings.Default.MainFormLocation;
        }

       
        //Error Validation for the Name Button 
        private void Name_Validating(object sender, CancelEventArgs e)
        {
            string input = this.inputBox.Text;
            string err = "";
            if (input.Trim().Length == 0)
            {
                err = "Incorrect input (Input must contain at least 1 non-space character)";
                e.Cancel = true;
            }
            if (input == string.Empty)
            {
                err = "Incorrect input (Not empty string)";
                e.Cancel = true;
            }
            if (input.Length > 15)
            {
                err = "Incorrect input (Input lenght has to be less than 15 characteres)";
                e.Cancel = true;
            }
            

            this.errorProvider1.SetError(inputBox, err);
        }

        // Show a message box before closing if the list is not empty
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.listView.Items.Count > 0)
            {
                var textToShow = "The last ListView item value was:   " + this.listView.Items[0].Text
                    + "\n Click CANCEL to prevent the application from closing";

                if (MessageBox.Show(textToShow, "Application closing ...", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    this.Show();
                }
            }
           
        }

        // Hide the form whe it loses the focus
        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            
            this.minimizedIcon.Visible = true;
            this.Visible = false;
        }

        
    }
}
