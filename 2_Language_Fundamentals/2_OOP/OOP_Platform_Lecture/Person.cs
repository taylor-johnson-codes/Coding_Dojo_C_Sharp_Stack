using System.Collections.Generic;

namespace OOP_Platform_Lecture
{
    public class Person
    {
        public List<Vehicle> OwnedVehicles;
        
        public Person() 
        {
            OwnedVehicles = new List<Vehicle>();
        }
        
        // can add ANY type of vehicle
        public void AddToVehicles(Vehicle newVehicle)
        {
            OwnedVehicles.Add(newVehicle);
        }
        
        public void DisplayVehicles()
        {
            foreach(Vehicle v in OwnedVehicles)
            {
                v.GetInfo();
            }
        }
    }
}