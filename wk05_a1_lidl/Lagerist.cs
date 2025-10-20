using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk05_a1_lidl
{
    internal class Lagerist : Person
    {
        public int groesse;

        public void lagern()
        {
            Console.WriteLine("Ich lagere etwas ein.");
        }

        public override void trargen()
        {
            Console.WriteLine("Trage die Paletten.");
        }
    }
}
