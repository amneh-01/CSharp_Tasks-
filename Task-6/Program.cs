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

            Warrior p1 = new Warrior("player-1", 80);
            Wizard p2 = new Wizard("player-2", 70);

            characters.Add(p1);
            characters.Add(p2);

            Console.WriteLine();
             
           
            p1.UseSpecialAbility();
            p1.TakeDamage(10); 
            p1.DisplayHealth();

           
            p1.Heal();   
            p1.Heal(15);  

     
            p2.UseSpecialAbility();
            p2.TakeDamage(10); 
            p2.DisplayHealth();

           
            HealthPotion potion = new HealthPotion("Health Potion");
            potion.Collect();
            Console.WriteLine();

           
            potion.Use(p2, "15"); 
            potion.Use(p2, "abc"); 
            
        }
    }
}
