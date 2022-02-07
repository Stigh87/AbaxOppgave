using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax_oppgave
{
    internal class Vehicle
    {
        public string RegNr { get; set; }
        public int Effekt { get; set; }

        public Vehicle(string regnr, int effekt)
        {
            RegNr = regnr;
            Effekt = effekt;
        }

    }
}
