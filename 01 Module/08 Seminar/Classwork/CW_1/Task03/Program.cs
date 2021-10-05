using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            int c = 0;
            int r = 0;
            bool rev = false;
            for (int i = 0; i < n*n; i++)
            {
                a[c, r] = i + 1;
                r += rev ? -1 : 1;
                if (r >= n)
                {
                    c++;
                    rev = true;
                    r--;
                }
                if (i>0 && r<0)
                {
                    c++;
                    rev = false;
                    r++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
