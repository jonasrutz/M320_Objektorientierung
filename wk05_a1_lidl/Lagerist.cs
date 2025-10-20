using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk05_a1_lidl
{
    internal class Lagerist : Person
    {
        public int groesse { get; set; }

        public void lager()
        {
            Console.WriteLine($"{vorname} lagert etwas ein.");
        }

        public override void trarge()
        {
            Console.WriteLine($"{vorname} trägt die Paletten.");
        }
    }
}
