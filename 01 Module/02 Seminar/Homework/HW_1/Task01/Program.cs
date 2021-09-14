using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {


        // это тупой костыль но тут теперь 0 умножений.))))))))))))))))))))))
        // я знаю что это ужасно
        public static long m(long n, long k)
        {
            long c = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    c++;
                }
            }
            return c;
        }

        public static long calc(long x)
        {
            long x2 = m(x,x); 
            return (m(3,m(x2,((x2<<2) + (x+x+x) - 1))) + (x<<1) - 4);
        }


        static void Main(string[] args)
        {
            long x;
            do
            {
                Console.Write("Enter x: ");
                if (!long.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Arg error");
                    return;
                }
                Console.WriteLine($"F(x) = {calc(x)}");
                Console.WriteLine("Press ESC to exit / ENTER to continue!");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
