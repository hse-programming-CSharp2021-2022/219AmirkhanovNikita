using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    class Program
    {

        public static string r() => Console.ReadLine();

        public static void method1(double n, out int a, out double b)
        {
            a = (int)n;
            b = n-a;
        }

        public static void method2(double n, out double a, out double b)
        {
            a = n * n;
            b = n >= 0 ? Math.Sqrt(n) : -1;
        }

        static void Main(string[] args)
        {
            double n;
            int a;
            double b, c, d;
            bool s = true;
            do
            {
                Console.WriteLine("N:");
                s &= double.TryParse(r(), out n);
                if (!s) // if для проверки значений
                {
                    Console.WriteLine("args error");
                    return;
                }
                method1(n, out a, out b);
                method2(n, out c, out d);
                string ans = d >= 0 ? d.ToString() : "Not exist";
                Console.WriteLine($"Base: {a}, Part: {b}, Square: {c}, Root: {ans}");
                Console.WriteLine("Press ESC to exit / ENTER to continue!");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
