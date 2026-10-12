using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int randomNumber = random.Next(50, 76);
            int userGuess = 0;
            int attempts = 0;
            int points = 0;

            Console.WriteLine(randomNumber);

            Console.WriteLine("===== Guessing Game =====");
            Console.Write(" Guess a number between 50 and 75 !");

            while (userGuess != randomNumber)
            { 
                userGuess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (attempts == 1) points = 10;
                else if (attempts == 2) points = 7;
                else if (attempts == 3) points = 5;
                else points = 0;

                if (userGuess < randomNumber)
                {
                    Console.Write("Try a higher number ");
                }
                else if (userGuess > randomNumber)
                {
                    Console.Write("Try a lower number ");
                }
                else
                {
                    Console.WriteLine("Congratulations :) ");
                    Console.WriteLine($"\nTotal Attempts: {attempts}");
                    Console.WriteLine($"Points Earned: {points}");
                }
            }
           

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /* Write a C# program that accepts an integer and determines if the number is 
               even or odd. Display the result. */


            Console.WriteLine(" Enter any num");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0) Console.WriteLine($" {num}is even");
            else Console.WriteLine($"{num}is ood");



           /*Write a C# program that accepts five numbers and displays the  2nd smallest of the 
            five.*/

            int[] num2 = new int[5]; 
            Console.WriteLine("Please enter 5 numbers:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Number {i + 1}: ");
                num2[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(num2);
            int secondSmallest = num2[1];

            Console.WriteLine($"\nThe 2nd smallest number is: {secondSmallest}");




            /* Write a program that calculates the factorial of a given number using a for loop*/

            Console.WriteLine(" Enter any num");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int  factorial = 1;

            for (int i = num3 ; i >= 1; i--)
            {
                factorial *= i;

            }

            Console.WriteLine($"The factorial of {num3} is: {factorial}");



            /* Write a program that takes two integers as input and prints all the prime numbers 
               between them using nested loops. */

            Console.Write("Enter the first integer: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int end = Convert.ToInt32(Console.ReadLine());

           
            int min = Math.Min(start, end);
            int max = Math.Max(start, end);

            Console.WriteLine($"\nPrime numbers between {min} and {max}:");

 
            for (int i = min; i <= max; i++)
            {
             
                if (i <= 1)
                {
                    continue;
                }

                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false; 
                        break;           
                    }
                }

           
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }




            /* Create a program that initializes an integer array and finds the largest number in it 
              using a foreach loop.*/










    }

}

}
