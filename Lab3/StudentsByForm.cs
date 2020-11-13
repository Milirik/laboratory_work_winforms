using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class StudentsByForm : Form
    {
        Form1 parent;
        public StudentsByForm(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void StudentsByForm_Load(object sender, EventArgs e)
        {
            foreach (Student student in Student.students_by_form())
            {

                if (!(student is null))
                {
                    dataGridView1.Rows.Add(
                        student.Surname + " " + student.Name + " " + student.SName,
                        student.S_number.ToString(),
                        student.Gender,
                        student.BDateD + "." + student.BDateM + "." + student.BDateY,
                        student.Debts,
                        student.L_base,
                        student.Note
                    );
                }
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Close();
        }

        private void StudentsByForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parent.Show();
        }

        
    }
}
