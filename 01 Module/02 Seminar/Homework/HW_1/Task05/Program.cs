using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {

        public static string r() => Console.ReadLine();

        static void Main(string[] args)
        {
            double a, b, c;
            bool s = true;
            bool d = true;
            do
            {
                Console.WriteLine("a,b,c:");
                s &= double.TryParse(r(), out a);
                s &= double.TryParse(r(), out b);
                s &= double.TryParse(r(), out c);
                if (!s) // if для проверки значений!
                {
                    Console.WriteLine("args error");
                    return;
                }
                d &= a < b + c;
                d &= b < c + a;
                d &= c < a + b;
                string ans = d ? "Exists" : "Dont exist";
                Console.WriteLine(ans);
                Console.WriteLine("Press ESC to exit / ENTER to continue!");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
