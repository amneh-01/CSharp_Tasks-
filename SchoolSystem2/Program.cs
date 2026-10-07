using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolSystem2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name :");
            string studentName = Console.ReadLine();
            Console.WriteLine("Enter your age :");
            int studentAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your grade :");
            int studentGrade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Average :");
            double studentAverage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your gender :");
            string studentGender = Console.ReadLine();

            Console.WriteLine("\n-------------------------------------------------------------------\n");
            Console.WriteLine("===== Student Information ===== \n" +
                                 "Name:" + studentName + "\n" +
                                 "Age:" + studentAge + "\n" +
                                 "Grade:" + studentGrade + "\n" +
                                 "Average:" + studentAverage + "\n" +
                                 "Gender:" + studentGender );

            Console.WriteLine("\n-------------------------------------------------------------------\n");
            Console.WriteLine("===== Name Information  ===== \n" +
                                "Original Name: " + studentName + "\n" +
                                "Uppercase: " + studentName.ToUpper() + "\n" +
                                "Lowercase: " + studentName.ToLower() + "\n" +
                                "First Character: " + studentName[0] + "\n");


            Console.WriteLine("\n------------------------------------------------------------------\n");
            double NewstudentAverage;
            Console.WriteLine("Original Average:" + studentAverage + "\n" +
                                 "Bonus Marks: 5" + "\n" +
                                 "New Average:" + (NewstudentAverage = studentAverage + 5));



            Console.WriteLine("\n------------------------------------------------------------------\n");

            
            Console.WriteLine("===== STUDENT SUMMARY ===== \n" +
                               "Welcome :" + studentName.ToUpper() + "\n" +
                               "Name:" + studentName + "\n" +
                               "Age:" + studentAge + "\n" +
                               "Grade:" + studentGrade + "\n" +
                               "Average:" + studentAverage + "\n" +
                               "New Average:" + NewstudentAverage + "\n" +
                               "Result:" + (studentAverage >= 50 ? "Passed" : "Failed") + "\n" +
                               "Adult:" + (studentAge >= 18 ? "True" : "False"));
        }
    }
}
