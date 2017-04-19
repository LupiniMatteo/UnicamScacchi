using System.Collections.Generic;

namespace Scacchi.Modello
{
    public interface IScacchiera
    {
        //accesso sequenziale, che si scorre con un foreach che scorre tutte le case
        IEnumerable<ICasa> Case { get; }
        //acesso casuale
        ICasa this[Colonna colonna, Traversa traversa] { get; }
    }
}