namespace wk02_a3_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool weiter = true;
            int? ergebnis = null; // Zwischenspeicher für das Ergebnis (int)

            while (weiter)
            {
                Console.WriteLine("====================================\r\n       MATHE MENU\r\n====================================\r\n[1] Addition (+)\r\n[2] Subtraktion (-)\r\n[3] Multiplikation (×)\r\n[4] Division (÷)\r\n[5] Exit\r\n====================================\r\nBitte wähle eine Option: _");
                string antwort = Console.ReadLine();
                double a, b;

                if (ergebnis.HasValue)
                {
                    Console.WriteLine($"Vorheriges Ergebnis: {ergebnis.Value}");
                    Console.WriteLine("Soll das Ergebnis als erster Wert verwendet werden? (j/n)");
                    string useResult = Console.ReadLine();
                    if (useResult?.ToLower() == "j")
                    {
                        a = ergebnis.Value; // int zu double
                        Console.WriteLine("Bitte zweiten Wert eingeben:");
                        while (!double.TryParse(Console.ReadLine(), out b))
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }
                    else
                    {
                        (a, b) = methodes.ZahlenAbfrage();
                    }
                }
                else
                {
                    (a, b) = methodes.ZahlenAbfrage();
                }

                double result = 0;

                if (antwort == "1")
                {
                    result = methodes.CalcAddition(a, b);
                    Console.WriteLine($"{a} + {b} = {result}");
                }
                else if (antwort == "2")
                {
                    result = methodes.CalcSubtraktion(a, b);
                    Console.WriteLine($"{a} - {b} = {result}");
                }
                else if (antwort == "3")
                {
                    result = methodes.CalcMultiplikation(a, b);
                    Console.WriteLine($"{a} × {b} = {result}");
                }
                else if (antwort == "4")
                {
                    if (b != 0)
                    {
                        result = methodes.CalcDivision(a, b);
                        Console.WriteLine($"{a} ÷ {b} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Division durch 0 ist nicht erlaubt.");
                        continue;
                    }
                }
                else if (antwort == "5")
                {
                    Console.WriteLine("Bis zum nächsen mal");
                    weiter = false;
                    continue;
                }
                else
                {
                    Console.WriteLine("geben sie eine mögliche antwort");
                    continue;
                }

                // Zwischenspeichern als int (z.B. gerundet)
                ergebnis = Convert.ToInt32(Math.Round(result));
            }
        }
    }
}
