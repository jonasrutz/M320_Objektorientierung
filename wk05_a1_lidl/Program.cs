namespace wk05_a1_lidl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kunde kunde1 = new Kunde() { vorname = "Lars", name = "Hellstern", umsatz = 21345.34 };

            Lagerist lagerist1 = new Lagerist() { vorname = "Stefan", name = "Paulus", groesse = 182, };

            Kind kind1 = new Kind() { vorname = "Adriana", name = "Rutz", alter = 12 };



            kunde1.esse();
            kunde1.kaufen();
            kunde1.trarge();
            lagerist1.esse();
            lagerist1.lager();
            lagerist1.trarge();
            kind1.esse();
            kind1.trarge();


        }
    }
}
