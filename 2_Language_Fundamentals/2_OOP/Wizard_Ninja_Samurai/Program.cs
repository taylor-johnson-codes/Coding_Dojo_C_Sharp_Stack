using System;

namespace Wizard_Ninja_Samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Human-Taylor");
            Human human2 = new Human("Human-Mac");
            Wizard wizard1 = new Wizard("Wizard-Chris");
            Ninja ninja1 = new Ninja("Ninja-Gary");
            Samurai samurai1 = new Samurai("Samurai-Angie");

            human1.Attack(human2);
            wizard1.Attack(human2);
            // wizard1.Heal(human2);
            // ninja1.Attack(human2);
            // ninja1.Steal(human2);
            // samurai1.Attack(human2);
            // samurai1.Meditate();
        }
    }
}
