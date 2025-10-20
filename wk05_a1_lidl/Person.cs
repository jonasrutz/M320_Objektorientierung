using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk05_a1_lidl
{
    internal abstract class Person
    {
        public string name;
        public string vorname;

        public void essen()
        {
            Console.WriteLine($"{vorname} {name} isst!");
        }

        public abstract void trargen();
    }
}
