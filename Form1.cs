using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.Drawing.Drawing2D;

namespace geometry
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        const int PT_RAD = 2;
        const int PT_WID = PT_RAD * 2 + 1;

        private List<PointF> m_Points = new List<PointF>();

        // Draw the polygon.
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            // Draw the points.
            if (m_Points.Count > 0)
            {
                int count = 0;
                foreach (PointF pt in m_Points)
                { count++;
                    e.Graphics.FillRectangle(Brushes.White, pt.X - PT_RAD, pt.Y - PT_RAD, PT_WID, PT_WID);
                    e.Graphics.DrawRectangle(Pens.Black, pt.X - PT_RAD, pt.Y - PT_RAD, PT_WID, PT_WID);
                    e.Graphics.DrawString($"{count}", new Font("Times New Roman", 12, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Black, pt);
                }
            }

            // Enable menu items appropriately.
            EnableMenus();
        }

        // Enable menu items appropriately.
        private void EnableMenus()
        {
            bool enabled = (m_Points.Count >= 3);
            mnuTestsConvex.Enabled = enabled;
            mnuTestsPointInPolygon.Enabled = enabled;
            mnuTestsArea.Enabled = enabled;
            mnuTestsCentroid.Enabled = enabled;
            mnuTestsOrientation.Enabled = enabled;
            mnuTestsTriangulate.Enabled = enabled;
        }

        // Remove all points.
        private void mnuTestsClear_Click(object sender, EventArgs e)
        {
            m_Points = new List<PointF>();
            EnableMenus();
            this.Invalidate();
        }

        // Save a new point.
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            m_Points.Add(new PointF(e.X, e.Y));
            // Redraw.
            this.Invalidate();
        }

        // See if the polygon is convex.
        private void mnuTestsConvex_Click(object sender, EventArgs e)
        {
            // Make a Polygon.
            Polygon pgon = new Polygon(m_Points.ToArray());

            if (pgon.PolygonIsConvex())
            {
                MessageBox.Show("The polygon is convex", "Convex",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The polygon is not convex", "Not Convex",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // See if the mouse's current position is inside the polygon.
        private void mnuTestsPointInPolygon_Click(object sender, EventArgs e)
        {
            // Get the current mouse position.
            Point pt = Cursor.Position;

            // Convert into form coordinates.
            pt = this.PointToClient(pt);

            Rectangle rect = new Rectangle(pt.X - 3, pt.Y - 3, 7, 7);
            using (Graphics gr = this.CreateGraphics())
            {
                // Make a Polygon.
                Polygon pgon = new Polygon(m_Points.ToArray());

                // See if the point is in the polygon.
                if (pgon.PointInPolygon(pt.X, pt.Y))
                {
                    gr.FillEllipse(Brushes.Lime, rect);
                }
                else
                {
                    gr.FillEllipse(Brushes.Red, rect);
                }
                gr.DrawEllipse(Pens.Black, rect);
            }
        }

        // Find the polygon's area.
        private void mnuTestsArea_Click(object sender, EventArgs e)
        {
            // Make a Polygon.
            Polygon pgon = new Polygon(m_Points.ToArray());

            MessageBox.Show("Area: " + pgon.PolygonArea().ToString(), "Area",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Display the centroid.
        private void mnuTestsCentroid_Click(object sender, EventArgs e)
        {
            // Make a Polygon.
            Polygon pgon = new Polygon(m_Points.ToArray());

            PointF pt = pgon.FindCentroid();

            Rectangle rect = new Rectangle((int)pt.X - 3, (int)pt.Y - 3, 7, 7);
            using (Graphics gr = this.CreateGraphics())
            {
                gr.FillEllipse(Brushes.Yellow, rect);
                gr.DrawEllipse(Pens.Black, rect);
            }
        }

        // See if the polygon is oriented clockwise or counterclockwise.
        private void mnuTestsOrientation_Click(object sender, EventArgs e)
        {
            // Make a Polygon.
            Polygon pgon = new Polygon(m_Points.ToArray());

            if (pgon.PolygonIsOrientedClockwise())
            {
                MessageBox.Show("Clockwise", "Clockwise",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Counterclockwise", "Counterclockwise",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<Triangle> triangles;

        // Triangulate the polygon.
        private void mnuTestsTriangulate_Click(object sender, EventArgs e)
        {
            // Make a Polygon.
            Polygon pgon = new Polygon(m_Points.ToArray());
            //if (pgon.PolygonIsConvex())
                // Triangulate.
                triangles = pgon.Triangulate();
            var tri = triangles[0];
            double maxAngle = getAngle(triangles[triangles.Count - 1].Points[2], triangles[0].Points[0], triangles[0].Points[1]);
            for (int i = 0; i < triangles.Count; i++)
                if (getAngle(triangles[i].Points[0], triangles[i].Points[1], triangles[i].Points[2]) > maxAngle)
                {
                    maxAngle = getAngle(triangles[i].Points[0], triangles[i].Points[1], triangles[i].Points[2]);
                    tri = triangles[i];
                }
            // Draw the triangles.
            using (Graphics gr = this.CreateGraphics())
            {

                //gr.DrawPolygon(Pens.Red, tri.Points);
                gr.DrawLine(Pens.Red, tri.Points[0], tri.Points[1]);
               // gr.DrawLine(Pens.Green, tri.Points[2], tri.Points[1]);
                gr.DrawLine(Pens.Black, tri.Points[2], tri.Points[0]);

                // Redraw the polygon. 
                 if (m_Points.Count >= 3)
                  {
                      // Draw the polygon.
                      gr.DrawPolygon(Pens.Blue, m_Points.ToArray());
                  }
            }

        }
        private double getAngle(PointF P1,PointF P2, PointF P3)
        {
            double result = Math.Atan2(P3.Y - P1.Y, P3.X - P1.X) -
                Math.Atan2(P2.Y - P1.Y, P2.X - P1.X);
            return result;
        }
        

        private void btn_add_Click(object sender, EventArgs e)
        {
            string line = textBox1.Text;
            string[] tokens;
            char[] sep = { '\t', ' ', '\r', '\n' };
            tokens = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tokens.Length - 1; i+=2)
                m_Points.Add(new PointF(Convert.ToInt32(tokens[i]), Convert.ToInt32(tokens[i + 1])));
            // Make a Polygon.
            Polygon pgon = new Polygon(m_Points.ToArray());

            FontFamily fontFamily = new FontFamily("Arial");
            
            using (Graphics gr = this.CreateGraphics())
            {
                // Redraw the polygon.
                if (m_Points.Count >= 3)
                {
                    // Draw the polygon.
                    gr.DrawPolygon(Pens.Blue, m_Points.ToArray());
                }
                if (m_Points.Count > 0)
                {
                    foreach (PointF pt in m_Points)
                    {
                        gr.FillRectangle(Brushes.White, pt.X - PT_RAD, pt.Y - PT_RAD, PT_WID, PT_WID);
                        gr.DrawRectangle(Pens.Black, pt.X - PT_RAD, pt.Y - PT_RAD, PT_WID, PT_WID);
                    }
                }
            }
        }

        // Main algorithm:
        public List<PointF> SortByDistance(List<PointF> lst)
        {
            List<PointF> output = new List<PointF>();
            output.Add(lst[NearestPoint(new PointF(0, 0), lst)]);
            lst.Remove(output[0]);
            int x = 0;
            for (int i = 0; i < lst.Count + x; i++)
            {
                output.Add(lst[NearestPoint(output[output.Count - 1], lst)]);
                lst.Remove(output[output.Count - 1]);
                x++;
            }
            return output;
        }

        public int NearestPoint(PointF srcPt, List<PointF> lookIn)
        {
            KeyValuePair<double, int> smallestDistance = new KeyValuePair<double, int>();
            for (int i = 0; i < lookIn.Count; i++)
            {
                double distance = Math.Sqrt(Math.Pow(srcPt.X - lookIn[i].X, 2) + Math.Pow(srcPt.Y - lookIn[i].Y, 2));
                if (i == 0)
                {
                    smallestDistance = new KeyValuePair<double, int>(distance, i);
                }
                else
                {
                    if (distance < smallestDistance.Key)
                    {
                        smallestDistance = new KeyValuePair<double, int>(distance, i);
                    }
                }
            }
            return smallestDistance.Value;
        }

        private double GetDistance(PointF pStart, PointF pFinish)
                {
                    return Math.Sqrt(Math.Pow(pStart.X - pFinish.X, 2) + Math.Pow(pStart.Y - pFinish.Y, 2));
                }

                private void mnuManualPoints_Click(object sender, EventArgs e)
                {
                    textBox1.Visible = true;
                    btn_add.Visible = true;
                }

                private void mnuHide_Click(object sender, EventArgs e)
                {
                    textBox1.Visible = false;
                    btn_add.Visible = false;
                }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            m_Points = SortByDistance(m_Points);
            using (Graphics g = CreateGraphics())
                g.DrawPolygon(new Pen(Color.Blue, 4),m_Points.ToArray());
        }
    }
}
