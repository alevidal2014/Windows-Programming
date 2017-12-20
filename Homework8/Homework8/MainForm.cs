using ControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Utilities;

namespace Homework8
{
    public partial class MainForm : BaseMainForm
    {
        public static bool IsAboutDialogOpen { get; set; } // Only allow one About dialog to be open at a time
        public static bool IsOathDialogOpen { get; set; } // Only allow one Oath dialog to be open at a time
        public static bool IsOptionsDialogOpen { get; set; } // Only allow one Option dialog to be open at a time

        public bool SavedDoc { get; set; } // Variable used to save the file in the same location
        public bool WasSaved { get; set; }
        public bool startdrawing { get; set; } // Variable to control the drawing
        public bool startdrag { get; set; } // Variable to control the drawing
        public bool continueToMove { get; set; }
        public int index { get; set; }
        public bool isFileSelectedText;
        public String ExtName { get; set; } // Custom .ext of the saved file

        Size s;     //Size of the shape we are drawing 

        public Document MyTextsDoc; // List of texts
        public Text CurrentText; // Currently selected text
        public Text Newtext;          //The new text object to create
        public Text textToDraw;         //Use in the paint event
        public SearchDialog searchDiag;

        int locationY = 0;  //Use to control the drop and paste evenys

        //Here are the print document ariables
        bool preview = false;
        int margins = 100;
        Font header_font = null;
        Font footer_font = null;
        Font body_font = null;
        int objectIndex = 0;
        int m_nTotalPage = 1;
        int m_nMaxPage = 1;


        public MainForm()
        {
            InitializeComponent();
            SearchDialog.OnFileSelected += SearchDialog_OnFileSelected;
            isFileSelectedText = false;
           
        }

