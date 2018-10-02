using System;

class Program
{
    static void Main()
    {
        Bag bag = new Bag(Console.ReadLine());
        var intput = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < intput.Length; i += 2)
        {
            var type = intput[i];
            var amount = long.Parse(intput[i + 1]);

            bool isValid = bag.IsBelowBagCapacity(amount);
            if (isValid)
            {
                bag.ParseTreasure(type, amount);              
            }
        }

        bag
            .OrderByValue()
            .ForEach(x => Console.WriteLine(x));  
    } 
}