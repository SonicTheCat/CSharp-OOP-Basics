using System.Collections.Generic;

namespace MilitaryElite.Interfaces
{
    public interface ICommando
    {
        IReadOnlyCollection<IMission> Missions { get; }
    }
}
