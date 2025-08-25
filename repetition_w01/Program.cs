namespace repetition_w01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            arr = new int[5];
            arr[3] = 200;
            arr[0] = 450;
            arr[1] = 700;
            arr[2] = 175;
            arr[4] = 250;

            int summe = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                summe += arr[i];
            }

            Console.WriteLine("Summe:" +summe);
        }
    }
}
