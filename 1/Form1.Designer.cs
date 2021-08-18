namespace _3
{
    partial class frmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtTemperatureWork = new System.Windows.Forms.TextBox();
            this.txtAlfaWork = new System.Windows.Forms.TextBox();
            this.txtLambda1 = new System.Windows.Forms.TextBox();
            this.txtThickness1 = new System.Windows.Forms.TextBox();
            this.txtTemperatureExternal = new System.Windows.Forms.TextBox();
            this.txtAlfaExternal = new System.Windows.Forms.TextBox();
            this.txtGetQ = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThickness2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLambda2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAlfaWork = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGetRWork = new System.Windows.Forms.TextBox();
            this.txtGetRWall = new System.Windows.Forms.TextBox();
            this.txtGetRExternal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(896, 485);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTemperatureWork
            // 
            this.txtTemperatureWork.Location = new System.Drawing.Point(567, 30);
            this.txtTemperatureWork.Margin = new System.Windows.Forms.Padding(2);
            this.txtTemperatureWork.Name = "txtTemperatureWork";
            this.txtTemperatureWork.Size = new System.Drawing.Size(200, 20);
            this.txtTemperatureWork.TabIndex = 1;
            this.txtTemperatureWork.TextChanged += new System.EventHandler(this.ClearResult_TextChanged);
            this.txtTemperatureWork.Enter += new System.EventHandler(this.txtTemperatureWork_Enter);
            this.txtTemperatureWork.Validating += new System.ComponentModel.CancelEventHandler(this.txtTemperatureWork_Validating);
            // 
            // txtAlfaWork
            // 
            this.txtAlfaWork.Location = new System.Drawing.Point(567, 64);
            this.txtAlfaWork.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlfaWork.Name = "txtAlfaWork";
            this.txtAlfaWork.Size = new System.Drawing.Size(200, 20);
            this.txtAlfaWork.TabIndex = 2;
            this.txtAlfaWork.TextChanged += new System.EventHandler(this.ClearResult_TextChanged);
            this.txtAlfaWork.Enter += new System.EventHandler(this.txtAlfaWork_Enter);
            this.txtAlfaWork.Validating += new System.ComponentModel.CancelEventHandler(this.txtAlfaWork_Validating);
            // 
            // txtLambda1
            // 
            this.txtLambda1.Location = new System.Drawing.Point(567, 98);
            this.txtLambda1.Margin = new System.Windows.Forms.Padding(2);
            this.txtLambda1.Name = "txtLambda1";
            this.txtLambda1.Size = new System.Drawing.Size(200, 20);
            this.txtLambda1.TabIndex = 3;
            this.txtLambda1.TextChanged += new System.EventHandler(this.ClearResult_TextChanged);
            this.txtLambda1.Enter += new System.EventHandler(this.txtLambda_Enter);
            this.txtLambda1.Validating += new System.ComponentModel.CancelEventHandler(this.txtLambda_Validating);
            // 
            // txtThickness1
            // 
            this.txtThickness1.Location = new System.Drawing.Point(567, 157);
            this.txtThickness1.Margin = new System.Windows.Forms.Padding(2);
            this.txtThickness1.Name = "txtThickness1";
            this.txtThickness1.Size = new System.Drawing.Size(200, 20);
            this.txtThickness1.TabIndex = 4;
            this.txtThickness1.TextChanged += new System.EventHandler(this.ClearResult_TextChanged);
            this.txtThickness1.Enter += new System.EventHandler(this.txtThickness_Enter);
            this.txtThickness1.Validating += new System.ComponentModel.CancelEventHandler(this.txtThickness_Validating);
            // 
            // txtTemperatureExternal
            // 
            this.txtTemperatureExternal.Location = new System.Drawing.Point(567, 212);
            this.txtTemperatureExternal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTemperatureExternal.Name = "txtTemperatureExternal";
            this.txtTemperatureExternal.Size = new System.Drawing.Size(200, 20);
            this.txtTemperatureExternal.TabIndex = 4;
            this.txtTemperatureExternal.TextChanged += new System.EventHandler(this.ClearResult_TextChanged);
            this.txtTemperatureExternal.Enter += new System.EventHandler(this.txtTemperatureExternal_Enter);
            this.txtTemperatureExternal.Validating += new System.ComponentModel.CancelEventHandler(this.txtTemperatureExternal_Validating);
            // 
            // txtAlfaExternal
            // 
            this.txtAlfaExternal.Location = new System.Drawing.Point(567, 237);
            this.txtAlfaExternal.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlfaExternal.Name = "txtAlfaExternal";
            this.txtAlfaExternal.Size = new System.Drawing.Size(200, 20);
            this.txtAlfaExternal.TabIndex = 4;
            this.txtAlfaExternal.TextChanged += new System.EventHandler(this.ClearResult_TextChanged);
            this.txtAlfaExternal.Enter += new System.EventHandler(this.txtAlfaExternal_Enter);
            this.txtAlfaExternal.Validating += new System.ComponentModel.CancelEventHandler(this.txtAlfaExternal_Validating);
            // 
            // txtGetQ
            // 
            this.txtGetQ.Location = new System.Drawing.Point(494, 18);
            this.txtGetQ.Margin = new System.Windows.Forms.Padding(2);
            this.txtGetQ.Name = "txtGetQ";
            this.txtGetQ.ReadOnly = true;
            this.txtGetQ.Size = new System.Drawing.Size(156, 20);
            this.txtGetQ.TabIndex = 4;
            this.txtGetQ.TextChanged += new System.EventHandler(this.txtGetQ_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(727, 485);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Рассчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtThickness2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtLambda2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblAlfaWork);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAlfaExternal);
            this.groupBox1.Controls.Add(this.txtLambda1);
            this.groupBox1.Controls.Add(this.txtTemperatureExternal);
            this.groupBox1.Controls.Add(this.txtThickness1);
            this.groupBox1.Controls.Add(this.txtAlfaWork);
            this.groupBox1.Controls.Add(this.txtTemperatureWork);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(777, 320);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные данные";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtThickness2
            // 
            this.txtThickness2.Location = new System.Drawing.Point(567, 187);
            this.txtThickness2.Name = "txtThickness2";
            this.txtThickness2.Size = new System.Drawing.Size(200, 20);
            this.txtThickness2.TabIndex = 12;
            this.txtThickness2.TextChanged += new System.EventHandler(this.ClearResult_TextChanged);
            this.txtThickness2.Validating += new System.ComponentModel.CancelEventHandler(this.txtThickness2_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Толщина второй огнеупорной стенки, м";
            // 
            // txtLambda2
            // 
            this.txtLambda2.Location = new System.Drawing.Point(567, 128);
            this.txtLambda2.Name = "txtLambda2";
            this.txtLambda2.Size = new System.Drawing.Size(200, 20);
            this.txtLambda2.TabIndex = 10;
            this.txtLambda2.TextChanged += new System.EventHandler(this.ClearResult_TextChanged);
            this.txtLambda2.Validating += new System.ComponentModel.CancelEventHandler(this.txtLambda2_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(364, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Коэффициент теплопроводности второй огнеупорной стенки, Вт/(м К)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(478, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Коэффициент теплоотдачи от наружной поверхности стенки к окружающей среде, Вт/(м2" +
    " К)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Температура наружной (окружающей) среды, К";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Толщина первой огнеупорной стенки, м";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Коэффициент теплопроводности первой огнеупорной стенки, Вт/(м К)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAlfaWork
            // 
            this.lblAlfaWork.AutoSize = true;
            this.lblAlfaWork.Location = new System.Drawing.Point(2, 64);
            this.lblAlfaWork.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlfaWork.Name = "lblAlfaWork";
            this.lblAlfaWork.Size = new System.Drawing.Size(464, 13);
            this.lblAlfaWork.TabIndex = 8;
            this.lblAlfaWork.Text = "Коэффициент теплоотдачи от рабочей среды к внутренней поверхности стенки, Вт/(м2 " +
    "К)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Температура рабочей среды в печи, K";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtGetRWork);
            this.groupBox2.Controls.Add(this.txtGetRWall);
            this.groupBox2.Controls.Add(this.txtGetRExternal);
            this.groupBox2.Controls.Add(this.txtGetQ);
            this.groupBox2.Location = new System.Drawing.Point(14, 347);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(657, 143);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результаты";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 119);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(364, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Расчёт плотности теплового потока через огнеупорную стенку, Вт/м2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(301, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "Расчёт теплового сопротивления при передачи теплоты\r\nот стенки печи к наружной (о" +
    "кружающий) среде, (м2К)/Вт";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(332, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Расчёт теплового сопротивления огнеупорной стенки, (м2К)/Вт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Расчёт теплового сопротивления при предачи теплоты от рабочей среды стенки печи, " +
    "(м2К)/Вт";
            // 
            // txtGetRWork
            // 
            this.txtGetRWork.Location = new System.Drawing.Point(494, 50);
            this.txtGetRWork.Margin = new System.Windows.Forms.Padding(2);
            this.txtGetRWork.Name = "txtGetRWork";
            this.txtGetRWork.ReadOnly = true;
            this.txtGetRWork.Size = new System.Drawing.Size(156, 20);
            this.txtGetRWork.TabIndex = 4;
            this.txtGetRWork.TextChanged += new System.EventHandler(this.txtGetRWork_TextChanged);
            // 
            // txtGetRWall
            // 
            this.txtGetRWall.Location = new System.Drawing.Point(494, 115);
            this.txtGetRWall.Margin = new System.Windows.Forms.Padding(2);
            this.txtGetRWall.Name = "txtGetRWall";
            this.txtGetRWall.ReadOnly = true;
            this.txtGetRWall.Size = new System.Drawing.Size(156, 20);
            this.txtGetRWall.TabIndex = 4;
            // 
            // txtGetRExternal
            // 
            this.txtGetRExternal.Location = new System.Drawing.Point(494, 82);
            this.txtGetRExternal.Margin = new System.Windows.Forms.Padding(2);
            this.txtGetRExternal.Name = "txtGetRExternal";
            this.txtGetRExternal.ReadOnly = true;
            this.txtGetRExternal.Size = new System.Drawing.Size(156, 20);
            this.txtGetRExternal.TabIndex = 4;
            this.txtGetRExternal.TextChanged += new System.EventHandler(this.txtGetRExternal_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_2.Properties.Resources.Рис__Постановка_задачи_к_ЛР_2;
            this.pictureBox1.Location = new System.Drawing.Point(823, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnForm
            // 
            this.btnForm.Location = new System.Drawing.Point(891, 446);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(135, 33);
            this.btnForm.TabIndex = 9;
            this.btnForm.Text = "График";
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 532);
            this.Controls.Add(this.btnForm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Рассчёт теплообмена через плоскую стенку";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTemperatureWork;
        private System.Windows.Forms.TextBox txtAlfaWork;
        private System.Windows.Forms.TextBox txtLambda1;
        private System.Windows.Forms.TextBox txtThickness1;
        private System.Windows.Forms.TextBox txtTemperatureExternal;
        private System.Windows.Forms.TextBox txtAlfaExternal;
        private System.Windows.Forms.TextBox txtGetQ;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAlfaWork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGetRWork;
        private System.Windows.Forms.TextBox txtGetRWall;
        private System.Windows.Forms.TextBox txtGetRExternal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLambda2;
        private System.Windows.Forms.TextBox txtThickness2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnForm;
    }
}

