using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk04_a2_firma_mitarbeiter
{
    internal class Fima
    {
        private List<Mitarbeiter> mitarbeitern = new List<Mitarbeiter>();

        public Fima(Mitarbeiter mitarbeiter)
        {
            AddFestplatte(mitarbeiter);
        }

        public bool AddFestplatte(Mitarbeiter mitarbeiter)
        {
            if (!mitarbeiter.IstEingestellt)
            {
                mitarbeitern.Add(mitarbeiter);
                mitarbeiter.IstEingestellt = true;
                return true;
            }
            return false;
        }

        public Mitarbeiter RemoveFestPlatte()
        {
            if (mitarbeitern.Count == 0)
                return null;

            Mitarbeiter fp = mitarbeitern[0];
            mitarbeitern.RemoveAt(0);
            fp.IstEingestellt = false;
            return fp;
        }
    }
}
