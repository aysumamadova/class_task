using System;
using System.Collections.Generic;
using System.Text;

namespace IAccount_task.Models
{
    class Student
    {
        private static int _Id = 0;
        private string _Fullname;
        public double Point { get; set; }
        public int Id { get; }

        public string Fullname
        {
            get { return _Fullname; }
            set
            {
                _Fullname = value;
            }
        }
        private Student()
        {
            _Id++;
            Id = _Id;
        }
        public Student(string fullname,double point):this()
        {
            Fullname = fullname;
            Point = point;
        }
        public void StudentInfo()
        {
            Console.WriteLine($" ID->{Id}\n Fullname->{Fullname}\n Point->{Point}\n");
        }
    }
}
