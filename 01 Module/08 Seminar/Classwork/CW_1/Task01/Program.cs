using System;

namespace Task01
{
    class Program
    {

        static int Count(int n) => n == 0 ? 0 : 1 + Count(n / 10);

        static int Sum(int n) => n == 0 ? 0 : n % 10 + Sum(n / 10);

        static int CustomSortA(int a, int b)
        {
            if (a % 2 == 0 && b % 2 != 0) return -1;
            if (a % 2 != 0 && b % 2 == 0) return 1;
            else return 0;
        }

        static int CustomSortB(int a, int b) => Count(a) > Count(b) ? 1 : -1;
        static int CustomSortC(int a, int b) => Sum(a) > Sum(b) ? 1 : -1;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(0, 1001);
            Array.Sort(arr, CustomSortA);
            Array.ForEach(arr, el => Console.Write($"{el} "));
            Console.WriteLine("\n--------------------");
            Array.Sort(arr, CustomSortB);
            Array.ForEach(arr, el => Console.Write($"{el} "));
            Console.WriteLine("\n--------------------");
            Array.Sort(arr, CustomSortC);
            Array.ForEach(arr, el => Console.Write($"{el} "));
            Console.WriteLine("\n--------------------");
        }
    }
}
