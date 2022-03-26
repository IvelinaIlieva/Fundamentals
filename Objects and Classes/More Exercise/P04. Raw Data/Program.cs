using System;
using System.Collections.Generic;

namespace P04._Raw_Data
{
    class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
        }
        public string Model { get; set; }
        public Engine Engine{ get; set; }
        public Cargo Cargo{ get; set; }   

    }

    class Engine
    {
        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }
        public int Speed { get; set; }
        public int Power{ get; set; }
    }

    class Cargo
    {
        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }
        public int Weight { get; set; }
        public string Type { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();

            int countOfCars = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countOfCars; i++)
            {
                string[] carArgs = Console.ReadLine().Split(" ");

                string model = carArgs[0];
                int engineSpeed = int.Parse(carArgs[1]);
                int enginePower = int.Parse(carArgs[2]);
                int cargoWeight = int.Parse(carArgs[3]);
                string cargoType = carArgs[4];

                Car newCar = new Car(model, new Engine(engineSpeed, enginePower), new Cargo(cargoWeight, cargoType));
                cars.Add(newCar);
            }

            string command = Console.ReadLine();
            switch (command)
            {
                case "fragile":

                    foreach (Car car in cars)
                    {
                        if (car.Cargo.Type == "fragile" && car.Cargo.Weight < 1000)
                        {
                            Console.WriteLine(car.Model);
                        }
                    }

                    break;
                case "flamable":

                    foreach (Car car in cars)
                    {
                        if (car.Cargo.Type == "flamable" && car.Engine.Power > 250)
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                    break;
            }
        }
    }
}
