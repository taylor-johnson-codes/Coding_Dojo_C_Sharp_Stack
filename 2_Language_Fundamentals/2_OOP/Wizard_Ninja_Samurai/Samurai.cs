using System;

namespace Wizard_Ninja_Samurai
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            Health = 200;
        }

        public override int Attack(Human target)
        {
            // calls the base Attack and reduces the target to 0 if it has less than 50 remaining health points.

            base.Attack(target);

            if (target.Health < 50)
            {
                target.Health = 0;
                Console.WriteLine($"{Name} has reduced {target.Name}'s health to ZERO!");
            }
            return target.Health;
        }

        public void Meditate()
        {
            // heals the Samurai back to full health

            Health = 200;
            Console.WriteLine($"{Name} has meditated and health has been restored to 200!");
        }
    }
}