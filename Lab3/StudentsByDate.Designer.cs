namespace Lab3
{
    partial class StudentsByDate
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
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ok = new System.Windows.Forms.Button();
            this.save_changes = new System.Windows.Forms.Button();
            this.delete_ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
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
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 600);
            this.dataGridView1.TabIndex = 0;
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
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(920, 700);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(100, 40);
            this.ok.TabIndex = 1;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // save_changes
            // 
            this.save_changes.Location = new System.Drawing.Point(800, 610);
            this.save_changes.Name = "save_changes";
            this.save_changes.Size = new System.Drawing.Size(100, 40);
            this.save_changes.TabIndex = 2;
            this.save_changes.Text = "Сохранить изменения";
            this.save_changes.UseVisualStyleBackColor = true;
            this.save_changes.Click += new System.EventHandler(this.save_changes_Click);
            // 
            // delete_
            // 
            this.delete_.Location = new System.Drawing.Point(920, 610);
            this.delete_.Name = "delete_";
            this.delete_.Size = new System.Drawing.Size(100, 40);
            this.delete_.TabIndex = 3;
            this.delete_.Text = "Удалить";
            this.delete_.UseVisualStyleBackColor = true;
            this.delete_.Click += new System.EventHandler(this.delete__Click);
            // 
            // StudentsByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 761);
            this.Controls.Add(this.delete_);
            this.Controls.Add(this.save_changes);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentsByDate";
            this.Text = "StudentsByDate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentsByDate_FormClosing);
            this.Load += new System.EventHandler(this.StudentsByDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button save_changes;
        private System.Windows.Forms.Button delete_;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn pol;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolg;
        private System.Windows.Forms.DataGridViewTextBoxColumn form;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps;
    }
}