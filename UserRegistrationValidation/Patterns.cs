﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationValidation
{
    class Patterns
    {
        public static string Regex_name = "^[A-Z]{1}[a-z]{2,}$";
        public static string Regex_email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";

        public void IsValidFirstName()
        {
            Boolean flag;
            Console.WriteLine("Enter the first name");

            do
            {
                string FirstName = Console.ReadLine();
                flag = (Regex.IsMatch(FirstName, Regex_name));
                if (flag == true)
                    Console.WriteLine("valid");
                else
                    Console.WriteLine("Invalid, Type again");
            }
            while (flag == false);

        }


        public void IsValidLastName()
        {
            Boolean flag;
            Console.WriteLine("Enter the last name");
            do
            {
                string LastName = Console.ReadLine();
                flag = (Regex.IsMatch(LastName, Regex_name));
                if (flag == true)
                    Console.WriteLine("valid");
                else
                    Console.WriteLine("Invalid, Type again");

            }
            while (!flag);
        }


        public void IsValidEmail()
        {
            Boolean flag;
            Console.WriteLine("Enter the Email");
            do
            {
                string Email = Console.ReadLine();
                flag = (Regex.IsMatch(Email, Regex_email));
                if (flag == true)
                    Console.WriteLine("valid");
                else
                    Console.WriteLine("Invalid, Type again");

            }
            while (!flag);
        }


    }
}
