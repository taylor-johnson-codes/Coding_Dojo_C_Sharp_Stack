namespace Platform_Lecture_ASP_MVC_II.Models  // notice .Models was added on here
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

// the User class can have all different kinds of data types in it, so when you're sending over the User data type
// to a cshtml page, you're sending over all the different data types within the User class

// if I just want a model to store data and not be instantiated (i.e. not create a new User),
// then add 'static' before 'public'