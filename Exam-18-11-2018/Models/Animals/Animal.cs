using AnimalCentre.Models.Contracts;
using System;

namespace AnimalCentre.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        private const string Default_Owner = "Centre";

        private int happiness;
        private int energy;

        protected Animal(string name, int energy, int happiness, int procedureTime)
        {
            this.Name = name;
            this.Energy = energy;
            this.Happiness = happiness;
            this.ProcedureTime = procedureTime;
            this.Owner = Default_Owner;
            this.IsAdopt = false;
            this.IsChipped = false;
            this.IsVaccinated = false;
        }

        public string Name { get; }

        public int Happiness
        {
            get
            {
                return this.happiness;
            }
           private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Invalid happiness");
                }
                else
                {
                    this.happiness = value;
                }
            }
        }

        public int Energy
        {
            get
            {
                return energy;
            }
          private  set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Invalid energy");
                }

                this.energy = value;
            }
        }

        public int ProcedureTime { get; set; }

        public string Owner { get; private set; }

        public bool IsAdopt { get; set; }

        public bool IsChipped { get; set; }

        public bool IsVaccinated { get; set; }

        public void IncreaseHappiness(int value)
        {
            this.Happiness += value;
        }

        public void DecreaseHappiness(int value)
        {
            this.Happiness -= value;
        }

        public void IncreaseEnergy(int value)
        {
            this.Energy += value;
        }

        public void DecreaseEnergy(int value)
        {
            this.Energy -= value;
        }

        public void SubstractProcedureTime(int value)
        {
            this.ProcedureTime -= value; 
        }

        public void ChangeOwner(string value)
        {
            this.Owner = value; 
        }
    }
}
