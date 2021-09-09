using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            double U, R;
            bool s = true;
            s &= double.TryParse(Console.ReadLine(), out U);
            s &= double.TryParse(Console.ReadLine(), out R);
            if (s)
            {
                Console.WriteLine($"I = {U/R}");
                Console.WriteLine($"P = {(U*U) / R}");
            }
        }
    }
}
