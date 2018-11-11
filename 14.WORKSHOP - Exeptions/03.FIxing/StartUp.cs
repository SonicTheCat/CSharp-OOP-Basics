using System;

namespace FIxing
{
    public class StartUp
    {
        public static void Main()
        {
            string[] weekdays = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday" };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(weekdays[i]);
            }           
        }
    }
}
