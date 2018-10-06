using System;

class Program
{
    static void Main()
    {
        RandomList randomList = new RandomList() { "pael", "sa", "ligael", "yambol", "tri", "moreta", "vitosha", "stud", "sofia" };
        Console.WriteLine(randomList.RandomString());
        Console.WriteLine(randomList.Count);

        Console.WriteLine(randomList.RandomString());
        Console.WriteLine(randomList.Count);

        Console.WriteLine(randomList.RandomString());
        Console.WriteLine(randomList.Count);

        Console.WriteLine(randomList.RandomString());
        Console.WriteLine(randomList.Count);

        Console.WriteLine(randomList.RandomString());
        Console.WriteLine(randomList.Count);

    }
}