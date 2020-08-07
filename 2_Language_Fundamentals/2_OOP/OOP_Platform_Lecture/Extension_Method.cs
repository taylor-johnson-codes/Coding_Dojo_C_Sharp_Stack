/*
namespace OOP_Platform_Lecture
{
    // Assume this is the class provided that we can not edit.
    public class ShoppingCart
    {
        public List<Product> Products { get; set; }
    }
    // This is the wrapper for our extension
    // Note the static keyword
    public static class MyExtensionMethods
    {
        // Note how the parameters for the new function is previous class
        public static decimal TotalPrices(this ShoppingCart cartParam)
        {
            decimal total = 0;
            foreach (Product prod in cartParam.Products)
            {
                total += prod.Price;
            }
            return total;
        }
    }
}
*/

/*
From here an extension method is in place and the class will have access to that function when called as normal. 
Note they do have to be in the same namespace, though not in necessarily in the same file!
*/

/*
You can apply an extension method directly to an interface as well! This allows you to add the extension method 
functionality to every class that implements the interface.  EXAMPLE:
*/

/*
public static class MyExtensionMethods
{
    // This still only affects the Shopping cart class
    public static decimal TotalPrices(this ShoppingCart cartParam)
    {
        decimal total = 0;
        foreach (Product prod in cartParam.Products)
        {
            total += prod.Price;
        }
        return total;
    }
    // This method is added to everything that uses the CanRun interface though!
    public static double MarathonDistance(this CanRun creature)
    {
        creature.Run();
        Console.WriteLine("I'm running a marathon now!");
        return 26.2;
    } 
}
*/

/*
Delegates
Callback is a concept that exists in many other languages. The idea is that you can pass a function as a parameter 
to another function so that the passed function may be called within the one it was passed to. This allows for you 
to create some order by which the functions run as well as improve passing data between them. To create a callback 
in C# you must use a delegate, which is a variable reference to some type of function. Delegates can be defined like this:

public delegate void Del(string message);
public static void DelegateMethod(string message)
{
    Console.WriteLine(message);
}
// Instantiate the delegate to reference the DelegateMethod function
Del handler = DelegateMethod;

Now that you have set up a reference to a function as a delegate you can easily pass it to another function as a 
callback by making a parameter of the delegate type.

public void MethodWithCallback(int param1, int param2, Del callback)
{
    callback("The number is: " + (param1 + param2).ToString());
}
// Call this function by passing the params and actual delegate reference
MethodWithCallback(1, 2, handler);
*/