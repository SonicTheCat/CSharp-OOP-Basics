using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var accounts = new Dictionary<int, BankAccount>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var split = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var command = split[0];
            var id = int.Parse(split[1]); 

            if (command == "Create")
            {
                CreateAcc(accounts, id);
            }
            else if (command == "Deposit")
            {
                if (isValidAccount(accounts,id))
                {
                    accounts[id].Deposit(decimal.Parse(split[2]));
                }
            }
            else if (command == "Withdraw")
            {
                if (isValidAccount(accounts, id))
                {
                    accounts[id].Withdraw(decimal.Parse(split[2]));
                }
            }
            else
            {
                if (isValidAccount(accounts, id))
                {
                    Console.WriteLine(accounts[id]);
                }
            }
        }
    }
    static void CreateAcc(Dictionary<int, BankAccount> accounts, int id)
    {
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            var current = new BankAccount();
            current.Id = id;
            accounts.Add(id, current);
        }
    }
    static bool isValidAccount(Dictionary<int, BankAccount> accounts, int id)
    {
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
            return false;
        }
        return true;
    }
}

