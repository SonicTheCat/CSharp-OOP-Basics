using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Rectangle rectangle = new Rectangle(Console.ReadLine); 

        int countOfPoints = int.Parse(Console.ReadLine());

        for (int i = 0; i < countOfPoints; i++)
        {
            var point = new Point(Console.ReadLine); 
            bool contains = rectangle.Contains(point);
            Console.WriteLine(contains);
        }
    }
}

