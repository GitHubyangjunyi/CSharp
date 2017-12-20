using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawPolygon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen myPen = new Pen(Color.Red,2);
            Point[] points1 = { new Point(20, 20), new Point(100, 60), new Point(150, 150), new Point(10, 150) };
            g.DrawPolygon(myPen,points1);
            Brush myBrush = new SolidBrush(Color.Blue);
            Point[] points2 = { new Point(170,20),new Point (230,20),new Point (270,100),new Point (230,200),new Point (170,200)};
            g.FillPolygon(myBrush,points2);
        }
    }
}
