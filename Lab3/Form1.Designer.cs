namespace Lab3
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
            this.label1 = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.surname_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.s_name_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_db = new System.Windows.Forms.DateTimePicker();
            this.pol_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.num_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.form_cb = new System.Windows.Forms.ComboBox();
            this.dolg_cb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ps_tb = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.add_student = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sort_by_date = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.students_by_form = new System.Windows.Forms.Button();
            this.name_er_lb = new System.Windows.Forms.Label();
            this.surname_er_lb = new System.Windows.Forms.Label();
            this.s_name_er_lb = new System.Windows.Forms.Label();
            this.pol_er_lb = new System.Windows.Forms.Label();
            this.num_er_lb = new System.Windows.Forms.Label();
            this.dolg_er_lb = new System.Windows.Forms.Label();
            this.date_er_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(100, 100);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(130, 20);
            this.name_tb.TabIndex = 1;
            // 
            // surname_tb
            // 
            this.surname_tb.Location = new System.Drawing.Point(300, 100);
            this.surname_tb.Name = "surname_tb";
            this.surname_tb.Size = new System.Drawing.Size(130, 20);
            this.surname_tb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // s_name_tb
            // 
            this.s_name_tb.Location = new System.Drawing.Point(500, 100);
            this.s_name_tb.Name = "s_name_tb";
            this.s_name_tb.Size = new System.Drawing.Size(130, 20);
            this.s_name_tb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата рождения";
            // 
            // date_db
            // 
            this.date_db.Location = new System.Drawing.Point(200, 197);
            this.date_db.Name = "date_db";
            this.date_db.Size = new System.Drawing.Size(200, 20);
            this.date_db.TabIndex = 7;
            this.date_db.Value = new System.DateTime(2020, 11, 12, 0, 0, 0, 0);
            // 
            // pol_cb
            // 
            this.pol_cb.FormattingEnabled = true;
            this.pol_cb.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.pol_cb.Location = new System.Drawing.Point(500, 197);
            this.pol_cb.Name = "pol_cb";
            this.pol_cb.Size = new System.Drawing.Size(130, 21);
            this.pol_cb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пол";
            // 
            // num_tb
            // 
            this.num_tb.Location = new System.Drawing.Point(100, 330);
            this.num_tb.Name = "num_tb";
            this.num_tb.Size = new System.Drawing.Size(130, 20);
            this.num_tb.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "№ студенческого билета";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Основа обучения";
            // 
            // form_cb
            // 
            this.form_cb.FormattingEnabled = true;
            this.form_cb.Items.AddRange(new object[] {
            "Бюджетная",
            "Платная"});
            this.form_cb.Location = new System.Drawing.Point(300, 330);
            this.form_cb.Name = "form_cb";
            this.form_cb.Size = new System.Drawing.Size(130, 21);
            this.form_cb.TabIndex = 12;
            // 
            // dolg_cb
            // 
            this.dolg_cb.Location = new System.Drawing.Point(500, 330);
            this.dolg_cb.Name = "dolg_cb";
            this.dolg_cb.Size = new System.Drawing.Size(130, 20);
            this.dolg_cb.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Количество задолжностей";
            // 
            // ps_tb
            // 
            this.ps_tb.Location = new System.Drawing.Point(100, 430);
            this.ps_tb.Name = "ps_tb";
            this.ps_tb.Size = new System.Drawing.Size(330, 100);
            this.ps_tb.TabIndex = 16;
            this.ps_tb.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Примечание";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.No;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(500, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 14);
            this.label10.TabIndex = 18;
            this.label10.Text = "При наличии";
            // 
            // add_student
            // 
            this.add_student.Location = new System.Drawing.Point(100, 560);
            this.add_student.Name = "add_student";
            this.add_student.Size = new System.Drawing.Size(160, 30);
            this.add_student.TabIndex = 19;
            this.add_student.Text = "Добавить студента";
            this.add_student.UseVisualStyleBackColor = true;
            this.add_student.Click += new System.EventHandler(this.add_student_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 630);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 10);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // sort_by_date
            // 
            this.sort_by_date.Location = new System.Drawing.Point(100, 721);
            this.sort_by_date.Name = "sort_by_date";
            this.sort_by_date.Size = new System.Drawing.Size(230, 70);
            this.sort_by_date.TabIndex = 21;
            this.sort_by_date.Text = "Вывести отсортированный по дате рождения(убыванию)\r\nсписок студентов\r\n";
            this.sort_by_date.UseVisualStyleBackColor = true;
            this.sort_by_date.Click += new System.EventHandler(this.sort_by_date_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(240, 660);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(260, 29);
            this.label11.TabIndex = 23;
            this.label11.Text = "Выберете действие";
            // 
            // students_by_form
            // 
            this.students_by_form.Location = new System.Drawing.Point(400, 721);
            this.students_by_form.Name = "students_by_form";
            this.students_by_form.Size = new System.Drawing.Size(230, 70);
            this.students_by_form.TabIndex = 24;
            this.students_by_form.Text = "Вывести всех студентов \r\nна платной форме обучения";
            this.students_by_form.UseVisualStyleBackColor = true;
            this.students_by_form.Click += new System.EventHandler(this.students_by_form_Click);
            // 
            // name_er_lb
            // 
            this.name_er_lb.AutoSize = true;
            this.name_er_lb.ForeColor = System.Drawing.Color.Red;
            this.name_er_lb.Location = new System.Drawing.Point(97, 120);
            this.name_er_lb.Name = "name_er_lb";
            this.name_er_lb.Size = new System.Drawing.Size(162, 13);
            this.name_er_lb.TabIndex = 25;
            this.name_er_lb.Text = "Поле должно быть заполнено!";
            this.name_er_lb.Visible = false;
            // 
            // surname_er_lb
            // 
            this.surname_er_lb.AutoSize = true;
            this.surname_er_lb.ForeColor = System.Drawing.Color.Red;
            this.surname_er_lb.Location = new System.Drawing.Point(297, 120);
            this.surname_er_lb.Name = "surname_er_lb";
            this.surname_er_lb.Size = new System.Drawing.Size(162, 13);
            this.surname_er_lb.TabIndex = 26;
            this.surname_er_lb.Text = "Поле должно быть заполнено!";
            this.surname_er_lb.Visible = false;
            // 
            // s_name_er_lb
            // 
            this.s_name_er_lb.AutoSize = true;
            this.s_name_er_lb.ForeColor = System.Drawing.Color.Red;
            this.s_name_er_lb.Location = new System.Drawing.Point(497, 120);
            this.s_name_er_lb.Name = "s_name_er_lb";
            this.s_name_er_lb.Size = new System.Drawing.Size(162, 13);
            this.s_name_er_lb.TabIndex = 27;
            this.s_name_er_lb.Text = "Поле должно быть заполнено!";
            this.s_name_er_lb.Visible = false;
            // 
            // pol_er_lb
            // 
            this.pol_er_lb.AutoSize = true;
            this.pol_er_lb.ForeColor = System.Drawing.Color.Red;
            this.pol_er_lb.Location = new System.Drawing.Point(497, 220);
            this.pol_er_lb.Name = "pol_er_lb";
            this.pol_er_lb.Size = new System.Drawing.Size(162, 13);
            this.pol_er_lb.TabIndex = 28;
            this.pol_er_lb.Text = "Поле должно быть заполнено!";
            this.pol_er_lb.Visible = false;
            // 
            // num_er_lb
            // 
            this.num_er_lb.AutoSize = true;
            this.num_er_lb.ForeColor = System.Drawing.Color.Red;
            this.num_er_lb.Location = new System.Drawing.Point(97, 353);
            this.num_er_lb.Name = "num_er_lb";
            this.num_er_lb.Size = new System.Drawing.Size(170, 13);
            this.num_er_lb.TabIndex = 29;
            this.num_er_lb.Text = "Поле должно состоять из цифр!";
            this.num_er_lb.Visible = false;
            // 
            // dolg_er_lb
            // 
            this.dolg_er_lb.AutoSize = true;
            this.dolg_er_lb.ForeColor = System.Drawing.Color.Red;
            this.dolg_er_lb.Location = new System.Drawing.Point(500, 353);
            this.dolg_er_lb.Name = "dolg_er_lb";
            this.dolg_er_lb.Size = new System.Drawing.Size(170, 13);
            this.dolg_er_lb.TabIndex = 31;
            this.dolg_er_lb.Text = "Поле должно состоять из цифр!";
            this.dolg_er_lb.Visible = false;
            // 
            // date_er_lb
            // 
            this.date_er_lb.AutoSize = true;
            this.date_er_lb.ForeColor = System.Drawing.Color.Red;
            this.date_er_lb.Location = new System.Drawing.Point(197, 220);
            this.date_er_lb.Name = "date_er_lb";
            this.date_er_lb.Size = new System.Drawing.Size(206, 13);
            this.date_er_lb.TabIndex = 32;
            this.date_er_lb.Text = "Дата не может быть позднее текущей!";
            this.date_er_lb.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 861);
            this.Controls.Add(this.date_er_lb);
            this.Controls.Add(this.dolg_er_lb);
            this.Controls.Add(this.num_er_lb);
            this.Controls.Add(this.pol_er_lb);
            this.Controls.Add(this.s_name_er_lb);
            this.Controls.Add(this.surname_er_lb);
            this.Controls.Add(this.name_er_lb);
            this.Controls.Add(this.students_by_form);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sort_by_date);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.add_student);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ps_tb);
            this.Controls.Add(this.dolg_cb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.form_cb);
            this.Controls.Add(this.num_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pol_cb);
            this.Controls.Add(this.date_db);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.s_name_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surname_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №3, Олейников";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox surname_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox s_name_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_db;
        private System.Windows.Forms.ComboBox pol_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox num_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox form_cb;
        private System.Windows.Forms.TextBox dolg_cb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox ps_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button add_student;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sort_by_date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button students_by_form;
        private System.Windows.Forms.Label name_er_lb;
        private System.Windows.Forms.Label surname_er_lb;
        private System.Windows.Forms.Label s_name_er_lb;
        private System.Windows.Forms.Label pol_er_lb;
        private System.Windows.Forms.Label num_er_lb;
        private System.Windows.Forms.Label dolg_er_lb;
        private System.Windows.Forms.Label date_er_lb;
    }
}

