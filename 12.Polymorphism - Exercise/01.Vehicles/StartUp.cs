using System;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main()
        {
            var carTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var truckTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var carStartQuantity = double.Parse(carTokens[1]);
            var carConsumption = double.Parse(carTokens[2]);

            var truckStartQuantity = double.Parse(truckTokens[1]);
            var truckConsumption = double.Parse(truckTokens[2]);

            Vehicle car = new Car(carStartQuantity, carConsumption);
            Vehicle truck = new Truck(truckStartQuantity, truckConsumption);

            var inputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLines; i++)
            {
                var tokens = Console.ReadLine().Split();
                double distanceOrFuel = double.Parse(tokens[2]); 

                if (tokens[1] == "Car")
                {
                    Action(car, tokens[0], distanceOrFuel);
                }
                else
                {
                    Action(truck, tokens[0], distanceOrFuel);
                }
            }
            Print(car.ToString());
            Print(truck.ToString());
        }

        static void Action(Vehicle vehicle, string command, double distanceOrFuel)
        {
            if (command == "Drive")
            {
                Print(vehicle.Drive(distanceOrFuel));
            }
            else
            {
                vehicle.Refuel(distanceOrFuel);
            }
        }

        static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}