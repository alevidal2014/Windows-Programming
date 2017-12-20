using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework8
{
    public partial class SearchDialog : Form
    {
        BindingList<string> fileInfoBindingList;
        string fileExtensionSelected;
        bool isPaused = false;
        private ToolTip toolTips;
        public static event EventHandler<BaseMessageEventArgs> OnFileSelected;

        public SearchDialog()
        {
            InitializeComponent();
            fileInfoBindingList = new BindingList<string>();
        }

        private void SearchDialog_Load(object sender, EventArgs e)
        {
            extensionDropDownBox.Items.AddRange(new[] { ".g1",".txt", ".html", ".htm" });
            extensionDropDownBox.SelectedItem = extensionDropDownBox.Items[0];
            fileExtensionSelected = extensionDropDownBox.SelectedItem.ToString();
            searchResultBox.DataSource = fileInfoBindingList;
            pauseButton.Enabled = false;
            stopButton.Enabled = false;

            // Create tooltips and set the captions for each control
            toolTips = new ToolTip();
            toolTips.IsBalloon = true;
            toolTips.ToolTipTitle = "Tool Tip";
            toolTips.ToolTipIcon = ToolTipIcon.Info;

            toolTips.SetToolTip(this.searchResultBox, "View the search results from running a search");
            toolTips.SetToolTip(this.startButton, "Click this to begin searching");
            toolTips.SetToolTip(this.pauseButton, "Click this to halt the search");
            toolTips.SetToolTip(this.stopButton, "Click this to end the search");
            toolTips.SetToolTip(this.extensionDropDownBox, "Click this to select a specific file extension to search");
            toolTips.SetToolTip(this.statusStrip, "Displays status of search");
        }

        #region Search methods
        private void Search(string fileExtension)
        {
            
            foreach (String drive in Directory.GetLogicalDrives())
            {
                Debug.WriteLine(drive);
                foreach (DirectoryInfo child in getDirectories(drive))
                {
                    Debug.WriteLine(child.FullName);
                    FindFiles(child, fileExtension);
                }
            }
        }

        private  void FindFiles(DirectoryInfo dir, string fileExtension)
        {
            if (this.backgroundWorker.CancellationPending) { return; }
             
             
            try
            {
                DirectoryInfo[] children = getDirectories(dir);
                if (children.Length > 0)
                {
                    foreach (DirectoryInfo child in children)
                    {
                        Debug.WriteLine(child.FullName);
                        FindFiles(child, fileExtension);
                    }
                }
                else
                {
                    FileInfo[] Files = dir.GetFiles("*" + this.fileExtensionSelected);
                    if (Files.Length > 0)
                    {
                        while (isPaused)
                        {
                            System.Threading.Thread.Sleep(300);
                        }

                        foreach (FileInfo file in Files)
                        {
                            System.Threading.Thread.Sleep(100);
                            this.backgroundWorker.ReportProgress(0, file.FullName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }


        private  bool AttrOn(FileAttributes attr, FileAttributes field)
        {
            return (attr & field) == field;
        }

        public  DirectoryInfo[] getDirectories(DirectoryInfo dir)
        {
            if (AttrOn(dir.Attributes, FileAttributes.Offline))
            {
                Console.Out.WriteLine(dir.Name + " is not mapped ");
                return new DirectoryInfo[] { };
            }
            if (!dir.Exists)
            {
                Console.Out.WriteLine(dir.Name + " does not exist ");
                return new DirectoryInfo[] { };
            }
            try
            {
                return dir.GetDirectories();
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
                Console.Out.WriteLine(ex.StackTrace);
                return new DirectoryInfo[] { };
            }
        }

        public  DirectoryInfo[] getDirectories(String strDrive)
        {
            DirectoryInfo dir = new DirectoryInfo(strDrive);
            return getDirectories(dir);
        }
        #endregion

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            pauseButton.Enabled = true;
            stopButton.Enabled = true;
            this.backgroundWorker.RunWorkerAsync();
            if(backgroundWorker.IsBusy)
            {
                actionLabel.Text = "Searching ...";
            }
        }

        void ShowProgress(string fileFullPath)
        {
            // Make sure we're on the UI thread
            Debug.Assert(this.InvokeRequired == false);

            // Display progress in UI
            fileInfoBindingList.Add(fileFullPath);
        }

       

        void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Show progress
            string progress = (string)e.UserState;
            ShowProgress(progress);
        }

        void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Reset progress UI
            startButton.Enabled = true;
            pauseButton.Enabled = false;
            stopButton.Enabled = false;

            // Was the worker thread cancelled?
            if (e.Cancelled)
            {
                actionLabel.Text = "Search Cancelled";
                MessageBox.Show("The search was cancelled");
            }
            else
            {
                // Show elapsed time
                TimeSpan elapsed = (TimeSpan)e.Result;
                MessageBox.Show("Elapsed: " + elapsed.ToString());
            }
            if (m_bClosing)
            {
                MessageBox.Show("Closing after thread was cancelled");
                this.Close();
                m_bClosing = false;
            }

            MessageBox.Show(fileInfoBindingList.Count + " files founded");

        }

        bool m_bClosing = false;
        private void AsyncCalcPiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
                m_bClosing = true;
                e.Cancel = true;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to cancel the seach ?","Search Cancel",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                backgroundWorker.CancelAsync();

            }

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            DateTime start = DateTime.Now;

          
            Search(fileExtensionSelected);

            if (this.backgroundWorker != null && this.backgroundWorker.CancellationPending)
            {
                e.Cancel = true;
            }

            // Return elapsed time
            DateTime end = DateTime.Now;
            TimeSpan elapsed = end - start;
            e.Result = elapsed;
        }

        private void extensionDropDownBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileExtensionSelected = extensionDropDownBox.SelectedItem.ToString();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {

            if (pauseButton.Text == "Pause")
            {
                pauseButton.Text = "Continue";
                isPaused = true;
                actionLabel.Text = "Search Paused";
            }
            else
            {
                pauseButton.Text = "Pause";
                isPaused = false;
                actionLabel.Text = "Searching ...";
            }
            if (this.backgroundWorker.IsBusy)
            {
                
            }
        }

      

        private void searchResultBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchResultBox_DoubleClick(object sender, EventArgs e)
        {
            string selectedItem = searchResultBox.SelectedItem.ToString();
            string fileContent = string.Empty;

            if (!string.IsNullOrEmpty(selectedItem))
            {
                using (Stream stream = new FileStream(selectedItem, FileMode.Open, FileAccess.Read))
                {
                    if ((selectedItem).Contains(".g1"))
                    {

                        IFormatter formatter = new BinaryFormatter();
                        OnFileSelected?.Invoke(this, new CustomMessageEventArgs { Document = (Document)formatter.Deserialize(stream) });

                    }
                    else
                    {
                        fileContent = File.ReadAllText(selectedItem);
                        

                        OnFileSelected?.Invoke(this, new MessageEventArgs { Text = fileContent });
                    }

                    //newForm.searchDiag = this;
                }
            }
        }

        private void SearchDialog_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            // Convert screen coordinates to client coordinates
            Point pt = this.PointToClient(hlpevent.MousePos);

            // Look for control user clicked on
            Control control = FindChildAtPoint(this, pt);
            if (control == null)
                return;

            // Show help
            string help = this.toolTips.GetToolTip(control);
            if (string.IsNullOrEmpty(help))
                return;
            MessageBox.Show(help, "Help");
            hlpevent.Handled = true;
        }

        // Finds the control at the given point
        Control FindChildAtPoint(Control parent, Point pt)
        {
            // Find a child
            Control child = parent.GetChildAtPoint(pt);
            // If no child, this is the control at the mouse cursor
            if (child == null) return parent;
            // If a child, offset our current position to be relative to the child
            Point childPoint = new Point(pt.X - child.Location.X, pt.Y - child.Location.Y);
            // Find child of child control at offset position
            return FindChildAtPoint(child, childPoint);
        }
    }
}
