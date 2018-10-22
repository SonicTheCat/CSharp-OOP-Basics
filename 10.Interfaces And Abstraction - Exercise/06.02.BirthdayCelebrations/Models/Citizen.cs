using BirthdayCelebrations.Interfaces;
using System;

namespace BirthdayCelebrations.Models
{
    class Citizen : IIdentifiable, IName, IBirthable
    {
        public string Id { get; }
        public string Age { get; }
        public string Name { get; }
        public DateTime Birthdate { get; }

        public Citizen(string name, string age, string id, string birthdate)
        {
            this.Id = id;
            this.Age = age;
            this.Name = name;
            this.Birthdate = DateTime.ParseExact(birthdate, "dd/mm/yyyy", null); 
        }
    }
}
