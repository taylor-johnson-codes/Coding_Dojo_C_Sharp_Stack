// EXAMPLE OF STATIC CLASS

/*
A static class can only contain static fields and static methods and cannot be instantiated. 
The main reason to create a static class is to serve as a toolbox of sorts. A static class may 
contain several useful methods that we want to call from many parts of our code without having 
to write them in multiple places.
*/

namespace OOP_Platform_Lecture
{
    public static class Calculator
    {
        public static int Add(int FirstValue, int SecondValue)
        {
            return FirstValue + SecondValue;
        }
    }
}

/* in main method:

int Sum = Calculator.Add(4, 6);

Notice that we call .Add() directly on the class name Calculator, rather than an instance of type Calculator. 
Non-static classes can contain static fields and methods, just remember that they will still be called from 
the class name, not class instances.

*/
