using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Student
    {
        public string Surname;
        public string Name;
        public string SName;
        public int BDateD;
        public int BDateM;
        public int BDateY;
        public string Gender;
        public int S_number;
        public string L_base;
        public int Debts;
        public string Note;
        static public Student[] all_students;


        // Метод проверки номера зачетки на уникальность
        static public bool check_uniqueness(int num){
            foreach (Student student in Student.all_students) {
                if (!(student is null) && num == student.S_number) return false;
            }
            return true;
        }

        // Метод добавляет нового студента в группу
        static public void add_new_student(Student student)
        {
            for (int i = 0; i < 20; i++)
            {
                if (Student.all_students[i] is null)
                {
                    Student.all_students[i] = student;
                    break;
                };
            }
        }


        // Метод удаляет студента
        static public void delete_student(int i)
        {
            for (int j = 0; j < 19; j++) {
                if(Student.all_students[j] == Student.sorted_students_by_date()[i])
                {
                    Student.all_students[j] = null;
                    break;
                }
            }
                
            // Сдвиг массива
            Student tmp;
            for(int k = 0; k < 19; k++)
            {
                if (Student.all_students[k] is null && !(Student.all_students[k+1] is null)) {
                    tmp = Student.all_students[k];
                    Student.all_students[k] = Student.all_students[k + 1];
                    Student.all_students[k + 1] = tmp;
                }
            }
        }

        // Список студентов на платной форме обучения
        static public Student[] students_by_form() {
            Student[] tmp = new Student[20];
            int i = 0;

            foreach (Student student in Student.all_students) {
                if (!(student is null)) {
                    if (student.L_base == "Платная"){
                        tmp[i] = student;
                        i++;
                    }
                }   
            }
            return tmp;
        }

        // Отсортированный список студентов по дню рождения
        static public Student[] sorted_students_by_date() {
            Student[] tmp = new Student[20];

            SortedDictionary<int, Student> sorted_list = new SortedDictionary<int, Student>();
            foreach (Student student in Student.all_students) {
                if (!(student is null)) sorted_list.Add(student.BDateD + student.BDateM*30 + student.BDateY*365, student);
            }

            int i = 0;
            foreach (Student student in sorted_list.Values) {
                tmp[i] = student;
                i++;
            }
            return tmp;
        }
    }

   
}

