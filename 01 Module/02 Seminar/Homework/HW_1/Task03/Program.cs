using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {

        public static double f(string c) => double.Parse(c);
        public static string r() => Console.ReadLine();

        static void Main(string[] args)
        {
            // ax2 +bx +c = 0
            double a, b, c, x, d;
            a = f(r());
            b = f(r());
            c = f(r());
            d = (b * b) - (4 * a * c);
            switch (d)
            {
                case 0:
                    break;
                default:
                    break;
            }
        }
    }
}
