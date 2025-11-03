using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk05_a1_lidl
{
    internal class Lagerist : MuendigePerson
    {
        public int Groesse { get; set; }

        public Lagerist(string vorname, string name, int identNr, string key, int groesse) : base(vorname, name, identNr, key)
        {
            Groesse = groesse;
        }

        public void LagereEin()
        {
            Console.WriteLine("Ich als Lagerist {0} {1} {2} lagere ein", Vorname, Name, IdentNr);
        }

        public override void Trage()
        {
            Console.WriteLine("Ich als Lagerist {0} {1} {2} trage mit dem Stapler", Vorname, Name, IdentNr);
        }
    }
}
