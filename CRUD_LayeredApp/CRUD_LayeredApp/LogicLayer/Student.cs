using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_LayeredApp.LogicLayer
{
    internal class Student
    { 

        // Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public int StudentNumber { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
        public string Phone { get; set; }

        // Constructors
        public Student(){}
        public Student(int studentNumber, string name, string surname, int age, string course, string phone)
        {
            Name = name;
            Surname = surname;
            StudentNumber = studentNumber;
            Age = age;
            Course = course;
            Phone = phone;
        }
    }
}
