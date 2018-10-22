using System.Collections.Generic;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public IReadOnlyCollection<IPrivate> Privates { get; }

        public LeutenantGeneral(string id, string firstname, string lastname, double salary, List<IPrivate> privates)
            : base(id, firstname, lastname, salary)
        {
            Privates = privates;
        }

        public override string ToString()
        {
            string result = base.ToString() + "\nPrivates:";
            foreach (var p in Privates)
            {
                result += $"\n{p}";
            }
            return result; 
        }
    }
}