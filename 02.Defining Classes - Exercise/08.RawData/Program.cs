using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> allCars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            var currentCar = Console.ReadLine().Split();
            var model = currentCar[0];
            var engineSpeed = int.Parse(currentCar[1]);
            var enginePower = int.Parse(currentCar[2]);
            var cargoWeight = int.Parse(currentCar[3]);
            var cargoType = currentCar[4];
            var tires = GetTyres(currentCar);

            Engine engine = new Engine(engineSpeed, enginePower);
            Cargo cargo = new Cargo(cargoWeight, cargoType);

            Car car = new Car(model, engine, cargo, tires);
            allCars.Add(car);
        }

        PrintCars(allCars);
    }
    private static void PrintCars(List<Car> allCars)
    {
        var type = Console.ReadLine();

        if (type == "fragile")
        {
            foreach (var car in allCars.Where(c => c.Cargo.CargoType == "fragile"))
            {
                foreach (var tire in car.Tire)
                {
                    if (tire.Presure < 1)
                    {
                        Console.WriteLine(car.Model);
                        break;
                    }
                }
            }
        }
        else
        {
            Console.WriteLine(string.Join("\n", allCars
                .Where(c => c.Cargo.CargoType == "flamable" && c.Engine.EnginePower > 250)
                .Select(c => c.Model)));
        }
    }
    static List<Tire> GetTyres(string[] currentCar)
    {
        List<Tire> tires = new List<Tire>();

        for (int i = 5; i < currentCar.Length; i += 2)
        {
            var pressure = double.Parse(currentCar[i]);
            var age = int.Parse(currentCar[i + 1]);
            tires.Add(new Tire(pressure, age));
        }
        return tires;
    }
}

