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

            
        }
    }
}