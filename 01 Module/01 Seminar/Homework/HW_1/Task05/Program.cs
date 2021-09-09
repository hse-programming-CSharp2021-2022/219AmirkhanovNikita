using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            bool s = true;
            s &= double.TryParse(Console.ReadLine(), out x);
            s &= double.TryParse(Console.ReadLine(), out y);
            if (s)
            {
                Console.WriteLine(Math.Sqrt(x*x+y*y));
            }
        }
    }
}
