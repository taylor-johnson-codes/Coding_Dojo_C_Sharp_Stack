namespace OOP_Platform_Lecture
{
    // Common naming convention for interfaces: capital I + DescriptionOfBehavior
    public interface IRideable
    {
        // any class that implements "IRideable", must have the following methods/properties
        
        // in interfaces, "method signatures" are used.
        // this means that there is no body to this method, only its return type, name, and parameters
        void Ride(double distance);
        // it's up to the class to say exactly what this action does
        
        // properties can also be used in interfaces (fields can not)
        double DistanceTraveled {get;set;}
    }
}