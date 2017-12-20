﻿using ControlLibrary;
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

namespace Homework3
{
    public partial class RectangularChild : BaseForm, ICustomForm
    {
        public int SideMeasure { get { return Height; } }
        public event EventHandler FocusIN;
        public event EventHandler FocusOUT;

        public RectangularChild(int height, float ratio)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Update(height, ratio);
            SetRectangleRegion();
        }


        public void Update(int sideMeasure, float newRatio)
        {
            this.Height = sideMeasure;
            this.Width = (int)(sideMeasure * newRatio);
        }

        private void SetRectangleRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddRectangle(this.ClientRectangle);
                this.Region = new Region(path);
            }
        }

        private void RectangularChild_Leave(object sender, EventArgs e)
        {
            this.FocusOUT(this, EventArgs.Empty);
        }

        private void RectangularChild_Enter(object sender, EventArgs e)
        {
            this.FocusIN(this, EventArgs.Empty);
        }
    }
}