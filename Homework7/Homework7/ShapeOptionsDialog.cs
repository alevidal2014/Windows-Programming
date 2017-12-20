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

namespace Homework7
{
    public partial class ShapeOptionsDialog : BaseDialog
    {
        // Used to temporarily disable textbox event handlers
        private bool disableEvent; 

        private ToolTip toolTips;
        private BindingList<Shape> shapesDoc;
        private Brush brush;
        private Pen pen;
        Point defaultPosition;
        public event EventHandler ChangesApplied;

        private BindingManagerBase BindingManager
        {
            get { return this.BindingContext[this.shapesDoc]; }
        }

        public ShapeOptionsDialog()
        {
            InitializeComponent();
            defaultPosition = new Point(this.displayPanel.Width / 2, this.displayPanel.Height / 2);

        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            // Create tooltips and set the captions for each control
            toolTips = new ToolTip();
            toolTips.IsBalloon = true;
            toolTips.ToolTipTitle = "Tool Tip";
            toolTips.ToolTipIcon = ToolTipIcon.Info;

            toolTips.SetToolTip(this.POKButton, "Click this to close dialog");
            toolTips.SetToolTip(this.brushColorAButton, "Click this to select the first color for the shape's brush");
            toolTips.SetToolTip(this.brushColorBButton, "Click this to select the second color for the shape's brush");
            toolTips.SetToolTip(this.penColorButton, "Click this to select a color for the shape's pen");
            toolTips.SetToolTip(this.moveFirstButton, "Click this to go to beginning of shapes list");
            toolTips.SetToolTip(this.moveAfterButton, "Click this to go to next shape in list");
            toolTips.SetToolTip(this.moveBeforeButton, "Click this to go to previous shape in list");
            toolTips.SetToolTip(this.moveLastButton, "Click this to go to end of shapes list");

            toolTips.SetToolTip(this.ellipseButton, "Set the shape's form to an Ellipse");
            toolTips.SetToolTip(this.rectangleButton, "Set the shape's form to a Rectangle");
            toolTips.SetToolTip(this.customButton, "Set the shape's form to a Custom Shape");
            toolTips.SetToolTip(this.solidBButton, "Select the shape's brush type to Solid");
            toolTips.SetToolTip(this.hatchedButton, "Select the shape's brush type to Hatched: CheckerBoardStyle");
            toolTips.SetToolTip(this.linearGradientButton, "Select the shape's brush type to Linear Gradient");
            toolTips.SetToolTip(this.solidPButton, "Select the shape's pen type to Solid");
            toolTips.SetToolTip(this.dashedButton, "Select the shape's pen type to Dashed");
            toolTips.SetToolTip(this.compoundButton, "Select the shape's pen type to Compound");

            // TODO: Do this with binding manager instead
            MainForm parent = this.Owner as MainForm;
            shapesDoc = parent.MyShapesDoc.DocShapes;

            updateUI();
        }

        // Update the UI on selected options, show a sample of the Shape's current settings
        private void updateUI()
        {
			
            // temporarily disable event handler for inputs so that they do not recursively call back this function
            disableEvent = true;

            var currentShape = this.BindingManager.Current as Shape;
            this.shapeNameLabel.Text = currentShape.Name;

            if (currentShape.ShapeType == Shapes.Ellipse)
                ellipseButton.Checked = true;
            else if (currentShape.ShapeType == Shapes.Rectangle)
                rectangleButton.Checked = true;
            else
                customButton.Checked = true;

            if (currentShape.BrushType == Brushes.Solid)
            {
                solidBButton.Checked = true;
                brush = new SolidBrush(currentShape.BrushColorA);
            }
            else if (currentShape.BrushType == Brushes.Hatched)
            {
                hatchedButton.Checked = true;
                brush = new HatchBrush(HatchStyle.LargeCheckerBoard, currentShape.BrushColorA, currentShape.BrushColorB);
            }
            else
            {
                linearGradientButton.Checked = true;
                //Rectangle rect = currentShape.DrawingRect;
                Rectangle rect = new Rectangle(defaultPosition.X - currentShape.SSize.Width/2, defaultPosition.Y - currentShape.SSize.Height / 2, 200, 200);
                brush = new LinearGradientBrush(rect, currentShape.BrushColorA, currentShape.BrushColorB, LinearGradientMode.Vertical);
            }

            pen = new Pen(currentShape.PenColor, 5);
            if (currentShape.PenType == Pens.Solid)
            {
                solidPButton.Checked = true;
                pen.DashStyle = DashStyle.Solid;
            }
            else if (currentShape.PenType == Pens.Dashed)
            {
                dashedButton.Checked = true;
                pen.DashStyle = DashStyle.Dash;
            }
            else
            {
                compoundButton.Checked = true;
                pen.CompoundArray = new float[] { 0.0f, 0.2f, 0.8f, 1.0f, };
            }

            disableEvent = false;

            // Invoke Paint Event for display panel
            this.displayPanel.Invalidate();
        }

