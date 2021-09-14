using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        public static string r() => Console.ReadLine();


        static void Main(string[] args)
        {
            string ipt;
            uint n;
            do
            {
                ipt = r();
                if (!uint.TryParse(ipt, out n))
                {
                    Console.WriteLine("args error");
                    return;
                }
                else if (n < 1000 || n > 9999)
                {
                    Console.WriteLine("args error");
                    return;
                }
                string ou = string.Join("", ipt.ToCharArray().Reverse());
                Console.WriteLine(ou);
                Console.WriteLine("Press ESC to exit / ENTER to continue!");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
