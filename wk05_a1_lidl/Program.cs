namespace wk05_a1_lidl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kunde kunde1 = new Kunde() { vorname = "Lars", name = "Hellstern", umsatz = 21345.34 };

            Lagerist lagerist1 = new Lagerist() { vorname = "Stefan", name = "Paulus", groesse = 182, };
            
            kunde1.essen();
            kunde1.kaufen();
            kunde1.trargen();
            lagerist1.essen();
            lagerist1.lagern();
            lagerist1.trargen();


        }
    }
}
