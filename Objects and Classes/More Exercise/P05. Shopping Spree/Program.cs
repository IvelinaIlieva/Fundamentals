using System;
using System.Collections.Generic;

namespace P05._Shopping_Spree
{
    class Person
    {
        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<Product>();
        }
        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> Products { get; set; }

        public void CanBuyTheProduct(Product product)
        {
            double productPrice = product.Cost;

            if (this.Money >= productPrice)
            {
                this.Products.Add(product);
                this.Money -= productPrice;
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }

        public override string ToString()
        {
            if (this.Products.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }
            else
            {
                List<string> nameOfProducts = new List<string>();

                foreach (Product product in this.Products)
                {
                    nameOfProducts.Add(product.Name);
                }

                return $"{this.Name} - {string.Join(", ", nameOfProducts)}";
            }
        }
    }

    class Product
    {
        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        public string Name { get; set; }
        public double Cost { get; set; }
    }
    internal class Program
    {
        static void Main()
        {
            List<Person> peopleList = new List<Person>();

            string[] people = Console.ReadLine().Split(";");

            for (int i = 0; i < people.Length; i++)
            {
                string[] personArgs = people[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = personArgs[0];
                double money = double.Parse(personArgs[1]);

                Person newPerson = new Person(name, money);
                peopleList.Add(newPerson);
            }

            List<Product> productsList = new List<Product>();

            string[] products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < products.Length; i++)
            {
                string[] productArgs = products[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = productArgs[0];
                double cost = double.Parse(productArgs[1]);

                Product newProduct = new Product(name, cost);
                productsList.Add(newProduct);
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string personName = commandArgs[0];
                string productName = commandArgs[1];

                Person currPerson = peopleList.Find(p => p.Name == personName);
                Product currProduct = productsList.Find(p => p.Name == productName);

                currPerson.CanBuyTheProduct(currProduct);
            }

            foreach (Person person in peopleList)
            {
                Console.WriteLine(person);
            }
        }
    }
}
