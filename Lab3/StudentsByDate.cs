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
    public partial class StudentsByDate : Form
    {
        Form1 parent;
        public StudentsByDate(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void StudentsByDate_Load(object sender, EventArgs e)
        {
            foreach (Student student in Student.sorted_students_by_date()) {

                // Встроенная функция у dataGrid работать не будет для дат
                // dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);

                if (!(student is null)) {
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
            dataGridView1.Rows.Clear();
            this.parent.Show();
            this.Close();
        }

        private void StudentsByDate_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridView1.Rows.Clear();
            this.parent.Show();
        }

        private void delete__Click(object sender, EventArgs e)
        {
            int curruentRow = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[curruentRow];
            dataGridView1.Rows.Remove(dataGridView1.Rows[curruentRow]);
            Student.delete_student(curruentRow);
            //MessageBox.Show(curruentRow.ToString());
        }

        private void save_changes_Click(object sender, EventArgs e)
        {
            List<Student> scan = new List<Student>();
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Student tmp = new Student();
                int i = 0;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (!(cell.Value is null))
                    {
                        string value = cell.Value.ToString();
                        switch (i)
                        {
                            case 0:
                                String[] words = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                tmp.Surname = words[0];
                                tmp.Name = words[1];
                                tmp.SName = words[2];
                                break;
                            case 1:
                                tmp.S_number = int.Parse(value);
                                break;
                            case 2:
                                tmp.Gender = value;
                                break;
                            case 3:
                                String[] nums = value.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                                tmp.BDateD = int.Parse(nums[0]);
                                tmp.BDateM = int.Parse(nums[1]);
                                tmp.BDateY = int.Parse(nums[2]);
                                break;
                            case 4:
                                tmp.Debts = int.Parse(value);
                                break;
                            case 5:
                                tmp.L_base = value;
                                break;
                            case 6:
                                tmp.Note = value;
                                break;
                        }
                    }
                    //else break;
                    i++;
                }
                scan.Add(tmp);
            }
            for (int j = 0; j < 19; j++) {
                foreach(Student new_student in scan)
                {
                    if (!(Student.all_students[j] is null)){
                        if (Student.all_students[j].S_number == new_student.S_number)
                        {
                            Student.all_students[j] = new_student;
                        }
                    }
                }
            }
            MessageBox.Show("Изменения сохранены", "Success");
        }
    }
}
