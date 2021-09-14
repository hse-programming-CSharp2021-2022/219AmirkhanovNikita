using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {

        public static string r() => Console.ReadLine();

        public static int clac(double d, double a, double b)
        {
            Console.WriteLine("D < 0 -> no roots");
            return -1;
        }

        public static int calc(double d, double a, double b)
        {
            double dr = Math.Sqrt(d);
            double x1, x2;
            x1 = (-b + dr) / (2 * a);
            x2 = (-b - dr) / (2 * a);
            Console.WriteLine($"Roots: {x1}, {x2}");
            return 0;
        }

        static void Main(string[] args)
        {
            // ax2 +bx +c = 0
            double a, b, c, x, d;
            bool s = true;
            Dictionary<int, Func<double, double, double, int>> ez = new Dictionary<int, Func<double, double, double, int>>();
            ez[0] = calc;
            ez[1] = clac;
            do
            {
                Console.WriteLine("A,B,C:");
                s &= double.TryParse(r(), out a);
                s &= double.TryParse(r(), out b);
                s &= double.TryParse(r(), out c);
                if (!s) // if для проверки значений
                {
                    Console.WriteLine("args error");
                    return;
                }
                d = (b * b) - (4 * a * c);
                int ptr = d >= 0 ? 0 : 1;
                ez[ptr](d, a, b);
                Console.WriteLine("Press ESC to exit / ENTER to continue!");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
