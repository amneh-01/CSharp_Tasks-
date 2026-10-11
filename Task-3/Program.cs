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

            
        }

    }
  
}
