using System;

namespace Task03
{
    class Program
    {
        public static double G(double x) => x <= 0.5 ? Math.Sin(Math.PI / 2) : Math.Sin((Math.PI * (x - 1)) / 2);
        static void Main(string[] args)
        {
            double n;
            if (double.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine(G(n));
            }
        }
    }
}
