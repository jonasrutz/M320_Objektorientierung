using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk04_a3_konto_kunde
{
    internal class Kunde
    {
        private int kontoanzahl;
        private List<Konto> konto = new List<Konto>();

        public Kunde()
        {
            
            konto.Add(new Konto());
            kontoanzahl = 1;
        }

        public void AddKonto()
        {
            if (kontoanzahl < 5)
            {
                konto.Add(new Konto());
                kontoanzahl++;
            }
            else
            {
                Console.WriteLine("Sie haben bereits 5 Konton ");
            }
        }
    }
}
