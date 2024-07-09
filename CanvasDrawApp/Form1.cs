using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Microsoft.Win32;


namespace CanvasDrawApp
{

    public partial class Form1 : Form
    {
        private Point startPoint;
        private Point endPoint;
        private Pen pen;
        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 2);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                endPoint = e.Location;
                panel1.Refresh();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            endPoint = e.Location;
            DrawLine(startPoint, endPoint);
        }

        private void DrawLine(Point startPoint, Point endPoint)
        {
            using (Graphics g = panel1.CreateGraphics())
            {
                g.DrawLine(pen, startPoint, endPoint);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
