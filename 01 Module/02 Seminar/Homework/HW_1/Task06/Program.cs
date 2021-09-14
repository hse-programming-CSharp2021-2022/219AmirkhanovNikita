using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {

        public static string r() => Console.ReadLine();

        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("en-us");
            decimal amount;
            int percent;
            bool s = true;
            do
            {
                Console.WriteLine("amount , percent:");
                s &= decimal.TryParse(r(), out amount);
                s &= int.TryParse(r(), out percent);
                if (!s) // if для проверки значений
                {
                    Console.WriteLine("args error");
                    return;
                }
                amount = amount / 100 * percent;

                Console.WriteLine(amount.ToString("C", ci));
                Console.WriteLine("Press ESC to exit / ENTER to continue!");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
