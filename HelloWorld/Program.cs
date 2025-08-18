namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int a = 16;
            int b = 3;

            int summe = MyMath.add(a, b);
            Console.WriteLine($"Summe von {a} und {b} = {summe}");

            int differenz = MyMath.subtract(a, b);
            Console.WriteLine($"Differenz von {a} und {b} = {differenz}");
        }
    }
}
