using System;

namespace OOP_Platform_Lecture
{
    public class Horse : IRideable
    // horse and car class share more similar characteristics than horse and vehicle; creating Interface for this relationship
    {
        // a horse can have its own unique attributes
        public string Name;
        public double Endurance;
        public double DistanceTraveled {get;set;}
        // implementing DistanceTraveled a bit differently from a Car,
        // only requirement here, is that it has a property for DistanceTraveled
         
        public Horse(string name, double endurance)
        {
            Name = name;
            Endurance = endurance;
            DistanceTraveled = 0;
        }
        // implementing Ride, again, a bit differently from a Car
        // a Horse can only go so far as its endurance will allow
        public void Ride(double distance)
        {
            Console.WriteLine("... riding, heeeyahhh ...");
            if(distance >= Endurance)
                distance = Endurance;
            DistanceTraveled += distance;
        }
    }
}