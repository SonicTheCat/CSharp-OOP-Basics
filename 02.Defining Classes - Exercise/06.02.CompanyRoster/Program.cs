using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var employees = GetEmployees();

        var result = employees
            .GroupBy(x => x.Department)
            .Select(d => new
            {
                Department = d.Key,
                Average = d.Average(emp => emp.Salary),
                Employees = d.OrderByDescending(emp => emp.Salary).ToList()
            })
        .OrderByDescending(d => d.Average)
        .FirstOrDefault();

        if (result != null)
        {
            Console.WriteLine($"Highest Average Salary: {result.Department}");
            result.Employees
                             .ForEach(e => Console.WriteLine(e.ToString()));
        }
    }

    private static List<Employee> GetEmployees()
    {
        var employees = new List<Employee>();
        var numberOfEmployees = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfEmployees; i++)
        {
            var employeeInfo = Console.ReadLine()
                               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
           
            var employee = new Employee(
                            employeeInfo[0],
                            decimal.Parse(employeeInfo[1]),
                            employeeInfo[2],
                            employeeInfo[3]);
        
            if (employeeInfo.Length > 4)
            {
                var emailOrAge = employeeInfo[4];
                if (emailOrAge.Contains("@"))
                {
                    employee.Email = emailOrAge;
                }
                else
                {
                    employee.Age = int.Parse(emailOrAge);
                }
            }
            if (employeeInfo.Length > 5)
            {
                employee.Age = int.Parse(employeeInfo[5]);
            }
            employees.Add(employee);
        }
        return employees;
    }
}
