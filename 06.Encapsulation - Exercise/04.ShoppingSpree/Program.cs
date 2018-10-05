using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>();
        List<Product> products = new List<Product>();

        GetAllPeople(people);
        GetAllProducts(products);

        while (true)
        {
            var commands = Console.ReadLine().Split();
            if (commands[0] == "END")
            {
                break;
            }

            var person = people.FirstOrDefault(p => p.Name == commands[0]);
            var product = products.FirstOrDefault(p => p.Name == commands[1]);
            if (person != null && product != null)
            {
                var canAfford = person.CanAfford(product);
                Console.WriteLine(canAfford);
            }

        }
        people.ForEach(p => Console.WriteLine(p));
    }

    static void GetAllPeople(List<Person> people)
    {
        var peopleAndMoney = Console
            .ReadLine()
            .Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < peopleAndMoney.Length; i += 2)
        {
            string name = peopleAndMoney[i];
            int money = int.Parse(peopleAndMoney[i + 1]);
            try
            {
                var person = new Person(name, money);
                people.Add(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
        }
    }
    static void GetAllProducts(List<Product> products)
    {
        var productsAndCost = Console
            .ReadLine()
            .Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < productsAndCost.Length; i += 2)
        {
            string name = productsAndCost[i];
            int cost = int.Parse(productsAndCost[i + 1]);

            try
            {
                products.Add(new Product(name, cost));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
        }
    }
}