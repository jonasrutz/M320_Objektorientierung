using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk02_a3_calculator
{
    internal class methodes
    {
        static internal double CalcAddition(double a, double b)
        {
            return a + b;
        }

        static internal double CalcSubtraktion(double a, double b)
        {
            return a - b;
        }

        static internal double CalcMultiplikation(double a, double b)
        {
            return a * b;
        }

        static internal double CalcDivision(double a, double b)
        {
            return a / b;
        }

        public static (double a, double b) ZahlenAbfrage()
        {
            double a, b;
            while (true)
            {
                Console.Write("Geben Sie die erste Zahl ein: ");
                if (double.TryParse(Console.ReadLine(), out a)) break;
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
            }
            while (true)
            {
                Console.Write("Geben Sie die zweite Zahl ein: ");
                if (double.TryParse(Console.ReadLine(), out b)) break;
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
            }
            return (a, b);
        }
    }
}