        // Draw sample shape using brush and pen for selected option
        private void displayPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var currentShape = this.BindingManager.Current as Shape;

            if (currentShape.ShapeType == Shapes.Ellipse)
            {
                if (currentShape.CustomDrawingPoly[0].Y == 0) 
                {
                    addNewPoly(currentShape);
                }
                g.FillEllipse(brush, defaultPosition.X - currentShape.SSize.Width / 2, defaultPosition.Y - currentShape.SSize.Height / 2, currentShape.SSize.Width, currentShape.SSize.Height);
                g.DrawEllipse(pen, defaultPosition.X - currentShape.SSize.Width / 2, defaultPosition.Y - currentShape.SSize.Height / 2, currentShape.SSize.Width, currentShape.SSize.Height);
            }
            else if (currentShape.ShapeType == Shapes.Rectangle)
            {
                if(currentShape.CustomDrawingPoly[0].Y == 0)
                {
                    addNewPoly(currentShape);
                }
                g.FillRectangle(brush, defaultPosition.X - currentShape.SSize.Width / 2, defaultPosition.Y - currentShape.SSize.Height / 2, currentShape.SSize.Width, currentShape.SSize.Height);
                g.DrawRectangle(pen, defaultPosition.X - currentShape.SSize.Width / 2, defaultPosition.Y - currentShape.SSize.Height / 2, currentShape.SSize.Width, currentShape.SSize.Height);
            }
            else
            {
                PointF point1 = new PointF(defaultPosition.X - currentShape.SSize.Width / 2, defaultPosition.Y - currentShape.SSize.Height / 2);
                PointF point2 = new PointF(defaultPosition.X - currentShape.SSize.Width / 2, defaultPosition.Y - currentShape.SSize.Height / 2  + currentShape.SSize.Height);
                PointF point3 = new PointF(defaultPosition.X - currentShape.SSize.Width / 2 + currentShape.SSize.Width, defaultPosition.Y - currentShape.SSize.Height / 2  + currentShape.SSize.Height);
                PointF point4 = new PointF(defaultPosition.X - currentShape.SSize.Width / 2 + (currentShape.SSize.Width / 2), defaultPosition.Y - currentShape.SSize.Height / 2 + (currentShape.SSize.Height / 2));
                PointF point5 = new PointF(defaultPosition.X - currentShape.SSize.Width / 2 + currentShape.SSize.Width, defaultPosition.Y - currentShape.SSize.Height / 2);

               
                PointF[] CustomPoly = { point1, point2, point3, point4, point5 };

                if (currentShape.CustomDrawingPoly[0].X != currentShape.CustomDrawingPoly[1].X)
                {
                    CustomPoly[1] = point4;
                    CustomPoly[2] = point2;
                    CustomPoly[3] = point3;
                    
                }

                g.FillPolygon(brush, CustomPoly, FillMode.Winding);
                g.DrawPolygon(pen, CustomPoly);
            }
            // Clear memory
            brush.Dispose();
            pen.Dispose();
        }

