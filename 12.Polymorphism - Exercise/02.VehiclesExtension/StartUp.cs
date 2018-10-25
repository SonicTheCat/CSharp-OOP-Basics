using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var vehicles = new List<Vehicle>(); 

        var tokens = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
        vehicles.Add(new Car(tokens[0], tokens[1], tokens[2]));
        tokens = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
        vehicles.Add(new Truck(tokens[0], tokens[1], tokens[2]));
        tokens = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
        vehicles.Add(new Bus(tokens[0], tokens[1], tokens[2]));
        
        var countOfLines = int.Parse(Console.ReadLine());
        for (int i = 0; i < countOfLines; i++)
        {
            var commands = Console.ReadLine().Split();

            var command = commands[0];
            var type = commands[1];
            var value = double.Parse(commands[2]);

            var vehicle = vehicles.First(v => v.GetType().Name == type);
            TriggerCommand(vehicle, command, value);
        }
        vehicles.ForEach(v => Console.WriteLine(v));
    }

    public static void TriggerCommand(Vehicle vehicle, string command, double value)
    {
        switch (command)
        {
            case "Drive": Console.WriteLine(vehicle.Drive(value)); break;
            case "Refuel":
                try
                {
                    vehicle.Refuel(value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                break;
            case "DriveEmpty": Console.WriteLine(vehicle.Drive(value, false)); break;
        }
    }
}