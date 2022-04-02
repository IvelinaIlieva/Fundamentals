using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                string barcode = Console.ReadLine();

                Regex regex = new Regex(@"^@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+$");

                Match match = regex.Match(barcode);

                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }

                string productGroup = string.Join("", barcode.Where(char.IsDigit));

                Console.WriteLine(productGroup == string.Empty ? $"Product group: 00" : $"Product group: {productGroup}");
            }
        }
    }
}
