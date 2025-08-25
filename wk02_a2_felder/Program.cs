using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace wk02_a2_felder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle();

            Console.WriteLine(rectangle1.height);
            Console.WriteLine(rectangle1.color);

            rectangle1.color = "blue";
            Console.WriteLine(rectangle1.color);
        }
    }
}
