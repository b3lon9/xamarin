using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPjt
{
    class Student
    {
        // 데이터는 손쉽게 접근하지 않도록 수정
        private string  Name;
        private int     Age;
        private string  Major;
        private int     Grade;

        public Student()
        {
            Console.WriteLine("[Student Constructor]");
        }

        public Student(string name, int age, string major, int grade)
        {
            this.Name   = name;
            this.Age    = age;
            this.Major  = major;
            this.Grade  = grade;
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Name : {Name}");
        }

        // Getter&Setter
        public string GetName(string masterId)
        {
            string name = "";
            if (masterId == "admin")
            {
                name = this.Name;
            }
            else
            {
                name = "You Don't have access.";
            }

            return name;
        }

        public string GetMajor(string masterId)
        {
            string major = "";
            if (masterId == "admin")
            {
                major = this.Major;
            }
            else
            {
                major = "You don't have Access";
            }
            return major;
        }
    }
}
