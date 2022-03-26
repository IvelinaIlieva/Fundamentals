using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace P03.TakeSkipRope
{
    internal class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine()
                .ToCharArray();

            List<char> numberList = new List<char>();
            List<char> nonNumberList = new List<char>();

            foreach (char ch in input)
            {
                if (char.IsNumber(ch))
                {
                    numberList.Add(ch);
                }
                else
                {
                    nonNumberList.Add(ch);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numberList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numberList[i] - 48);
                }
                else
                {
                    skipList.Add(numberList[i] - 48);
                }
            }

            StringBuilder message = new StringBuilder();
            int takeCounter = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                for (int j = 0; j < takeList[i]; j++)
                {
                    if (takeCounter == nonNumberList.Count - 1)
                    {
                        message.Append(nonNumberList[takeCounter]);
                        break;
                    }
                    message.Append(nonNumberList[takeCounter]);
                    takeCounter++;
                }
                takeCounter += skipList[i];
            }
            Console.WriteLine(message);
        }
    }
}
