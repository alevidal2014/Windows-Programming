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

namespace Homework9
{
    public partial class SearchDialog : Form
    {
        string fileExtensionSelected;
        ManualResetEvent _busy = new ManualResetEvent(false);
        bool isPaused = false;
        public static event EventHandler<MessageEventArgs> OnImageSelected;

        public SearchDialog()
        {
            InitializeComponent();
        }

        private void SearchDialog_Load(object sender, EventArgs e)
        {
            extensionDropDownBox.Items.AddRange(new[] { ".g1",".png", ".jpg", ".bmp" });
            extensionDropDownBox.SelectedItem = extensionDropDownBox.Items[0];
            fileExtensionSelected = extensionDropDownBox.SelectedItem.ToString();
            pauseButton.Enabled = false;
            stopButton.Enabled = false;
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
             
            // if(isPaused)
            //_busy.WaitOne();
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
                       while(isPaused)
                        {
                            System.Threading.Thread.Sleep(300);
                        }

                        foreach (var file in Files)
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
            imageList1.Images.Add(Image.FromFile(fileFullPath));
            ListViewItem item = new ListViewItem();
            item.ImageIndex = imageList1.Images.Count - 1;
            item.Name = fileFullPath;
            searchResultBox.Items.Add(item);
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

            MessageBox.Show(searchResultBox.Items.Count + " files founded");

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

            if(isPaused)
            _busy.WaitOne();

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

     

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }


        private void searchResultBox_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = searchResultBox.SelectedItems[0];

            if (OnImageSelected != null)
            {

                OnImageSelected(this, new MessageEventArgs {  ImagePath = item.Name});
            }
        }
    }
}
