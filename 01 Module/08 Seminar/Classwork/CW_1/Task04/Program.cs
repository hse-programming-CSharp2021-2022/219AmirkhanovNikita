using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            int c = 0;
            int r = 0;
            int shiftR = 0;
            int shiftC = 0;
            int mode = 0; // 0 -> ; 1 \/ ; 2 <- ; 3 /\;  
            for (int i = 0; i < n * n; i++)
            {
                a[c, r] = i + 1;
                switch (mode)
                {
                    case 0:
                        r++;
                        break;
                    case 1:
                        c++;
                        break;
                    case 2:
                        r--;
                        break;
                    case 3:
                        c--;
                        break;
                }
                if (r >= n-shiftR)
                {
                    mode = 1;
                    c++;
                    r--;
                }
                if (c >= n)
                {
                    mode = 2;
                    r--;
                    c--;
                }
                if (i > 0 && r < shiftR)
                {
                    mode = 3;
                    c--;
                    r++;
                }
                if (i > 0 && c < 0)
                {
                    mode = 0;
                    c++;
                    r+=2;
                    shiftR++;
                }
                for (int FUCK = 0; FUCK < n; FUCK++)
                {
                    for (int FUCK2 = 0; FUCK2 < n; FUCK2++)
                    {
                        Console.Write($"{a[FUCK, FUCK2]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("-------------------");
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
