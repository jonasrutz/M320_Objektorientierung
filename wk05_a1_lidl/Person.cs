using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk05_a1_lidl
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        protected int IdentNr { get; private set; }
        private string Key { get; set; }

        public Person(string name, string vorname, int identNr, string key)
        {
            Name = name;
            Vorname = vorname;
            IdentNr = identNr;
            Key = key;
        }

        public virtual void Esse()
        {
            System.Console.WriteLine("Ich als Person {0} {1} {2} esse mit Messer und Gabel", Vorname, Name, IdentNr);
        }

        public abstract void Trage();
    }
}
