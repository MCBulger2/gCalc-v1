using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;
using System.Threading;

namespace GraphingCalc
{
    public partial class Form1 : Form
    {
        // Global Variables
        double scaleFactor;
        double maxVal = 50;
        double minVal = -50;
        double maxXDraw;
        double[] origin = { 500, 500 };
        double sampleRate = 0.3;
        bool showGrid = true;
        int gridIncrement = 5;
        int thickness = 4;
        string[] equations = new string[3];
        Color[] palette = { Color.FromArgb(211, 19, 19), Color.FromArgb(19, 108, 211), Color.FromArgb(22, 210, 18) };
        Point lastPoint;
        Point mousePos;

        public Form1()
        {
            InitializeComponent();
            this.MouseWheel += new MouseEventHandler(Zoom);
        }

        private void PaintUpdate(object sender, PaintEventArgs e)
        {
            if (scaleFactor == 0) {
                scaleFactor = 20;
            }

            maxXDraw = 0.75 * this.Width;

            equations[0] = tbInput1.Text;
            equations[1] = tbInput2.Text;
            equations[2] = tbInput3.Text;

            Brush aBrush = (Brush)Brushes.Black;
            Graphics g = this.CreateGraphics();


            GraphAxis();
        }

        public void CalcData()
        {
            double oldSampleRate = sampleRate;

            for (int i = 0; i < equations.Length; i++) {
                for (double x = minVal; x < maxVal; x += sampleRate) {
                    try {
                        if (equations[i] != "") {
                            if (x < 0.3 && x > -0.3) {
                                sampleRate = 0.005;
                            } else {
                                sampleRate = oldSampleRate;
                            }

                            double y = Function(x, equations[i]);
                            if (!Double.IsNaN(y)) {
                                GraphPoint(x, y, i);
                            }   
                        }
                    } catch {

                    }
                } lastPoint = new Point();
            }
        }

        private double Function(double x, string input)
        {
            do {
                input = input.Replace("xx", "x*x");
            } while (input.Contains("xx"));
            input = input.Replace("x", "[x]");
            input = input.Replace("pi", Math.PI.ToString());
            input = input.Replace("e", Math.E.ToString());

            try {
                Expression e = new Expression(input, EvaluateOptions.IgnoreCase);


                if (x == 0) {
                    if (Function(x - 0.001, input) > Function(x - 0.002, input)) {
                        return (double)float.MaxValue;
                    } else {
                        return (double)float.MinValue; ;
                    }
                }

                try {
                    e.Parameters["x"] = x;
                    return Double.Parse(e.Evaluate().ToString());
                } catch (DivideByZeroException) {
                    return 10000;
                } catch {
                    return Double.NaN;
                }
            } catch {
                return Double.NaN;
            }
            
        }

        private void GraphPoint(double x, double y, int i)
        {
            Brush aBrush = new SolidBrush(palette[i]);
            Pen aPen = new Pen(aBrush, thickness);
            Graphics g = this.CreateGraphics();
            double xPrime = (scaleFactor * x) + origin[0];
            double yPrime = (-scaleFactor * y) + origin[1];

            try {
                if (xPrime < maxXDraw) g.FillRectangle(aBrush, (float)xPrime, (float)yPrime, 1, 1);
                else lastPoint = new Point();
            } catch (OverflowException) {
                if (xPrime < maxXDraw) {
                    if (y < 0) {
                        g.FillRectangle(aBrush, (float)xPrime, -1073741760, 1, 1);
                    } else {
                        g.FillRectangle(aBrush, (float)xPrime, 1000000000, 1, 1);
                    }
                } else lastPoint = new Point();
            }
            try {
                if (!lastPoint.IsEmpty || lastPoint.X > xPrime) g.DrawLine(aPen, lastPoint, new Point((int)xPrime, (int)yPrime));
            } catch (OverflowException) {
                
            }

            lastPoint = new Point((int)xPrime, (int)yPrime);
        }

