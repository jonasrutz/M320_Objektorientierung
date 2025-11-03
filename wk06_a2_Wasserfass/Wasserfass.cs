using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk06_a2_Wasserfass
{
    public class Wasserfass
    {
        private int minimalPegel { get; }
        private int maximalPegel { get; }
        public int Fuellstand { get; }
        public int Kapazitaet { get;  }

        public int befüllen(int menge)
        {
            int newfuellstand = Fuellstand + menge;
            if (newfuellstand > Kapazitaet)
            {
                return Kapazitaet;
            }
            else
            {
                return newfuellstand;
            }
        }

        public int entnehmen(int menge)
        {
            int newfuellstand = Fuellstand - menge;
            if (newfuellstand < minimalPegel)
            {
                return minimalPegel;
            }
            else
            {
                return newfuellstand;
            }
        }

        public int entleeren()
        {
            int newfuellstand = Fuellstand - Fuellstand;
            return newfuellstand;
        }


        public Wasserfass()
        {
            this.Fuellstand = 50;
            this.Kapazitaet = 200;
            this.maximalPegel = 190;
            this.minimalPegel = 10;
        }

        public Wasserfass(int minimalPegel, int maximalPegel, int fuellstand, int kapazitaet)
        {
            this.minimalPegel = minimalPegel;
            this.maximalPegel = maximalPegel;
            this.Fuellstand = fuellstand;
            this.Kapazitaet = kapazitaet;
        }
    }
}
