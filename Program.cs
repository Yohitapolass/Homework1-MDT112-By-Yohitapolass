using System;

namespace PasswordValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a 6-digit password: ");
            int password = int.Parse(Console.ReadLine());

            Console.Write("Enter Agency code (CIA, FBI, or NSA): ");
            string agencyCode = Console.ReadLine().ToUpper();

            bool isValid = false;

            switch (agencyCode)
            {
                case "CIA":
                    if (CheckCIA(password))
                    {
                        isValid = true;
                    }
                    break;
                case "FBI":
                    if (CheckFBI(password))
                    {
                        isValid = true;
                    }
                    break;
                case "NSA":
                    if (CheckNSA(password))
                    {
                        isValid = true;
                    }
                    break;
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password is invalid");
            }
        }
    }
}