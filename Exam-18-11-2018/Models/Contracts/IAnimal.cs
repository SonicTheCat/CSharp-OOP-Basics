namespace AnimalCentre.Models.Contracts
{
    public interface IAnimal
    {
        string Name { get; }

        int Happiness { get;  }

        int Energy { get;  }

        int ProcedureTime { get; }

        string Owner { get; }

        bool IsAdopt { get; set; }

        bool IsChipped { get; set; }

        bool IsVaccinated { get; set; }

        void IncreaseHappiness(int value);

        void DecreaseHappiness(int value);

        void IncreaseEnergy(int value);

        void DecreaseEnergy(int value);

        void SubstractProcedureTime(int value);

        void ChangeOwner(string value); 
    }
}
