using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
   public abstract class Soldier : ISoldier
    {
        public string Id { get; }
        public string Firstname { get; }
        public string Lastname { get; }

        public Soldier(string id, string firstname, string lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }

        public override string ToString()
        {
            return $"Name: {Firstname} {Lastname} Id: {Id}"; 
        }
    }
}
