using System;

namespace Wizard_Ninja_Samurai
{
    public class Human
{
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int Health;
        
        /* 
        This is if I kept public int health:

        public int Health
        {
            get { return health; }
        }
        */
         
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
         
        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            Health = hp;
        }
         
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.Health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }
    }
}