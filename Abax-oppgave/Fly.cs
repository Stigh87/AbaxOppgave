using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax_oppgave
{
    internal class Fly : Vehicle
    {
        public int Vingespenn;
        public int Lasteevne;
        public int Egenvekt;
        public string Klasse;


        public Fly(string regnr, int effekt, int vingespenn, int lasteevne, int egenvekt, string klasse) : base(regnr, effekt)
        {
            Vingespenn = vingespenn;
            Lasteevne = lasteevne;
            Egenvekt = egenvekt;
            Klasse = klasse;
            //printInfo();
        }

        public void printInfo()
        {
            Console.WriteLine($@"
            Regnr:      {RegNr}
            Effekt:     {Effekt}kW
            Vingespenn: {Vingespenn}m
            Lasteevne:  {Lasteevne}tonn
            Egenvekt:   {Egenvekt}tonn
            Klasse:     {Klasse}");
        }

        public void kjør()
        {
            Console.WriteLine($"{RegNr} er nå i luften!");
        }
        
    }
}
