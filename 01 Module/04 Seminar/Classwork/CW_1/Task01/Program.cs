using System;

namespace Task01
{
    class Program
    {

        static void f1()
        {
            float n = 0, prev = -1;
            long c = 1;
            while (n - prev > 0)
            {
                prev = n;
                n += 1f / (c * (c + 1) * (c + 2));
                c++;
            }
            Console.WriteLine(n);
        }

        static void f2()
        {
            double n = 0, prev = -1;
            long c = 1;
            while (n - prev > 0)
            {
                prev = n;
                n += 1f / (c * (c + 1) * (c + 2));
                c++;
            }
            Console.WriteLine(n);
        }
        static void Main(string[] args)
        {
            f1();
            f2();
        }
    }
}
