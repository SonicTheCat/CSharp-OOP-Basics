using System;

class Program
{
    static void Main()
    {
        try
        {
            var tokens = Console.ReadLine().Split();
            Pizza pizza = new Pizza(tokens[1]);
            tokens = Console.ReadLine().Split();
            pizza.Dough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));

            string input; 
            while ((input = Console.ReadLine()) != "END")
            {
                tokens = input.Split();
                pizza.AddTopping(new Topping(tokens[1], double.Parse(tokens[2]))); 
            }

            Console.WriteLine(pizza.Name + " - " + pizza.TotalCalories() + " Calories.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}