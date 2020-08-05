using System;

namespace OOP_Platform_Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
        /*
        Vehicle myVehicle = new Vehicle();
        // Notice the type for the new object reference is the same as the class name
        Console.WriteLine($"My vehicle is holding {myVehicle.NumPassengers} people.");
        */

        Vehicle myVehicle = new Vehicle(7);
        Console.WriteLine($"My vehicle is holding {myVehicle.NumPassengers} people.");

        myVehicle.MakeNoise("HOOONK!");

        myVehicle.MakeNoise();

        myVehicle.ColorProp = "Blue";

        Console.WriteLine(myVehicle.ColorProp);

        Vehicle myVehicle2 = new Vehicle(5, "red");
        Console.WriteLine($"My vehicle is {myVehicle2.Color} and can hold {myVehicle2.MaxNumPassengers} people.");

        }
    }

    /* ACCESS MODIFIERS:
    public: No access restriction
    private: Access restricted to own class (default for class members)
    protected: Access restricted to own class, and any child class
    internal: Access restricted to Assembly (essentially, your project's compiled .dll)
    */
    
    public class Vehicle
    {
        // FIELD EXAMPLES:
        public int NumPassengers;  // this unassigned integer will default to 0
        public int MaxNumPassengers;  // includes automatic invisible getter/setter at end: {get;set;}
        public double MaxSpeed;
        public string Color;

        // private string color;  // can't be accessed in the Main method/Program class; only in the Vehicle class
        // public string Color { get {return color;} }  // allows the Main method/Program class to only see the color


        // CONSTRUCTOR:
        // Notice the Constructor function doesn't need a return type or the static keyword
        public Vehicle(int val)
        {
            NumPassengers = val;
        }

        // There can more than one constructor:
        public Vehicle(int maxPass, string color)
        {
            MaxNumPassengers = maxPass;
            Color = color;
        }

        // METHOD EXAMPLES:
        public void MakeNoise(string noise)
        {
            Console.WriteLine(noise);
        }
        
        public void MakeNoise()
        {
            Console.WriteLine("BEEP!");
        }

        // PROPERTIES EXAMPLE:
        public string ColorProp
        {
            get
            {
                // Simply referencing the property will invoke the "getter", such as:
                // Console.WriteLine(vehicleObject.ColorProp);
                // and will return the following:
                return $"The vehicle is {Color}.";
            }
            set
            {
                // Assigning a value to a property, such as:
                // vehicleObject.ColorProp = "Blue";
                // will invoke the "setter", and the "value" keyword will become the assigned value
                Color = value;
            }
        }
    }
    /*
    ENCAPSULATION EXAMPLE:

    class Vehicle
    {
        private int maxNumPassengers;
        private string color;
        public int MaxNumPassengers
        {
            get { return maxNumPassengers; }
        }
        public string Color
        {
            get { return color; }
        }
        public Vehicle(int maxPass, string col)
        {
            maxNumPassengers = maxPass;
            color = col;
        }
    }
    */
}
