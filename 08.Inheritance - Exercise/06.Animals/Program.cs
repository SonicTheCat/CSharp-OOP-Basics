using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            var type = Console.ReadLine();
            if (type == "Beast!") break;

            try
            {
                Animal animal = GetAnimal(type);
                Console.WriteLine(animal);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    private static Animal GetAnimal(string type)
    {
        var tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        if (type == "Cat")
            return new Cat(tokens[0], int.Parse(tokens[1]), tokens[2]);
        else if (type == "Dog")
            return new Dog(tokens[0], int.Parse(tokens[1]), tokens[2]);
        else if (type == "Frog")
            return new Frog(tokens[0], int.Parse(tokens[1]), tokens[2]);
        else if (type == "Kitten")
            return new Kitten(tokens[0], int.Parse(tokens[1]));
        else if (type == "Tomcat")
            return new Tomcat(tokens[0], int.Parse(tokens[1]));
        else
            throw new ArgumentException("Invalid input!");
    }
}