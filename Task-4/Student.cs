using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Student
    {

        public string Name;
        public int Age;
        public int Grade;


        public string DisplayInfo()
        { 
                return $"Name: {Name} \nAge: {Age} \nGrade: {Grade} \n";
        }


        public Student(string name, int age, int grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }



    }
}
