using System;

namespace _01.SquareRoot
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                var number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentException();
                }
                Print(Math.Sqrt(number).ToString());
            }
            catch (FormatException)
            {
                Print("Invalid format");
            }
            catch(ArgumentException)
            {
                Print("Invalid argument");
            }
            finally
            {
                Print("Bye!");
            }
        }
        static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
