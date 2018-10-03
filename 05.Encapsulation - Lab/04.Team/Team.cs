using System;
using System.Collections.Generic;
using System.Text;

public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;

    public IReadOnlyCollection<Person> FirstTeam
    {
        get => this.firstTeam;  
    }
    public IReadOnlyCollection<Person> ReserveTeam
    {
        get => this.reserveTeam;
    }

    public Team(string name)
    {
        this.name = name;
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
    }

    public void AddPlayer(Person person)
    {
        if (person.Age >= 40)
        {
            reserveTeam.Add(person);
        }
        else
        {
            firstTeam.Add(person); 
        }
    }
}