using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string studentName = "sami Ali";
            int studentAge = 20;
            int studentGrade = 12;
            double studentAverage = 85.5;
            string studentGender = "M";
            bool isstudentActive = true;


            Console.WriteLine("===== Student Information ===== \n" +
                                 "Name:" + studentName + "\n" +
                                 "Age:" + studentAge + "\n" +
                                 "Grade:" + studentGrade + "\n" +
                                 "Average:" + studentAverage + "\n" +
                                 "Gender:" + studentGender + "\n" +
                                  "Active:" + isstudentActive);


            //////////////////////////////////////////////////////////////////
            Console.WriteLine(" \n------------Part-2------------------\n ");

            string[] students = { "Ahmad", "Sara", "Omar", "Lina" };

            Console.WriteLine("===== Before Change =====" + "\n" +
                              "Student 1:" + students[0] + "\n" +
                              "Student 0:" + students[1] + "\n" +
                              "Student 2:" + students[2] + "\n" +
                              "Student 3:" + students[3] + "\n" +
                              "Number of Students:" + students.Length );

            /////////////////////////////////////////////////////////////////////
            Console.WriteLine(" \n------------Part-3------------------\n ");

            students[2] = "Arwa";
            Console.WriteLine("===== After Change =====" + "\n" +
                              "Student 1:" + students[0] + "\n" +
                              "Student 0:" + students[1] + "\n" +
                              "Student 2:" + students[2] + "\n" +
                              "Student 3:" + students[3] + "\n" );


        }
    }    
}
