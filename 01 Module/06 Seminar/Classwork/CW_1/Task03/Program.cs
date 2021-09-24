using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            bool s = true;
            s &= int.TryParse(Console.ReadLine(), out n);
            s &= int.TryParse(Console.ReadLine(), out m);
            if (!s) return;

            Console.WriteLine((1 << n) + (1 << m));
        }
    }
}
