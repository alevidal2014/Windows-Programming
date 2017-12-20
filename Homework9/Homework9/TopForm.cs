using ControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using Homework9.Properties;

namespace Homework9
{
    public partial class TopForm : BaseMainForm
    {
        public static bool IsAboutDialogOpen { get; set; } // Only allow one About dialog to be open at a time
        public static bool IsOathDialogOpen { get; set; } // Only allow one Oath dialog to be open at a time

        String FileName { get; set; }
        String ExtName { get; set; }           

        public static bool IsImageSaved { get; set; }
        public static bool PathToSave { get; set; }

        CustomImage MyImage { get; set; }
        SearchDialog searchDialog;
        Binding imageBinding;

        // Keeps track of number of top forms open
        static int formCount = 0;
        //Font used to print
        Font m_fontPrinter = null;
        bool preview = false;

        bool isImage = false;

        NotifyIcon Mynotify;
        
        public TopForm()
        {
            InitializeComponent();
            formCount++;
            SearchDialog.OnImageSelected += SearchDialog_OnImageSelected;
            this.Text = String.Format("{0}:{1}", this.Text, formCount);
            MultiSDIApp.Application.AddTopLevelForm(this);
            MultiSDIApp.Application.AddWindowMenu(windowToolStripMenuItem);
            this.MyImage = new CustomImage(this.pictureBox.Width, this.pictureBox.Height, "Untitled");
            pictureBox.DataBindings.Add("Image", MyImage, "MyPicture", true);

        }


        private void SearchDialog_OnImageSelected(object sender, MessageEventArgs e)
        {
            MyImage.MyPicture = (Bitmap)Image.FromFile(e.ImagePath);
            if(MyImage.myPicture.Height > pictureBox.Height || MyImage.myPicture.Width > pictureBox.Width)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else
            {
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Merge the menu toolstrip from BaseMainForm to the mainMenuStrip
            ToolStripManager.Merge(base.baseMenuStrip, mainMenuStrip);
            //Setting the dialogs control variables to false
            IsAboutDialogOpen = false;
            IsOathDialogOpen = false;

            PathToSave = false;
            IsImageSaved = true;
            ExtName = ".g1";
            this.FilenametoolStripStatusLabel.Text = "Untitled";
            ((Control)this.pictureBox).AllowDrop = true;

        }

        // Creates a new Top Form modelessly, opening a file if passed one
        public static TopForm CreateTopLevelWindow(String fileName)
        {
            if (!String.IsNullOrEmpty(fileName))
            {
                foreach (TopForm form in Application.OpenForms)
                {
                    if (String.Compare(form.FileName, fileName, true) == 0)
                    {
                        form.Activate();
                        return form;
                    }
                }
            }

            TopForm newForm = new TopForm();
            newForm.OpenFile(fileName);
            newForm.Show();
            newForm.Activate();
            return newForm;
        }

        // Opens file (if it exists), reads its contents and place then into the file text box
        private void OpenFile(String fileName)
        {
            this.FileName = fileName;
            
            if (File.Exists(fileName))
            {
                // TODO: Read the file contents
            }
            else // Could not find file, open form as Untitled
            {
                this.FileName = String.Format("Untitled {0}", formCount);
            }
            this.Text = String.Format("{0} ({1})", this.Text, this.FileName);
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopForm.CreateTopLevelWindow(null);
        }

        // Override Oath and About menu item click event

        public override void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsOathDialogOpen)
            {
                IsOathDialogOpen = true;
                OathDialog oathDlg = new OathDialog();
                oathDlg.Owner = this;
                oathDlg.StartPosition = FormStartPosition.Manual;
                oathDlg.Location = new Point(this.Location.X + this.Width + 8, this.Location.Y);
                oathDlg.Show();
            }
        }

