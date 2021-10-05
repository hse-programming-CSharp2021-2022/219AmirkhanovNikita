using System;

namespace Task03
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
            Array.Resize(ref mas, 100);
            mas[99] = mas[rnd.Next(0, 99)];
            Array.Sort(mas, Shuffle);
            Print(mas);
            int sCheck = 5050;
            int s = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                s += mas[i];
            }
            
            Console.WriteLine(s);
        }
    }
}