        private void GraphAxis()
        {
            Pen aPen = new Pen(Color.FromArgb(69, 73, 76), thickness);
            Pen bPen = new Pen(Color.FromArgb(69, 73, 76), 1);
            Graphics g = this.CreateGraphics();

            g.DrawLine(aPen, new Point(0, (int)origin[1]), new Point((int)maxXDraw, (int)origin[1]));
            if (origin[0] < maxXDraw) {
                g.DrawLine(aPen, new Point((int)origin[0], 0), new Point((int)origin[0], 1000));
            }

            g.DrawLine(aPen, new Point((int)maxXDraw, 0), new Point((int)maxXDraw, 1000));

            if (showGrid) {
                for (int i = 0; i < maxVal; i += gridIncrement) {
                    if ((int)(origin[0] + (i * scaleFactor)) < maxXDraw) {
                        g.DrawLine(bPen, new Point((int)(origin[0] + (i * scaleFactor)), 0), new Point((int)(origin[0] + (i * scaleFactor)), 1000));
                    }
                    g.DrawLine(bPen, new Point(0, (int)(origin[1] + (i * scaleFactor))), new Point((int)maxXDraw, (int)(origin[1] + (i * scaleFactor))));
                }

                for (int i = 0; i > minVal; i -= gridIncrement) {
                    if ((int)(origin[0] + (i * scaleFactor)) < maxXDraw) {
                        g.DrawLine(bPen, new Point((int)(origin[0] + (i * scaleFactor)), 0), new Point((int)(origin[0] + (i * scaleFactor)), 1000));
                    }
                    g.DrawLine(bPen, new Point(0, (int)(origin[1] + (i * scaleFactor))), new Point((int)maxXDraw, (int)(origin[1] + (i * scaleFactor))));
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos = this.PointToClient(Cursor.Position);
        }

        private void UpdateDraw()
        {
            lastPoint = new Point();
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            GraphAxis();
            CalcData();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            origin[0] += this.PointToClient(Cursor.Position).X - mousePos.X;
            origin[1] += this.PointToClient(Cursor.Position).Y - mousePos.Y;
            UpdateDraw();
        }

        private void Zoom(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0) {
                scaleFactor *= 2;
            } else {
                scaleFactor /= 2;
            }
            
            UpdateDraw();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            maxXDraw = 0.75 * this.Width;
            UpdateDraw();
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            UpdateDraw();
        }
        private void colorSelect(object sender, EventArgs e)
        {
            Button b = sender as Button;
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            palette[int.Parse(b.Tag.ToString())] = color.Color;
            b.BackColor = color.Color;
            UpdateDraw();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnColor1.BackColor = palette[0];
            btnColor2.BackColor = palette[1];
            btnColor3.BackColor = palette[2];

            origin[0] = 0.375 * this.Width;
            origin[1] = 0.5 * this.Height;
        }

        private void nudGridSize_ValueChanged(object sender, EventArgs e)
        {
            if (nudGridSize.Value <= 0) {
                nudGridSize.Value = 1;
            }

            gridIncrement = (int)Math.Floor(nudGridSize.Value);
            UpdateDraw();
        }

        private void cbShowGrid_Click(object sender, EventArgs e)
        {
            if (cbShowGrid.Checked) {
                showGrid = true;
            } else {
                showGrid = false;
            }

            UpdateDraw();
        }

        private void nudThickness_ValueChanged(object sender, EventArgs e)
        {
            thickness = (int)nudThickness.Value;
            nudThickness.Refresh();
            UpdateDraw();
        }

        private void nudSampleRate_ValueChanged(object sender, EventArgs e)
        {
            sampleRate = (double)nudSampleRate.Value;

            nudSampleRate.Refresh();
            UpdateDraw();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            double valAtX = (this.PointToClient(Cursor.Position).X - origin[0]) / scaleFactor;
            double valAtY = Function(valAtX, equations[0]);

            lblX.Text = valAtX.ToString();
            lblY.Text = valAtY.ToString();
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            origin[0] = 0.375 * this.Width;
            origin[1] = 0.5 * this.Height;
            scaleFactor = 20;

            UpdateDraw();
        }

        private void nudRange_ValueChanged(object sender, EventArgs e)
        {
            if (!cbRangeAuto.Checked) {
                maxVal = (int)nudRange.Value;
                minVal = -maxVal;
            }

            UpdateDraw();
        }

        private void autoRange(object sender, EventArgs e)
        {
            if (cbRangeAuto.Checked) {
                maxVal = maxXDraw / scaleFactor;
                minVal = -maxVal;
            } else {
                maxVal = (int)nudRange.Value;
                minVal = -maxVal;
            }
        }
    }
}
