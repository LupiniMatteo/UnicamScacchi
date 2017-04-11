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
            orologio.TempoScaduto += notificaSconfitta;
                
            
            orologio.Accendi();
            orologio.Avvia();
            Console.ReadKey();

            
        }

        private static void notificaSconfitta(object sender, Colore colore)
        {
           Console.WriteLine ($"Il giocatore  {colore} ha perso la partita!");
        }
    }
}
