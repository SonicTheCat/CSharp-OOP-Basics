using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var rectangles = new Dictionary<string, Rectangle>();

        for (int i = 0; i < numbers[0]; i++)
        {
            var data = Console.ReadLine().Split();

            var id = data[0];
            var width = double.Parse(data[1]);
            var height = double.Parse(data[2]);
            var horizontal = double.Parse(data[3]);
            var vertical = double.Parse(data[4]);

            rectangles[id] = new Rectangle(id,width,height,horizontal,vertical);
        }

        for (int i = 0; i < numbers[1]; i++)
        {
            var ids = Console.ReadLine().Split();

            Rectangle firstRec = rectangles[ids[0]];
            Rectangle secondRec = rectangles[ids[1]];

            Console.WriteLine(firstRec.FindIntersection(secondRec));
        }
    }
}