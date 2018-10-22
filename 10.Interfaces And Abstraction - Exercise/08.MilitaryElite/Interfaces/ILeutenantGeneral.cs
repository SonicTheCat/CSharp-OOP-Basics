using System.Collections.Generic;

namespace MilitaryElite.Interfaces
{
    interface ILeutenantGeneral
    {
        IReadOnlyCollection<IPrivate> Privates { get; }
    }
}
