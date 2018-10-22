using System.Collections.Generic;

namespace MilitaryElite.Interfaces
{
    public interface IEngineer
    {
        IReadOnlyCollection<IRepair> Repairs { get; }
    }
}
