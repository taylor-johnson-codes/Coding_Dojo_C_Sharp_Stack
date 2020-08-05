using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    public class Buffet
    {
        public List<Food> Menu;
         
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Pizza Slice", 250, false, false),
                new Food("Salad", 300, false, false),
                new Food("Spicy Tuna Roll", 315, true, false),
                new Food("Sweet & Sour Chicken", 275, true, true),
                new Food("Cookie", 100, false, true),
                new Food("Cheeseburger", 800, false, false),
                new Food("Asparagus", 150, false, false),
            };
        }
         
        public Food Serve()
        {
            Random random = new Random();
            int index = random.Next(0, Menu.Count);
            return Menu[index];
        }
    }
}