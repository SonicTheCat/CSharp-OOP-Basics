using System.Collections.Generic;
using System.Linq;

class Doctor
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<string> patients { get; set; }

    public Doctor(string firstname, string lastname, string patient)
    {
        FirstName = firstname;
        LastName = lastname; 
        this.patients = new List<string>();
        AddPatient(patient); 
    }

    public void AddPatient(string patient)
    {
        patients.Add(patient); 
    }

    public override string ToString()
    {
        return string
            .Join("\n", this.patients
            .OrderBy(x => x));
    }
}