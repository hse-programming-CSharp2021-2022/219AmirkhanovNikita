﻿using System;

namespace Task04
{
    class Program
    {

        static int Akkerman(int m, int n)
        {
            if (m == 0) return n + 1;
            else if (n == 0) return Akkerman(m - 1, 1);
            else return Akkerman(m - 1, Akkerman(m, n - 1));
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Akkerman(4,0));
        }
    }
}
