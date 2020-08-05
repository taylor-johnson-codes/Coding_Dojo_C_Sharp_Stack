using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
         
        // add a public "getter" property to access health
        public int Health
        {
            get { return health; }
        }
         
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
         
        // Add a constructor to assign custom values to all fields
        public Human(string name, int strength, int intelligence, int dexterity, int health_input)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = health_input;
        }

        /*
        Now add a new method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter. 
        The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker). 
        This method should return the remaining health of the target object.
        */
         
        // Build Attack method
        public int Attack(Human target)
        {
            target.health -= 5 * this.Strength;
            return target.Health;
        }
    }
}