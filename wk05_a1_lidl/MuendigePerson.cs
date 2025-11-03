using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk05_a1_lidl
{
    internal abstract class MuendigePerson : Person, IPayment
    {
        public virtual void Zahle(int betrag)
        {
            Console.WriteLine($"Ich bezahle den {betrag}CHF");
        }

        public MuendigePerson(string name, string vorname, int identNr, string key)
            : base(name, vorname, identNr, key)
        {
        }
    }
}
