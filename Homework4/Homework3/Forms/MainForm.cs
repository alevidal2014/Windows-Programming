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
using Homework3.Forms;

namespace Homework3
{
    // Inherit from the BaseForm in Control Library
    public partial class MainForm : Form
    {
        
        private EllipticChild ellipticChild;
        private RectangularChild rectangularChild;
        private CustomChild customChild;
        
        private float eRatio = 1;
        private float rRatio = 1;
        private int eWidth = 150;
        private int rHeight = 150;
        private bool isPrefOpen = false;
        private bool isAboutOpen = false;

        public event EventHandler ActivateParent;
        public event EventHandler DeactivateParent;

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
            ellipticChild.MdiParent = this;
            InitEllipseChild(ellipticChild);
            ellipticChild.Show();
        }

        //Create and Displays a Rectangular child dialog
        private void rectangularChildToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rectangularChild = new RectangularChild(RHeight, RRatio);
            rectangularChild.MdiParent = this;
            InitRectChild(rectangularChild);
            rectangularChild.Show();
        }

        //Close the form from the main menu
        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Fire off Activated and Deactivated events that the preferences dialog will respond to
        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (ActivateParent != null)
                ActivateParent(this, EventArgs.Empty);
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            if (DeactivateParent != null)
                DeactivateParent(this, EventArgs.Empty);
        }

        //Opens the oathDialog (modally) right next to the mainForm
        private void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.OathDialog oathDlg = new Forms.OathDialog();
            oathDlg.Owner = this;
            oathDlg.StartPosition = FormStartPosition.Manual;
            oathDlg.Location = new Point(this.Location.X + this.Width-15, this.Location.Y);
            oathDlg.ShowDialog();            
        }

        private void customChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customChild = new CustomChild(EWidth + (int)(RHeight * RRatio), ERatio);
            customChild.MdiParent = this;
            InitCustomChild(customChild);
            customChild.Show();
        }

        //Function to handle the focus event in the ellipse dialog
        private void EllipseChild_Focus(object sender, EventArgs e)
        {
            var dlg = sender as EllipticChild;

            this.StatusLabel.Text = "Ellipse";
            this.statusBar.BackColor = dlg.BackColor;

        }


        //Function to handle the focus event in the Rectangle dialog
        private void RectangleChild_Focus(object sender, EventArgs e)
        {
            var dlg = sender as RectangularChild;

            this.StatusLabel.Text = "Rectangle";
            this.statusBar.BackColor = dlg.BackColor;

        }

        //Function to handle the focus event in the Custom dialog
        private void CustomChild_Focus(object sender, EventArgs e)
        {
            var dlg = sender as CustomChild;

            this.StatusLabel.Text = "Custom";
            this.statusBar.BackColor = dlg.BackColor;

        }

        //Function to handle the out of focus event in the child dialogs
        private void Child_OutFocus(object sender, EventArgs e)
        {
            this.StatusLabel.Text = "Status";
            this.statusBar.BackColor = this.BackColor;

        }

        //Function that initializes the event handle of the ellipse child
        private void InitEllipseChild(ICustomForm dlg)
        {
            dlg.FocusIN += EllipseChild_Focus;
            dlg.FocusOUT += Child_OutFocus;
        }

        //Function that initializes the event handle of the rectangle child
        private void InitRectChild(ICustomForm dlg)
        {
            dlg.FocusIN += RectangleChild_Focus;
            dlg.FocusOUT += Child_OutFocus;
        }

        //Function that initializes the event handle of the custom child
        private void InitCustomChild(ICustomForm dlg)
        {
            dlg.FocusIN += CustomChild_Focus;
            dlg.FocusOUT += Child_OutFocus;
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            this.toolStripMenuItem.Visible = false;
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                this.toolStripMenuItem.Visible = true;
            else
                this.toolStripMenuItem.Visible = false;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.isAboutOpen)
            {
                Forms.AboutDialog abtthDlg = new Forms.AboutDialog();
                abtthDlg.Owner = this;
                abtthDlg.StartPosition = FormStartPosition.Manual;
                abtthDlg.Location = new Point(this.Location.X, this.Location.Y + this.Height-8);
                this.isAboutOpen = true;
                abtthDlg.IsClosed += AboutDialog_closed;
                abtthDlg.Show();
            }
        }

        //Function to handle the apply button of the preference dialog
        private void AboutDialog_closed(object sender, EventArgs e)
        {
            var dlg = sender as AboutDialog;

            if (dlg != null)
            {
                this.isAboutOpen = dlg.isOpen;
            }
        }

        
    }
}
