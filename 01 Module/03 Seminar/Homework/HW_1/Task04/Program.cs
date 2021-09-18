using System;
using System.Collections.Generic;

namespace Task04
{
    class Program
    {
        public static int Len(int n) => n.ToString().Length;
        static void Main(string[] args)
        {
            int[] aud = new int[10];
            string input;
            bool s = true;
            int n;
            for (int i = 0; i < 3; i++)
            {
                input = Console.ReadLine();
                s &= int.TryParse(input, out n);
                s &= n > 99 && n < 1000;
                if (!s) return;
                int a = int.Parse(input.Substring(1, 2));
                aud[n / 100] = aud[n / 100] == 0 ? a : Math.Min(aud[n/100], a);

            }
            for (int i = 0; i < 10; i++)
            {
                if (aud[i] > 0)
                {
                    string ans = Len(aud[i]) == 1 ? '0' + aud[i].ToString() : aud[i].ToString();
                    Console.WriteLine($"{i}{ans}");
                    break;
                }
            }
           

        }
    }
}
