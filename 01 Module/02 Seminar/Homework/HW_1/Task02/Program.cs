using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {

        public static uint a(char c) => uint.Parse(c.ToString());

        static void Main(string[] args)
        {
            uint n;
            string ipt;
            do
            {
                ipt = Console.ReadLine();
                if (!uint.TryParse(ipt, out n))
                {
                    Console.WriteLine("Args error");
                    return;
                }
                else if (n > 999 || n < 100)
                {
                    Console.WriteLine("Args error");
                    return;
                }
                List<uint> l = new List<uint>(3) { a(ipt[0]), a(ipt[1]), a(ipt[2]) };
                l.Sort();
                l.Reverse();
                Console.WriteLine(string.Join("", l));
                Console.WriteLine("Press ESC to exit / ENTER to continue!");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);


        }
    }
}
