using System;

namespace Wizard_Ninja_Samurai
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }

        public override int Attack(Human target)
        {
            // reduces the target by 5 * Dexterity and a 20% chance of dealing an additional 10 points of damage
            int dmg = Dexterity * 5;
            Random random = new Random();
            int randomChance = random.Next(0,5);
            if(randomChance == 3)  // between 0 and 5, there's a 20% chance it will be 3
            {
                dmg += 10;
            }
            target.Health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }

        public void Steal(Human target)
        {
            target.Health -= 5;
            Health += 5;
            Console.WriteLine($"{Name} stole 5 from {target.Name} to improve {Name}'s health by 5!");
        }
    }
}