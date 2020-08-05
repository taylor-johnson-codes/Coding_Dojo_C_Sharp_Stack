using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    public class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
         
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
         
        public bool IsFull
        {
            get
            {
                if(calorieIntake > 1200){
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
         
        public void Eat(Food item)
        {
            if (!IsFull) 
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"Food name: {item.Name}");
                if (item.IsSpicy && item.IsSweet)
                {
                Console.WriteLine($"{item.Name} is sweet and spicy.");
                }
                else if (item.IsSpicy)
                {
                Console.WriteLine($"{item.Name} is spicy.");
                }
                else if (item.IsSweet)
                {
                Console.WriteLine($"{item.Name} is sweet.");
                }
            }
            if (IsFull)
            {
                Console.WriteLine("Ninja is full and cannot eat any more."); 
            }
        }
    }
}