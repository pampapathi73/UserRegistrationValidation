using System;

namespace UserRegistrationValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Patterns pattern = new Patterns();
            pattern.IsValidFirstName();
            pattern.IsValidLastName();
            pattern.IsValidEmail();
            pattern.IsValidPhoneNo();
            pattern.IsValidPasswordRule3();
        }
    }
}
