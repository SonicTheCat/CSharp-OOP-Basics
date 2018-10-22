using System;
using System.Collections.Generic;

class StartUp
{
    static void Main()
    {
        List<Person> people = new List<Person>();

        Citizen citizen = new Citizen("Hasan", 1);
        citizen.CitizenShip = "Mangaliq";

        Worker plumer = new Worker("John", 34);
        plumer.Job = "Plumer";
        plumer.Salary = 23232.55m;

        Student student = new Student("Stamat", 15);
        student.studentId = 32323;

        people.Add(citizen);
        people.Add(plumer);
        people.Add(student);


        foreach (var p in people)
        {
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.SayHelloInYourLanguage());
            Console.WriteLine(new string('-', 10));
        }
    }
}