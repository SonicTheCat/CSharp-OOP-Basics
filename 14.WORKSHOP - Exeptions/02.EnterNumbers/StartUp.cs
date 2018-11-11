using System;

namespace _02.EnterNumbers
{
    public class StartUp
    {
        public static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    ReadNumber(1, 100);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    i = -1;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                    i = -1;
                }
            }
        }

        static void ReadNumber(int start, int end)
        {
            var number = int.Parse(Console.ReadLine());

            if (number < start || number > end)
            {
                throw new ArgumentException($"The number should be in range {start} - {end}");
            }
        }
    }
}
