using System;
using System.Collections.Generic;
using System.Linq;

class CarSalesman
{
    static void Main()
    {
        int engineCount = int.Parse(Console.ReadLine());
        List<Engine> engines = new List<Engine>();
        for (int i = 0; i < engineCount; i++)
        {
            string[] tokens = Console
                .ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            engines.Add(GetEngine(tokens));
        }

        int carCount = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();
        for (int i = 0; i < carCount; i++)
        {
            string[] tokesn = Console
                .ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            cars.Add(GetCar(tokesn, engines));
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
    static Car GetCar(string[] tokens, List<Engine> engines)
    {
        string model = tokens[0];
        string engineModel = tokens[1];
        Engine engine = engines.FirstOrDefault(x => x.model == engineModel);
        int weight = -1;

        if (tokens.Length == 3)
        {
            if (int.TryParse(tokens[2], out weight))
            {
                return new Car(model, engine, weight);
            }
            return new Car(model, engine, tokens[2]);
        }
        else if (tokens.Length == 4)
        {
            return new Car(model, engine, int.Parse(tokens[2]), tokens[3]);
        }
        return new Car(model, engine);
    }
    static Engine GetEngine(string[] tokens)
    {
        string model = tokens[0];
        int power = int.Parse(tokens[1]);
        int displacement = -1;

        if (tokens.Length == 3)
        {
            if (int.TryParse(tokens[2], out displacement))
            {
                return new Engine(model, power, displacement);
            }
            return new Engine(model, power, tokens[2]);
        }
        else if (tokens.Length == 4)
        {
            return new Engine(model, power, int.Parse(tokens[2]), tokens[3]);
        }
        return new Engine(model, power);
    }
}