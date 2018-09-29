namespace _01._01.RhombusОfStars
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int rombusSize = int.Parse(Console.ReadLine());

            for (int row = 1; row <= rombusSize; row++)
            {
                PrintRow(row, rombusSize - row);
            }
            for (int row = rombusSize; row >= 0; row--)
            {
                PrintRow(row - 1, rombusSize - row + 1);
            }
        }

        static void PrintRow(int stars, int whiteSpaces)
        {
            Console.Write(new string(' ', whiteSpaces));
            for (int i = 0; i < stars; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
