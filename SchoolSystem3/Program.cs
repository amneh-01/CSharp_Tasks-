using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] stuNames = { "Ahmad", "Ali", "Amjad", "Ajwad", "Arwa" };
            int[] stuGrades = { 20, 50, 90 , 80 , 70 };

            foreach (int stu in stuGrades) 
            {
                Console.WriteLine(stu);
            
            }



            Console.Write("Enter student name:");
            string Name = Console.ReadLine();
            int i=0;
            while (i < stuNames.Length && stuNames[i] != Name)
            {
                i++;
                
            }
            if (i < stuNames.Length)
            {
                Console.WriteLine($"Student '{Name}' was found at index {i}.");
            }
            else
            {
                Console.WriteLine($"Student '{Name}' was not found.");
            }




            Console.Write("Enter student grade:");
            int Grade = Convert.ToInt32(Console.ReadLine());

            if (100 >= Grade &&  Grade >= 90)
            {
                Console.WriteLine("Excellent");
            }
            else if (98 >= Grade && Grade >= 80)
            {
                Console.WriteLine("Very Good");
            }
            else if (79 >= Grade && Grade >= 70)
            {
                Console.WriteLine("Good");
            }
            else if (69 >= Grade && Grade >= 60)
            {
                Console.WriteLine("Pass");
            }
            
            else
            {
                Console.WriteLine("Fail :( ");
            }







        }
    }
}
