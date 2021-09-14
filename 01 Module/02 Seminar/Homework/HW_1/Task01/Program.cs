using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {

        public static long calc(long x)
        {
            long x2 = x * x; // 3 умножения)))))
            return (3*x2*((x2<<2) + (x+x+x) - 1) + (x<<1) - 4);
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
