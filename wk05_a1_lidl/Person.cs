using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk05_a1_lidl
{
    internal abstract class Person
    {
        public string name { get; set; }
        public string vorname { get; set; }

        public virtual void esse()
        {
            Console.WriteLine($"{vorname} {name} isst mit Messer und Gabel.");
        }

        public abstract void trarge();
    }
}
