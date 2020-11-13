namespace Lab3
{
    partial class StudentsByForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ok = new System.Windows.Forms.Button();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.full_name,
            this.num,
            this.pol,
            this.date,
            this.dolg,
            this.form,
            this.ps});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(970, 600);
            this.dataGridView1.TabIndex = 1;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(870, 650);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(100, 40);
            this.ok.TabIndex = 2;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // full_name
            // 
            this.full_name.HeaderText = "ФИО";
            this.full_name.Name = "full_name";
            this.full_name.Width = 200;
            // 
            // num
            // 
            this.num.HeaderText = "№ Cтуденческого";
            this.num.Name = "num";
            // 
            // pol
            // 
            this.pol.HeaderText = "Пол";
            this.pol.Name = "pol";
            // 
            // date
            // 
            this.date.HeaderText = "Дата рождения";
            this.date.Name = "date";
            // 
            // dolg
            // 
            this.dolg.HeaderText = "Задолженности";
            this.dolg.Name = "dolg";
            // 
            // form
            // 
            this.form.HeaderText = "Основа обучения";
            this.form.Name = "form";
            // 
            // ps
            // 
            this.ps.HeaderText = "Примечания";
            this.ps.Name = "ps";
            this.ps.Width = 200;
            // 
            // StudentsByForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentsByForm";
            this.Text = "StudentsByForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentsByForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentsByForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn pol;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolg;
        private System.Windows.Forms.DataGridViewTextBoxColumn form;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps;
    }
}