using System;

class Program
{
    static void Main()
    {
        PriceCalculator priceCalc = new PriceCalculator(Console.ReadLine);
        var result = priceCalc.TotalPrice();

        Console.WriteLine(result.ToString("F2"));
    }
}