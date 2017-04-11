using System;
using Scacchi.Modello;

namespace Scacchi
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleXUnitRunner.SimpleXUnit.RunTests();
            IOrologio orologio = new Orologio(TimeSpan.FromSeconds(5));
            orologio.TempoScaduto += notificaSconfitta {
                Console.WriteLine{$"Il giocatore {colore} ha perso!"}
            }
            orologio.Accendi();
            orologio.Avvia();
            Console.ReadKey();

            
        }

        private static void notificaSconfitta(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
