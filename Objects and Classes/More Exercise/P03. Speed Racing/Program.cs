using System;
using System.Collections.Generic;

namespace P03._Speed_Racing
{
    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumption, double distance)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumption;
            this.TraveledDistance = distance;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TraveledDistance { get; set; }

        public bool CanMoveTheDistance(string model, double distance)
        {
            double neededFuel = this.FuelConsumptionPerKilometer * distance;

            if (this.FuelAmount >= neededFuel)
            {
                this.FuelAmount -= neededFuel;
                this.TraveledDistance += distance;
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return false;
            }
        }
    }
    internal class Program
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();

            int countOfCars = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countOfCars; i++)
            {
                string[] carArgs = Console.ReadLine()
                    .Split(' ');

                string model = carArgs[0];
                double fuelAmount = double.Parse(carArgs[1]);
                double fuelConsumptionPerKilometer = double.Parse(carArgs[2]);
                double distance = 0;

                Car newCar = new Car(model, fuelAmount, fuelConsumptionPerKilometer, distance);
                cars.Add(newCar);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] driveArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = driveArgs[1];
                double distance = double.Parse(driveArgs[2]);

                Car chosenCar = cars.Find(c=>c.Model == model);
                chosenCar.CanMoveTheDistance(model, distance);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }
}
