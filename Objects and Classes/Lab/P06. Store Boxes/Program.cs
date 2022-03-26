using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._Store_Boxes
{
    class Item
    {
        public Item(string item, double itemPrice)
        {
            this.Name = item;
            this.Price = itemPrice;
        }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public Box(int serialNumber, string item, int itemQuantity, double itemPrice)
        {
            this.SerialNumber = serialNumber;
            this.Item = new Item(item, itemPrice);
            this.ItemQuantity = itemQuantity;
            this.PriceForABox = itemPrice * itemQuantity;
        }
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForABox { get; set; }
    }
    internal class Program
    {
        static void Main()
        {
            List<Box> boxes = new List<Box>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] args = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int serialNumber = int.Parse(args[0]);
                string item = args[1];
                int itemQuantity = int.Parse(args[2]);
                double itemPrice = double.Parse(args[3]);

                Box box = new Box(serialNumber, item, itemQuantity, itemPrice);

                boxes.Add(box);
            }

            List<Box> orderedList = boxes.OrderByDescending(box => box.PriceForABox).ToList();

            Printing(orderedList);
        }

        private static void Printing(List<Box> orderedList)
        {
            foreach (Box box in orderedList)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }
}
