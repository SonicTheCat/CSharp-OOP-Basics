using System.Collections.Generic;
using System.Linq;

public class Family
{
    private List<Person> people = new List<Person>();

    public void AddMember(Person member)
    {
        people.Add(member); 
    }

    public Person GetOldestMember()
    {
        return people.OrderByDescending(p => p.Age).ToArray()[0]; 
    }
}

