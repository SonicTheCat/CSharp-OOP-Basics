using System;

namespace P03_StudentSystem
{
    class StartUp
    {
        static void Main()
        {
            StudentSystem studentSystem = new StudentSystem();

            string input;
            while ((input = Console.ReadLine()) != "Exit")
            {
                studentSystem.ParseCommand(input);              
            }
        }
    }
}
