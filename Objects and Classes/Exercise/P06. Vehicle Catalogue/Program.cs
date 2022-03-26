using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._Vehicle_Catalogue
{
    class Vehicle
    {
        public Vehicle(string type, string model, string color, double horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
        public override string ToString()
        {
            return $"Type: {this.Type} Model: {this.Model} Color: {this.Color} Horsepower: {this.HorsePower}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            List<double> horsePowerOfCars = new List<double>();
            List<double> horsePowerOfTrucks = new List<double>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] vehicleArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string type = vehicleArgs[0];
                string model = vehicleArgs[1];
                string color = vehicleArgs[2];
                double horsePower = double.Parse(vehicleArgs[3]);

                switch (type)
                {
                    case "car":
                        type = "Car";
                        horsePowerOfCars.Add(horsePower);
                        break;
                    case "truck":
                        type = "Truck";
                        horsePowerOfTrucks.Add(horsePower);
                        break;
                }

                Vehicle newVehicle = new Vehicle(type, model, color, horsePower);

                vehicles.Add(newVehicle);
            }

            string commandPrint;
            while ((commandPrint = Console.ReadLine()) != "Close the Catalogue")
            {
                string model = commandPrint;

                foreach (Vehicle vehicle in vehicles)
                {
                    if (vehicle.Model == model)
                    {
                        Console.WriteLine($"Type: {vehicle.Type}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                    }
                }
            }

            Console.WriteLine(horsePowerOfCars.Count != 0
                ? $"Cars have average horsepower of: {horsePowerOfCars.Average():f2}."
                : $"Cars have average horsepower of: {0d:f2}.");

            Console.WriteLine(horsePowerOfTrucks.Count != 0
                ? $"Trucks have average horsepower of: {horsePowerOfTrucks.Average():f2}."
                : $"Trucks have average horsepower of: {0d:f2}.");
        }
    }
}
