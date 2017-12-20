using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Homework9
{
    class MultiSDIApp: WindowsFormsApplicationBase
    {
        private static MultiSDIApp application;
        private NotifyIcon notify;
        

        // Make singleton pointer to application
        internal static MultiSDIApp Application
        {
            get
            {
                if (application == null)
                    application = new MultiSDIApp();
                return application;
            }
        }
        public MultiSDIApp()
        {
            // Only allow single instance of application, close the application after last form is closed
            this.IsSingleInstance = true; 
            this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
            this.notify = new NotifyIcon();
        }

        // Assign the main form as a newly created first Top Form
        protected override void OnCreateMainForm()
        {
            this.MainForm = this.CreateTopLevelWindow(this.CommandLineArgs);
        }

        // Calls the Top form Create Form method, passing the associated file if it exists
        private System.Windows.Forms.Form CreateTopLevelWindow(
            ReadOnlyCollection<string> args)
        {
            String fileName = null;
            if (args.Count > 0) fileName = args[0];
            return TopForm.CreateTopLevelWindow(fileName);
        }

        protected override void OnStartupNextInstance(
            StartupNextInstanceEventArgs eventArgs)
        {
            this.CreateTopLevelWindow(eventArgs.CommandLine);
        }

        // Register the event for a Top Form Closing
        public void AddTopLevelForm(Form form)
        {
            form.FormClosed += form_FormClosed;
            //form.Resize += form_Minimize;
                       
        }

        // Designate a new form to become a top form if the Main Form is closing and there are other forms open
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = sender as Form;
            if (form == this.MainForm &&
                this.OpenForms.Count > 0)
            {
                this.MainForm = (Form)this.OpenForms[0];
            }
            form.FormClosed -= form_FormClosed;
        }

        // Register Top form event when window menu is selected
        public void AddWindowMenu(ToolStripMenuItem windowMenu)
        {
            windowMenu.DropDownOpening += windowMenu_DropDownOpening;
        }
       
        // Populate the Window form with list of all open Top forms
        void windowMenu_DropDownOpening(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            menu.DropDownItems.Clear();
            foreach (Form form in this.OpenForms)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(form.Text);
                item.Tag = form;
                item.Click += item_Click;

                // Set the current Top form as checked
                item.Checked = form == Form.ActiveForm;
                menu.DropDownItems.Add(item);
                
            }
        }

        // Switch focus to the selected Top Form in the Windows Menu
        void item_Click(object sender, EventArgs e)
        {
            ((Form)((ToolStripMenuItem)sender).Tag).Activate();
        }


       /* void form_Minimize(object sender, EventArgs e)
        {
            Form form = sender as Form;

           if (form.WindowState == FormWindowState.Minimized)
           {
                
                this.notify.BalloonTipText = "Back to Team 1 Image app";
                this.notify.BalloonTipTitle = "Image app";
                this.notify.ShowBalloonTip(3000);
                this.notify.Click += Restore_Form;
                this.notify.Icon = ((System.Drawing.Icon)(Properties.Resources.if_Info_Circle_Symbol_Information_Letter_1396823));
                form.ShowInTaskbar = false;
                this.notify.Visible = true;
            }
            
        }*/

        /*void Restore_Form(object sender, EventArgs e)
        {
            Form form = sender as Form;
            /* foreach(Form f in OpenForms)
             {
                 f.ShowInTaskbar = true;
                 f.Show();
             }

            form.Show();
            
        }*/
    }
}
