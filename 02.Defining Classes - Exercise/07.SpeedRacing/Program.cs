using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        List<Car> carsList = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            var carData = Console.ReadLine().Split();
            carsList.Add(new Car(carData[0], decimal.Parse(carData[1]), decimal.Parse(carData[2])));
        }

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var drive = input.Split();
            var model = drive[1];
            var amoutOfKm = int.Parse(drive[2]);

            carsList.Where(car => car.Model == model).ToList().ForEach(car => car.isFuelEnough(amoutOfKm));
        }
        Console.WriteLine(string.Join($"{Environment.NewLine}", carsList));
    }
}