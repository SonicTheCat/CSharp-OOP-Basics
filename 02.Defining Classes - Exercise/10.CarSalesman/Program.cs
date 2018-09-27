using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int numOfEngines = int.Parse(Console.ReadLine());
        List<Engine> engines = new List<Engine>();

        for (int i = 0; i < numOfEngines; i++)
        {
            engines.Add(GetEngines());
        }

        int numOfCars = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < numOfCars; i++)
        {
            cars.Add(GetCars(engines));
        }
        cars.ForEach(Console.WriteLine);
    }

    static Car GetCars(List<Engine> engines)
    {
        var data = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

        var model = data[0];
        var engine = engines.Where(e => e.Model == data[1]).FirstOrDefault();
        string weigth = "n/a";
        string color = "n/a";

        if (data.Length == 3)
        {
            bool isNum = double.TryParse(data[2], out _);
            if (isNum)
            {
                weigth = data[2];
            }
            else
            {
                color = data[2];
            }
        }
        else if (data.Length == 4)
        {
            weigth = data[2];
            color = data[3];
        }
        return new Car(model, engine, weigth, color);
    }
    static Engine GetEngines()
    {
        var data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        var model = data[0];
        var power = double.Parse(data[1]);
        string displacement = "n/a";
        string efficiency = "n/a";

        if (data.Length == 3)
        {
            bool isNum = double.TryParse(data[2], out _);
            if (isNum)
            {
                displacement = data[2];
            }
            else
            {
                efficiency = data[2];
            }
        }
        else if (data.Length == 4)
        {
            displacement = data[2];
            efficiency = data[3];
        }
        return new Engine(model, power, displacement, efficiency);
    }
}
