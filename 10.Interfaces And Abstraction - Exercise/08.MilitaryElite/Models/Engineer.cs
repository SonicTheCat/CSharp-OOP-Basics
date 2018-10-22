using System.Collections.Generic;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public IReadOnlyCollection<IRepair> Repairs { get; }

        public Engineer(string id, string firstname, string lastname, double salary, string corp, 
            List<IRepair> repairs)
            : base(id, firstname, lastname, salary, corp)
        {
            Repairs = repairs;
        }

        public override string ToString()
        {
            var result = base.ToString() + "\nRepairs:";

            foreach (var r in Repairs)
            {
                result += $"\n{r}";
            }
            return result;
        }
    }
}
