using System;
using System.Collections.Generic;
using System.Linq;

namespace Scacchi.Modello {
    public class Scacchiera : IScacchiera
    {
        private ICasa[] listaCase;

       /* public Scacchiera() {
            listaCase= new ICasa[64];
            int contatore=0;
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++,contatore++)
                {
                    ICasa casa = new Casa((Colonna)j,(Traversa)i);
                    listaCase[contatore] = casa;
                }
            }

        }*/

        public Scacchiera()
        {
            listaCase = Enumerable
            //butta fuori un elenco di numeri fino a 63
            .Range(0, 64)
            //della fila di interi la posso trasformare usando la select, decidiamo noi cosa buttare fuori con la select
            .Select(i => (ICasa) new Casa((Colonna) (i%8+1), (Traversa) (i/8+1)))
            //to array trasforma tutto in array
            .ToArray();
        }
        public IEnumerable<ICasa> Case {
            get{
                return listaCase;
            }
        }

        public ICasa this[Colonna colonna, Traversa traversa] {
            get{
                return listaCase[(int) colonna-1+(((int) traversa-1)*8)];
            }
        }

    }
}