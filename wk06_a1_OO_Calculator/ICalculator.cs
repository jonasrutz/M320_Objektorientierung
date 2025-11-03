using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk06_a1_OO_Calculator
{
    internal interface ICalculator
    {
        int Add(int a, int b);
        int Sub(int a, int b);
        int Mult(int a, int b);
        int Div(int a, int b);
    }
}
