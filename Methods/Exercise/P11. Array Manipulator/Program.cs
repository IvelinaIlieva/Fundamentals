using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Threading.Channels;

namespace P11._Array_Manipulator
{
    internal class Program
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] wholeCommand = input.Split(" ").ToArray();
                string command = wholeCommand[0];

                switch (command)
                {
                    case "exchange":
                        int index = int.Parse(wholeCommand[1]);
                        if (index < 0 || index >= inputArray.Length)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        inputArray = Exchange(inputArray, index);
                        break;
                    case "max":
                        string kindOfMaxNum = wholeCommand[1];
                        if (GetTheMaxNum(inputArray, kindOfMaxNum) > -1)
                        {
                            Console.WriteLine(GetTheMaxNum(inputArray, kindOfMaxNum));
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                        break;
                    case "min":
                        string kindOfMinNum = wholeCommand[1];
                        if (GetTheMinNum(inputArray, kindOfMinNum) > -1)
                        {
                            Console.WriteLine(GetTheMinNum(inputArray, kindOfMinNum));
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                        break;
                    case "first":
                        string kindOfFirstNum = wholeCommand[2];
                        int countFirst = int.Parse(wholeCommand[1]);
                        if (countFirst <= inputArray.Length)
                        {
                            GetFirstEvenOddNum(inputArray, kindOfFirstNum, countFirst);
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        break;
                    case "last":
                        int countLast = int.Parse(wholeCommand[1]);
                        string kindOfSecondNum = wholeCommand[2];
                        if (countLast <= inputArray.Length)
                        {
                            GetLastEvenOddNum(inputArray, kindOfSecondNum, countLast);
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", inputArray)}]");
        }

        static int[] Exchange(int[] array, int index)
        {
            int[] exArray = new int[array.Length];
            int startIndex = 0;

            for (int i = index + 1; i < array.Length; i++)
            {
                exArray[startIndex] = array[i];
                startIndex++;
            }

            for (int i = 0; i <= index; i++)
            {
                exArray[startIndex] = array[i];
                startIndex++;
            }
            return exArray;
        }

        static int GetTheMaxNum(int[] array, string evenOdd)
        {
            int maxEvenNum = int.MinValue;
            int maxOddNum = int.MinValue;
            int indexMaxEven = -1;
            int indexMaxOdd = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (maxEvenNum <= array[i])
                    {
                        maxEvenNum = array[i];
                        indexMaxEven = i;
                    }
                }
                else
                {
                    if (maxOddNum <= array[i])
                    {
                        maxOddNum = array[i];
                        indexMaxOdd = i;
                    }
                }
            }

            if (evenOdd == "even")
            {
                return indexMaxEven;
            }
            else
            {
                return indexMaxOdd;
            }
        }

        static int GetTheMinNum(int[] array, string evenOdd)
        {
            int minEvenNum = int.MaxValue;
            int minOddNum = int.MaxValue;
            int indexMinEven = -1;
            int indexMinOdd = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (minEvenNum >= array[i])
                    {
                        minEvenNum = array[i];
                        indexMinEven = i;
                    }
                }
                else
                {
                    if (minOddNum >= array[i])
                    {
                        minOddNum = array[i];
                        indexMinOdd = i;
                    }
                }
            }

            if (evenOdd == "even")
            {
                return indexMinEven;
            }
            else
            {
                return indexMinOdd;
            }
        }

        static void GetFirstEvenOddNum(int[] array, string evenOdd, int count)
        {
            int[] arrayToFill = new int[count];
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (evenOdd == "even")
                {
                    if (array[i] % 2 == 0 && counter < count)
                    {
                        arrayToFill[counter] = array[i];
                        counter++;
                    }
                }
                else
                {
                    if (array[i] % 2 != 0 && counter < count)
                    {
                        arrayToFill[counter] = array[i];
                        counter++;
                    }
                }
            }

            PrintArray(arrayToFill, counter);
        }

        static void GetLastEvenOddNum(int[] array, string evenOdd, int count)
        {
            int[] arrayToFill = new int[count];
            int counter = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (evenOdd == "even")
                {
                    if (array[i] % 2 == 0 && counter < count)
                    {
                        arrayToFill[counter] = array[i];
                        counter++;
                    }
                }
                else
                {
                    if (array[i] % 2 != 0 && counter < count)
                    {
                        arrayToFill[counter] = array[i];
                        counter++;
                    }
                }
            }

            int[] revArr = new int[counter];
            int revIndex = 0;
            for (int i = counter - 1; i >= 0; i--)
            {
                revArr[i] = arrayToFill[revIndex];
                revIndex++;
            }

            PrintArray(revArr, counter);
        }

        static void PrintArray(int[] arrToPrint, int counter)
        {
            string print = string.Empty;

            if (counter == 0)
            {
                Console.WriteLine($"[]");
                return;
            }

            for (int i = 0; i < counter; i++)
            {
                if (i == counter - 1)
                {
                    print += arrToPrint[i];
                }
                else
                {
                    print += arrToPrint[i] + ", ";
                }
            }

            Console.WriteLine($"[{print}]");
        }
    }
}
