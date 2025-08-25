using System.ComponentModel.Design;

namespace wk02_a3_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool weiter = true;

            while (weiter)
            {
                Console.WriteLine("====================================\r\n       MATHE MENU\r\n====================================\r\n[1] Addition (+)\r\n[2] Subtraktion (-)\r\n[3] Multiplikation (×)\r\n[4] Division (÷)\r\n[5] Exit\r\n====================================\r\nBitte wähle eine Option: _");
                string antwort = Console.ReadLine();
                double a = 0, b = 0;
                if (antwort == "1")
                {
                    (a, b) = methodes.ZahlenAbfrage();
                    double addition = methodes.CalcAddition(a, b);
                    Console.WriteLine($"{a} + {b} = {addition}");
                }
                else if (antwort == "2")
                {
                    (a, b) = methodes.ZahlenAbfrage();
                    double subtraktion = methodes.CalcSubtraktion(a, b);
                    Console.WriteLine($"{a} - {b} = {subtraktion}");
                }
                else if (antwort == "3")
                {
                    (a, b) = methodes.ZahlenAbfrage();
                    double multiplikation = methodes.CalcMultiplikation(a, b);
                    Console.WriteLine($"{a} × {b} = {multiplikation}");
                }
                else if (antwort == "4")
                {
                    (a, b) = methodes.ZahlenAbfrage();
                    if (b != 0)
                    {
                        double division = methodes.CalcDivision(a, b);
                        Console.WriteLine($"{a} ÷ {b} = {division}");
                    }
                    else
                    {
                        Console.WriteLine("Division durch 0 ist nicht erlaubt.");
                    }
                }
                else if (antwort == "5")
                {
                    Console.WriteLine("Bis zum nächsen mal");
                    weiter = false;
                }
                else
                {
                    Console.WriteLine("geben sie eine mögliche antwort");
                }
            }
        }
    }
}