        // OK button click event handler
        private void POKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Event handler for clicking a control using the help cursor
        private void Preferences_HelpRequested(object sender, HelpEventArgs e)
        {

            // Convert screen coordinates to client coordinates
            Point pt = this.PointToClient(e.MousePos);

            // Look for control user clicked on
            Control control = FindChildAtPoint(this, pt);
            if (control == null)
                return;

            // Show help
            string help = this.toolTips.GetToolTip(control);
            if (string.IsNullOrEmpty(help))
                return;
            MessageBox.Show(help, "Help");
            e.Handled = true;
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

        private void ShapeOptionsDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.IsOptionsDialogOpen = false;
        }

        // Button click events to move between shapes

        private void moveFirstButton_Click(object sender, EventArgs e)
        {
            this.BindingManager.Position = 0;
            updateUI();
        }

        private void moveAfterButton_Click(object sender, EventArgs e)
        {
            ++this.BindingManager.Position;
            updateUI();
        }

        private void moveBeforeButton_Click(object sender, EventArgs e)
        {
            --this.BindingManager.Position;
            updateUI();
        }

        private void moveLastButton_Click(object sender, EventArgs e)
        {
            this.BindingManager.Position = this.BindingManager.Count - 1;
            updateUI();
        }

        // Prompt user for new shape brush A color
        private void brushColorButtonA_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            var currentShape = this.BindingManager.Current as Shape;
            if (cdlg.ShowDialog() == DialogResult.OK)
            {
                currentShape.BrushColorA = cdlg.Color;
                updateUI();
            }
        }

        // Prompt user for new shape brush B color
        private void brushColorButtonB_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            var currentShape = this.BindingManager.Current as Shape;
            if (cdlg.ShowDialog() == DialogResult.OK)
            {
                currentShape.BrushColorB = cdlg.Color;
                updateUI();
            }
        }

        // Prompt user for new shape pen color
        private void penColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            var currentShape = this.BindingManager.Current as Shape;
            if (cdlg.ShowDialog() == DialogResult.OK)
            {
                currentShape.PenColor = cdlg.Color;
                updateUI();
            }
        }

        // Radio button click events to modify shape properties

        private void ellipseButton_CheckedChanged(object sender, EventArgs e)
        {

            if (!disableEvent)
            {
                var currentShape = this.BindingManager.Current as Shape;
                currentShape.ShapeType = Shapes.Ellipse;
                updateUI();                
            }
        }

        private void rectangleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                var currentShape = this.BindingManager.Current as Shape;
                currentShape.ShapeType = Shapes.Rectangle;
                updateUI();
            }
        }

        private void customButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                var currentShape = this.BindingManager.Current as Shape;
                currentShape.ShapeType = Shapes.Custom;
                updateUI();
            }
        }

        private void solidBButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                var currentShape = this.BindingManager.Current as Shape;
                currentShape.BrushType = Brushes.Solid;
                updateUI();
            }
        }

        private void hatchedButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                var currentShape = this.BindingManager.Current as Shape;
                currentShape.BrushType = Brushes.Hatched;
                updateUI();
            }
        }

        private void linearGradientButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                var currentShape = this.BindingManager.Current as Shape;
                currentShape.BrushType = Brushes.LinearGradient;
                updateUI();
            }
        }

        private void solidPButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                var currentShape = this.BindingManager.Current as Shape;
                currentShape.PenType = Pens.Solid;
                updateUI();
            }
        }

        private void dashedButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                var currentShape = this.BindingManager.Current as Shape;
                currentShape.PenType = Pens.Dashed;
                updateUI();
            }
        }

        private void compoundButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!disableEvent)
            {
                var currentShape = this.BindingManager.Current as Shape;
                currentShape.PenType = Pens.Compound;
                updateUI();
            }
        }


        private void applyButton_Click(object sender, EventArgs e)
        {
            if(this.ChangesApplied != null)
            {
                ChangesApplied(this, e);
            }

        }
    }
}
