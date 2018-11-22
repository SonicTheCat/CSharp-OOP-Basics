using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Procedures
{
    public abstract class Procedure : IProcedure
    {
        protected List<IAnimal> ProcedureHistory { get; private set; }

        protected Procedure()
        {
            this.ProcedureHistory = new List<IAnimal>(); 
        }

        public string History()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.GetType().Name);
            foreach (var animal in this.ProcedureHistory)
            {
                sb.AppendLine(animal.ToString());
            }
            return sb.ToString().TrimEnd();
        }

        public virtual void DoService(IAnimal animal, int procedureTime)
        {
            if (animal.ProcedureTime >= procedureTime)
            {
                animal.SubstractProcedureTime(procedureTime);
                this.ProcedureHistory.Add(animal);
            }
            else
            {
                throw new ArgumentException("Animal doesn't have enough procedure time");
            }
        }
    }
}