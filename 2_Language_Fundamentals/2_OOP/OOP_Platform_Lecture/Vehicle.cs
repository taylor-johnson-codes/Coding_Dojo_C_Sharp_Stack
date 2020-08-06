using System;

namespace OOP_Platform_Lecture
{
    public class Vehicle
    // adding "abstract" (before public) will throw an error in the Main method because vehicles can't be instantiated/created if class is abstract

    {
        
    /* ACCESS MODIFIERS:
    public: No access restriction
    private: Access restricted to own class (default for class members)
    protected: Access restricted to own class, and any child class
    internal: Access restricted to Assembly (essentially, your project's compiled .dll)
    */
    

    // FIELD EXAMPLES:
    public int NumPassengers;  // this unassigned integer will default to 0
    public int MaxNumPassengers;  // includes automatic invisible getter/setter at end: {get;set;}
    public double MaxSpeed;
    public string Color;
    protected double Odometer;  // accessible only by child class

    // private string color;  // can't be accessed in the Main method/Program class; only in the Vehicle class
    // public string Color { get {return color;} }  // allows the Main method/Program class to only see the color


    // CONSTRUCTOR(S):
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
        MaxSpeed = 120;
        Odometer = 0;
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
    
    public virtual void GetInfo()
    // marked as virtual so child class can override it
        {
            Console.WriteLine($"Num Passengers: {NumPassengers}");
            Console.WriteLine($"Max Num Passengers: {MaxNumPassengers}");
            Console.WriteLine($"Max Speed: {MaxSpeed}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Odometer: {Odometer}");
            Console.WriteLine("------------------------");
        }

    // abstract method example:
    // public abstract void MakeNoise();   // required to be implemented in child relationships


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
}