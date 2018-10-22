using MilitaryElite.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public IReadOnlyCollection<IMission> Missions { get; }

        public Commando(string id, string firstname, string lastname, double salary, string corp,
          List<IMission> missions)
          : base(id, firstname, lastname, salary, corp)
        {
            Missions = missions;             
        }

        public override string ToString()
        {
            var result = base.ToString() + "\nMissions:";
            foreach (var m in Missions)
            {
                result += $"\n{m}";
            }
            return result; 
        }
    }
}