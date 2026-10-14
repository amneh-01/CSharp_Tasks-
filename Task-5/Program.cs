using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_5
{
    public class Person
    {
        public string Name { get; set; }
        public int Age {  get; set; }
        protected string SchoolName { get; set; }
        private string _internalCode = "INTERNAL-999";

        public Person(string name, int age, string schoolName)
        {
            Name = name;
            Age = age;
            SchoolName = schoolName;
        }
        
        public void DisplayInfo()
        {
            Console.WriteLine($" Name: {Name} , Age:{Age}");

        }

       
    }


    class Student : Person
    {
        public int Grade { get; set; }
        public string StudentId { get; set; }

        public Student(string name, int age, string schoolName, int grade, string studentId) : base(name, age, schoolName)
        {
            Grade = grade;
            StudentId = studentId;
        }
        public void DisplayInfo1()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}, Student ID: {StudentId}, School Name: {SchoolName}");
        }
    

    }

    public class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string schoolName, string subject) : base(name, age, schoolName)
        {
            Subject = subject;
        }
        public void DisplayTeacherInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Subject: {Subject}, School Name: {SchoolName}");

        }



    }


    public sealed class SchoolReport 
    {
        public string ReportTitle { get; set; }
        public SchoolReport(string reportTitle)
        {
            ReportTitle = reportTitle;
        }
        public void DisplayReportTitle()
        {
            Console.WriteLine($"School Report Title: {ReportTitle}");
        }

    }
 
    internal class Program
    {
        static void Main(string[] args)
        {

            Student stu1 = new Student("Ali", 16, "A Academy", 20, "STU-01");
            Student stu2 = new Student("Arwa", 16, "A Academy", 20, "STU-02");
            Student stu3 = new Student("Amjad", 16, "A Academy", 10, "STU-03");

            Teacher T1 = new Teacher("Ahmad", 38, "A Academy", "Math");
            Teacher T2 = new Teacher("Aseel", 48, "A Academy", "English");

            Console.WriteLine("=== Student info ===");
            stu1.DisplayInfo1();
            stu2.DisplayInfo1();
            stu3.DisplayInfo1();

            Console.WriteLine("\n=== Teacher info ===");
            T1.DisplayTeacherInfo();

            Console.WriteLine("\n=== Report ===");
            SchoolReport report = new SchoolReport("Report 2026");
            report.DisplayReportTitle();
        }

    }
    
}
