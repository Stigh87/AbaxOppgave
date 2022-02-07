using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax_oppgave
{
    internal class Båt : Vehicle
    {
        public int MaxFart;
        public int Vekt;
        

        public Båt(string regnr, int effekt, int maxFart, int vekt) : base(regnr, effekt)
        {
            MaxFart = maxFart;
            Vekt = vekt;
        }

        public void printBoat()
        {
            Console.WriteLine(@$"
            Regnr:          {RegNr}
            Effekt:         {Effekt}kw
            Maksfart:       {MaxFart}knop
            Vekt:           {Vekt}Tonn");
        }
    }
}
