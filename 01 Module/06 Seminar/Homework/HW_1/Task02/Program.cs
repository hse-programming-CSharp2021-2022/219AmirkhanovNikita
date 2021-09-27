using System;

namespace Task02
{
    class Program
    {

        static long Fact(long n)
        {
            long s = 1;
            for (int i = 1; i <= n; i++)
                s *= i;
            return s;
        }
        static double Method1(double x)
        {
            double n = x*x, prev = -1;
            long c = 1;
            long pow = 4;
            while (n - prev > 0)
            {
                prev = n;
                n += (c % 2 == 0 ? 1 : -1) * ((Math.Pow(2,pow-1)*Math.Pow(x,pow))/Fact(pow));
                pow += 2;
                c += 1;
            }
            return n;
        }

        static double Method2(double x)
        {
            double n = 1, prev = -1;
            long c = 1;
            while (n - prev > 0)
            {
                prev = n;
                n += (Math.Pow(x, c)) / (Fact(c));
                c += 1;
            }
            return n;
        }
        static void Main(string[] args)
        {
            double x;
            if (double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine(Method1(x));
                Console.WriteLine(Method2(x));
            }
                
        }
    }
}
