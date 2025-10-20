using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk05_a1_lidl
{
    internal class Kind : Person
    {
        public int alter { get; set; }

        public override void trarge()
        {
            Console.WriteLine($"{vorname} trägt seine Jacke.");
        }

        public override void esse()
        {
            Console.WriteLine($"{vorname} isst mit den Händen.");
        }
    }
}
