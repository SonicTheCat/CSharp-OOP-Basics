using System;

public class StartUp
{
    public static void Main()
    {
        Action<IPerson> PrintPerson = x => Console.WriteLine(x.GetName());
        Action<IResident> PrintResident = x => Console.WriteLine(x.GetName());

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split();
            Citizen citizen = new Citizen(tokens[0], tokens[1], tokens[2]);
            PrintPerson(citizen);
            PrintResident(citizen);          
        }
    }
}