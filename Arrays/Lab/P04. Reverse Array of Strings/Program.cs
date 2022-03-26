using System;
using System.Linq;

namespace P04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray(); 
            string[] newArray = new string[array.Length]; 

            for (int i = array.Length - 1; i >= 0; i--)
            {
                newArray[i] = array[array.Length - 1 - i];
            }
            Console.WriteLine(string.Join(" ", newArray));
        }
    }
}
