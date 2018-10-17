namespace Лаба1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btLoadLetter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startRotate = new System.Windows.Forms.Button();
            this.chbRotateZ = new System.Windows.Forms.CheckBox();
            this.chbRotateY = new System.Windows.Forms.CheckBox();
            this.chbRotateX = new System.Windows.Forms.CheckBox();
            this.timerRotate = new System.Windows.Forms.Timer(this.components);
            this.timerAngleRotate = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btAngleRotateGo = new System.Windows.Forms.Button();
            this.txtAngleRotZ = new System.Windows.Forms.TextBox();
            this.txtAngleRotX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAngleRotY = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtScaleOZ = new System.Windows.Forms.TextBox();
            this.txtScaleOY = new System.Windows.Forms.TextBox();
            this.txtScaleOX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btScale = new System.Windows.Forms.Button();
            this.timerScale = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMoveZ = new System.Windows.Forms.TextBox();
            this.txtMoveY = new System.Windows.Forms.TextBox();
            this.txtMoveX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMove = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnReflect = new System.Windows.Forms.Button();
            this.chbReflectOZ = new System.Windows.Forms.CheckBox();
            this.chbReflectOY = new System.Windows.Forms.CheckBox();
            this.chbReflectOX = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btStopTraectory = new System.Windows.Forms.Button();
            this.btStartTraectory = new System.Windows.Forms.Button();
            this.timerTraectory = new System.Windows.Forms.Timer(this.components);
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.timerScale2 = new System.Windows.Forms.Timer(this.components);
            this.reflect = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(608, 561);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btLoadLetter
            // 
            this.btLoadLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btLoadLetter.Location = new System.Drawing.Point(621, 13);
            this.btLoadLetter.Margin = new System.Windows.Forms.Padding(2);
            this.btLoadLetter.Name = "btLoadLetter";
            this.btLoadLetter.Size = new System.Drawing.Size(307, 43);
            this.btLoadLetter.TabIndex = 1;
            this.btLoadLetter.Text = "Load letter";
            this.btLoadLetter.UseVisualStyleBackColor = true;
            this.btLoadLetter.Click += new System.EventHandler(this.btLoadLetter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startRotate);
            this.groupBox1.Controls.Add(this.chbRotateZ);
            this.groupBox1.Controls.Add(this.chbRotateY);
            this.groupBox1.Controls.Add(this.chbRotateX);
            this.groupBox1.Location = new System.Drawing.Point(618, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(310, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rotate";
            // 
            // startRotate
            // 
            this.startRotate.Location = new System.Drawing.Point(0, 42);
            this.startRotate.Margin = new System.Windows.Forms.Padding(2);
            this.startRotate.Name = "startRotate";
            this.startRotate.Size = new System.Drawing.Size(306, 31);
            this.startRotate.TabIndex = 3;
            this.startRotate.Text = "GO";
            this.startRotate.UseVisualStyleBackColor = true;
            this.startRotate.Click += new System.EventHandler(this.startRotate_Click);
            // 
            // chbRotateZ
            // 
            this.chbRotateZ.AutoSize = true;
            this.chbRotateZ.Location = new System.Drawing.Point(273, 21);
            this.chbRotateZ.Margin = new System.Windows.Forms.Padding(2);
            this.chbRotateZ.Name = "chbRotateZ";
            this.chbRotateZ.Size = new System.Drawing.Size(33, 17);
            this.chbRotateZ.TabIndex = 2;
            this.chbRotateZ.Text = "Z";
            this.chbRotateZ.UseVisualStyleBackColor = true;
            // 
            // chbRotateY
            // 
            this.chbRotateY.AutoSize = true;
            this.chbRotateY.Location = new System.Drawing.Point(136, 21);
            this.chbRotateY.Margin = new System.Windows.Forms.Padding(2);
            this.chbRotateY.Name = "chbRotateY";
            this.chbRotateY.Size = new System.Drawing.Size(33, 17);
            this.chbRotateY.TabIndex = 1;
            this.chbRotateY.Text = "Y";
            this.chbRotateY.UseVisualStyleBackColor = true;
            // 
            // chbRotateX
            // 
            this.chbRotateX.AutoSize = true;
            this.chbRotateX.Location = new System.Drawing.Point(4, 21);
            this.chbRotateX.Margin = new System.Windows.Forms.Padding(2);
            this.chbRotateX.Name = "chbRotateX";
            this.chbRotateX.Size = new System.Drawing.Size(33, 17);
            this.chbRotateX.TabIndex = 0;
            this.chbRotateX.Text = "X";
            this.chbRotateX.UseVisualStyleBackColor = true;
            this.chbRotateX.CheckedChanged += new System.EventHandler(this.chbRotateX_CheckedChanged);
            // 
            // timerRotate
            // 
            this.timerRotate.Interval = 15;
            this.timerRotate.Tick += new System.EventHandler(this.timerRotate_Tick);
            // 
            // timerAngleRotate
            // 
            this.timerAngleRotate.Interval = 15;
            this.timerAngleRotate.Tick += new System.EventHandler(this.timerAngleRotate_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btAngleRotateGo);
            this.groupBox2.Controls.Add(this.txtAngleRotZ);
            this.groupBox2.Controls.Add(this.txtAngleRotX);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtAngleRotY);
            this.groupBox2.Location = new System.Drawing.Point(618, 145);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(310, 83);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Angle rotate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "OZ";
            // 
            // btAngleRotateGo
            // 
            this.btAngleRotateGo.Location = new System.Drawing.Point(3, 54);
            this.btAngleRotateGo.Margin = new System.Windows.Forms.Padding(2);
            this.btAngleRotateGo.Name = "btAngleRotateGo";
            this.btAngleRotateGo.Size = new System.Drawing.Size(307, 30);
            this.btAngleRotateGo.TabIndex = 3;
            this.btAngleRotateGo.Text = "GO";
            this.btAngleRotateGo.UseVisualStyleBackColor = true;
            this.btAngleRotateGo.Click += new System.EventHandler(this.btAngleRotateGo_Click);
            // 
            // txtAngleRotZ
            // 
            this.txtAngleRotZ.Location = new System.Drawing.Point(266, 17);
            this.txtAngleRotZ.Margin = new System.Windows.Forms.Padding(2);
            this.txtAngleRotZ.Name = "txtAngleRotZ";
            this.txtAngleRotZ.Size = new System.Drawing.Size(40, 20);
            this.txtAngleRotZ.TabIndex = 9;
            this.txtAngleRotZ.Text = "0";
            // 
            // txtAngleRotX
            // 
            this.txtAngleRotX.Location = new System.Drawing.Point(3, 17);
            this.txtAngleRotX.Margin = new System.Windows.Forms.Padding(2);
            this.txtAngleRotX.Name = "txtAngleRotX";
            this.txtAngleRotX.Size = new System.Drawing.Size(40, 20);
            this.txtAngleRotX.TabIndex = 7;
            this.txtAngleRotX.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "OY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "OX";
            // 
            // txtAngleRotY
            // 
            this.txtAngleRotY.Location = new System.Drawing.Point(136, 17);
            this.txtAngleRotY.Margin = new System.Windows.Forms.Padding(2);
            this.txtAngleRotY.Name = "txtAngleRotY";
            this.txtAngleRotY.Size = new System.Drawing.Size(40, 20);
            this.txtAngleRotY.TabIndex = 8;
            this.txtAngleRotY.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtScaleOZ);
            this.groupBox3.Controls.Add(this.txtScaleOY);
            this.groupBox3.Controls.Add(this.txtScaleOX);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btScale);
            this.groupBox3.Location = new System.Drawing.Point(618, 232);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(310, 87);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "To scale";
            // 
            // txtScaleOZ
            // 
            this.txtScaleOZ.Location = new System.Drawing.Point(266, 17);
            this.txtScaleOZ.Margin = new System.Windows.Forms.Padding(2);
            this.txtScaleOZ.Name = "txtScaleOZ";
            this.txtScaleOZ.Size = new System.Drawing.Size(40, 20);
            this.txtScaleOZ.TabIndex = 9;
            this.txtScaleOZ.Text = "1";
            // 
            // txtScaleOY
            // 
            this.txtScaleOY.Location = new System.Drawing.Point(137, 17);
            this.txtScaleOY.Margin = new System.Windows.Forms.Padding(2);
            this.txtScaleOY.Name = "txtScaleOY";
            this.txtScaleOY.Size = new System.Drawing.Size(40, 20);
            this.txtScaleOY.TabIndex = 8;
            this.txtScaleOY.Text = "1";
            // 
            // txtScaleOX
            // 
            this.txtScaleOX.Location = new System.Drawing.Point(5, 17);
            this.txtScaleOX.Margin = new System.Windows.Forms.Padding(2);
            this.txtScaleOX.Name = "txtScaleOX";
            this.txtScaleOX.Size = new System.Drawing.Size(40, 20);
            this.txtScaleOX.TabIndex = 7;
            this.txtScaleOX.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "OZ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "OY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "OX";
            // 
            // btScale
            // 
            this.btScale.Location = new System.Drawing.Point(4, 58);
            this.btScale.Margin = new System.Windows.Forms.Padding(2);
            this.btScale.Name = "btScale";
            this.btScale.Size = new System.Drawing.Size(306, 29);
            this.btScale.TabIndex = 3;
            this.btScale.Text = "GO";
            this.btScale.UseVisualStyleBackColor = true;
            this.btScale.Click += new System.EventHandler(this.btScale_Click);
            // 
            // timerScale
            // 
            this.timerScale.Interval = 15;
            this.timerScale.Tick += new System.EventHandler(this.timerScale_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMoveZ);
            this.groupBox4.Controls.Add(this.txtMoveY);
            this.groupBox4.Controls.Add(this.txtMoveX);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnMove);
            this.groupBox4.Location = new System.Drawing.Point(618, 323);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(310, 96);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "To move";
            // 
            // txtMoveZ
            // 
            this.txtMoveZ.Location = new System.Drawing.Point(266, 21);
            this.txtMoveZ.Margin = new System.Windows.Forms.Padding(2);
            this.txtMoveZ.Name = "txtMoveZ";
            this.txtMoveZ.Size = new System.Drawing.Size(40, 20);
            this.txtMoveZ.TabIndex = 9;
            this.txtMoveZ.Text = "0";
            // 
            // txtMoveY
            // 
            this.txtMoveY.Location = new System.Drawing.Point(137, 21);
            this.txtMoveY.Margin = new System.Windows.Forms.Padding(2);
            this.txtMoveY.Name = "txtMoveY";
            this.txtMoveY.Size = new System.Drawing.Size(40, 20);
            this.txtMoveY.TabIndex = 8;
            this.txtMoveY.Text = "0";
            // 
            // txtMoveX
            // 
            this.txtMoveX.Location = new System.Drawing.Point(5, 21);
            this.txtMoveX.Margin = new System.Windows.Forms.Padding(2);
            this.txtMoveX.Name = "txtMoveX";
            this.txtMoveX.Size = new System.Drawing.Size(40, 20);
            this.txtMoveX.TabIndex = 7;
            this.txtMoveX.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "deltaZ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "deltaY";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "deltaX";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(0, 61);
            this.btnMove.Margin = new System.Windows.Forms.Padding(2);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(310, 31);
            this.btnMove.TabIndex = 3;
            this.btnMove.Text = "GO";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnReflect);
            this.groupBox5.Controls.Add(this.chbReflectOZ);
            this.groupBox5.Controls.Add(this.chbReflectOY);
            this.groupBox5.Controls.Add(this.chbReflectOX);
            this.groupBox5.Location = new System.Drawing.Point(618, 423);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(310, 91);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reflect";
            // 
            // btnReflect
            // 
            this.btnReflect.Location = new System.Drawing.Point(0, 43);
            this.btnReflect.Margin = new System.Windows.Forms.Padding(2);
            this.btnReflect.Name = "btnReflect";
            this.btnReflect.Size = new System.Drawing.Size(306, 46);
            this.btnReflect.TabIndex = 3;
            this.btnReflect.Text = "GO";
            this.btnReflect.UseVisualStyleBackColor = true;
            this.btnReflect.Click += new System.EventHandler(this.btnReflect_Click);
            // 
            // chbReflectOZ
            // 
            this.chbReflectOZ.AutoSize = true;
            this.chbReflectOZ.Location = new System.Drawing.Point(265, 22);
            this.chbReflectOZ.Margin = new System.Windows.Forms.Padding(2);
            this.chbReflectOZ.Name = "chbReflectOZ";
            this.chbReflectOZ.Size = new System.Drawing.Size(41, 17);
            this.chbReflectOZ.TabIndex = 2;
            this.chbReflectOZ.Text = "OZ";
            this.chbReflectOZ.UseVisualStyleBackColor = true;
            // 
            // chbReflectOY
            // 
            this.chbReflectOY.AutoSize = true;
            this.chbReflectOY.Location = new System.Drawing.Point(137, 22);
            this.chbReflectOY.Margin = new System.Windows.Forms.Padding(2);
            this.chbReflectOY.Name = "chbReflectOY";
            this.chbReflectOY.Size = new System.Drawing.Size(41, 17);
            this.chbReflectOY.TabIndex = 1;
            this.chbReflectOY.Text = "OY";
            this.chbReflectOY.UseVisualStyleBackColor = true;
            // 
            // chbReflectOX
            // 
            this.chbReflectOX.AutoSize = true;
            this.chbReflectOX.Location = new System.Drawing.Point(4, 22);
            this.chbReflectOX.Margin = new System.Windows.Forms.Padding(2);
            this.chbReflectOX.Name = "chbReflectOX";
            this.chbReflectOX.Size = new System.Drawing.Size(41, 17);
            this.chbReflectOX.TabIndex = 0;
            this.chbReflectOX.Text = "OX";
            this.chbReflectOX.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btStopTraectory);
            this.groupBox6.Controls.Add(this.btStartTraectory);
            this.groupBox6.Location = new System.Drawing.Point(618, 516);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(310, 51);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Rotate";
            // 
            // btStopTraectory
            // 
            this.btStopTraectory.Location = new System.Drawing.Point(9, 15);
            this.btStopTraectory.Margin = new System.Windows.Forms.Padding(2);
            this.btStopTraectory.Name = "btStopTraectory";
            this.btStopTraectory.Size = new System.Drawing.Size(142, 23);
            this.btStopTraectory.TabIndex = 4;
            this.btStopTraectory.Text = "STOP";
            this.btStopTraectory.UseVisualStyleBackColor = true;
            this.btStopTraectory.Click += new System.EventHandler(this.btStopTraectory_Click);
            // 
            // btStartTraectory
            // 
            this.btStartTraectory.Location = new System.Drawing.Point(155, 15);
            this.btStartTraectory.Margin = new System.Windows.Forms.Padding(2);
            this.btStartTraectory.Name = "btStartTraectory";
            this.btStartTraectory.Size = new System.Drawing.Size(151, 23);
            this.btStartTraectory.TabIndex = 3;
            this.btStartTraectory.Text = "START";
            this.btStartTraectory.UseVisualStyleBackColor = true;
            this.btStartTraectory.Click += new System.EventHandler(this.btStartTraectory_Click);
            // 
            // timerTraectory
            // 
            this.timerTraectory.Interval = 15;
            this.timerTraectory.Tick += new System.EventHandler(this.timerTraectory_Tick);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.Color.Silver;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblX.Location = new System.Drawing.Point(584, 337);
            this.lblX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 17);
            this.lblX.TabIndex = 8;
            this.lblX.Text = "X";
            this.lblX.Visible = false;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.BackColor = System.Drawing.Color.Silver;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblY.Location = new System.Drawing.Point(286, 55);
            this.lblY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(18, 17);
            this.lblY.TabIndex = 9;
            this.lblY.Text = "Y";
            this.lblY.Visible = false;
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.BackColor = System.Drawing.Color.Silver;
            this.lblZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblZ.Location = new System.Drawing.Point(133, 497);
            this.lblZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(18, 17);
            this.lblZ.TabIndex = 10;
            this.lblZ.Text = "Z";
            this.lblZ.Visible = false;
            // 
            // timerScale2
            // 
            this.timerScale2.Tick += new System.EventHandler(this.timerScale2_Tick);
            // 
            // reflect
            // 
            this.reflect.Tick += new System.EventHandler(this.reflect_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 653);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btLoadLetter);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btLoadLetter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startRotate;
        private System.Windows.Forms.CheckBox chbRotateZ;
        private System.Windows.Forms.CheckBox chbRotateY;
        private System.Windows.Forms.CheckBox chbRotateX;
        private System.Windows.Forms.Timer timerRotate;
        private System.Windows.Forms.Timer timerAngleRotate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAngleRotZ;
        private System.Windows.Forms.TextBox txtAngleRotY;
        private System.Windows.Forms.TextBox txtAngleRotX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAngleRotateGo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtScaleOZ;
        private System.Windows.Forms.TextBox txtScaleOY;
        private System.Windows.Forms.TextBox txtScaleOX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btScale;
        private System.Windows.Forms.Timer timerScale;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMoveZ;
        private System.Windows.Forms.TextBox txtMoveY;
        private System.Windows.Forms.TextBox txtMoveX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnReflect;
        private System.Windows.Forms.CheckBox chbReflectOZ;
        private System.Windows.Forms.CheckBox chbReflectOY;
        private System.Windows.Forms.CheckBox chbReflectOX;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btStartTraectory;
        private System.Windows.Forms.Button btStopTraectory;
        private System.Windows.Forms.Timer timerTraectory;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Timer timerScale2;
        private System.Windows.Forms.Timer reflect;
    }
}

