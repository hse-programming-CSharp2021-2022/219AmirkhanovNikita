using System;

namespace Task01
{
    class Program
    {
        static uint Fact(uint n)
        {
            uint s = 1;
            for (uint i = 1; i <= n; i++)
                s *= i;
            return s;
        }
        static double Func(uint x, uint n) => Math.Pow(x, n) / Fact(n);
        static double[] SinGen(uint n)
        {
            double[] arr = new double[n];
            arr[0] = 1;
            for (uint i = 1, j = 3; i < n; i++,j+=2)
            {
                arr[i] = arr[i-1] + (i%2==0?1:-1)*Func(i + 1, j);
            }
            return arr;
        }

        static double Sin(uint x, double[] arr) => arr[x];
        static void Main(string[] args)
        {
            uint n;
            if (uint.TryParse(Console.ReadLine(), out n)) {
                double[] arr = SinGen(n);
                do
                {
                    uint x;
                    if (!uint.TryParse(Console.ReadLine(), out x)) return;
                    Console.WriteLine($"Custom sin: {Sin(x,arr)} | Math.Sin: {Math.Sin(x)}");
                } while (true); 
            }
        }
    }
}
