using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk05_a1_lidl
{
    internal class Kunde : Person
    {
        public double umsatz;

        public void kaufen()
        {
            Console.WriteLine("Ich kaufe etwas");
        }

        public override void trargen()
        {
            Console.WriteLine("Trage die Einkaufstaschen");
        }
    }
}
