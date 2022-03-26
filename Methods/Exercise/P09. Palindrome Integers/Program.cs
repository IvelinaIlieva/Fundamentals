using System;
using System.Linq;

namespace P09._Palindrome_Integers
{
    internal class Program
    {
        static void Main()
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                Console.WriteLine(CheckIfPalindrome(input));
            }
        }

        static bool CheckIfPalindrome(string num)
        {
            string reverse = new string(num.Reverse().ToArray());

            return num == reverse;
        }
    }
}
