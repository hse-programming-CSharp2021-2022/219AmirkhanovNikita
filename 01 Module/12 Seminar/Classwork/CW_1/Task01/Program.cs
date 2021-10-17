using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections;

namespace Task01
{
    class Program
    {

        static bool IsPal(int n)
        {
            string s = n.ToString();
            for (int i = 0; i < s.Length/2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                    return false;
            }
            return true;
        }

        static int Sum(int n)
        {
            int s = 0;
            while (n != 0)
            {
                s += n % 10;
                n /= 10;
            }
            return s;
        }

        static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            if (!uint.TryParse(Console.ReadLine(), out uint n))
                return;
            var arr = new int[n];
            var rnd = new Random(0);
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(1, 10001);
            var ans = new object[6];
            Print(arr);
            ans[0] = arr.Where(x => x % 3 == 0).Where(x => x.ToString().Length == 2).ToArray();
            ans[1] = arr.Where(x => IsPal(x)).ToArray();
            ans[2] = arr.OrderBy(x => Sum(x)).ThenBy(x => x).ToArray();
            ans[3] = arr.Where(x => x.ToString().Length == 4).Sum();
            ans[4] = arr.Where(x => x.ToString().Length == 2).DefaultIfEmpty().Min();
            ans[5] = arr.Select(
                x => x.ToString()
                .ToCharArray()
                .Select(y => int.Parse(y.ToString()))
                .DefaultIfEmpty().Max()
            ).ToArray();
            int a = 0;
            for(int i = 0; i < 6; i ++)
            {
                if (ans[i].GetType() == a.GetType())
                {
                    Console.WriteLine($"{i + 1}) {ans[i]}");
                }
                else
                {
                    Console.Write($"{i + 1})");
                    Print((int[])ans[i]);
                }
                    
            }
        }
    }
}
