using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student stu1 = new Student("Amneh", 24 , 90);
            Console.WriteLine(stu1.DisplayInfo());

            Student stu2 = new Student("Ali", 24, 40);
            Console.WriteLine(stu2.DisplayInfo());

            Student stu3 = new Student("Amjad", 24, 99);
            Console.WriteLine(stu3.DisplayInfo());


        }
    }
}
