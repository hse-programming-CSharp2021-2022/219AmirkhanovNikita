using System;

namespace Task01
{
    class Program
    {
        static void Print(char[] mas)
        {
            foreach (var item in mas)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        static int Shuffle(int a, int b) 
        {
            Random r = new Random();
            return r.Next(-1, 2);
        }

        static void Main(string[] args)
        {
            uint k;
            if(uint.TryParse(Console.ReadLine(), out k))
            {
                Random rnd = new Random();
                char[] arr = new char[k];
                for (int i = 0; i < k; i++)
                    arr[i] = (char)rnd.Next('A', 'Z' + 1);
                Print(arr);
                char[] arr2 = new char[k];
                Array.Copy(arr, arr2, k);
                Array.Sort(arr2);
                Print(arr2);
                Array.Reverse(arr2);
                Print(arr2);
            }
        }
    }
}
