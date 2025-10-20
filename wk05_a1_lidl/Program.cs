namespace wk05_a1_lidl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Person person1 = new Person("Hans", "Meier");
            Kunde kunde1 = new Kunde("Fritz", "Mueller", 100, "KEY100", 1000.0);
            Lagerist lagerist1 = new Lagerist("Joe", "Manser", 101, "KEY101", 180);
            Kind kleinkind1 = new Kind("Kiddy", "Kid", 102, "KEY102", 3);

            //person1.Esse();
            kunde1.Esse();
            kunde1.Kaufe();
            kunde1.Trage();
            lagerist1.Esse();
            lagerist1.LagereEin();
            lagerist1.Trage();
            kleinkind1.Esse();
            kleinkind1.Trage();
        }
    }
}
