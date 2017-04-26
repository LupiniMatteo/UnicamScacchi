using System;

namespace Scacchi
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleXUnitRunner.SimpleXUnit.RunTests();
            IOrologio orologio = new Orologio(TimeSpan.FromSeconds(5));
            //orologio.TempoScaduto += notificaSconfitta;
                
            
            orologio.Accendi();
            orologio.Avvia();
            Console.ReadKey();
         
        }


            /*IScacchiera scacchiera = new Scacchiera();
            scacchiera
            .Case
            .ConPezzi(Colore.Bianco)
            .DiTipo<Pedone>();*/

        /*
        private static void NotificaSconfitta(object sender, Colore colore)
        {
            Console.WriteLine($"(Dal metodo): Il giocatore {colore} ha perso la partita, secondo l'orologio {sender}!");
        }
        */
    }
}
