using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax_oppgave
{
    internal class Bil : Vehicle
    {
        public int MaxFart { get; set; }

        public string Color { get; set; }

        public string Klasse { get; set; }


        public Bil(string regnr, int effekt, int maxfart, string color, string klasse) : base(regnr, effekt)
        {
            MaxFart = maxfart;
            Color = color;
            Klasse = klasse;

        }

        public void printCar()
        {
            Console.WriteLine(@$"
            Regnr:          {RegNr}
            Effekt:         {Effekt}kw
            Maksfart:       {MaxFart}km/t
            Farge:          {Color}
            Lett Kjøretøy:  {Klasse}");
        }

        public void isEqualTo(Bil bil2)
        {
            bool likeBiler = (MaxFart == bil2.MaxFart) &&
                             (Color == bil2.Color) &&
                             (Klasse == bil2.Klasse) &&
                             (RegNr == bil2.RegNr) &&
                             (Effekt == bil2.Effekt);
            Console.WriteLine(likeBiler ? " Bilene er like" : " Bilene er ikke like");
        }

        public void kjør()
        {
            Console.WriteLine($"{RegNr} er nå på veien!");
        }

    }
}
