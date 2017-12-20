using ControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
//using Microsoft.VisualBasic;

namespace Homework7
{
    public partial class MainForm : BaseMainForm
    {
        public static bool IsAboutDialogOpen { get; set; } // Only allow one About dialog to be open at a time
        public static bool IsOathDialogOpen { get; set; } // Only allow one Oath dialog to be open at a time
        public static bool IsOptionsDialogOpen { get; set; } // Only allow one Option dialog to be open at a time
        

        public bool SavedDoc { get; set; } // Variable used to save the file in the same location
        public bool start { get; set; } // Variable to control the drawing 
        private bool continueToMove { get; set; }
 // State of the document
        public bool WasSaved { get; set; }
        public String ExtName { get; set; } // Custom .ext of the saved file

        public Document MyShapesDoc;        //List of shapes
        public Shape CurrentShape;          //Currently selected shape to draw
        
        Size s;     //Size of the shape we are drawing 

        public MainForm()
        {
            InitializeComponent();
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

            //Satrt Drawing  
            start = false;

            
            // Custom Extension name
            this.ExtName = ".g1";

            // Create the list of shapes in my document object
            this.MyShapesDoc = new Document();

            // Create the shape with initial properties
            this.CurrentShape = new Shape(Shapes.Ellipse);  //Setting default shape to be ellipse

            //Load the dfault values for the menu items
            loadMenu();
            loadstatus();

            //Size of the shape we are drawing
            s = new Size(0, 0);

           
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

        private void shapeOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsOptionsDialogOpen)
            {
                IsOptionsDialogOpen = true;
                ShapeOptionsDialog optDlg = new ShapeOptionsDialog();
                optDlg.Owner = this;
                optDlg.ChangesApplied += OptDlg_ChangesApplied;
                // Intialize dialog
                optDlg.Show();
            }
        }

        private void OptDlg_ChangesApplied(object sender, EventArgs e)
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

            this.MyShapesDoc = new Document();
            this.Invalidate(true);
            this.WasSaved = false;
            this.shapeOptionsToolStripMenuItem.Enabled = false;
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
                //Setting the default extension for the file 
                dlg.AddExtension = true;
                dlg.DefaultExt = this.ExtName;
                dlg.Filter = "G1 files (*.g1)|*" + this.ExtName + "|All files (*.*)|*.*";

