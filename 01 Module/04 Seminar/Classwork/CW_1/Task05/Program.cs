using System;

namespace Task05
{
    class Program
    {

        static double Total(double k, double r, uint n)
        {
            return k+k * (r/100 * n);
        }
        static void Main(string[] args)
        {
            double k, r;
            uint n;
            bool s = true;
            s &= double.TryParse(Console.ReadLine(), out k);
            s &= double.TryParse(Console.ReadLine(), out r);
            s &= uint.TryParse(Console.ReadLine(), out n);
            if (!s) return;
            for (uint i = 0; i < n; i++)
            {
                Console.WriteLine($"{i+1} - {Total(k, r, i+1)}");
            }
        }
    }
}
