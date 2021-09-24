using System;

namespace Task02
{
    class Program
    {
        static void Shift(int[] n, int pos)
        {
            for (int i = pos; i < n.Length-1; i++)
                n[i] = n[i + 1];
        }
        static int[] Zip(int[] n)
        {
            int arrSize = n.Length;
            for (int i = 0; i < n.Length-1; i++)
            {
                if ((n[i] + n[i+1]) % 3 == 0)
                {
                    n[i] = n[i] * n[i + 1];
                    i++;
                    Shift(n, i);
                    arrSize--;
                }
            }
            int[] res = new int[arrSize];
            for (int i = 0; i < arrSize; i++)
                res[i] = n[i];
            return res;
        }
        static void Main(string[] args)
        {
            int[] a = new int[6] { 1, 2, 3, 4, 5, 6 };
            foreach (var item in Zip(a))
            {
                Console.Write($"{item} ");
            }
        }
    }
}
