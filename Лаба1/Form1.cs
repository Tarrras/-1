using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба1
{
    public partial class Form1 : Form
    {
        public Points2D[] T_2D;
        public Points3D[] T_3D;
        public Pair[] T_con;
        Points2D start = new Points2D(300, 350);
        public Bitmap myBitmap;
        public Graphics myGraphics;
        Pen penForLine = new Pen(Color.Blue, 3);
        Pen penForPoints = new Pen(Color.DarkBlue, 5);


        public Form1()
        {
            InitializeComponent();
            myBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            myGraphics = Graphics.FromImage(myBitmap);

        }

        private void btLoadLetter_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\T.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    T_3D = new Points3D[int.Parse(sr.ReadLine())];
                    for (int i = 0; i < T_3D.Length; i++)
                    {
                        string[] coordinate = sr.ReadLine().Split();
                        T_3D[i] = (new Points3D(int.Parse(coordinate[0]), int.Parse(coordinate[1]), int.Parse(coordinate[2])));
                    }
                    T_con = new Pair[int.Parse(sr.ReadLine())];
                    for (int i = 0; i < T_con.Length; i++)
                    {
                        string[] coordinate = sr.ReadLine().Split();
                        T_con[i] = (new Pair(int.Parse(coordinate[0]), int.Parse(coordinate[1])));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show( "Error");
            }
            Restart();
            Сonvert2D_3D(T_3D, 200);
            DrawLetter();
        }

        public void DrawLetter()
        {
            myGraphics.Clear(Color.Silver);


            myGraphics.DrawLine(penForLine, start.X, start.Y, start.X + 300, start.Y);
            myGraphics.DrawLine(penForLine, start.X, start.Y, start.X, start.Y - 300);
            myGraphics.DrawLine(penForLine, start.X, start.Y, start.X - 150, start.Y + 150);


            cordX.Visible = true;
            cordY.Visible = true;
            cordZ.Visible = true;


            for (int i = 0; i < T_con.Length; i++)
            {
                myGraphics.DrawLine(penForPoints, T_2D[T_con[i].A].X, T_2D[T_con[i].A].Y, T_2D[T_con[i].B].X, T_2D[T_con[i].B].Y);
            }

            pictureBox1.Image = myBitmap;
        }

        public void Сonvert2D_3D(Points3D[] points3D, int k)
        {
            T_2D = new Points2D[points3D.Length];
            for (int i = 0; i < T_2D.Length; i++)
            {
                T_2D[i].X = Convert.ToInt32(start.X + (k * points3D[i].X / (points3D[i].Z + k)));
                T_2D[i].Y = Convert.ToInt32(start.Y - (k * points3D[i].Y / (points3D[i].Z + k)));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 980;
            this.Height = 620;
        }
        public bool IsOutOfPicture()
        {
            for (int i = 0; i < T_2D.Length; i++)
            {
                if (T_2D[i].X < pictureBox1.Location.X || T_2D[i].Y < pictureBox1.Location.Y
                    || T_2D[i].X > pictureBox1.Location.X + pictureBox1.Width
                    || T_2D[i].Y > pictureBox1.Location.Y + pictureBox1.Height)
                {
                    return true;
                }
            }
            return false;
        }

        private void startRotate_Click(object sender, EventArgs e)
        {
            timeToRotate = 0;
            timerRotate.Start();
        }

        int timeToRotate = 0;
        private void timerRotate_Tick(object sender, EventArgs e)
        {

            if (timeToRotate++ > 360)
            {
                timerRotate.Stop();
            }
            if (chbRotateX.Checked)
            {
                for (int i = 0; i < T_3D.Length; i++)
                {
                    var y= T_3D[i].Y * Math.Cos(Math.PI / 180) - T_3D[i].Z * Math.Sin(Math.PI / 180);
                    var z= T_3D[i].Y * Math.Sin(Math.PI / 180) + T_3D[i].Z * Math.Cos(Math.PI / 180);
                    T_3D[i].Y = y;
                    T_3D[i].Z = z;
                }
            }
            if (chbRotateY.Checked)
            {
                for (int i = 0; i < T_3D.Length; i++)
                {                   
                    var x = T_3D[i].X * Math.Cos(Math.PI / 180) + T_3D[i].Z * Math.Sin(Math.PI / 180);
                    var z= -T_3D[i].X * Math.Sin(Math.PI / 180) + T_3D[i].Z * Math.Cos(Math.PI / 180);
                    T_3D[i].X=x;
                    T_3D[i].Z=z;
                }
            }
            if (chbRotateZ.Checked)
            {
                for (int i = 0; i < T_3D.Length; i++)
                {
                    var x = T_3D[i].X * Math.Cos(Math.PI / 180) + T_3D[i].Y * Math.Sin(Math.PI / 180);
                    var y = -T_3D[i].X * Math.Sin(Math.PI / 180) + T_3D[i].Y * Math.Cos(Math.PI / 180);
                    T_3D[i].X = x;
                    T_3D[i].Y = y;
                }
            }

            Сonvert2D_3D(T_3D, 200);
            if (IsOutOfPicture())
            {
                timerRotate.Stop();
                MessageBox.Show("Out of pictureBox");
            }
            else
            {
                DrawLetter();
            }
        }

        int angleRotate = 0; 
        private void timerAngleRotate_Tick(object sender, EventArgs e)
        {
            if (angleRotate < AngleRotX) 
            {
                for (int i = 0; i < T_3D.Length; i++)
                {
                    var y = T_3D[i].Y * Math.Cos(Math.PI / 180) - T_3D[i].Z * Math.Sin(Math.PI / 180);
                    var z = T_3D[i].Y * Math.Sin(Math.PI / 180) + T_3D[i].Z * Math.Cos(Math.PI / 180);
                    T_3D[i].Y = y;
                    T_3D[i].Z = z;
                }
            }
            if (angleRotate < AngleRotY)
            {
                for (int i = 0; i < T_3D.Length; i++)
                {
                    var x = T_3D[i].X * Math.Cos(Math.PI / 180) + T_3D[i].Z * Math.Sin(Math.PI / 180);
                    var z = -T_3D[i].X * Math.Sin(Math.PI / 180) + T_3D[i].Z * Math.Cos(Math.PI / 180);
                    T_3D[i].X = x;
                    T_3D[i].Z = z;
                }
            }
            if (angleRotate < AngleRotZ)
            {
                for (int i = 0; i < T_3D.Length; i++)
                {
                    var x = T_3D[i].X * Math.Cos(Math.PI / 180) + T_3D[i].Y * Math.Sin(Math.PI / 180);
                    var y = -T_3D[i].X * Math.Sin(Math.PI / 180) + T_3D[i].Y * Math.Cos(Math.PI / 180);
                    T_3D[i].X = x;
                    T_3D[i].Y = y;
                }
            }
            Сonvert2D_3D(T_3D, 200);
            if (IsOutOfPicture())
            {
                timerAngleRotate.Stop();
                MessageBox.Show("Out of pictureBox");
            }
            else
            {
                angleRotate++;
                DrawLetter();
            }
        }

        int AngleRotX = 0, AngleRotY = 0, AngleRotZ = 0;
        private void btAngleRotateGo_Click(object sender, EventArgs e)
        {

            try
            {
                AngleRotX = Convert.ToInt32(txtAngleRotX.Text);
                AngleRotY = Convert.ToInt32(txtAngleRotY.Text);
                AngleRotZ = Convert.ToInt32(txtAngleRotZ.Text);
                if (AngleRotX < 0 || AngleRotY < 0 || AngleRotZ < 0)
                    throw new FormatException();
                angleRotate = 0;
                timerAngleRotate.Start();

            }
            catch
            {
                MessageBox.Show("U`ve made a mistake in angle to rotate, the angle must be >0 ");
            }
        }

        int KofScaleX = 0, KofScaleY = 0, KofScaleZ = 0;
        private void btScale_Click(object sender, EventArgs e)
        {

            try
            {
                KofScaleX = Convert.ToInt32(txtScaleOX.Text);
                KofScaleY = Convert.ToInt32(txtScaleOY.Text);
                KofScaleZ = Convert.ToInt32(txtScaleOZ.Text);
                if (KofScaleX == 0 || KofScaleY == 0 || KofScaleZ == 0)
                    throw new FormatException();

                timerScale2.Start();

            }
            catch
            {
                MessageBox.Show("U`ve made a mistake in scale parameters, value must be > 0 or < 0 ");
            }
        }
        private void timerScale2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < T_3D.Length; i++)
            {
                T_3D[i].X += (T_3D[i].X * (KofScaleX - 1)) ;
                T_3D[i].Y += (T_3D[i].Y * (KofScaleY - 1)) ;
                T_3D[i].Z += (T_3D[i].Z * (KofScaleZ - 1)) ;
            }

            Сonvert2D_3D(T_3D, 200);
            if (IsOutOfPicture())
            {
                timerScale2.Stop();
                MessageBox.Show("Out of pictureBox");
            }
            else
            {               
                DrawLetter();
                timerScale2.Stop();
            }
        }

        private void timerScale_Tick(object sender, EventArgs e)
        {   
            for (int i = 0; i < T_3D.Length; i++)
            {
                T_3D[i].X += MoveX ;
                T_3D[i].Y += MoveY ;
                T_3D[i].Z += MoveZ ;
            }

            Сonvert2D_3D(T_3D, 200);
            if (IsOutOfPicture())
            {
                timerScale.Stop();
                MessageBox.Show("Out of pictureBox");
            }
            else
            {
                DrawLetter();
                timerScale.Stop();
            }

        }


        double MoveX, MoveY, MoveZ;


        private void btnMove_Click(object sender, EventArgs e)
        {
            try
            {
                MoveX = Convert.ToDouble(txtMoveX.Text);
                MoveY = Convert.ToDouble(txtMoveY.Text);
                MoveZ = Convert.ToDouble(txtMoveZ.Text);
                timerScale.Start();
            }
            catch
            {
                MessageBox.Show("U`ve made a mistake in scale parameters, value must be integer");
            }
        }


        private void btnReflect_Click(object sender, EventArgs e)
        {
            reflect.Start();
        }

        private void reflect_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < T_3D.Length; i++)
            {
                if (chbReflectOX.Checked)
                    T_3D[i].Y = -T_3D[i].Y ;
                if (chbReflectOY.Checked)
                    T_3D[i].X = -T_3D[i].X ;
                if (chbReflectOZ.Checked)
                    T_3D[i].Z = -T_3D[i].Z ;
            }

            Сonvert2D_3D(T_3D, 200);
            if (IsOutOfPicture())
            {
                reflect.Stop();
                MessageBox.Show("Out of pictureBox");
            }
            else
            {
                DrawLetter();
                reflect.Stop();
            }
        }

        private void btStartTraectory_Click(object sender, EventArgs e)
        {
            timerTraectory.Start();
        }


        private void btStopTraectory_Click(object sender, EventArgs e)
        {
            timerTraectory.Stop();
        }
        double t1 = 1, t2 = 1;
        private void timerTraectory_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < T_3D.Length; i++)
            {
                T_3D[i].X += Math.Sin(t1);
                T_3D[i].Y += Math.Cos(t2);
                T_3D[i].Z += Math.Tan(t2/t1);               
                DrawLetter();
            }
            t1 += 0.04;
            t2 += 0.04;

            Сonvert2D_3D(T_3D, 200);
            if (IsOutOfPicture())
            {
                timerTraectory.Stop();
                MessageBox.Show("Out of pictureBox", "Error");
            }        
        }

        public void Restart()
        {
            chbReflectOX.Checked = false;
            chbReflectOY.Checked = false;
            chbReflectOZ.Checked = false;
            chbRotateX.Checked = false;
            chbRotateY.Checked = false;
            chbRotateZ.Checked = false;
            txtAngleRotX.Text = "0";
            txtAngleRotY.Text = "0";
            txtAngleRotZ.Text = "0";
            txtScaleOX.Text = "1";
            txtScaleOY.Text = "1";
            txtScaleOZ.Text = "1";
            txtMoveX.Text = "0";
            txtMoveY.Text = "0";
            txtMoveZ.Text = "0";
        }
    }
}
