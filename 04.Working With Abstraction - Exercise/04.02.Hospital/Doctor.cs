using System.Collections.Generic;
using System.Linq;

class Doctor
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Patient> Patients { get; set; }

    public Doctor(string firstname, string lastname, string patient)
    {
        FirstName = firstname;
        LastName = lastname;
        this.Patients = new List<Patient>();
        AddPatient(patient);
    }

    public void AddPatient(string patient)
    {
        Patients.Add(new Patient(patient));
    }

    public override string ToString()
    {
        return string.Join("\n", this
              .Patients
              .OrderBy(p => p.Name)
              .Select(p => p.Name)
              .ToArray());
    }
}