using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk05_a1_lidl
{
    internal class Kunde : Person
    {
        public double umsatz { get; set; }

        public void kaufen()
        {
            Console.WriteLine($"{vorname} kauft etwas.");
        }

        public override void trarge()
        {
            Console.WriteLine($"{vorname} trägt die Einkaufstaschen.");
        }
    }
}
