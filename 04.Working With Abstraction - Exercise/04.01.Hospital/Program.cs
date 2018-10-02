using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<Department> departments = new List<Department>();
        List<Doctor> doctors = new List<Doctor>();

        string input;
        while ((input = Console.ReadLine()) != "Output")
        {
            var tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            GetDepartments(tokens, departments);
            GetDoctors(tokens, doctors);
        }

        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length == 1)
            {
                var department = departments.First(d => d.DepartmentName == tokens[0]);
                Console.Write(department);
            }
            else
            {
                int roomNumber;
                if (int.TryParse(tokens[1], out roomNumber))
                {
                    var department = departments.First(d => d.DepartmentName == tokens[0]);
                    var patients = department.GetPatientsInRoom(roomNumber);
                    Console.WriteLine(patients);
                }
                else
                {
                    var doctor = doctors.First(d => d.FirstName == tokens[0] && d.LastName == tokens[1]);
                    Console.WriteLine(doctor);
                }
            }
        }
    }

    static void GetDoctors(string[] tokens, List<Doctor> doctors)
    {
        var firstName = tokens[1];
        var lastName = tokens[2];
        var patient = tokens[3];

        foreach (var doctor in doctors)
        {
            if (doctor.FirstName == firstName && doctor.LastName == lastName)
            {
                doctor.AddPatient(patient);
                return;
            }
        }
        doctors.Add(new Doctor(firstName, lastName, patient));
    }

    static void GetDepartments(string[] tokens, List<Department> departments)
    {
        var department = tokens[0];
        var patient = tokens[3];

        foreach (var d in departments)
        {
            if (d.DepartmentName == department)
            {
                d.FindRoomForPatient(patient);
                return;
            }
        }
        departments.Add(new Department(department, patient));
    }
}