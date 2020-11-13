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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            form_cb.SelectedItem = "Бюджетная";
            Student.all_students = new Student[20] {
            new Student {
                Surname = "Сидоров", Name="Иван", SName = "Петрович",
                BDateD = 10, BDateM = 10, BDateY = 2000,
                Gender = "Мужской", S_number = 1000, L_base = "Бюджетная",
                Debts = 2, Note = "Состоит в профкоме"
            },
            new Student {
                Surname = "Сидорова", Name="Мария", SName = "Агаповна",
                BDateD = 1, BDateM = 2, BDateY = 2000,
                Gender = "Женский", S_number = 1001, L_base = "Бюджетная",
                Debts = 1, Note = ""
            },
            new Student {
                Surname = "Петров", Name="Женя", SName = "Гаврилов",
                BDateD = 2, BDateM = 1, BDateY = 2000,
                Gender = "Мужской", S_number = 1002, L_base = "Платная",
                Debts = 0, Note = ""
            },
            new Student {
                Surname = "Смирнов", Name="Григорий", SName = "Антонович",
                BDateD = 3, BDateM = 3, BDateY = 2001,
                Gender = "Мужской", S_number = 1003, L_base = "Бюджетная",
                Debts = 0, Note = ""
            },
            new Student {
                Surname = "Филиппов", Name="Сергей", SName = "Юрьевич",
                BDateD = 9, BDateM = 4, BDateY = 2001,
                Gender = "Мужской", S_number = 1004, L_base = "Платная",
                Debts = 2, Note = "Состоит в профкоме"
            },
            new Student {
                Surname = "Сидоров", Name="Олег", SName = "Юрьевич",
                BDateD = 5, BDateM = 1, BDateY = 2000,
                Gender = "Мужской", S_number = 1005, L_base = "Бюджетная",
                Debts = 0, Note = "Состоит в профкоме"
            },
            new Student {
                Surname = "Алексев", Name="Павел", SName = "Антонович",
                BDateD = 6, BDateM = 2, BDateY = 2000,
                Gender = "Мужской", S_number = 1006, L_base = "Бюджетная",
                Debts = 3, Note = ""
            },
            new Student {
                Surname = "Альпиева", Name="Мария", SName = "Андреевна",
                BDateD = 11, BDateM = 9, BDateY = 2000,
                Gender = "Женский", S_number = 1007, L_base = "Бюджетная",
                Debts = 0, Note = ""
            },
            new Student {
                Surname = "Агапова", Name="Юлия", SName = "Сергеевна",
                BDateD = 25, BDateM = 2, BDateY = 2000,
                Gender = "Женский", S_number = 1008, L_base = "Платная",
                Debts = 1, Note = "Староста"
            },
            new Student {
                Surname = "Сидоров", Name="Василий", SName = "Олегович",
                BDateD = 20, BDateM = 6, BDateY = 1999,
                Gender = "Мужской", S_number = 1009, L_base = "Платная",
                Debts = 0, Note = "Олимпиадник"
            },
            null,null,null,null,null,null,null,null,null,null
        };
        }

        private void add_student_Click(object sender, EventArgs e)
        {
            // Проверка на заполнение
            name_er_lb.Visible = name_tb.Text == "" ? true : false;
            surname_er_lb.Visible = surname_tb.Text == "" ? true  : false;
            s_name_er_lb.Visible = s_name_tb.Text == "" ? true : false;
            pol_er_lb.Visible = pol_cb.Text == "" ? true : false;

            // Проверка поля "Долг" на цифры
            int dolg;
            bool isInt = Int32.TryParse(dolg_cb.Text, out dolg);
            dolg_er_lb.Visible = !isInt ? true : false;

            // Проверка даты
            date_er_lb.Visible = date_db.Value > DateTime.Now ? true : false;

            // Проверка номера зачетки
            int num;
            isInt = Int32.TryParse(num_tb.Text, out num); 
            bool check_er = Student.check_uniqueness(num);
            num_er_lb.Text = num_tb.Text == "" ? 
                "Поле должно быть заполнено!" : !check_er ? 
                    "Зачетка с таким номером уже есть в базе" : "Поле должно состоять из цифр!";
            num_er_lb.Visible = !isInt || !check_er || num_tb.Text == "" ? true : false;

            // Добавление студента в группу
            if (!(name_er_lb.Visible || surname_er_lb.Visible || s_name_er_lb.Visible 
                || pol_er_lb.Visible || num_er_lb.Visible || dolg_er_lb.Visible || date_er_lb.Visible)){
                Student.add_new_student(new Student {
                    Surname = surname_tb.Text,
                    Name = name_tb.Text,
                    SName = s_name_tb.Text,
                    BDateD = date_db.Value.Day,
                    BDateM = date_db.Value.Month,
                    BDateY = date_db.Value.Year,
                    Gender = pol_cb.Text,
                    S_number = num,
                    L_base = form_cb.Text,
                    Debts = dolg,
                    Note = ps_tb.Text
            });
                MessageBox.Show("Студент был добавлен!", "Success");
            }
        }

        private void sort_by_date_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentsByDate form = new StudentsByDate(this);
            form.Show();
        }

        private void students_by_form_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentsByForm form = new StudentsByForm(this);
            form.Show();
        }
    }
}
