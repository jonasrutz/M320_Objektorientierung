using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk05_a1_lidl
{
    internal class Kind : Person
    {
        public int Alter { get; set; }

        public Kind(string vorname, string name, int identNr, string key, int alter) : base(vorname, name, identNr, key)
        {
            Alter = alter;
        }

        public override void Esse()
        {
            base.Esse();
            Console.WriteLine("   ... Nein, als Kleinkind {0} {1} {2} mit Alter {3} natürlich von Hand...", Vorname, Name, IdentNr, Alter);
        }

        public override void Trage()
        {
            Console.WriteLine("Ich als Kleinkind {0} {1} {2} trage gar nichts", Vorname, Name, IdentNr);

        }
    }
}
