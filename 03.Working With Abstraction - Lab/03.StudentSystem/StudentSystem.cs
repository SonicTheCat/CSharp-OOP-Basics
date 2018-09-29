using System;
using System.Collections.Generic;

public class StudentSystem
{
    private Dictionary<string, Student> repo;

    public StudentSystem()
    {
        this.repo = new Dictionary<string, Student>();
    }

    public void ParseCommand(string args)
    {
        var splitArgs = args.Split();

        if (splitArgs[0] == "Create")
        {
            CreateStudent(splitArgs);
        }
        else if (splitArgs[0] == "Show")
        {
            ShowStudent(splitArgs, Console.WriteLine);
        }
    }

    private void CreateStudent(string[] args)
    {
        var name = args[1];
        var age = int.Parse(args[2]);
        var grade = double.Parse(args[3]);

        if (!repo.ContainsKey(name))
        {
            var student = new Student(name, age, grade);
            repo[name] = student;
        }
    }

    private void ShowStudent(string[] args, Action<string> printFunction)
    {
        var name = args[1];
        if (repo.ContainsKey(name))
        {
            var student = repo[name];

            printFunction(student.ToString());
        }
    }
}