        public override void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsAboutDialogOpen)
            {
                IsAboutDialogOpen = true;
                AboutDialog abtthDlg = new AboutDialog();
                abtthDlg.Owner = this;
                abtthDlg.StartPosition = FormStartPosition.Manual;
                abtthDlg.Location = new Point(this.Location.X, this.Location.Y + this.Height + 8);
                abtthDlg.Show();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsImageSaved)
            {
                DialogResult d = MessageBox.Show("Do you want to save the file?", "Unsaved Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    this.saveToolStripMenuItem_Click(sender, e);
                }
            }

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                //Setting the default extension for the file 
                dlg.AddExtension = true;
                dlg.DefaultExt = this.ExtName;
                dlg.Filter = "G1 files (*.g1)|*" + this.ExtName + "|All files (*.*)|*.*";
                

                if (dlg.ShowDialog() != DialogResult.OK) return;
                {
                    String fileExt = dlg.FileName.Substring(dlg.FileName.IndexOf("."));
                    
                    if (fileExt == this.ExtName) //We are opening a custom g1 file that needs to be deserialized first
                    {
                         using (Stream stream = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                        {
                            IFormatter formatter = new BinaryFormatter();
                            this.MyImage = (CustomImage)formatter.Deserialize(stream);
                            //Update the Picture Box
                            pictureBox.Image = this.MyImage.myPicture;
                            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

                            //Avoid asking to save if we just open the file
                            IsImageSaved = true;
                            this.FileName = dlg.FileName;
                            this.FilenametoolStripStatusLabel.Text = this.FileName;
                            //Update the Form Title 
                            this.Text = String.Format("{0} ({1})", this.Text.Substring(0, 13), this.FileName.Substring(this.FileName.LastIndexOf('\\') + 1));
                            PathToSave = true;
                        }
                    }
                    else
                    {
                        IsImageSaved = false;
                        this.MyImage.myPicture = new Bitmap(dlg.FileName);
                        pictureBox.Image = this.MyImage.myPicture;                        
                        pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        this.FileName = dlg.FileName;
                        this.FilenametoolStripStatusLabel.Text = this.FileName;
                        this.Text = String.Format("{0} ({1})", this.Text.Substring(0, 13), this.FileName.Substring(this.FileName.LastIndexOf('\\') + 1));
                    }

                    this.imageToolStripMenuItem.Enabled = true;
                    this.isImage = true;
                    this.copyToolStripMenuItem.Enabled = true;
                }               
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PathToSave)  //If the data was alredy saved use the same location
            {
                using (Stream stream = new FileStream(this.FileName, FileMode.Create, FileAccess.Write))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this.MyImage);
                    IsImageSaved = true;
                    this.savetoolStripStatusLabel.Text = "Document Saved";
                }
            }
            else  // If not display a dialog to use a new location
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                //Setting the default extension for the file 
                dlg.AddExtension = true;
                dlg.DefaultExt = this.ExtName;
                dlg.Filter = "G1 files (*.g1)|*" + this.ExtName + "|All files (*.*)|*.*";

                if (dlg.ShowDialog() != DialogResult.OK) return;
                using (Stream stream = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
                {
                    this.MyImage.SavedName = dlg.FileName;
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this.MyImage);                   
                    IsImageSaved = true;                    
                    //Update the Form Title 
                    this.FileName = dlg.FileName;
                    this.FilenametoolStripStatusLabel.Text = this.FileName;
                    this.savetoolStripStatusLabel.Text = "Document Saved";
                    this.Text = String.Format("{0} ({1})", this.Text.Substring(0, 13), this.FileName.Substring(this.FileName.LastIndexOf('\\') + 1));
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Image menu tranformations event handlers
        private void clockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MyImage.myPicture.RotateFlip(RotateFlipType.Rotate90FlipNone);
            this.pictureBox.Image = this.MyImage.myPicture;
            IsImageSaved = false;
        }

        private void couterclockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MyImage.myPicture.RotateFlip(RotateFlipType.Rotate270FlipNone);
            this.pictureBox.Image = this.MyImage.myPicture;
            IsImageSaved = false;            
        }

        private void flipXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MyImage.myPicture.RotateFlip(RotateFlipType.RotateNoneFlipX);
            this.pictureBox.Image = this.MyImage.myPicture;
            IsImageSaved = false;
        }

        private void flipYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MyImage.myPicture.RotateFlip(RotateFlipType.RotateNoneFlipY);
            this.pictureBox.Image = this.MyImage.myPicture;
            IsImageSaved = false;
        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a blank bitmap the same size as original
            Bitmap grayBitmap = new Bitmap(this.MyImage.myPicture.Width, this.MyImage.myPicture.Height);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(grayBitmap);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
                    new float[] {.3f, .3f, .3f, 0, 0},
                    new float[] {.59f, .59f, .59f, 0, 0},
                    new float[] {.11f, .11f, .11f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
               });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(this.MyImage.myPicture, new Rectangle(0, 0, this.MyImage.myPicture.Width, this.MyImage.myPicture.Height),
               0, 0, this.MyImage.myPicture.Width, this.MyImage.myPicture.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();

            this.MyImage.myPicture = grayBitmap;
            this.pictureBox.Image = this.MyImage.myPicture;
            IsImageSaved = false;
        }

        //Open a print previw dialog
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();  
            
        }

        // Print page event
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            
            Rectangle realPageBounds = GetRealPageBounds(e, preview);
            RectangleF visibleClipBounds = e.Graphics.VisibleClipBounds;            

            g.DrawRectangle(Pens.Black, realPageBounds);
            g.DrawImage(this.MyImage.myPicture, 0, 0, realPageBounds.Width, realPageBounds.Height);
            g.DrawString("Team 1", m_fontPrinter, Brushes.Black, realPageBounds);
            using (StringFormat format = new StringFormat())
            {
                format.Alignment = StringAlignment.Far;
                format.LineAlignment = StringAlignment.Far;
                g.DrawString(this.FileName, m_fontPrinter, Brushes.Black, realPageBounds, format);
            }
          }

        private void printDocument_BeginPrint(object sender, PrintEventArgs e)
        {
            preview = (e.PrintAction == PrintAction.PrintToPreview);
            m_fontPrinter = new Font("Lucida Console", 24);
        }

        private void printDocument_EndPrint(object sender, PrintEventArgs e)
        {
            m_fontPrinter.Dispose();
            m_fontPrinter = null;
        }

        static Rectangle GetRealPageBounds(PrintPageEventArgs e, bool preview)
        {
            // Return in units of 1/100 inch
            if (preview) return e.PageBounds;
            // Translate to units of 1/100 inch
            RectangleF vpb = e.Graphics.VisibleClipBounds;
            PointF[] bottomRight = { new PointF(vpb.Size.Width, vpb.Size.Height) };
            e.Graphics.TransformPoints(
            CoordinateSpace.Device, CoordinateSpace.Page, bottomRight);
            float dpiX = e.Graphics.DpiX;
            float dpiY = e.Graphics.DpiY;
            return new Rectangle(0, 0, (int)(bottomRight[0].X * 100 / dpiX),
            (int)(bottomRight[0].Y * 100 / dpiY));
            
        }


        //Here begings the methods related with the drag and drop events
        private void pictureBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                Bitmap temp = new Bitmap((Bitmap)e.Data.GetData(DataFormats.Bitmap), this.pictureBox.Size);
                this.MyImage.myPicture = temp;
                this.pictureBox.Image = this.MyImage.myPicture;
                this.copyToolStripMenuItem.Enabled = true;

            }       
        }

        private void pictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }        
        }

        //Here begings the methods related with the copy and paste events
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            // Start the drag if it's the right mouse button.
            if (e.Button == MouseButtons.Left && this.isImage)
            {
                  pictureBox.DoDragDrop(this.MyImage.myPicture, DragDropEffects.Copy);              
               
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(this.MyImage.myPicture);
        }

        private void pasteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Clipboard.ContainsData(DataFormats.Bitmap))
            {
                this.MyImage.myPicture = (Bitmap)Clipboard.GetData(DataFormats.Bitmap);
                this.pictureBox.Image = this.MyImage.myPicture;
                this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.copyToolStripMenuItem.Enabled = true;
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(searchDialog == null || searchDialog.Text == string.Empty)
            {
                searchDialog = new SearchDialog();
                searchDialog.Owner = this;
                searchDialog.Show();
            }
        }


        //Notify icon Events
        private void TopForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {               
                this.Mynotify = new NotifyIcon();
                this.Mynotify.Text = "Back to Team 1 Image app";
                this.Mynotify.Visible = true;
                this.Mynotify.Icon = ((System.Drawing.Icon)(Properties.Resources.if_Info_Circle_Symbol_Information_Letter_1396823));
                this.Mynotify.Click += Restore_Form;               
                this.ShowInTaskbar = false;
                
            }
        }

        void Restore_Form(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Mynotify.Visible = false;
            this.Mynotify.Dispose();
            this.Show();
            this.Activate();

        }
    }
}
