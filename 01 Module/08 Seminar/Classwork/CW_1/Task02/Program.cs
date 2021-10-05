using System;

namespace Task02
{
    class Program
    {

        static int Comp(int a, int b) => a < b ? 1 : -1;

        static int CompA(int[] a, int[] b) => a.Length < b.Length ? 1 : -1;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random(1);
            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[rnd.Next(5, 16)];
                for (int j = 0; j < arr[i].Length; j++)
                    arr[i][j] = rnd.Next(-10, 11);
            }
            foreach (var ar in arr)
            {
                foreach (var el in ar)
                    Console.Write($"{el} ");
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");
            for (int i = 0; i < n; i++)
                Array.Sort(arr[i], Comp);
            foreach (var ar in arr)
            {
                foreach (var el in ar)
                    Console.Write($"{el} ");
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");
            for (int i = 0; i < n; i++)
                Array.Sort(arr, CompA);
            foreach (var ar in arr)
            {
                foreach (var el in ar)
                    Console.Write($"{el} ");
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");
        }
    }
}
