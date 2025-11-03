namespace wk05_a1_lidl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kunde kunde1 = new Kunde("Fritz", "Mueller", 100, "KEY100", 1000.0);
            Lagerist lagerist1 = new Lagerist("Joe", "Manser", 101, "KEY101", 180);
            Kind kleinkind1 = new Kind("Kiddy", "Kid", 102, "KEY102", 3);
            ChatBot chatbot1 = new ChatBot(); 

            List<IPublish> IPuhblishObjects = new List<IPublish>{kunde1, kleinkind1, lagerist1, chatbot1 };

            foreach (var value in IPuhblishObjects)
            {
                value.Publiziere($"Hello ich bin {value}");
            }

            kunde1.Esse();
            kunde1.Kaufe();
            kunde1.Trage();
            lagerist1.Esse();
            lagerist1.LagereEin();
            lagerist1.Trage();
            kleinkind1.Esse();
            kleinkind1.Trage();
            kunde1.Zahle(45);
            lagerist1.Zahle(234);
            kunde1.Publiziere("Ich bin der Kunde");
            lagerist1.Publiziere("Ich bin der Lagerist");
            kleinkind1.Publiziere("Ich bin das Kleinkind");

        }
    }
}
