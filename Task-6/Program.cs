using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_6
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("===== ADVENTURE GAME =====\n");

            
            List<GameCharacter> characters = new List<GameCharacter>();

            Warrior alex = new Warrior("Alex", 80);
            Wizard luna = new Wizard("Luna", 70);

            characters.Add(alex);
            characters.Add(luna);

            Console.WriteLine();

           
            alex.UseSpecialAbility();
            alex.TakeDamage(10); 
            alex.DisplayHealth();

           
            alex.Heal();   
            alex.Heal(15);  

     
            luna.UseSpecialAbility();
            luna.TakeDamage(10); 
            luna.DisplayHealth();

           
            HealthPotion potion = new HealthPotion("Health Potion");
            potion.Collect();
            Console.WriteLine();

           
            potion.Use(luna, "15"); 

            
            potion.Use(luna, "abc"); 
            
        }
    }
}
