using System;

namespace Wizard_Ninja_Samurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Intelligence = 25;
            Health = 50;
        }

        public override int Attack(Human target)
        {
            // reduces the target by 5 * Intelligence and heals the Wizard by the amount of damage dealt
            int dmg = Intelligence * 5;
            target.Health -= dmg;
            this.Health += dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            Console.WriteLine($"{Name} earned {dmg} health!");
            return target.Health;
        }

        public void Heal(Human target)
        {
            int healedAmount = Intelligence * 10;
            target.Health += healedAmount;
            Console.WriteLine($"{Name} healed {target.Name}'s health by {healedAmount}!");
        }
    }
}