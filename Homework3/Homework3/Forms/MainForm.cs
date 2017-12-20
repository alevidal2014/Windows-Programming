using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Include the created Control Library
using ControlLibrary;

namespace Homework3
{
    // Inherit from the BaseForm in Control Library
    public partial class MainForm : BaseForm
    {
        
        private EllipticChild ellipticChild;
        private RectangularChild rectangularChild;
        private float eRatio = 1;
        private float rRatio = 1;
        private int eWidth = 300;
        private int rHeight = 300;
        private bool isPrefOpen = false;

        public MainForm()
        {
            InitializeComponent();
        }


        //Main properties
        public float ERatio
        {
            get{ return this.eRatio;   }
            set { this.eRatio = value; }
        }

        public float RRatio
        {
            get { return this.rRatio; }
            set { this.rRatio = value; }
        }

        public int EWidth
        {
            get { return this.eWidth; }
            set { this.eWidth = value; }
        }

        public int RHeight
        {
            get { return this.rHeight; }
            set { this.rHeight = value; }
        }

        //Initializating the values of the preferences dialog from the main properties
        private void InitPreferencesDialog(IMeasuresInput dlg)
        {
            dlg.EllipseWidthUnapplied = EWidth;
            dlg.RectangleHeightUnapplied = RHeight;
            dlg.RatioUnapplied = ERatio;
            dlg.RecRatioUnapplied = RRatio;
            dlg.EllipseWidth = EWidth;
            dlg.RectangleHeight = RHeight;
            dlg.Ratio = ERatio;
            dlg.RecRatio = RRatio;
            dlg.Apply += PreferencesDialog_Apply;

        }

        //Function to handle the apply button of the preference dialog
        private void PreferencesDialog_Apply(object sender, EventArgs e)
        {
            var dlg = sender as Preferences;

            if (dlg != null)
            {
                this.EWidth = dlg.EllipseWidth;
                this.RHeight = dlg.RectangleHeight;
                this.ERatio = dlg.Ratio;
                this.RRatio = dlg.RecRatio;
                this.isPrefOpen = dlg.Active;
            }
        }


                
        //Main Form closing. Ask for user confirmation before closing the form
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to close the application?", "Closing Confirmation",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //Open the dialog modally and handles the ok result
        private void openPreferencesModalyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isPrefOpen)
            {
                using (Preferences pdlg = new Preferences())
                {
                    isPrefOpen = true;
                    pdlg.Owner = this;
                    InitPreferencesDialog(pdlg);
                    pdlg.ShowDialog();
                    if (DialogResult.OK == pdlg.DialogResult)
                    {
                        retrieveModalDialog(pdlg);
                        isPrefOpen = false;
                    }
                }
            }
        }

        //Retrive the data from the Dialog using the interface
        private void retrieveModalDialog(IMeasuresInput dlg)
        {
            this.EWidth = dlg.EllipseWidth;
            this.RHeight = dlg.RectangleHeight;
            this.ERatio = dlg.Ratio;
            this.RRatio = dlg.RecRatio;
        }

        
        //Open the dialog Modeless
        private void openPreferencesModelessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isPrefOpen)
            {
                Preferences pdlg = new Preferences();
                pdlg.Owner = this;
                isPrefOpen = true;
                InitPreferencesDialog(pdlg);
                pdlg.Show();
            }  
        }

        //Create and Displays an Elliptic child dialog
        private void ellipticChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ellipticChild = new EllipticChild(EWidth, ERatio);
            ellipticChild.Show();
        }

        //Create and Displays a Rectangular child dialog
        private void rectangularChildToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rectangularChild = new RectangularChild(RHeight, RRatio);
            rectangularChild.Show();
        }

        //Close the form from the main menu
        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
