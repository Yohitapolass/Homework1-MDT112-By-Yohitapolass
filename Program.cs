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

        static bool CheckCIA(int password)
        {
            int unitDigit = password % 10;
            int tensDigit = (password / 10) % 10;
            int thousandsDigit = (password / 1000) % 10;

            if (unitDigit % 3 != 0)
            {
                return false;
            }
            if (tensDigit == 1 || tensDigit == 3 || tensDigit == 5)
            {
                return false;
            }
            if (thousandsDigit < 6 || thousandsDigit == 8)
            {
                return false;
            }

            return true;
        }

         static bool CheckFBI(int password)
        {
            int hundredThousandsDigit = (password / 100000);
            int thousandsDigits = (password / 10000) % 10;
            int hundredsDigit = (password / 100) % 10;

            if (hundredsDigit % 3 != 0)
            {
                return false;
            }
            if (hundredsDigit % 3 != 0)
            {
                return false;
            }
            if (hundredsDigit % 3 != 0)
            {
                return false;
            }

            return true;
        }

        static bool CheckNSA(int password)
        {
            int unitDigits = password % 10;
            int hundredsDigits = (password / 100) % 10;
            int Digit = 7;

            if (unitDigits % 3 != 0)
            {
                return false;
            }
            if (unitDigits % 3 != 0)
            {
                return false;
            }
            if (unitDigits % 3 != 0)
            {
                return false;
            }

            return true;
        } 



    }
}