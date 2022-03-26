using System;

namespace P03._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());

            uint[] fibonaciArr = new uint[endNum + 1];
            fibonaciArr[0] = 1;
            fibonaciArr[1] = 1;
            if (endNum == 1)
            {
                Console.WriteLine("1");
                return;
            }

            for (int i = 2; i < endNum + 1; i++)
            {
                fibonaciArr[i] = fibonaciArr[i - 1] + fibonaciArr[i - 2];
            }
            Console.WriteLine(fibonaciArr[endNum - 1]);
        }
    }
}