        private void SearchDialog_OnFileSelected(object sender, BaseMessageEventArgs e)
        {
            isFileSelectedText = true;
            switch(e.GetType().Name)
            {
                case "CustomMessageEventArgs" :
                    {
                        this.MyTextsDoc = (e as CustomMessageEventArgs).Document;
                        
                    }
                        break;

                case "MessageEventArgs":
                    {
                        string content = (e as MessageEventArgs).Text;
                        LoadFileContent(content);
                      
                    }
                    break;
            }

            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Merge the menu toolstrip from BaseMainForm to the mainMenuStrip
            ToolStripManager.Merge(base.baseMenuStrip, mainMenuStrip);

            //Setting the dialogs control variables to false
            IsAboutDialogOpen = false;
            IsOathDialogOpen = false;
            IsOptionsDialogOpen = false;

            // State of the document
            SavedDoc = false;
            WasSaved = false;

            //Starting of a drawing action
            startdrawing = false;
            startdrag = false;
            index = -1;

            

            // Custom Extension name
            this.ExtName = ".g1";

            this.MyTextsDoc = new Document();
            // Create text with default properties
            this.CurrentText = new Text();
            this.Newtext = new Text();
            this.textToDraw = new Text();

            //Initialize Status bar
            UpdateStatus();

            //Size of the shape we are drawing
            s = new Size(0, 0);

            rotlabel.BringToFront();
            rottextBox.BringToFront();
            textlabel.BringToFront();
            textContenttextBox.BringToFront();
            
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

        private void textOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsOptionsDialogOpen)
            {
                IsOptionsDialogOpen = true;
                TextOptionsDialog optDlg = new TextOptionsDialog();
                optDlg.Owner = this;
                optDlg.ChangesApplied += OptDlg_ChangesApplied;
                // Intialize dialog
                optDlg.Show();

            }
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsOptionsDialogOpen)
            {
                IsOptionsDialogOpen = true;
                ManageDialog mDlg = new ManageDialog();
                mDlg.Owner = this;
                mDlg.ChangesApplied += MDlg_ChangesApplied;
                // Intialize dialog
                mDlg.Show();

            }
        }

        private void OptDlg_ChangesApplied(object sender, EventArgs e)
        {
            this.Invalidate(true);
        }

        private void MDlg_ChangesApplied(object sender, EventArgs e)
        {
            this.Invalidate(true);
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            this.Invalidate(true);
        }


        //File Menu Buttons Handlers
        //New Button
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.SavedDoc)
            {
                DialogResult d = MessageBox.Show("Do you want to save the file?", "Unsaved Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    this.saveToolStripMenuItem_Click(sender, e);
                }
            }

            this.MyTextsDoc = new Document();
            this.Invalidate(true);
            this.WasSaved = false;
            this.textOptionsToolStripMenuItem.Enabled = false;
            this.manageToolStripMenuItem.Enabled = false;
        }

        //Open Button
        // Open a saved document file using Binary Format Serialization 
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.SavedDoc)
            {
                DialogResult d = MessageBox.Show("Do you want to save the file?", "Unsaved Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    this.saveToolStripMenuItem_Click(sender, e);
                }
            }

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                Stream myStream = null;
                //Setting the default extension for the file 
                dlg.AddExtension = true;
                dlg.DefaultExt = this.ExtName;
                dlg.Filter = "G1 files (*.g1)|*" + this.ExtName + "|All files (*.*)|*.*";

                if (dlg.ShowDialog() != DialogResult.OK) return;

                String fileExt = dlg.FileName.Substring(dlg.FileName.IndexOf("."));

                if (fileExt == this.ExtName) //We are opening a custom g1 file that needs to be deserialized first
                {
                    using (Stream stream = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        this.MyTextsDoc = (Document)formatter.Deserialize(stream);

                        if (this.MyTextsDoc.CountShape() > 0)
                        {
                            this.textOptionsToolStripMenuItem.Enabled = true;
                            this.manageToolStripMenuItem.Enabled = true;
                        }

                        this.Invalidate(true);

                        //Avoid asking to save if we just open the file
                        this.SavedDoc = true;
                        this.WasSaved = true;

                    }

                    //Helper to avoid overslapping the next time we paste text in this panel
                    setMaxlocationYValue();
                }
                else
                {
                    using (Stream stream = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                    {

                        using (StreamReader reader = new StreamReader(stream))
                        {
                                             
                            string  s = reader.ReadLine();
                            while(s!= null)
                            {
                                ProcessString(s);
                                s = reader.ReadLine();                                
                            }
                            
                        }
                        locationY += 14;
                        stream.Close();
                    }
                }
            }
        }

        //Save Button
        // Saved document file using Binary Format Serialization 
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WasSaved)  //If the data was alredy saved use the same location
            {
                using (Stream stream = new FileStream(this.MyTextsDoc.SavedName, FileMode.Create, FileAccess.Write))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this.MyTextsDoc);
                    this.SavedDoc = true;

                }
            }
            else  // If not display a dialog to use a new location
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        //Save As Button
        // Saved document file using Binary Format Serialization 
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
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this.MyTextsDoc);
                    this.MyTextsDoc.SavedName = dlg.FileName;
                    this.SavedDoc = true;

                }
            }
        }

        //Exit Button
        //Close the Main Form
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Verify for unsaved document before closing or prevent closing
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.SavedDoc)
            {
                DialogResult d = MessageBox.Show("Do you want to save the file?", "Unsaved Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    this.saveToolStripMenuItem_Click(sender, e);
                }
                if (d == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        //Font Menu itmes
        private void fontTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fdlg = new FontDialog())
            {
                if (fdlg.ShowDialog() == DialogResult.OK)
                {
                    Newtext.TextFont = fdlg.Font;
                    Newtext.TextFont = fdlg.Font;
                    UpdateStatus();
                    
                }
            }
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog cdlg = new ColorDialog())
            {
                if (cdlg.ShowDialog() == DialogResult.OK)
                {
                    Newtext.TextColor = cdlg.Color;
                    Newtext.TextColor = cdlg.Color;
                    UpdateStatus();
                    
                }
            }
        }

        public void UpdateStatus()
        {
            this.fontTypeToolStripStatusLabel.Text = "Font Type: " + this.Newtext.TextFont.Name.ToString();
            this.fontSizeToolStripStatusLabel.Text = "Font Size: " + this.Newtext.TextFont.Size.ToString();
            this.showColortoolStripStatusLabel.Text = this.Newtext.TextColor.ToString();
            this.showColortoolStripStatusLabel.BackColor = this.Newtext.TextColor;

            if (boldButton.Checked && italicButton.Checked && underlineButton.Checked && strikeoutButton.Checked)
            {
                Font edittedFont = new Font(Newtext.TextFont.FontFamily, Newtext.TextFont.Size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline | FontStyle.Strikeout);
                Newtext.TextFont = edittedFont;
            } else if (boldButton.Checked && italicButton.Checked && underlineButton.Checked && !strikeoutButton.Checked)
            {
                Font edittedFont = new Font(Newtext.TextFont.FontFamily, Newtext.TextFont.Size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                Newtext.TextFont = edittedFont;
            } else if (boldButton.Checked && italicButton.Checked && !underlineButton.Checked && strikeoutButton.Checked)
            {
                Font edittedFont = new Font(Newtext.TextFont.FontFamily, Newtext.TextFont.Size, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout);
                Newtext.TextFont = edittedFont;
            } else if (boldButton.Checked && !italicButton.Checked && underlineButton.Checked && strikeoutButton.Checked)
            {
                Font edittedFont = new Font(Newtext.TextFont.FontFamily, Newtext.TextFont.Size, FontStyle.Bold | FontStyle.Underline | FontStyle.Strikeout);
                Newtext.TextFont = edittedFont;
            } else if (!boldButton.Checked && italicButton.Checked && underlineButton.Checked && strikeoutButton.Checked)
            {
                Font edittedFont = new Font(Newtext.TextFont.FontFamily, Newtext.TextFont.Size, FontStyle.Italic | FontStyle.Underline | FontStyle.Strikeout);
                Newtext.TextFont = edittedFont;
            } else if (boldButton.Checked && italicButton.Checked && !underlineButton.Checked && !strikeoutButton.Checked)
            {
                Font edittedFont = new Font(Newtext.TextFont.FontFamily, Newtext.TextFont.Size, FontStyle.Bold | FontStyle.Italic);
                Newtext.TextFont = edittedFont;
            } else if (boldButton.Checked && !italicButton.Checked && underlineButton.Checked && !strikeoutButton.Checked)
            {
                Font edittedFont = new Font(Newtext.TextFont.FontFamily, Newtext.TextFont.Size, FontStyle.Bold | FontStyle.Underline);
                Newtext.TextFont = edittedFont;
            } else if (!boldButton.Checked && italicButton.Checked && underlineButton.Checked && !strikeoutButton.Checked)
            {
                Font edittedFont = new Font(Newtext.TextFont.FontFamily, Newtext.TextFont.Size, FontStyle.Underline | FontStyle.Italic);
                Newtext.TextFont = edittedFont;
            } else if (boldButton.Checked && !italicButton.Checked && !underlineButton.Checked && strikeoutButton.Checked)
            {
                Font edittedFont = new Font(Newtext.TextFont.FontFamily, Newtext.TextFont.Size, FontStyle.Bold | FontStyle.Strikeout);
                Newtext.TextFont = edittedFont;
            } else if (!boldButton.Checked && italicButton.Checked && !underlineButton.Checked && strikeoutButton.Checked)
            {
                Font edittedFont = new Font(Newtext.TextFont.FontFamily, Newtext.TextFont.Size, FontStyle.Italic | FontStyle.Strikeout);
                Newtext.TextFont = edittedFont;
            } else if (!boldButton.Checked && !italicButton.Checked && underlineButton.Checked && strikeoutButton.Checked)
            {
                Font edittedFont = new Font(Newtext.TextFont.FontFamily, Newtext.TextFont.Size, FontStyle.Underline | FontStyle.Strikeout);
                Newtext.TextFont = edittedFont;
            } else if (boldButton.Checked && !italicButton.Checked && !underlineButton.Checked && !strikeoutButton.Checked)
            {
                Font edittedFont = new Font(Newtext.TextFont.FontFamily, Newtext.TextFont.Size, FontStyle.Bold);
                Newtext.TextFont = edittedFont;
            } else if (!boldButton.Checked && italicButton.Checked && !underlineButton.Checked && !strikeoutButton.Checked)
            {
                Font edittedFont = new Font(Newtext.TextFont.FontFamily, Newtext.TextFont.Size, FontStyle.Italic);
                Newtext.TextFont = edittedFont;
            } else if (!boldButton.Checked && !italicButton.Checked && underlineButton.Checked && !strikeoutButton.Checked)
            {
                Font edittedFont = new Font(Newtext.TextFont.FontFamily, Newtext.TextFont.Size, FontStyle.Underline);
                Newtext.TextFont = edittedFont;
            } else if (!boldButton.Checked && !italicButton.Checked && !underlineButton.Checked && strikeoutButton.Checked)
            {
                Font edittedFont = new Font(Newtext.TextFont.FontFamily, Newtext.TextFont.Size, FontStyle.Strikeout);
                Newtext.TextFont = edittedFont;
            } else
            {
                Font nonedittedFont = new Font(Newtext.TextFont.FontFamily, Newtext.TextFont.Size);
                Newtext.TextFont = nonedittedFont;
            }
        }


        //Start Draw Events in the panel
        //Mouse down retrive the position of the mouse
        private void drawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            index = Isinside(e);
            if (index != -1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.CurrentText = this.MyTextsDoc.DocTexts.ElementAt(index);
                    startdrag = true;
                    this.drawingPanel.Invalidate(true);
                    this.CurrentText.Location = e.Location;
                }
                else
                {
                    textOptionsToolStripMenuItem_Click(sender, e);
                }
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Newtext.Location = e.Location;
                    startdrawing = true;
                }
            }
            //this.Invalidate(true);
        }

        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (startdrawing) // If we initiate a drawing 
            {
                s.Width = e.Location.X - this.Newtext.Location.X;
                s.Height = e.Location.Y - this.Newtext.Location.Y;
                this.Newtext.SSize = s;
                this.continueToMove = true;

                this.Newtext.TextContent = this.textContenttextBox.Text;

                //Handeling the Left to right drawing

                Rectangle r;

                if (s.Width == 0 && s.Height == 0) return;
                if (s.Width < 0 && s.Height < 0)
                {
                    s.Width = s.Width * -1;
                    s.Height = s.Height * -1;
                    r = new Rectangle(new Point(this.Newtext.Location.X - s.Width, this.Newtext.Location.Y - s.Height), s);

                }
                else if (s.Height < 0)
                {
                    s.Height = s.Height * -1;
                    r = new Rectangle(new Point(this.Newtext.Location.X, this.Newtext.Location.Y - s.Height), s);

                }
                else if (s.Width < 0)
                {
                    s.Width = s.Width * -1;
                    r = new Rectangle(new Point(this.Newtext.Location.X - s.Width, this.Newtext.Location.Y), s);
                }

                else
                {
                    r = new Rectangle(this.Newtext.Location, s);
                }

                
                this.Newtext.DrawingRect = r;
                this.Newtext.Rotation = float.Parse(this.rottextBox.Text);
                this.drawingPanel.Invalidate(true);               

            }

            if (startdrag) // Dragging the text rectangle
            {
                Rectangle r;
                r = new Rectangle(e.X,e.Y, this.MyTextsDoc.DocTexts.ElementAt(index).DrawingRect.Width, this.MyTextsDoc.DocTexts.ElementAt(index).DrawingRect.Height);
                this.MyTextsDoc.DocTexts.ElementAt(index).DrawingRect = r;
                this.drawingPanel.Invalidate(true);
            }

            
        }

        private void drawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            startdrawing = false;
            startdrag = false;

            if (continueToMove)
            {
                isFileSelectedText = false;
                this.Newtext.SSize = s;
                this.Newtext.TextContent = this.textContenttextBox.Text;
                this.Newtext.Rotation = float.Parse(this.rottextBox.Text);
                this.MyTextsDoc.AddText(new Text(Newtext.TextContent,
                                                    Newtext.TextFont,
                                                    Newtext.Location,
                                                    Newtext.Rotation,
                                                    Newtext.TextColor,
                                                    Newtext.SSize,
                                                    Newtext.DrawingRect));

                if (textOptionsToolStripMenuItem.Enabled == false)
                    textOptionsToolStripMenuItem.Enabled = true;

                if (manageToolStripMenuItem.Enabled == false)
                    manageToolStripMenuItem.Enabled = true;

                s.Width = 0;
                s.Height = 0;
            }
            //this.drawingPanel.Invalidate(true);
           
            continueToMove = false;
        }

        //Drawing the text
        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            printdoc(e, g, index); // Helper method to print all the shapes in the document

           
            if (!startdrawing && !startdrag && !isFileSelectedText)
            {
                return;
            }
                
            if (startdrag)      //Select whicj text object I will use to drwa
            {
                textToDraw = CurrentText;
            }
            else
            {
                if(isFileSelectedText)
                {
                    textToDraw.DrawingRect = new Rectangle(new Point(drawingPanel.Location.X, drawingPanel.Location.Y), new Size(0,0));
                }
                textToDraw = Newtext;

            }

            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush b = new SolidBrush(this.textToDraw.TextColor);
           
            
            // Save the graphics state
            GraphicsState state = g.Save();
            g.ResetTransform();

            Matrix matrix = new Matrix();
            matrix.RotateAt(this.textToDraw.Rotation, this.textToDraw.DrawingRect.Location);
            g.Transform = matrix;

            // Rotate graphics
            /*g.RotateTransform(this.CurrentText.Rotation);

            if (this.CurrentText.Rotation > 0)
            {
                g.TranslateTransform(this.CurrentText.DrawingRect.X, this.CurrentText.DrawingRect.Y, MatrixOrder.Append);
            }*/

            
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Near;

            // Draw text at origin, with center alignment
            
            g.DrawString(this.textToDraw.TextContent, this.textToDraw.TextFont, b, this.textToDraw.DrawingRect, format);
            //Restore the graphics state
           

           g.DrawRectangle(new Pen(b), this.textToDraw.DrawingRect);
           g.Restore(state);

            b.Dispose();
            g.Dispose();

           // startdrag = false;
            //startdrawing = false;
        }

        //Method used to redraw the old shapes in the panel
        public void printdoc(PaintEventArgs e, Graphics g, int i)
        {
            
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Near;
            int count = 0;

            foreach (Text mytext in this.MyTextsDoc.DocTexts)
            {
                g.ResetTransform();
                Matrix matrix = new Matrix();
                matrix.RotateAt(mytext.Rotation, mytext.DrawingRect.Location);
                g.Transform = matrix;
                g.DrawString(mytext.TextContent, mytext.TextFont, new SolidBrush(mytext.TextColor), mytext.DrawingRect, format);
                if(count == i)      //We draw the rectangle of the selected text
                {
                    g.DrawRectangle(new Pen(new SolidBrush(mytext.TextColor)), mytext.DrawingRect);
                }
                count++;
            }

        }

        //opens the SearchDialog modelessly
        private void searchMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchDiag == null || searchDiag.Text == string.Empty)
            {
                searchDiag = new SearchDialog();
                searchDiag.Owner = this;
                searchDiag.Show();
            }
        }


        public int Isinside(MouseEventArgs e)
        {
            foreach (Text mytext in this.MyTextsDoc.DocTexts)
            {
                if (mytext.Isin(e.Location))
                {
                    return MyTextsDoc.DocTexts.IndexOf(mytext);
                }

            }
            return -1;
        }

        //Indicates that what is being dragged into the text box is dropable.
        private void drawingPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                e.Effect = DragDropEffects.Copy;
            } else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void drawingPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                string dropString = (string)e.Data.GetData(DataFormats.Text);
                ProcessString(dropString);
            }
          
        }

        public void LoadFileContent(string content)
        {
            Newtext.TextContent = content;
            this.drawingPanel.Invalidate(true);
        }

      

        //Helper method used to process the drop and paste events
        public void ProcessString(string pString)
        {
            string[] tokens = pString.Split(' ');
            int locationX = 0;

            Font font = new Font("Arial", 12);


            foreach (string t in tokens)
            {
                Image fakeImage = new Bitmap(1, 1); //As we cannot use CreateGraphics() in a class library, so the fake image is used to load the Graphics.
                using (Graphics graphics = Graphics.FromImage(fakeImage))
                {
                    SizeF size = graphics.MeasureString(t, font);
                    size.Width += 1;
                    size.Height += 1;



                    if (locationX + size.Width > this.drawingPanel.Width)
                    {
                        locationY += (int)size.Height + 5;
                        locationX = 0;
                    }
                    this.MyTextsDoc.AddText(new Text(t, font, new Point(locationX, locationY),
                                               0f, Color.Black, size.ToSize(),
                                                new Rectangle(new Point(locationX, locationY), size.ToSize())));

                    locationX += (int)size.Width + 5;

                }
            }

            if (textOptionsToolStripMenuItem.Enabled == false)
                textOptionsToolStripMenuItem.Enabled = true;

            if (manageToolStripMenuItem.Enabled == false)
                manageToolStripMenuItem.Enabled = true;

            locationY += font.Height + 5;
            this.drawingPanel.Invalidate(true);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsData(DataFormats.Text))
            {
                string pasteString = (string)Clipboard.GetData(DataFormats.Text);
                ProcessString(pasteString);
            }
        }


        public void setMaxlocationYValue()
        {
            foreach(Text t in MyTextsDoc.DocTexts)
            {
                if((t.DrawingRect.Location.Y+ t.DrawingRect.Size.Height) > this.locationY)
                {
                    locationY = (t.DrawingRect.Location.Y + t.DrawingRect.Size.Height);
                }
            }
        }

        //Keeps track of the buttons' state
        private void boldButton_Click(object sender, EventArgs e)
        {

            if (boldButton.Checked == false)
            {
                boldButton.Checked = true;
            } else
            {
                boldButton.Checked = false;
            }

            UpdateStatus();
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            if (italicButton.Checked == false)
            {
                italicButton.Checked = true;
            } else
            {
                italicButton.Checked = false;
            }

            UpdateStatus();
        }

        private void underlineButton_Click(object sender, EventArgs e)
        {
            if (underlineButton.Checked == false)
            {
                underlineButton.Checked = true;
            }
            else
            {
                underlineButton.Checked = false;
            }

            UpdateStatus();
        }

        private void strikeoutButton_Click(object sender, EventArgs e)
        {

            if (strikeoutButton.Checked == false)
            {
                strikeoutButton.Checked = true;
            }
            else
            {
                strikeoutButton.Checked = false;
            }

            UpdateStatus();
        }

        int m_nPage = 1;
        //Here we show the preview when we click in print button
             

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            preview = (e.PrintAction == PrintAction.PrintToPreview);
            header_font = new Font("Lucida Console", 36);
            footer_font = new Font("Lucida Console", 20);
            body_font = new Font("Arial", 12);
            m_nPage = 0;
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            m_nPage++;
            Graphics g = e.Graphics;
            Rectangle realPageBounds = PrintUtils.GetRealPageBounds(e, preview);
            Rectangle realMarginBounds = PrintUtils.GetRealMarginBounds(e, preview);
            g.DrawRectangle(Pens.Black, realPageBounds);
            g.DrawRectangle(Pens.Black, realMarginBounds);

            //This will print the header
            g.DrawString("Group #1", header_font, Brushes.Black, realPageBounds); //Displays the left header

            SizeF measure = g.MeasureString("Homework 10", header_font);
            PointF toHeader = new PointF((realPageBounds.Location.X + realPageBounds.Width) - measure.Width, realPageBounds.Y);
            g.DrawString("Homework 10", header_font, Brushes.Black, toHeader);    //Displays the Right header

            //Now we will print the footer 
            measure = g.MeasureString("Page: " + m_nPage.ToString(), footer_font);
            DateTime thisDay = DateTime.Today;
            toHeader.X = realPageBounds.X;
            toHeader.Y = realPageBounds.Height - measure.Height;
            g.DrawString(thisDay.ToString(), footer_font, Brushes.Black, toHeader); //Displays the left Footer

            toHeader = new PointF(realPageBounds.Width - measure.Width, realPageBounds.Height - measure.Height);
            g.DrawString("Page: " + m_nPage.ToString(), footer_font, Brushes.Black, toHeader); //Displays the Right Footer

            for (int i = objectIndex; i < this.MyTextsDoc.DocTexts.Count(); i++)
            {
                
                    Text temp = this.MyTextsDoc.DocTexts.ElementAt(i);
                    String line = "Object# " + i.ToString();

                    String[] fontValues = temp.TextFont.ToString().Split('=');
                    String fontLine = fontValues[1] + fontValues[2].Substring(0, fontValues[2].IndexOf(','));
                    int numtabs = (int)(temp.TextContent.Length / 7)+1;  //tab lenght
                    String tabs = "";
                    switch (numtabs)
                    {
                        case 1: tabs = "\t\t";
                            break;
                        case 2: tabs = "\t";
                            break;
                        
                    }

                    line += " " + temp.TextContent + tabs + temp.TextColor + "\tRotation =" + temp.Rotation + "\t" + fontLine + "\n";
                    //SizeF lineHeight = g.MeasureString(temp.TextContent, temp.TextFont);
                    g.DrawString(line, body_font, new SolidBrush(temp.TextColor), realMarginBounds);
                    realMarginBounds.Y += (int)(body_font.Height);
                    realMarginBounds.Height -= (int)(body_font.Height); ;
                    objectIndex++;
                
                if (objectIndex + 1 < this.MyTextsDoc.DocTexts.Count())   //If there is more objects to print 
                {         
                    Text nextObject = this.MyTextsDoc.DocTexts.ElementAt(i+1);
                    if(realMarginBounds.Height < body_font.Height)      //But we dont have space for the next line
                    {                        
                        e.HasMorePages = true;
                        break;
                    }
                }
            }      
           
        }

        private void printDocument_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            objectIndex = 0;
            m_nTotalPage = m_nPage;
            header_font.Dispose();
            body_font.Dispose();
            footer_font.Dispose();
        }

        private void printDocument_QueryPageSettings(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs e)
        {
            e.PageSettings.Margins = new Margins(margins, margins, margins, margins);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m_nPage = 1;
            ((Form)printPreviewDialog).Height = 600;
            ((Form)printPreviewDialog).Width = 600;
            printPreviewDialog.ShowDialog();
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PrintController savedController = printDocument.PrintController;
            PrintController virtualController = new PreviewPrintController();

            printDocument.PrintController = virtualController;
            printDocument.Print();
            printDocument.PrintController = savedController;

            printDocument.PrinterSettings.FromPage = 1;
            printDocument.PrinterSettings.ToPage = m_nTotalPage;
            printDocument.PrinterSettings.MinimumPage = 1;
            printDocument.PrinterSettings.MaximumPage = m_nTotalPage;
            printDialog.AllowSomePages = true;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                if (printDialog.PrinterSettings.PrintRange == PrintRange.SomePages)
                {
                    m_nPage = printDocument.PrinterSettings.FromPage;
                    m_nMaxPage = printDocument.PrinterSettings.ToPage;
                }
                else
                {
                    m_nPage = 1;
                    m_nMaxPage = m_nTotalPage;
                }
                this.printDocument.Print();
            }
        }

        private void imageViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsOptionsDialogOpen)
            {
                IsOptionsDialogOpen = true;
                ImageViewDialog imgDlg = new ImageViewDialog();
                imgDlg.Owner = this;
                // Intialize dialog
                imgDlg.ShowDialog();
                IsOptionsDialogOpen = false;
            }
        }

        private void saveAsImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Bitmap bmp = new Bitmap(drawingPanel.ClientSize.Width, drawingPanel.ClientSize.Height))
            {
                drawingPanel.DrawToBitmap(bmp, drawingPanel.ClientRectangle);

                saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Png Image|*.png";
                saveFileDialog.Title = "Save an Image File";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            bmp.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;

                        case 2:
                            bmp.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Bmp);
                            break;

                        case 3:
                            bmp.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Png);
                            break;
                    }
                }
            }
        }
    }
}
