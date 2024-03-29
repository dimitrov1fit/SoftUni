﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Raw_Data
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                double tire1Pressure = double.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);
                double tire2Pressure = double.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);
                double tire3Pressure = double.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);
                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);

                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, 
                    tire1Pressure, tire1Age, tire2Pressure, tire2Age, tire3Pressure, 
                    tire3Age, tire4Pressure, tire4Age);

                cars.Add(car);
            }

            string cmd = Console.ReadLine();

            List<Car> specialCars = new List<Car>();

            if (cmd == "fragile")
            {
                specialCars = cars.Where(c => c.Cargo.CargoType == "fragile" &&
                                              c.Tires.Any(t => t.TirePressure < 1)).ToList();
            }
            else
            {
                specialCars = cars.Where(c => c.Cargo.CargoType == "flamable" &&
                                              c.Engine.EnginePower > 250).ToList();
            }

            foreach (var specialCar in specialCars)
            {
                Console.WriteLine(specialCar.Model);
            }
        }
    }
}
