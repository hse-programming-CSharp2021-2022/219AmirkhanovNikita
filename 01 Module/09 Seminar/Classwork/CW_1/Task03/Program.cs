using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task03
{
    class Program
    {
        static string M1(string s)
        {
            string pee = s.Trim();
            string[] poo = pee.Split();
            var sb = new StringBuilder();
            foreach (var item in poo)
            {
                if (item != "")
                {
                    sb.Append(item);
                    sb.Append(' ');
                }

            }
            return sb.ToString().Trim();
        }

        static int M2(string s)
        {
            string pee = s.Trim();
            string[] poo = pee.Split();
            int c = 0;
            foreach (var item in poo)
            {
                if (item.Length > 4)
                    c++;
            }
            return c;
        }

        static int M3(string s)
        {
            char[] aa = { 'а', 'я', 'е', 'у', 'о', 'и', 'э', 'ё' };
            string pee = s.Trim();
            string[] poo = pee.Split();
            int c = 0;
            foreach (var item in poo)
            {
                if (item.IndexOfAny(aa) == 0)
                    c++;
            }
            return c;
        }

        static void Main(string[] args)
        {
            string i = Console.ReadLine();
            Console.WriteLine(M1(i));
            Console.WriteLine(M2(i));
            Console.WriteLine(M3(i));
        }
    }
}
