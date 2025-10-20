using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk04_a1_kunde_buch
{
    internal class Kunde
    {
        private List<Buch> bucher = new List<Buch> ();

        public void AddBuch(Buch buch)
        {
            bucher.Add(buch);
        }
    }
}
