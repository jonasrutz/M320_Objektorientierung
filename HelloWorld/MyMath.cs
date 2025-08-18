using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class MyMath
    {
        static internal int Calc_ggT(int a, int b)
        {
            
            while (b != 0)
            {
                int z;
                z = a % b;
                a = b;
                b = z;
            }
            return a;
        }

        static internal int Calc_kgv(int a, int b)
        {
            if (a == 0 | b == 0)
            {
                return 0;
            }
            
            int ggt = Calc_ggT(a, b);
            return (a * b) / ggt;
        }

        static internal int ReadInt() 
        {
            return 0;
        }

        static internal string ShowResult(int a, int b, int ggt, int kgv)
        {
            Console.WriteLine($"ggt von {a} und {b} ist {ggt}");
            Console.WriteLine($"kgv von {a} und {b} ist {kgv}");
        }
    }
}
