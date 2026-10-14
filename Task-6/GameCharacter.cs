using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public abstract class GameCharacter
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        private int _health;
        protected int Health
        {
            get => _health;
            set
            {
                if (value < 0) _health = 0;
                else if (value > 100) _health = 100;
                else _health = value;
            }
        }

        protected GameCharacter(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public abstract void UseSpecialAbility();

        public virtual void TakeDamage(int amount)
        {
            Health -= amount;
        }

        // Method Overloading للشفاء
        public void Heal()
        {
            Health += 10;
            Console.WriteLine($"{Name} heals 10 points.");
            Console.WriteLine($"{Name}'s health: {Health}\n");
        }

        public void Heal(int amount)
        {
            Health += amount;
            Console.WriteLine($"{Name} heals {amount} points.");
            Console.WriteLine($"{Name}'s health: {Health}\n");
        }

        public void DisplayHealth()
        {
            Console.WriteLine($"{Name}'s health: {Health}\n");
        }
    }



    public class Wizard : GameCharacter
    {
        public Wizard(string name, int health) : base(name, health)
        {
            Console.WriteLine($"Wizard {Name} enters the game!");
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Wizard uses magic!");
        }

        public override void TakeDamage(int amount)
        {
            base.TakeDamage(amount); 
            Console.WriteLine($"{Name} takes {amount} damage.");
        }
    }


    public class HealthPotion : ICollectible
    {
        public string PotionName { get; set; }

        public HealthPotion(string name)
        {
            PotionName = name;
        }

        public void Collect()
        {
            Console.WriteLine($"{PotionName} collected!");
        }

        public void Use(GameCharacter character, string amountText)
        {
            try
            {
                int amount = int.Parse(amountText);
                character.Heal(amount);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a number.");
            }
        }
    }


    public class Warrior : GameCharacter
    {
        public Warrior(string name, int health) : base(name, health)
        {
           
            Console.WriteLine($"Warrior {Name} enters the game!");
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Warrior attacks with a sword!");
        }

        public override void TakeDamage(int amount)
        {
           
            int actualDamage = amount - 2;
            if (actualDamage < 0) actualDamage = 0;

            Health -= actualDamage;
            Console.WriteLine($"{Name} takes {actualDamage} damage.");
        }
    }


    public interface ICollectible
    {
        void Collect();
    }
}


    
