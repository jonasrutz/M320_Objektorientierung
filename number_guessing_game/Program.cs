namespace number_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string startup = "_________                           _____________       \r\n__  ____/___  _____________________ ___  __/__  /______ \r\n_  / __ _  / / /  _ \\_  ___/_  ___/ __  /  __  __ \\  _ \\\r\n/ /_/ / / /_/ //  __/(__  )_(__  )  _  /   _  / / /  __/\r\n\\____/  \\__,_/ \\___//____/ /____/   /_/    /_/ /_/\\___/ \r\n                                                        \r\n_____   __                 ______                       \r\n___  | / /___  ________ ______  /______________         \r\n__   |/ /_  / / /_  __ `__ \\_  __ \\  _ \\_  ___/         \r\n_  /|  / / /_/ /_  / / / / /  /_/ /  __/  /             \r\n/_/ |_/  \\__,_/ /_/ /_/ /_//_.___/\\___//_/              \n";
            Console.WriteLine($"{startup}");

            bool entscheidung = true;
            while (entscheidung == true) 
            {
                Console.WriteLine("Wollen sie spielen? (y) (n)");
                string spielen = Console.ReadLine();

                if (spielen == "y")
                {
                    Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 10.");
                    bool spielenbool = true;
                    while (spielenbool)
                    {
                        if (int.TryParse(Console.ReadLine(), out int guess_number))
                        {
                            int rnd_number = logic.number_random();
                            if (rnd_number == guess_number)
                            {
                                Console.WriteLine("Glückwunsch sie haben gewonnen");
                            }
                            else
                            {
                                Console.WriteLine($"Die Zahl war {rnd_number}");
                                Console.WriteLine($"Sie haben die nummer um {rnd_number - guess_number} verfehlt");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
                        }
                        spielenbool = false;
                    }
                    
                }
                else if (spielen == "n")
                {
                    Console.WriteLine("Okay, vlt. spaeter");
                    entscheidung = false;
                }
                else
                {
                    Console.WriteLine("Bitte nur 'y' oder 'n' eingeben.");
                }
            }
        }
    }
}
