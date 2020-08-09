namespace Platform_Lecture_ASP_MVC_II.Models  // notice .Models was added on here
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

/*
Because I haven't created my own construtor, the default construtor is still here invisibly which is used
to instantiate new users. If I create my own construtor, I would also need to add the default construtor back in
because it will disappear when I create my own.

Invisible constructor:
public User()
{
    
}
*/

/*
The User class can have all different kinds of data types in it, so when you're sending over the User data type
to a cshtml page, you're sending over all the different data types within the User class.
*/

/*
If I just want a model to store data and not be instantiated (i.e. not create a new User), th en add 'static' before 
'public'. Note: any methods in a static class need to be static methods.
*/