                if (dlg.ShowDialog() != DialogResult.OK) return;
                using (Stream stream = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                {
                    IFormatter formatter = new BinaryFormatter();
                    this.MyShapesDoc = (Document)formatter.Deserialize(stream);

                    if(MyShapesDoc.DocShapes.Count > 0)
                    this.shapeOptionsToolStripMenuItem.Enabled = true;

                    this.Invalidate(true);

                    //Avoid asking to save if we just open the file
                    this.SavedDoc = true;
                    this.WasSaved = true;
                   
                }
            }
        }

        //Save Button
        // Saved document file using Binary Format Serialization 
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WasSaved)  //If the data was alredy saved use the same location
            {
                using (Stream stream = new FileStream(this.MyShapesDoc.SavedName, FileMode.Create, FileAccess.Write))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this.MyShapesDoc);
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
                    formatter.Serialize(stream, this.MyShapesDoc);
                    this.MyShapesDoc.SavedName = dlg.FileName;
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


        //Helper method to Load the default values for the menu
        public void loadMenu()
        {
            //**** Not sure if we can use Data binding to Generate this menu automatically 
            //Unchecked every item first
            this.ellipseToolStripMenuItem.Checked = false;
            this.rectangleToolStripMenuItem.Checked = false;
            this.customToolStripMenuItem.Checked = false;
            this.solidToolStripMenuItem1.Checked = false;
            this.customDashedToolStripMenuItem.Checked = false;
            this.compoundToolStripMenuItem.Checked = false;
            this.solidToolStripMenuItem.Checked = false;
            this.hatchToolStripMenuItem.Checked = false;
            this.linearGradientToolStripMenuItem.Checked = false;
            this.ellipseToolStripBtn.Checked = false;
            this.rectangleToolStripBtn.Checked = false;
            this.customShapeToolStripBtn.Checked = false;
            this.penToolStripBtn.Checked = false;
            this.customPenToolStripBtn.Checked = false;
            this.compoundPenToolStripBtn.Checked = false;
            this.solidBrushToolStripBtn.Checked = false;
            this.hatchedBrushToolStripBtn.Checked = false;
            this.gradientBrushToolStripBtn.Checked = false;


            //Load the shape type menu
            if (this.CurrentShape.ShapeType == Shapes.Ellipse)
            {
                this.ellipseToolStripMenuItem.Checked = true;
                this.ellipseToolStripBtn.Checked = true;
            }

            if (this.CurrentShape.ShapeType == Shapes.Rectangle)
            {
                this.rectangleToolStripMenuItem.Checked = true;
                this.rectangleToolStripBtn.Checked = true;
            }

            if (this.CurrentShape.ShapeType == Shapes.Custom)
            {
                this.customToolStripMenuItem.Checked = true;
                this.customShapeToolStripBtn.Checked = true;
            }


            //Load the pen type menu
            if (this.CurrentShape.PenType == Pens.Solid)
            {
                this.solidToolStripMenuItem1.Checked = true;
                this.penToolStripBtn.Checked = true;
            }

            if (this.CurrentShape.PenType == Pens.Dashed)
            {
                this.customDashedToolStripMenuItem.Checked = true;
                this.customPenToolStripBtn.Checked = true;
            }

            if (this.CurrentShape.PenType == Pens.Compound)
            {
                this.compoundToolStripMenuItem.Checked = true;
                this.compoundPenToolStripBtn.Checked = true;
            }


            //Load the brush type menu
            if (this.CurrentShape.BrushType == Brushes.Solid)
            {
                this.solidToolStripMenuItem.Checked = true;
                this.solidBrushToolStripBtn.Checked = true;
            }

            if (this.CurrentShape.BrushType == Brushes.Hatched)
            {
                this.hatchToolStripMenuItem.Checked = true;
                this.hatchedBrushToolStripBtn.Checked = true;
            }

            if (this.CurrentShape.BrushType == Brushes.LinearGradient)
            {
                this.linearGradientToolStripMenuItem.Checked = true;
                this.gradientBrushToolStripBtn.Checked = true;
            }

            //Load the color menu
            Bitmap p = new Bitmap(16, 16);
            Bitmap ba = new Bitmap(16, 16);
            Bitmap bb = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(p))
                g.Clear(this.CurrentShape.PenColor);

            this.penColorToolStripMenuItem.Image = p;

            using (Graphics g = Graphics.FromImage(ba))
                g.Clear(this.CurrentShape.BrushColorA);
            this.brushAColorToolStripMenuItem.Image = ba;

            using (Graphics g = Graphics.FromImage(bb))
                g.Clear(this.CurrentShape.BrushColorB);
            this.brushBColorToolStripMenuItem.Image = bb;

            loadstatus();
        }


        //Update the status bar
        public void loadstatus()
        {
            this.shapetoolStripStatusLabel.Text = "Shape: " + this.CurrentShape.ShapeType.ToString();
            this.penStripStatusLabel.Text = "Pen Type: " + this.CurrentShape.PenType.ToString();
            this.brushtoolStripStatusLabel.Text = "Brush Type: " + this.CurrentShape.BrushType.ToString();

            this.pcolortoolStripStatusLabel.Text = this.CurrentShape.PenColor.ToString().Substring(6);
            this.pcolortoolStripStatusLabel.BackColor = this.CurrentShape.PenColor;

            this.bAcolortoolStripStatusLabel.Text = this.CurrentShape.BrushColorA.ToString().Substring(6);
            this.bAcolortoolStripStatusLabel.BackColor = this.CurrentShape.BrushColorA;

            this.bBcolortoolStripStatusLabel.Text = this.CurrentShape.BrushColorB.ToString().Substring(6);
            this.bBcolortoolStripStatusLabel.BackColor = this.CurrentShape.BrushColorB;

        }


        //Shape Type menu click handlers
        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CurrentShape.ShapeType = Shapes.Ellipse;
            loadMenu();

        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CurrentShape.ShapeType = Shapes.Rectangle;
            loadMenu();
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CurrentShape.ShapeType = Shapes.Custom;
            loadMenu();
        }

        //Shape Pen menu click handlers
        private void solidToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.CurrentShape.PenType = Pens.Solid;
            loadMenu();
        }

        private void customDashedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CurrentShape.PenType = Pens.Dashed;
            loadMenu();
        }

        private void compoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CurrentShape.PenType = Pens.Compound;
            loadMenu();
        }
        
        //Shape Brush menu click handlers
        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CurrentShape.BrushType = Brushes.Solid;
            loadMenu();
        }

        private void hatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CurrentShape.BrushType = Brushes.Hatched;
            loadMenu();
        }

        private void linearGradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CurrentShape.BrushType = Brushes.LinearGradient;
            loadMenu();
        }
        
        //Shape Color menu click handlers
        private void penColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    this.CurrentShape.PenColor = dlg.Color;
                    loadMenu();
                }
            }

        }

        private void brushColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    this.CurrentShape.BrushColorA = dlg.Color;
                    loadMenu();
                }
            }
        }

        private void brushBColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    this.CurrentShape.BrushColorB = dlg.Color;
                    loadMenu();
                }
            }
        }


        //Start Draw Events in the panel
        //Mouse down retrive the position of the mouse
        private void canvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            this.CurrentShape.Location = e.Location;
            start = true;
            this.Invalidate(true);
        }

        //Mouse Move retrive the position of the mouse and create the size of the shape
        private void canvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (start) // If we initiate a drawing 
            {
                //if(this.CurrentShape.ShapeType == Shapes.Rectangle)
                //{
                    
                    s.Width = e.Location.X - this.CurrentShape.Location.X;
                    s.Height = e.Location.Y - this.CurrentShape.Location.Y;
                    this.CurrentShape.SSize = s;
                    this.continueToMove = true;
            //}


            this.Invalidate(true);

            }
        }

        //Mouse up finish the drawing and add the shape to the document
        private void canvasPanel_MouseUp(object sender, MouseEventArgs e)
        {
            start = false;

            if (continueToMove)
            {
                this.CurrentShape.SSize = s;
                this.MyShapesDoc.AddShape(new Shape(CurrentShape.ShapeType,
                                                    CurrentShape.Location,
                                                    CurrentShape.PenColor,
                                                    CurrentShape.PenType,
                                                    CurrentShape.BrushColorA,
                                                    CurrentShape.BrushColorB,
                                                    CurrentShape.BrushType,
                                                    CurrentShape.SSize,
                                                    CurrentShape.DrawingRect,
                                                    CurrentShape.CustomDrawingPoly,

                                                    CurrentShape.Name = CurrentShape.ShapeType.ToString() + this.MyShapesDoc.DocShapes.Count + 1));

                if (shapeOptionsToolStripMenuItem.Enabled == false)
                    shapeOptionsToolStripMenuItem.Enabled = true;


                s.Width = 0;
                s.Height = 0;
            }

            continueToMove = false;
            
        }

        //Paint event to redraw the panel
        private void canvasPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            printdoc(e,g); // Helper method to print all the shapes in the document

            if (this.CurrentShape.ShapeType == Shapes.Ellipse)
            {
                drawEllip(e, this.CurrentShape,g, false); //Drawing an ellipse

            } else if (this.CurrentShape.ShapeType == Shapes.Rectangle)
            {
                drawRec(e, this.CurrentShape,g, false);  //Drawing a rectangle
            } else if (this.CurrentShape.ShapeType == Shapes.Custom)
            {
                drawCusto(e, this.CurrentShape,g, false);
            }

            g.Dispose();

        }


        //Helper method to draw a rectangle
        public void drawRec(PaintEventArgs e, Shape useShape, Graphics g, bool previousShape)
        {
            //Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen p = new Pen(useShape.PenColor, 3); //Creating a solid pen with its color
            Brush b;
            Rectangle r;
            
            //Selecting the type of the Pen 
            if (useShape.PenType == Pens.Dashed) // Change pen style to dashed
                {
                    p.DashStyle = DashStyle.Dash;
                }

                if (useShape.PenType == Pens.Compound) // Change pen style to Compound
            {
                    p.DashStyle = DashStyle.Custom;
                    p.CompoundArray = new float[] { 0.0f, 0.2f, 0.8f, 1.0f, };
                }

            //Selecting the type of the brush 
            if (useShape.BrushType == Brushes.LinearGradient)
            {
               Rectangle rect = new Rectangle(useShape.Location.X, useShape.Location.Y, 200, 200);
                b = new LinearGradientBrush(rect, useShape.BrushColorA, useShape.BrushColorB, LinearGradientMode.Vertical);
            }
            
            else if (useShape.BrushType == Brushes.Hatched)
            {
                 b = new HatchBrush(HatchStyle.LargeCheckerBoard, useShape.BrushColorA, useShape.BrushColorB);
                
            }

            else
            {
                b = new SolidBrush(useShape.BrushColorA);
            }


            if (previousShape) // If we are printing a previous shape
            {
                g.FillRectangle(b, useShape.DrawingRect);
                g.DrawRectangle(p, useShape.DrawingRect);
                return;
            }

            //Handeling the Left to right drawing

            if (s.Width < 0 && s.Height < 0)
                {
                    s.Width = s.Width * -1;
                    s.Height = s.Height * -1;
                    r = new Rectangle(new Point(useShape.Location.X - s.Width, useShape.Location.Y - s.Height), s);

                }
                else if (s.Height < 0)
                {
                    s.Height = s.Height * -1;
                    r = new Rectangle(new Point(useShape.Location.X, useShape.Location.Y - s.Height), s);

                }
                else if (s.Width < 0)
                {
                    s.Width = s.Width * -1;
                    r = new Rectangle(new Point(useShape.Location.X - s.Width, useShape.Location.Y), s);
                }

                else
                {
                    r = new Rectangle(useShape.Location, s);
                }
            
                     
            
                g.FillRectangle(b, r);
                g.DrawRectangle(p, r);
                this.CurrentShape.DrawingRect = r;
            

            

            b.Dispose();
           // g.Dispose();

        }

        //Helper method to draw an ellipse
        public void drawEllip(PaintEventArgs e, Shape useShape, Graphics g, bool previousShape)
        {
            //Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen p = new Pen(useShape.PenColor, 3); //Creating a solid pen with its color
            Brush b;
            Rectangle r;

            //Selecting the type of the Pen 
            if (useShape.PenType == Pens.Dashed) // Change pen style to dashed
            {
                p.DashStyle = DashStyle.Dash;
            } else if (useShape.PenType == Pens.Compound) // Change pen style to Compound
            {
                p.DashStyle = DashStyle.Custom;
                p.CompoundArray = new float[] { 0.0f, 0.2f, 0.8f, 1.0f, };
            }

            //Selecting the type of the brush 
            if (useShape.BrushType == Brushes.LinearGradient) //Changes brush style to gradient
            {
                Rectangle rect = new Rectangle(useShape.Location.X, useShape.Location.Y, 200,200);
                b = new LinearGradientBrush(rect, useShape.BrushColorA, useShape.BrushColorB, LinearGradientMode.Vertical);

            } else if (useShape.BrushType == Brushes.Hatched) //Changes brush style to hatched
            {
                b = new HatchBrush(HatchStyle.LargeCheckerBoard, useShape.BrushColorA, useShape.BrushColorB);

            } else //sets the solid brush style
            {
                b = new SolidBrush(useShape.BrushColorA);
            }

            if (previousShape) // If we are printing a previous shape
            {
                g.FillEllipse(b, useShape.DrawingRect);
                g.DrawEllipse(p, useShape.DrawingRect);
                return;
            }

            //Handeling the Left to right drawing
            if (s.Width < 0 && s.Height < 0)
            {
                s.Width = s.Width * -1;
                s.Height = s.Height * -1;
                r = new Rectangle(new Point(useShape.Location.X - s.Width, useShape.Location.Y - s.Height), s);

            }
            else if (s.Height < 0)
            {
                s.Height = s.Height * -1;
                r = new Rectangle(new Point(useShape.Location.X, useShape.Location.Y - s.Height), s);

            }
            else if (s.Width < 0)
            {
                s.Width = s.Width * -1;
                r = new Rectangle(new Point(useShape.Location.X - s.Width, useShape.Location.Y), s);
            }

            else
            {
                r = new Rectangle(useShape.Location, s);
            }

            g.FillEllipse(b, r);
            g.DrawEllipse(p, r);
            this.CurrentShape.DrawingRect = r;

            b.Dispose();
            //g.Dispose();

        }

        //Helper method to draw an Custom Shape
        public void drawCusto(PaintEventArgs e, Shape useShape, Graphics g, bool previousShape)
        {
            //Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen p = new Pen(useShape.PenColor, 3); //Creating a solid pen with its color
            Brush b;
            Rectangle r;
            bool flip = false;

            //Selecting the type of the Pen 
            if (useShape.PenType == Pens.Dashed) // Change pen style to dashed
            {
                p.DashStyle = DashStyle.Dash;
            }
            else if (useShape.PenType == Pens.Compound) // Change pen style to Compound
            {
                p.DashStyle = DashStyle.Custom;
                p.CompoundArray = new float[] { 0.0f, 0.2f, 0.8f, 1.0f, };
            }

            //Selecting the type of the brush 
            if (useShape.BrushType == Brushes.LinearGradient) //Changes brush style to gradient
            {
                Rectangle rect = new Rectangle(useShape.Location.X, useShape.Location.Y, 200, 200);
                b = new LinearGradientBrush(rect, useShape.BrushColorA, useShape.BrushColorB, LinearGradientMode.Vertical);

            }
            else if (useShape.BrushType == Brushes.Hatched) //Changes brush style to hatched
            {
                b = new HatchBrush(HatchStyle.LargeCheckerBoard, useShape.BrushColorA, useShape.BrushColorB);

            }
            else //sets the solid brush style
            {
                b = new SolidBrush(this.CurrentShape.BrushColorA);
            }


            if (previousShape)// If we are printing a previous shape
            {
                g.FillPolygon(b, useShape.CustomDrawingPoly, FillMode.Winding);
                g.DrawPolygon(p, useShape.CustomDrawingPoly);
                return;
            }

            //Handeling the Left to right drawing
            if (s.Width < 0 && s.Height < 0)
            {
                flip = true;
                s.Width = s.Width * -1;
                s.Height = s.Height * -1;
                r = new Rectangle(new Point(useShape.Location.X - s.Width, useShape.Location.Y - s.Height), s);

            }
            else if (s.Height < 0)
            {
                s.Height = s.Height * -1;
                r = new Rectangle(new Point(useShape.Location.X, useShape.Location.Y - s.Height), s);

            }
            else if (s.Width < 0)
            {
                flip = true;
                s.Width = s.Width * -1;
                r = new Rectangle(new Point(useShape.Location.X - s.Width, useShape.Location.Y), s);
            }

            else
            {
                r = new Rectangle(useShape.Location, s);
            }

           //Creating the points for the custom Shape
            PointF point1 = new PointF(r.Location.X , r.Location.Y);
            PointF point2 = new PointF(r.Location.X , r.Location.Y + s.Height);
            PointF point3 = new PointF(r.Location.X +s.Width, r.Location.Y +s.Height);
            PointF point4 = new PointF(r.Location.X +(s.Width/2) , r.Location.Y +(s.Height/2));
            PointF point5 = new PointF(r.Location.X + s.Width, r.Location.Y);
           

            PointF[] CustomPoly = { point1, point2, point3, point4, point5 };
            if (flip)
            {
                CustomPoly[1] = point4;
                CustomPoly[2] = point2;
                CustomPoly[3] = point3;
                
            }
           

            g.FillPolygon(b, CustomPoly, FillMode.Winding);
            g.DrawPolygon(p, CustomPoly);
            this.CurrentShape.DrawingRect = r;
            CurrentShape.CustomDrawingPoly = CustomPoly;

            b.Dispose();
            //g.Dispose();

        }


        //Method used to redraw the old shapes in the panel
        public void printdoc(PaintEventArgs e, Graphics g)
        {

            foreach (Shape myshape in this.MyShapesDoc.DocShapes)
            {
                if (myshape.ShapeType == Shapes.Ellipse)
                {
                    drawEllip(e, myshape, g, true); //Drawing an ellipse

                }
                else if (myshape.ShapeType == Shapes.Rectangle)
                {
                    drawRec(e, myshape, g, true);  //Drawing a rectangle
                }
                else if (myshape.ShapeType == Shapes.Custom)
                {
                    drawCusto(e, myshape, g, true); //Drawing a custom
                }
            } 
            
            
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            this.Invalidate(true);
        }
    }
}
