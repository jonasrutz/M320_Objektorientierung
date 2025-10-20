using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace wk03_a7_kapselung
{
    internal class Person
    {
        private int intensity;
        private int duration;

        //Funktionen
        public bool atMax()
        {
            return intensity == 100;
        }

        public Color colorHead()
        {
            if (intensity > 50)
            {
                return Color.Orange;
            }
            if (intensity > 80)
            {
                return Color.Orange;
            }
            else 
            {
                return Color.Yellow;
            }
        }
        public string signs()
        {
            return "";
        }

        public void Provoziere(int amount)
        {
            if (atMax())
            {
                return;
            }
            intensity += amount / 2;
        }

        public void Zureden(int amount)
        {
            intensity -= amount / 2;
        }
    }
}
