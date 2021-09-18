using System;

namespace Task01
{
    class Program
    {

        public static bool F(double x, double y) => x * x + y * y <= 2f * 2f && x >= y && x >= 0;

        static void Main(string[] args)
        {
            bool s = true;
            double x, y;
            s &= double.TryParse(Console.ReadLine(), out x);
            s &= double.TryParse(Console.ReadLine(), out y);
            if (s) Console.WriteLine(F(x, y));
        }
    }
}
