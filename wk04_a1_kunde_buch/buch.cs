using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk04_a1_kunde_buch
{
    internal class Buch
    {
        private Kunde kunde;

        public Buch(Kunde kunde)
        {
            this.kunde = kunde;
            kunde.AddBuch(this);
        }
    }
}
