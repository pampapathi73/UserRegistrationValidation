using System;

namespace UserRegistrationValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User registration Validation");
            Patterns pattern = new Patterns();
            pattern.IsValidFirstName();
            pattern.IsValidLastName();
        }
    }
}
