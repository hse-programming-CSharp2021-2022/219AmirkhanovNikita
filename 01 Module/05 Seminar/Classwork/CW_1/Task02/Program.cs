using System;

namespace Task02
{
    class Program
    {
        public static double S(uint k)
        {
            double s = 0;
            for (int i = 1; i <= k; i++)
            {
                s += (i + 0.3) / (3 * i * i + 5);
         
            }
            return s;
        } 
        static void Main(string[] args)
        {
            uint k = uint.Parse(Console.ReadLine());
            for (uint i = 1; i <= k; i++)
            {
                Console.WriteLine($"{i} = {S(i)}");
            }
        }
    }
}
