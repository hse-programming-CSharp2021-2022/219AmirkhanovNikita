using System;

namespace Task02
{
    class Program
    {
        static void Print(int[] mas)
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
            Random rnd = new Random();
            int[] mas = new int[100];
            for (int i = 0; i < mas.Length; i++)
                mas[i] = i + 1;
            Array.Sort(mas, Shuffle);
            Array.Resize(ref mas, 99);
            Print(mas);

            int s = 5050;
            for (int i = 0; i < mas.Length; i++)
            {
                s -= mas[i];
            }
            Console.WriteLine(s);
        }
    }
}
