using System;

namespace Task03
{
    class Program
    {
        static ulong GCD(ulong a, ulong b) => b == 0 ? a : GCD(b, a % b);
        static ulong LCM(ulong a, ulong b) => (a * b) / GCD(a, b);
        static void NodNok(ulong a, ulong b, out ulong nod, out ulong nok)
        {
            nod = GCD(a,b);
            nok = LCM(a,b);
        }
        static void Main(string[] args)
        {
            ulong a, b;
            bool s = true;
            s &= ulong.TryParse(Console.ReadLine(), out a);
            s &= ulong.TryParse(Console.ReadLine(), out b);
            if (s)
            {
                ulong n, k;
                NodNok(a, b, out n, out k);
                Console.WriteLine($"GCD: {n}, LCM: {k}");
            }
        }
    }
}
