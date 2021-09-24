using System;

namespace Task01
{
    class Program
    {

        public static void Sums(uint n, out uint sumsEven, out uint sumsOdd)
        {
            uint _se = 0;
            uint _so = 0;
            string _s = n.ToString();
            for (int i = _s.Length-1; i > 0; i-=2)
            {
                _se += uint.Parse(_s[i].ToString());
                _so += uint.Parse(_s[i-1].ToString());
            }
            sumsEven = _se;
            sumsOdd = _so;
        }
        static void Main(string[] args)
        {
            uint n;
            if (!uint.TryParse(Console.ReadLine(), out n)) return;
            Sums(n, out uint a, out uint b);
            Console.WriteLine($"e: {a}, o: {b}");
        }
    }
}
