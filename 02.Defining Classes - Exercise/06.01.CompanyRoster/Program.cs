using System;
using System.Collections.Generic;
using System.Linq;

class Program 
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var employees = new List<Employee>();
        var departmentsSalary = new Dictionary<string, decimal>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            FindBiggestSalaryByDepart(departmentsSalary, input);

            Employee current = GetCurrentEmployee(input);
            employees.Add(current);
        }
        string highestDepart = departmentsSalary
            .OrderByDescending(x => x.Value)
            .ToArray()[0]
            .Key;

        Console.WriteLine($"Highest Average Salary: {highestDepart}");

        employees = employees
            .Where(x => x.Department == highestDepart)
            .OrderByDescending(x => x.Salary)
            .ToList();

        foreach (var emp in employees)
        {
            Console.WriteLine(emp);
        }
    }
    static void FindBiggestSalaryByDepart(Dictionary<string, decimal> departmentsSalary, string[] input)
    {
        var salary = decimal.Parse(input[1]);
        var department = input[3];

        if (!departmentsSalary.ContainsKey(department))
        {
            departmentsSalary[department] = 0;
        }
        departmentsSalary[department] += salary;
    }

    static Employee GetCurrentEmployee(string[] input)
    {
        var name = input[0];
        var salary = decimal.Parse(input[1]);
        var position = input[2];
        var department = input[3];
        string email;
        int age;

        Employee currentEmp = new Employee(name, salary, position, department);

        if (input.Length == 5)
        {
            string str = input[4];
            bool isNumber = int.TryParse(str, out age);

            if (isNumber)
            {
                currentEmp.Age = age;
            }
            else
            {
                currentEmp.Email = str;
            }
        }
        else if (input.Length == 6)
        {
            email = input[4];
            age = int.Parse(input[5]);
            currentEmp.Age = age;
            currentEmp.Email = email;
        }
        return currentEmp;
    }
}

