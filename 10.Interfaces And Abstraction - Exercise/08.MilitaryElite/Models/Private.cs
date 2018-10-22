using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Private : Soldier, IPrivate
    {
        public double Salary { get; }

        public Private(string id, string firstname, string lastname, double salary)
            : base(id, firstname, lastname)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + $" Salary: {Salary:F2}";
        }
    }
}
