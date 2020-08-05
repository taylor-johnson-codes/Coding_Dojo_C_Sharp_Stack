using System;

namespace OOP_Platform_Lecture
{
    public class Car : Vehicle  // indicates Car inherits from Vehicle; Car is a child of Vehicle parent/base class
    {
        public string Make;
        public string Model;

        // One of the two Vehicle constructors need to be satisfied now:
        // invoked one of the parent class constructors and added the Car fields to the Car part of the constructor
        public Car(int maxPassengers, string car_color, string make, string model) : base(maxPassengers, car_color) 
        {
            Make = make;
            Model = model;
        }  

        // public Car() : base(5, "silver") {}  // all cars created would have maxPass 5/color silver with this example

        public override void GetInfo()
            {
                Console.WriteLine($"Car Make: {Make}");
                Console.WriteLine($"Car Model: {Model}");
                base.GetInfo();  // or copy paste over what you want from base class GetInfo()
            }

        public void Drive(double distance)
        {
            Odometer += distance;
            Console.WriteLine($"I drove {distance} miles!");
            Console.WriteLine($"Odometer reading: {this.Odometer}");
        }
    }
}