using System;

namespace Task01
{
    class Program
    {
        static ulong F(ulong n, ulong pos)
        {
            ulong m = (ulong) Math.Pow(10,pos);
            ulong k = n / m;
            while (Length(k) > 1)
            {
                k %= 10;
            }
            return k;
        }

        static ulong Swap(ulong n, ulong m, ulong l, ulong pos_m, ulong pos_l)
        {
            ulong fuck = (ulong)Math.Pow(10, pos_m) * m;
            ulong s = n - fuck;

            ulong fuck2 = (ulong)Math.Pow(10, pos_l) * l;
            s -= fuck2;

            s += (ulong)Math.Pow(10, pos_m) * l;
            s += (ulong)Math.Pow(10, pos_l) * m;
            return s;

        }

        static ulong Length(ulong n) => n == 0 ? 0 : 1 + Length(n / 10);
        static ulong FuckArrays(ulong n)
        {
            ulong len = Length(n);
            for (ulong i = 0; i < len; i++)
                for (ulong j = i; j < len; j++)
                    if (F(n,i) > F(n,j))
                        n = Swap(n, F(n, i), F(n, j), i, j);
            return n;
        }
        static void Main(string[] args)
        {
            ulong n;
            if (!ulong.TryParse(Console.ReadLine(), out n)) {
                return;
            }
            Console.WriteLine(Length(n));
            Console.WriteLine(FuckArrays(n));
        }
    }
}
