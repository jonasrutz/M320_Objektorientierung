namespace wk04_a1_kunde_buch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kunde fido = new Kunde();
            Kunde beni = new Kunde();
            Buch die_drei_fragezeichen = new Buch(fido);
            Buch pipo_der_raecher = new Buch(beni);
        }
    }
}
