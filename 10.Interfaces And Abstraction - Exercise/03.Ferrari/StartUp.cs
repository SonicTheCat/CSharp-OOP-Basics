using System;

namespace Ferrari
{
   public class StartUp
    {
        static void Main()
        {
            var driver = Console.ReadLine(); 
            Ferrari spider = new Ferrari("488-Spider", driver);

            Console.WriteLine(spider);          
        }
    }
}