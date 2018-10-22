using MilitaryElite.Interfaces;
using System;

namespace MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corp; 

        public string Corp
        {
            get => this.corp;
            private set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException(); 
                }
                this.corp = value;
            }
        }

        public SpecialisedSoldier(string id, string firstname, string lastname, double salary, string corp)
            : base(id, firstname, lastname, salary)
        {
            Corp = corp;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCorps: {Corp}";
        }
    }
}
