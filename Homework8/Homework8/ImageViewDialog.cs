using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Homework8
{
    public partial class ImageViewDialog : Form
    {

        CustomImage MyImage { get; set; }

        String FileName { get; set; }
        String ExtName { get; set; }

        public static bool IsImageSaved { get; set; }
        public static bool PathToSave { get; set; }

        public ImageViewDialog()
        {
            InitializeComponent();
            this.MyImage = new CustomImage(this.pictureBox.Width, this.pictureBox.Height, "Untitled");

            IsImageSaved = true;
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
                //dlg.Filter = "G1 files (*.g1)|*" + this.ExtName + "|All files (*.*)|*.*";


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
                        this.Text = String.Format("{0} ({1})", this.Text.Substring(0, 13), this.FileName.Substring(this.FileName.LastIndexOf('\\') + 1));
                    }
                   
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
                    this.Text = String.Format("{0} ({1})", this.Text.Substring(0, 13), this.FileName.Substring(this.FileName.LastIndexOf('\\') + 1));
                }
            }
        }

        private void showPaletteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var colors = MyImage.myPicture.Palette.Entries;
            int cntColors = colors.Count();
            int half = cntColors / 2;
            
            Bitmap platte = new Bitmap(half * 50, half * 50);
            Graphics dc = Graphics.FromImage(platte);

            int currX = 0,
                currY = 0;

            for (int i = 0; i < cntColors; i++)
            {
                SolidBrush brush = new SolidBrush(Color.FromArgb(colors[i].A, colors[i].R, colors[i].G, colors[i].B));

                dc.FillRectangle(brush, currX, currY, 50, 50);

                if (currX == platte.Width)
                {
                    currX = 0;
                    currY += 50;
                }
                else
                {
                    currX += 50;
                }
            }

            pictureBox.Image = platte;
        }
    }
}
