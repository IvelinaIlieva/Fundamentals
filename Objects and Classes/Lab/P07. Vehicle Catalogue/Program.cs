using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Vehicle_Catalogue
{
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class Catalog
    {
        public Catalog()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            Catalog catalog = new Catalog();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] args = command.Split('/', StringSplitOptions.RemoveEmptyEntries);

                string type = args[0];
                string brand = args[1];
                string model = args[2];
                int horsePowerOrWeight = int.Parse(args[3]);

                if (type == "Car")
                {
                    Car newCar = new Car(brand, model, horsePowerOrWeight);
                    catalog.Cars.Add(newCar);

                }
                else if (type == "Truck")
                {
                    Truck newTruck = new Truck(brand, model, horsePowerOrWeight);
                    catalog.Trucks.Add(newTruck);
                }
            }

            if (catalog.Cars.Count > 0)
            {
                List<Car> orderedCar = catalog.Cars.OrderBy(car => car.Brand).ToList();

                Console.WriteLine("Cars:");

                foreach (Car car in orderedCar)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                List<Truck> orderedTrucks = catalog.Trucks.OrderBy(truck => truck.Brand).ToList();

                Console.WriteLine("Trucks:");

                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
