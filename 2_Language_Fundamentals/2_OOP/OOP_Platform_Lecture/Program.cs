using System;
using System.Collections.Generic;

namespace OOP_Platform_Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myVehicle1 = new Vehicle(7);
            Console.WriteLine($"My vehicle is holding {myVehicle1.NumPassengers} people.");

            myVehicle1.MakeNoise("HOOONK!");

            myVehicle1.MakeNoise();

            myVehicle1.ColorProp = "blue";

            Console.WriteLine(myVehicle1.ColorProp);

            Vehicle myVehicle2 = new Vehicle(5, "red");
            Console.WriteLine($"My vehicle is {myVehicle2.Color} and can hold {myVehicle2.MaxNumPassengers} people.");

            myVehicle1.GetInfo();
            myVehicle2.GetInfo();

            Car newCar1 = new Car(2, "red", "Tesla", "Roadster");
            Car newCar2 = new Car(7, "black", "Toyota", "4Runner");

            newCar1.GetInfo();
            newCar2.GetInfo();

            newCar1.Drive(50);
            newCar1.Drive(200);

            // Polymorphism example: Car can be a car and car can also be a vehicle
            List<Vehicle> allVehicles = new List<Vehicle>() {myVehicle1, myVehicle2, newCar1, newCar2};
            // allVehicles.Add(myVehicle1);
            // allVehicles.Add(myVehicle2);
            // allVehicles.Add(newCar1);
            // allVehicles.Add(newCar2);

            foreach (var v in allVehicles)
            {
                v.GetInfo();  // automatically shows Vehicle's version and Car's version of GetInfo()
            }

            Vehicle someVehicle = new Vehicle(4);
            
            // Constructing a Car "as a" Vehicle
            Vehicle carAsVehicle = new Car(5, "silver", "Subaru", "Outback");
            
            // Constructing a Person, adding any Vehicle to their list of OwnedVehicles
            Person somePerson = new Person();
            somePerson.AddToVehicles(someVehicle);
            somePerson.AddToVehicles(carAsVehicle);
            
            somePerson.DisplayVehicles();

            /*
            IRideable[] variousRideables = new IRideable[]
            {
                new Car("Yellow", "Dodge", "Dart"),
                new Car("Green", "Ford", "Fiesta"),
                new Horse("Silver Queen", 100),
                new Horse("Samammish", 75),
            };
            // let them all ride!
            foreach(var rideable in variousRideables)
            {
                // each "rideable" object will be able to invoke the common "Ride()" method
                // however the implementation of "Ride()" will be unique to how each class has chosen to build it
                rideable.Ride(50);
            }
            */

            Horse wilbur = new Horse("Wilbur", 120);
            Car subaru = new Car(5, "yellow", "Subaru", "Forester");
            
            // sally starts out with a horse
            Person2 sally = new Person2("Sally", wilbur);
            // sally can ride her horse
            sally.GoSomewhere(34);
            
            // we can also change her Transport to a Car
            sally.Transport = subaru;
            sally.GoSomewhere(100);
            sally.GetPersonInfo();
        }
    }
}
