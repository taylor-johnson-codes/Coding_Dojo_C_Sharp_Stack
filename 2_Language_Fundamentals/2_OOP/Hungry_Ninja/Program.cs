using System;

namespace Hungry_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet1 = new Buffet();
            Ninja ninja1 = new Ninja();

            while (ninja1.IsFull == false)
            {
                ninja1.Eat(buffet1.Serve());
            }
        }
    }
}
