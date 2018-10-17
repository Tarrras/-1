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
        public bool HaveAnimation = false;
        public Points2D[] T_2D;// use for print on screen
        public Points3D[] T_3D; // from file
        public Pair[] T_con; // from file


        Points2D p0 = new Points2D(300, 350);

        public Bitmap bmp;
        public Graphics gr;
        Pen p = new Pen(Color.Blue, 3);
        Pen pMainBlue = new Pen(Color.DarkBlue, 2);
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gr = Graphics.FromImage(bmp);
            EnableGroupsBoxs(false);

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
                        string line = sr.ReadLine();
                        string[] cord = line.Split();
                        T_3D[i] = (new Points3D(int.Parse(cord[0]), int.Parse(cord[1]), int.Parse(cord[2])));
                    }
                    T_con = new Pair[int.Parse(sr.ReadLine())];
                    for (int i = 0; i < T_con.Length; i++)
                    {
                        string line = sr.ReadLine();
                        string[] cord = line.Split();
                        T_con[i] = (new Pair(int.Parse(cord[0]), int.Parse(cord[1])));
                    }
                    EnableGroupsBoxs(true);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("File wasn`t found or some mistakes while reading", "Error");
            }
            Restart();
            ConvertFrom3DTo2D(T_3D, 200);
            DrawLetter();
        }

        public void DrawLetter()
        {
            gr.Clear(Color.Silver);
            gr.DrawLine(p, p0.X, p0.Y, p0.X + 300, p0.Y);
            gr.DrawLine(p, p0.X, p0.Y, p0.X, p0.Y - 300);
            gr.DrawLine(p, p0.X, p0.Y, p0.X - 150, p0.Y + 150);
            lblX.Visible = true;
            lblY.Visible = true;
            lblZ.Visible = true;
            for (int i = 0; i < T_con.Length; i++)
            {
                gr.DrawLine(pMainBlue, T_2D[T_con[i].A].X, T_2D[T_con[i].A].Y, T_2D[T_con[i].B].X, T_2D[T_con[i].B].Y);
            }

            pictureBox1.Image = bmp;
        }

        public void ConvertFrom3DTo2D(Points3D[] points3D, int k)
        {
            T_2D = new Points2D[points3D.Length];
            for (int i = 0; i < T_2D.Length; i++)
            {
                T_2D[i].X = Convert.ToInt32(p0.X + (k * points3D[i].X / (double)(points3D[i].Z + k)));
                T_2D[i].Y = Convert.ToInt32(p0.Y - (k * points3D[i].Y / (double)(points3D[i].Z + k)));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //    btLoadLetter_Click(sender, e);
            this.Width = 920;
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
            if (HaveAnimation == true)
            {
                MessageBox.Show("Now we have active animation");
                return;
            }

            HaveAnimation = true;
            timeToRotate = 0;

            timerRotate.Start();
        }

        int timeToRotate = 0;
        private void timerRotate_Tick(object sender, EventArgs e)
        {

            if (timeToRotate++ > 360)
            {
                HaveAnimation = false;
                timerRotate.Stop();
            }
            if (chbRotateX.Checked)
            {
                for (int i = 0; i < T_3D.Length; i++)
                {
                    T_3D[i].Y = T_3D[i].Y * Math.Cos(Math.PI / 180) - T_3D[i].Z * Math.Sin(Math.PI / 180);
                    T_3D[i].Z = T_3D[i].Y * Math.Sin(Math.PI / 180) + T_3D[i].Z * Math.Cos(Math.PI / 180);
                }
            }
            if (chbRotateY.Checked)
            {
                for (int i = 0; i < T_3D.Length; i++)
                {
                    T_3D[i].X = T_3D[i].X * Math.Cos(Math.PI / 180) + T_3D[i].Z * Math.Sin(Math.PI / 180);
                    T_3D[i].Z = -T_3D[i].X * Math.Sin(Math.PI / 180) + T_3D[i].Z * Math.Cos(Math.PI / 180);
                }
            }
            if (chbRotateZ.Checked)
            {
                for (int i = 0; i < T_3D.Length; i++)
                {
                    T_3D[i].X = T_3D[i].X * Math.Cos(Math.PI / 180) + T_3D[i].Y * Math.Sin(Math.PI / 180);
                    T_3D[i].Y = -T_3D[i].X * Math.Sin(Math.PI / 180) + T_3D[i].Y * Math.Cos(Math.PI / 180);
                }
            }

            ConvertFrom3DTo2D(T_3D, 200);
            if (IsOutOfPicture())
            {
                HaveAnimation = false;
                timerRotate.Stop();
                MessageBox.Show("Out of pictureBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DrawLetter();
            }
        }

        int angleRotate = 0; // на какой угол повернули текущим циклом
        private void timerAngleRotate_Tick(object sender, EventArgs e)
        {
            if (angleRotate > AngleRotX && angleRotate > AngleRotY && angleRotate > AngleRotZ)
            {
                HaveAnimation = false;
                timerAngleRotate.Stop();
            }
            if (angleRotate < AngleRotX) // 
            {
                for (int i = 0; i < T_3D.Length; i++)
                {
                    T_3D[i].Y = T_3D[i].Y * Math.Cos(Math.PI / 180) - T_3D[i].Z * Math.Sin(Math.PI / 180);
                    T_3D[i].Z = T_3D[i].Y * Math.Sin(Math.PI / 180) + T_3D[i].Z * Math.Cos(Math.PI / 180);
                }
            }
            if (angleRotate < AngleRotY)
            {
                for (int i = 0; i < T_3D.Length; i++)
                {
                    T_3D[i].X = T_3D[i].X * Math.Cos(Math.PI / 180) + T_3D[i].Z * Math.Sin(Math.PI / 180);
                    T_3D[i].Z = -T_3D[i].X * Math.Sin(Math.PI / 180) + T_3D[i].Z * Math.Cos(Math.PI / 180);
                }
            }
            if (angleRotate < AngleRotZ)
            {
                for (int i = 0; i < T_3D.Length; i++)
                {
                    T_3D[i].X = T_3D[i].X * Math.Cos(Math.PI / 180) + T_3D[i].Y * Math.Sin(Math.PI / 180);
                    T_3D[i].Y = -T_3D[i].X * Math.Sin(Math.PI / 180) + T_3D[i].Y * Math.Cos(Math.PI / 180);
                }
            }
            ConvertFrom3DTo2D(T_3D, 200);
            if (IsOutOfPicture())
            {
                HaveAnimation = false;
                timerAngleRotate.Stop();
                MessageBox.Show("Out of pictureBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            
            if (HaveAnimation == true)
            {
                MessageBox.Show("Now we have active animation");
                return;
            }

            try
            {
                AngleRotX = Convert.ToInt32(txtAngleRotX.Text);
                AngleRotY = Convert.ToInt32(txtAngleRotY.Text);
                AngleRotZ = Convert.ToInt32(txtAngleRotZ.Text);
                if (AngleRotX < 0 || AngleRotY < 0 || AngleRotZ < 0)
                    throw new FormatException();
                HaveAnimation = true;
                angleRotate = 0;
                timerAngleRotate.Start();

            }
            catch
            {
                MessageBox.Show("U`ve made a mistake in angle to rotate, the angle must be >0 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("U`ve made a mistake in scale parameters, value must be > 0 or < 0 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            ConvertFrom3DTo2D(T_3D, 200);
            if (IsOutOfPicture())
            {
                timerScale2.Stop();
                MessageBox.Show("Out of pictureBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            ConvertFrom3DTo2D(T_3D, 200);
            if (IsOutOfPicture())
            {
                HaveAnimation = false;
                timerScale.Stop();
                MessageBox.Show("Out of pictureBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("U`ve made a mistake in scale parameters, value must be integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    T_3D[i].X = -T_3D[i].X ;
                if (chbReflectOY.Checked)
                    T_3D[i].Y = -T_3D[i].Y ;
                if (chbReflectOZ.Checked)
                    T_3D[i].Z = -T_3D[i].Z ;
            }

            ConvertFrom3DTo2D(T_3D, 200);
            if (IsOutOfPicture())
            {
                HaveAnimation = false;
                reflect.Stop();
                MessageBox.Show("Out of pictureBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DrawLetter();
                reflect.Stop();
            }
        }

        private void btStartTraectory_Click(object sender, EventArgs e)
        {
            if (HaveAnimation == true)
            {
                MessageBox.Show("Now we have active animation");
                return;
            }

            HaveAnimation = true;
            timerTraectory.Start();
        }



        private void chbRotateX_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btStopTraectory_Click(object sender, EventArgs e)
        {
            if (HaveAnimation == true)
            {
                HaveAnimation = false;
                timerTraectory.Stop();
            }
        }
        double t1 = 1, t2 = 1;
        private void timerTraectory_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < T_3D.Length; i++)
            {
                T_3D[i].X += Math.Sin(t1);
                T_3D[i].Y += Math.Cos(t2);
                T_3D[i].Z += Math.Cos(t2+0.2);
                
                DrawLetter();
            }
            t1 += 0.07;
            t2 += 0.03;

            ConvertFrom3DTo2D(T_3D, 200);
            if (IsOutOfPicture())
            {
                HaveAnimation = false;
                timerTraectory.Stop();
                MessageBox.Show("Out of pictureBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
                
            
        }

        public void Copy3DPoints(Points3D[] input, out Points3D[] output)
        {
            output = new Points3D[input.Length];
            for (int i = 0; i < T_3D.Length; i++)
            {
                output[i].X = input[i].X;
                output[i].Y = input[i].Y;
                output[i].Z = input[i].Z;
            }
        }

        public void EnableGroupsBoxs(bool param)
        {
            groupBox1.Enabled = param;
            groupBox2.Enabled = param;
            groupBox3.Enabled = param;
            groupBox4.Enabled = param;
            groupBox5.Enabled = param;
            groupBox6.Enabled = param;

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
            txtScaleOX.Text = "0";
            txtScaleOY.Text = "0";
            txtScaleOZ.Text = "0";
            txtMoveX.Text = "0";
            txtMoveY.Text = "0";
            txtMoveZ.Text = "0";
        }
    }
}
