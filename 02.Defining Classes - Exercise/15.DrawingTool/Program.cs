using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();

        if (input == "Square")
        {
            var size = Console.ReadLine();
            Square sq = new Square(int.Parse(size));
            sq.Draw(); 
        }
        else if (input == "Rectangle")
        {
            var sizeOne = Console.ReadLine();
            var sizeTwo = Console.ReadLine();
            Rectangle rec = new Rectangle(int.Parse(sizeOne), int.Parse(sizeTwo));
            rec.Draw(); 
        }
    }
}

