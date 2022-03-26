using System;

namespace P04._Password_Validator
{
    internal class Program
    {
        static void Main()
        {
            const int MinChar = 6;
            const int MaxChar = 10;
            const int MinDigits = 2;
            string password = Console.ReadLine();
            Print(password, MinChar, MaxChar, MinDigits);
        }

        static void Print(string password, int min, int max, int minDigit)
        {

            if (!CheckTheLenght(password,min,max))
            {
                Console.WriteLine($"Password must be between {min} and {max} characters");
            }

            if (!CheckIsAlphanumeric(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!CheckCountOfDigits(password, minDigit))
            {
                Console.WriteLine($"Password must have at least {minDigit} digits");
            }

            if (CheckTheLenght(password, min, max) && CheckIsAlphanumeric(password) && CheckCountOfDigits(password, minDigit))
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CheckTheLenght(string password, int min, int max)
        {

            bool isValid = password.Length >= min && password.Length <= max;

            return isValid;
        }

        static bool CheckIsAlphanumeric(string password)
        {
            bool isAlphanumeric = false;
            foreach (char ch in password)
            {
                if (char.IsLetterOrDigit(ch))
                {
                    isAlphanumeric = true;
                }
                else
                {
                    isAlphanumeric = false;
                    break;
                }
                ;
            }
            return isAlphanumeric;
        }

        static bool CheckCountOfDigits(string password, int minDigit)
        {
            bool hasEnoughDigits = false;
            int counter = 0;

            foreach (char ch in password)
            {
                if (char.IsDigit(ch))
                {
                    counter++;

                    if (counter >= minDigit)
                    {
                        hasEnoughDigits = true;
                        break;
                    }
                }
                ;
            }
            return hasEnoughDigits;

        }
    }
}
