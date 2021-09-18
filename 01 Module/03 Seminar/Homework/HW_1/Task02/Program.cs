using System;

namespace Task02
{
    class Program
    {

        public static double G(double x, double y)
        {
            if (x < y && x > 0) return x + Math.Sin(y);
            else if (x > y && x < 0) return y - Math.Cos(x);
            else return 0.5 * x * y;
        }
        static void Main(string[] args)
        {
            bool s = true;
            double x, y;
            s &= double.TryParse(Console.ReadLine(), out x);
            s &= double.TryParse(Console.ReadLine(), out y);
            if (s) Console.WriteLine(G(x, y));
        }
    }
}
