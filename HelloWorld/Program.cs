namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 12;
            int b = 16;


            int ggt = MyMath.Calc_ggT(a, b);
            Console.WriteLine(ggt);
            int kgv = MyMath.Calc_kgv(a, b);
            Console.WriteLine(kgv);
        }
    }
}
