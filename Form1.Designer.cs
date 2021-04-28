namespace geometry
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuTests = new System.Windows.Forms.MenuItem();
            this.mnuTestsClear = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuManualPoints = new System.Windows.Forms.MenuItem();
            this.mnuHide = new System.Windows.Forms.MenuItem();
            this.mnuTestsConvex = new System.Windows.Forms.MenuItem();
            this.mnuTestsPointInPolygon = new System.Windows.Forms.MenuItem();
            this.mnuTestsArea = new System.Windows.Forms.MenuItem();
            this.mnuTestsCentroid = new System.Windows.Forms.MenuItem();
            this.mnuTestsOrientation = new System.Windows.Forms.MenuItem();
            this.mnuTestsTriangulate = new System.Windows.Forms.MenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // MainMenu1
            // 
            this.MainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuTests});
            // 
            // mnuTests
            // 
            this.mnuTests.Index = 0;
            this.mnuTests.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuTestsClear,
            this.menuItem1,
            this.menuItem2,
            this.mnuManualPoints,
            this.mnuHide,
            this.mnuTestsConvex,
            this.mnuTestsPointInPolygon,
            this.mnuTestsArea,
            this.mnuTestsCentroid,
            this.mnuTestsOrientation,
            this.mnuTestsTriangulate});
            this.mnuTests.Text = "Menu";
            // 
            // mnuTestsClear
            // 
            this.mnuTestsClear.Index = 0;
            this.mnuTestsClear.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.mnuTestsClear.Text = "Clear";
            this.mnuTestsClear.Click += new System.EventHandler(this.mnuTestsClear_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.Text = "-";
            // 
            // mnuManualPoints
            // 
            this.mnuManualPoints.Index = 3;
            this.mnuManualPoints.Text = "Add Points Manualy";
            this.mnuManualPoints.Click += new System.EventHandler(this.mnuManualPoints_Click);
            // 
            // mnuHide
            // 
            this.mnuHide.Index = 4;
            this.mnuHide.Text = "Hide";
            this.mnuHide.Click += new System.EventHandler(this.mnuHide_Click);
            // 
            // mnuTestsConvex
            // 
            this.mnuTestsConvex.Enabled = false;
            this.mnuTestsConvex.Index = 5;
            this.mnuTestsConvex.Shortcut = System.Windows.Forms.Shortcut.F2;
            this.mnuTestsConvex.Text = "&Convex";
            this.mnuTestsConvex.Click += new System.EventHandler(this.mnuTestsConvex_Click);
            // 
            // mnuTestsPointInPolygon
            // 
            this.mnuTestsPointInPolygon.Enabled = false;
            this.mnuTestsPointInPolygon.Index = 6;
            this.mnuTestsPointInPolygon.Shortcut = System.Windows.Forms.Shortcut.F3;
            this.mnuTestsPointInPolygon.Text = "&Point in Polygon";
            this.mnuTestsPointInPolygon.Click += new System.EventHandler(this.mnuTestsPointInPolygon_Click);
            // 
            // mnuTestsArea
            // 
            this.mnuTestsArea.Enabled = false;
            this.mnuTestsArea.Index = 7;
            this.mnuTestsArea.Shortcut = System.Windows.Forms.Shortcut.F4;
            this.mnuTestsArea.Text = "&Area";
            this.mnuTestsArea.Click += new System.EventHandler(this.mnuTestsArea_Click);
            // 
            // mnuTestsCentroid
            // 
            this.mnuTestsCentroid.Enabled = false;
            this.mnuTestsCentroid.Index = 8;
            this.mnuTestsCentroid.Shortcut = System.Windows.Forms.Shortcut.F5;
            this.mnuTestsCentroid.Text = "Centroi&d";
            this.mnuTestsCentroid.Click += new System.EventHandler(this.mnuTestsCentroid_Click);
            // 
            // mnuTestsOrientation
            // 
            this.mnuTestsOrientation.Enabled = false;
            this.mnuTestsOrientation.Index = 9;
            this.mnuTestsOrientation.Shortcut = System.Windows.Forms.Shortcut.F6;
            this.mnuTestsOrientation.Text = "&Orientation";
            this.mnuTestsOrientation.Click += new System.EventHandler(this.mnuTestsOrientation_Click);
            // 
            // mnuTestsTriangulate
            // 
            this.mnuTestsTriangulate.Enabled = false;
            this.mnuTestsTriangulate.Index = 10;
            this.mnuTestsTriangulate.Shortcut = System.Windows.Forms.Shortcut.F7;
            this.mnuTestsTriangulate.Text = "&Triangulate";
            this.mnuTestsTriangulate.Click += new System.EventHandler(this.mnuTestsTriangulate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(812, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 169);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Type in here points";
            this.textBox1.Visible = false;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(812, 209);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(72, 26);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Visible = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.menuItem2.Text = "Draw";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(896, 588);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.textBox1);
            this.Menu = this.MainMenu1;
            this.Name = "Form1";
            this.Text = "Triangularea si aria unui poligon";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MainMenu MainMenu1;
        internal System.Windows.Forms.MenuItem mnuTests;
        private System.Windows.Forms.MenuItem mnuTestsClear;
        private System.Windows.Forms.MenuItem menuItem1;
        internal System.Windows.Forms.MenuItem mnuTestsConvex;
        internal System.Windows.Forms.MenuItem mnuTestsPointInPolygon;
        internal System.Windows.Forms.MenuItem mnuTestsArea;
        internal System.Windows.Forms.MenuItem mnuTestsCentroid;
        internal System.Windows.Forms.MenuItem mnuTestsOrientation;
        internal System.Windows.Forms.MenuItem mnuTestsTriangulate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.MenuItem mnuManualPoints;
        private System.Windows.Forms.MenuItem mnuHide;
        private System.Windows.Forms.MenuItem menuItem2;
    }
}

