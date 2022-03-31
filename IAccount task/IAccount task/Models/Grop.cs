using System;
using System.Collections.Generic;
using System.Text;

namespace IAccount_task.Models
{
    class Grop
    {
        public string GroupNo { get; set; }
        public int StudentLimit { get; set; }
        private Student[] _stu = new Student[0];
        public Student this[int index]
        {
            get { return _stu[index]; }
            set { _stu[index] = value; }
        }
        public Grop(string groupno, int studentLimit)
        {
            GroupNo = groupno;
            StudentLimit = studentLimit;
        }
        public bool CheckGroupNo(string groupNo)
        {
            bool isUpper1 = false;
            bool isUpper2 = false;
            bool isDigit1 = false;
            bool isDigit2 = false;
            bool isDigit3 = false;

            if (groupNo.Length >= 5)
            {
                if (char.IsUpper(groupNo[0])) isUpper1 = true;
                if (char.IsUpper(groupNo[1])) isUpper2 = true;
                if (char.IsDigit(groupNo[2])) isDigit1 = true;
                if (char.IsDigit(groupNo[3])) isDigit2 = true;
                if (char.IsDigit(groupNo[4])) isDigit3 = true;

                if (isUpper1 && isUpper2 && isDigit1 && isDigit2 && isDigit3)
                    return true;
            }
            return false;

        }

        public void AddStudent(Student student)
        {
            if (_stu.Length < StudentLimit)
            {
                Array.Resize(ref _stu, _stu.Length + 1);
                _stu[_stu.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("limit kecildi");
            }
        }

        public void GetStudent(int? studentId)
        {
            if (studentId !=null)
            {
                foreach (Student student in _stu)
                {
                    if (student.Id==studentId)
                    {
                        Console.WriteLine(student);
                    }

                }
            }
        }
        public void GetAllStudents()
        {
            foreach (var item in _stu)
            {
                Console.WriteLine(item);
            }
        }
    }
} 
        