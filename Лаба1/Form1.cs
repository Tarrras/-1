using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба1
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Pen penRoad, penCar;
        SolidBrush fon;
        SolidBrush figure;

        public Form1()
        {
            InitializeComponent();
            DrawRoad();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        public void DrawRoad()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bmp);
            penRoad = new Pen(Color.Red);
            graphics.DrawLine(penRoad, pictureBox1.Left, 150, pictureBox1.Right, 150);
            penCar = new Pen(Color.Black);
            graphics.DrawRectangle(penCar, pictureBox1.Left, 100, 100, 50);
            pictureBox1.Image = bmp;
        }


    }
}
